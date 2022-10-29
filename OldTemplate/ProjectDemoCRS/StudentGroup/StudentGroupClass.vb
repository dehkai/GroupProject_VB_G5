Imports System.Data.OleDb
Friend Structure StudentGroupRecord
    Dim studentGroupId, studentGroupName, groupLevel As String
    Dim capacity As Integer
End Structure
Public Class StudentGroupClass
    Private con As New OleDb.OleDbConnection
    Friend Function addStudentGroup(newStudentGroupRec As StudentGroupRecord) As Boolean
        Try
            Dim sql As String
            ''Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\registrationdb.accdb")
            con.ConnectionString = My.Resources.databaseConnectionPath & Application.StartupPath & My.Resources.databaseName
            con.Open()
            If con.State = ConnectionState.Open Then
                MsgBox("MS Database Connected!")
            Else
                MsgBox("error connecting to database")
                Exit Function
            End If
            sql = "insert into studentGroupTbl(groupId,groupName,groupLevel,maximumStudent)"
            sql = sql & " values('" & newStudentGroupRec.studentGroupId & "','" & newStudentGroupRec.studentGroupName & "','" & newStudentGroupRec.groupLevel & "','" & newStudentGroupRec.capacity.ToString & "')"
            ' MessageBox.Show(sql)
            ' Debug.WriteLine(sql)
            Dim cmd As New OleDbCommand(sql, con)
            cmd.ExecuteNonQuery()
            con.Close()
        Catch ex As Exception

            MessageBox.Show("Error adding new student group record. Message:" & ex.ToString)
        End Try
        Return True

    End Function
    Friend Function getStudentGroupRecord(studentGroupId) As StudentGroupRecord
        Dim dr As OleDbDataReader
        Dim studentGroupRec As New StudentGroupRecord
        Try
            Dim sql As String
            con.ConnectionString = My.Resources.databaseConnectionPath & Application.StartupPath & My.Resources.databaseName
            con.Open()
            sql = "select * FROM studentGroupTbl WHERE (groupId = '" & studentGroupId & "')"

            MessageBox.Show(sql)
            Dim cmd As New OleDbCommand(sql, con)
            dr = cmd.ExecuteReader()
            If dr.HasRows Then
                dr.Read()
                studentGroupRec.studentGroupId = dr("groupId").ToString
                studentGroupRec.studentGroupName = dr("groupName").ToString
                studentGroupRec.groupLevel = dr("groupLevel").ToString
                studentGroupRec.capacity = dr("maximumStudent")

                con.Close()
                Return studentGroupRec
            End If
        Catch
            MessageBox.Show("Error accessing student group")
            con.Close()
            Return studentGroupRec
        End Try
        Return studentGroupRec
    End Function
    Friend Function getStudentClassList() As String
        Dim studentClassList As String
        Dim i As Integer
        Dim dr As OleDbDataReader
        studentClassList = String.Empty
        Try
            Dim sql As String
            con.ConnectionString = My.Resources.databaseConnectionPath & Application.StartupPath & My.Resources.databaseName
            con.Open()
            'sql = "select distinct(groupId) FROM studentGroupTbl order by groupId"
            sql = "select groupId FROM studentGroupTbl order by groupId"

            MessageBox.Show(sql)
            Dim cmd As New OleDbCommand(sql, con)
            dr = cmd.ExecuteReader()
            studentClassList = String.Empty
            If dr.HasRows Then


                While dr.HasRows
                    dr.Read()
                    studentClassList += dr("groupId") + ControlChars.NewLine
                    'MessageBox.Show(studentClassList)
                    'dr.NextResult()
                    i += 1
                End While


                con.Close()
                Return studentClassList
            End If
        Catch e As Exception
            MessageBox.Show("Error accessing student group" + e.ToString)
            con.Close()
        End Try
        Return studentClassList
    End Function
    Friend Function updateThisStudentGroup(oldStudentGroupRec As StudentGroupRecord, newStudentGroupRec As StudentGroupRecord) As Boolean
        Try
            Dim sql As String
            con.ConnectionString = My.Resources.databaseConnectionPath & Application.StartupPath & My.Resources.databaseName
            con.Open()
            sql = "update studentGroupTbl set groupId ='" & newStudentGroupRec.studentGroupId & "',"
            sql = sql & " groupName ='" & newStudentGroupRec.studentGroupName & "',"
            sql = sql & " groupLevel ='" & newStudentGroupRec.groupLevel & "',"
            sql = sql & " maximumStudent ='" & newStudentGroupRec.capacity & "'"
            sql = sql & " where groupId ='" & oldStudentGroupRec.studentGroupId & "'"
            MessageBox.Show(sql)
            Dim cmd As New OleDbCommand(sql, con)
            cmd.ExecuteNonQuery()
            con.Close()
            Return True

        Catch ex As Exception
            MessageBox.Show("Error updating group record. Message:" & ex.ToString)
            con.Close()
            Return False
        End Try


    End Function
    Friend Function deleteStudentGroupRecord(groupId As String) As Boolean
        Try
            Dim sql As String
            con.ConnectionString = My.Resources.databaseConnectionPath & Application.StartupPath & My.Resources.databaseName
            con.Open()
            sql = "DELETE FROM studentGroupTbl WHERE (groupId = '" & groupId & "')"
            MessageBox.Show(sql)
            Dim cmd As New OleDbCommand(sql, con)
            cmd.ExecuteNonQuery()
            con.Close()
            Return True
        Catch e As Exception
            MessageBox.Show(e.ToString) 'data integrity error
            con.Close()
            Return False
        End Try

    End Function


End Class



