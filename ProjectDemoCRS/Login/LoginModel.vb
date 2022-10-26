Imports MySql.Data.MySqlClient
Imports System.Data.OleDb
Public Class LoginModel

    Private con As New OleDb.OleDbConnection


    Public Function checkLogin(username As String, password As String) As Boolean
        Try
            Dim sql As String
            ''Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\registrationdb.accdb")
            con.ConnectionString = My.Resources.databaseConnectionPath & Application.StartupPath & My.Resources.databaseName
            con.Open()
            If con.State = ConnectionState.Open Then
                MsgBox("Welcome!")
            Else
                MsgBox("error connecting to database")
                Exit Function
            End If
            sql = "SELECT * FROM usertbl WHERE userName= '" + username + "' and password = '" + password + "'"
            ' MessageBox.Show(sql)
            ' Debug.WriteLine(sql)
            Dim cmd As New OleDbCommand(sql, con)
            cmd.ExecuteNonQuery()
            con.Close()
        Catch ex As Exception

            MessageBox.Show("Did't found user Account:" & ex.ToString)
        End Try
        Return True
        'Dim cmd As New MySqlCommand
        'Dim sqlString As String
        'Dim successBoolean As Boolean
        'Dim Reader As MySqlDataReader
        'successBoolean = False
        'createConnection()
        'Try
        '    sqlString = "SELECT * FROM usertbl WHERE userName= '" + username + "' and password = '" + password + "'"
        '    cmd = New MySqlCommand(sqlString, con)
        '    Reader = cmd.ExecuteReader
        '    Debug.WriteLine(sqlString)
        '    Dim count As Integer
        '    count = 0

        '    While Reader.Read
        '        count += 1

        '    End While

        '    If (count = 1) Then
        '        MessageBox.Show("Successfully found the username")
        '        successBoolean = True
        '    ElseIf count = 0 Then
        '        MessageBox.Show("fail to found the username")
        '        successBoolean = False

        '    End If
        '    'If cmd.ExecuteNonQuery() = 1 Then 'success

        '    '    successBoolean = True
        '    '    Debug.WriteLine("username " + username + " has been found")
        '    'End If
        '    con.Close()
        '    Return successBoolean
        'Catch ex As MySqlException
        '    MessageBox.Show(ex.Message)
        'Finally
        '    con.Dispose()
        'End Try
    End Function
End Class
