Imports MySql.Data.MySqlClient
Public Class StudentSubjectListForm
    Dim con As New MySqlConnection()
    Dim connectionString As String = "server = localhost;user id = vbproject;password=vbproject;database=vbproject"
    Private Sub displayListOfRoom()
        Dim sqlString As String
        Dim subjectTable As New DataTable
        Dim roomTableAdapter As New MySqlDataAdapter
        Try
            con.ConnectionString = connectionString
            con.Open() ' open the connection to mysql server using connection string
            sqlString = "Select * from subject order by subjectCode"
            Dim myCommand As New MySqlCommand
            myCommand.Connection = con
            myCommand.CommandType = CommandType.Text
            myCommand.CommandText = sqlString
            roomTableAdapter.SelectCommand = myCommand
            roomTableAdapter.Fill(subjectTable)
            con.Close()
            StudentSubjectDataGridView.DataSource = subjectTable

        Catch ex As Exception
            MessageBox.Show("Database error." + ControlChars.NewLine + ex.ToString)
        End Try
    End Sub
    Private Sub StudentSubjectListForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        displayListOfRoom()
    End Sub
End Class