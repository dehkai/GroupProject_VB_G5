Imports System.Data.OleDb
Public Class RegistrationForm
    Public conn As New OleDb.OleDbConnection
    Dim dbProvider As String
    Dim dbsource As String
    Dim mydocfolder, theatabase As String
    Dim fullPath As String
    Dim dataAdapter As New OleDb.OleDbDataAdapter
    Dim sql As String
    Dim ds As New DataSet
    Dim mId As String
    Public dr As OleDbDataReader
    Dim msubjectCodeString As String

    Dim mySubject As New Subject
    Public Sub showStudentInformation(matricString As String)

        displayStudentRecord(matricString)
        mId = matricString
        displaySubjectRegister(mId)
    End Sub
    Private Sub displayStudentRecord(matricString As String)
        ' Dim curStudentRec As 
        openConnection()
        Dim str As String
        str = "SELECT * FROM student WHERE (matricNumber = '" & matricString & "')"
        MessageBox.Show(str)
        Dim cmd As OleDbCommand = New OleDbCommand(str, conn)
        dr = cmd.ExecuteReader
        While dr.Read()
            With Me
                .matricNumberLabel.Text = dr("matricNumber").ToString
                .nameLabel.Text = dr("name").ToString
                '.statusLabel.Text = dr("status").ToString
                .courseLabel.Text = dr("course").ToString
            End With
        End While
        'conn.Close()
    End Sub
    Private Sub displaySubjectRegister(matricString As String)
        clearSubjectRegisterGrid()
        sql = "Select r.subjectCode,s.subjectName"
        sql &= " from subjectregister r, student stu, subject s"
        sql &= " where r.matricNumber = stu.matricNumber"
        sql &= " and r.matricNumber = '" & matricString & "'"
        sql &= " and r.subjectCode = s.subjectCode"
        MessageBox.Show(sql)
        Debug.WriteLine(sql)
        dataAdapter = New OleDb.OleDbDataAdapter(sql, conn)
        dataAdapter.Fill(ds, "ihsanTuitionCenterDb")
        Me.SubjectRegisterDataGridView.DataMember = "ihsanTuitionCenterDb"
        SubjectRegisterDataGridView.DataSource = ds
    End Sub
    Private Sub openConnection()


        'conn.ConnectionString = My.Resources.databaseConnectionPath & Application.StartupPath & My.Resources.databaseName

        Try
            'opens the connection
            If conn.State <> ConnectionState.Open Then
                conn.ConnectionString = My.Resources.databaseConnectionPath & Application.StartupPath & My.Resources.databaseName
                conn.Open()
                MsgBox("MS Database Connected!")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        'close the connection
        ' conn.Close()
    End Sub
    Private Sub clearSubjectRegisterGrid()
        Me.ds.Clear() 'clear the original data
        Me.DropButton.Enabled = False
    End Sub

    Private Sub displaySubjectButton_Click(sender As Object, e As EventArgs)
        ' displaySubjectRegister(mId)
    End Sub

    Private Sub SubjectRegisterDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles SubjectRegisterDataGridView.CellClick
        Dim cb As New OleDb.OleDbCommandBuilder(dataAdapter)
        Dim dataRow As DataRow
        Dim row, col, noOfRec As Integer

        noOfRec = SubjectRegisterDataGridView.Rows.Count
        col = SubjectRegisterDataGridView.CurrentCell.ColumnIndex
        row = SubjectRegisterDataGridView.CurrentCell.RowIndex
        If col = 0 And row < noOfRec - 1 Then ' allow subjectCode selection only
            msubjectCodeString = SubjectRegisterDataGridView.CurrentCell.Value
        Else
            msubjectCodeString=""
        End If


        If (msubjectCodeString <> "") Then
            Me.DropButton.Enabled = True
        Else
            Me.DropButton.Enabled = False
        End If
    End Sub

    Private Sub DropButton_Click(sender As Object, e As EventArgs) Handles DropButton.Click
        Dim dialogResult As MsgBoxResult
        Dim deletedOK As Boolean
        Dim messageString = "Drop " & msubjectCodeString & " subject"
        If msubjectCodeString <> "" Then
        dialogResult = MessageBox.Show(messageString, "Confirm Drop", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            If dialogResult = MsgBoxResult.Ok Then
                'deletedOK = mySubject.dropStudentSubject(mId, msubjectCodeString)


                deletedOK = mySubject.dropSubject(mId, msubjectCodeString)



                displaySubjectRegister(mId)
            End If
        End If
    End Sub

    Private Sub RegistrationForm_Deactivate(sender As Object, e As EventArgs) Handles Me.Deactivate
        conn.Close()
    End Sub

    Private Sub AddSubjectButton_Click(sender As Object, e As EventArgs) Handles AddSubjectButton.Click
        Dim subjectCodeToRegister, currentStudentMatric As String
        subjectCodeToRegister = SubjectCodeTextBox.Text
        currentStudentMatric = mId
        mySubject.RegisterSubjectForThisStudent(subjectCodeToRegister, currentStudentMatric)
        displaySubjectRegister(mId)
    End Sub

    Private Sub RegistrationForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        openConnection()

    End Sub
End Class