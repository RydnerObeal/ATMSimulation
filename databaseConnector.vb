Imports MySql.Data.MySqlClient
Module databaseConnector
    Public cn As New MySqlConnection
    Public cmd As New MySqlCommand
    Public dr As MySqlDataReader
    Public sql As String

    Public Sub Connect()
        cn.Close()
        cn.ConnectionString = "server=localhost;user=root;password=;database=atm_system"
        cn.Open()
    End Sub
End Module
