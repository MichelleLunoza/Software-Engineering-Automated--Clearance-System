Public Class CBMS_TotalForm

    Private Sub OverallTotalCBMSButton_Click(sender As Object, e As EventArgs) Handles OverallTotalCBMSButton.Click

    End Sub

    Private Sub TotalCBMSButton_Click(sender As Object, e As EventArgs) Handles TotalCBMSButton.Click
        TotalCBMS_Purok.Show()
        Me.Hide()
    End Sub

    Private Sub CBMS_TotalForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ULabel.Text = LoginForm.TypeUserComboBox.SelectedItem.ToString
    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        CBMS_Form.Show()
        Me.Hide()
    End Sub
End Class