﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StudentSubjectListForm
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
        Me.StudentSubjectDataGridView = New System.Windows.Forms.DataGridView()
        CType(Me.StudentSubjectDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StudentSubjectDataGridView
        '
        Me.StudentSubjectDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.StudentSubjectDataGridView.Location = New System.Drawing.Point(91, 106)
        Me.StudentSubjectDataGridView.Name = "StudentSubjectDataGridView"
        Me.StudentSubjectDataGridView.Size = New System.Drawing.Size(298, 152)
        Me.StudentSubjectDataGridView.TabIndex = 0
        '
        'StudentSubjectListForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1427, 450)
        Me.Controls.Add(Me.StudentSubjectDataGridView)
        Me.Name = "StudentSubjectListForm"
        Me.Text = "StudentSubjectListForm"
        CType(Me.StudentSubjectDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents StudentSubjectDataGridView As DataGridView
End Class
