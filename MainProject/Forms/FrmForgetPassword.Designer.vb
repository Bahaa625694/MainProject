<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmForgetPassword
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim EditorButtonImageOptions1 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject2 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject3 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject4 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmForgetPassword))
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.LoginBtn = New DevExpress.XtraEditors.ButtonEdit()
        Me.LoginNameTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.EmailTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.MobileTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.ItemForLoginName = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForEmail = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForMobile = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.LoginBtn.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LoginNameTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmailTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MobileTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForLoginName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForEmail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForMobile, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.LoginBtn)
        Me.LayoutControl1.Controls.Add(Me.LoginNameTextEdit)
        Me.LayoutControl1.Controls.Add(Me.EmailTextEdit)
        Me.LayoutControl1.Controls.Add(Me.MobileTextEdit)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsView.RightToLeftMirroringApplied = True
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(330, 194)
        Me.LayoutControl1.TabIndex = 5
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'LoginBtn
        '
        Me.LoginBtn.EditValue = "تسجيل"
        Me.LoginBtn.Location = New System.Drawing.Point(12, 132)
        Me.LoginBtn.Name = "LoginBtn"
        Me.LoginBtn.Properties.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[True]
        Me.LoginBtn.Properties.Appearance.BackColor = System.Drawing.Color.Green
        Me.LoginBtn.Properties.Appearance.Font = New System.Drawing.Font("Droid Arabic Kufi", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoginBtn.Properties.Appearance.ForeColor = System.Drawing.Color.White
        Me.LoginBtn.Properties.Appearance.Options.UseBackColor = True
        Me.LoginBtn.Properties.Appearance.Options.UseFont = True
        Me.LoginBtn.Properties.Appearance.Options.UseForeColor = True
        Me.LoginBtn.Properties.Appearance.Options.UseTextOptions = True
        SerializableAppearanceObject1.BackColor = System.Drawing.Color.Green
        SerializableAppearanceObject1.ForeColor = System.Drawing.Color.White
        SerializableAppearanceObject1.Options.UseBackColor = True
        SerializableAppearanceObject1.Options.UseForeColor = True
        Me.LoginBtn.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "استعادة كلمة المرور", -1, True, True, False, EditorButtonImageOptions1, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, SerializableAppearanceObject2, SerializableAppearanceObject3, SerializableAppearanceObject4, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
        Me.LoginBtn.Properties.ContextImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[True]
        Me.LoginBtn.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        Me.LoginBtn.Size = New System.Drawing.Size(306, 28)
        Me.LoginBtn.StyleController = Me.LayoutControl1
        Me.LoginBtn.TabIndex = 12
        '
        'LoginNameTextEdit
        '
        Me.LoginNameTextEdit.Location = New System.Drawing.Point(12, 12)
        Me.LoginNameTextEdit.Name = "LoginNameTextEdit"
        Me.LoginNameTextEdit.Properties.ContextImageOptions.Alignment = DevExpress.XtraEditors.ContextImageAlignment.Far
        Me.LoginNameTextEdit.Properties.ContextImageOptions.SvgImage = CType(resources.GetObject("LoginNameTextEdit.Properties.ContextImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.LoginNameTextEdit.Properties.NullText = "اسم المستخدم"
        Me.LoginNameTextEdit.Size = New System.Drawing.Size(225, 36)
        Me.LoginNameTextEdit.StyleController = Me.LayoutControl1
        Me.LoginNameTextEdit.TabIndex = 7
        '
        'EmailTextEdit
        '
        Me.EmailTextEdit.Location = New System.Drawing.Point(12, 52)
        Me.EmailTextEdit.Name = "EmailTextEdit"
        Me.EmailTextEdit.Properties.Appearance.Options.UseTextOptions = True
        Me.EmailTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.EmailTextEdit.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.EmailTextEdit.Properties.ContextImageOptions.Image = CType(resources.GetObject("EmailTextEdit.Properties.ContextImageOptions.Image"), System.Drawing.Image)
        Me.EmailTextEdit.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.RegExpMaskManager))
        Me.EmailTextEdit.Properties.MaskSettings.Set("mask", "[a-zA-Z]+.@[a-zA-Z]+.[.][a-zA-Z]+.")
        Me.EmailTextEdit.Properties.NullText = "البريد الالكتروني"
        Me.EmailTextEdit.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.EmailTextEdit.Size = New System.Drawing.Size(225, 36)
        Me.EmailTextEdit.StyleController = Me.LayoutControl1
        Me.EmailTextEdit.TabIndex = 10
        '
        'MobileTextEdit
        '
        Me.MobileTextEdit.Location = New System.Drawing.Point(12, 92)
        Me.MobileTextEdit.Name = "MobileTextEdit"
        Me.MobileTextEdit.Properties.ContextImageOptions.Image = CType(resources.GetObject("MobileTextEdit.Properties.ContextImageOptions.Image"), System.Drawing.Image)
        Me.MobileTextEdit.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.RegularMaskManager))
        Me.MobileTextEdit.Properties.MaskSettings.Set("mask", "(\d?\d?\d?\d) \d\d\d-\d\d\d\d")
        Me.MobileTextEdit.Properties.NullText = "رقم الموبايل"
        Me.MobileTextEdit.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.MobileTextEdit.Size = New System.Drawing.Size(225, 36)
        Me.MobileTextEdit.StyleController = Me.LayoutControl1
        Me.MobileTextEdit.TabIndex = 11
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ItemForLoginName, Me.ItemForEmail, Me.ItemForMobile, Me.LayoutControlItem2})
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(330, 194)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'ItemForLoginName
        '
        Me.ItemForLoginName.AppearanceItemCaption.Font = New System.Drawing.Font("Traditional Arabic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ItemForLoginName.AppearanceItemCaption.FontStyleDelta = System.Drawing.FontStyle.Bold
        Me.ItemForLoginName.AppearanceItemCaption.Options.UseFont = True
        Me.ItemForLoginName.Control = Me.LoginNameTextEdit
        Me.ItemForLoginName.ControlAlignment = System.Drawing.ContentAlignment.TopRight
        Me.ItemForLoginName.CustomizationFormText = "Login Name"
        Me.ItemForLoginName.Location = New System.Drawing.Point(0, 0)
        Me.ItemForLoginName.Name = "ItemForLoginName"
        Me.ItemForLoginName.Size = New System.Drawing.Size(310, 40)
        Me.ItemForLoginName.Text = "اسم المستخدم"
        Me.ItemForLoginName.TextSize = New System.Drawing.Size(69, 24)
        '
        'ItemForEmail
        '
        Me.ItemForEmail.AppearanceItemCaption.Font = New System.Drawing.Font("Traditional Arabic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ItemForEmail.AppearanceItemCaption.FontStyleDelta = System.Drawing.FontStyle.Bold
        Me.ItemForEmail.AppearanceItemCaption.Options.UseFont = True
        Me.ItemForEmail.Control = Me.EmailTextEdit
        Me.ItemForEmail.ControlAlignment = System.Drawing.ContentAlignment.TopRight
        Me.ItemForEmail.CustomizationFormText = "Email"
        Me.ItemForEmail.Location = New System.Drawing.Point(0, 40)
        Me.ItemForEmail.Name = "ItemForEmail"
        Me.ItemForEmail.Size = New System.Drawing.Size(310, 40)
        Me.ItemForEmail.Text = "البريد الالكتروني"
        Me.ItemForEmail.TextSize = New System.Drawing.Size(69, 24)
        '
        'ItemForMobile
        '
        Me.ItemForMobile.AppearanceItemCaption.Font = New System.Drawing.Font("Traditional Arabic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ItemForMobile.AppearanceItemCaption.FontStyleDelta = System.Drawing.FontStyle.Bold
        Me.ItemForMobile.AppearanceItemCaption.Options.UseFont = True
        Me.ItemForMobile.Control = Me.MobileTextEdit
        Me.ItemForMobile.ControlAlignment = System.Drawing.ContentAlignment.TopRight
        Me.ItemForMobile.CustomizationFormText = "Mobile"
        Me.ItemForMobile.Location = New System.Drawing.Point(0, 80)
        Me.ItemForMobile.Name = "ItemForMobile"
        Me.ItemForMobile.Size = New System.Drawing.Size(310, 40)
        Me.ItemForMobile.Text = "رقم الموبايل"
        Me.ItemForMobile.TextSize = New System.Drawing.Size(69, 24)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.LoginBtn
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 120)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(310, 54)
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
        '
        'FrmForgetPassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(330, 194)
        Me.Controls.Add(Me.LayoutControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.IconOptions.LargeImage = CType(resources.GetObject("FrmForgetPassword.IconOptions.LargeImage"), System.Drawing.Image)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmForgetPassword"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "شاشة استعادة كلمة المرور"
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.LoginBtn.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LoginNameTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmailTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MobileTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForLoginName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForEmail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForMobile, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LoginBtn As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents LoginNameTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents EmailTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents MobileTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents ItemForLoginName As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForEmail As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForMobile As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
End Class
