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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CrsMainForm))
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
        Me.SubjectInformationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SubjectListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UserInformationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UserListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TeacherReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StaffReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StudentReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AbutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.AliceBlue
        Me.MenuStrip1.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 33)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(6, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(1200, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuStrip2
        '
        Me.MenuStrip2.BackColor = System.Drawing.Color.GhostWhite
        Me.MenuStrip2.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.MenuStrip2.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ApplicationToolStripMenuItem, Me.RegistrarToolStripMenuItem, Me.ToolStripMenuItem1, Me.ToolStripMenuItem2, Me.SubjectInformationToolStripMenuItem, Me.UserInformationToolStripMenuItem, Me.ReportingToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip2.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Padding = New System.Windows.Forms.Padding(6, 2, 0, 2)
        Me.MenuStrip2.Size = New System.Drawing.Size(1200, 33)
        Me.MenuStrip2.TabIndex = 1
        Me.MenuStrip2.Text = "MenuStrip2"
        '
        'ApplicationToolStripMenuItem
        '
        Me.ApplicationToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LogoutToolStripMenuItem})
        Me.ApplicationToolStripMenuItem.Name = "ApplicationToolStripMenuItem"
        Me.ApplicationToolStripMenuItem.Size = New System.Drawing.Size(54, 29)
        Me.ApplicationToolStripMenuItem.Text = "File"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(171, 34)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'RegistrarToolStripMenuItem
        '
        Me.RegistrarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TeacherInformationToolStripMenuItem, Me.StafInformationToolStripMenuItem, Me.StudentInformationToolStripMenuItem})
        Me.RegistrarToolStripMenuItem.Name = "RegistrarToolStripMenuItem"
        Me.RegistrarToolStripMenuItem.Size = New System.Drawing.Size(97, 29)
        Me.RegistrarToolStripMenuItem.Text = "Registrar"
        '
        'TeacherInformationToolStripMenuItem
        '
        Me.TeacherInformationToolStripMenuItem.Name = "TeacherInformationToolStripMenuItem"
        Me.TeacherInformationToolStripMenuItem.Size = New System.Drawing.Size(230, 34)
        Me.TeacherInformationToolStripMenuItem.Text = "Class List"
        '
        'StafInformationToolStripMenuItem
        '
        Me.StafInformationToolStripMenuItem.Name = "StafInformationToolStripMenuItem"
        Me.StafInformationToolStripMenuItem.Size = New System.Drawing.Size(270, 34)
        Me.StafInformationToolStripMenuItem.Text = "Assign Teacher"
        '
        'StudentInformationToolStripMenuItem
        '
        Me.StudentInformationToolStripMenuItem.Name = "StudentInformationToolStripMenuItem"
        Me.StudentInformationToolStripMenuItem.Size = New System.Drawing.Size(270, 34)
        Me.StudentInformationToolStripMenuItem.Text = "Enrol Student"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FindStaffTeacherToolStripMenuItem, Me.AddStaffToolStripMenuItem, Me.AddTeacherToolStripMenuItem})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(162, 29)
        Me.ToolStripMenuItem1.Text = "Staff and Teacher"
        '
        'FindStaffTeacherToolStripMenuItem
        '
        Me.FindStaffTeacherToolStripMenuItem.Name = "FindStaffTeacherToolStripMenuItem"
        Me.FindStaffTeacherToolStripMenuItem.Size = New System.Drawing.Size(254, 34)
        Me.FindStaffTeacherToolStripMenuItem.Text = "Find Staff/Teacher"
        '
        'AddStaffToolStripMenuItem
        '
        Me.AddStaffToolStripMenuItem.Name = "AddStaffToolStripMenuItem"
        Me.AddStaffToolStripMenuItem.Size = New System.Drawing.Size(254, 34)
        Me.AddStaffToolStripMenuItem.Text = "Add Staff"
        '
        'AddTeacherToolStripMenuItem
        '
        Me.AddTeacherToolStripMenuItem.Name = "AddTeacherToolStripMenuItem"
        Me.AddTeacherToolStripMenuItem.Size = New System.Drawing.Size(254, 34)
        Me.AddTeacherToolStripMenuItem.Text = "Add Teacher"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StudentListToolStripMenuItem})
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(188, 29)
        Me.ToolStripMenuItem2.Text = "Student Information"
        '
        'StudentListToolStripMenuItem
        '
        Me.StudentListToolStripMenuItem.Name = "StudentListToolStripMenuItem"
        Me.StudentListToolStripMenuItem.Size = New System.Drawing.Size(206, 34)
        Me.StudentListToolStripMenuItem.Text = "Student List"
        '
        'SubjectInformationToolStripMenuItem
        '
        Me.SubjectInformationToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SubjectListToolStripMenuItem})
        Me.SubjectInformationToolStripMenuItem.Name = "SubjectInformationToolStripMenuItem"
        Me.SubjectInformationToolStripMenuItem.Size = New System.Drawing.Size(185, 29)
        Me.SubjectInformationToolStripMenuItem.Text = "Subject Information"
        '
        'SubjectListToolStripMenuItem
        '
        Me.SubjectListToolStripMenuItem.Name = "SubjectListToolStripMenuItem"
        Me.SubjectListToolStripMenuItem.Size = New System.Drawing.Size(203, 34)
        Me.SubjectListToolStripMenuItem.Text = "Subject List"
        '
        'UserInformationToolStripMenuItem
        '
        Me.UserInformationToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UserListToolStripMenuItem})
        Me.UserInformationToolStripMenuItem.Name = "UserInformationToolStripMenuItem"
        Me.UserInformationToolStripMenuItem.Size = New System.Drawing.Size(162, 29)
        Me.UserInformationToolStripMenuItem.Text = "User Information"
        '
        'UserListToolStripMenuItem
        '
        Me.UserListToolStripMenuItem.Name = "UserListToolStripMenuItem"
        Me.UserListToolStripMenuItem.Size = New System.Drawing.Size(180, 34)
        Me.UserListToolStripMenuItem.Text = "User List"
        '
        'ReportingToolStripMenuItem
        '
        Me.ReportingToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TeacherReportToolStripMenuItem, Me.StaffReportToolStripMenuItem, Me.StudentReportToolStripMenuItem})
        Me.ReportingToolStripMenuItem.Name = "ReportingToolStripMenuItem"
        Me.ReportingToolStripMenuItem.Size = New System.Drawing.Size(106, 29)
        Me.ReportingToolStripMenuItem.Text = "Reporting"
        '
        'TeacherReportToolStripMenuItem
        '
        Me.TeacherReportToolStripMenuItem.Name = "TeacherReportToolStripMenuItem"
        Me.TeacherReportToolStripMenuItem.Size = New System.Drawing.Size(233, 34)
        Me.TeacherReportToolStripMenuItem.Text = "Teacher Report"
        '
        'StaffReportToolStripMenuItem
        '
        Me.StaffReportToolStripMenuItem.Name = "StaffReportToolStripMenuItem"
        Me.StaffReportToolStripMenuItem.Size = New System.Drawing.Size(233, 34)
        Me.StaffReportToolStripMenuItem.Text = "Staff Report"
        '
        'StudentReportToolStripMenuItem
        '
        Me.StudentReportToolStripMenuItem.Name = "StudentReportToolStripMenuItem"
        Me.StudentReportToolStripMenuItem.Size = New System.Drawing.Size(233, 34)
        Me.StudentReportToolStripMenuItem.Text = "Student Report"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem, Me.AbutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(65, 29)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(166, 34)
        Me.AboutToolStripMenuItem.Text = "Search"
        '
        'AbutToolStripMenuItem
        '
        Me.AbutToolStripMenuItem.Name = "AbutToolStripMenuItem"
        Me.AbutToolStripMenuItem.Size = New System.Drawing.Size(270, 34)
        Me.AbutToolStripMenuItem.Text = "Abut"
        '
        'PictureBox1
        '
        Me.PictureBox1.ErrorImage = CType(resources.GetObject("PictureBox1.ErrorImage"), System.Drawing.Image)
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.InitialImage = CType(resources.GetObject("PictureBox1.InitialImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(194, 125)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(812, 445)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(474, 58)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(195, 40)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Staff Page"
        '
        'CrsMainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(1200, 692)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.MenuStrip2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "CrsMainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CrsMain"
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents UserInformationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UserListToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
End Class
