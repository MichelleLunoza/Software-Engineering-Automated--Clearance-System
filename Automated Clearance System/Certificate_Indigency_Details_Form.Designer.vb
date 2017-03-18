<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Certificate_Indigency_Details_Form
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
        Me.SearchnameTextBox = New System.Windows.Forms.TextBox()
        Me.Label = New System.Windows.Forms.Label()
        Me.ULabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Middlename = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Lastname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Firstname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.FnameTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LastnameTextBox = New System.Windows.Forms.TextBox()
        Me.DateTextBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.MiddlenameTextBox = New System.Windows.Forms.TextBox()
        Me.DeleteButton = New System.Windows.Forms.Button()
        Me.EditButton = New System.Windows.Forms.Button()
        Me.AddButton = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.FirstnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MiddlenameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CertificateIndigencyTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClearanceDbDataSet = New Automated_Clearance_System.ClearanceDbDataSet()
        Me.Certificate_IndigencyTableTableAdapter = New Automated_Clearance_System.ClearanceDbDataSetTableAdapters.Certificate_IndigencyTableTableAdapter()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CertificateIndigencyTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClearanceDbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SearchnameTextBox
        '
        Me.SearchnameTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.SearchnameTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.SearchnameTextBox.Location = New System.Drawing.Point(130, 52)
        Me.SearchnameTextBox.Name = "SearchnameTextBox"
        Me.SearchnameTextBox.Size = New System.Drawing.Size(266, 20)
        Me.SearchnameTextBox.TabIndex = 14
        '
        'Label
        '
        Me.Label.AutoSize = True
        Me.Label.Location = New System.Drawing.Point(12, 59)
        Me.Label.Name = "Label"
        Me.Label.Size = New System.Drawing.Size(93, 13)
        Me.Label.TabIndex = 13
        Me.Label.Text = "Search Lastname:"
        '
        'ULabel
        '
        Me.ULabel.AutoSize = True
        Me.ULabel.Location = New System.Drawing.Point(51, 20)
        Me.ULabel.Name = "ULabel"
        Me.ULabel.Size = New System.Drawing.Size(0, 13)
        Me.ULabel.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "User: "
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "Firstname"
        Me.Column1.HeaderText = "Column1"
        Me.Column1.Name = "Column1"
        '
        'Middlename
        '
        Me.Middlename.DataPropertyName = "Middlename"
        Me.Middlename.HeaderText = "Middlename"
        Me.Middlename.Name = "Middlename"
        '
        'Lastname
        '
        Me.Lastname.DataPropertyName = "Lastname"
        Me.Lastname.HeaderText = "Lastname"
        Me.Lastname.Name = "Lastname"
        '
        'Firstname
        '
        Me.Firstname.DataPropertyName = "Firstname"
        Me.Firstname.HeaderText = "Column2"
        Me.Firstname.Name = "Firstname"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Middlename"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Middlename"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Lastname"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Lastname"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "Firstname"
        Me.Column2.HeaderText = "Column2"
        Me.Column2.Name = "Column2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Middlename"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Middlename"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Lastname"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Lastname"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
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
        Me.GroupBox1.Location = New System.Drawing.Point(565, 106)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(310, 202)
        Me.GroupBox1.TabIndex = 26
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Personal Information"
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
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(27, 124)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Lastname:"
        '
        'LastnameTextBox
        '
        Me.LastnameTextBox.Location = New System.Drawing.Point(103, 117)
        Me.LastnameTextBox.Name = "LastnameTextBox"
        Me.LastnameTextBox.ReadOnly = True
        Me.LastnameTextBox.Size = New System.Drawing.Size(179, 20)
        Me.LastnameTextBox.TabIndex = 14
        '
        'DateTextBox
        '
        Me.DateTextBox.Location = New System.Drawing.Point(103, 155)
        Me.DateTextBox.Name = "DateTextBox"
        Me.DateTextBox.ReadOnly = True
        Me.DateTextBox.Size = New System.Drawing.Size(179, 20)
        Me.DateTextBox.TabIndex = 18
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
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(27, 162)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(33, 13)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Date:"
        '
        'MiddlenameTextBox
        '
        Me.MiddlenameTextBox.Location = New System.Drawing.Point(103, 79)
        Me.MiddlenameTextBox.Name = "MiddlenameTextBox"
        Me.MiddlenameTextBox.ReadOnly = True
        Me.MiddlenameTextBox.Size = New System.Drawing.Size(179, 20)
        Me.MiddlenameTextBox.TabIndex = 16
        '
        'DeleteButton
        '
        Me.DeleteButton.Location = New System.Drawing.Point(724, 382)
        Me.DeleteButton.Name = "DeleteButton"
        Me.DeleteButton.Size = New System.Drawing.Size(112, 33)
        Me.DeleteButton.TabIndex = 25
        Me.DeleteButton.Text = "Delete"
        Me.DeleteButton.UseVisualStyleBackColor = True
        '
        'EditButton
        '
        Me.EditButton.Location = New System.Drawing.Point(724, 343)
        Me.EditButton.Name = "EditButton"
        Me.EditButton.Size = New System.Drawing.Size(112, 33)
        Me.EditButton.TabIndex = 24
        Me.EditButton.Text = "Edit"
        Me.EditButton.UseVisualStyleBackColor = True
        '
        'AddButton
        '
        Me.AddButton.Location = New System.Drawing.Point(606, 382)
        Me.AddButton.Name = "AddButton"
        Me.AddButton.Size = New System.Drawing.Size(112, 33)
        Me.AddButton.TabIndex = 23
        Me.AddButton.Text = "Add"
        Me.AddButton.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FirstnameDataGridViewTextBoxColumn, Me.MiddlenameDataGridViewTextBoxColumn, Me.LastnameDataGridViewTextBoxColumn, Me.DateDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.CertificateIndigencyTableBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(15, 93)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(484, 322)
        Me.DataGridView1.TabIndex = 27
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
        'CertificateIndigencyTableBindingSource
        '
        Me.CertificateIndigencyTableBindingSource.DataMember = "Certificate_IndigencyTable"
        Me.CertificateIndigencyTableBindingSource.DataSource = Me.ClearanceDbDataSet
        '
        'ClearanceDbDataSet
        '
        Me.ClearanceDbDataSet.DataSetName = "ClearanceDbDataSet"
        Me.ClearanceDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Certificate_IndigencyTableTableAdapter
        '
        Me.Certificate_IndigencyTableTableAdapter.ClearBeforeFill = True
        '
        'BackButton
        '
        Me.BackButton.Location = New System.Drawing.Point(893, 15)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(75, 23)
        Me.BackButton.TabIndex = 28
        Me.BackButton.Text = "Back"
        Me.BackButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(424, 50)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(75, 23)
        Me.ClearButton.TabIndex = 29
        Me.ClearButton.Text = "Clear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'SaveButton
        '
        Me.SaveButton.Location = New System.Drawing.Point(606, 343)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(112, 33)
        Me.SaveButton.TabIndex = 30
        Me.SaveButton.Text = "Save"
        Me.SaveButton.UseVisualStyleBackColor = True
        '
        'Certificate_Indigency_Details_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(980, 439)
        Me.Controls.Add(Me.SaveButton)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DeleteButton)
        Me.Controls.Add(Me.EditButton)
        Me.Controls.Add(Me.AddButton)
        Me.Controls.Add(Me.SearchnameTextBox)
        Me.Controls.Add(Me.Label)
        Me.Controls.Add(Me.ULabel)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Certificate_Indigency_Details_Form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Certificate_Indigency_Details_Form"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CertificateIndigencyTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClearanceDbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SearchnameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label As System.Windows.Forms.Label
    Friend WithEvents ULabel As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Middlename As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Lastname As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Firstname As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents FnameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents LastnameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DateTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents MiddlenameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DeleteButton As System.Windows.Forms.Button
    Friend WithEvents EditButton As System.Windows.Forms.Button
    Friend WithEvents AddButton As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents ClearanceDbDataSet As Automated_Clearance_System.ClearanceDbDataSet
    Friend WithEvents CertificateIndigencyTableBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Certificate_IndigencyTableTableAdapter As Automated_Clearance_System.ClearanceDbDataSetTableAdapters.Certificate_IndigencyTableTableAdapter
    Friend WithEvents FirstnameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MiddlenameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LastnameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BackButton As System.Windows.Forms.Button
    Friend WithEvents ClearButton As System.Windows.Forms.Button
    Friend WithEvents SaveButton As System.Windows.Forms.Button
End Class
