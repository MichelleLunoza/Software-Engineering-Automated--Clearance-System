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
        Me.TypeUserComboBox = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.usernameTextBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.passwordTextBox = New System.Windows.Forms.TextBox()
        Me.ChangePassButton = New System.Windows.Forms.Button()
        Me.LoginButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TypeUserComboBox
        '
        Me.TypeUserComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TypeUserComboBox.FormattingEnabled = True
        Me.TypeUserComboBox.Items.AddRange(New Object() {"Administrator", "Guest"})
        Me.TypeUserComboBox.Location = New System.Drawing.Point(267, 102)
        Me.TypeUserComboBox.Name = "TypeUserComboBox"
        Me.TypeUserComboBox.Size = New System.Drawing.Size(213, 21)
        Me.TypeUserComboBox.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(315, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Login"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(152, 110)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Type of User:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(152, 144)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Username:"
        '
        'usernameTextBox
        '
        Me.usernameTextBox.Location = New System.Drawing.Point(267, 141)
        Me.usernameTextBox.Name = "usernameTextBox"
        Me.usernameTextBox.ReadOnly = True
        Me.usernameTextBox.Size = New System.Drawing.Size(213, 20)
        Me.usernameTextBox.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(152, 181)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Password:"
        '
        'passwordTextBox
        '
        Me.passwordTextBox.Location = New System.Drawing.Point(267, 178)
        Me.passwordTextBox.Name = "passwordTextBox"
        Me.passwordTextBox.ReadOnly = True
        Me.passwordTextBox.Size = New System.Drawing.Size(213, 20)
        Me.passwordTextBox.TabIndex = 7
        '
        'ChangePassButton
        '
        Me.ChangePassButton.Location = New System.Drawing.Point(135, 242)
        Me.ChangePassButton.Name = "ChangePassButton"
        Me.ChangePassButton.Size = New System.Drawing.Size(126, 38)
        Me.ChangePassButton.TabIndex = 9
        Me.ChangePassButton.Text = "&Change Password"
        Me.ChangePassButton.UseVisualStyleBackColor = True
        '
        'LoginButton
        '
        Me.LoginButton.Location = New System.Drawing.Point(267, 242)
        Me.LoginButton.Name = "LoginButton"
        Me.LoginButton.Size = New System.Drawing.Size(126, 38)
        Me.LoginButton.TabIndex = 10
        Me.LoginButton.Text = "&Login"
        Me.LoginButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(399, 242)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(126, 38)
        Me.ClearButton.TabIndex = 11
        Me.ClearButton.Text = "&Clear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'LoginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(666, 310)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.LoginButton)
        Me.Controls.Add(Me.ChangePassButton)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.passwordTextBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.usernameTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TypeUserComboBox)
        Me.Name = "LoginForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TypeUserComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents usernameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents passwordTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ChangePassButton As System.Windows.Forms.Button
    Friend WithEvents LoginButton As System.Windows.Forms.Button
    Friend WithEvents ClearButton As System.Windows.Forms.Button

End Class
