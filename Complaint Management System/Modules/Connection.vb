Imports MySql.Data.MySqlClient

Module Connection

    Public da As MySqlDataAdapter = New MySqlDataAdapter
    Public cmbldr As MySqlCommandBuilder
    'Public Sqlds As DataSet = New DataSet
    'Public Sqlda As MySqlDataAdapter = New MySqlDataAdapter
    'Public Sqlcmbldr As MySqlCommandBuilder
    Public ds As DataSet = New DataSet
    Public dr As DataRow
    Public dt As DataTable

    Public strConnection As String = "Server=" & GetServerName() & ";Database=" & DatabaseName & ";Uid=" & UserID & ";password=" & GetPassword() & ";Allow Zero Datetime=true;"
    Public cn As MySqlConnection = New MySqlConnection(strConnection)

    Public strConPsion As String = "Server=" & GetServerName() & ";Database=" & DatabaseNamePsion & ";Uid=" & UserID & ";password=" & GetPassword() & ";Allow Zero Datetime=true;"
    Public cnPsion As MySqlConnection = New MySqlConnection(strConPsion)

    Public Function GetServerName() As String

        Dim oRead As System.IO.StreamReader

        oRead = IO.File.OpenText(Application.StartupPath & "\servername.txt")
        GetServerName = oRead.ReadToEnd()

        Return GetServerName

    End Function

    Public Function GetPassword() As String

        Dim oRead As System.IO.StreamReader

        oRead = IO.File.OpenText(Application.StartupPath & "\password.txt")
        GetPassword = oRead.ReadToEnd()

        Return GetPassword

    End Function

    Public Function CheckConnection(ByVal conn As MySqlConnection) As MySqlConnection
        'Try
        'This function checks the recordset if it is open.
        'if it is open, then it will close the recordset
        If conn.State <> ConnectionState.Open Then
            conn.Open()
        End If
        Return conn
        'Catch ex As Exception
        'MessageBox.Show(ex.Message, "Connection to SQL Server failed", MessageBoxButtons.OK)
        End
        'End Try

    End Function

End Module
