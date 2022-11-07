<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserListForm
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
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.ResetPasswordButton = New System.Windows.Forms.Button()
        Me.DeleteUserButton = New System.Windows.Forms.Button()
        Me.AddUserButton = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.UserLevelTextBox = New System.Windows.Forms.TextBox()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.UsernameTextBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.UserListDataGridView = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.UserListDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Coral
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Panel1.Location = New System.Drawing.Point(13, 13)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1259, 636)
        Me.Panel1.TabIndex = 0
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.Control
        Me.Panel4.Controls.Add(Me.ClearButton)
        Me.Panel4.Controls.Add(Me.ResetPasswordButton)
        Me.Panel4.Controls.Add(Me.DeleteUserButton)
        Me.Panel4.Controls.Add(Me.AddUserButton)
        Me.Panel4.Location = New System.Drawing.Point(922, 98)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(320, 525)
        Me.Panel4.TabIndex = 0
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(13, 402)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(293, 108)
        Me.ClearButton.TabIndex = 0
        Me.ClearButton.Text = "Clear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'ResetPasswordButton
        '
        Me.ResetPasswordButton.Location = New System.Drawing.Point(13, 276)
        Me.ResetPasswordButton.Name = "ResetPasswordButton"
        Me.ResetPasswordButton.Size = New System.Drawing.Size(293, 108)
        Me.ResetPasswordButton.TabIndex = 0
        Me.ResetPasswordButton.Text = "Update"
        Me.ResetPasswordButton.UseVisualStyleBackColor = True
        '
        'DeleteUserButton
        '
        Me.DeleteUserButton.Location = New System.Drawing.Point(13, 147)
        Me.DeleteUserButton.Name = "DeleteUserButton"
        Me.DeleteUserButton.Size = New System.Drawing.Size(293, 108)
        Me.DeleteUserButton.TabIndex = 0
        Me.DeleteUserButton.Text = "Delete User"
        Me.DeleteUserButton.UseVisualStyleBackColor = True
        '
        'AddUserButton
        '
        Me.AddUserButton.Location = New System.Drawing.Point(13, 13)
        Me.AddUserButton.Name = "AddUserButton"
        Me.AddUserButton.Size = New System.Drawing.Size(293, 108)
        Me.AddUserButton.TabIndex = 0
        Me.AddUserButton.Text = "Add User"
        Me.AddUserButton.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.Control
        Me.Panel3.Controls.Add(Me.UserLevelTextBox)
        Me.Panel3.Controls.Add(Me.PasswordTextBox)
        Me.Panel3.Controls.Add(Me.UsernameTextBox)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.UserListDataGridView)
        Me.Panel3.Location = New System.Drawing.Point(15, 98)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(901, 525)
        Me.Panel3.TabIndex = 0
        '
        'UserLevelTextBox
        '
        Me.UserLevelTextBox.Location = New System.Drawing.Point(302, 171)
        Me.UserLevelTextBox.Name = "UserLevelTextBox"
        Me.UserLevelTextBox.Size = New System.Drawing.Size(585, 62)
        Me.UserLevelTextBox.TabIndex = 1
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.Location = New System.Drawing.Point(302, 90)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PasswordTextBox.Size = New System.Drawing.Size(585, 62)
        Me.PasswordTextBox.TabIndex = 1
        '
        'UsernameTextBox
        '
        Me.UsernameTextBox.Location = New System.Drawing.Point(302, 13)
        Me.UsernameTextBox.Name = "UsernameTextBox"
        Me.UsernameTextBox.Size = New System.Drawing.Size(585, 62)
        Me.UsernameTextBox.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 178)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(254, 55)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "User Level"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 97)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(236, 55)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Password"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(255, 55)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "UserName"
        '
        'UserListDataGridView
        '
        Me.UserListDataGridView.BackgroundColor = System.Drawing.SystemColors.Control
        Me.UserListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.UserListDataGridView.Location = New System.Drawing.Point(13, 276)
        Me.UserListDataGridView.Name = "UserListDataGridView"
        Me.UserListDataGridView.Size = New System.Drawing.Size(874, 234)
        Me.UserListDataGridView.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(15, 15)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1227, 77)
        Me.Panel2.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(509, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(213, 55)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "User List"
        '
        'UserListForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1284, 661)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "UserListForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "User List"
        Me.Panel1.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.UserListDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents UserLevelTextBox As TextBox
    Friend WithEvents PasswordTextBox As TextBox
    Friend WithEvents UsernameTextBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents UserListDataGridView As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents ClearButton As Button
    Friend WithEvents ResetPasswordButton As Button
    Friend WithEvents DeleteUserButton As Button
    Friend WithEvents AddUserButton As Button
End Class
