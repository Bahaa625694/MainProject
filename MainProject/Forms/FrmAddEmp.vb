Imports System.Data.SqlClient
Imports System.IO

Public Class FrmAddEmp

    Public ID As Integer = 0
    Public Folders As New OpenFileDialog
    Public ms1 As New MemoryStream()
    Public arrimg() As Byte
    Public Property Photo As PictureBox


    Private Sub BtnClose_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub FrmAddEmp_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click

        Try


            'If String.IsNullOrWhiteSpace(NumEmpTextEdit.Text) Then
            '    ErrorProvider1.SetError(NumEmpTextEdit, "رقم مؤسسةالموظف مطلوب")
            '    Return
            'Else
            '    ErrorProvider1.Clear()
            'End If

            'If String.IsNullOrWhiteSpace(NameEmpTextEdit.Text) Then
            '    ErrorProvider1.SetError(NameEmpTextEdit, "اسم الموظف مطلوب")
            '    Return
            'Else
            '    ErrorProvider1.Clear()
            'End If

            'If String.IsNullOrWhiteSpace(BirthDateTextEdit.Text) Then
            '    ErrorProvider1.SetError(BirthDateTextEdit, "تاريخ ميلادالموظف مطلوب")
            '    Return
            'Else
            '    ErrorProvider1.Clear()
            'End If


            'If String.IsNullOrWhiteSpace(CompanyCombobox.EditValue) Then
            '    ErrorProvider1.SetError(CompanyCombobox, "اسم الشركة مطلوب")
            '    Return
            'Else
            '    ErrorProvider1.Clear()
            'End If


            'If String.IsNullOrWhiteSpace(QualitiveCombo.EditValue) Then
            '    ErrorProvider1.SetError(QualitiveCombo, "المجموعة النوعية مطلوب")
            '    Return
            'Else
            '    ErrorProvider1.Clear()
            'End If

            'If String.IsNullOrWhiteSpace(QualificationTextEdit.Text) Then
            '    ErrorProvider1.SetError(QualificationTextEdit, "المؤهل الدراسى مطلوب")
            '    Return
            'Else
            '    ErrorProvider1.Clear()
            'End If


            'If String.IsNullOrWhiteSpace(ClassCombo.EditValue) Then

            '    ErrorProvider1.SetError(ClassCombo, "الدرجة الوظيفية مطلوب")
            '    Return
            'Else
            '    ErrorProvider1.Clear()
            'End If



            If DevExpress.XtraEditors.XtraMessageBox.Show("سيتم اضافة بيانات موظف جديد.هل تريد المواصـلة؟", "تنبيـه", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
                Exit Sub
            End If


            Dim Emp As New ClassMain
            Dim DF As New Dictionary(Of String, Object)

            'DF.Add("EmployeeName", TxtEmployeeName.Text.ToString)
            'DF.Add("GenderID", .EditValue)
            'DF.Add("QualificationID",   .Text.ToString)
            'DF.Add("SocialStatusID", .EditValue)
            'DF.Add("ReligionID", .EditValue)
            'DF.Add("Mobile1", .Text.ToString)
            'DF.Add("Mobile2",.Text.ToString)
            'DF.Add("Address", .Text.ToString)
            'DF.Add("ClassID", .EditValue)
            'DF.Add("JobID", .Text.ToString)
            'DF.Add("ManagmentID", .EditValue)
            'DF.Add("Email", .EditValue)
            'DF.Add("DateEmployment", .Text.ToString)
            'DF.Add("BirthDate", .Text.ToString)
            'DF.Add("MaritalStatusID", .EditValue)
            'DF.Add("Email", .EditValue)
            'DF.Add("EmpNationalNum",   .Text.ToString)
            'DF.Add("Notes", .Text.ToString)


            If PhotoEmp.Image.ToString <> Nothing Then
                Dim ms As New MemoryStream()
                PhotoEmp.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
                Dim imageBytes As Byte() = ms.ToArray()
                DF.Add("Photo", imageBytes)
            End If

            Emp.DoAction("Employees", DF, Nothing, Nothing)

            MsgBox("تم إضـافة بيانات الموظف بنجاح", vbInformation, Application.ProductName)

        Catch ex As Exception
            Dim WError As New ClassMain
            WError.WriteLogFile(Me.Name, System.Reflection.MethodBase.GetCurrentMethod.Name, ex.HResult & " " & ex.Message)
        End Try



    End Sub



    Private Sub PhotoEmp_Click(sender As Object, e As EventArgs) Handles PhotoEmp.Click
        Try

            Dim ms1 As New MemoryStream()
            Folders.Filter = "(Image Files)|*.jpg;*.png;*.bmp;*.gif;*.ico|Jpg | *.jpg|Png | *.png|Bmp | *.bmp|Gif | *.gif|Ico | *.ico"
            Folders.Multiselect = False
            Folders.Title = "اختيار المرفق"


            If Folders.ShowDialog = DialogResult.OK Then

                Dim FN As String

                FN = Format(Now, "dMy") & 0 & Path.GetExtension(Folders.FileName)

                PhotoEmp.Image = Image.FromFile(Folders.FileName)

                PhotoEmp.Image.Save(ms1, PhotoEmp.Image.RawFormat)
                arrimg = ms1.GetBuffer
                ms1.Close()

            End If

        Catch ex As Exception
            Dim WLF As New ClassMain
            WLF.WriteLogFile(Name, System.Reflection.MethodBase.GetCurrentMethod.Name, ex.Message)

        End Try


    End Sub

    Private Sub TxtEmployeeID_EditValueChanged(sender As Object, e As EventArgs) Handles TxtEmployeeID.EditValueChanged

    End Sub

    Private Sub TxtEmployeeID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtEmployeeID.KeyPress

        If Char.IsDigit(e.KeyChar) = False Then
            e.Handled = True

        End If
        If Char.IsControl(e.KeyChar) = True Then
            e.Handled = False
        End If


    End Sub
End Class