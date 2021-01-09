<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListViewForm
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ListViewForm))
        Me.FoldersListView = New System.Windows.Forms.ListView()
        Me.NameHeader = New System.Windows.Forms.ColumnHeader()
        Me.LocationHeader = New System.Windows.Forms.ColumnHeader()
        Me.ModifiedHeader = New System.Windows.Forms.ColumnHeader()
        Me.OpenFolderContextMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem6 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SelectFolderButton = New System.Windows.Forms.Button()
        Me.FolderTextBox = New System.Windows.Forms.TextBox()
        Me.FolderSelectionContextMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CancelButton = New System.Windows.Forms.Button()
        Me.TraverseButton = New System.Windows.Forms.Button()
        Me.ProcessingLabel = New System.Windows.Forms.Label()
        Me.ProcessedTitleLabel = New System.Windows.Forms.Label()
        Me.OpenFolderContextMenuStrip.SuspendLayout()
        Me.FolderSelectionContextMenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'FoldersListView
        '
        Me.FoldersListView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FoldersListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.NameHeader, Me.LocationHeader, Me.ModifiedHeader})
        Me.FoldersListView.ContextMenuStrip = Me.OpenFolderContextMenuStrip
        Me.FoldersListView.FullRowSelect = True
        Me.FoldersListView.HideSelection = False
        Me.FoldersListView.Location = New System.Drawing.Point(12, 71)
        Me.FoldersListView.MultiSelect = False
        Me.FoldersListView.Name = "FoldersListView"
        Me.FoldersListView.Size = New System.Drawing.Size(776, 348)
        Me.FoldersListView.TabIndex = 8
        Me.FoldersListView.UseCompatibleStateImageBehavior = False
        Me.FoldersListView.View = System.Windows.Forms.View.Details
        '
        'NameHeader
        '
        Me.NameHeader.Name = "NameHeader"
        Me.NameHeader.Text = "Location"
        Me.NameHeader.Width = 320
        '
        'LocationHeader
        '
        Me.LocationHeader.Name = "LocationHeader"
        Me.LocationHeader.Text = "Name"
        Me.LocationHeader.Width = 320
        '
        'ModifiedHeader
        '
        Me.ModifiedHeader.Name = "ModifiedHeader"
        Me.ModifiedHeader.Text = "Modified"
        Me.ModifiedHeader.Width = 100
        '
        'OpenFolderContextMenuStrip
        '
        Me.OpenFolderContextMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem6})
        Me.OpenFolderContextMenuStrip.Name = "OpenFolderContextMenuStrip"
        Me.OpenFolderContextMenuStrip.Size = New System.Drawing.Size(184, 26)
        Me.OpenFolderContextMenuStrip.Text = "Open folder"
        '
        'ToolStripMenuItem6
        '
        Me.ToolStripMenuItem6.Name = "ToolStripMenuItem6"
        Me.ToolStripMenuItem6.Size = New System.Drawing.Size(183, 22)
        Me.ToolStripMenuItem6.Text = "Open selected folder"
        '
        'SelectFolderButton
        '
        Me.SelectFolderButton.Image = CType(resources.GetObject("SelectFolderButton.Image"), System.Drawing.Image)
        Me.SelectFolderButton.Location = New System.Drawing.Point(536, 36)
        Me.SelectFolderButton.Name = "SelectFolderButton"
        Me.SelectFolderButton.Size = New System.Drawing.Size(56, 23)
        Me.SelectFolderButton.TabIndex = 12
        Me.SelectFolderButton.UseVisualStyleBackColor = True
        '
        'FolderTextBox
        '
        Me.FolderTextBox.ContextMenuStrip = Me.FolderSelectionContextMenuStrip
        Me.FolderTextBox.Location = New System.Drawing.Point(12, 37)
        Me.FolderTextBox.Name = "FolderTextBox"
        Me.FolderTextBox.Size = New System.Drawing.Size(518, 23)
        Me.FolderTextBox.TabIndex = 11
        '
        'FolderSelectionContextMenuStrip
        '
        Me.FolderSelectionContextMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem4, Me.ToolStripMenuItem1, Me.ToolStripMenuItem2, Me.ToolStripMenuItem3, Me.ToolStripMenuItem5})
        Me.FolderSelectionContextMenuStrip.Name = "ContextMenuStrip1"
        Me.FolderSelectionContextMenuStrip.Size = New System.Drawing.Size(288, 114)
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(287, 22)
        Me.ToolStripMenuItem4.Text = "C:\Program Files (x86)"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(287, 22)
        Me.ToolStripMenuItem1.Text = "C:\OED\Dotnetland\VS2019\VbSolutions"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(287, 22)
        Me.ToolStripMenuItem2.Text = "C:\Windows\System32"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(287, 22)
        Me.ToolStripMenuItem3.Text = "Documents"
        '
        'ToolStripMenuItem5
        '
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        Me.ToolStripMenuItem5.Size = New System.Drawing.Size(287, 22)
        Me.ToolStripMenuItem5.Text = "C:\Windows\Microsoft.NET"
        '
        'CancelButton
        '
        Me.CancelButton.Location = New System.Drawing.Point(105, 8)
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.Size = New System.Drawing.Size(75, 23)
        Me.CancelButton.TabIndex = 10
        Me.CancelButton.Text = "Cancel"
        Me.CancelButton.UseVisualStyleBackColor = True
        '
        'TraverseButton
        '
        Me.TraverseButton.Location = New System.Drawing.Point(12, 8)
        Me.TraverseButton.Name = "TraverseButton"
        Me.TraverseButton.Size = New System.Drawing.Size(75, 23)
        Me.TraverseButton.TabIndex = 9
        Me.TraverseButton.Text = "Traverse"
        Me.TraverseButton.UseVisualStyleBackColor = True
        '
        'ProcessingLabel
        '
        Me.ProcessingLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ProcessingLabel.AutoSize = True
        Me.ProcessingLabel.Location = New System.Drawing.Point(80, 426)
        Me.ProcessingLabel.Name = "ProcessingLabel"
        Me.ProcessingLabel.Size = New System.Drawing.Size(47, 15)
        Me.ProcessingLabel.TabIndex = 13
        Me.ProcessingLabel.Text = "Process"
        '
        'ProcessedTitleLabel
        '
        Me.ProcessedTitleLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ProcessedTitleLabel.AutoSize = True
        Me.ProcessedTitleLabel.Location = New System.Drawing.Point(12, 426)
        Me.ProcessedTitleLabel.Name = "ProcessedTitleLabel"
        Me.ProcessedTitleLabel.Size = New System.Drawing.Size(60, 15)
        Me.ProcessedTitleLabel.TabIndex = 14
        Me.ProcessedTitleLabel.Text = "Processed"
        '
        'ListViewForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ProcessedTitleLabel)
        Me.Controls.Add(Me.ProcessingLabel)
        Me.Controls.Add(Me.SelectFolderButton)
        Me.Controls.Add(Me.FolderTextBox)
        Me.Controls.Add(Me.CancelButton)
        Me.Controls.Add(Me.TraverseButton)
        Me.Controls.Add(Me.FoldersListView)
        Me.Name = "ListViewForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ListView Form"
        Me.OpenFolderContextMenuStrip.ResumeLayout(False)
        Me.FolderSelectionContextMenuStrip.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents FoldersListView As ListView
    Friend WithEvents LocationColumnHeader As ColumnHeader
    Friend WithEvents LocationHeader As ColumnHeader
    Friend WithEvents ModifiedHeader As ColumnHeader
    Friend WithEvents SelectFolderButton As Button
    Friend WithEvents FolderTextBox As TextBox
    Friend WithEvents CancelButton As Button
    Friend WithEvents TraverseButton As Button
    Friend WithEvents FolderSelectionContextMenuStrip As ContextMenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ProcessingLabel As Label
    Friend WithEvents ProcessedTitleLabel As Label
    Friend WithEvents NameColumnHeader As ColumnHeader
    Friend WithEvents NameHeader As ColumnHeader
    Friend WithEvents ToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem5 As ToolStripMenuItem
    Friend WithEvents OpenFolderContextMenuStrip As ContextMenuStrip
    Friend WithEvents ToolStripMenuItem6 As ToolStripMenuItem
End Class
