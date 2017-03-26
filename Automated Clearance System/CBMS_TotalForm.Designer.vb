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
        Me.TotalCBMSButton = New System.Windows.Forms.Button()
        Me.OverallTotalCBMSButton = New System.Windows.Forms.Button()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.ULabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TotalCBMSButton
        '
        Me.TotalCBMSButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalCBMSButton.Location = New System.Drawing.Point(124, 109)
        Me.TotalCBMSButton.Name = "TotalCBMSButton"
        Me.TotalCBMSButton.Size = New System.Drawing.Size(171, 79)
        Me.TotalCBMSButton.TabIndex = 27
        Me.TotalCBMSButton.Text = "Total CBMS (By Purok)"
        Me.TotalCBMSButton.UseVisualStyleBackColor = True
        '
        'OverallTotalCBMSButton
        '
        Me.OverallTotalCBMSButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OverallTotalCBMSButton.Location = New System.Drawing.Point(361, 109)
        Me.OverallTotalCBMSButton.Name = "OverallTotalCBMSButton"
        Me.OverallTotalCBMSButton.Size = New System.Drawing.Size(171, 79)
        Me.OverallTotalCBMSButton.TabIndex = 28
        Me.OverallTotalCBMSButton.Text = "Overall Total (CBMS)"
        Me.OverallTotalCBMSButton.UseVisualStyleBackColor = True
        '
        'BackButton
        '
        Me.BackButton.Location = New System.Drawing.Point(575, 13)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(75, 23)
        Me.BackButton.TabIndex = 32
        Me.BackButton.Text = "Back"
        Me.BackButton.UseVisualStyleBackColor = True
        '
        'ULabel
        '
        Me.ULabel.AutoSize = True
        Me.ULabel.Location = New System.Drawing.Point(49, 13)
        Me.ULabel.Name = "ULabel"
        Me.ULabel.Size = New System.Drawing.Size(0, 13)
        Me.ULabel.TabIndex = 31
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "User: "
        '
        'CBMS_TotalForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(664, 296)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.ULabel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TotalCBMSButton)
        Me.Controls.Add(Me.OverallTotalCBMSButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "CBMS_TotalForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CBMS_TotalForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TotalCBMSButton As System.Windows.Forms.Button
    Friend WithEvents OverallTotalCBMSButton As System.Windows.Forms.Button
    Friend WithEvents BackButton As System.Windows.Forms.Button
    Friend WithEvents ULabel As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
