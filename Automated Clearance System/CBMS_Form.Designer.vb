﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CBMS_Form
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
        Me.BackButton = New System.Windows.Forms.Button()
        Me.ULabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BCDButton = New System.Windows.Forms.Button()
        Me.CIDButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BackButton
        '
        Me.BackButton.Location = New System.Drawing.Point(570, 12)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(75, 23)
        Me.BackButton.TabIndex = 29
        Me.BackButton.Text = "Back"
        Me.BackButton.UseVisualStyleBackColor = True
        '
        'ULabel
        '
        Me.ULabel.AutoSize = True
        Me.ULabel.Location = New System.Drawing.Point(44, 17)
        Me.ULabel.Name = "ULabel"
        Me.ULabel.Size = New System.Drawing.Size(0, 13)
        Me.ULabel.TabIndex = 28
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "User: "
        '
        'BCDButton
        '
        Me.BCDButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BCDButton.Location = New System.Drawing.Point(103, 100)
        Me.BCDButton.Name = "BCDButton"
        Me.BCDButton.Size = New System.Drawing.Size(171, 79)
        Me.BCDButton.TabIndex = 25
        Me.BCDButton.Text = "CBMS Details"
        Me.BCDButton.UseVisualStyleBackColor = True
        '
        'CIDButton
        '
        Me.CIDButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CIDButton.Location = New System.Drawing.Point(340, 100)
        Me.CIDButton.Name = "CIDButton"
        Me.CIDButton.Size = New System.Drawing.Size(171, 79)
        Me.CIDButton.TabIndex = 26
        Me.CIDButton.Text = "Total (CBMS)"
        Me.CIDButton.UseVisualStyleBackColor = True
        '
        'CBMS_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(664, 296)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.ULabel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BCDButton)
        Me.Controls.Add(Me.CIDButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "CBMS_Form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CBMS Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BackButton As System.Windows.Forms.Button
    Friend WithEvents ULabel As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BCDButton As System.Windows.Forms.Button
    Friend WithEvents CIDButton As System.Windows.Forms.Button
End Class
