Imports System
Imports System.Drawing
Imports System.IO
Imports System.Drawing.Printing
Imports System.Windows.Forms
Imports System.Data.SqlClient

Public Class Certificate_Indigency_Form

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim Heading1 As [String] = "Republic of the Philippines"
        Dim printFont As New Font("Courier New", 10)
        Dim sngLineHeight As Single = printFont.GetHeight + 2
        Dim sngXLocation As Single = e.MarginBounds.Left
        Dim sngYLocation As Single = e.MarginBounds.Top
        Dim f As Graphics = e.Graphics

        e.Graphics.DrawString(Heading1, New Font("Brush Script MT", 14, FontStyle.Italic), Brushes.Black, 10, 10)
        Dim x As Single = Convert.ToSingle(e.PageBounds.Width / 2 - e.Graphics.MeasureString("Republic of the Philippines", printFont).Width / 2)

        e.Graphics.DrawString("Republic of the Philippines", printFont, Brushes.Black, x, 100)
        'f.DrawImage(Image.FromFile("D:\Mich\pics_mich\05.14.2015\1111111.jpg"), 5, 5)

    End Sub

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
            query &= "INSERT INTO Certificate_IndigencyTable (Firstname,Middlename,Lastname,Date)"
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