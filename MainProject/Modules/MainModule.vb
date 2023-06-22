Imports System.Data.SqlClient 'استيراد مكتبة السيكوال سيرفر
Imports System.Configuration 'استيراد المكتبة المسئولة عن التشفير وفك التشفير
Imports System.Text.RegularExpressions

Module MainModule

    Public UserID As Int16 'متغير لحفظ رقم المستخدم
    Public UserName As String 'متغير لحفظ اسم المستخدم
    Public GroupID As Int16 'كود رقم الجروب الخاص بالمستخدم

    Public SQLCon As New SqlConnection 'جملة الاتصال الرئيسية للبرنامج(connString)


    Dim DecryptedString As String
    Dim encryptedString As String

    ''' <summary>
    ''' دالة استدعاء فورمات التاريخ
    ''' الحالة الأولى ارسال رقم 1 وتعني كامل التاريخ ووالوقت
    ''' الحالة الثانية ارسال رقم 2 وتعني التاريخ فقط
    ''' الحالة الثالثة ارسال رقم 3 وتعني الوقت فقط
    ''' الحالة الرابعة ارسال رقم 4 وتعني ارسال فورمات مخصص
    ''' </summary>
    ''' <param name="FullFormat"></param>
    ''' <returns></returns>
    Public Function ServerDate(ByVal DateStatus As Int16, Optional CustomFormat As String = Nothing, Optional RD As String = Nothing) As String

        Dim gt As New ClassMain
        gt.DoSelect("SELECT GETDATE()")

        Select Case DateStatus

            Case 1
                RD = Format(CDate(gt.DT(0)(0)), "yyyy/MM/dd hh:mm:ss")
            Case 2
                RD = Format(CDate(gt.DT(0)(0)), "yyyy/MM/dd")
            Case 3
                RD = Format(CDate(gt.DT(0)(0)), "hh:mm:ss")
            Case 4

                RD = Format(CDate(gt.DT(0)(0)), CustomFormat)
        End Select

        Return RD

    End Function
    '====================================================================================================

    '====================================================================================================
    ''' <summary>
    ''' دالة تفريغ التيكستات والكومبو بوكس
    ''' تأخذ متغير واحد اسم الفورم
    ''' </summary>
    ''' <param name="frm"></param> متغير من نوع فورم
    Public Sub ClearForm(frm As Form)
        Dim ctrl As Control
        For Each ctrl In frm.Controls
            If TypeOf ctrl Is TextBox Then
                ctrl.Text = ""
            ElseIf TypeOf ctrl Is ComboBox Then
                ctrl.Text = ""
            End If
        Next ctrl
    End Sub
    '====================================================================================================


    ''' <summary>
    ''' دالة تشفير أي نص
    ''' </summary>
    ''' <param name="EncryptString"></param> ارسال القيمة المراد تشفيرها
    ''' <returns></returns>
    Public Function Encrypt(EncryptString As String) As String


        ' تحويل النص العادي إلى بايت باستخدام UTF-8
        Dim bytes As Byte() = System.Text.Encoding.UTF8.GetBytes(EncryptString)

        ' تحويل البايتات إلى تشفير Base64
        encryptedString = System.Convert.ToBase64String(bytes)


        Return encryptedString

    End Function


    ''' <summary>
    ''' دالة فك التشفير
    ''' </summary>
    ''' <param name="DecryptString"></param>ارسال النص المشفر
    ''' <returns></returns>
    Public Function Decrypt(DecryptString As String) As String
        Try


            Dim DecryptedBytes As Byte() = System.Convert.FromBase64String(DecryptString)

            ' تحويل البايتات إلى النص العادي باستخدام UTF-8
            DecryptedString = System.Text.Encoding.UTF8.GetString(DecryptedBytes)
        Catch ex As Exception

            If ex.HResult = -2146233033 Then


                ' إنشاء كائن لقراءة ملف الكونفيج
                Dim config As Configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None)


                ' تحديث قيمة جملة الاتصال في ملف الكونفيج
                config.ConnectionStrings.ConnectionStrings("MainProject.MySettings.SQLCon").ConnectionString = Encrypt(DecryptString).ToString

                ' حفظ التغييرات في ملف الكونفيج
                config.Save()


            End If

        End Try

        Return DecryptedString

    End Function




    Public Function ValidatePassword(password As String) As Boolean
        ' Define password validation regular expression pattern
        Dim pattern As String = "^(?=.*[A-Z])(?=.*[a-z])(?=.*\d)(?=.*\W).{8,16}$"

        ' Create regex object and match the pattern with the password string
        Dim regex As New Regex(pattern)
        Dim match As Match = regex.Match(password)

        ' Return whether the password matches the pattern or not
        Return match.Success
    End Function

End Module
