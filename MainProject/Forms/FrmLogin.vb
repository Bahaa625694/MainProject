Imports System.ComponentModel
Imports System.Configuration
Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel


Public Class FrmLogin
    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LblProductName.Text = Application.ProductName

        LblVersion.Text = "Version:" & Application.ProductVersion


        Try

            SQLCon.ConnectionString = Decrypt(ConfigurationManager.ConnectionStrings("MainProject.MySettings.SQLCon").ConnectionString)

            SQLCon.Open()

            If My.Settings.RememberMe = True Then
                UserNameTextBox.Text = My.Settings.UserAccounts
                PasswordTextBox.Text = Decrypt(My.Settings.UserPassword)
                RememberCheck.Checked = My.Settings.RememberMe

            End If

        Catch ex As Exception
            If ex.HResult = -2146232060 Or ex.HResult = -2147024809 Or ex.HResult = -2146233079 Then
                FrmRegistration.Show()
            End If
        Finally

            If SQLCon.State = ConnectionState.Open Then
                SQLCon.Close()
            End If
        End Try


    End Sub

    Private Sub LoginBtn_Click(sender As Object, e As EventArgs) Handles LoginBtn.Click
        Try

            Dim Log As New ClassMain
            Log.DoSelect("SELECT * from Sett.Users WHERE LoginName = '" & UserNameTextBox.Text & "' AND Password = '" & Encrypt(PasswordTextBox.Text) & "'")


            If Log.DT.Rows.Count < 1 Then
                MsgBox("اسم المستخدم أو كلمة المرور غير صحيحة", vbCritical, Application.ProductName)
                UserNameTextBox.Focus()
                Return
            End If


            If RememberCheck.Checked = True Then
                My.Settings.RememberMe = True
                My.Settings.UserAccounts = UserNameTextBox.Text
                My.Settings.UserPassword = Encrypt(PasswordTextBox.Text)
                My.Settings.Save()
            Else
                My.Settings.RememberMe = False
                My.Settings.Save()
            End If



            UserID = Log.DT(0)("UserID").ToString & Nothing
            If (Log.DT(0)("GroupID").ToString) <> Nothing Then
                GroupID = Log.DT(0)("GroupID").ToString & Nothing
            End If
            UserName = Log.DT(0)("UserName").ToString & Nothing


            'If CType(Log.DT(0)("MustChangePassword"), Boolean) = True Then
            '    FrmConfirmPassword.ShowDialog()
            '    Return
            'End If


            'كود الصلاحية
            If Log.Authorization("LogV") = True Then
                FrmMain.Show()
                Me.Hide()
            End If




        Catch ex As Exception
            If ex.HResult = -2146233036 Then
                FrmRegistration.Show()
                Me.Hide()
            End If
        End Try




    End Sub

    Private Sub HyperlinkLabelControl2_Click(sender As Object, e As EventArgs) Handles HyperlinkLabelControl2.Click
        FrmNewUsers.ShowDialog()
    End Sub

    Private Sub HyperlinkLabelControl1_Click(sender As Object, e As EventArgs) Handles HyperlinkLabelControl1.Click


        FrmForgetPassword.ShowDialog()

        'Dim command As New SqlCommand("dbo.SendEmail", SQLCon)
        'command.CommandType = CommandType.StoredProcedure
        'command.Parameters.AddWithValue("@ToEmail", "recipient@example.com")
        'command.Parameters.AddWithValue("@Subject", "Test email")
        'command.Parameters.AddWithValue("@Body", "<html><body><h1>Hello, world!</h1></body></html>")
        'command.ExecuteNonQuery()

    End Sub

    Private Sub LoginBtn_EditValueChanged(sender As Object, e As EventArgs) Handles LoginBtn.EditValueChanged

    End Sub
End Class