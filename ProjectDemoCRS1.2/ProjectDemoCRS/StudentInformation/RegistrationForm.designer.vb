<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RegistrationForm
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.courseLabel = New System.Windows.Forms.Label()
        Me.statusLabel = New System.Windows.Forms.Label()
        Me.nameLabel = New System.Windows.Forms.Label()
        Me.matricNumberLabel = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SubjectCodeTextBox = New System.Windows.Forms.TextBox()
        Me.AddSubjectButton = New System.Windows.Forms.Button()
        Me.DropButton = New System.Windows.Forms.Button()
        Me.SubjectRegisterDataGridView = New System.Windows.Forms.DataGridView()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TotalCreditLabel = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.SubjectRegisterDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.courseLabel)
        Me.GroupBox1.Controls.Add(Me.statusLabel)
        Me.GroupBox1.Controls.Add(Me.nameLabel)
        Me.GroupBox1.Controls.Add(Me.matricNumberLabel)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 41)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(6)
        Me.GroupBox1.Size = New System.Drawing.Size(554, 226)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Student Information"
        '
        'courseLabel
        '
        Me.courseLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.courseLabel.Location = New System.Drawing.Point(201, 151)
        Me.courseLabel.Name = "courseLabel"
        Me.courseLabel.Size = New System.Drawing.Size(257, 35)
        Me.courseLabel.TabIndex = 7
        '
        'statusLabel
        '
        Me.statusLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.statusLabel.Location = New System.Drawing.Point(201, 111)
        Me.statusLabel.Name = "statusLabel"
        Me.statusLabel.Size = New System.Drawing.Size(257, 35)
        Me.statusLabel.TabIndex = 6
        '
        'nameLabel
        '
        Me.nameLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.nameLabel.Location = New System.Drawing.Point(201, 74)
        Me.nameLabel.Name = "nameLabel"
        Me.nameLabel.Size = New System.Drawing.Size(257, 35)
        Me.nameLabel.TabIndex = 5
        '
        'matricNumberLabel
        '
        Me.matricNumberLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.matricNumberLabel.Location = New System.Drawing.Point(201, 34)
        Me.matricNumberLabel.Name = "matricNumberLabel"
        Me.matricNumberLabel.Size = New System.Drawing.Size(257, 35)
        Me.matricNumberLabel.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(35, 161)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 25)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Course"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(35, 121)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 25)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Status"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(35, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(35, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(152, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Matric Number"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.SubjectCodeTextBox)
        Me.GroupBox2.Controls.Add(Me.AddSubjectButton)
        Me.GroupBox2.Controls.Add(Me.DropButton)
        Me.GroupBox2.Controls.Add(Me.SubjectRegisterDataGridView)
        Me.GroupBox2.Location = New System.Drawing.Point(16, 295)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1126, 325)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Subject Register"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(838, 17)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(266, 25)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Enter Subject Code to Add"
        '
        'SubjectCodeTextBox
        '
        Me.SubjectCodeTextBox.Location = New System.Drawing.Point(887, 45)
        Me.SubjectCodeTextBox.Name = "SubjectCodeTextBox"
        Me.SubjectCodeTextBox.Size = New System.Drawing.Size(175, 31)
        Me.SubjectCodeTextBox.TabIndex = 4
        '
        'AddSubjectButton
        '
        Me.AddSubjectButton.Location = New System.Drawing.Point(887, 83)
        Me.AddSubjectButton.Name = "AddSubjectButton"
        Me.AddSubjectButton.Size = New System.Drawing.Size(179, 53)
        Me.AddSubjectButton.TabIndex = 3
        Me.AddSubjectButton.Text = "Add Subject"
        Me.AddSubjectButton.UseVisualStyleBackColor = True
        '
        'DropButton
        '
        Me.DropButton.Location = New System.Drawing.Point(887, 142)
        Me.DropButton.Name = "DropButton"
        Me.DropButton.Size = New System.Drawing.Size(179, 53)
        Me.DropButton.TabIndex = 2
        Me.DropButton.Text = "Drop Subject"
        Me.DropButton.UseVisualStyleBackColor = True
        '
        'SubjectRegisterDataGridView
        '
        Me.SubjectRegisterDataGridView.AllowUserToResizeRows = False
        Me.SubjectRegisterDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.SubjectRegisterDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SubjectRegisterDataGridView.Location = New System.Drawing.Point(21, 50)
        Me.SubjectRegisterDataGridView.Name = "SubjectRegisterDataGridView"
        Me.SubjectRegisterDataGridView.Size = New System.Drawing.Size(860, 258)
        Me.SubjectRegisterDataGridView.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.TotalCreditLabel)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Location = New System.Drawing.Point(593, 51)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(227, 226)
        Me.GroupBox3.TabIndex = 8
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Information"
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label8.Location = New System.Drawing.Point(39, 161)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(149, 38)
        Me.Label8.TabIndex = 3
        '
        'TotalCreditLabel
        '
        Me.TotalCreditLabel.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.TotalCreditLabel.Location = New System.Drawing.Point(39, 75)
        Me.TotalCreditLabel.Name = "TotalCreditLabel"
        Me.TotalCreditLabel.Size = New System.Drawing.Size(149, 38)
        Me.TotalCreditLabel.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(54, 126)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(128, 25)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Fee Amount"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(48, 44)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(134, 25)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Total Credits"
        '
        'RegistrationForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1205, 669)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "RegistrationForm"
        Me.Text = "RegistrationForm"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.SubjectRegisterDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents courseLabel As System.Windows.Forms.Label
    Friend WithEvents statusLabel As System.Windows.Forms.Label
    Friend WithEvents nameLabel As System.Windows.Forms.Label
    Friend WithEvents matricNumberLabel As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents SubjectRegisterDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents AddSubjectButton As System.Windows.Forms.Button
    Friend WithEvents DropButton As System.Windows.Forms.Button
    Friend WithEvents Label5 As Label
    Friend WithEvents SubjectCodeTextBox As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TotalCreditLabel As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
End Class
