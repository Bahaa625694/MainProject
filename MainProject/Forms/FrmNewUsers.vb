Imports System.IO

Public Class FrmNewUsers
    Private Sub LoginBtn_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles LoginBtn.ButtonClick
        Dim NewUsers As New ClassMain

        Dim UsersValue As New Dictionary(Of String, Object)
        UsersValue.Add("UserName", UserNameTextEdit.EditValue)
        UsersValue.Add("LoginName", LoginNameTextEdit.EditValue)
        UsersValue.Add("Password", Encrypt(PasswordTextEdit.EditValue))
        UsersValue.Add("Email", EmailTextEdit.EditValue)
        UsersValue.Add("Mobile", MobileTextEdit.EditValue)

        Dim ms As New MemoryStream()
        PhotoPictureEdit.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
        Dim imageBytes As Byte() = ms.ToArray()

        UsersValue.Add("Photo", imageBytes)
        NewUsers.DoAction("Sett.Users", UsersValue, Nothing, Nothing)

        If NewUsers.RMassage = "OK" Then
            MsgBox("تم تسجيل بيانات المستخدم بنجاح برجاء الإنتظار لحين مراجعة البيانات والموافقة عليها", vbInformation, Application.ProductName)
            Me.Close()
        Else
            MsgBox("حدث خطأ أثناء عملية نقل البيانات برجاء المحاولة لاحقاً", vbCritical, Application.ProductName)
        End If
    End Sub



    Private Sub PasswordTextEdit_Leave(sender As Object, e As EventArgs) Handles PasswordTextEdit.Leave
        Dim password As String = PasswordTextEdit.Text

        If ValidatePassword(password) Then
            ' Password is valid, proceed with login
        Else
            ' Password is not valid, show error message

            'PasswordTextEdit.DoValidate()
            PasswordTextEdit.ErrorText = "كلمة مرور غير مطابقة للمعايير يجب أن تحتوي على حرف كبير وحرف صغير ورقم واحد ورمز مخصص ويكون طول كلمة المرور بين 8 ل 16 رقم"
            'MessageBox.Show("Invalid password. Password must contain at least one uppercase letter, one lowercase letter, one digit, one special character, and must be between 8 and 16 characters long.")
            PasswordTextEdit.Focus()
        End If
    End Sub

    Private Sub LoginBtn_EditValueChanged(sender As Object, e As EventArgs) Handles LoginBtn.EditValueChanged

    End Sub
End Class