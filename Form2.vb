Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnOK.Click
        DialogResult = DialogResult.OK


    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        DialogResult = DialogResult.Cancel
    End Sub
End Class