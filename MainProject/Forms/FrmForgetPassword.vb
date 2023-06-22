Imports System.Data.SqlClient
Imports DevExpress.XtraEditors.Controls

Public Class FrmForgetPassword

    Private Sub LoginBtn_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles LoginBtn.ButtonClick
        Dim ForgetPassword As New ClassMain
        ForgetPassword.DoSelect("SELECT * FROM Sett.Users WHERE LoginName = '" & LoginNameTextEdit.Text & "' AND
                                 Email = '" & EmailTextEdit.Text & "' AND Mobile = '" & MobileTextEdit.Text & "'")

        If SQLCon.State = ConnectionState.Closed Then SQLCon.Open()
        Dim command As New SqlCommand("dbo.SendEmail", SQLCon)
        command.CommandType = CommandType.StoredProcedure
        command.Parameters.AddWithValue("@ToEmail", ForgetPassword.DT(0)("Email").ToString)
        command.Parameters.AddWithValue("@Subject", "إستعادة كلمة السر")
        command.Parameters.AddWithValue("@Body", "<html><body><h1>كود التفعيل الخاص باستعادة كلمة السر</h1></body></html>")
        command.ExecuteNonQuery()



        UserID = ForgetPassword.DT(0)("UserID").ToString & Nothing
        If (ForgetPassword.DT(0)("GroupID").ToString) <> Nothing Then
            GroupID = ForgetPassword.DT(0)("GroupID").ToString & Nothing
        End If
        UserName = ForgetPassword.DT(0)("UserName").ToString & Nothing

        If ForgetPassword.DT.Rows.Count > 0 Then
            FrmConfirmPassword.Show(FrmLogin)
            Me.Close()
        Else
            MsgBox("بعض البيانات التي تم إدخالها غير صحيحة", vbCritical, Application.ProductName)
            LoginNameTextEdit.Focus()
        End If

    End Sub


End Class