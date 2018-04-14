Public Class LoginDTO

    Private _id As Integer
    Private _userName As String
    Private _userPassword As String

    Public Property Id As Integer

        Get

            Return _id

        End Get

        Set(value As Integer)

            _id = value

        End Set

    End Property

    Public Property UserName As String

        Get

            Return _userName

        End Get

        Set(value As String)

            _userName = value

        End Set

    End Property

    Public Property UserPassword As String

        Get

            Return _userPassword

        End Get

        Set(value As String)

            _userPassword = value

        End Set

    End Property

End Class
