Public Class MainForm

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ULabel.Text = LoginForm.TypeUserComboBox.SelectedItem.ToString
    End Sub

    Private Sub ClearancesButton_Click(sender As Object, e As EventArgs) Handles ClearancesButton.Click
        ClearanceForm.Show()
        Me.Hide()
    End Sub

    Private Sub CBMSButton_Click(sender As Object, e As EventArgs) Handles CBMSButton.Click
        CBMS_Form.Show()
        Me.Hide()
    End Sub
End Class