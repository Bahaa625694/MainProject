﻿Public Class FrmIntro
    Sub New
        InitializeComponent()
        Me.labelCopyright.Text = "Copyright © 1998-" & DateTime.Now.Year.ToString()
    End Sub

    Public Overrides Sub ProcessCommand(ByVal cmd As System.Enum, ByVal arg As Object)
        MyBase.ProcessCommand(cmd, arg)
    End Sub

    Public Enum SplashScreenCommand
        SomeCommandId
    End Enum

    Private Sub peImage_EditValueChanged(sender As Object, e As EventArgs) Handles peImage.EditValueChanged

    End Sub

    Private Sub peLogo_EditValueChanged(sender As Object, e As EventArgs) 

    End Sub
End Class
