Public Class StudentCrsMainForm
    Private Sub StudentCrsMainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs)

    End Sub

    Private Sub ClassListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClassListToolStripMenuItem.Click
        StudentGroupListForm.ShowDialog()
    End Sub

    Private Sub AssignTeacherToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AssignTeacherToolStripMenuItem.Click
        TeacherForm.ShowDialog()
    End Sub

    Private Sub EnrolStudentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EnrolStudentToolStripMenuItem.Click
        StudentForm.ShowDialog()
    End Sub

    Private Sub FindTeacherToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FindTeacherToolStripMenuItem.Click
        TeacherListForm.ShowDialog()
    End Sub

    Private Sub AddTeacherToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddTeacherToolStripMenuItem.Click
        TeacherForm.ShowDialog()
    End Sub

    Private Sub StudentListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StudentListToolStripMenuItem.Click
        StudentListForm.ShowDialog()
    End Sub

    Private Sub SubjectListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SubjectListToolStripMenuItem.Click
        SubjectListForm.ShowDialog()
    End Sub
End Class