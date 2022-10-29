Public Class StudentGroupForm
    Dim myStudentGroup As New StudentGroupClass
    ' Dim theStudentGroupRecord As StudentGroupRecord
    Dim OldStudentGroupRec As StudentGroupRecord

    Friend Sub prepareToUpdateSubject(studentGroupId As String)
        With Me
            .AddUpdateButton.Text = "Update"
        End With
        displayExistingStudentGroupInfo(studentGroupId)
    End Sub
    Private Sub displayExistingStudentGroupInfo(studentGroupId As String)
        OldStudentGroupRec = myStudentGroup.getStudentGroupRecord(studentGroupId)
        With Me
            .groupIdTextBox.Text = OldStudentGroupRec.studentGroupId
            .groupNameTextBox.Text = OldStudentGroupRec.studentGroupName
            ' .levelTextBox.Text = theStudentGroupRecord.groupLevel
            displayLevel(OldStudentGroupRec.groupLevel) 'to check suitable radio button
            .noOfStudentTextBox.Text = OldStudentGroupRec.capacity.ToString

        End With
    End Sub
    Friend Sub prepareToAddNewStudentGroup()
        clearStudentGroupForm()
        With Me
            .AddUpdateButton.Text = "Add"
        End With
    End Sub
    Friend Sub prepareToUpdateStudentGroup(studentGroupId As String)
        MessageBox.Show("to update groupid" & studentGroupId)
        With Me
            .AddUpdateButton.Text = "Update"
        End With
        displayExistingStudentGroupInfo(studentGroupId)
    End Sub
    Private Sub clearStudentGroupForm()
        With Me
            .groupIdTextBox.Clear()
            .groupNameTextBox.Clear()
            .primaryRadioButton.Checked = True
            .noOfStudentTextBox.Clear()
        End With
    End Sub

    Private Sub addThisStudentGroup()
        Dim theNewStudentGroupRec As New StudentGroupRecord
        Dim addOk As Boolean
        Dim messageString As String
        With theNewStudentGroupRec
            .studentGroupId = groupIdTextBox.Text
            .studentGroupName = groupNameTextBox.Text
            .groupLevel = getLevelFromRadioButton() 'levelTextBox.Text
            .capacity = noOfStudentTextBox.Text
        End With

        addOk = myStudentGroup.addStudentGroup(theNewStudentGroupRec)
        If addOk Then
            messageString = "New Class with Group Id : " & theNewStudentGroupRec.studentGroupId & " has been added"
            MessageBox.Show(messageString, "Add New Student Group", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        End If
    End Sub
    Private Sub updateThisStudentGroup(oldGroupRec As StudentGroupRecord)
        Dim theNewGroupRec As New StudentGroupRecord
        Dim updateOk As Boolean
        Dim messageString As String
        theNewGroupRec.studentGroupId = groupIdTextBox.Text
        theNewGroupRec.studentGroupName = groupNameTextBox.Text
        theNewGroupRec.groupLevel = getLevelFromRadioButton() 'levelTextBox.Text
        theNewGroupRec.capacity = noOfStudentTextBox.Text
        updateOk = myStudentGroup.updateThisStudentGroup(oldGroupRec, theNewGroupRec)
        If updateOk Then
            messageString = "Group Id : " & theNewGroupRec.studentGroupId & " has been updated"
            MessageBox.Show(messageString, "Update", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        End If
    End Sub


    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        Me.Close()
    End Sub

    Private Sub AddUpdateButton_Click(sender As Object, e As EventArgs) Handles AddUpdateButton.Click
        If AddUpdateButton.Text = "Add" Then
            addThisStudentGroup() 'add new student group
        Else 'update
            updateThisStudentGroup(OldStudentGroupRec)
        End If
    End Sub
    Private Function getLevelFromRadioButton() As String
        If primaryRadioButton.Checked Then
            Return "PRIMARY"
        Else
            Return "SECONDARY"
        End If
    End Function
    Private Sub displayLevel(level As String)
        If level = "PRIMARY" Then
            primaryRadioButton.Checked = True
        Else
            secondaryRadioButton.Checked = True
        End If

    End Sub
End Class