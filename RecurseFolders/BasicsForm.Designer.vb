<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BasicsForm
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
        Me.GetFilesConventionalButton = New System.Windows.Forms.Button()
        Me.GetFilesConventionalTaskButton = New System.Windows.Forms.Button()
        Me.CrossThreadViolationButton = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.CrossThreadFixButton = New System.Windows.Forms.Button()
        Me.IntermediateGetFilesButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'GetFilesConventionalButton
        '
        Me.GetFilesConventionalButton.Location = New System.Drawing.Point(23, 23)
        Me.GetFilesConventionalButton.Name = "GetFilesConventionalButton"
        Me.GetFilesConventionalButton.Size = New System.Drawing.Size(198, 23)
        Me.GetFilesConventionalButton.TabIndex = 0
        Me.GetFilesConventionalButton.Text = "GetFiles conventional"
        Me.GetFilesConventionalButton.UseVisualStyleBackColor = True
        '
        'GetFilesConventionalTaskButton
        '
        Me.GetFilesConventionalTaskButton.Location = New System.Drawing.Point(23, 52)
        Me.GetFilesConventionalTaskButton.Name = "GetFilesConventionalTaskButton"
        Me.GetFilesConventionalTaskButton.Size = New System.Drawing.Size(198, 23)
        Me.GetFilesConventionalTaskButton.TabIndex = 1
        Me.GetFilesConventionalTaskButton.Text = "GetFiles conventional Task"
        Me.GetFilesConventionalTaskButton.UseVisualStyleBackColor = True
        '
        'CrossThreadViolationButton
        '
        Me.CrossThreadViolationButton.Location = New System.Drawing.Point(23, 81)
        Me.CrossThreadViolationButton.Name = "CrossThreadViolationButton"
        Me.CrossThreadViolationButton.Size = New System.Drawing.Size(198, 23)
        Me.CrossThreadViolationButton.TabIndex = 2
        Me.CrossThreadViolationButton.Text = "Cross thread issue"
        Me.CrossThreadViolationButton.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 15
        Me.ListBox1.Location = New System.Drawing.Point(23, 158)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(200, 154)
        Me.ListBox1.TabIndex = 3
        '
        'CrossThreadFixButton
        '
        Me.CrossThreadFixButton.Location = New System.Drawing.Point(23, 110)
        Me.CrossThreadFixButton.Name = "CrossThreadFixButton"
        Me.CrossThreadFixButton.Size = New System.Drawing.Size(198, 23)
        Me.CrossThreadFixButton.TabIndex = 4
        Me.CrossThreadFixButton.Text = "Cross thread fix"
        Me.CrossThreadFixButton.UseVisualStyleBackColor = True
        '
        'IntermediateGetFilesButton
        '
        Me.IntermediateGetFilesButton.Location = New System.Drawing.Point(23, 327)
        Me.IntermediateGetFilesButton.Name = "IntermediateGetFilesButton"
        Me.IntermediateGetFilesButton.Size = New System.Drawing.Size(198, 23)
        Me.IntermediateGetFilesButton.TabIndex = 5
        Me.IntermediateGetFilesButton.Text = "Intermediate get files"
        Me.IntermediateGetFilesButton.UseVisualStyleBackColor = True
        '
        'BasicsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(257, 369)
        Me.Controls.Add(Me.IntermediateGetFilesButton)
        Me.Controls.Add(Me.CrossThreadFixButton)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.CrossThreadViolationButton)
        Me.Controls.Add(Me.GetFilesConventionalTaskButton)
        Me.Controls.Add(Me.GetFilesConventionalButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "BasicsForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Basics"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GetFilesConventionalButton As Button
    Friend WithEvents GetFilesConventionalTaskButton As Button
    Friend WithEvents CrossThreadViolationButton As Button
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents CrossThreadFixButton As Button
    Friend WithEvents IntermediateGetFilesButton As Button
End Class
