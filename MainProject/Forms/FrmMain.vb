Imports System.ComponentModel
Imports System.Text


Partial Public Class FrmMain
    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ribbonControl1_Click(sender As Object, e As EventArgs) Handles ribbonControl1.Click

    End Sub

    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick

        FrmCourseEmp.ShowDialog()



    End Sub

    Private Sub FrmMain_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

        If MsgBox("هل تريد إنهاء البرنامج", vbCritical + vbYesNo, Application.ProductName) = MsgBoxResult.Yes Then
            Application.Exit()
        Else
            e.Cancel = True

        End If



    End Sub
End Class
