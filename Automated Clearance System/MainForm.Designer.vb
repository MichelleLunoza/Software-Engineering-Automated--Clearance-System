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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.LogoutButton = New System.Windows.Forms.Button()
        Me.ULabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CBMSButton = New System.Windows.Forms.Button()
        Me.ClearancesButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LogoutButton
        '
        Me.LogoutButton.Location = New System.Drawing.Point(576, 156)
        Me.LogoutButton.Name = "LogoutButton"
        Me.LogoutButton.Size = New System.Drawing.Size(75, 23)
        Me.LogoutButton.TabIndex = 23
        Me.LogoutButton.Text = "Logout"
        Me.LogoutButton.UseVisualStyleBackColor = True
        '
        'ULabel
        '
        Me.ULabel.AutoSize = True
        Me.ULabel.Location = New System.Drawing.Point(265, 125)
        Me.ULabel.Name = "ULabel"
        Me.ULabel.Size = New System.Drawing.Size(0, 13)
        Me.ULabel.TabIndex = 22
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(224, 125)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "User: "
        '
        'CBMSButton
        '
        Me.CBMSButton.BackColor = System.Drawing.Color.Transparent
        Me.CBMSButton.BackgroundImage = CType(resources.GetObject("CBMSButton.BackgroundImage"), System.Drawing.Image)
        Me.CBMSButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CBMSButton.FlatAppearance.BorderSize = 0
        Me.CBMSButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CBMSButton.Location = New System.Drawing.Point(227, 273)
        Me.CBMSButton.Name = "CBMSButton"
        Me.CBMSButton.Size = New System.Drawing.Size(255, 53)
        Me.CBMSButton.TabIndex = 20
        Me.CBMSButton.UseVisualStyleBackColor = False
        '
        'ClearancesButton
        '
        Me.ClearancesButton.BackColor = System.Drawing.Color.Transparent
        Me.ClearancesButton.BackgroundImage = CType(resources.GetObject("ClearancesButton.BackgroundImage"), System.Drawing.Image)
        Me.ClearancesButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClearancesButton.FlatAppearance.BorderSize = 0
        Me.ClearancesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ClearancesButton.Location = New System.Drawing.Point(227, 204)
        Me.ClearancesButton.Name = "ClearancesButton"
        Me.ClearancesButton.Size = New System.Drawing.Size(255, 53)
        Me.ClearancesButton.TabIndex = 19
        Me.ClearancesButton.UseVisualStyleBackColor = False
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(663, 458)
        Me.Controls.Add(Me.LogoutButton)
        Me.Controls.Add(Me.ULabel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CBMSButton)
        Me.Controls.Add(Me.ClearancesButton)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LogoutButton As System.Windows.Forms.Button
    Friend WithEvents ULabel As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CBMSButton As System.Windows.Forms.Button
    Friend WithEvents ClearancesButton As System.Windows.Forms.Button
End Class
