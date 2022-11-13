﻿Public Class CrsMainForm
    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        End
    End Sub

    Private Sub CrsMainForm_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        End
    End Sub

    Private Sub TeacherInformationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TeacherInformationToolStripMenuItem.Click
        StudentGroupListForm.ShowDialog()
    End Sub

    Private Sub StudentListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StudentListToolStripMenuItem.Click
        StudentListForm.ShowDialog()
    End Sub

    Private Sub SubjectListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SubjectListToolStripMenuItem.Click
        SubjectListForm.ShowDialog()
    End Sub

    Private Sub FindStaffTeacherToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FindStaffTeacherToolStripMenuItem.Click
        TeacherListForm.ShowDialog()
    End Sub

    Private Sub AddTeacherToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddTeacherToolStripMenuItem.Click
        TeacherForm.Show()
        TeacherForm.AddUpdateButton.Text = "Add"
    End Sub

    Private Sub UserListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UserListToolStripMenuItem.Click
        UserListForm.ShowDialog()
    End Sub

    Private Sub ApplicationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ApplicationToolStripMenuItem.Click

    End Sub

    Private Sub StudentInformationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StudentInformationToolStripMenuItem.Click
        StudentListForm.ShowDialog()
    End Sub

    Private Sub StafInformationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StafInformationToolStripMenuItem.Click
        TeacherForm.Show()
        TeacherForm.AddUpdateButton.Text = "Add"
    End Sub

End Class
