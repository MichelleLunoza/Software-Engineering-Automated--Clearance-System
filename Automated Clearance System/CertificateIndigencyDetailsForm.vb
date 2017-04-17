Imports System.Data.SqlClient
Public Class CertificateIndigencyDetailsForm

    Private Sub CertificateIndigencyDetailsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AutomatedClearanceDbDataSet.CertificateIndigencyTable' table. You can move, or remove it, as needed.
        Me.CertificateIndigencyTableTableAdapter.Fill(Me.AutomatedClearanceDbDataSet.CertificateIndigencyTable)
        ULabel.Text = LoginForm.TypeUserComboBox.SelectedItem.ToString
        SaveButton.Enabled = False


        Timer1.Start()
        Me.DateLabel.Text = DateTime.Now.ToString("mm/dd/yyy")
        Me.TimeLabel.Text = TimeOfDay.ToString("hh:mm:ss")
    End Sub

    Private Sub SearchnameTextBox_TextChanged(sender As Object, e As EventArgs) Handles SearchnameTextBox.TextChanged
        Dim con As SqlConnection = New SqlConnection("Data Source = MIGUTIERREZ-PC; Initial Catalog = AutomatedClearanceDb; Integrated Security = True")
        Dim cmd As New SqlCommand
        Dim adapt As New SqlDataAdapter
        Dim dt As New DataTable

        Try

            con.Open()
            dt = New DataTable
            With cmd
                .Connection = con
                .CommandText = "SELECT * FROM CertificateIndigencyTable WHERE Lastname Like'" & SearchnameTextBox.Text & "%'"
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

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        ClearanceForm.Show()
        Me.Hide()
    End Sub

    Private Sub UpdateButton_Click(sender As Object, e As EventArgs) Handles UpdateButton.Click
        SaveButton.Enabled = False
        EditButton.Enabled = True
        DeleteButton.Enabled = True
        AddButton.Enabled = True
        UpdateButton.Enabled = False

        Dim Fname = FnameTextBox.Text
        Dim Mname = MnameTextBox.Text
        Dim Lname = LnameTextBox.Text
        Dim Datetime = DateTextBox.Text
        Dim ID = IDTextBox.Text
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand


        Dim query As String = String.Empty
        query &= "UPDATE CertificateIndigencyTable SET Firstname=@Firstname,Middlename=@Middlename,Lastname=@Lastname,Date=@Date WHERE ID=@ID"


        con.ConnectionString = "Data Source = MIGUTIERREZ-PC; Initial Catalog = AutomatedClearanceDb; Integrated Security = True"
        With cmd
            .Connection = con
            .CommandType = CommandType.Text
            .CommandText = query
            .Parameters.AddWithValue("@ID", ID)
            .Parameters.AddWithValue("@Firstname", Fname)
            .Parameters.AddWithValue("@Middlename", Mname)
            .Parameters.AddWithValue("@Lastname", Lname)
            .Parameters.AddWithValue("@Date", Datetime)
        End With

        con.Open()
        cmd.ExecuteNonQuery()
        con.Close()
        FnameTextBox.ReadOnly = True
        MnameTextBox.ReadOnly = True
        LnameTextBox.ReadOnly = True
        DateTextBox.ReadOnly = True


        FnameTextBox.Clear()
        MnameTextBox.Clear()
        LnameTextBox.Clear()
        DateTextBox.Clear()
        IDTextBox.Clear()

        Me.CertificateIndigencyTableTableAdapter.Fill(Me.AutomatedClearanceDbDataSet.CertificateIndigencyTable)

    End Sub

    Private Sub EditButton_Click(sender As Object, e As EventArgs) Handles EditButton.Click
        FnameTextBox.ReadOnly = False
        MnameTextBox.ReadOnly = False
        LnameTextBox.ReadOnly = False
        DateTextBox.ReadOnly = False
        EditButton.Enabled = False
        SaveButton.Enabled = False
        AddButton.Enabled = False
        DeleteButton.Enabled = False
        UpdateButton.Enabled = True
    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        AddButton.Enabled = True
        UpdateButton.Enabled = False
        EditButton.Enabled = True
        SaveButton.Enabled = False
        DeleteButton.Enabled = True

        Dim Fname = FnameTextBox.Text
        Dim Mname = MnameTextBox.Text
        Dim Lname = LnameTextBox.Text
        Dim Datetime = DateTextBox.Text
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand


        Dim query As String = String.Empty
        query &= "INSERT INTO CertificateIndigencyTable (Firstname,Middlename,Lastname,Date)"
        query &= "VALUES (@Firstname,@Middlename,@Lastname,@Date)"

        con.ConnectionString = "Data Source = MIGUTIERREZ-PC; Initial Catalog = AutomatedClearanceDb; Integrated Security = True"
        With cmd
            .Connection = con
            .CommandType = CommandType.Text
            .CommandText = query
            .Parameters.AddWithValue("@Firstname", Fname)
            .Parameters.AddWithValue("@Middlename", Mname)
            .Parameters.AddWithValue("@Lastname", Lname)
            .Parameters.AddWithValue("@Date", Datetime)
        End With

        con.Open()
        cmd.ExecuteNonQuery()

        FnameTextBox.ReadOnly = True
        MnameTextBox.ReadOnly = True
        LnameTextBox.ReadOnly = True
        DateTextBox.ReadOnly = True

        FnameTextBox.Clear()
        MnameTextBox.Clear()
        LnameTextBox.Clear()
        DateTextBox.Clear()
        IDTextBox.Clear()

        Me.CertificateIndigencyTableTableAdapter.Fill(Me.AutomatedClearanceDbDataSet.CertificateIndigencyTable)
    End Sub

    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click
        AddButton.Enabled = False
        UpdateButton.Enabled = False
        EditButton.Enabled = False
        SaveButton.Enabled = True
        DeleteButton.Enabled = False
        FnameTextBox.ReadOnly = False
        MnameTextBox.ReadOnly = False
        LnameTextBox.ReadOnly = False
        DateTextBox.ReadOnly = False
    End Sub
    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim row As DataGridViewRow = DataGridView1.CurrentRow

        IDTextBox.Text = row.Cells(0).Value.ToString()
        LnameTextBox.Text = row.Cells(1).Value.ToString()
        FnameTextBox.Text = row.Cells(2).Value.ToString()
        MnameTextBox.Text = row.Cells(3).Value.ToString()
        DateTextBox.Text = row.Cells(4).Value.ToString()

    End Sub

    Private Sub ClearButton1_Click(sender As Object, e As EventArgs) Handles ClearButton1.Click
        FnameTextBox.Clear()
        MnameTextBox.Clear()
        LnameTextBox.Clear()
        DateTextBox.Clear()
        IDTextBox.Clear()
    End Sub
End Class