Imports System.Data.SqlClient


Public Class Brgy_Clearance_Form

    Private Sub PrintPreviewDialog1_Load(sender As Object, e As EventArgs) Handles PrintPreviewDialog1.Load
        PrintPreviewDialog1.Document = PrintDocument1
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
            Dim DateTime = DateTimePicker.Value.ToString("dd/MM/yyyy hh:mm:ss")
            Dim con As New SqlConnection
            Dim cmd As New SqlCommand


            Dim query As String = String.Empty
            query &= "INSERT INTO Brgy_ClearanceTable (Firstname,Middlename,Lastname,Date)"
            query &= "VALUES (@Fname,@Mname,@Lname,@Date)"

            con.ConnectionString = "Data Source = MIGUTIERREZ-PC; Initial Catalog = ClearanceDb; Integrated Security = True"
            With cmd
                .Connection = con
                .CommandType = CommandType.Text
                .CommandText = query
                .Parameters.AddWithValue("@Fname", Fname)
                .Parameters.AddWithValue("@Mname", Mname)
                .Parameters.AddWithValue("@Lname", Mname)
                .Parameters.AddWithValue("@Date", DateTime)
            End With
            Try
                con.Open()
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MessageBox.Show(ex.Message.ToString(), "Error Message")
            End Try

            PrintPreviewDialog1.Document = PrintDocument1
            PrintPreviewDialog1.ShowDialog()
        End If
    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        ClearanceForm.Show()
        Me.Hide()
    End Sub
End Class