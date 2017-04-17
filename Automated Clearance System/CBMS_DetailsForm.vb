Imports System.Data.SqlClient
Public Class CBMS_DetailsForm

    Private Sub CBMS_DetailsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AutomatedClearanceDbDataSet.CBMSTable' table. You can move, or remove it, as needed.
        Me.CBMSTableTableAdapter.Fill(Me.AutomatedClearanceDbDataSet.CBMSTable)
        ULabel.Text = LoginForm.TypeUserComboBox.SelectedItem.ToString
    End Sub
    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick

        Dim row As DataGridViewRow = DataGridView1.CurrentRow

        Me.HHnoTextBox.Text = row.Cells(0).Value.ToString()
        Me.CategoryTextBox.Text = row.Cells(1).Value.ToString()
        Me.HeadTextBox.Text = row.Cells(2).Value.ToString()
        Me.TotalPopTextBox.Text = row.Cells(3).Value.ToString()
        Me.TotalMTextBox.Text = row.Cells(4).Value.ToString()
        Me.TotalFTextBox.Text = row.Cells(5).Value.ToString()
        Me.OFWTextBox.Text = row.Cells(6).Value.ToString()
        Me.PWDTextBox.Text = row.Cells(7).Value.ToString()
        Me.MonthsTextBox.Text = row.Cells(8).Value.ToString()
        Me.TOTextBox.Text = row.Cells(9).Value.ToString()
        Me.SOldTextBox.Text = row.Cells(10).Value.ToString()
        Me.ThOldTextBox.Text = row.Cells(11).Value.ToString()
        Me.SeniorTextBox.Text = row.Cells(12).Value.ToString()

    End Sub

    Private Sub SearchTextBox_TextChanged(sender As Object, e As EventArgs) Handles SearchTextBox.TextChanged
        Dim con As SqlConnection = New SqlConnection("Data Source = MIGUTIERREZ-PC; Initial Catalog = AutomatedClearanceDb; Integrated Security = True")
        Dim cmd As New SqlCommand
        Dim adapt As New SqlDataAdapter
        Dim dt As New DataTable

        Try

            con.Open()
            dt = New DataTable
            With cmd
                .Connection = con
                .CommandText = "SELECT * FROM CBMSTable WHERE HeadFamily Like'" & SearchTextBox.Text & "%'"
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
        CBMS_Form.Show()
        Me.Hide()
    End Sub

    Private Sub UpdateButton_Click(sender As Object, e As EventArgs) Handles UpdateButton.Click
        SaveButton.Enabled = False
        EditButton.Enabled = True
        DeleteButton.Enabled = True
        AddButton.Enabled = True
        UpdateButton.Enabled = False

        Dim HHno = HHnoTextBox.Text
        Dim Category = CategoryTextBox.Text
        Dim HeadFam = HeadTextBox.Text
        Dim TotalPop = TotalPopTextBox.Text
        Dim TotalM = TotalMTextBox.Text
        Dim TotalF = TotalFTextBox.Text
        Dim OFW = OFWTextBox.Text
        Dim PWD = PWDTextBox.Text
        Dim Months = MonthsTextBox.Text
        Dim TOld = TOTextBox.Text
        Dim SOld = SOldTextBox.Text
        Dim ThOld = ThOldTextBox.Text
        Dim Senior = SeniorTextBox.Text
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand

        Dim query As String = String.Empty
        query &= "UPDATE CBMSTable SET HHNumber=@HHno,Category=@Category,HeadFamily=@HeadFam,TotalPopulation=@TotalPop,TotalMale=@TotalM,TotalFemale=@TotalF,TotalOFW=@OFW,TotalPWD=@PWD,zero_12Months=@Months,two_5YrsOld=@TOld,six_12YrsOld=@SOld,thirteen_17YrsOld=@ThOld,SeniorCitizen=@Senior WHERE HHNumber=@HHno"


        con.ConnectionString = "Data Source = MIGUTIERREZ-PC; Initial Catalog = AutomatedClearanceDb; Integrated Security = True"
        With cmd
            .Connection = con
            .CommandType = CommandType.Text
            .CommandText = query
            .Parameters.AddWithValue("@HHno", HHno)
            .Parameters.AddWithValue("@Category", Category)
            .Parameters.AddWithValue("@HeadFam", HeadFam)
            .Parameters.AddWithValue("@TotalPop", TotalPop)
            .Parameters.AddWithValue("@TotalM", TotalM)
            .Parameters.AddWithValue("@TotalF", TotalF)
            .Parameters.AddWithValue("@OFW", OFW)
            .Parameters.AddWithValue("@PWD", PWD)
            .Parameters.AddWithValue("Months", Months)
            .Parameters.AddWithValue("TOld", TOld)
            .Parameters.AddWithValue("@SOld", SOld)
            .Parameters.AddWithValue("@ThOld", ThOld)
            .Parameters.AddWithValue("@Senior", Senior)
        End With

        con.Open()
        cmd.ExecuteNonQuery()
        con.Close()

        HHnoTextBox.ReadOnly = True
        HeadTextBox.ReadOnly = True
        CategoryTextBox.ReadOnly = True
        TotalPopTextBox.ReadOnly = True
        TotalMTextBox.ReadOnly = True
        TotalFTextBox.ReadOnly = True
        OFWTextBox.ReadOnly = True
        PWDTextBox.ReadOnly = True
        MonthsTextBox.ReadOnly = True
        TOTextBox.ReadOnly = True
        SOldTextBox.ReadOnly = True
        ThOldTextBox.ReadOnly = True
        SeniorTextBox.ReadOnly = True

        HHnoTextBox.Clear()
        HeadTextBox.Clear()
        CategoryTextBox.Clear()
        TotalPopTextBox.Clear()
        TotalMTextBox.Clear()
        TotalFTextBox.Clear()
        OFWTextBox.Clear()
        PWDTextBox.Clear()
        MonthsTextBox.Clear()
        TOTextBox.Clear()
        SOldTextBox.Clear()
        ThOldTextBox.Clear()
        SeniorTextBox.Clear()

        Me.CBMSTableTableAdapter.Fill(Me.AutomatedClearanceDbDataSet.CBMSTable)
    End Sub

    Private Sub EditButton_Click(sender As Object, e As EventArgs) Handles EditButton.Click
        EditButton.Enabled = False
        SaveButton.Enabled = False
        AddButton.Enabled = False
        DeleteButton.Enabled = False
        UpdateButton.Enabled = True

        HHnoTextBox.ReadOnly = False
        HeadTextBox.ReadOnly = False
        CategoryTextBox.ReadOnly = False
        TotalPopTextBox.ReadOnly = False
        TotalMTextBox.ReadOnly = False
        TotalFTextBox.ReadOnly = False
        OFWTextBox.ReadOnly = False
        PWDTextBox.ReadOnly = False
        MonthsTextBox.ReadOnly = False
        TOTextBox.ReadOnly = False
        SOldTextBox.ReadOnly = False
        ThOldTextBox.ReadOnly = False
        SeniorTextBox.ReadOnly = False
    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        AddButton.Enabled = True
        UpdateButton.Enabled = False
        EditButton.Enabled = True
        SaveButton.Enabled = False
        DeleteButton.Enabled = True


        Dim HHno = HHnoTextBox.Text
        Dim Category = CategoryTextBox.Text
        Dim HeadFam = HeadTextBox.Text
        Dim TotalPop = TotalPopTextBox.Text
        Dim TotalM = TotalMTextBox.Text
        Dim TotalF = TotalFTextBox.Text
        Dim OFW = OFWTextBox.Text
        Dim PWD = PWDTextBox.Text
        Dim Months = MonthsTextBox.Text
        Dim TOld = TOTextBox.Text
        Dim SOld = SOldTextBox.Text
        Dim ThOld = ThOldTextBox.Text
        Dim Senior = SeniorTextBox.Text
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand

        Dim query As String = String.Empty
        query &= "INSERT INTO CBMSTable (HHNumber,Category,HeadFamily,TotalPopulation,TotalMale,TotalFemale,TotalOFW,TotalPWD,zero_12Months,two_5YrsOld,six_12YrsOld,thirteen_17YrsOld,SeniorCitizen)"
        query &= "VALUES (@HHno,@Category,@HeadFam,@TotalPop,@TotalM,@TotalF,@OFW,@PWD,@Months,@TOld,@SOld,@ThOld,@Senior)"


        con.ConnectionString = "Data Source = MIGUTIERREZ-PC; Initial Catalog = AutomatedClearanceDb; Integrated Security = True"
        With cmd
            .Connection = con
            .CommandType = CommandType.Text
            .CommandText = query
            .Parameters.AddWithValue("@HHno", HHno)
            .Parameters.AddWithValue("@Category", Category)
            .Parameters.AddWithValue("@HeadFam", HeadFam)
            .Parameters.AddWithValue("@TotalPop", TotalPop)
            .Parameters.AddWithValue("@TotalM", TotalM)
            .Parameters.AddWithValue("@TotalF", TotalF)
            .Parameters.AddWithValue("@OFW", OFW)
            .Parameters.AddWithValue("@PWD", PWD)
            .Parameters.AddWithValue("Months", Months)
            .Parameters.AddWithValue("TOld", TOld)
            .Parameters.AddWithValue("@SOld", SOld)
            .Parameters.AddWithValue("@ThOld", ThOld)
            .Parameters.AddWithValue("@Senior", Senior)
        End With
        con.Open()
        cmd.ExecuteNonQuery()

        HHnoTextBox.ReadOnly = True
        HeadTextBox.ReadOnly = True
        CategoryTextBox.ReadOnly = True
        TotalPopTextBox.ReadOnly = True
        TotalMTextBox.ReadOnly = True
        TotalFTextBox.ReadOnly = True
        OFWTextBox.ReadOnly = True
        PWDTextBox.ReadOnly = True
        MonthsTextBox.ReadOnly = True
        TOTextBox.ReadOnly = True
        SOldTextBox.ReadOnly = True
        ThOldTextBox.ReadOnly = True
        SeniorTextBox.ReadOnly = True

        HHnoTextBox.Clear()
        HeadTextBox.Clear()
        CategoryTextBox.Clear()
        TotalPopTextBox.Clear()
        TotalMTextBox.Clear()
        TotalFTextBox.Clear()
        OFWTextBox.Clear()
        PWDTextBox.Clear()
        MonthsTextBox.Clear()
        TOTextBox.Clear()
        SOldTextBox.Clear()
        ThOldTextBox.Clear()
        SeniorTextBox.Clear()

        Me.CBMSTableTableAdapter.Fill(Me.AutomatedClearanceDbDataSet.CBMSTable)
    End Sub

    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click
        AddButton.Enabled = False
        UpdateButton.Enabled = False
        EditButton.Enabled = False
        SaveButton.Enabled = True
        DeleteButton.Enabled = False

        HHnoTextBox.ReadOnly = False
        CategoryTextBox.ReadOnly = False
        HeadTextBox.ReadOnly = False
        TotalPopTextBox.ReadOnly = False
        TotalMTextBox.ReadOnly = False
        TotalFTextBox.ReadOnly = False
        OFWTextBox.ReadOnly = False
        PWDTextBox.ReadOnly = False
        MonthsTextBox.ReadOnly = False
        TOTextBox.ReadOnly = False
        SOldTextBox.ReadOnly = False
        ThOldTextBox.ReadOnly = False
        SeniorTextBox.ReadOnly = False
    End Sub

    Private Sub ClearButton1_Click(sender As Object, e As EventArgs) Handles ClearButton1.Click
        HHnoTextBox.Clear()
        HeadTextBox.Clear()
        CategoryTextBox.Clear()
        TotalPopTextBox.Clear()
        TotalMTextBox.Clear()
        TotalFTextBox.Clear()
        OFWTextBox.Clear()
        PWDTextBox.Clear()
        MonthsTextBox.Clear()
        TOTextBox.Clear()
        SOldTextBox.Clear()
        ThOldTextBox.Clear()
        SeniorTextBox.Clear()
    End Sub
End Class