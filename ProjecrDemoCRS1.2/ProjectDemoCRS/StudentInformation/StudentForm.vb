Public Class StudentForm
    Dim myStudent As New Student
    Dim myStudentGroupClass As New StudentGroupClass
    ' Dim theStudentGroupRecord As StudentGroupRecord
    Dim OldStudentRec As StudentRecord


    Friend Sub prepareToUpdateStudent(studentMatric As String)
        MessageBox.Show("to update student with matric" & studentMatric)
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
                ' MessageBox.Show(OldStudentRec.dob.Date.ToString)
                .courseTextBox.Text = OldStudentRec.course
                'displayLevel(OldStudentGroupRec.groupLevel) 'to check suitable radio button
                '.dobDateTimePicker1.CustomFormat = "dd-MM-yyyy"
                .dobDateTimePicker1.Value = OldStudentRec.dob.Date
                .PhoneNumberTextBox.Text = OldStudentRec.phone
                .classComboBox.Text = OldStudentRec.classGroup
                .emailTextBox.Text = OldStudentRec.email
                .Address1TextBox.Text = OldStudentRec.address1
                .Address2TextBox.Text = OldStudentRec.address2
                .CityTextBox.Text = OldStudentRec.city
                .DistrictTextBox.Text = OldStudentRec.district
                .PostCodeTextBox.Text = OldStudentRec.postCode
                displayGender(OldStudentRec.gender)

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
            .course = courseTextBox.Text
            .dob = dobDateTimePicker1.Value
            .classGroup = classComboBox.Text
            .phone = PhoneNumberTextBox.Text
            .email = emailTextBox.Text
            .address1 = Address1TextBox.Text
            .address2 = Address2TextBox.Text
            .city = CityTextBox.Text
            .district = DistrictTextBox.Text
            .postCode = PostCodeTextBox.Text
            .gender = getGenderFromRadioButton()
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
            .courseTextBox.Clear()
            .PhoneNumberTextBox.Clear()
            .emailTextBox.Clear()
            .Address1TextBox.Clear()
            .Address2TextBox.Clear()
            .CityTextBox.Clear()
            .DistrictTextBox.Clear()
            .PostCodeTextBox.Clear()

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
        theNewStudentRec.ic = icNumberTextBox.Text
        theNewStudentRec.name = nameTextBox.Text
        theNewStudentRec.course = courseTextBox.Text
        theNewStudentRec.dob = dobDateTimePicker1.Value
        theNewStudentRec.classGroup = classComboBox.Text
        theNewStudentRec.phone = PhoneNumberTextBox.Text
        theNewStudentRec.email = emailTextBox.Text
        theNewStudentRec.address1 = Address1TextBox.Text
        theNewStudentRec.address2 = Address2TextBox.Text
        theNewStudentRec.city = CityTextBox.Text
        theNewStudentRec.district = DistrictTextBox.Text
        theNewStudentRec.postCode = PostCodeTextBox.Text
        theNewStudentRec.gender = getGenderFromRadioButton()
        updateOk = myStudent.updateThisStudent(oldStudentRec, theNewStudentRec)
        If updateOk Then
            messageString = "Student with matric : " & theNewStudentRec.matric & " has been updated"
            MessageBox.Show(messageString, "Update", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        End If
    End Sub

    Private Function getGenderFromRadioButton() As String
        If MaleRadioButton.Checked Then
            Return "MALE"
        Else
            Return "FEMALE"
        End If
    End Function

    Private Sub displayGender(gender As String)
        If gender = "MALE" Then
            MaleRadioButton.Checked = True
        Else
            FemaleRadioButton.Checked = True
        End If

    End Sub

    Private Sub clearButton_Click(sender As Object, e As EventArgs) Handles clearButton.Click
        clearStudentForm()
    End Sub

    Private Sub dobDateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles dobDateTimePicker1.ValueChanged
        'MessageBox.Show(dobDateTimePicker1.Value.ToShortDateString)
    End Sub

End Class