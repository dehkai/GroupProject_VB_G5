<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SubjectListForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SubjectListForm))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.ViewStudentListButton = New System.Windows.Forms.Button()
        Me.ViewAllButton = New System.Windows.Forms.Button()
        Me.SearchByNameButton = New System.Windows.Forms.Button()
        Me.SearchByCodeButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.DeleteButton = New System.Windows.Forms.Button()
        Me.UpdateButton = New System.Windows.Forms.Button()
        Me.AddButton = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.SearchTextBox = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.CreditTextBox = New System.Windows.Forms.TextBox()
        Me.SubjectNameTextBox = New System.Windows.Forms.TextBox()
        Me.SubjectCodeTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SubjectCodeLabel = New System.Windows.Forms.Label()
        Me.SubjectListDataGridView = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.SubjectListDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.CadetBlue
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(18, 18)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1890, 1154)
        Me.Panel1.TabIndex = 1
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Azure
        Me.Panel5.Controls.Add(Me.ViewStudentListButton)
        Me.Panel5.Controls.Add(Me.ViewAllButton)
        Me.Panel5.Controls.Add(Me.SearchByNameButton)
        Me.Panel5.Controls.Add(Me.SearchByCodeButton)
        Me.Panel5.Controls.Add(Me.ClearButton)
        Me.Panel5.Controls.Add(Me.DeleteButton)
        Me.Panel5.Controls.Add(Me.UpdateButton)
        Me.Panel5.Controls.Add(Me.AddButton)
        Me.Panel5.Location = New System.Drawing.Point(1353, 272)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(513, 858)
        Me.Panel5.TabIndex = 0
        '
        'ViewStudentListButton
        '
        Me.ViewStudentListButton.BackColor = System.Drawing.Color.LavenderBlush
        Me.ViewStudentListButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ViewStudentListButton.Location = New System.Drawing.Point(22, 12)
        Me.ViewStudentListButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ViewStudentListButton.Name = "ViewStudentListButton"
        Me.ViewStudentListButton.Size = New System.Drawing.Size(471, 95)
        Me.ViewStudentListButton.TabIndex = 1
        Me.ViewStudentListButton.Text = "View Student List"
        Me.ViewStudentListButton.UseVisualStyleBackColor = False
        '
        'ViewAllButton
        '
        Me.ViewAllButton.BackColor = System.Drawing.Color.LavenderBlush
        Me.ViewAllButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ViewAllButton.Location = New System.Drawing.Point(22, 745)
        Me.ViewAllButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ViewAllButton.Name = "ViewAllButton"
        Me.ViewAllButton.Size = New System.Drawing.Size(471, 95)
        Me.ViewAllButton.TabIndex = 0
        Me.ViewAllButton.Text = "View All"
        Me.ViewAllButton.UseVisualStyleBackColor = False
        '
        'SearchByNameButton
        '
        Me.SearchByNameButton.BackColor = System.Drawing.Color.LavenderBlush
        Me.SearchByNameButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchByNameButton.Location = New System.Drawing.Point(22, 640)
        Me.SearchByNameButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.SearchByNameButton.Name = "SearchByNameButton"
        Me.SearchByNameButton.Size = New System.Drawing.Size(471, 95)
        Me.SearchByNameButton.TabIndex = 0
        Me.SearchByNameButton.Text = "Search 2"
        Me.SearchByNameButton.UseVisualStyleBackColor = False
        '
        'SearchByCodeButton
        '
        Me.SearchByCodeButton.BackColor = System.Drawing.Color.LavenderBlush
        Me.SearchByCodeButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchByCodeButton.Location = New System.Drawing.Point(22, 535)
        Me.SearchByCodeButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.SearchByCodeButton.Name = "SearchByCodeButton"
        Me.SearchByCodeButton.Size = New System.Drawing.Size(471, 95)
        Me.SearchByCodeButton.TabIndex = 0
        Me.SearchByCodeButton.Text = "Search 1"
        Me.SearchByCodeButton.UseVisualStyleBackColor = False
        '
        'ClearButton
        '
        Me.ClearButton.BackColor = System.Drawing.Color.LavenderBlush
        Me.ClearButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClearButton.Location = New System.Drawing.Point(22, 431)
        Me.ClearButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(471, 95)
        Me.ClearButton.TabIndex = 0
        Me.ClearButton.Text = "Clear"
        Me.ClearButton.UseVisualStyleBackColor = False
        '
        'DeleteButton
        '
        Me.DeleteButton.BackColor = System.Drawing.Color.LavenderBlush
        Me.DeleteButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteButton.Location = New System.Drawing.Point(22, 326)
        Me.DeleteButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DeleteButton.Name = "DeleteButton"
        Me.DeleteButton.Size = New System.Drawing.Size(471, 95)
        Me.DeleteButton.TabIndex = 0
        Me.DeleteButton.Text = "Delete"
        Me.DeleteButton.UseVisualStyleBackColor = False
        '
        'UpdateButton
        '
        Me.UpdateButton.BackColor = System.Drawing.Color.LavenderBlush
        Me.UpdateButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UpdateButton.Location = New System.Drawing.Point(22, 222)
        Me.UpdateButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.UpdateButton.Name = "UpdateButton"
        Me.UpdateButton.Size = New System.Drawing.Size(471, 95)
        Me.UpdateButton.TabIndex = 0
        Me.UpdateButton.Text = "Update"
        Me.UpdateButton.UseVisualStyleBackColor = False
        '
        'AddButton
        '
        Me.AddButton.BackColor = System.Drawing.Color.LavenderBlush
        Me.AddButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddButton.Location = New System.Drawing.Point(22, 117)
        Me.AddButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.AddButton.Name = "AddButton"
        Me.AddButton.Size = New System.Drawing.Size(471, 95)
        Me.AddButton.TabIndex = 0
        Me.AddButton.Text = "Add"
        Me.AddButton.UseVisualStyleBackColor = False
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Azure
        Me.Panel4.Controls.Add(Me.SearchTextBox)
        Me.Panel4.Location = New System.Drawing.Point(1353, 151)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(513, 112)
        Me.Panel4.TabIndex = 0
        '
        'SearchTextBox
        '
        Me.SearchTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchTextBox.Location = New System.Drawing.Point(22, 12)
        Me.SearchTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.SearchTextBox.Name = "SearchTextBox"
        Me.SearchTextBox.Size = New System.Drawing.Size(469, 89)
        Me.SearchTextBox.TabIndex = 2
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Azure
        Me.Panel3.Controls.Add(Me.CreditTextBox)
        Me.Panel3.Controls.Add(Me.SubjectNameTextBox)
        Me.Panel3.Controls.Add(Me.SubjectCodeTextBox)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.SubjectCodeLabel)
        Me.Panel3.Controls.Add(Me.SubjectListDataGridView)
        Me.Panel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel3.Location = New System.Drawing.Point(21, 151)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1323, 980)
        Me.Panel3.TabIndex = 0
        '
        'CreditTextBox
        '
        Me.CreditTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CreditTextBox.Location = New System.Drawing.Point(590, 314)
        Me.CreditTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CreditTextBox.Name = "CreditTextBox"
        Me.CreditTextBox.Size = New System.Drawing.Size(698, 89)
        Me.CreditTextBox.TabIndex = 2
        '
        'SubjectNameTextBox
        '
        Me.SubjectNameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SubjectNameTextBox.Location = New System.Drawing.Point(590, 168)
        Me.SubjectNameTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.SubjectNameTextBox.Name = "SubjectNameTextBox"
        Me.SubjectNameTextBox.Size = New System.Drawing.Size(698, 89)
        Me.SubjectNameTextBox.TabIndex = 2
        '
        'SubjectCodeTextBox
        '
        Me.SubjectCodeTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SubjectCodeTextBox.Location = New System.Drawing.Point(590, 25)
        Me.SubjectCodeTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.SubjectCodeTextBox.Name = "SubjectCodeTextBox"
        Me.SubjectCodeTextBox.Size = New System.Drawing.Size(698, 89)
        Me.SubjectCodeTextBox.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(26, 325)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(228, 82)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Credit"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(26, 178)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(487, 82)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Subject Name"
        '
        'SubjectCodeLabel
        '
        Me.SubjectCodeLabel.AutoSize = True
        Me.SubjectCodeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SubjectCodeLabel.Location = New System.Drawing.Point(26, 35)
        Me.SubjectCodeLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.SubjectCodeLabel.Name = "SubjectCodeLabel"
        Me.SubjectCodeLabel.Size = New System.Drawing.Size(467, 82)
        Me.SubjectCodeLabel.TabIndex = 1
        Me.SubjectCodeLabel.Text = "Subject Code"
        '
        'SubjectListDataGridView
        '
        Me.SubjectListDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.SubjectListDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SubjectListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SubjectListDataGridView.Location = New System.Drawing.Point(21, 463)
        Me.SubjectListDataGridView.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.SubjectListDataGridView.Name = "SubjectListDataGridView"
        Me.SubjectListDataGridView.RowHeadersWidth = 62
        Me.SubjectListDataGridView.Size = New System.Drawing.Size(1282, 495)
        Me.SubjectListDataGridView.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Azure
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Location = New System.Drawing.Point(21, 18)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1845, 123)
        Me.Panel2.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(596, 17)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(675, 82)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Subject Information"
        '
        'SubjectListForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1926, 1191)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "SubjectListForm"
        Me.Text = "Subject List"
        Me.Panel1.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.SubjectListDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents ViewAllButton As Button
    Friend WithEvents SearchByNameButton As Button
    Friend WithEvents SearchByCodeButton As Button
    Friend WithEvents ClearButton As Button
    Friend WithEvents DeleteButton As Button
    Friend WithEvents UpdateButton As Button
    Friend WithEvents AddButton As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents SearchTextBox As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents CreditTextBox As TextBox
    Friend WithEvents SubjectNameTextBox As TextBox
    Friend WithEvents SubjectCodeTextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents SubjectCodeLabel As Label
    Friend WithEvents SubjectListDataGridView As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents ViewStudentListButton As Button
End Class
