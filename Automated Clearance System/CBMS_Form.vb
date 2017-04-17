Public Class CBMS_Form

    Private Sub CBMS_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ULabel.Text = LoginForm.TypeUserComboBox.SelectedItem.ToString
        Timer1.Start()
        Me.DateLabel.Text = DateTime.Now.ToString("mm/dd/yyy")
        Me.TimeLabel.Text = TimeOfDay.ToString("hh:mm:ss")

    End Sub

    Private Sub BCDButton_Click(sender As Object, e As EventArgs) Handles BCDButton.Click
        CBMS_DetailsForm.Show()
        Me.Hide()
    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        MainForm.Show()
        Me.Hide()
    End Sub

    Private Sub CIDButton_Click(sender As Object, e As EventArgs) Handles CIDButton.Click
        CBMS_TotalForm.Show()
        Me.Hide()
    End Sub
End Class