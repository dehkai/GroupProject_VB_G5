Imports System.Data.OleDb
Public Class SubjectListForm
    Private conn As New OleDb.OleDbConnection
    Dim cmd As OleDbCommand
    Dim dt As New DataTable
    Dim da As New OleDbDataAdapter(cmd)
    Dim subjectCode As String
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
        SubjectListDataGridView.ColumnHeadersDefaultCellStyle.Font = New Font("Microsoft Sans Serif", 12.0F)
        SubjectListDataGridView.DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 12.0F)
    End Sub

    Private Sub SubjectListForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\ydk14\OneDrive\Desktop\GroupProject_VB_G5\ProjectDemoCRS\bin\Debug\ihsanTuitionCenterDb.accdb"
        conn.ConnectionString = My.Resources.databaseConnectionPath & Application.StartupPath & My.Resources.databaseName
        SearchTextBox.Text = "Search"
        SearchTextBox.ForeColor = Color.Silver
        Me.ViewStudentListButton.Enabled = False
        viewer()


    End Sub

    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click

        Try
            conn.Open()
            cmd = conn.CreateCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "insert into subject(subjectCode,subjectName,credit)values('" + SubjectCodeTextBox.Text +
            "','" + SubjectNameTextBox.Text + "','" + CreditTextBox.Text + "')"
            cmd.ExecuteNonQuery()
            conn.Close()
            MessageBox.Show("Record Added", "Paragon Private and International School Database", MessageBoxButtons.OK, MessageBoxIcon.Information)
            SearchByCodeButton_Click(New Object, New EventArgs())
            viewer()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Paragon Private and International School Database", MessageBoxButtons.OK, MessageBoxIcon.Error)
            conn.Close()
        End Try



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
            conn.Close()
        End Try
    End Sub

    Private Sub SubjectListDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles SubjectListDataGridView.CellClick
        Try
            SubjectCodeTextBox.Text = SubjectListDataGridView.SelectedRows(0).Cells(0).Value.ToString()
            SubjectNameTextBox.Text = SubjectListDataGridView.SelectedRows(0).Cells(1).Value.ToString()
            CreditTextBox.Text = SubjectListDataGridView.SelectedRows(0).Cells(2).Value.ToString()
            subjectCode = SubjectListDataGridView.CurrentCell.Value
            Try
                If (subjectCode <> "") Then
                    Me.ViewStudentListButton.Enabled = True
                End If
            Catch ex As Exception
                Me.ViewStudentListButton.Enabled = False
            End Try


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Paragon Private and International School Database", MessageBoxButtons.OK, MessageBoxIcon.Error)
            conn.Close()
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
            conn.Close()
        End Try
    End Sub

    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
        Try
            conn.Open()
            cmd = conn.CreateCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "delete * from subject where subjectCode = '" + SubjectCodeTextBox.Text + "'"
            cmd.ExecuteNonQuery()
            conn.Close()
            MessageBox.Show("Record Deleted", "Paragon Private and International School Database", MessageBoxButtons.OK, MessageBoxIcon.Information)
            SearchByCodeButton_Click(New Object, New EventArgs())
            viewer()
            SubjectCodeTextBox.Text = ""
            SubjectNameTextBox.Text = ""
            CreditTextBox.Text = ""
            SearchTextBox.Text = "Search"
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Paragon Private and International School Database", MessageBoxButtons.OK, MessageBoxIcon.Error)
            conn.Close()
        End Try
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        SubjectCodeTextBox.Text = ""
        SubjectNameTextBox.Text = ""
        CreditTextBox.Text = ""
        SearchTextBox.Text = "Search"
    End Sub



    Private Sub SearchTextBox_MouseEnter(sender As Object, e As EventArgs) Handles SearchTextBox.MouseEnter
        SearchTextBox.Text = ""
        SearchTextBox.Focus()
        SearchTextBox.ForeColor = Color.Black
    End Sub

    Private Sub SearchTextBox_MouseLeave(sender As Object, e As EventArgs) Handles SearchTextBox.MouseLeave
        If (SearchTextBox.Text = "") Then
            SearchTextBox.Text = "Search"
            SearchTextBox.ForeColor = Color.Silver
        End If
    End Sub

    Private Sub ViewAllButton_Click(sender As Object, e As EventArgs) Handles ViewAllButton.Click
        viewer()
    End Sub

    Private Sub SearchByNameButton_Click(sender As Object, e As EventArgs) Handles SearchByNameButton.Click
        Dim checker As Integer
        Try
            conn.Open()
            cmd = conn.CreateCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "select * from subject where subjectName = '" + SearchTextBox.Text + "'"
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
            conn.Close()
        End Try
    End Sub

    Private Sub SubjectCodeTextBox_TextChanged(sender As Object, e As EventArgs) Handles SubjectCodeTextBox.TextChanged

    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub ViewStudentListButton_Click(sender As Object, e As EventArgs) Handles ViewStudentListButton.Click
        StudentListBySubjectCodeForm.showStudentInformation(subjectCode)
        StudentListBySubjectCodeForm.ShowDialog()
        'dsataseasdasdaswqasdasdasdaasdasdasdasdasdasdasdasd
    End Sub

    Private Sub SubjectListDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles SubjectListDataGridView.CellContentClick

    End Sub
End Class