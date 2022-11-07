Imports System.Data.OleDb
Public Class UserListForm
    Private conn As New OleDb.OleDbConnection
    Dim cmd As OleDbCommand
    Dim dt As New DataTable
    Dim da As New OleDbDataAdapter(cmd)

    Private Sub updateTable()
        conn.Open()
        cmd = conn.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from userTbl"
        cmd.ExecuteNonQuery()
        dt = New DataTable()
        da = New OleDbDataAdapter(cmd)
        da.Fill(dt)
        UserListDataGridView.DataSource = dt
        conn.Close()
    End Sub
    Private Sub viewer()
        conn.Open()
        cmd = conn.CreateCommand()
        cmd.CommandType = CommandType.Text
        da = New OleDbDataAdapter("select * from userTbl", conn)
        da.Fill(dt)
        UserListDataGridView.DataSource = dt
        conn.Close()
        UserListDataGridView.Columns(0).Width = 150
        UserListDataGridView.Columns(1).Width = 500
        UserListDataGridView.Columns(2).Width = 145
        UserListDataGridView.ColumnHeadersDefaultCellStyle.Font = New Font("Microsoft Sans Serif", 12.0F)
        UserListDataGridView.DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 12.0F)
    End Sub

    Private Sub UserListForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = My.Resources.databaseConnectionPath & Application.StartupPath & My.Resources.databaseName
        viewer()
    End Sub

    Private Sub AddUserButton_Click(sender As Object, e As EventArgs) Handles AddUserButton.Click
        Try
            conn.Open()
            cmd = conn.CreateCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "insert into userTbl values('" + UsernameTextBox.Text +
            "','" + PasswordTextBox.Text + "','" + UserLevelTextBox.Text + "')"
            cmd.ExecuteNonQuery()
            conn.Close()
            MessageBox.Show("Record Added", "Paragon Private and International School Database", MessageBoxButtons.OK, MessageBoxIcon.Information)
            viewer()
            updateTable()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Paragon Private and International School Database", MessageBoxButtons.OK, MessageBoxIcon.Error)
            conn.Close()
        End Try
    End Sub

    Private Sub ResetPasswordButton_Click(sender As Object, e As EventArgs) Handles ResetPasswordButton.Click
        Dim sqlString As String
        Try
            conn.Open()
            cmd = conn.CreateCommand()
            cmd.CommandType = CommandType.Text
            'cmd.CommandText = "update userTbl set password = '" + PasswordTextBox.Text + "' where userName = '" + UsernameTextBox.Text + "'"
            sqlString = "update userTbl set [password] = '" + PasswordTextBox.Text + "' where [userName] = '" + UsernameTextBox.Text + "'"
            cmd.CommandText = sqlString
            cmd.ExecuteNonQuery()
            conn.Close()
            MessageBox.Show("Record Updated", "Paragon Private and International School Database", MessageBoxButtons.OK, MessageBoxIcon.Information)
            viewer()
            updateTable()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Paragon Private and International School Database", MessageBoxButtons.OK, MessageBoxIcon.Error)
            conn.Close()
        End Try
    End Sub

    Private Sub UserListDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles UserListDataGridView.CellClick
        Try
            UsernameTextBox.Text = UserListDataGridView.SelectedRows(0).Cells(0).Value.ToString()
            PasswordTextBox.Text = UserListDataGridView.SelectedRows(0).Cells(1).Value.ToString()
            UserLevelTextBox.Text = UserListDataGridView.SelectedRows(0).Cells(2).Value.ToString()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Paragon Private and International School Database", MessageBoxButtons.OK, MessageBoxIcon.Error)
            conn.Close()
        End Try
    End Sub

    Private Sub DeleteUserButton_Click(sender As Object, e As EventArgs) Handles DeleteUserButton.Click
        Try
            conn.Open()
            cmd = conn.CreateCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "delete * from userTbl where userName = '" + UsernameTextBox.Text + "'"
            cmd.ExecuteNonQuery()
            conn.Close()
            MessageBox.Show("Record Deleted", "Paragon Private and International School Database", MessageBoxButtons.OK, MessageBoxIcon.Information)
            viewer()
            UsernameTextBox.Text = ""
            PasswordTextBox.Text = ""
            UserLevelTextBox.Text = ""
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Paragon Private and International School Database", MessageBoxButtons.OK, MessageBoxIcon.Error)
            conn.Close()
        End Try
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        UsernameTextBox.Text = ""
        PasswordTextBox.Text = ""
        UserLevelTextBox.Text = ""
    End Sub
End Class