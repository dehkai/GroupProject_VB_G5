Public Class StudentListForm
    Public conn As New OleDb.OleDbConnection
    Dim ds As New DataSet
    Dim dataAdapter As New OleDb.OleDbDataAdapter

    Dim sqlString As String
    Dim mMatricString As String
    Dim studentMdl As New Student

    Private Sub StudentListForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        disableButton()

        'you can use multiple option in connecting to the database - the following are 3 example to set the connection string
        ' conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\ihsanTuitionCenterDb.accdb"
        conn.ConnectionString = My.Resources.databaseConnectionPath & Application.StartupPath & My.Resources.databaseName
        ' conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\UTM\SEM I20212022\DDWC2653 VBNetLabDemo
        '\DemoProject\ProjectDemoCRS\ProjectDemoCRS\bin\Debug\ihsanTuitionCenterDb.accdb"

        Try
            'opens the connection
            conn.Open()
            If conn.State = ConnectionState.Open Then
                MsgBox("MS Database Connected!")
                displayAllStudent()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        'close the connection
        conn.Close()
    End Sub
    Private Sub displayAllStudent()
        clearStudentGrid()
        sqlString = "Select * from student"
        dataAdapter = New OleDb.OleDbDataAdapter(sqlString, conn)
        dataAdapter.Fill(ds, "ihsanTuitionCenterDb")
        Me.StudentDataGridView.DataMember = "ihsanTuitionCenterDb"
        StudentDataGridView.DataSource = ds
    End Sub
    Private Sub clearStudentGrid()
        Me.ds.Clear() 'clear the original data
    End Sub
    Private Sub disableButton()
        With Me
            .AddStudentButton.Enabled = False
            .updateStudentButton.Enabled = False
            .DeleteStudentButton.Enabled = False
        End With
    End Sub
    Private Sub enableButton()
        With Me
            .AddStudentButton.Enabled = True
            .updateStudentButton.Enabled = True
            .DeleteStudentButton.Enabled = True
        End With
    End Sub
    Private Sub AddStudentButton_Click(sender As Object, e As EventArgs) Handles AddStudentButton.Click
        StudentForm.prepareToAddNewStudent()
        StudentForm.ShowDialog()
        'Me.StudentGroupDataGridView.Refresh()
        displayAllStudent()
    End Sub

    Private Sub StudentDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles StudentDataGridView.CellClick
        Dim cb As New OleDb.OleDbCommandBuilder(dataAdapter)
        Dim col, inc As Integer
        ' MessageBox.Show(StudentGroupDataGridView.CurrentCell.ColumnIndex)
        Try
            col = StudentDataGridView.CurrentCell.ColumnIndex
            If col <> 0 Then 'ignore if not click on primary key - groupId
                disableButton()
                Exit Sub
            End If
            inc = StudentDataGridView.CurrentCell.RowIndex
            'store the selected studentGroupId from the cell selection
            mMatricString = StudentDataGridView.CurrentCell.Value
            If (mMatricString <> "") Then
                enableButton()
            Else
                disableButton()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub updateStudentButton_Click(sender As Object, e As EventArgs) Handles updateStudentButton.Click
        If mMatricString <> "" Then
            StudentForm.prepareToUpdateStudent(mMatricString)
            StudentForm.ShowDialog()
            displayAllStudent()
        End If
    End Sub

    Private Sub DeleteStudentButton_Click(sender As Object, e As EventArgs) Handles DeleteStudentButton.Click
        Dim dialogResult As MsgBoxResult
        Dim deletedOK As Boolean
        Dim messageString = "Delete Student  :" & mMatricString
        If mMatricString <> "" Then
            dialogResult = MessageBox.Show(messageString, "Confirm Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            If dialogResult = MsgBoxResult.Ok Then
                deletedOK = studentMdl.deleteStudentRecord(mMatricString)
                displayAllStudent()
            End If
        End If
    End Sub

    Private Sub nameButton_Click(sender As Object, e As EventArgs) Handles nameButton.Click
        clearStudentGrid()

        sqlString = "Select * from student where name like '%" & searchTextBox.Text & "%'"
        Debug.WriteLine(sqlString)
        dataAdapter = New OleDb.OleDbDataAdapter(sqlString, conn)
        dataAdapter.Fill(ds, "ihsanTuitionCenterDb")
        Me.StudentDataGridView.DataMember = "ihsanTuitionCenterDb"
        StudentDataGridView.DataSource = ds
    End Sub

    Private Sub displayAllButton_Click(sender As Object, e As EventArgs) Handles displayAllButton.Click
        displayAllStudent()
    End Sub
End Class