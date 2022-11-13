<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class StudentCrsMainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StudentCrsMainForm))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TeacherInformationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StudentInformationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SubjectInformationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClassListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AssignTeacherToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnrolStudentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FindTeacherToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddTeacherToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StudentListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SubjectListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TeacherReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StudentReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(423, 75)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(271, 40)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Registrar Page"
        '
        'PictureBox1
        '
        Me.PictureBox1.ErrorImage = CType(resources.GetObject("PictureBox1.ErrorImage"), System.Drawing.Image)
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.InitialImage = CType(resources.GetObject("PictureBox1.InitialImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(195, 125)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(812, 445)
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.MintCream
        Me.MenuStrip1.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.RegistrarToolStripMenuItem, Me.TeacherInformationToolStripMenuItem, Me.StudentInformationToolStripMenuItem, Me.SubjectInformationToolStripMenuItem, Me.ReportingToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1200, 33)
        Me.MenuStrip1.TabIndex = 7
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LogoutToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(54, 29)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'RegistrarToolStripMenuItem
        '
        Me.RegistrarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClassListToolStripMenuItem, Me.AssignTeacherToolStripMenuItem, Me.EnrolStudentToolStripMenuItem})
        Me.RegistrarToolStripMenuItem.Name = "RegistrarToolStripMenuItem"
        Me.RegistrarToolStripMenuItem.Size = New System.Drawing.Size(97, 29)
        Me.RegistrarToolStripMenuItem.Text = "Registrar"
        '
        'TeacherInformationToolStripMenuItem
        '
        Me.TeacherInformationToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FindTeacherToolStripMenuItem, Me.AddTeacherToolStripMenuItem})
        Me.TeacherInformationToolStripMenuItem.Name = "TeacherInformationToolStripMenuItem"
        Me.TeacherInformationToolStripMenuItem.Size = New System.Drawing.Size(185, 29)
        Me.TeacherInformationToolStripMenuItem.Text = "Teacher Information"
        '
        'StudentInformationToolStripMenuItem
        '
        Me.StudentInformationToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StudentListToolStripMenuItem})
        Me.StudentInformationToolStripMenuItem.Name = "StudentInformationToolStripMenuItem"
        Me.StudentInformationToolStripMenuItem.Size = New System.Drawing.Size(188, 29)
        Me.StudentInformationToolStripMenuItem.Text = "Student Information"
        '
        'SubjectInformationToolStripMenuItem
        '
        Me.SubjectInformationToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SubjectListToolStripMenuItem})
        Me.SubjectInformationToolStripMenuItem.Name = "SubjectInformationToolStripMenuItem"
        Me.SubjectInformationToolStripMenuItem.Size = New System.Drawing.Size(185, 29)
        Me.SubjectInformationToolStripMenuItem.Text = "Subject Information"
        '
        'ReportingToolStripMenuItem
        '
        Me.ReportingToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TeacherReportToolStripMenuItem, Me.StudentReportToolStripMenuItem})
        Me.ReportingToolStripMenuItem.Name = "ReportingToolStripMenuItem"
        Me.ReportingToolStripMenuItem.Size = New System.Drawing.Size(106, 29)
        Me.ReportingToolStripMenuItem.Text = "Reporting"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SearchToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(65, 29)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(270, 34)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'ClassListToolStripMenuItem
        '
        Me.ClassListToolStripMenuItem.Name = "ClassListToolStripMenuItem"
        Me.ClassListToolStripMenuItem.Size = New System.Drawing.Size(270, 34)
        Me.ClassListToolStripMenuItem.Text = "Class List"
        '
        'AssignTeacherToolStripMenuItem
        '
        Me.AssignTeacherToolStripMenuItem.Name = "AssignTeacherToolStripMenuItem"
        Me.AssignTeacherToolStripMenuItem.Size = New System.Drawing.Size(270, 34)
        Me.AssignTeacherToolStripMenuItem.Text = "Assign Teacher"
        '
        'EnrolStudentToolStripMenuItem
        '
        Me.EnrolStudentToolStripMenuItem.Name = "EnrolStudentToolStripMenuItem"
        Me.EnrolStudentToolStripMenuItem.Size = New System.Drawing.Size(270, 34)
        Me.EnrolStudentToolStripMenuItem.Text = "Enrol Student"
        '
        'FindTeacherToolStripMenuItem
        '
        Me.FindTeacherToolStripMenuItem.Name = "FindTeacherToolStripMenuItem"
        Me.FindTeacherToolStripMenuItem.Size = New System.Drawing.Size(270, 34)
        Me.FindTeacherToolStripMenuItem.Text = "Find Teacher"
        '
        'AddTeacherToolStripMenuItem
        '
        Me.AddTeacherToolStripMenuItem.Name = "AddTeacherToolStripMenuItem"
        Me.AddTeacherToolStripMenuItem.Size = New System.Drawing.Size(270, 34)
        Me.AddTeacherToolStripMenuItem.Text = "Add Teacher"
        '
        'StudentListToolStripMenuItem
        '
        Me.StudentListToolStripMenuItem.Name = "StudentListToolStripMenuItem"
        Me.StudentListToolStripMenuItem.Size = New System.Drawing.Size(270, 34)
        Me.StudentListToolStripMenuItem.Text = "Student List"
        '
        'SubjectListToolStripMenuItem
        '
        Me.SubjectListToolStripMenuItem.Name = "SubjectListToolStripMenuItem"
        Me.SubjectListToolStripMenuItem.Size = New System.Drawing.Size(270, 34)
        Me.SubjectListToolStripMenuItem.Text = "Subject List"
        '
        'TeacherReportToolStripMenuItem
        '
        Me.TeacherReportToolStripMenuItem.Name = "TeacherReportToolStripMenuItem"
        Me.TeacherReportToolStripMenuItem.Size = New System.Drawing.Size(270, 34)
        Me.TeacherReportToolStripMenuItem.Text = "Teacher Report"
        '
        'StudentReportToolStripMenuItem
        '
        Me.StudentReportToolStripMenuItem.Name = "StudentReportToolStripMenuItem"
        Me.StudentReportToolStripMenuItem.Size = New System.Drawing.Size(270, 34)
        Me.StudentReportToolStripMenuItem.Text = "Student Report"
        '
        'SearchToolStripMenuItem
        '
        Me.SearchToolStripMenuItem.Name = "SearchToolStripMenuItem"
        Me.SearchToolStripMenuItem.Size = New System.Drawing.Size(270, 34)
        Me.SearchToolStripMenuItem.Text = "Search"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(270, 34)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'StudentCrsMainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.OldLace
        Me.ClientSize = New System.Drawing.Size(1200, 692)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "StudentCrsMainForm"
        Me.Text = "StudentCrsMainForm"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RegistrarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TeacherInformationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StudentInformationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SubjectInformationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClassListToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AssignTeacherToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EnrolStudentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FindTeacherToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddTeacherToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StudentListToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SubjectListToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TeacherReportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StudentReportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SearchToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
End Class
