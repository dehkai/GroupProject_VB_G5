<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StudentForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StudentForm))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.courseTextBox = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.clearButton = New System.Windows.Forms.Button()
        Me.MaleRadioButton = New System.Windows.Forms.RadioButton()
        Me.FemaleRadioButton = New System.Windows.Forms.RadioButton()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.PostCodeTextBox = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.DistrictTextBox = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.CityTextBox = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Address2TextBox = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Address1TextBox = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.emailTextBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dobDateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.nameTextBox = New System.Windows.Forms.TextBox()
        Me.classComboBox = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PhoneNumberTextBox = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CancelButton = New System.Windows.Forms.Button()
        Me.AddUpdateButton = New System.Windows.Forms.Button()
        Me.icNumberTextBox = New System.Windows.Forms.TextBox()
        Me.matricTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.GroupBox1.Controls.Add(Me.courseTextBox)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.clearButton)
        Me.GroupBox1.Controls.Add(Me.MaleRadioButton)
        Me.GroupBox1.Controls.Add(Me.FemaleRadioButton)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.PostCodeTextBox)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.DistrictTextBox)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.CityTextBox)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Address2TextBox)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Address1TextBox)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.emailTextBox)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.dobDateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.nameTextBox)
        Me.GroupBox1.Controls.Add(Me.classComboBox)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.PhoneNumberTextBox)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.CancelButton)
        Me.GroupBox1.Controls.Add(Me.AddUpdateButton)
        Me.GroupBox1.Controls.Add(Me.icNumberTextBox)
        Me.GroupBox1.Controls.Add(Me.matricTextBox)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.GroupBox1.Location = New System.Drawing.Point(131, 66)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.GroupBox1.Size = New System.Drawing.Size(682, 742)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Student Information"
        '
        'courseTextBox
        '
        Me.courseTextBox.Location = New System.Drawing.Point(207, 566)
        Me.courseTextBox.Name = "courseTextBox"
        Me.courseTextBox.Size = New System.Drawing.Size(262, 23)
        Me.courseTextBox.TabIndex = 39
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(13, 568)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(53, 17)
        Me.Label14.TabIndex = 38
        Me.Label14.Text = "Course"
        '
        'clearButton
        '
        Me.clearButton.BackColor = System.Drawing.Color.PeachPuff
        Me.clearButton.Location = New System.Drawing.Point(458, 673)
        Me.clearButton.Name = "clearButton"
        Me.clearButton.Size = New System.Drawing.Size(101, 45)
        Me.clearButton.TabIndex = 37
        Me.clearButton.Text = "Clear"
        Me.clearButton.UseVisualStyleBackColor = False
        '
        'MaleRadioButton
        '
        Me.MaleRadioButton.AutoSize = True
        Me.MaleRadioButton.Location = New System.Drawing.Point(349, 614)
        Me.MaleRadioButton.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MaleRadioButton.Name = "MaleRadioButton"
        Me.MaleRadioButton.Size = New System.Drawing.Size(56, 21)
        Me.MaleRadioButton.TabIndex = 36
        Me.MaleRadioButton.TabStop = True
        Me.MaleRadioButton.Text = "Male"
        Me.MaleRadioButton.UseVisualStyleBackColor = True
        '
        'FemaleRadioButton
        '
        Me.FemaleRadioButton.AutoSize = True
        Me.FemaleRadioButton.Location = New System.Drawing.Point(209, 614)
        Me.FemaleRadioButton.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.FemaleRadioButton.Name = "FemaleRadioButton"
        Me.FemaleRadioButton.Size = New System.Drawing.Size(72, 21)
        Me.FemaleRadioButton.TabIndex = 35
        Me.FemaleRadioButton.TabStop = True
        Me.FemaleRadioButton.Text = "Female"
        Me.FemaleRadioButton.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(16, 614)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(56, 17)
        Me.Label13.TabIndex = 34
        Me.Label13.Text = "Gender"
        '
        'PostCodeTextBox
        '
        Me.PostCodeTextBox.Location = New System.Drawing.Point(207, 523)
        Me.PostCodeTextBox.Name = "PostCodeTextBox"
        Me.PostCodeTextBox.Size = New System.Drawing.Size(262, 23)
        Me.PostCodeTextBox.TabIndex = 33
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(13, 523)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(67, 17)
        Me.Label12.TabIndex = 32
        Me.Label12.Text = "Postcode"
        '
        'DistrictTextBox
        '
        Me.DistrictTextBox.Location = New System.Drawing.Point(207, 479)
        Me.DistrictTextBox.Name = "DistrictTextBox"
        Me.DistrictTextBox.Size = New System.Drawing.Size(262, 23)
        Me.DistrictTextBox.TabIndex = 31
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(13, 479)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(51, 17)
        Me.Label11.TabIndex = 30
        Me.Label11.Text = "District"
        '
        'CityTextBox
        '
        Me.CityTextBox.Location = New System.Drawing.Point(207, 431)
        Me.CityTextBox.Name = "CityTextBox"
        Me.CityTextBox.Size = New System.Drawing.Size(262, 23)
        Me.CityTextBox.TabIndex = 29
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(13, 431)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(31, 17)
        Me.Label10.TabIndex = 28
        Me.Label10.Text = "City"
        '
        'Address2TextBox
        '
        Me.Address2TextBox.Location = New System.Drawing.Point(207, 390)
        Me.Address2TextBox.Name = "Address2TextBox"
        Me.Address2TextBox.Size = New System.Drawing.Size(262, 23)
        Me.Address2TextBox.TabIndex = 27
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(13, 390)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(67, 17)
        Me.Label9.TabIndex = 26
        Me.Label9.Text = "Addess 2"
        '
        'Address1TextBox
        '
        Me.Address1TextBox.Location = New System.Drawing.Point(207, 344)
        Me.Address1TextBox.Name = "Address1TextBox"
        Me.Address1TextBox.Size = New System.Drawing.Size(262, 23)
        Me.Address1TextBox.TabIndex = 25
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(13, 344)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(67, 17)
        Me.Label8.TabIndex = 24
        Me.Label8.Text = "Addess 1"
        '
        'emailTextBox
        '
        Me.emailTextBox.Location = New System.Drawing.Point(207, 304)
        Me.emailTextBox.Name = "emailTextBox"
        Me.emailTextBox.Size = New System.Drawing.Size(262, 23)
        Me.emailTextBox.TabIndex = 23
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 304)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 17)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Email"
        '
        'dobDateTimePicker1
        '
        Me.dobDateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dobDateTimePicker1.Location = New System.Drawing.Point(207, 174)
        Me.dobDateTimePicker1.Name = "dobDateTimePicker1"
        Me.dobDateTimePicker1.Size = New System.Drawing.Size(260, 23)
        Me.dobDateTimePicker1.TabIndex = 21
        Me.dobDateTimePicker1.Value = New Date(2022, 10, 30, 1, 32, 24, 0)
        '
        'nameTextBox
        '
        Me.nameTextBox.Location = New System.Drawing.Point(207, 129)
        Me.nameTextBox.Name = "nameTextBox"
        Me.nameTextBox.Size = New System.Drawing.Size(262, 23)
        Me.nameTextBox.TabIndex = 20
        '
        'classComboBox
        '
        Me.classComboBox.FormattingEnabled = True
        Me.classComboBox.Location = New System.Drawing.Point(207, 258)
        Me.classComboBox.Name = "classComboBox"
        Me.classComboBox.Size = New System.Drawing.Size(262, 24)
        Me.classComboBox.TabIndex = 19
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(13, 258)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 17)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Class"
        '
        'PhoneNumberTextBox
        '
        Me.PhoneNumberTextBox.Location = New System.Drawing.Point(207, 217)
        Me.PhoneNumberTextBox.Name = "PhoneNumberTextBox"
        Me.PhoneNumberTextBox.Size = New System.Drawing.Size(262, 23)
        Me.PhoneNumberTextBox.TabIndex = 16
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(13, 217)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(103, 17)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Phone Number"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 174)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 17)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Date of birth"
        '
        'CancelButton
        '
        Me.CancelButton.BackColor = System.Drawing.Color.PeachPuff
        Me.CancelButton.Location = New System.Drawing.Point(329, 673)
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.Size = New System.Drawing.Size(101, 45)
        Me.CancelButton.TabIndex = 7
        Me.CancelButton.Text = "Cancel"
        Me.CancelButton.UseVisualStyleBackColor = False
        '
        'AddUpdateButton
        '
        Me.AddUpdateButton.BackColor = System.Drawing.Color.PeachPuff
        Me.AddUpdateButton.Location = New System.Drawing.Point(209, 673)
        Me.AddUpdateButton.Name = "AddUpdateButton"
        Me.AddUpdateButton.Size = New System.Drawing.Size(97, 45)
        Me.AddUpdateButton.TabIndex = 6
        Me.AddUpdateButton.Text = "Button1"
        Me.AddUpdateButton.UseVisualStyleBackColor = False
        '
        'icNumberTextBox
        '
        Me.icNumberTextBox.Location = New System.Drawing.Point(207, 87)
        Me.icNumberTextBox.Name = "icNumberTextBox"
        Me.icNumberTextBox.Size = New System.Drawing.Size(262, 23)
        Me.icNumberTextBox.TabIndex = 4
        '
        'matricTextBox
        '
        Me.matricTextBox.Location = New System.Drawing.Point(207, 44)
        Me.matricTextBox.Name = "matricTextBox"
        Me.matricTextBox.Size = New System.Drawing.Size(262, 23)
        Me.matricTextBox.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 133)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Ic Number"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Matric Number"
        '
        'StudentForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.ClientSize = New System.Drawing.Size(944, 827)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "StudentForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Student Form"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents courseTextBox As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents clearButton As Button
    Friend WithEvents MaleRadioButton As RadioButton
    Friend WithEvents FemaleRadioButton As RadioButton
    Friend WithEvents Label13 As Label
    Friend WithEvents PostCodeTextBox As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents DistrictTextBox As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents CityTextBox As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Address2TextBox As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Address1TextBox As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents emailTextBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents dobDateTimePicker1 As DateTimePicker
    Friend WithEvents nameTextBox As TextBox
    Friend WithEvents classComboBox As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents PhoneNumberTextBox As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents CancelButton As Button
    Friend WithEvents AddUpdateButton As Button
    Friend WithEvents icNumberTextBox As TextBox
    Friend WithEvents matricTextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
