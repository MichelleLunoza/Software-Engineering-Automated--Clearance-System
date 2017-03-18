
Imports System.Data.SqlClient
Imports System.Data.DataTable


Public Class Certificate_Indigency_Details_Form

    Private Sub Certificate_Indigency_Details_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ClearanceDbDataSet.Certificate_IndigencyTable' table. You can move, or remove it, as needed.
        Me.Certificate_IndigencyTableTableAdapter.Fill(Me.ClearanceDbDataSet.Certificate_IndigencyTable)
        'TODO: This line of code loads data into the 'ClearanceDbDataSet.Certificate_IndigencyTable' table. You can move, or remove it, as needed.
        Me.Certificate_IndigencyTableTableAdapter.Fill(Me.ClearanceDbDataSet.Certificate_IndigencyTable)

        DataGridView1.Refresh()
        ULabel.Text = LoginForm.TypeUserComboBox.SelectedItem.ToString
        SaveButton.Enabled = False
    End Sub

    Private Sub SearchnameTextBox_TextChanged(sender As Object, e As EventArgs) Handles SearchnameTextBox.TextChanged


        Dim con As SqlConnection = New SqlConnection("Data Source = MIGUTIERREZ-PC; Initial Catalog = ClearanceDb; Integrated Security = True")
        Dim cmd As New SqlCommand
        Dim adapt As New SqlDataAdapter
        Dim dt As New DataTable

        Try
            
            con.Open()
            dt = New DataTable
            With cmd
                .Connection = con
                .CommandText = "SELECT * FROM Certificate_IndigencyTable WHERE Lastname Like'" & SearchnameTextBox.Text & "%'"
            End With
            adapt.SelectCommand = cmd
            adapt.Fill(dt)
            DataGridView1.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        adapt.Dispose()
        con.Close()
    End Sub

    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click
    End Sub
    Private Sub EditButton_Click(sender As Object, e As EventArgs) Handles EditButton.Click
        FnameTextBox.ReadOnly = False
        MiddlenameTextBox.ReadOnly = False
        LastnameTextBox.ReadOnly = False
        DateTextBox.ReadOnly = False

    End Sub
    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick

        Dim row As DataGridViewRow = DataGridView1.CurrentRow
        Me.FnameTextBox.Text = row.Cells(0).Value.ToString()
        Me.MiddlenameTextBox.Text = row.Cells(1).Value.ToString()
        Me.LastnameTextBox.Text = row.Cells(2).Value.ToString()
        Me.DateTextBox.Text = row.Cells(3).Value.ToString()
    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        ClearanceForm.Show()
        Me.Hide()
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        SearchnameTextBox.Clear()
    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        If FnameTextBox.Text = "" Then
            MessageBox.Show("Enter Firstname.")
            FnameTextBox.Focus()
        ElseIf MiddlenameTextBox.Text = "" Then
            MessageBox.Show("Enter Middlename or Middle Initial")
            MiddlenameTextBox.Focus()
        ElseIf LastnameTextBox.Text = "" Then
            MessageBox.Show("Enter Lastname")
            LastnameTextBox.Focus()
        ElseIf DateTextBox.Text = "" Then
            MessageBox.Show("Enter Date and Time")

        Else

            Dim Fname = FnameTextBox.Text
            Dim Mname = MiddlenameTextBox.Text
            Dim Lname = LastnameTextBox.Text
            Dim DateTime = DateTextBox.Text
            Dim con As New SqlConnection
            Dim cmd As New SqlCommand


            Dim query As String = String.Empty
            query &= "INSERT INTO Certificate_IndigencyTable (Firstname,Middlename,Lastname,Date)"
            query &= "VALUES (@Fname,@Mname,@Lname,@Date)"

            con.ConnectionString = "Data Source = MIGUTIERREZ-PC; Initial Catalog = ClearanceDb; Integrated Security = True"
            With cmd
                .Connection = con
                .CommandType = CommandType.Text
                .CommandText = query
                .Parameters.AddWithValue("@Fname", Fname)
                .Parameters.AddWithValue("@Mname", Mname)
                .Parameters.AddWithValue("@Lname", Lname)
                .Parameters.AddWithValue("@Date", DateTime)
            End With
            Try
                con.Open()
                cmd.ExecuteNonQuery()
                MessageBox.Show("Successfully Saved!")
                DataGridView1.Refresh()
                SaveButton.Enabled = False
                EditButton.Enabled = True
                FnameTextBox.ReadOnly = True
                MiddlenameTextBox.ReadOnly = True
                LastnameTextBox.ReadOnly = True
                DateTextBox.ReadOnly = True

            Catch ex As Exception
                MessageBox.Show(ex.Message.ToString(), "Error Message")
            End Try

        End If
    End Sub
End Class