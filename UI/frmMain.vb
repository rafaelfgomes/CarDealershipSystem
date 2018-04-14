Public Class frmMain

    Private Sub menuLogin_Click(sender As Object, e As EventArgs) Handles menuLogin.Click

        frmLogin.MdiParent = Me
        frmLogin.Show()

    End Sub

End Class
