
Imports System.ComponentModel
Imports System.Configuration
Imports System.Security


Public Class FrmRegistration

    Private Sub FrmRegistration_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            TxtServerName.Text = My.Settings.ServerName
            TxtSqlDataBaseName.Text = My.Settings.DB
            TxtSqlUserName.Text = My.Settings.UserName

            Label1.Text = Application.ProductName


            If (TxtServerName.Text <> "اسم السيرفر" And TxtServerName.Text <> String.Empty) Then
                TxtServerName.ForeColor = Color.Black
            End If

            If (TxtSqlDataBaseName.Text <> "قاعدة البيانات" And TxtSqlDataBaseName.Text <> String.Empty) Then
                TxtSqlDataBaseName.ForeColor = Color.Black
            End If

            If (TxtSqlUserName.Text <> "اسم المستخدم" And TxtSqlUserName.Text <> String.Empty) Then
                TxtSqlUserName.ForeColor = Color.Black
            End If

            If (TxtSqlPassword.Text <> "كلمة المرور" And TxtSqlPassword.Text <> String.Empty) Then
                TxtSqlPassword.ForeColor = Color.Black
                TxtSqlPassword.PasswordChar = "*"
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            TxtServerName.ReadOnly = False
            TxtSqlDataBaseName.ReadOnly = False
            TxtSqlUserName.ReadOnly = False
            TxtSqlPassword.ReadOnly = False

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub TxtServerName_Enter(sender As Object, e As EventArgs) Handles TxtSqlUserName.Enter, TxtSqlDataBaseName.Enter, TxtServerName.Enter, TxtSqlPassword.Enter
        Try
            Dim TxtBox As TextBox = CType(sender, TextBox)
            If TxtBox.Text = "اسم السيرفر" Or TxtBox.Text = "قاعدة البيانات" Or TxtBox.Text = "اسم المستخدم" Or TxtBox.Text = "كلمة المرور" Then
                TxtBox.Text = String.Empty
                TxtBox.ForeColor = Color.Black

                ErrorProvider1.Clear()
                If TxtBox.Name = "TxtSqlPassword" Then
                    TxtSqlPassword.PasswordChar = "*"
                End If
            End If
            If Not TxtBox.Text = String.Empty Then
                TxtBox.ForeColor = Color.Black
            End If

            TxtBox.SelectAll()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub TxtServerName_Leave(sender As Object, e As EventArgs) Handles TxtSqlUserName.Leave, TxtSqlDataBaseName.Leave, TxtServerName.Leave, TxtSqlPassword.Leave
        Try
            Dim TxtBox As TextBox = CType(sender, TextBox)

            If TxtBox.Text = String.Empty Then
                If TxtBox.Name = "TxtServerName" Then
                    TxtBox.Text = "اسم السيرفر"
                    TxtBox.ForeColor = Color.DarkGray
                End If

                If TxtBox.Name = "TxtSqlDataBaseName" Then
                    TxtBox.Text = "قاعدة البيانات"
                    TxtBox.ForeColor = Color.DarkGray
                End If


                If TxtBox.Name = "TxtSqlUserName" Then
                    TxtBox.Text = "اسم المستخدم"
                    TxtBox.ForeColor = Color.DarkGray
                End If

                If TxtBox.Name = "TxtSqlPassword" Then
                    TxtBox.Text = "كلمة المرور"
                    TxtBox.ForeColor = Color.DarkGray
                    TxtSqlPassword.PasswordChar = "*"
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BtnRegistration_Click(sender As Object, e As EventArgs) Handles BtnRegistration.Click
        Try
            If TxtServerName.ForeColor = Color.DarkGray Then
                ErrorProvider1.SetError(TxtServerName, "برجاء ادخال اسم السيرفر")
                Return
            End If

            If TxtSqlDataBaseName.ForeColor = Color.DarkGray Then
                ErrorProvider1.SetError(TxtSqlDataBaseName, "برجاء ادخال اسم قاعدة البيانات")
                Return
            End If

            If TxtSqlUserName.ForeColor = Color.DarkGray Then
                ErrorProvider1.SetError(TxtSqlUserName, "برجاء ادخال اسم المستخدم")
                Return
            End If

            If TxtSqlPassword.ForeColor = Color.DarkGray Then
                ErrorProvider1.SetError(TxtSqlPassword, "برجاء ادخال كلمة المرور")
                Return
            End If




            ' إنشاء كائن لقراءة ملف الكونفيج
            Dim config As Configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None)

            Dim connstring As String

            ' تغيير قيمة جملة الاتصال مع تشفير كلمة المرور
            connstring = ("Data Source= " & TxtServerName.Text & " ;Initial Catalog=" & TxtSqlDataBaseName.Text & ";User ID=" & TxtSqlUserName.Text & " ; Password = " & TxtSqlPassword.Text & " ")

            Encrypt(connstring)


            ' تحديث قيمة جملة الاتصال في ملف الكونفيج
            config.ConnectionStrings.ConnectionStrings("MainProject.MySettings.SQLCon").ConnectionString = Encrypt(connstring)

            ' حفظ التغييرات في ملف الكونفيج
            config.Save()


            My.Settings.ServerName = TxtServerName.Text
            My.Settings.DB = TxtSqlDataBaseName.Text
            My.Settings.UserName = TxtSqlUserName.Text
            My.Settings.Save()


            MsgBox(" تم تسجيل بيانات السيرفر بنجاح يجب إعادة تشغيل البرنامج لتفعيل الإعدادادت الجديدة")

            Application.Exit()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub FrmRegistration_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Try
            FrmLogin.Show()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub TimerEndFrmLogin_Tick(sender As Object, e As EventArgs) Handles TimerEndFrmLogin.Tick
        FrmLogin.Hide()
    End Sub

End Class