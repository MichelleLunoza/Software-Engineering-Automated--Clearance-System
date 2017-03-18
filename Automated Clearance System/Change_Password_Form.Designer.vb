<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Change_Password_Form
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.OldUsernameTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.OldPassTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.NewUsernameTextBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.NewPassTextBox = New System.Windows.Forms.TextBox()
        Me.ConfirmNewPassTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.ChangePasswordButton = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ValidateButton = New System.Windows.Forms.Button()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(25, 77)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Old Password:"
        '
        'OldUsernameTextBox
        '
        Me.OldUsernameTextBox.Location = New System.Drawing.Point(165, 35)
        Me.OldUsernameTextBox.Name = "OldUsernameTextBox"
        Me.OldUsernameTextBox.Size = New System.Drawing.Size(224, 20)
        Me.OldUsernameTextBox.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 38)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Old Username:"
        '
        'OldPassTextBox
        '
        Me.OldPassTextBox.Location = New System.Drawing.Point(165, 74)
        Me.OldPassTextBox.Name = "OldPassTextBox"
        Me.OldPassTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.OldPassTextBox.Size = New System.Drawing.Size(224, 20)
        Me.OldPassTextBox.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "New Username:"
        '
        'NewUsernameTextBox
        '
        Me.NewUsernameTextBox.Location = New System.Drawing.Point(165, 18)
        Me.NewUsernameTextBox.Name = "NewUsernameTextBox"
        Me.NewUsernameTextBox.Size = New System.Drawing.Size(224, 20)
        Me.NewUsernameTextBox.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(25, 95)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(119, 13)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Confirm New Password:"
        '
        'NewPassTextBox
        '
        Me.NewPassTextBox.Location = New System.Drawing.Point(165, 57)
        Me.NewPassTextBox.Name = "NewPassTextBox"
        Me.NewPassTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.NewPassTextBox.Size = New System.Drawing.Size(224, 20)
        Me.NewPassTextBox.TabIndex = 13
        '
        'ConfirmNewPassTextBox
        '
        Me.ConfirmNewPassTextBox.Location = New System.Drawing.Point(165, 92)
        Me.ConfirmNewPassTextBox.Name = "ConfirmNewPassTextBox"
        Me.ConfirmNewPassTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.ConfirmNewPassTextBox.Size = New System.Drawing.Size(224, 20)
        Me.ConfirmNewPassTextBox.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "New Password:"
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(302, 343)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(130, 31)
        Me.ClearButton.TabIndex = 25
        Me.ClearButton.Text = "Clear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'ChangePasswordButton
        '
        Me.ChangePasswordButton.Location = New System.Drawing.Point(151, 343)
        Me.ChangePasswordButton.Name = "ChangePasswordButton"
        Me.ChangePasswordButton.Size = New System.Drawing.Size(130, 31)
        Me.ChangePasswordButton.TabIndex = 24
        Me.ChangePasswordButton.Text = "Change Password"
        Me.ChangePasswordButton.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(249, 59)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(93, 13)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Change Password"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.NewUsernameTextBox)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.NewPassTextBox)
        Me.Panel2.Controls.Add(Me.ConfirmNewPassTextBox)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(107, 133)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(423, 140)
        Me.Panel2.TabIndex = 23
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.OldUsernameTextBox)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.OldPassTextBox)
        Me.Panel1.Location = New System.Drawing.Point(107, 133)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(423, 124)
        Me.Panel1.TabIndex = 22
        '
        'ValidateButton
        '
        Me.ValidateButton.Location = New System.Drawing.Point(151, 343)
        Me.ValidateButton.Name = "ValidateButton"
        Me.ValidateButton.Size = New System.Drawing.Size(130, 31)
        Me.ValidateButton.TabIndex = 26
        Me.ValidateButton.Text = "Validate"
        Me.ValidateButton.UseVisualStyleBackColor = True
        '
        'Change_Password_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(626, 446)
        Me.Controls.Add(Me.ValidateButton)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.ChangePasswordButton)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Change_Password_Form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Change_Password_Form"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents OldUsernameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents OldPassTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents NewUsernameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents NewPassTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ConfirmNewPassTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ClearButton As System.Windows.Forms.Button
    Friend WithEvents ChangePasswordButton As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ValidateButton As System.Windows.Forms.Button
End Class
