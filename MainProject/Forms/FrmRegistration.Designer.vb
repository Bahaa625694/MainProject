<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmRegistration
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmRegistration))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnRegistration = New System.Windows.Forms.Button()
        Me.TxtSqlPassword = New System.Windows.Forms.TextBox()
        Me.TxtSqlUserName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtServerName = New System.Windows.Forms.TextBox()
        Me.TxtSqlDataBaseName = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.TimerEndFrmLogin = New System.Windows.Forms.Timer(Me.components)
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Brush Script MT", 26.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(33, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(177, 43)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "MIOSystem"
        '
        'BtnRegistration
        '
        Me.BtnRegistration.BackColor = System.Drawing.Color.Gainsboro
        Me.BtnRegistration.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.BtnRegistration.FlatAppearance.BorderSize = 2
        Me.BtnRegistration.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRegistration.ForeColor = System.Drawing.Color.Black
        Me.BtnRegistration.Location = New System.Drawing.Point(21, 267)
        Me.BtnRegistration.Name = "BtnRegistration"
        Me.BtnRegistration.Size = New System.Drawing.Size(205, 23)
        Me.BtnRegistration.TabIndex = 5
        Me.BtnRegistration.Text = "&تسجيل السيرفر"
        Me.BtnRegistration.UseVisualStyleBackColor = False
        '
        'TxtSqlPassword
        '
        Me.TxtSqlPassword.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSqlPassword.ForeColor = System.Drawing.Color.DarkGray
        Me.TxtSqlPassword.Location = New System.Drawing.Point(21, 229)
        Me.TxtSqlPassword.Name = "TxtSqlPassword"
        Me.TxtSqlPassword.ReadOnly = True
        Me.TxtSqlPassword.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtSqlPassword.Size = New System.Drawing.Size(205, 21)
        Me.TxtSqlPassword.TabIndex = 4
        Me.TxtSqlPassword.Text = "كلمة المرور"
        Me.TxtSqlPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtSqlUserName
        '
        Me.TxtSqlUserName.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSqlUserName.ForeColor = System.Drawing.Color.DarkGray
        Me.TxtSqlUserName.Location = New System.Drawing.Point(21, 196)
        Me.TxtSqlUserName.Name = "TxtSqlUserName"
        Me.TxtSqlUserName.ReadOnly = True
        Me.TxtSqlUserName.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtSqlUserName.Size = New System.Drawing.Size(205, 21)
        Me.TxtSqlUserName.TabIndex = 3
        Me.TxtSqlUserName.Text = "اسم المستخدم"
        Me.TxtSqlUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Brush Script MT", 26.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(-5, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(261, 43)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Server Registration"
        '
        'TxtServerName
        '
        Me.TxtServerName.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtServerName.ForeColor = System.Drawing.Color.DarkGray
        Me.TxtServerName.Location = New System.Drawing.Point(21, 130)
        Me.TxtServerName.Name = "TxtServerName"
        Me.TxtServerName.ReadOnly = True
        Me.TxtServerName.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtServerName.Size = New System.Drawing.Size(205, 21)
        Me.TxtServerName.TabIndex = 1
        Me.TxtServerName.Text = "اسم السيرفر"
        Me.TxtServerName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtSqlDataBaseName
        '
        Me.TxtSqlDataBaseName.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSqlDataBaseName.ForeColor = System.Drawing.Color.DarkGray
        Me.TxtSqlDataBaseName.Location = New System.Drawing.Point(21, 163)
        Me.TxtSqlDataBaseName.Name = "TxtSqlDataBaseName"
        Me.TxtSqlDataBaseName.ReadOnly = True
        Me.TxtSqlDataBaseName.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtSqlDataBaseName.Size = New System.Drawing.Size(205, 21)
        Me.TxtSqlDataBaseName.TabIndex = 2
        Me.TxtSqlDataBaseName.Text = "قاعدة البيانات"
        Me.TxtSqlDataBaseName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Gainsboro
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.Button1.FlatAppearance.BorderSize = 2
        Me.Button1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(21, 100)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(205, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "تنشيط التسجيل"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'TimerEndFrmLogin
        '
        Me.TimerEndFrmLogin.Enabled = True
        Me.TimerEndFrmLogin.Interval = 250
        '
        'FrmRegistration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 29.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(247, 354)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TxtSqlDataBaseName)
        Me.Controls.Add(Me.TxtServerName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnRegistration)
        Me.Controls.Add(Me.TxtSqlPassword)
        Me.Controls.Add(Me.TxtSqlUserName)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Traditional Arabic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmRegistration"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "شاشة تسجيل السيرفر"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents BtnRegistration As Button
    Friend WithEvents TxtSqlPassword As TextBox
    Friend WithEvents TxtSqlUserName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtServerName As TextBox
    Friend WithEvents TxtSqlDataBaseName As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents TimerEndFrmLogin As Timer
End Class
