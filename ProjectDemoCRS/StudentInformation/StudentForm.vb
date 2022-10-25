Public Class StudentForm
    Dim myStudent As New Student
    Dim myStudentGroupClass As New StudentGroupClass
    ' Dim theStudentGroupRecord As StudentGroupRecord
    Dim OldStudentRec As StudentRecord


    Friend Sub prepareToUpdateStudent(studentMatric As String)
        MessageBox.Show("to update studnet with matric" & studentMatric)
        With Me
            .AddUpdateButton.Text = "Update"
        End With
        displayExistingStudentInfo(studentMatric)
    End Sub

    Private Sub displayExistingStudentInfo(studentMatric As String)
        Try
            OldStudentRec = myStudent.getStudentRecord(studentMatric)
            With Me
                .icNumberTextBox.Text = OldStudentRec.ic
                .matricTextBox.Text = OldStudentRec.matric
                .nameTextBox.Text = OldStudentRec.name
                MessageBox.Show(OldStudentRec.dob.Date.ToString)
                'displayLevel(OldStudentGroupRec.groupLevel) 'to check suitable radio button
                '.dobDateTimePicker1.CustomFormat = "dd-MM-yyyy"
                .dobDateTimePicker1.Value = OldStudentRec.dob.Date
                .PhoneNumberTextBox.Text = OldStudentRec.phone
                .classComboBox.Text = OldStudentRec.classGroup

            End With
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try

    End Sub
    Friend Sub prepareToAddNewStudent()
        clearStudentForm()
        displayClassList()
        With Me
            .AddUpdateButton.Text = "Add"
        End With
    End Sub

    Private Sub displayClassList()
        Dim classListArray() As String
        Dim studentClassList As String
        studentClassList = myStudentGroupClass.getStudentClassList()
        classListArray = studentClassList.Split(ControlChars.NewLine)
        classComboBox.Items.Clear()
        'MessageBox.Show(studentClassList)
        For Each i As String In classListArray
            Me.classComboBox.Items.Add(i)
        Next
        If classComboBox.Items.Count <> 0 Then
            classComboBox.SelectedIndex = 0
        End If

    End Sub
    Private Sub AddUpdateButton_Click(sender As Object, e As EventArgs) Handles AddUpdateButton.Click
        If AddUpdateButton.Text = "Add" Then
            addThisStudent() 'add new student 
        Else 'update
            updateThisStudent(OldStudentRec)
        End If
    End Sub
    Private Sub addThisStudent()
        Dim theNewStudentRec As New StudentRecord
        Dim addOk As Boolean
        Dim messageString As String
        With theNewStudentRec
            .ic = icNumberTextBox.Text
            .matric = matricTextBox.Text
            .name = nameTextBox.Text
            .dob = dobDateTimePicker1.Value
            .classGroup = classComboBox.Text
        End With

        addOk = myStudent.addStudent(theNewStudentRec)
        If addOk Then
            messageString = "New student with matric : " & theNewStudentRec.matric & " has been added"
            MessageBox.Show(messageString, "Add New Student ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        End If
    End Sub
    Private Sub clearStudentForm()
        With Me
            .matricTextBox.Clear()
            .icNumberTextBox.Clear()
            .nameTextBox.Clear()

            .classComboBox.Text = ""
        End With
    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        Me.Close()
    End Sub
    Private Sub updateThisStudent(oldStudentRec As StudentRecord)
        Dim theNewStudentRec As New StudentRecord
        Dim updateOk As Boolean
        Dim messageString As String
        theNewStudentRec.matric = matricTextBox.Text
        theNewStudentRec.name = nameTextBox.Text
        theNewStudentRec.dob = dobDateTimePicker1.Value
        theNewStudentRec.classGroup = classComboBox.Text
        updateOk = myStudent.updateThisStudent(oldStudentRec, theNewStudentRec)
        If updateOk Then
            messageString = "Student with matric : " & theNewStudentRec.matric & " has been updated"
            MessageBox.Show(messageString, "Update", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        End If
    End Sub

    Private Sub dobDateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles dobDateTimePicker1.ValueChanged
        'MessageBox.Show(dobDateTimePicker1.Value.ToString("dd-MM-yyyy"))
        MessageBox.Show(dobDateTimePicker1.Value.ToShortDateString)

    End Sub

End Class