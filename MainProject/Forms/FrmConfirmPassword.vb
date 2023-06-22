Public Class FrmConfirmPassword
    Private Sub LoginBtn_Click(sender As Object, e As EventArgs) Handles LoginBtn.ButtonClick

        If DxValidationProvider1.Validate = True Then

            Dim ChangePassword As New ClassMain

            Dim Password As New Dictionary(Of String, Object)

            Password.Add("Password", Encrypt(PasswordTextBox.Text))

            Password.Add("MustChangePassword", False)

            ChangePassword.DoAction("Sett.Users", Password, "UserID", UserID)

            Me.Close()

        End If
    End Sub



    Private Sub PasswordTextBox_Leave(sender As Object, e As EventArgs) Handles PasswordTextBox.Leave
        Dim password As String = PasswordTextBox.Text

        If ValidatePassword(password) Then
            ' Password is valid, proceed with login
        Else
            ' Password is not valid, show error message

            'PasswordTextEdit.DoValidate()
            PasswordTextBox.ErrorText = "كلمة مرور غير مطابقة للمعايير يجب أن تحتوي على حرف كبير وحرف صغير ورقم واحد ورمز مخصص ويكون طول كلمة المرور بين 8 ل 16 رقم"
            'MessageBox.Show("Invalid password. Password must contain at least one uppercase letter, one lowercase letter, one digit, one special character, and must be between 8 and 16 characters long.")
            PasswordTextBox.Focus()
        End If
    End Sub


End Class