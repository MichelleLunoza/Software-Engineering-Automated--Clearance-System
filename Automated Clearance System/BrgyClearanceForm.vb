Imports System.Data.SqlClient
Public Class BrgyClearanceForm

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        ClearanceForm.Show()
        Me.Hide()
    End Sub
    Private Sub PrintButton_Click(sender As Object, e As EventArgs) Handles PrintButton.Click
        If FnameTextBox.Text = "" Then
            MessageBox.Show("Enter Firstname.")
            FnameTextBox.Focus()
        ElseIf MnameTextBox.Text = "" Then
            MessageBox.Show("Enter Middlename or Middle Initial")
            MnameTextBox.Focus()
        ElseIf LnameTextBox.Text = "" Then
            MessageBox.Show("Enter Lastname")
            LnameTextBox.Focus()

        Else

            Dim Fname = FnameTextBox.Text
            Dim Mname = MnameTextBox.Text
            Dim Lname = LnameTextBox.Text
            Dim Datetime = DateTimePicker.Value.ToString
            Dim con As New SqlConnection
            Dim cmd As New SqlCommand


            Dim query As String = String.Empty
            query &= "INSERT INTO Brgy_ClearanceTable (Firstname,Middlename,Lastname,Date)"
            query &= "VALUES (@Firstname,@Middlename,@Lastname,@Date)"

            con.ConnectionString = "Data Source = MIGUTIERREZ-PC; Initial Catalog = AutomatedClearanceDb; Integrated Security = True"
            With cmd
                .Connection = con
                .CommandType = CommandType.Text
                .CommandText = query
                .Parameters.AddWithValue("@Firstname", Fname)
                .Parameters.AddWithValue("@Middlename", Mname)
                .Parameters.AddWithValue("@Lastname", Lname)
                .Parameters.AddWithValue("@Date", DateTime)
            End With

            con.Open()
            cmd.ExecuteNonQuery()

        End If

    End Sub

    Private Sub BrgyClearanceForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        ULabel.Text = LoginForm.TypeUserComboBox.SelectedItem.ToString
        Me.DateLabel.Text = DateTime.Now.ToString("mm/dd/yyy")
        Me.TimeLabel.Text = TimeOfDay.ToString("hh:mm:ss")
    End Sub
End Class