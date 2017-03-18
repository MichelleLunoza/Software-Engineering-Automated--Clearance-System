<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.CBMSButton = New System.Windows.Forms.Button()
        Me.ClearancesButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ULabel = New System.Windows.Forms.Label()
        Me.LogoutButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'CBMSButton
        '
        Me.CBMSButton.Location = New System.Drawing.Point(333, 124)
        Me.CBMSButton.Name = "CBMSButton"
        Me.CBMSButton.Size = New System.Drawing.Size(165, 53)
        Me.CBMSButton.TabIndex = 3
        Me.CBMSButton.Text = "                    CBMS                       (COMMUNITY BASED MONITORING SYSTEM" & _
    ")"
        Me.CBMSButton.UseVisualStyleBackColor = True
        '
        'ClearancesButton
        '
        Me.ClearancesButton.Location = New System.Drawing.Point(109, 124)
        Me.ClearancesButton.Name = "ClearancesButton"
        Me.ClearancesButton.Size = New System.Drawing.Size(165, 53)
        Me.ClearancesButton.TabIndex = 2
        Me.ClearancesButton.Text = "CLEARANCES"
        Me.ClearancesButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "User: "
        '
        'ULabel
        '
        Me.ULabel.AutoSize = True
        Me.ULabel.Location = New System.Drawing.Point(51, 9)
        Me.ULabel.Name = "ULabel"
        Me.ULabel.Size = New System.Drawing.Size(0, 13)
        Me.ULabel.TabIndex = 5
        '
        'LogoutButton
        '
        Me.LogoutButton.Location = New System.Drawing.Point(551, 9)
        Me.LogoutButton.Name = "LogoutButton"
        Me.LogoutButton.Size = New System.Drawing.Size(75, 23)
        Me.LogoutButton.TabIndex = 13
        Me.LogoutButton.Text = "Logout"
        Me.LogoutButton.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(638, 313)
        Me.Controls.Add(Me.LogoutButton)
        Me.Controls.Add(Me.ULabel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CBMSButton)
        Me.Controls.Add(Me.ClearancesButton)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MainForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CBMSButton As System.Windows.Forms.Button
    Friend WithEvents ClearancesButton As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ULabel As System.Windows.Forms.Label
    Friend WithEvents LogoutButton As System.Windows.Forms.Button
End Class
