Public Class TeacherListForm
    Public conn As New OleDb.OleDbConnection
    Dim ds As New DataSet
    Dim dataAdapter As New OleDb.OleDbDataAdapter

    Dim sqlString As String
    Dim mStaffNoString As String
    Dim teacherMdl As New Teacher
    Private Sub TeacherListForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        disableButton()
        conn.ConnectionString = My.Resources.databaseConnectionPath & Application.StartupPath & My.Resources.databaseName
        Try
            'opens the connection
            conn.Open()
            If conn.State = ConnectionState.Open Then
                displayAllTeacher()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        'close the connection
        conn.Close()
    End Sub

    Private Sub displayAllTeacher()
        clearTeacherGrid()
        sqlString = "Select * from teacher"
        dataAdapter = New OleDb.OleDbDataAdapter(sqlString, conn)
        dataAdapter.Fill(ds, "ihsanTuitionCenterDb")
        Me.TeacherDataGridView.DataMember = "ihsanTuitionCenterDb"
        TeacherDataGridView.DataSource = ds
        TeacherDataGridView.ColumnHeadersDefaultCellStyle.Font = New Font("Microsoft Sans Serif", 10.0F)
        TeacherDataGridView.DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 10.0F)
    End Sub

    Private Sub clearTeacherGrid()
        Me.ds.Clear()
    End Sub

    Private Sub disableButton()
        With Me
            .AddTeacherButton.Enabled = False
            .updateTeacherButton.Enabled = False
            .DeleteTeacherButton.Enabled = False
        End With
    End Sub

    Private Sub enableButton()
        With Me
            .AddTeacherButton.Enabled = True
            .updateTeacherButton.Enabled = True
            .DeleteTeacherButton.Enabled = True
        End With
    End Sub



    Private Sub DeleteTeacherButton_Click(sender As Object, e As EventArgs) Handles DeleteTeacherButton.Click
        Dim dialogResult As MsgBoxResult
        Dim deletedOK As Boolean
        Dim messageString = "Delete teacher  :" & mStaffNoString
        If mStaffNoString <> "" Then
            dialogResult = MessageBox.Show(messageString, "Confirm Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            If dialogResult = MsgBoxResult.Ok Then
                deletedOK = teacherMdl.deleteTeacherRecord(mStaffNoString)
                displayAllTeacher()
            End If
        End If
    End Sub

    Private Sub AddTeacherButton_Click(sender As Object, e As EventArgs) Handles AddTeacherButton.Click
        TeacherForm.prepareToAddNewTeacher()
        TeacherForm.ShowDialog()
        'Me.StudentGroupDataGridView.Refresh()
        displayAllTeacher()
    End Sub

    Private Sub ICButton_Click(sender As Object, e As EventArgs) Handles ICButton.Click
        clearTeacherGrid()

        sqlString = "Select * from teacher where icNumber like '%" & searchTextBox.Text & "%'"
        Debug.WriteLine(sqlString)
        dataAdapter = New OleDb.OleDbDataAdapter(sqlString, conn)
        dataAdapter.Fill(ds, "ihsanTuitionCenterDb")
        Me.TeacherDataGridView.DataMember = "ihsanTuitionCenterDb"
        TeacherDataGridView.DataSource = ds
    End Sub

    Private Sub nameButton_Click(sender As Object, e As EventArgs) Handles nameButton.Click
        clearTeacherGrid()

        sqlString = "Select * from teacher where name like '%" & searchTextBox.Text & "%'"
        Debug.WriteLine(sqlString)
        dataAdapter = New OleDb.OleDbDataAdapter(sqlString, conn)
        dataAdapter.Fill(ds, "ihsanTuitionCenterDb")
        Me.TeacherDataGridView.DataMember = "ihsanTuitionCenterDb"
        TeacherDataGridView.DataSource = ds
    End Sub

    Private Sub displayAllButton_Click(sender As Object, e As EventArgs) Handles displayAllButton.Click
        displayAllTeacher()
    End Sub

    Private Sub updateTeacherButton_Click(sender As Object, e As EventArgs) Handles updateTeacherButton.Click
        If mStaffNoString <> "" Then
            TeacherForm.prepareToUpdateTeacher(mStaffNoString)
            TeacherForm.ShowDialog()
            displayAllTeacher()
        End If
    End Sub

    Private Sub TeacherDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles TeacherDataGridView.CellClick
        Dim cb As New OleDb.OleDbCommandBuilder(dataAdapter)
        Dim col, inc As Integer

        Try
            col = TeacherDataGridView.CurrentCell.ColumnIndex
            If col <> 0 Then
                disableButton()
                Exit Sub
            End If
            inc = TeacherDataGridView.CurrentCell.RowIndex
            mStaffNoString = TeacherDataGridView.CurrentCell.Value
            If (mStaffNoString <> "") Then
                enableButton()
            Else
                disableButton()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
End Class