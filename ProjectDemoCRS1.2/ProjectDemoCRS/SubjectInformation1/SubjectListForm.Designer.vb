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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
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
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1260, 679)
        Me.Panel1.TabIndex = 0
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.SystemColors.Control
        Me.Panel5.Controls.Add(Me.ViewAllButton)
        Me.Panel5.Controls.Add(Me.SearchByNameButton)
        Me.Panel5.Controls.Add(Me.SearchByCodeButton)
        Me.Panel5.Controls.Add(Me.ClearButton)
        Me.Panel5.Controls.Add(Me.DeleteButton)
        Me.Panel5.Controls.Add(Me.UpdateButton)
        Me.Panel5.Controls.Add(Me.AddButton)
        Me.Panel5.Location = New System.Drawing.Point(902, 177)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(342, 488)
        Me.Panel5.TabIndex = 0
        '
        'ViewAllButton
        '
        Me.ViewAllButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ViewAllButton.Location = New System.Drawing.Point(15, 422)
        Me.ViewAllButton.Name = "ViewAllButton"
        Me.ViewAllButton.Size = New System.Drawing.Size(314, 62)
        Me.ViewAllButton.TabIndex = 0
        Me.ViewAllButton.Text = "View All"
        Me.ViewAllButton.UseVisualStyleBackColor = True
        '
        'SearchByNameButton
        '
        Me.SearchByNameButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchByNameButton.Location = New System.Drawing.Point(15, 354)
        Me.SearchByNameButton.Name = "SearchByNameButton"
        Me.SearchByNameButton.Size = New System.Drawing.Size(314, 62)
        Me.SearchByNameButton.TabIndex = 0
        Me.SearchByNameButton.Text = "Search 2"
        Me.SearchByNameButton.UseVisualStyleBackColor = True
        '
        'SearchByCodeButton
        '
        Me.SearchByCodeButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchByCodeButton.Location = New System.Drawing.Point(15, 286)
        Me.SearchByCodeButton.Name = "SearchByCodeButton"
        Me.SearchByCodeButton.Size = New System.Drawing.Size(314, 62)
        Me.SearchByCodeButton.TabIndex = 0
        Me.SearchByCodeButton.Text = "Search 1"
        Me.SearchByCodeButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClearButton.Location = New System.Drawing.Point(15, 218)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(314, 62)
        Me.ClearButton.TabIndex = 0
        Me.ClearButton.Text = "Clear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'DeleteButton
        '
        Me.DeleteButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteButton.Location = New System.Drawing.Point(15, 150)
        Me.DeleteButton.Name = "DeleteButton"
        Me.DeleteButton.Size = New System.Drawing.Size(314, 62)
        Me.DeleteButton.TabIndex = 0
        Me.DeleteButton.Text = "Delete"
        Me.DeleteButton.UseVisualStyleBackColor = True
        '
        'UpdateButton
        '
        Me.UpdateButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UpdateButton.Location = New System.Drawing.Point(15, 82)
        Me.UpdateButton.Name = "UpdateButton"
        Me.UpdateButton.Size = New System.Drawing.Size(314, 62)
        Me.UpdateButton.TabIndex = 0
        Me.UpdateButton.Text = "Update"
        Me.UpdateButton.UseVisualStyleBackColor = True
        '
        'AddButton
        '
        Me.AddButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddButton.Location = New System.Drawing.Point(15, 14)
        Me.AddButton.Name = "AddButton"
        Me.AddButton.Size = New System.Drawing.Size(314, 62)
        Me.AddButton.TabIndex = 0
        Me.AddButton.Text = "Add"
        Me.AddButton.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.Control
        Me.Panel4.Controls.Add(Me.SearchTextBox)
        Me.Panel4.Location = New System.Drawing.Point(902, 98)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(342, 73)
        Me.Panel4.TabIndex = 0
        '
        'SearchTextBox
        '
        Me.SearchTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchTextBox.Location = New System.Drawing.Point(15, 8)
        Me.SearchTextBox.Name = "SearchTextBox"
        Me.SearchTextBox.Size = New System.Drawing.Size(314, 62)
        Me.SearchTextBox.TabIndex = 2
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.Control
        Me.Panel3.Controls.Add(Me.CreditTextBox)
        Me.Panel3.Controls.Add(Me.SubjectNameTextBox)
        Me.Panel3.Controls.Add(Me.SubjectCodeTextBox)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.SubjectCodeLabel)
        Me.Panel3.Controls.Add(Me.SubjectListDataGridView)
        Me.Panel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel3.Location = New System.Drawing.Point(14, 98)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(882, 567)
        Me.Panel3.TabIndex = 0
        '
        'CreditTextBox
        '
        Me.CreditTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CreditTextBox.Location = New System.Drawing.Point(393, 204)
        Me.CreditTextBox.Name = "CreditTextBox"
        Me.CreditTextBox.Size = New System.Drawing.Size(467, 62)
        Me.CreditTextBox.TabIndex = 2
        '
        'SubjectNameTextBox
        '
        Me.SubjectNameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SubjectNameTextBox.Location = New System.Drawing.Point(393, 109)
        Me.SubjectNameTextBox.Name = "SubjectNameTextBox"
        Me.SubjectNameTextBox.Size = New System.Drawing.Size(467, 62)
        Me.SubjectNameTextBox.TabIndex = 2
        '
        'SubjectCodeTextBox
        '
        Me.SubjectCodeTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SubjectCodeTextBox.Location = New System.Drawing.Point(393, 16)
        Me.SubjectCodeTextBox.Name = "SubjectCodeTextBox"
        Me.SubjectCodeTextBox.Size = New System.Drawing.Size(467, 62)
        Me.SubjectCodeTextBox.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(17, 211)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(152, 55)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Credit"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(17, 116)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(326, 55)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Subject Name"
        '
        'SubjectCodeLabel
        '
        Me.SubjectCodeLabel.AutoSize = True
        Me.SubjectCodeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SubjectCodeLabel.Location = New System.Drawing.Point(17, 23)
        Me.SubjectCodeLabel.Name = "SubjectCodeLabel"
        Me.SubjectCodeLabel.Size = New System.Drawing.Size(313, 55)
        Me.SubjectCodeLabel.TabIndex = 1
        Me.SubjectCodeLabel.Text = "Subject Code"
        '
        'SubjectListDataGridView
        '
        Me.SubjectListDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.SubjectListDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SubjectListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SubjectListDataGridView.Location = New System.Drawing.Point(14, 301)
        Me.SubjectListDataGridView.Name = "SubjectListDataGridView"
        Me.SubjectListDataGridView.Size = New System.Drawing.Size(855, 252)
        Me.SubjectListDataGridView.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Location = New System.Drawing.Point(14, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1230, 80)
        Me.Panel2.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(397, 11)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(456, 55)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Subject Information"
        '
        'SubjectListForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1284, 703)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "SubjectListForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
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
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents SubjectListDataGridView As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents SubjectCodeTextBox As TextBox
    Friend WithEvents SubjectCodeLabel As Label
    Friend WithEvents CreditTextBox As TextBox
    Friend WithEvents SubjectNameTextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents SearchByNameButton As Button
    Friend WithEvents SearchByCodeButton As Button
    Friend WithEvents ClearButton As Button
    Friend WithEvents DeleteButton As Button
    Friend WithEvents UpdateButton As Button
    Friend WithEvents AddButton As Button
    Friend WithEvents SearchTextBox As TextBox
    Friend WithEvents ViewAllButton As Button
End Class
