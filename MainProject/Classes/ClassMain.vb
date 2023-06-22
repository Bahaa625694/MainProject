Imports System.Collections
Imports System.Data.SqlClient
Imports System.IO   ' التعامل مع الملفات مثل القراءة والكتابة والحذف والإنشاء والنسخ وغيرها. لذلك

Public Class ClassMain
    Public Cmd As New SqlClient.SqlCommand      'جملة استعلام سيكوال سيرفر
    Public DT As New DataTable                  'نسخة من الدتا تيبل
    Public RMassage As String

    '====================================================================================================
    ''' <summary>
    ''' معادلة للرجوع ببيانات أي جدول من قاعدة البيانات
    ''' يتم ارسال جملة السيليكت لها لتقوم بجلب الداتا من قاعدة البيانات
    ''' </summary>
    ''' <param name="CmdText"></param>
    ''' <returns></returns>
    Public Function DoSelect(CmdText As String) As DataTable
        Try
            DT.Rows.Clear()
            DT.Columns.Clear()
            Dim da As New SqlDataAdapter(CmdText, SQLCon)
            da.Fill(DT)
        Catch ex As Exception
            If ex.HResult = -2146232060 Then
            End If
        End Try
        Return DT
    End Function
    '====================================================================================================

    '====================================================================================================
    ''' <summary>
    ''' دالة تستخدم في حالة عمل حذف لبيان من قاعدة البيانات
    ''' تسخدم 3 بارميترات أساسية 
    ''' يجب ارسال اسم الجدول
    ''' يجب ارسال اسم الحقل المحتوي على الأي دي
    ''' يجب ارسال رقم الأي دي الذي سيتم الحذف بدلالته
    ''' </summary>
    ''' <param name="TableName"></param> 'بارميتر اسم الجدول المراد الحذف منه
    ''' <param name="ColumnID"></param> ' اسم الحقل المحتوي على الأي دي
    ''' <param name="ID"></param> ,بارميتر رقم الأي دي الذي سيتم الحذف بدلالته
    Public Sub DoAction(ByVal TableName As String, ByVal ColumnID As String, ByVal ID As String)
        Try
            Cmd.Connection = SQLCon
            Cmd.CommandType = CommandType.Text
            Cmd.Parameters.Clear()

            Cmd.CommandText = "DELETE FROM '" & TableName & "'  WHERE '" & ColumnID & "' = '" & ID & "'  "

            If SQLCon.State = ConnectionState.Closed Then SQLCon.Open()
            Cmd.ExecuteNonQuery()
            Cmd.Parameters.Clear()
            RMassage = "OK"

        Catch ex As Exception
            'MsgBox(ex.HResult)
            If ex.HResult = -2146232060 Then
                MsgBox("لا يمكن تنفيذ هذا الإجراء", vbCritical, Application.ProductName)
                Dim WLF As New ClassMain
                WLF.WriteLogFile("ClassMain", System.Reflection.MethodBase.GetCurrentMethod.Name, ex.Message)
            End If

        End Try

        SQLCon.Close()
    End Sub
    '====================================================================================================

    '====================================================================================================
    ''' <summary>
    ''' دالة تستخدم في حالة عمل إضافة وتعديل لبيان من قاعدة البيانات
    ''' مطلوب فيها 4 بارميترات
    ''' </summary>
    ''' <param name="TableName"></param> اسم الجدول المطلوب عمل الأكشن عليه
    ''' <param name="values"></param> القيم المراد إدخالها
    ''' <param name="ColumnID"></param> اسم حقل الأي دي
    ''' <param name="RecordID"></param> قيمة حقل الأي دي
    Public Sub DoAction(TableName As String, values As Dictionary(Of String, Object), ColumnID As String, RecordID As String)

        Cmd.Connection = SQLCon
        Cmd.CommandType = CommandType.Text
        Cmd.Parameters.Clear()

        Dim Columns As String = String.Join(",", values.Keys)
        Dim ParameterNames As String = String.Join(",", values.Keys.Select(Function(k) $"@{k}"))
        Dim QueryInsert As String = $"INSERT INTO {TableName} ({Columns}) VALUES ({ParameterNames})"


        Dim SetStatements As String = String.Join(",", values.Keys.Select(Function(k) $"{k} = @{k}"))
        Dim QueryUpdate As String = $"UPDATE {TableName} SET {SetStatements} WHERE {ColumnID} = @id"


        Select Case RecordID

            Case Nothing
                Cmd.CommandText = queryInsert
                For Each kvp As KeyValuePair(Of String, Object) In values
                    Cmd.Parameters.AddWithValue($"@{kvp.Key}", kvp.Value)
                Next

            Case = RecordID

                Cmd.CommandText = QueryUpdate
                Cmd.Parameters.AddWithValue("@id", RecordID)
                For Each kvp As KeyValuePair(Of String, Object) In values
                    Cmd.Parameters.AddWithValue($"@{kvp.Key}", kvp.Value)
                Next

        End Select


        If SQLCon.State = ConnectionState.Closed Then SQLCon.Open()
        Cmd.ExecuteNonQuery()
        Cmd.Parameters.Clear()
        SQLCon.Close()
        RMassage = "OK"
    End Sub


    '====================================================================================================
    'يوضع بالكلاس مين
    Public Sub WriteLogFile(ByVal FrmName As String, ByVal EventsName As String, ByVal ErrorM As String)

        Dim x As String = "التاريخ:" & " " & Format(Now, "yyyy/MM/dd hh:mm:ss t") & " " & "اسم النافذة:" & " " & FrmName & " " & "اسم الحدث:" & " " & EventsName & " " & "بيانات الخطأ:" & " " & ErrorM & Environment.NewLine
        File.AppendAllText(AppDomain.CurrentDomain.BaseDirectory & "LogFile", x)

    End Sub
    '====================================================================================================


    Public Function Authorization(Validate As String) As Boolean
        Dim AuthB As Boolean
        Dim Auth As New ClassMain
        Auth.DoSelect("SELECT * FROM Sett.Groups WHERE GroupID = '" & GroupID & "' ")

        If Auth.DT.Rows.Count < 1 Then

            MsgBox("غير مسموح لك بتنفيذ هذا الإجراء", vbCritical, Application.ProductName)
            AuthB = False
        Else



            If CBool(Auth.DT(0)(Validate)) = False Then
                MsgBox("غير مسموح لك بتنفيذ هذا الإجراء", vbCritical, Application.ProductName)
                AuthB = False
            Else
                AuthB = True
            End If
        End If
        Return AuthB
    End Function


End Class
