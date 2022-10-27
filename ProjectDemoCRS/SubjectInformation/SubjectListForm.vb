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

End Class