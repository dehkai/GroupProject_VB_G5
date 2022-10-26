Imports MySql.Data.MySqlClient
Public Class LoginModel
    Dim con As New MySqlConnection()
    Dim conString As String = "server = localhost;user id = vbproject;password=vbproject;database=vbproject"
    Public Sub createConnection()
        Try
            If con.State <> ConnectionState.Open Then
                'MsgBox("MS Database Connected!")
                con.ConnectionString = conString
                con.Open()
            End If
        Catch ex As Exception
            MessageBox.Show("ERROR CONNECTING TO MYSQL" + ControlChars.NewLine + ex.ToString)
        End Try
    End Sub

    Public Function checkLogin(username As String, password As String) As Boolean
        Dim cmd As New MySqlCommand
        Dim sqlString As String
        Dim successBoolean As Boolean
        Dim Reader As MySqlDataReader
        successBoolean = False
        createConnection()
        Try
            sqlString = "SELECT * FROM usertbl WHERE userName= '" + username + "' and password = '" + password + "'"
            cmd = New MySqlCommand(sqlString, con)
            Reader = cmd.ExecuteReader
            Debug.WriteLine(sqlString)
            Dim count As Integer
            count = 0

            While Reader.Read
                count += 1

            End While

            If (count = 1) Then
                MessageBox.Show("Successfully found the username")
                successBoolean = True
            ElseIf count = 0 Then
                MessageBox.Show("fail to found the username")
                successBoolean = False

            End If
            'If cmd.ExecuteNonQuery() = 1 Then 'success

            '    successBoolean = True
            '    Debug.WriteLine("username " + username + " has been found")
            'End If
            con.Close()
            Return successBoolean
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            con.Dispose()
        End Try
        Return successBoolean
    End Function
End Class
