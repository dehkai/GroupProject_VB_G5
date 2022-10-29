<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class StudentGroupListForm
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
        Me.StudentGroupDataGridView = New System.Windows.Forms.DataGridView()
        Me.updateStudentGroupButton = New System.Windows.Forms.Button()
        Me.AddStudentGroupButton = New System.Windows.Forms.Button()
        Me.DeleteStudentGroupButton = New System.Windows.Forms.Button()
        CType(Me.StudentGroupDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StudentGroupDataGridView
        '
        Me.StudentGroupDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.StudentGroupDataGridView.Location = New System.Drawing.Point(28, 134)
        Me.StudentGroupDataGridView.MultiSelect = False
        Me.StudentGroupDataGridView.Name = "StudentGroupDataGridView"
        Me.StudentGroupDataGridView.Size = New System.Drawing.Size(1496, 338)
        Me.StudentGroupDataGridView.TabIndex = 0
        '
        'updateStudentGroupButton
        '
        Me.updateStudentGroupButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.updateStudentGroupButton.Location = New System.Drawing.Point(505, 481)
        Me.updateStudentGroupButton.Margin = New System.Windows.Forms.Padding(6)
        Me.updateStudentGroupButton.Name = "updateStudentGroupButton"
        Me.updateStudentGroupButton.Size = New System.Drawing.Size(209, 60)
        Me.updateStudentGroupButton.TabIndex = 8
        Me.updateStudentGroupButton.Text = "Update Class"
        Me.updateStudentGroupButton.UseVisualStyleBackColor = True
        '
        'AddStudentGroupButton
        '
        Me.AddStudentGroupButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddStudentGroupButton.Location = New System.Drawing.Point(284, 481)
        Me.AddStudentGroupButton.Margin = New System.Windows.Forms.Padding(6)
        Me.AddStudentGroupButton.Name = "AddStudentGroupButton"
        Me.AddStudentGroupButton.Size = New System.Drawing.Size(209, 60)
        Me.AddStudentGroupButton.TabIndex = 7
        Me.AddStudentGroupButton.Text = "Add New Class"
        Me.AddStudentGroupButton.UseVisualStyleBackColor = True
        '
        'DeleteStudentGroupButton
        '
        Me.DeleteStudentGroupButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteStudentGroupButton.Location = New System.Drawing.Point(743, 481)
        Me.DeleteStudentGroupButton.Margin = New System.Windows.Forms.Padding(6)
        Me.DeleteStudentGroupButton.Name = "DeleteStudentGroupButton"
        Me.DeleteStudentGroupButton.Size = New System.Drawing.Size(228, 60)
        Me.DeleteStudentGroupButton.TabIndex = 6
        Me.DeleteStudentGroupButton.Text = "Delete Class"
        Me.DeleteStudentGroupButton.UseVisualStyleBackColor = True
        '
        'StudentGroupListForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1370, 560)
        Me.Controls.Add(Me.updateStudentGroupButton)
        Me.Controls.Add(Me.AddStudentGroupButton)
        Me.Controls.Add(Me.DeleteStudentGroupButton)
        Me.Controls.Add(Me.StudentGroupDataGridView)
        Me.Name = "StudentGroupListForm"
        Me.Text = "StudentGroupForm"
        CType(Me.StudentGroupDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents StudentGroupDataGridView As DataGridView
    Friend WithEvents updateStudentGroupButton As Button
    Friend WithEvents AddStudentGroupButton As Button
    Friend WithEvents DeleteStudentGroupButton As Button
End Class
