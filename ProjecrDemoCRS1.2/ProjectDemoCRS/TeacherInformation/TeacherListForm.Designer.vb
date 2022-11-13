<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TeacherListForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TeacherListForm))
        Me.Search = New System.Windows.Forms.GroupBox()
        Me.displayAllButton = New System.Windows.Forms.Button()
        Me.nameButton = New System.Windows.Forms.Button()
        Me.ICButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.searchTextBox = New System.Windows.Forms.TextBox()
        Me.AddTeacherButton = New System.Windows.Forms.Button()
        Me.updateTeacherButton = New System.Windows.Forms.Button()
        Me.DeleteTeacherButton = New System.Windows.Forms.Button()
        Me.TeacherDataGridView = New System.Windows.Forms.DataGridView()
        Me.Search.SuspendLayout()
        CType(Me.TeacherDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Search
        '
        Me.Search.BackColor = System.Drawing.Color.Transparent
        Me.Search.Controls.Add(Me.displayAllButton)
        Me.Search.Controls.Add(Me.nameButton)
        Me.Search.Controls.Add(Me.ICButton)
        Me.Search.Controls.Add(Me.Label1)
        Me.Search.Controls.Add(Me.searchTextBox)
        Me.Search.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Search.Location = New System.Drawing.Point(185, 86)
        Me.Search.Name = "Search"
        Me.Search.Size = New System.Drawing.Size(1037, 82)
        Me.Search.TabIndex = 33
        Me.Search.TabStop = False
        Me.Search.Text = "Search"
        '
        'displayAllButton
        '
        Me.displayAllButton.BackColor = System.Drawing.Color.Lavender
        Me.displayAllButton.Location = New System.Drawing.Point(849, 40)
        Me.displayAllButton.Name = "displayAllButton"
        Me.displayAllButton.Size = New System.Drawing.Size(124, 31)
        Me.displayAllButton.TabIndex = 4
        Me.displayAllButton.Text = "Display All"
        Me.displayAllButton.UseVisualStyleBackColor = False
        '
        'nameButton
        '
        Me.nameButton.BackColor = System.Drawing.Color.Lavender
        Me.nameButton.Location = New System.Drawing.Point(699, 37)
        Me.nameButton.Name = "nameButton"
        Me.nameButton.Size = New System.Drawing.Size(124, 34)
        Me.nameButton.TabIndex = 3
        Me.nameButton.Text = "By Name"
        Me.nameButton.UseVisualStyleBackColor = False
        '
        'ICButton
        '
        Me.ICButton.BackColor = System.Drawing.Color.Lavender
        Me.ICButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ICButton.Location = New System.Drawing.Point(539, 40)
        Me.ICButton.Name = "ICButton"
        Me.ICButton.Size = New System.Drawing.Size(124, 31)
        Me.ICButton.TabIndex = 2
        Me.ICButton.Text = "By IC"
        Me.ICButton.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(99, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "IC / Name"
        '
        'searchTextBox
        '
        Me.searchTextBox.Location = New System.Drawing.Point(220, 40)
        Me.searchTextBox.Name = "searchTextBox"
        Me.searchTextBox.Size = New System.Drawing.Size(295, 31)
        Me.searchTextBox.TabIndex = 0
        '
        'AddTeacherButton
        '
        Me.AddTeacherButton.BackColor = System.Drawing.Color.Lavender
        Me.AddTeacherButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddTeacherButton.Location = New System.Drawing.Point(306, 538)
        Me.AddTeacherButton.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.AddTeacherButton.Name = "AddTeacherButton"
        Me.AddTeacherButton.Size = New System.Drawing.Size(209, 60)
        Me.AddTeacherButton.TabIndex = 34
        Me.AddTeacherButton.Text = "Add Teacher"
        Me.AddTeacherButton.UseVisualStyleBackColor = False
        '
        'updateTeacherButton
        '
        Me.updateTeacherButton.BackColor = System.Drawing.Color.Lavender
        Me.updateTeacherButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.updateTeacherButton.Location = New System.Drawing.Point(527, 538)
        Me.updateTeacherButton.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.updateTeacherButton.Name = "updateTeacherButton"
        Me.updateTeacherButton.Size = New System.Drawing.Size(209, 60)
        Me.updateTeacherButton.TabIndex = 32
        Me.updateTeacherButton.Text = "Update Teacher"
        Me.updateTeacherButton.UseVisualStyleBackColor = False
        '
        'DeleteTeacherButton
        '
        Me.DeleteTeacherButton.BackColor = System.Drawing.Color.Lavender
        Me.DeleteTeacherButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteTeacherButton.Location = New System.Drawing.Point(747, 538)
        Me.DeleteTeacherButton.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.DeleteTeacherButton.Name = "DeleteTeacherButton"
        Me.DeleteTeacherButton.Size = New System.Drawing.Size(228, 60)
        Me.DeleteTeacherButton.TabIndex = 31
        Me.DeleteTeacherButton.Text = "Delete Teacher"
        Me.DeleteTeacherButton.UseVisualStyleBackColor = False
        '
        'TeacherDataGridView
        '
        Me.TeacherDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.TeacherDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TeacherDataGridView.Location = New System.Drawing.Point(143, 174)
        Me.TeacherDataGridView.MultiSelect = False
        Me.TeacherDataGridView.Name = "TeacherDataGridView"
        Me.TeacherDataGridView.RowHeadersWidth = 62
        Me.TeacherDataGridView.Size = New System.Drawing.Size(1103, 338)
        Me.TeacherDataGridView.TabIndex = 30
        '
        'TeacherListForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.SeaShell
        Me.ClientSize = New System.Drawing.Size(1349, 682)
        Me.Controls.Add(Me.Search)
        Me.Controls.Add(Me.AddTeacherButton)
        Me.Controls.Add(Me.updateTeacherButton)
        Me.Controls.Add(Me.DeleteTeacherButton)
        Me.Controls.Add(Me.TeacherDataGridView)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "TeacherListForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Teacher List Form"
        Me.Search.ResumeLayout(False)
        Me.Search.PerformLayout()
        CType(Me.TeacherDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Search As GroupBox
    Friend WithEvents displayAllButton As Button
    Friend WithEvents nameButton As Button
    Friend WithEvents ICButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents searchTextBox As TextBox
    Friend WithEvents AddTeacherButton As Button
    Friend WithEvents updateTeacherButton As Button
    Friend WithEvents DeleteTeacherButton As Button
    Friend WithEvents TeacherDataGridView As DataGridView
End Class
