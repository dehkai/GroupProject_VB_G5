<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StudentGroupForm
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
        Me.AddUpdateButton = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.secondaryRadioButton = New System.Windows.Forms.RadioButton()
        Me.primaryRadioButton = New System.Windows.Forms.RadioButton()
        Me.noOfStudentTextBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CancelButton = New System.Windows.Forms.Button()
        Me.groupNameTextBox = New System.Windows.Forms.TextBox()
        Me.groupIdTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'AddUpdateButton
        '
        Me.AddUpdateButton.BackColor = System.Drawing.SystemColors.Info
        Me.AddUpdateButton.Location = New System.Drawing.Point(224, 540)
        Me.AddUpdateButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.AddUpdateButton.Name = "AddUpdateButton"
        Me.AddUpdateButton.Size = New System.Drawing.Size(176, 69)
        Me.AddUpdateButton.TabIndex = 6
        Me.AddUpdateButton.Text = "Button1"
        Me.AddUpdateButton.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.noOfStudentTextBox)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.CancelButton)
        Me.GroupBox1.Controls.Add(Me.AddUpdateButton)
        Me.GroupBox1.Controls.Add(Me.groupNameTextBox)
        Me.GroupBox1.Controls.Add(Me.groupIdTextBox)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(106, 54)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(9, 9, 9, 9)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(9, 9, 9, 9)
        Me.GroupBox1.Size = New System.Drawing.Size(1023, 775)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Student Group Information"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.secondaryRadioButton)
        Me.GroupBox2.Controls.Add(Me.primaryRadioButton)
        Me.GroupBox2.Location = New System.Drawing.Point(298, 223)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox2.Size = New System.Drawing.Size(489, 120)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        '
        'secondaryRadioButton
        '
        Me.secondaryRadioButton.AutoSize = True
        Me.secondaryRadioButton.Location = New System.Drawing.Point(255, 46)
        Me.secondaryRadioButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.secondaryRadioButton.Name = "secondaryRadioButton"
        Me.secondaryRadioButton.Size = New System.Drawing.Size(194, 41)
        Me.secondaryRadioButton.TabIndex = 13
        Me.secondaryRadioButton.TabStop = True
        Me.secondaryRadioButton.Text = "Secondary"
        Me.secondaryRadioButton.UseVisualStyleBackColor = True
        '
        'primaryRadioButton
        '
        Me.primaryRadioButton.AutoSize = True
        Me.primaryRadioButton.Checked = True
        Me.primaryRadioButton.Location = New System.Drawing.Point(54, 46)
        Me.primaryRadioButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.primaryRadioButton.Name = "primaryRadioButton"
        Me.primaryRadioButton.Size = New System.Drawing.Size(152, 41)
        Me.primaryRadioButton.TabIndex = 12
        Me.primaryRadioButton.TabStop = True
        Me.primaryRadioButton.Text = "Primary"
        Me.primaryRadioButton.UseVisualStyleBackColor = True
        '
        'noOfStudentTextBox
        '
        Me.noOfStudentTextBox.Location = New System.Drawing.Point(298, 417)
        Me.noOfStudentTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.noOfStudentTextBox.Name = "noOfStudentTextBox"
        Me.noOfStudentTextBox.Size = New System.Drawing.Size(386, 43)
        Me.noOfStudentTextBox.TabIndex = 9
        Me.noOfStudentTextBox.Text = "10"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 417)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(274, 37)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Maximum Student"
        '
        'CancelButton
        '
        Me.CancelButton.BackColor = System.Drawing.SystemColors.Info
        Me.CancelButton.Location = New System.Drawing.Point(441, 540)
        Me.CancelButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.Size = New System.Drawing.Size(176, 69)
        Me.CancelButton.TabIndex = 7
        Me.CancelButton.Text = "Cancel"
        Me.CancelButton.UseVisualStyleBackColor = False
        '
        'groupNameTextBox
        '
        Me.groupNameTextBox.Location = New System.Drawing.Point(304, 166)
        Me.groupNameTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.groupNameTextBox.Name = "groupNameTextBox"
        Me.groupNameTextBox.Size = New System.Drawing.Size(391, 43)
        Me.groupNameTextBox.TabIndex = 4
        Me.groupNameTextBox.Text = "3 BIRU"
        '
        'groupIdTextBox
        '
        Me.groupIdTextBox.Location = New System.Drawing.Point(309, 88)
        Me.groupIdTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.groupIdTextBox.Name = "groupIdTextBox"
        Me.groupIdTextBox.Size = New System.Drawing.Size(386, 43)
        Me.groupIdTextBox.TabIndex = 3
        Me.groupIdTextBox.Text = "P3_BIRU"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 243)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 37)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Level"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 166)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(202, 37)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Group Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 92)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(142, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Group Id"
        '
        'StudentGroupForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(1268, 946)
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "StudentGroupForm"
        Me.Text = "StudentGroupForm"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents AddUpdateButton As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents CancelButton As Button
    Friend WithEvents groupNameTextBox As TextBox
    Friend WithEvents groupIdTextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents noOfStudentTextBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents secondaryRadioButton As RadioButton
    Friend WithEvents primaryRadioButton As RadioButton
End Class
