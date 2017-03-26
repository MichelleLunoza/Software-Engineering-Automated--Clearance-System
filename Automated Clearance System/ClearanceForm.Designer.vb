<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClearanceForm
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
        Me.BCButton = New System.Windows.Forms.Button()
        Me.CIButton = New System.Windows.Forms.Button()
        Me.BCDButton = New System.Windows.Forms.Button()
        Me.CIDButton = New System.Windows.Forms.Button()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.ULabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BCButton
        '
        Me.BCButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BCButton.Location = New System.Drawing.Point(28, 36)
        Me.BCButton.Name = "BCButton"
        Me.BCButton.Size = New System.Drawing.Size(165, 53)
        Me.BCButton.TabIndex = 1
        Me.BCButton.Text = "BARANGAY CLEARANCE"
        Me.BCButton.UseVisualStyleBackColor = True
        '
        'CIButton
        '
        Me.CIButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CIButton.Location = New System.Drawing.Point(28, 104)
        Me.CIButton.Name = "CIButton"
        Me.CIButton.Size = New System.Drawing.Size(165, 53)
        Me.CIButton.TabIndex = 2
        Me.CIButton.Text = "CERTIFICATE OF INDIGENCY"
        Me.CIButton.UseVisualStyleBackColor = True
        '
        'BCDButton
        '
        Me.BCDButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BCDButton.Location = New System.Drawing.Point(73, 36)
        Me.BCDButton.Name = "BCDButton"
        Me.BCDButton.Size = New System.Drawing.Size(165, 53)
        Me.BCDButton.TabIndex = 3
        Me.BCDButton.Text = "BARANGAY CLEARANCE"
        Me.BCDButton.UseVisualStyleBackColor = True
        '
        'CIDButton
        '
        Me.CIDButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CIDButton.Location = New System.Drawing.Point(73, 105)
        Me.CIDButton.Name = "CIDButton"
        Me.CIDButton.Size = New System.Drawing.Size(165, 53)
        Me.CIDButton.TabIndex = 4
        Me.CIDButton.Text = "CERTIFICATE OF INDIGENCY"
        Me.CIDButton.UseVisualStyleBackColor = True
        '
        'BackButton
        '
        Me.BackButton.Location = New System.Drawing.Point(574, 9)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(75, 23)
        Me.BackButton.TabIndex = 21
        Me.BackButton.Text = "Back"
        Me.BackButton.UseVisualStyleBackColor = True
        '
        'ULabel
        '
        Me.ULabel.AutoSize = True
        Me.ULabel.Location = New System.Drawing.Point(48, 14)
        Me.ULabel.Name = "ULabel"
        Me.ULabel.Size = New System.Drawing.Size(0, 13)
        Me.ULabel.TabIndex = 20
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "User: "
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.BCDButton)
        Me.GroupBox2.Controls.Add(Me.CIDButton)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(331, 78)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(283, 191)
        Me.GroupBox2.TabIndex = 18
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "DETAILS"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BCButton)
        Me.GroupBox1.Controls.Add(Me.CIButton)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(46, 78)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(243, 191)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "PRINT"
        '
        'ClearanceForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(664, 296)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.ULabel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "ClearanceForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Clearance Form"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BCButton As System.Windows.Forms.Button
    Friend WithEvents CIButton As System.Windows.Forms.Button
    Friend WithEvents BCDButton As System.Windows.Forms.Button
    Friend WithEvents CIDButton As System.Windows.Forms.Button
    Friend WithEvents BackButton As System.Windows.Forms.Button
    Friend WithEvents ULabel As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
End Class
