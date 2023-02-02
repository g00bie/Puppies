Public Class frmMain
    Private Sub btnPuppy_Click(sender As Object, e As EventArgs) Handles btnPuppy.Click
        Me.BackgroundImage = My.Resources.skelton
        btnPuppy.Visible = False
        Label1.Visible = True
    End Sub
End Class
