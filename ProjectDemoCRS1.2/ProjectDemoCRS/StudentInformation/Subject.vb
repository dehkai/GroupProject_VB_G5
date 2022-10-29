Imports System.Data.OleDb
Friend Structure SubjectRecord
    Dim subjectCode, subjectName As String
    Dim credit As Integer
End Structure
Public Class Subject
    Private conn As New OleDb.OleDbConnection
    'this function will add one subject for one student in the subjectregister table
    Friend Function RegisterSubjectForThisStudent(subjectCode As String, matricNumber As String) As Boolean
        Try
            Dim sql As String
            Dim con As New OleDbConnection(My.Resources.databaseConnectionPath & Application.StartupPath & My.Resources.databaseName) '"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\registrationdb.accdb")
            con.Open()
            sql = "insert into subjectregister(subjectCode,matricNumber)"
            sql = sql & " values('" & subjectCode & "','" & matricNumber & "')"
            'MessageBox.Show(sql)
            Dim cmd As New OleDbCommand(sql, con)
            cmd.ExecuteNonQuery()
            con.Close()
        Catch ex As Exception
            MessageBox.Show("Error register " + subjectCode + " for student with matric:" + matricNumber)
            Debug.WriteLine(ex.ToString)
        End Try
        Return True

    End Function
    Friend Function addNewSubject(newSubjectRed As SubjectRecord) As Boolean


    End Function
    Friend Function deleteSubjectRecord(subjectCode As String) As Boolean

    End Function
    Friend Function dropSubject(matricString As String, subjectCode As String) As Boolean

    End Function
    Friend Function getSubjectRecord(subjectCode As String) As SubjectRecord

    End Function
    Friend Function updateThisSubject(oldSubject As SubjectRecord, newSubjectRed As SubjectRecord) As Boolean

    End Function
End Class
