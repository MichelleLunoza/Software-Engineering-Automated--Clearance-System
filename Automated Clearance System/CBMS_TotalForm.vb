Public Class CBMS_TotalForm

    Private Sub CIDButton_Click(sender As Object, e As EventArgs) Handles CIDButton.Click

    End Sub
    Private Sub BCDButton_Click(sender As Object, e As EventArgs) Handles BCDButton.Click

    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click

    End Sub

    Private Sub CBMS_TotalForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()

        ULabel.Text = LoginForm.TypeUserComboBox.SelectedItem.ToString
        Me.DateLabel.Text = DateTime.Now.ToString("mm/dd/yyy")
        Me.TimeLabel.Text = TimeOfDay.ToString("hh:mm:ss")
    End Sub
End Class