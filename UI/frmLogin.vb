Imports DTO
Imports BLL

Public Class frmLogin

    Dim dto As LoginDTO = New LoginDTO
    Dim bll As LoginBLL = New LoginBLL

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        dto.UserName = txtUserName.Text
        dto.UserPassword = txtUserPassword.Text

        Dim accessType As String = bll.login(dto)

        If Not IsNothing(accessType) Then

            If accessType.Contains("Administrador") Then

                MessageBox.Show("Administrador", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If

        Else

            MessageBox.Show("Inválido", "Errrrou!!!", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If

    End Sub

End Class