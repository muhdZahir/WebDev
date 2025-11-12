Public Class FrmState
    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        Dim intStCode As Integer = txtICNumber.Text.Substring(6, 2)
        lblStateName.Text = GetStateName(intStCode)
    End Sub
End Class