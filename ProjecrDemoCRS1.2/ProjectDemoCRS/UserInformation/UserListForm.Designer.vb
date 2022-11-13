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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserListForm))
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
        Me.Panel1.Location = New System.Drawing.Point(20, 20)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1888, 978)
        Me.Panel1.TabIndex = 0
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.Info
        Me.Panel4.Controls.Add(Me.ClearButton)
        Me.Panel4.Controls.Add(Me.ResetPasswordButton)
        Me.Panel4.Controls.Add(Me.DeleteUserButton)
        Me.Panel4.Controls.Add(Me.AddUserButton)
        Me.Panel4.Location = New System.Drawing.Point(1383, 151)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(480, 808)
        Me.Panel4.TabIndex = 0
        '
        'ClearButton
        '
        Me.ClearButton.BackColor = System.Drawing.Color.MistyRose
        Me.ClearButton.Location = New System.Drawing.Point(20, 618)
        Me.ClearButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(440, 166)
        Me.ClearButton.TabIndex = 0
        Me.ClearButton.Text = "Clear"
        Me.ClearButton.UseVisualStyleBackColor = False
        '
        'ResetPasswordButton
        '
        Me.ResetPasswordButton.BackColor = System.Drawing.Color.MistyRose
        Me.ResetPasswordButton.Location = New System.Drawing.Point(20, 425)
        Me.ResetPasswordButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ResetPasswordButton.Name = "ResetPasswordButton"
        Me.ResetPasswordButton.Size = New System.Drawing.Size(440, 166)
        Me.ResetPasswordButton.TabIndex = 0
        Me.ResetPasswordButton.Text = "Update"
        Me.ResetPasswordButton.UseVisualStyleBackColor = False
        '
        'DeleteUserButton
        '
        Me.DeleteUserButton.BackColor = System.Drawing.Color.MistyRose
        Me.DeleteUserButton.Location = New System.Drawing.Point(20, 226)
        Me.DeleteUserButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DeleteUserButton.Name = "DeleteUserButton"
        Me.DeleteUserButton.Size = New System.Drawing.Size(440, 166)
        Me.DeleteUserButton.TabIndex = 0
        Me.DeleteUserButton.Text = "Delete User"
        Me.DeleteUserButton.UseVisualStyleBackColor = False
        '
        'AddUserButton
        '
        Me.AddUserButton.BackColor = System.Drawing.Color.MistyRose
        Me.AddUserButton.Location = New System.Drawing.Point(20, 20)
        Me.AddUserButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.AddUserButton.Name = "AddUserButton"
        Me.AddUserButton.Size = New System.Drawing.Size(440, 166)
        Me.AddUserButton.TabIndex = 0
        Me.AddUserButton.Text = "Add User"
        Me.AddUserButton.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.OldLace
        Me.Panel3.Controls.Add(Me.UserLevelTextBox)
        Me.Panel3.Controls.Add(Me.PasswordTextBox)
        Me.Panel3.Controls.Add(Me.UsernameTextBox)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.UserListDataGridView)
        Me.Panel3.Location = New System.Drawing.Point(22, 151)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1352, 808)
        Me.Panel3.TabIndex = 0
        '
        'UserLevelTextBox
        '
        Me.UserLevelTextBox.Location = New System.Drawing.Point(453, 263)
        Me.UserLevelTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.UserLevelTextBox.Name = "UserLevelTextBox"
        Me.UserLevelTextBox.Size = New System.Drawing.Size(876, 89)
        Me.UserLevelTextBox.TabIndex = 1
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.Location = New System.Drawing.Point(453, 138)
        Me.PasswordTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PasswordTextBox.Size = New System.Drawing.Size(876, 89)
        Me.PasswordTextBox.TabIndex = 1
        '
        'UsernameTextBox
        '
        Me.UsernameTextBox.Location = New System.Drawing.Point(453, 20)
        Me.UsernameTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.UsernameTextBox.Name = "UsernameTextBox"
        Me.UsernameTextBox.Size = New System.Drawing.Size(876, 89)
        Me.UsernameTextBox.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(26, 274)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(379, 82)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "User Level"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(26, 149)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(351, 82)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Password"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 31)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(379, 82)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "UserName"
        '
        'UserListDataGridView
        '
        Me.UserListDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.UserListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.UserListDataGridView.Location = New System.Drawing.Point(20, 425)
        Me.UserListDataGridView.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.UserListDataGridView.Name = "UserListDataGridView"
        Me.UserListDataGridView.RowHeadersWidth = 62
        Me.UserListDataGridView.Size = New System.Drawing.Size(1311, 360)
        Me.UserListDataGridView.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.OldLace
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(22, 23)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1840, 118)
        Me.Panel2.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(764, 15)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(319, 82)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "User List"
        '
        'UserListForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1926, 1017)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
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
