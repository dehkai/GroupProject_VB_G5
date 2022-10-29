Imports MySql.Data.MySqlClient
Imports System.Data.OleDb
Public Class LoginModel

    Private con As New OleDb.OleDbConnection


    Public Function checkLogin(username As String, password As String) As Boolean
        Dim successBoolean As Boolean
        Try
            Dim sql As String

            successBoolean = False
            ''Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\registrationdb.accdb")
            con.ConnectionString = My.Resources.databaseConnectionPath & Application.StartupPath & My.Resources.databaseName
            con.Open()
            If con.State = ConnectionState.Open Then

            Else
                MsgBox("error connecting to database")
                Exit Function
            End If
            sql = "SELECT count(*) FROM usertbl WHERE userName= '" + username + "' and password = '" + password + "'"
            ' MessageBox.Show(sql)
            Debug.WriteLine(sql)
            Dim cmd As New OleDbCommand(sql, con)
            'cmd.ExecuteNonQuery()

            Dim count = Convert.ToInt32(cmd.ExecuteScalar())

            If (count > 0) Then
                successBoolean = True
            ElseIf count = 0 Then
                MessageBox.Show("Fail to Search the User Account")
                successBoolean = False

            End If
            con.Close()
        Catch ex As Exception

            MessageBox.Show("Did't found user Account:" & ex.ToString)
        End Try
        Return successBoolean

    End Function
End Class
