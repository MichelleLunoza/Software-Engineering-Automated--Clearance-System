<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CBMS_TotalForm
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CBMS_TotalForm))
        Me.BCDButton = New System.Windows.Forms.Button()
        Me.CIDButton = New System.Windows.Forms.Button()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.ULabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TimeLabel = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DateLabel = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'BCDButton
        '
        Me.BCDButton.BackColor = System.Drawing.Color.Transparent
        Me.BCDButton.BackgroundImage = CType(resources.GetObject("BCDButton.BackgroundImage"), System.Drawing.Image)
        Me.BCDButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BCDButton.FlatAppearance.BorderSize = 0
        Me.BCDButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BCDButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BCDButton.Location = New System.Drawing.Point(198, 172)
        Me.BCDButton.Name = "BCDButton"
        Me.BCDButton.Size = New System.Drawing.Size(252, 56)
        Me.BCDButton.TabIndex = 27
        Me.BCDButton.UseVisualStyleBackColor = False
        '
        'CIDButton
        '
        Me.CIDButton.BackColor = System.Drawing.Color.Transparent
        Me.CIDButton.BackgroundImage = CType(resources.GetObject("CIDButton.BackgroundImage"), System.Drawing.Image)
        Me.CIDButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CIDButton.FlatAppearance.BorderSize = 0
        Me.CIDButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CIDButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CIDButton.Location = New System.Drawing.Point(198, 247)
        Me.CIDButton.Name = "CIDButton"
        Me.CIDButton.Size = New System.Drawing.Size(252, 56)
        Me.CIDButton.TabIndex = 28
        Me.CIDButton.UseVisualStyleBackColor = False
        '
        'BackButton
        '
        Me.BackButton.Location = New System.Drawing.Point(577, 128)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(75, 23)
        Me.BackButton.TabIndex = 32
        Me.BackButton.Text = "Back"
        Me.BackButton.UseVisualStyleBackColor = True
        '
        'ULabel
        '
        Me.ULabel.AutoSize = True
        Me.ULabel.BackColor = System.Drawing.Color.Transparent
        Me.ULabel.Location = New System.Drawing.Point(266, 101)
        Me.ULabel.Name = "ULabel"
        Me.ULabel.Size = New System.Drawing.Size(0, 13)
        Me.ULabel.TabIndex = 31
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(225, 101)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "User: "
        '
        'TimeLabel
        '
        Me.TimeLabel.AutoSize = True
        Me.TimeLabel.BackColor = System.Drawing.Color.Transparent
        Me.TimeLabel.Location = New System.Drawing.Point(553, 101)
        Me.TimeLabel.Name = "TimeLabel"
        Me.TimeLabel.Size = New System.Drawing.Size(0, 13)
        Me.TimeLabel.TabIndex = 75
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(517, 101)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(33, 13)
        Me.Label6.TabIndex = 74
        Me.Label6.Text = "Time:"
        '
        'DateLabel
        '
        Me.DateLabel.AutoSize = True
        Me.DateLabel.BackColor = System.Drawing.Color.Transparent
        Me.DateLabel.Location = New System.Drawing.Point(438, 101)
        Me.DateLabel.Name = "DateLabel"
        Me.DateLabel.Size = New System.Drawing.Size(0, 13)
        Me.DateLabel.TabIndex = 73
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Location = New System.Drawing.Point(404, 101)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(33, 13)
        Me.Label10.TabIndex = 72
        Me.Label10.Text = "Date:"
        '
        'CBMS_TotalForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(664, 376)
        Me.Controls.Add(Me.TimeLabel)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.DateLabel)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.ULabel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BCDButton)
        Me.Controls.Add(Me.CIDButton)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "CBMS_TotalForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CBMS_TotalForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BCDButton As System.Windows.Forms.Button
    Friend WithEvents CIDButton As System.Windows.Forms.Button
    Friend WithEvents BackButton As System.Windows.Forms.Button
    Friend WithEvents ULabel As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TimeLabel As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents DateLabel As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
