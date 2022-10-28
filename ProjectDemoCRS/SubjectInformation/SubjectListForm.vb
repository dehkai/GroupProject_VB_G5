Imports System.Data.OleDb
Public Class SubjectListForm
    Dim conn As New OleDbConnection
    Dim cmd As OleDbCommand
    Dim dt As New DataTable
    Dim da As New OleDbDataAdapter(cmd)

    Private bitmap As Bitmap

    Private Sub viewer()
        conn.Open()
        cmd = conn.CreateCommand()
        cmd.CommandType = CommandType.Text
        da = New OleDbDataAdapter("select * from subject", conn)
        da.Fill(dt)
        SubjectListDataGridView.DataSource = dt
        conn.Close()
        SubjectListDataGridView.Columns(0).Width = 150
        SubjectListDataGridView.Columns(1).Width = 500
        SubjectListDataGridView.Columns(2).Width = 145

    End Sub

    Private Sub SubjectListForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\ydk14\OneDrive\Desktop\GroupProject_VB_G5\ProjectDemoCRS\bin\Debug\ihsanTuitionCenterDb.accdb"
        SearchTextBox.Text = "Search"
        SearchTextBox.ForeColor = Color.Silver
        viewer()


    End Sub

    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click
        conn.Open()
        cmd = conn.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "insert into subject(subjectCode,subjectName,credit)values('" + SubjectCodeTextBox.Text +
        "','" + SubjectNameTextBox.Text + "','" + CreditTextBox.Text + "')"
        cmd.ExecuteNonQuery()
        conn.Close()
        MessageBox.Show("Record Saved", "Paragon Private and International School Database", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Private Sub UpdateButton_Click(sender As Object, e As EventArgs) Handles UpdateButton.Click
        Try
            conn.Open()
            cmd = conn.CreateCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "update subject set subjectCode = '" + SubjectCodeTextBox.Text + "',subjectName = '" + SubjectNameTextBox.Text + "',credit = '" + CreditTextBox.Text + "' where subjectCode = '" + SubjectCodeTextBox.Text + "'"
            cmd.ExecuteNonQuery()
            conn.Close()
            MessageBox.Show("Record Updated", "Paragon Private and International School Database", MessageBoxButtons.OK, MessageBoxIcon.Information)
            SearchByCodeButton_Click(New Object, New EventArgs())
            viewer()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Paragon Private and International School Database", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub SubjectListDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles SubjectListDataGridView.CellClick
        Try
            SubjectCodeTextBox.Text = SubjectListDataGridView.SelectedRows(0).Cells(0).Value.ToString()
            SubjectNameTextBox.Text = SubjectListDataGridView.SelectedRows(0).Cells(1).Value.ToString()
            CreditTextBox.Text = SubjectListDataGridView.SelectedRows(0).Cells(2).Value.ToString()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub SearchByCodeButton_Click(sender As Object, e As EventArgs) Handles SearchByCodeButton.Click
        Dim checker As Integer
        Try
            conn.Open()
            cmd = conn.CreateCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "select * from subject where subjectCode = '" + SearchTextBox.Text + "'"
            cmd.ExecuteNonQuery()
            dt = New DataTable()
            da = New OleDbDataAdapter(cmd)
            da.Fill(dt)
            checker = Convert.ToInt32(dt.Rows.Count.ToString)
            SubjectListDataGridView.DataSource = dt
            conn.Close()
            If (checker = 0) Then
                SearchTextBox.Text = "Search"
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Paragon Private and International School Database", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class