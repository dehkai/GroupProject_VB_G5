<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StudentListForm
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
        Me.updateStudentButton = New System.Windows.Forms.Button()
        Me.AddStudentButton = New System.Windows.Forms.Button()
        Me.DeleteStudentButton = New System.Windows.Forms.Button()
        Me.StudentDataGridView = New System.Windows.Forms.DataGridView()
        Me.Search = New System.Windows.Forms.GroupBox()
        Me.displayAllButton = New System.Windows.Forms.Button()
        Me.nameButton = New System.Windows.Forms.Button()
        Me.ICButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.searchTextBox = New System.Windows.Forms.TextBox()
        Me.RegistrationButton = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.StudentDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Search.SuspendLayout()
        Me.SuspendLayout()
        '
        'updateStudentButton
        '
        Me.updateStudentButton.BackColor = System.Drawing.Color.WhiteSmoke
        Me.updateStudentButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.updateStudentButton.Location = New System.Drawing.Point(1045, 757)
        Me.updateStudentButton.Margin = New System.Windows.Forms.Padding(9)
        Me.updateStudentButton.Name = "updateStudentButton"
        Me.updateStudentButton.Size = New System.Drawing.Size(314, 92)
        Me.updateStudentButton.TabIndex = 12
        Me.updateStudentButton.Text = "Update Student"
        Me.updateStudentButton.UseVisualStyleBackColor = False
        '
        'AddStudentButton
        '
        Me.AddStudentButton.BackColor = System.Drawing.Color.WhiteSmoke
        Me.AddStudentButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddStudentButton.Location = New System.Drawing.Point(713, 757)
        Me.AddStudentButton.Margin = New System.Windows.Forms.Padding(9)
        Me.AddStudentButton.Name = "AddStudentButton"
        Me.AddStudentButton.Size = New System.Drawing.Size(314, 92)
        Me.AddStudentButton.TabIndex = 11
        Me.AddStudentButton.Text = "Add New Student"
        Me.AddStudentButton.UseVisualStyleBackColor = False
        '
        'DeleteStudentButton
        '
        Me.DeleteStudentButton.BackColor = System.Drawing.Color.WhiteSmoke
        Me.DeleteStudentButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteStudentButton.Location = New System.Drawing.Point(1376, 757)
        Me.DeleteStudentButton.Margin = New System.Windows.Forms.Padding(9)
        Me.DeleteStudentButton.Name = "DeleteStudentButton"
        Me.DeleteStudentButton.Size = New System.Drawing.Size(342, 92)
        Me.DeleteStudentButton.TabIndex = 10
        Me.DeleteStudentButton.Text = "Delete Student"
        Me.DeleteStudentButton.UseVisualStyleBackColor = False
        '
        'StudentDataGridView
        '
        Me.StudentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.StudentDataGridView.Location = New System.Drawing.Point(58, 249)
        Me.StudentDataGridView.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.StudentDataGridView.MultiSelect = False
        Me.StudentDataGridView.Name = "StudentDataGridView"
        Me.StudentDataGridView.RowHeadersWidth = 62
        Me.StudentDataGridView.Size = New System.Drawing.Size(1863, 454)
        Me.StudentDataGridView.TabIndex = 9
        '
        'Search
        '
        Me.Search.Controls.Add(Me.displayAllButton)
        Me.Search.Controls.Add(Me.nameButton)
        Me.Search.Controls.Add(Me.ICButton)
        Me.Search.Controls.Add(Me.Label1)
        Me.Search.Controls.Add(Me.searchTextBox)
        Me.Search.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Search.Location = New System.Drawing.Point(154, 20)
        Me.Search.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Search.Name = "Search"
        Me.Search.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Search.Size = New System.Drawing.Size(1767, 126)
        Me.Search.TabIndex = 13
        Me.Search.TabStop = False
        Me.Search.Text = "Search"
        '
        'displayAllButton
        '
        Me.displayAllButton.BackColor = System.Drawing.Color.WhiteSmoke
        Me.displayAllButton.Location = New System.Drawing.Point(1274, 62)
        Me.displayAllButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.displayAllButton.Name = "displayAllButton"
        Me.displayAllButton.Size = New System.Drawing.Size(186, 48)
        Me.displayAllButton.TabIndex = 4
        Me.displayAllButton.Text = "Display All"
        Me.displayAllButton.UseVisualStyleBackColor = False
        '
        'nameButton
        '
        Me.nameButton.BackColor = System.Drawing.Color.WhiteSmoke
        Me.nameButton.Location = New System.Drawing.Point(1048, 57)
        Me.nameButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.nameButton.Name = "nameButton"
        Me.nameButton.Size = New System.Drawing.Size(186, 52)
        Me.nameButton.TabIndex = 3
        Me.nameButton.Text = "By Name"
        Me.nameButton.UseVisualStyleBackColor = False
        '
        'ICButton
        '
        Me.ICButton.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ICButton.Location = New System.Drawing.Point(808, 62)
        Me.ICButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ICButton.Name = "ICButton"
        Me.ICButton.Size = New System.Drawing.Size(186, 48)
        Me.ICButton.TabIndex = 2
        Me.ICButton.Text = "By IC"
        Me.ICButton.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(148, 62)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(161, 37)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "IC / Name"
        '
        'searchTextBox
        '
        Me.searchTextBox.Location = New System.Drawing.Point(330, 62)
        Me.searchTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.searchTextBox.Name = "searchTextBox"
        Me.searchTextBox.Size = New System.Drawing.Size(440, 43)
        Me.searchTextBox.TabIndex = 0
        '
        'RegistrationButton
        '
        Me.RegistrationButton.BackColor = System.Drawing.Color.WhiteSmoke
        Me.RegistrationButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RegistrationButton.Location = New System.Drawing.Point(236, 757)
        Me.RegistrationButton.Margin = New System.Windows.Forms.Padding(9)
        Me.RegistrationButton.Name = "RegistrationButton"
        Me.RegistrationButton.Size = New System.Drawing.Size(459, 92)
        Me.RegistrationButton.TabIndex = 15
        Me.RegistrationButton.Text = "View Subject Registration"
        Me.RegistrationButton.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(52, 208)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(708, 33)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Click on student matric number to enable more option"
        '
        'StudentListForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SeaShell
        Me.ClientSize = New System.Drawing.Size(2055, 1040)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.RegistrationButton)
        Me.Controls.Add(Me.Search)
        Me.Controls.Add(Me.updateStudentButton)
        Me.Controls.Add(Me.AddStudentButton)
        Me.Controls.Add(Me.DeleteStudentButton)
        Me.Controls.Add(Me.StudentDataGridView)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "StudentListForm"
        Me.Text = "StudentListForm"
        CType(Me.StudentDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Search.ResumeLayout(False)
        Me.Search.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents updateStudentButton As Button
    Friend WithEvents AddStudentButton As Button
    Friend WithEvents DeleteStudentButton As Button
    Friend WithEvents StudentDataGridView As DataGridView
    Friend WithEvents Search As GroupBox
    Friend WithEvents nameButton As Button
    Friend WithEvents ICButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents searchTextBox As TextBox
    Friend WithEvents displayAllButton As Button
    Friend WithEvents RegistrationButton As Button
    Friend WithEvents Label2 As Label
End Class
