Imports System.Data.SqlClient
Imports System.Data
Public Class TotalCBMS_Purok

    Private Sub TotalCBMS_Purok_Load(sender As Object, e As EventArgs) Handles MyBase.Load

      
    End Sub

    Private Sub SearchButton_Click(sender As Object, e As EventArgs) Handles SearchButton.Click
        Dim con As String = "Data Source = MIGUTIERREZ-PC; Initial Catalog = AutomatedClearanceDb; Integrated Security = True"
        Dim query As String = String.Empty
        query &= "SELECT HHNumber As 'HH Number',Category As 'Category', HeadFamily As 'Head of the Family', TotalPopulation AS 'Total Population', TotalMale AS 'Total Male', TotalFemale As 'Total Female', TotalOFW As 'Total OFW', TotalPWD As 'Total PWD', zero_12Months As '0-12 Months', two_5YrsOld As '2-5 Yrs Old', six_12YrsOld As '6-12 Yrs Old', thirteen_17YrsOld As '13-17 Yrs Old', SeniorCitizen As 'Senior Citizen' FROM CBMSTable WHERE Category='" & ComboBox1.SelectedItem & "'"

        Dim connection As New SqlConnection(con)
        Dim dataadapter As New SqlDataAdapter(query, connection)
        Dim ds As New DataSet()


        connection.Open()
        dataadapter.Fill(ds, "CBMSTable")
        connection.Close()
        DataGridView1.DataSource = ds
        DataGridView1.DataMember = "CBMSTable"

  

    End Sub
    'TotalPopulation AS 'Total Population',HeadFamily AS 'Head of the Family'
    '"SELECT SUM(TotalPopulation) AS TotalPop FROM CBMSTable WHERE Category='" & TextBox1.Text & "'"
    '"SELECT COUNT(*) AS 'HH Number' FROM CBMSTable WHERE Category='" & TextBox1.Text & "'"

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub
End Class