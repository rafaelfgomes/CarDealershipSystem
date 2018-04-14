Imports DTO
Imports BLL

Public Class frmLogin

    Dim dto As LoginDTO = New LoginDTO
    Dim bll As LoginBLL = New LoginBLL

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        dto.UserName = txtUserName.Text
        dto.UserPassword = txtUserPassword.Text

        If bll.login(dto) Then

            MessageBox.Show("Login Ok", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Else

            MessageBox.Show("Inválido", "Errrrou!!!", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If

    End Sub

End Class