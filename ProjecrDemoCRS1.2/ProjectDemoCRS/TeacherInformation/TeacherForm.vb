Public Class TeacherForm
    Dim myTeacher As New Teacher
    Dim OldTeacherRec As TeacherRecord

    Friend Sub prepareToUpdateTeacher(staffNo As String)
        MessageBox.Show("to update teacher with staffNumber" & staffNo)
        With Me
            .AddUpdateButton.Text = "Update"
        End With
        displayExistingTeacherInfo(staffNo)
    End Sub

    Private Sub displayExistingTeacherInfo(staffNo As String)
        Try
            OldTeacherRec = myTeacher.getTeacherRecord(staffNo)
            With Me
                .icNumberTextBox.Text = OldTeacherRec.ic
                .StaffNoTextBox.Text = OldTeacherRec.staffNo
                .nameTextBox.Text = OldTeacherRec.name
                MessageBox.Show(OldTeacherRec.dob.Date.ToString)
                'displayLevel(OldStudentGroupRec.groupLevel) 'to check suitable radio button
                '.dobDateTimePicker1.CustomFormat = "dd-MM-yyyy"
                .dobDateTimePicker1.Value = OldTeacherRec.dob.Date
                .PhoneNumberTextBox.Text = OldTeacherRec.phone
                .emailTextBox.Text = OldTeacherRec.email
                .Address1TextBox.Text = OldTeacherRec.address1
                .Address2TextBox.Text = OldTeacherRec.address2
                .CityTextBox.Text = OldTeacherRec.city
                .DistrictTextBox.Text = OldTeacherRec.district
                .PostCodeTextBox.Text = OldTeacherRec.postCode
                displayGender(OldTeacherRec.gender)
            End With
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try

    End Sub

    Friend Sub prepareToAddNewTeacher()
        clearTeacherForm()
        With Me
            .AddUpdateButton.Text = "Add"
        End With
    End Sub

    Private Sub addThisTeacher()
        Dim theNewTeacherRec As New TeacherRecord
        Dim addOk As Boolean
        Dim messageString As String
        With theNewTeacherRec
            .ic = icNumberTextBox.Text
            .staffNo = StaffNoTextBox.Text
            .name = nameTextBox.Text
            .dob = dobDateTimePicker1.Value
            .phone = PhoneNumberTextBox.Text
            .email = emailTextBox.Text
            .address1 = Address1TextBox.Text
            .address2 = Address2TextBox.Text
            .city = CityTextBox.Text
            .district = DistrictTextBox.Text
            .postCode = PostCodeTextBox.Text
            .gender = getGenderFromRadioButton()
        End With

        addOk = myTeacher.addTeacher(theNewTeacherRec)
        If addOk Then
            messageString = "New teacher with staff number : " & theNewTeacherRec.staffNo & " has been added"
            MessageBox.Show(messageString, "Add New Teacher ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        End If
    End Sub

    Private Sub clearTeacherForm()
        With Me
            .StaffNoTextBox.Clear()
            .icNumberTextBox.Clear()
            .nameTextBox.Clear()
            .PhoneNumberTextBox.Clear()
            .emailTextBox.Clear()
            .Address1TextBox.Clear()
            .Address2TextBox.Clear()
            .CityTextBox.Clear()
            .DistrictTextBox.Clear()
            .PostCodeTextBox.Clear()
        End With
    End Sub


    Private Sub CancelButton_Click(sender As Object, e As EventArgs)
        Me.Close()
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

    Private Sub AddUpdateButton_Click(sender As Object, e As EventArgs) Handles AddUpdateButton.Click
        If AddUpdateButton.Text = "Add" Then
            addThisTeacher() 'add new student 
        Else 'update
            updateThisTeacher(OldTeacherRec)
        End If
    End Sub

    Private Sub updateThisTeacher(oldTeacherRec As TeacherRecord)
        Dim theNewTeacherRec As New TeacherRecord
        Dim updateOk As Boolean
        Dim messageString As String
        theNewTeacherRec.staffNo = StaffNoTextBox.Text
        theNewTeacherRec.name = nameTextBox.Text
        theNewTeacherRec.dob = dobDateTimePicker1.Value
        theNewTeacherRec.ic = icNumberTextBox.Text
        theNewTeacherRec.phone = PhoneNumberTextBox.Text
        theNewTeacherRec.email = emailTextBox.Text
        theNewTeacherRec.address1 = Address1TextBox.Text
        theNewTeacherRec.address2 = Address2TextBox.Text
        theNewTeacherRec.city = CityTextBox.Text
        theNewTeacherRec.district = DistrictTextBox.Text
        theNewTeacherRec.postCode = PostCodeTextBox.Text
        theNewTeacherRec.gender = getGenderFromRadioButton()

        updateOk = myTeacher.updateThisTeacher(oldTeacherRec, theNewTeacherRec)
        If updateOk Then
            messageString = "Teacher with staffNumber : " & theNewTeacherRec.staffNo & " has been updated"
            MessageBox.Show(messageString, "Update", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        End If
    End Sub

    Private Sub dobDateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles dobDateTimePicker1.ValueChanged
        'MessageBox.Show(dobDateTimePicker1.Value.ToShortDateString)
    End Sub

    Private Sub clearButton_Click(sender As Object, e As EventArgs) Handles clearButton.Click
        clearTeacherForm()
    End Sub
End Class