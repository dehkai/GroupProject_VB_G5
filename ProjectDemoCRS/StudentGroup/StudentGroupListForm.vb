Imports System.Data.OleDb
Public Class StudentGroupListForm
    Public conn As New OleDb.OleDbConnection
    Dim ds As New DataSet
    Dim dataAdapter As New OleDb.OleDbDataAdapter

    Dim sqlString As String
    Dim mstudentGroupId As String
    Dim studentGroupClass As New StudentGroupClass
    Private Sub StudentGroupForm_Load(sender As Object, e As EventArgs) Handles Me.Load
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
                displayAllStudentGroup()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        'close the connection
        conn.Close()
    End Sub
    Private Sub displayAllStudentGroup()
        clearStudentGrid()
        sqlString = "Select * from studentGroupTbl"
        dataAdapter = New OleDb.OleDbDataAdapter(sqlString, conn)
        dataAdapter.Fill(ds, "ihsanTuitionCenterDb")
        Me.StudentGroupDataGridView.DataMember = "ihsanTuitionCenterDb"
        StudentGroupDataGridView.DataSource = ds
    End Sub
    Private Sub clearStudentGrid()
        Me.ds.Clear() 'clear the original data
    End Sub

    Private Sub AddStudentGroupButton_Click(sender As Object, e As EventArgs) Handles AddStudentGroupButton.Click
        StudentGroupForm.prepareToAddNewStudentGroup()
        StudentGroupForm.ShowDialog()
        'Me.StudentGroupDataGridView.Refresh()
        displayAllStudentGroup()
    End Sub

    Private Sub updateClassButton_Click(sender As Object, e As EventArgs) Handles updateStudentGroupButton.Click
        If mstudentGroupId <> "" Then
            StudentGroupForm.prepareToUpdateStudentGroup(mstudentGroupId)
            StudentGroupForm.ShowDialog()
            displayAllStudentGroup()
        End If
    End Sub

    Private Sub StudentGroupDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles StudentGroupDataGridView.CellClick

        Dim cb As New OleDb.OleDbCommandBuilder(dataAdapter)
        Dim col, inc As Integer
        ' MessageBox.Show(StudentGroupDataGridView.CurrentCell.ColumnIndex)
        Try
            col = StudentGroupDataGridView.CurrentCell.ColumnIndex
            If col <> 0 Then 'ignore if not click on primary key - groupId
                disableButton()
                Exit Sub
            End If
            inc = StudentGroupDataGridView.CurrentCell.RowIndex
            'store the selected studentGroupId from the cell selection
            mstudentGroupId = StudentGroupDataGridView.CurrentCell.Value
            If (mstudentGroupId <> "") Then
                enableButton()
            Else
                disableButton()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Private Sub disableButton()
        With Me
            .AddStudentGroupButton.Enabled = False
            .updateStudentGroupButton.Enabled = False
            .DeleteStudentGroupButton.Enabled = False
        End With
    End Sub
    Private Sub enableButton()
        With Me
            .AddStudentGroupButton.Enabled = True
            .updateStudentGroupButton.Enabled = True
            .DeleteStudentGroupButton.Enabled = True
        End With
    End Sub

    Private Sub DeleteStudentGroupButton_Click(sender As Object, e As EventArgs) Handles DeleteStudentGroupButton.Click
        Dim dialogResult As MsgBoxResult
        Dim deletedOK As Boolean
        Dim messageString = "Delete Student Group :" & mstudentGroupId
        If mstudentGroupId <> "" Then
            dialogResult = MessageBox.Show(messageString, "Confirm Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            If dialogResult = MsgBoxResult.Ok Then
                deletedOK = studentGroupClass.deleteStudentGroupRecord(mstudentGroupId)
                displayAllStudentGroup()
            End If
        End If
    End Sub


End Class
