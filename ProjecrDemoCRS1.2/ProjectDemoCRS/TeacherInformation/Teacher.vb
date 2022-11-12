Imports System.Data.OleDb
Friend Structure TeacherRecord
    Dim staffNo, ic, name, email, phone, address1, address2, city As String
    Dim district, postCode, gender As String
    Dim dob As Date
End Structure

Public Class Teacher

    Private con As New OleDb.OleDbConnection

    Friend Function getTeacherRecord(staffNo) As TeacherRecord
        Dim dr As OleDbDataReader
        Dim teacherRec As New TeacherRecord
        Try
            Dim sql As String
            con.ConnectionString = My.Resources.databaseConnectionPath & Application.StartupPath & My.Resources.databaseName
            con.Open()
            sql = "select * FROM teacher WHERE (staffNumber = '" & staffNo & "')"

            MessageBox.Show(sql)
            Debug.WriteLine(sql)
            Dim cmd As New OleDbCommand(sql, con)
            dr = cmd.ExecuteReader()
            If dr.HasRows Then
                dr.Read()
                teacherRec.ic = dr("icNumber").ToString
                teacherRec.staffNo = dr("staffNumber").ToString
                teacherRec.name = dr("name").ToString

                teacherRec.dob = dr("dateOfBirth")
                teacherRec.phone = dr("phoneNumber").ToString
                teacherRec.email = dr("email").ToString
                teacherRec.address1 = dr("address1").ToString
                teacherRec.address2 = dr("address2").ToString
                teacherRec.city = dr("city").ToString
                teacherRec.district = dr("district").ToString
                teacherRec.postCode = dr("postCode").ToString
                teacherRec.gender = dr("gender").ToString
                con.Close()
                Return teacherRec
            End If
        Catch
            MessageBox.Show("Error accessing teacher record for teacher with staffNumber :" & staffNo)
            con.Close()
            Return teacherRec
        End Try
        Return teacherRec
    End Function

    Friend Function addTeacher(newTeacherRec As TeacherRecord) As Boolean
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
            sql = "insert into teacher(staffNumber, icNumber, name, dateOfBirth, gender, email, phoneNumber, address1, address2, city,district,postCode)"
            sql = sql & " values('" & newTeacherRec.staffNo & "','" & newTeacherRec.ic & "','" & newTeacherRec.name &
                "','" & newTeacherRec.dob & "','" & newTeacherRec.gender & "','" & newTeacherRec.email & "','" & newTeacherRec.phone & "','" & newTeacherRec.address1 &
                "','" & newTeacherRec.address2 & "','" & newTeacherRec.city &
                "','" & newTeacherRec.district & "','" & newTeacherRec.postCode & "')"

            MessageBox.Show(sql)
            Debug.WriteLine(sql)
            Dim cmd As New OleDbCommand(sql, con)
            cmd.ExecuteNonQuery()
            con.Close()
            Return True
        Catch ex As Exception

            MessageBox.Show("Error adding new teacher record. Message:" & ex.ToString)
            con.Close()
            Return False
        End Try
        Return True
    End Function

    Friend Function updateThisTeacher(OldTeacherRec As TeacherRecord, newTeacherRec As TeacherRecord) As Boolean
        Try
            Dim sql As String
            con.ConnectionString = My.Resources.databaseConnectionPath & Application.StartupPath & My.Resources.databaseName
            con.Open()

            sql = "update teacher set staffNumber ='" & newTeacherRec.staffNo & "',"
            sql = sql & " icNumber ='" & newTeacherRec.ic & "',"
            sql = sql & " name ='" & newTeacherRec.name & "',"
            sql = sql & " dateOfBirth ='" & newTeacherRec.dob & "',"
            sql = sql & " gender ='" & newTeacherRec.gender & "',"
            sql = sql & " email ='" & newTeacherRec.email & "',"
            sql = sql & " phoneNumber ='" & newTeacherRec.phone & "',"
            sql = sql & " address1 ='" & newTeacherRec.address1 & "',"
            sql = sql & " address2 ='" & newTeacherRec.address2 & "',"
            sql = sql & " city ='" & newTeacherRec.city & "',"
            sql = sql & " district ='" & newTeacherRec.district & "',"
            sql = sql & " postCode ='" & newTeacherRec.postCode & "'"

            sql = sql & " where staffNumber ='" & newTeacherRec.staffNo & "'"
            MessageBox.Show(sql)
            Dim cmd As New OleDbCommand(sql, con)
            cmd.ExecuteNonQuery()
            con.Close()
            Return True

        Catch ex As Exception
            MessageBox.Show("Error updating teacher record. Message:" & ex.ToString)
            Return False
        End Try
    End Function

    Friend Function deleteTeacherRecord(staffNo As String) As Boolean
        Try
            Dim sql As String
            con.ConnectionString = My.Resources.databaseConnectionPath & Application.StartupPath & My.Resources.databaseName
            con.Open()
            sql = "DELETE FROM teacher WHERE (staffNumber = '" & staffNo & "')"
            MessageBox.Show(sql)
            Dim cmd As New OleDbCommand(sql, con)
            cmd.ExecuteNonQuery()
            con.Close()
            Return True
        Catch e As Exception
            MessageBox.Show(e.ToString) 'data integrity error
            Return False
        End Try

    End Function
End Class
