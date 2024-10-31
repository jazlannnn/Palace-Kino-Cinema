Public Class frmSonic
    Private Sub frmSonic_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        frmMainPage.Show()
        Me.Close()
    End Sub
End Class