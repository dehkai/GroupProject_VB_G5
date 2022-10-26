Imports MySql.Data.MySqlClient
Public Class LoginModel
    Dim con As New MySqlConnection()
    Dim conString As String = "server = localhost;user id = vbproject;password=vbproject;database=vbproject"
    Private Sub createConnection()
        Try
            If con.State <> ConnectionState.Open Then
                con.ConnectionString = conString
                con.Open()
            End If
        Catch ex As Exception
            MessageBox.Show("ERROR CONNECTING TO MYSQL" + ControlChars.NewLine + ex.ToString)
        End Try
    End Sub

    Public Function checkLogin(user As UserClass) As Boolean
        Dim cmd As New MySqlCommand
        Dim sqlString As String
        Dim successBoolean As Boolean
        successBoolean = False
        createConnection()
        Try
            sqlString = "SELECT * FROM usertbl WHERE userName= '" + user.userName.ToString + "' and password = '" + user.password.ToString + "'"
            cmd.CommandType = System.Data.CommandType.Text
            cmd.CommandText = sqlString
            cmd.Connection = con
            Debug.WriteLine(cmd.CommandText)
            If cmd.ExecuteNonQuery() = 1 Then 'success
                successBoolean = True
                Debug.WriteLine("Room " + user.userName.ToString + " has been deleted")
            End If
            con.Close()
            Return True
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            con.Dispose()
        End Try
        Return successBoolean
    End Function
End Class
