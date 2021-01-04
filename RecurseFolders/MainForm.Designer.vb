<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.TraverseButton = New System.Windows.Forms.Button()
        Me.CancelButton = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ExcludeListBox = New System.Windows.Forms.ListBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.IncludedListBox = New System.Windows.Forms.ListBox()
        Me.FolderTextBox = New System.Windows.Forms.TextBox()
        Me.SelectFolderButton = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.ExceptionsListBox = New System.Windows.Forms.ListBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'TraverseButton
        '
        Me.TraverseButton.Location = New System.Drawing.Point(12, 26)
        Me.TraverseButton.Name = "TraverseButton"
        Me.TraverseButton.Size = New System.Drawing.Size(75, 23)
        Me.TraverseButton.TabIndex = 0
        Me.TraverseButton.Text = "Traverse"
        Me.TraverseButton.UseVisualStyleBackColor = True
        '
        'CancelButton
        '
        Me.CancelButton.Location = New System.Drawing.Point(93, 26)
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.Size = New System.Drawing.Size(75, 23)
        Me.CancelButton.TabIndex = 1
        Me.CancelButton.Text = "Cancel"
        Me.CancelButton.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ExcludeListBox)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 98)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(583, 159)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Excluded"
        '
        'ExcludeListBox
        '
        Me.ExcludeListBox.FormattingEnabled = True
        Me.ExcludeListBox.ItemHeight = 15
        Me.ExcludeListBox.Location = New System.Drawing.Point(6, 22)
        Me.ExcludeListBox.Name = "ExcludeListBox"
        Me.ExcludeListBox.Size = New System.Drawing.Size(571, 124)
        Me.ExcludeListBox.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.IncludedListBox)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 263)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(583, 159)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Included"
        '
        'IncludedListBox
        '
        Me.IncludedListBox.FormattingEnabled = True
        Me.IncludedListBox.ItemHeight = 15
        Me.IncludedListBox.Location = New System.Drawing.Point(6, 22)
        Me.IncludedListBox.Name = "IncludedListBox"
        Me.IncludedListBox.Size = New System.Drawing.Size(571, 124)
        Me.IncludedListBox.TabIndex = 0
        '
        'FolderTextBox
        '
        Me.FolderTextBox.Location = New System.Drawing.Point(14, 66)
        Me.FolderTextBox.Name = "FolderTextBox"
        Me.FolderTextBox.Size = New System.Drawing.Size(518, 23)
        Me.FolderTextBox.TabIndex = 4
        '
        'SelectFolderButton
        '
        Me.SelectFolderButton.Image = CType(resources.GetObject("SelectFolderButton.Image"), System.Drawing.Image)
        Me.SelectFolderButton.Location = New System.Drawing.Point(538, 66)
        Me.SelectFolderButton.Name = "SelectFolderButton"
        Me.SelectFolderButton.Size = New System.Drawing.Size(56, 23)
        Me.SelectFolderButton.TabIndex = 5
        Me.SelectFolderButton.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.ExceptionsListBox)
        Me.GroupBox3.Location = New System.Drawing.Point(14, 446)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(583, 159)
        Me.GroupBox3.TabIndex = 6
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Exceptions"
        '
        'ExceptionsListBox
        '
        Me.ExceptionsListBox.FormattingEnabled = True
        Me.ExceptionsListBox.ItemHeight = 15
        Me.ExceptionsListBox.Location = New System.Drawing.Point(6, 22)
        Me.ExceptionsListBox.Name = "ExceptionsListBox"
        Me.ExceptionsListBox.Size = New System.Drawing.Size(571, 124)
        Me.ExceptionsListBox.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(608, 617)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.SelectFolderButton)
        Me.Controls.Add(Me.FolderTextBox)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.CancelButton)
        Me.Controls.Add(Me.TraverseButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Traverse"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TraverseButton As Button
    Friend WithEvents CancelButton As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ExcludeListBox As ListBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents IncludedListBox As ListBox
    Friend WithEvents FolderTextBox As TextBox
    Friend WithEvents SelectFolderButton As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents ExceptionsListBox As ListBox
End Class
