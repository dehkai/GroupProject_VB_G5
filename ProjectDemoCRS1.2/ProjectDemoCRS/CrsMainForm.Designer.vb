<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CrsMainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.ApplicationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TeacherInformationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StafInformationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StudentInformationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.FindStaffTeacherToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddStaffToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddTeacherToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.StudentListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TeacherReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StaffReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StudentReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AbutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SubjectInformationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SubjectListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 24)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuStrip2
        '
        Me.MenuStrip2.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ApplicationToolStripMenuItem, Me.RegistrarToolStripMenuItem, Me.ToolStripMenuItem1, Me.ToolStripMenuItem2, Me.SubjectInformationToolStripMenuItem, Me.ReportingToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip2.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip2.TabIndex = 1
        Me.MenuStrip2.Text = "MenuStrip2"
        '
        'ApplicationToolStripMenuItem
        '
        Me.ApplicationToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LogoutToolStripMenuItem})
        Me.ApplicationToolStripMenuItem.Name = "ApplicationToolStripMenuItem"
        Me.ApplicationToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.ApplicationToolStripMenuItem.Text = "File"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'RegistrarToolStripMenuItem
        '
        Me.RegistrarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TeacherInformationToolStripMenuItem, Me.StafInformationToolStripMenuItem, Me.StudentInformationToolStripMenuItem})
        Me.RegistrarToolStripMenuItem.Name = "RegistrarToolStripMenuItem"
        Me.RegistrarToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.RegistrarToolStripMenuItem.Text = "Registrar"
        '
        'TeacherInformationToolStripMenuItem
        '
        Me.TeacherInformationToolStripMenuItem.Name = "TeacherInformationToolStripMenuItem"
        Me.TeacherInformationToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.TeacherInformationToolStripMenuItem.Text = "Class List"
        '
        'StafInformationToolStripMenuItem
        '
        Me.StafInformationToolStripMenuItem.Name = "StafInformationToolStripMenuItem"
        Me.StafInformationToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.StafInformationToolStripMenuItem.Text = "Assign Teacher"
        '
        'StudentInformationToolStripMenuItem
        '
        Me.StudentInformationToolStripMenuItem.Name = "StudentInformationToolStripMenuItem"
        Me.StudentInformationToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.StudentInformationToolStripMenuItem.Text = "Enrol Student"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FindStaffTeacherToolStripMenuItem, Me.AddStaffToolStripMenuItem, Me.AddTeacherToolStripMenuItem})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(109, 20)
        Me.ToolStripMenuItem1.Text = "Staff and Teacher"
        '
        'FindStaffTeacherToolStripMenuItem
        '
        Me.FindStaffTeacherToolStripMenuItem.Name = "FindStaffTeacherToolStripMenuItem"
        Me.FindStaffTeacherToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.FindStaffTeacherToolStripMenuItem.Text = "Find Staff/Teacher"
        '
        'AddStaffToolStripMenuItem
        '
        Me.AddStaffToolStripMenuItem.Name = "AddStaffToolStripMenuItem"
        Me.AddStaffToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.AddStaffToolStripMenuItem.Text = "Add Staff"
        '
        'AddTeacherToolStripMenuItem
        '
        Me.AddTeacherToolStripMenuItem.Name = "AddTeacherToolStripMenuItem"
        Me.AddTeacherToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.AddTeacherToolStripMenuItem.Text = "Add Teacher"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StudentListToolStripMenuItem})
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(126, 20)
        Me.ToolStripMenuItem2.Text = "Student Information"
        '
        'StudentListToolStripMenuItem
        '
        Me.StudentListToolStripMenuItem.Name = "StudentListToolStripMenuItem"
        Me.StudentListToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.StudentListToolStripMenuItem.Text = "Student List"
        '
        'ReportingToolStripMenuItem
        '
        Me.ReportingToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TeacherReportToolStripMenuItem, Me.StaffReportToolStripMenuItem, Me.StudentReportToolStripMenuItem})
        Me.ReportingToolStripMenuItem.Name = "ReportingToolStripMenuItem"
        Me.ReportingToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.ReportingToolStripMenuItem.Text = "Reporting"
        '
        'TeacherReportToolStripMenuItem
        '
        Me.TeacherReportToolStripMenuItem.Name = "TeacherReportToolStripMenuItem"
        Me.TeacherReportToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.TeacherReportToolStripMenuItem.Text = "Teacher Report"
        '
        'StaffReportToolStripMenuItem
        '
        Me.StaffReportToolStripMenuItem.Name = "StaffReportToolStripMenuItem"
        Me.StaffReportToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.StaffReportToolStripMenuItem.Text = "Staff Report"
        '
        'StudentReportToolStripMenuItem
        '
        Me.StudentReportToolStripMenuItem.Name = "StudentReportToolStripMenuItem"
        Me.StudentReportToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.StudentReportToolStripMenuItem.Text = "Student Report"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem, Me.AbutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AboutToolStripMenuItem.Text = "Search"
        '
        'AbutToolStripMenuItem
        '
        Me.AbutToolStripMenuItem.Name = "AbutToolStripMenuItem"
        Me.AbutToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AbutToolStripMenuItem.Text = "Abut"
        '
        'SubjectInformationToolStripMenuItem
        '
        Me.SubjectInformationToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SubjectListToolStripMenuItem})
        Me.SubjectInformationToolStripMenuItem.Name = "SubjectInformationToolStripMenuItem"
        Me.SubjectInformationToolStripMenuItem.Size = New System.Drawing.Size(124, 20)
        Me.SubjectInformationToolStripMenuItem.Text = "Subject Information"
        '
        'SubjectListToolStripMenuItem
        '
        Me.SubjectListToolStripMenuItem.Name = "SubjectListToolStripMenuItem"
        Me.SubjectListToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.SubjectListToolStripMenuItem.Text = "Subject List"
        '
        'CrsMainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.MenuStrip2)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "CrsMainForm"
        Me.Text = "CrsMain"
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenuStrip2 As MenuStrip
    Friend WithEvents ApplicationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RegistrarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TeacherInformationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StafInformationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StudentInformationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TeacherReportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StaffReportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StudentReportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AbutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents FindStaffTeacherToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddStaffToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddTeacherToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StudentListToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SubjectInformationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SubjectListToolStripMenuItem As ToolStripMenuItem
End Class
