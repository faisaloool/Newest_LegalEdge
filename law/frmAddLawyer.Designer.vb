<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAddLawyer
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
        Me.comboGender = New System.Windows.Forms.ComboBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtBirthdate = New System.Windows.Forms.TextBox()
        Me.txtNationality = New System.Windows.Forms.TextBox()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtIDNumber = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.comboRole = New System.Windows.Forms.ComboBox()
        Me.HomeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ServicesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContactToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoginToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangePasswordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MyPRofileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'comboGender
        '
        Me.comboGender.BackColor = System.Drawing.Color.FromArgb(CType(CType(137, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.comboGender.Font = New System.Drawing.Font("Lucida Bright", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboGender.ForeColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.comboGender.FormattingEnabled = True
        Me.comboGender.Items.AddRange(New Object() {"Male", "Female"})
        Me.comboGender.Location = New System.Drawing.Point(48, 266)
        Me.comboGender.Margin = New System.Windows.Forms.Padding(2)
        Me.comboGender.Name = "comboGender"
        Me.comboGender.Size = New System.Drawing.Size(148, 24)
        Me.comboGender.TabIndex = 98
        Me.comboGender.Text = "Gender"
        '
        'txtPassword
        '
        Me.txtPassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(137, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.txtPassword.Font = New System.Drawing.Font("Lucida Bright", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.txtPassword.Location = New System.Drawing.Point(474, 266)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(2)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(148, 24)
        Me.txtPassword.TabIndex = 97
        Me.txtPassword.Text = "Password"
        Me.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtAddress
        '
        Me.txtAddress.BackColor = System.Drawing.Color.FromArgb(CType(CType(137, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.txtAddress.Font = New System.Drawing.Font("Lucida Bright", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.ForeColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.txtAddress.Location = New System.Drawing.Point(258, 266)
        Me.txtAddress.Margin = New System.Windows.Forms.Padding(2)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(148, 24)
        Me.txtAddress.TabIndex = 96
        Me.txtAddress.Text = "Address"
        Me.txtAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtBirthdate
        '
        Me.txtBirthdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(137, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.txtBirthdate.Font = New System.Drawing.Font("Lucida Bright", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBirthdate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.txtBirthdate.Location = New System.Drawing.Point(474, 222)
        Me.txtBirthdate.Margin = New System.Windows.Forms.Padding(2)
        Me.txtBirthdate.Name = "txtBirthdate"
        Me.txtBirthdate.Size = New System.Drawing.Size(148, 24)
        Me.txtBirthdate.TabIndex = 95
        Me.txtBirthdate.Text = "Birthdate"
        Me.txtBirthdate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtNationality
        '
        Me.txtNationality.BackColor = System.Drawing.Color.FromArgb(CType(CType(137, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.txtNationality.Font = New System.Drawing.Font("Lucida Bright", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNationality.ForeColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.txtNationality.Location = New System.Drawing.Point(258, 222)
        Me.txtNationality.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNationality.Name = "txtNationality"
        Me.txtNationality.Size = New System.Drawing.Size(148, 24)
        Me.txtNationality.TabIndex = 94
        Me.txtNationality.Text = "Nationality"
        Me.txtNationality.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPhone
        '
        Me.txtPhone.BackColor = System.Drawing.Color.FromArgb(CType(CType(137, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.txtPhone.Font = New System.Drawing.Font("Lucida Bright", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhone.ForeColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.txtPhone.Location = New System.Drawing.Point(48, 222)
        Me.txtPhone.Margin = New System.Windows.Forms.Padding(2)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(148, 24)
        Me.txtPhone.TabIndex = 93
        Me.txtPhone.Text = "Phone Number"
        Me.txtPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEmail
        '
        Me.txtEmail.BackColor = System.Drawing.Color.FromArgb(CType(CType(137, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.txtEmail.Font = New System.Drawing.Font("Lucida Bright", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.ForeColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.txtEmail.Location = New System.Drawing.Point(474, 173)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(2)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(148, 24)
        Me.txtEmail.TabIndex = 92
        Me.txtEmail.Text = "Email"
        Me.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtIDNumber
        '
        Me.txtIDNumber.BackColor = System.Drawing.Color.FromArgb(CType(CType(137, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.txtIDNumber.Font = New System.Drawing.Font("Lucida Bright", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIDNumber.ForeColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.txtIDNumber.Location = New System.Drawing.Point(258, 173)
        Me.txtIDNumber.Margin = New System.Windows.Forms.Padding(2)
        Me.txtIDNumber.Name = "txtIDNumber"
        Me.txtIDNumber.Size = New System.Drawing.Size(148, 22)
        Me.txtIDNumber.TabIndex = 91
        Me.txtIDNumber.Text = "Lawyer ID Number"
        Me.txtIDNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Lucida Bright", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(277, 321)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(116, 31)
        Me.Button1.TabIndex = 90
        Me.Button1.Text = "Add Lawyer"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'txtName
        '
        Me.txtName.BackColor = System.Drawing.Color.FromArgb(CType(CType(137, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.txtName.Font = New System.Drawing.Font("Lucida Bright", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.txtName.Location = New System.Drawing.Point(48, 173)
        Me.txtName.Margin = New System.Windows.Forms.Padding(2)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(148, 24)
        Me.txtName.TabIndex = 89
        Me.txtName.Text = "Lawyer Name"
        Me.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Bright", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(245, 137)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(184, 31)
        Me.Label1.TabIndex = 88
        Me.Label1.Text = "New Lawyer"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.law.My.Resources.Resources.name
        Me.PictureBox1.Location = New System.Drawing.Point(258, 32)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(135, 95)
        Me.PictureBox1.TabIndex = 87
        Me.PictureBox1.TabStop = False
        '
        'comboRole
        '
        Me.comboRole.BackColor = System.Drawing.Color.FromArgb(CType(CType(137, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.comboRole.Font = New System.Drawing.Font("Lucida Bright", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboRole.ForeColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.comboRole.FormattingEnabled = True
        Me.comboRole.Items.AddRange(New Object() {"Lawyer", "Mangager"})
        Me.comboRole.Location = New System.Drawing.Point(48, 313)
        Me.comboRole.Margin = New System.Windows.Forms.Padding(2)
        Me.comboRole.Name = "comboRole"
        Me.comboRole.Size = New System.Drawing.Size(148, 24)
        Me.comboRole.TabIndex = 99
        Me.comboRole.Text = "Role"
        '
        'HomeToolStripMenuItem
        '
        Me.HomeToolStripMenuItem.Font = New System.Drawing.Font("Lucida Bright", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HomeToolStripMenuItem.Name = "HomeToolStripMenuItem"
        Me.HomeToolStripMenuItem.Size = New System.Drawing.Size(53, 22)
        Me.HomeToolStripMenuItem.Text = "Home"
        '
        'ServicesToolStripMenuItem
        '
        Me.ServicesToolStripMenuItem.Font = New System.Drawing.Font("Lucida Bright", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ServicesToolStripMenuItem.Name = "ServicesToolStripMenuItem"
        Me.ServicesToolStripMenuItem.Size = New System.Drawing.Size(69, 22)
        Me.ServicesToolStripMenuItem.Text = "Services"
        '
        'ContactToolStripMenuItem
        '
        Me.ContactToolStripMenuItem.Font = New System.Drawing.Font("Lucida Bright", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContactToolStripMenuItem.Name = "ContactToolStripMenuItem"
        Me.ContactToolStripMenuItem.Size = New System.Drawing.Size(67, 22)
        Me.ContactToolStripMenuItem.Text = "Contact"
        '
        'LoginToolStripMenuItem
        '
        Me.LoginToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LogoutToolStripMenuItem, Me.ChangePasswordToolStripMenuItem, Me.MyPRofileToolStripMenuItem})
        Me.LoginToolStripMenuItem.Font = New System.Drawing.Font("Lucida Bright", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoginToolStripMenuItem.Name = "LoginToolStripMenuItem"
        Me.LoginToolStripMenuItem.Size = New System.Drawing.Size(73, 22)
        Me.LoginToolStripMenuItem.Text = "Account "
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'ChangePasswordToolStripMenuItem
        '
        Me.ChangePasswordToolStripMenuItem.Name = "ChangePasswordToolStripMenuItem"
        Me.ChangePasswordToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.ChangePasswordToolStripMenuItem.Text = "Change Password"
        '
        'MyPRofileToolStripMenuItem
        '
        Me.MyPRofileToolStripMenuItem.Name = "MyPRofileToolStripMenuItem"
        Me.MyPRofileToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.MyPRofileToolStripMenuItem.Text = "My Profile"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HomeToolStripMenuItem, Me.ServicesToolStripMenuItem, Me.ContactToolStripMenuItem, Me.LoginToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(4, 1, 0, 1)
        Me.MenuStrip1.Size = New System.Drawing.Size(669, 24)
        Me.MenuStrip1.TabIndex = 66
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'frmAddLawyer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(669, 384)
        Me.Controls.Add(Me.comboRole)
        Me.Controls.Add(Me.comboGender)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.txtBirthdate)
        Me.Controls.Add(Me.txtNationality)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtIDNumber)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmAddLawyer"
        Me.Text = "Add Lawyer"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents comboGender As ComboBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents txtBirthdate As TextBox
    Friend WithEvents txtNationality As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtIDNumber As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents comboRole As ComboBox
    Friend WithEvents HomeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ServicesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContactToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LoginToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ChangePasswordToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MyPRofileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuStrip1 As MenuStrip
End Class
