Public Class CrsMainForm
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

    Private Sub ApplicationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ApplicationToolStripMenuItem.Click

    End Sub

    Private Sub CrsMainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub SubjectToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SubjectToolStripMenuItem.Click
        StudentSubjectListForm.ShowDialog()
    End Sub

    Private Sub SubjectListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SubjectListToolStripMenuItem.Click
        SubjectListForm.ShowDialog()
    End Sub
End Class
