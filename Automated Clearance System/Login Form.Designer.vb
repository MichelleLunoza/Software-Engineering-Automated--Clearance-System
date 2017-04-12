<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginForm))
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.LoginButton = New System.Windows.Forms.Button()
        Me.ChangePassButton = New System.Windows.Forms.Button()
        Me.passwordTextBox = New System.Windows.Forms.TextBox()
        Me.usernameTextBox = New System.Windows.Forms.TextBox()
        Me.TypeUserComboBox = New System.Windows.Forms.ComboBox()
        Me.MinimizeButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ClearButton
        '
        Me.ClearButton.BackgroundImage = CType(resources.GetObject("ClearButton.BackgroundImage"), System.Drawing.Image)
        Me.ClearButton.FlatAppearance.BorderSize = 0
        Me.ClearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ClearButton.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClearButton.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClearButton.Location = New System.Drawing.Point(375, 432)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(146, 31)
        Me.ClearButton.TabIndex = 31
        Me.ClearButton.Text = "&Clear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'LoginButton
        '
        Me.LoginButton.BackgroundImage = CType(resources.GetObject("LoginButton.BackgroundImage"), System.Drawing.Image)
        Me.LoginButton.FlatAppearance.BorderSize = 0
        Me.LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LoginButton.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoginButton.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LoginButton.Location = New System.Drawing.Point(206, 394)
        Me.LoginButton.Name = "LoginButton"
        Me.LoginButton.Size = New System.Drawing.Size(315, 34)
        Me.LoginButton.TabIndex = 30
        Me.LoginButton.Text = "&Login"
        Me.LoginButton.UseVisualStyleBackColor = True
        '
        'ChangePassButton
        '
        Me.ChangePassButton.BackgroundImage = CType(resources.GetObject("ChangePassButton.BackgroundImage"), System.Drawing.Image)
        Me.ChangePassButton.FlatAppearance.BorderSize = 0
        Me.ChangePassButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ChangePassButton.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChangePassButton.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ChangePassButton.Location = New System.Drawing.Point(206, 432)
        Me.ChangePassButton.Name = "ChangePassButton"
        Me.ChangePassButton.Size = New System.Drawing.Size(152, 31)
        Me.ChangePassButton.TabIndex = 29
        Me.ChangePassButton.Text = "&Change Password"
        Me.ChangePassButton.UseVisualStyleBackColor = True
        '
        'passwordTextBox
        '
        Me.passwordTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.passwordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.passwordTextBox.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.passwordTextBox.Location = New System.Drawing.Point(271, 358)
        Me.passwordTextBox.Name = "passwordTextBox"
        Me.passwordTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.passwordTextBox.ReadOnly = True
        Me.passwordTextBox.Size = New System.Drawing.Size(245, 14)
        Me.passwordTextBox.TabIndex = 27
        '
        'usernameTextBox
        '
        Me.usernameTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.usernameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.usernameTextBox.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.usernameTextBox.Location = New System.Drawing.Point(271, 302)
        Me.usernameTextBox.Name = "usernameTextBox"
        Me.usernameTextBox.ReadOnly = True
        Me.usernameTextBox.Size = New System.Drawing.Size(245, 14)
        Me.usernameTextBox.TabIndex = 25
        '
        'TypeUserComboBox
        '
        Me.TypeUserComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TypeUserComboBox.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TypeUserComboBox.FormattingEnabled = True
        Me.TypeUserComboBox.Items.AddRange(New Object() {"Administrator", "Guest"})
        Me.TypeUserComboBox.Location = New System.Drawing.Point(268, 246)
        Me.TypeUserComboBox.Name = "TypeUserComboBox"
        Me.TypeUserComboBox.Size = New System.Drawing.Size(253, 24)
        Me.TypeUserComboBox.TabIndex = 22
        '
        'MinimizeButton
        '
        Me.MinimizeButton.BackgroundImage = CType(resources.GetObject("MinimizeButton.BackgroundImage"), System.Drawing.Image)
        Me.MinimizeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MinimizeButton.FlatAppearance.BorderSize = 0
        Me.MinimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MinimizeButton.Location = New System.Drawing.Point(652, 7)
        Me.MinimizeButton.Name = "MinimizeButton"
        Me.MinimizeButton.Size = New System.Drawing.Size(29, 24)
        Me.MinimizeButton.TabIndex = 32
        Me.MinimizeButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.BackgroundImage = CType(resources.GetObject("ExitButton.BackgroundImage"), System.Drawing.Image)
        Me.ExitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ExitButton.FlatAppearance.BorderSize = 0
        Me.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ExitButton.Location = New System.Drawing.Point(687, 7)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(29, 24)
        Me.ExitButton.TabIndex = 33
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'LoginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(726, 533)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.MinimizeButton)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.LoginButton)
        Me.Controls.Add(Me.ChangePassButton)
        Me.Controls.Add(Me.passwordTextBox)
        Me.Controls.Add(Me.usernameTextBox)
        Me.Controls.Add(Me.TypeUserComboBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.Name = "LoginForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ClearButton As System.Windows.Forms.Button
    Friend WithEvents LoginButton As System.Windows.Forms.Button
    Friend WithEvents ChangePassButton As System.Windows.Forms.Button
    Friend WithEvents passwordTextBox As System.Windows.Forms.TextBox
    Friend WithEvents usernameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TypeUserComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents MinimizeButton As System.Windows.Forms.Button
    Friend WithEvents ExitButton As System.Windows.Forms.Button

End Class
