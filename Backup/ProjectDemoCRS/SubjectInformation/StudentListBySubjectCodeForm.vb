Imports System.Data.OleDb
Public Class StudentListBySubjectCodeForm
    Public conn As New OleDb.OleDbConnection
    Dim dbProvider As String
    Dim dbsource As String
    Dim mydocfolder, theatabase As String
    Dim fullPath As String
    Dim dataAdapter As New OleDb.OleDbDataAdapter
    Dim sql As String
    Dim ds As New DataSet
    Dim SJCode As String
    Public dr As OleDbDataReader
    Dim msubjectCodeString As String

    Private Sub openConnection()


        'conn.ConnectionString = My.Resources.databaseConnectionPath & Application.StartupPath & My.Resources.databaseName

        Try
            'opens the connection
            If conn.State <> ConnectionState.Open Then
                conn.ConnectionString = My.Resources.databaseConnectionPath & Application.StartupPath & My.Resources.databaseName
                conn.Open()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        'close the connection
        ' conn.Close()
    End Sub

    Public Sub showStudentInformation(subjectCode As String)

        'displayStudentRecord(subjectCode)
        SJCode = subjectCode
        displaySubjectRegister(SJCode)
    End Sub
    Private Sub displayStudentRecord(subjectCode As String)
        ' Dim curStudentRec As 
        openConnection()
        Dim str As String

        str = "Select stu.name, stu.matricNumber , s.credit"
        str &= " from subjectregister r, student stu, subject s"
        str &= " where r.matricNumber = stu.matricNumber"
        str &= " and r.subjectCode = '" & subjectCode & "'"
        MessageBox.Show(str)
        Dim cmd As OleDbCommand = New OleDbCommand(str, conn)
        dr = cmd.ExecuteReader
        'While dr.Read()
        '    With Me
        '        .matricNumberLabel.Text = dr("matricNumber").ToString
        '        .nameLabel.Text = dr("name").ToString
        '        '.statusLabel.Text = dr("status").ToString
        '        .courseLabel.Text = dr("course").ToString
        '    End With
        'End While
        'conn.Close()
    End Sub
    Private Sub displaySubjectRegister(SJCode As String)
        Dim dataAdapter2 As New OleDb.OleDbDataAdapter
        Dim sql2 As String
        clearSubjectRegisterGrid()
        conn.Close()
        conn.ConnectionString = My.Resources.databaseConnectionPath & Application.StartupPath & My.Resources.databaseName
        conn.Open()


        sql2 = "Select r.subjectCode, stu.name, stu.matricNumber , stu.email , stu.icNumber, stu.phoneNumber ,stu.gender"
        sql2 &= " from subjectregister r, student stu"
        sql2 &= " where stu.matricNumber = r.matricNumber"
        sql2 &= " and r.subjectCode = '" & SJCode & "'"

        Dim cmd As OleDbCommand = New OleDbCommand(sql2, conn)
        cmd.ExecuteNonQuery()
        conn.Close()

        MessageBox.Show(sql2)
        Debug.WriteLine(sql2)

        dataAdapter = New OleDb.OleDbDataAdapter(sql2, conn)
        dataAdapter.Fill(ds, "ihsanTuitionCenterDb")
        DataGridView1.ColumnHeadersDefaultCellStyle.Font = New Font("Microsoft Sans Serif", 12.0F)
        DataGridView1.DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 12.0F)
        Me.DataGridView1.DataMember = "ihsanTuitionCenterDb"
        DataGridView1.DataSource = ds
    End Sub
    Private Sub clearSubjectRegisterGrid()
        Me.ds.Clear() 'clear the original data
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub PrintStudentListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintStudentListToolStripMenuItem.Click
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.PrintPreviewControl.Zoom = 1
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim imagebmp As New Bitmap(Me.DataGridView1.Width, Me.DataGridView1.Height)
        DataGridView1.DrawToBitmap(imagebmp, New Rectangle(0, 0, Me.DataGridView1.Width, Me.DataGridView1.Height))
        e.Graphics.DrawImage(imagebmp, 0, 0)
        Dim ReportFont As Font = New Drawing.Font("Bebas Neue", 16)
        Dim ReportBodyFont As Font = New Drawing.Font("Bebas Neue", 6)

    End Sub

    Private Sub StudentListBySubjectCodeForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class