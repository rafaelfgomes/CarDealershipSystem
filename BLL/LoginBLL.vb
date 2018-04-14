Imports DAL
Imports DTO

Public Class LoginBLL

    Dim dal As LoginDAL = New LoginDAL

    Public Function login(ByVal dto As LoginDTO) As Boolean

        Return dal.login(dto)

    End Function

End Class
