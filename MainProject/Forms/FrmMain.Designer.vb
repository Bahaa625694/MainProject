Partial Public Class FrmMain
    Inherits DevExpress.XtraBars.Ribbon.RibbonForm

    ''' <summary>
    ''' Required designer variable.
    ''' </summary>
    Private components As System.ComponentModel.IContainer = Nothing

    ''' <summary>
    ''' Clean up any resources being used.
    ''' </summary>
    ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso (components IsNot Nothing) Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

#Region "Windows Form Designer generated code"

    ''' <summary>
    ''' Required method for Designer support - do not modify
    ''' the contents of this method with the code editor.
    ''' </summary>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMain))
        Me.DefaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
        Me.RibbonPage4 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup4 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPage3 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup3 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPage2 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.ribbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.ribbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.ribbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DefaultLookAndFeel1
        '
        Me.DefaultLookAndFeel1.LookAndFeel.SkinName = "Lilian"
        '
        'RibbonPage4
        '
        Me.RibbonPage4.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RibbonPage4.Appearance.ForeColor = System.Drawing.Color.Maroon
        Me.RibbonPage4.Appearance.Options.UseFont = True
        Me.RibbonPage4.Appearance.Options.UseForeColor = True
        Me.RibbonPage4.Appearance.Options.UseTextOptions = True
        Me.RibbonPage4.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.RibbonPage4.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        Me.RibbonPage4.AppearanceSelected.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RibbonPage4.AppearanceSelected.ForeColor = System.Drawing.Color.Navy
        Me.RibbonPage4.AppearanceSelected.Options.UseFont = True
        Me.RibbonPage4.AppearanceSelected.Options.UseForeColor = True
        Me.RibbonPage4.AppearanceSelected.Options.UseTextOptions = True
        Me.RibbonPage4.AppearanceSelected.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.RibbonPage4.AppearanceSelected.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        Me.RibbonPage4.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup4})
        Me.RibbonPage4.Name = "RibbonPage4"
        Me.RibbonPage4.Text = "الإعـــدادات"
        '
        'RibbonPageGroup4
        '
        Me.RibbonPageGroup4.Name = "RibbonPageGroup4"
        Me.RibbonPageGroup4.Text = "RibbonPageGroup4"
        '
        'RibbonPage3
        '
        Me.RibbonPage3.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RibbonPage3.Appearance.ForeColor = System.Drawing.Color.Maroon
        Me.RibbonPage3.Appearance.Options.UseFont = True
        Me.RibbonPage3.Appearance.Options.UseForeColor = True
        Me.RibbonPage3.Appearance.Options.UseTextOptions = True
        Me.RibbonPage3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.RibbonPage3.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        Me.RibbonPage3.AppearanceSelected.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RibbonPage3.AppearanceSelected.ForeColor = System.Drawing.Color.Navy
        Me.RibbonPage3.AppearanceSelected.Options.UseFont = True
        Me.RibbonPage3.AppearanceSelected.Options.UseForeColor = True
        Me.RibbonPage3.AppearanceSelected.Options.UseTextOptions = True
        Me.RibbonPage3.AppearanceSelected.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.RibbonPage3.AppearanceSelected.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        Me.RibbonPage3.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup3})
        Me.RibbonPage3.Name = "RibbonPage3"
        Me.RibbonPage3.Text = "التقـاريــر"
        '
        'RibbonPageGroup3
        '
        Me.RibbonPageGroup3.Name = "RibbonPageGroup3"
        Me.RibbonPageGroup3.Text = "RibbonPageGroup3"
        '
        'RibbonPage2
        '
        Me.RibbonPage2.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RibbonPage2.Appearance.ForeColor = System.Drawing.Color.Maroon
        Me.RibbonPage2.Appearance.Options.UseFont = True
        Me.RibbonPage2.Appearance.Options.UseForeColor = True
        Me.RibbonPage2.Appearance.Options.UseTextOptions = True
        Me.RibbonPage2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.RibbonPage2.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        Me.RibbonPage2.AppearanceSelected.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RibbonPage2.AppearanceSelected.ForeColor = System.Drawing.Color.Navy
        Me.RibbonPage2.AppearanceSelected.Options.UseFont = True
        Me.RibbonPage2.AppearanceSelected.Options.UseForeColor = True
        Me.RibbonPage2.AppearanceSelected.Options.UseTextOptions = True
        Me.RibbonPage2.AppearanceSelected.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.RibbonPage2.AppearanceSelected.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        Me.RibbonPage2.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup2})
        Me.RibbonPage2.Name = "RibbonPage2"
        Me.RibbonPage2.Text = "الإستبيــان"
        '
        'RibbonPageGroup2
        '
        Me.RibbonPageGroup2.Name = "RibbonPageGroup2"
        Me.RibbonPageGroup2.Text = "RibbonPageGroup2"
        '
        'ribbonPage1
        '
        Me.ribbonPage1.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ribbonPage1.Appearance.ForeColor = System.Drawing.Color.Maroon
        Me.ribbonPage1.Appearance.Options.UseFont = True
        Me.ribbonPage1.Appearance.Options.UseForeColor = True
        Me.ribbonPage1.Appearance.Options.UseTextOptions = True
        Me.ribbonPage1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ribbonPage1.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        Me.ribbonPage1.AppearanceSelected.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ribbonPage1.AppearanceSelected.ForeColor = System.Drawing.Color.Navy
        Me.ribbonPage1.AppearanceSelected.Options.UseFont = True
        Me.ribbonPage1.AppearanceSelected.Options.UseForeColor = True
        Me.ribbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.ribbonPageGroup1})
        Me.ribbonPage1.Name = "ribbonPage1"
        Me.ribbonPage1.Text = "الدورة التدريبيــة للموظـف"
        '
        'ribbonPageGroup1
        '
        Me.ribbonPageGroup1.ItemLinks.Add(Me.BarButtonItem1)
        Me.ribbonPageGroup1.Name = "ribbonPageGroup1"
        Me.ribbonPageGroup1.Text = "ribbonPageGroup1"
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Id = 1
        Me.BarButtonItem1.ImageOptions.Image = CType(resources.GetObject("BarButtonItem1.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItem1.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItem1.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarButtonItem1.ItemAppearance.Normal.Options.UseTextOptions = True
        Me.BarButtonItem1.ItemAppearance.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        Me.BarButtonItem1.Name = "BarButtonItem1"
        Me.BarButtonItem1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'ribbonControl1
        '
        Me.ribbonControl1.EmptyAreaImageOptions.ImagePadding = New System.Windows.Forms.Padding(35, 37, 35, 37)
        Me.ribbonControl1.ExpandCollapseItem.Id = 0
        Me.ribbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.ribbonControl1.ExpandCollapseItem, Me.ribbonControl1.SearchEditItem, Me.BarButtonItem1})
        Me.ribbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.ribbonControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.ribbonControl1.MaxItemId = 2
        Me.ribbonControl1.Name = "ribbonControl1"
        Me.ribbonControl1.OptionsMenuMinWidth = 385
        Me.ribbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.ribbonPage1, Me.RibbonPage2, Me.RibbonPage3, Me.RibbonPage4})
        Me.ribbonControl1.Size = New System.Drawing.Size(1124, 192)
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1124, 591)
        Me.Controls.Add(Me.ribbonControl1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "FrmMain"
        Me.Ribbon = Me.ribbonControl1
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region
    Friend WithEvents DefaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
    Friend WithEvents RibbonPage4 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup4 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPage3 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup3 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPage2 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Private WithEvents ribbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Private WithEvents ribbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Private WithEvents ribbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
End Class
