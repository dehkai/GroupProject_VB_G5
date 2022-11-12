Imports System.Data.OleDb
Imports System.Net.Mail
Imports System.Text
Public Class RegistrationForm
    Dim count As Integer
    Const CourseFee As Integer = 50
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
    Public dr2 As OleDbDataReader
    Dim msubjectCodeString As String

    Dim mySubject As New Subject

    Public Sub showStudentInformation(matricString As String)

        displayStudentRecord(matricString)
        'displayAddress(matricString)
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
        Dim dataAdapter2 As New OleDb.OleDbDataAdapter
        Dim sql2, sql3, sql4 As String
        Dim studentFee As Integer

        clearSubjectRegisterGrid()
        conn.Close()
        conn.ConnectionString = My.Resources.databaseConnectionPath & Application.StartupPath & My.Resources.databaseName
        conn.Open()
        sql = "Select r.subjectCode,s.subjectName , s.credit"
        sql &= " from subjectregister r, student stu, subject s"
        sql &= " where r.matricNumber = stu.matricNumber"
        sql &= " and r.matricNumber = '" & matricString & "'"
        sql &= " and r.subjectCode = s.subjectCode"

        sql2 = "Select SUM(s.credit) as TotalCredit"
        sql2 &= " from subjectregister r, student stu, subject s"
        sql2 &= " where r.matricNumber = stu.matricNumber"
        sql2 &= " and r.matricNumber = '" & matricString & "'"
        sql2 &= " and r.subjectCode = s.subjectCode"

        sql3 = "Select count(*)"
        sql3 &= " from subjectregister r, student stu, subject s"
        sql3 &= " where r.matricNumber = stu.matricNumber"
        sql3 &= " and r.matricNumber = '" & matricString & "'"
        sql3 &= " and r.subjectCode = s.subjectCode"

        sql4 = "Select icNumber,address1, address2, city, district, postCode ,email "
        sql4 &= " from student "
        sql4 &= " where matricNumber = '" & matricString & "'"

        Debug.WriteLine(sql4)
        Dim cmd3 As OleDbCommand = New OleDbCommand(sql4, conn)
        dr2 = cmd3.ExecuteReader
        While dr2.Read()
            With Me
                .EmailLabel.Text = dr2("email").ToString
                .IcLabel.Text = dr2("icNumber").ToString
                .Address1Label.Text = dr2("address1").ToString
                .Address2Label.Text = dr2("address2").ToString
                .postCodeLabel.Text = dr2("postCode").ToString
                .cityLabel.Text = dr2("city").ToString
                .DistrictLabel.Text = dr2("district").ToString
            End With
        End While


        Dim cmd As OleDbCommand = New OleDbCommand(sql2, conn)
        Dim cmd2 As OleDbCommand = New OleDbCommand(sql3, conn)
        dr = cmd.ExecuteReader
        count = Convert.ToInt32(cmd2.ExecuteScalar())
        studentFee = count * CourseFee
        While dr.Read()
            With Me
                .TotalCreditLabel.Text = dr("TotalCredit").ToString
                .StudentFeeLabel.Text = studentFee.ToString("C")
                .TotalSubjectLabel.Text = count.ToString
            End With
        End While

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
            msubjectCodeString = ""
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

    Private Sub GroupBox3_Enter(sender As Object, e As EventArgs) Handles GroupBox3.Enter

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles StudentFeeLabel.Click

    End Sub

    Private Sub PrintSlipToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintSlipToolStripMenuItem.Click
        If PrintPreviewDialog1.ShowDialog = DialogResult.OK Then
            PrintDocument1.Print()
        End If
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        'Dim companyLogo As Image =
        '    Image.FromFile("D:\Data D\1.UTMSPACE\A-Sem 5\VB.NET PROGRAMMING\LAB SKILL 4\Lab4_4\ImageCar.jpg")
        'e.Graphics.DrawImage(companyLogo, 100, 100, 400, 300)
        Dim yPos As Integer
        Dim titleString As String
        Dim titleFOnt As New Font("Cambria", 15, FontStyle.Bold)
        Dim dataFont As New Font("Cambria", 13, FontStyle.Regular)
        Dim dataString As String

        titleString = DateTime.Now.ToString + ControlChars.Tab + ControlChars.Tab + "Registration Slip"
        yPos = 20
        e.Graphics.DrawString(titleString, titleFOnt, Brushes.Black, 10, yPos)

        dataString = ControlChars.Tab + ControlChars.Tab + ControlChars.Tab + "SEKOLAH MENENGAH  KEBANGSAAN"
        yPos = 100
        e.Graphics.DrawString(dataString, titleFOnt, Brushes.Black, 1, yPos)
        dataString = ControlChars.Tab + ControlChars.Tab + ControlChars.Tab + "68100 , PETALING JAYA , SELANGOR,"
        yPos += 30
        e.Graphics.DrawString(dataString, dataFont, Brushes.Black, 80, yPos)
        dataString = ControlChars.Tab + ControlChars.Tab + ControlChars.Tab + "MALAYSIA"
        yPos += 30
        e.Graphics.DrawString(dataString, dataFont, Brushes.Black, 140, yPos)
        dataString = ControlChars.Tab + ControlChars.Tab + ControlChars.Tab + "(Student Registration Slip)"
        yPos += 50
        e.Graphics.DrawString(dataString, titleFOnt, Brushes.Black, 40, yPos)
        dataString = "Name:" + ControlChars.Tab + ControlChars.Tab + nameLabel.Text.ToString()
        yPos += 50
        e.Graphics.DrawString(dataString, dataFont, Brushes.Black, 100, yPos)
        dataString = "No. IC:" + ControlChars.Tab + ControlChars.Tab + IcLabel.Text.ToString()
        yPos += 30
        e.Graphics.DrawString(dataString, dataFont, Brushes.Black, 100, yPos)
        dataString = "Address:" + ControlChars.Tab + ControlChars.Tab + Address1Label.Text.ToString + ", "
        yPos += 30
        e.Graphics.DrawString(dataString, dataFont, Brushes.Black, 100, yPos)
        dataString = ControlChars.Tab + ControlChars.Tab + ControlChars.Tab + Address2Label.Text.ToString + ", "
        yPos += 30
        e.Graphics.DrawString(dataString, dataFont, Brushes.Black, 25, yPos)
        dataString = ControlChars.Tab + ControlChars.Tab + ControlChars.Tab + postCodeLabel.Text.ToString + ", " + DistrictLabel.Text.ToString + "," + cityLabel.Text.ToString() + ". "
        yPos += 30
        e.Graphics.DrawString(dataString, dataFont, Brushes.Black, 25, yPos)


        dataString = "Bill" + ControlChars.Tab + "   CODE" + ControlChars.Tab + "    CREDIT" + ControlChars.Tab + ControlChars.Tab + ControlChars.Tab + "NAME"
        yPos += 50
        e.Graphics.DrawString(dataString, titleFOnt, Brushes.Black, 30, yPos)
        Dim newInt As Integer
        For a = 0 To count - 1
            newInt = a + 1
            dataString = newInt.ToString + ControlChars.Tab + SubjectRegisterDataGridView.Rows(a).Cells(0).Value.ToString() + ControlChars.Tab + SubjectRegisterDataGridView.Rows(a).Cells(2).Value.ToString() + ControlChars.Tab + SubjectRegisterDataGridView.Rows(a).Cells(1).Value.ToString()

            yPos += 30
            e.Graphics.DrawString(dataString, dataFont, Brushes.Black, 40, yPos)
        Next


        dataString = "TOTAL CREDIT" + ControlChars.Tab + ControlChars.Tab + TotalCreditLabel.Text.ToString()
        yPos += 50
        e.Graphics.DrawString(dataString, titleFOnt, Brushes.Black, 100, yPos)
        dataString = "TOTAL FEES" + ControlChars.Tab + ControlChars.Tab + StudentFeeLabel.Text.ToString()
        yPos += 30
        e.Graphics.DrawString(dataString, titleFOnt, Brushes.Black, 100, yPos)
        'yPos += 30
        'Dim linepen As New Pen(Color.Black, 5)
        'Dim startPoint As New Point(100, yPos)
        'Dim endPoint As New Point(600, yPos)
        'e.Graphics.DrawLine(linepen, startPoint, endPoint)

        'Dim linepen2 As New Pen(Color.Black, 5)

        'startPoint.X = 100
        'startPoint.Y = yPos
        'endPoint.X = 600
        'endPoint.Y = yPos
        'e.Graphics.DrawLine(linepen, startPoint, endPoint)
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub EmailButton_Click(sender As Object, e As EventArgs) Handles EmailButton.Click
        Dim strIntro, tableStyle, headerStyle As String
        Dim message As MailMessage = New MailMessage
        strIntro = "Hye " + nameLabel.Text.ToString + "," + ControlChars.NewLine + ControlChars.NewLine + "Here is your subject registration detail" + ControlChars.NewLine + ControlChars.NewLine
        headerStyle = "border-collapse : ""collapse""; text-align : ""left; padding: ""16px""; border: ""1px solid #ddd"""

        Dim sbContent2 As New StringBuilder()
        sbContent2.Append(String.Format("<p " + headerStyle + ">NAME :" + nameLabel.Text.ToString) + "</p>")
        sbContent2.Append(String.Format("<p " + headerStyle + ">No. IC :" + IcLabel.Text.ToString) + "</p>")
        sbContent2.Append(String.Format("<h4 " + headerStyle + ">ADDRESS :</h4>"))
        sbContent2.Append(String.Format("<p >" + Address1Label.Text.ToString) + ",</p>")
        sbContent2.Append(String.Format("<p>" + Address2Label.Text.ToString) + ",</p>")
        sbContent2.Append(String.Format("<p>" + postCodeLabel.Text.ToString + "," + DistrictLabel.Text.ToString + "," + cityLabel.Text.ToString() + "</p>."))
        Dim tableHeader As String = "<tr><th " + headerStyle + ">Code</th> <th " + headerStyle + ">Credit</th> <th " + headerStyle + ">Name</th></tr>"
        Dim strTopTag As String = "<table>" + tableHeader + "<tbody>"
        Dim strBottomTag As String = "</tbody></table>"
        Dim sbContent As New StringBuilder()
        Dim newInt As Integer

        For a = 0 To count - 1
            sbContent.Append("<tr>")
            newInt = a + 1

            sbContent.Append(String.Format("<td " + headerStyle + ">  {0}     </td>", SubjectRegisterDataGridView.Rows(a).Cells(0).Value.ToString()))
            sbContent.Append(String.Format("<td " + headerStyle + ">  {0}     </td>", SubjectRegisterDataGridView.Rows(a).Cells(2).Value.ToString()))
            sbContent.Append(String.Format("<td " + headerStyle + ">  {0}     </td>", SubjectRegisterDataGridView.Rows(a).Cells(1).Value.ToString()))
            sbContent.Append(String.Format("<br>"))
            sbContent.Append("<tr>")
        Next
        Dim sbContent3 As New StringBuilder()
        sbContent3.Append(String.Format("<p " + headerStyle + ">TOTAL CREDIT :" + TotalCreditLabel.Text.ToString) + "</p>")
        sbContent3.Append(String.Format("<p " + headerStyle + ">TOTAL FEES :" + StudentFeeLabel.Text.ToString) + "</p>")

        Dim emailTemplate As String = strIntro + sbContent2.ToString() + strTopTag & sbContent.ToString() & strBottomTag + sbContent3.ToString()
        Try
            Dim smtp_server As New SmtpClient
            Dim e_mail As New MailMessage
            smtp_server.UseDefaultCredentials = False
            smtp_server.Credentials = New Net.NetworkCredential("tansen@graduate.utm.my", "Lone#2002")
            smtp_server.Port = 587
            smtp_server.EnableSsl = True
            smtp_server.Host = "smtp.gmail.com"
            e_mail = New MailMessage
            e_mail.From = New MailAddress("tansen@graduate.utm.my")
            e_mail.To.Add(EmailLabel.Text.ToString)
            e_mail.Subject = "Registration Slip"
            e_mail.IsBodyHtml = True
            e_mail.Body = emailTemplate
            smtp_server.Send(e_mail)
            MessageBox.Show("Email sended to " + EmailLabel.Text.ToString, "Email", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("something failed.")
        End Try
    End Sub



    'Public Sub displayAddress(matricString As String)
    '    Dim dataAdapter2 As New OleDb.OleDbDataAdapter
    '    Dim sql2 As String
    '    clearSubjectRegisterGrid()
    '    conn.Close()
    '    conn.ConnectionString = My.Resources.databaseConnectionPath & Application.StartupPath & My.Resources.databaseName
    '    conn.Open()
    '    sql2 = "Select address1, address2, city, district, state"
    '    sql2 &= " from subjectregister "
    '    sql2 &= " where matricNumber = '" & matricString & "'"

    '    Debug.WriteLine(sql2)
    '    Dim cmd As OleDbCommand = New OleDbCommand(sql2, conn)
    '    dr = cmd.ExecuteReader
    '    While dr.Read()
    '        With Me
    '            .Address1Label.Text = dr("address1").ToString
    '            .Address2Label.Text = dr("address2").ToString
    '            .CityLabel.Text = dr("city").ToString
    '            .DistrictLabel.Text = dr("district").ToString
    '            .StateLabel.Text = dr("state").ToString
    '        End With
    '    End While

    '    MessageBox.Show(sql)
    '    Debug.WriteLine(sql)


    'End Sub

    Private Sub RegistrationForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        openConnection()

    End Sub
End Class