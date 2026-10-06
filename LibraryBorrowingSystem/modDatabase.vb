Imports MySql.Data.MySqlClient
Module modDatabase
    Public sqlcon As New MySqlConnection
    Public db_server As String = "localhost"
    Public db_username As String = "root"
    Public db_password As String = ""
    Public db_port As String = "3306"
    Public db_database As String = "library_borrowing_system"

    Public Sub connectDB()
        sqlcon = New MySqlConnection("server=" & db_server & "; port=" & db_port & "; user id=" & db_username & "; password=" & db_password & "; database=" & db_database & ";")
        sqlcon.Open()
    End Sub

    Public Sub disconnectDB()
        sqlcon.Close()
    End Sub
End Module
