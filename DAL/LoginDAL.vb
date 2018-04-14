Imports System.Data.SqlClient
Imports DTO

Public Class LoginDAL

    Dim cn As SqlConnection = New SqlConnection(Connection.Connect)
    Dim cmd As SqlCommand = New SqlCommand
    Dim dr As SqlDataReader

    Public Function login(ByVal dto As LoginDTO) As String

        Dim accesType As String = Nothing

        Try

            cmd.CommandText = "SP_SYSTEM_USER_LOGIN"
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.Clear()

            cmd.Parameters.AddWithValue("USER", dto.UserName)
            cmd.Parameters.AddWithValue("PASS", dto.UserPassword)

            cmd.Connection = cn
            cn.Open()

            dr = cmd.ExecuteReader()

            If dr.HasRows Then

                While dr.Read

                    accesType = dr("PROFILE_NAME").ToString()

                End While

                Return accesType

            Else

                Return accesType

            End If

        Catch ex As SqlException

            Throw New Exception(String.Format("Erro SQL {0}: {1}", ex.Number, ex.Message))

        Catch ex As Exception

            Throw New Exception(ex.Message)

        Finally

            dr.Close()
            cn.Close()

        End Try

    End Function

End Class
