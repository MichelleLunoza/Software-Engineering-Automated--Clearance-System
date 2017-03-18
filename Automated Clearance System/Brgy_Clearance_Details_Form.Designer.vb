<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Brgy_Clearance_Details_Form
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
        Me.ULabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.FirstnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MiddlenameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BrgyClearanceTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClearanceDbDataSet = New Automated_Clearance_System.ClearanceDbDataSet()
        Me.Brgy_ClearanceTableTableAdapter = New Automated_Clearance_System.ClearanceDbDataSetTableAdapters.Brgy_ClearanceTableTableAdapter()
        Me.Label = New System.Windows.Forms.Label()
        Me.SearchnameTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.FnameTextBox = New System.Windows.Forms.TextBox()
        Me.LastnameTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.MiddlenameTextBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DateTextBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.AddButton = New System.Windows.Forms.Button()
        Me.EditButton = New System.Windows.Forms.Button()
        Me.DeleteButton = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.SaveButton = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BrgyClearanceTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClearanceDbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ULabel
        '
        Me.ULabel.AutoSize = True
        Me.ULabel.Location = New System.Drawing.Point(51, 9)
        Me.ULabel.Name = "ULabel"
        Me.ULabel.Size = New System.Drawing.Size(0, 13)
        Me.ULabel.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "User: "
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FirstnameDataGridViewTextBoxColumn, Me.MiddlenameDataGridViewTextBoxColumn, Me.LastnameDataGridViewTextBoxColumn, Me.DateDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.BrgyClearanceTableBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(15, 95)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(496, 332)
        Me.DataGridView1.TabIndex = 8
        '
        'FirstnameDataGridViewTextBoxColumn
        '
        Me.FirstnameDataGridViewTextBoxColumn.DataPropertyName = "Firstname"
        Me.FirstnameDataGridViewTextBoxColumn.HeaderText = "Firstname"
        Me.FirstnameDataGridViewTextBoxColumn.Name = "FirstnameDataGridViewTextBoxColumn"
        Me.FirstnameDataGridViewTextBoxColumn.Width = 120
        '
        'MiddlenameDataGridViewTextBoxColumn
        '
        Me.MiddlenameDataGridViewTextBoxColumn.DataPropertyName = "Middlename"
        Me.MiddlenameDataGridViewTextBoxColumn.HeaderText = "Middlename"
        Me.MiddlenameDataGridViewTextBoxColumn.Name = "MiddlenameDataGridViewTextBoxColumn"
        Me.MiddlenameDataGridViewTextBoxColumn.Width = 120
        '
        'LastnameDataGridViewTextBoxColumn
        '
        Me.LastnameDataGridViewTextBoxColumn.DataPropertyName = "Lastname"
        Me.LastnameDataGridViewTextBoxColumn.HeaderText = "Lastname"
        Me.LastnameDataGridViewTextBoxColumn.Name = "LastnameDataGridViewTextBoxColumn"
        Me.LastnameDataGridViewTextBoxColumn.Width = 120
        '
        'DateDataGridViewTextBoxColumn
        '
        Me.DateDataGridViewTextBoxColumn.DataPropertyName = "Date"
        Me.DateDataGridViewTextBoxColumn.HeaderText = "Date"
        Me.DateDataGridViewTextBoxColumn.Name = "DateDataGridViewTextBoxColumn"
        Me.DateDataGridViewTextBoxColumn.Width = 120
        '
        'BrgyClearanceTableBindingSource
        '
        Me.BrgyClearanceTableBindingSource.DataMember = "Brgy_ClearanceTable"
        Me.BrgyClearanceTableBindingSource.DataSource = Me.ClearanceDbDataSet
        '
        'ClearanceDbDataSet
        '
        Me.ClearanceDbDataSet.DataSetName = "ClearanceDbDataSet"
        Me.ClearanceDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Brgy_ClearanceTableTableAdapter
        '
        Me.Brgy_ClearanceTableTableAdapter.ClearBeforeFill = True
        '
        'Label
        '
        Me.Label.AutoSize = True
        Me.Label.Location = New System.Drawing.Point(12, 59)
        Me.Label.Name = "Label"
        Me.Label.Size = New System.Drawing.Size(93, 13)
        Me.Label.TabIndex = 9
        Me.Label.Text = "Search Lastname:"
        '
        'SearchnameTextBox
        '
        Me.SearchnameTextBox.Location = New System.Drawing.Point(130, 52)
        Me.SearchnameTextBox.Name = "SearchnameTextBox"
        Me.SearchnameTextBox.Size = New System.Drawing.Size(281, 20)
        Me.SearchnameTextBox.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Firstname:"
        '
        'FnameTextBox
        '
        Me.FnameTextBox.Location = New System.Drawing.Point(103, 44)
        Me.FnameTextBox.Name = "FnameTextBox"
        Me.FnameTextBox.ReadOnly = True
        Me.FnameTextBox.Size = New System.Drawing.Size(179, 20)
        Me.FnameTextBox.TabIndex = 12
        '
        'LastnameTextBox
        '
        Me.LastnameTextBox.Location = New System.Drawing.Point(103, 117)
        Me.LastnameTextBox.Name = "LastnameTextBox"
        Me.LastnameTextBox.ReadOnly = True
        Me.LastnameTextBox.Size = New System.Drawing.Size(179, 20)
        Me.LastnameTextBox.TabIndex = 14
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(27, 124)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Lastname:"
        '
        'MiddlenameTextBox
        '
        Me.MiddlenameTextBox.Location = New System.Drawing.Point(103, 79)
        Me.MiddlenameTextBox.Name = "MiddlenameTextBox"
        Me.MiddlenameTextBox.ReadOnly = True
        Me.MiddlenameTextBox.Size = New System.Drawing.Size(179, 20)
        Me.MiddlenameTextBox.TabIndex = 16
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(27, 86)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 13)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Middlename:"
        '
        'DateTextBox
        '
        Me.DateTextBox.Location = New System.Drawing.Point(103, 155)
        Me.DateTextBox.Name = "DateTextBox"
        Me.DateTextBox.ReadOnly = True
        Me.DateTextBox.Size = New System.Drawing.Size(179, 20)
        Me.DateTextBox.TabIndex = 18
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(27, 162)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(33, 13)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Date:"
        '
        'AddButton
        '
        Me.AddButton.Location = New System.Drawing.Point(624, 371)
        Me.AddButton.Name = "AddButton"
        Me.AddButton.Size = New System.Drawing.Size(112, 33)
        Me.AddButton.TabIndex = 19
        Me.AddButton.Text = "Add"
        Me.AddButton.UseVisualStyleBackColor = True
        '
        'EditButton
        '
        Me.EditButton.Location = New System.Drawing.Point(742, 332)
        Me.EditButton.Name = "EditButton"
        Me.EditButton.Size = New System.Drawing.Size(112, 33)
        Me.EditButton.TabIndex = 20
        Me.EditButton.Text = "Edit"
        Me.EditButton.UseVisualStyleBackColor = True
        '
        'DeleteButton
        '
        Me.DeleteButton.Location = New System.Drawing.Point(742, 371)
        Me.DeleteButton.Name = "DeleteButton"
        Me.DeleteButton.Size = New System.Drawing.Size(112, 33)
        Me.DeleteButton.TabIndex = 21
        Me.DeleteButton.Text = "Delete"
        Me.DeleteButton.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.FnameTextBox)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.LastnameTextBox)
        Me.GroupBox1.Controls.Add(Me.DateTextBox)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.MiddlenameTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(583, 95)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(310, 202)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Personal Information"
        '
        'BackButton
        '
        Me.BackButton.Location = New System.Drawing.Point(893, 12)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(75, 23)
        Me.BackButton.TabIndex = 29
        Me.BackButton.Text = "Back"
        Me.BackButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(436, 49)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(75, 23)
        Me.ClearButton.TabIndex = 30
        Me.ClearButton.Text = "Clear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'SaveButton
        '
        Me.SaveButton.Location = New System.Drawing.Point(624, 332)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(112, 33)
        Me.SaveButton.TabIndex = 31
        Me.SaveButton.Text = "Save"
        Me.SaveButton.UseVisualStyleBackColor = True
        '
        'Brgy_Clearance_Details_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(980, 439)
        Me.Controls.Add(Me.SaveButton)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DeleteButton)
        Me.Controls.Add(Me.EditButton)
        Me.Controls.Add(Me.AddButton)
        Me.Controls.Add(Me.SearchnameTextBox)
        Me.Controls.Add(Me.Label)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ULabel)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Brgy_Clearance_Details_Form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Brgy_Clearance_Details_Form"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BrgyClearanceTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClearanceDbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ULabel As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents ClearanceDbDataSet As Automated_Clearance_System.ClearanceDbDataSet
    Friend WithEvents BrgyClearanceTableBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Brgy_ClearanceTableTableAdapter As Automated_Clearance_System.ClearanceDbDataSetTableAdapters.Brgy_ClearanceTableTableAdapter
    Friend WithEvents FirstnameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MiddlenameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LastnameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label As System.Windows.Forms.Label
    Friend WithEvents SearchnameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents FnameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LastnameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents MiddlenameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DateTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents AddButton As System.Windows.Forms.Button
    Friend WithEvents EditButton As System.Windows.Forms.Button
    Friend WithEvents DeleteButton As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents BackButton As System.Windows.Forms.Button
    Friend WithEvents ClearButton As System.Windows.Forms.Button
    Friend WithEvents SaveButton As System.Windows.Forms.Button
End Class
