Public Class FormPoint
    Private Sub BtnSubtract_Click(sender As Object, e As EventArgs) Handles BtnSubtract.Click
        lblPoint.Text = lblPoint.Text - 1
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        lblPoint.Text = lblPoint.Text + 1
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        lblPoint.Text = 0
    End Sub
End Class