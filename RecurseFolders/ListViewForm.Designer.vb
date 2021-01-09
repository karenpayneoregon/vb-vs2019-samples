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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ListViewForm))
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.NameHeader = New System.Windows.Forms.ColumnHeader()
        Me.LocationHeader = New System.Windows.Forms.ColumnHeader()
        Me.ModifiedHeader = New System.Windows.Forms.ColumnHeader()
        Me.SelectFolderButton = New System.Windows.Forms.Button()
        Me.FolderTextBox = New System.Windows.Forms.TextBox()
        Me.CancelButton = New System.Windows.Forms.Button()
        Me.TraverseButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.NameHeader, Me.LocationHeader, Me.ModifiedHeader})
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(12, 90)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(776, 274)
        Me.ListView1.TabIndex = 8
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'NameHeader
        '
        Me.NameHeader.Name = "NameHeader"
        Me.NameHeader.Text = "Name"
        '
        'LocationHeader
        '
        Me.LocationHeader.Name = "LocationHeader"
        Me.LocationHeader.Text = "Location"
        '
        'ModifiedHeader
        '
        Me.ModifiedHeader.Name = "ModifiedHeader"
        Me.ModifiedHeader.Text = "Modified"
        '
        'SelectFolderButton
        '
        Me.SelectFolderButton.Image = CType(resources.GetObject("SelectFolderButton.Image"), System.Drawing.Image)
        Me.SelectFolderButton.Location = New System.Drawing.Point(536, 60)
        Me.SelectFolderButton.Name = "SelectFolderButton"
        Me.SelectFolderButton.Size = New System.Drawing.Size(56, 23)
        Me.SelectFolderButton.TabIndex = 12
        Me.SelectFolderButton.UseVisualStyleBackColor = True
        '
        'FolderTextBox
        '
        Me.FolderTextBox.Location = New System.Drawing.Point(12, 61)
        Me.FolderTextBox.Name = "FolderTextBox"
        Me.FolderTextBox.Size = New System.Drawing.Size(518, 23)
        Me.FolderTextBox.TabIndex = 11
        Me.FolderTextBox.Text = "C:\Windows\System32"
        '
        'CancelButton
        '
        Me.CancelButton.Location = New System.Drawing.Point(105, 32)
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.Size = New System.Drawing.Size(75, 23)
        Me.CancelButton.TabIndex = 10
        Me.CancelButton.Text = "Cancel"
        Me.CancelButton.UseVisualStyleBackColor = True
        '
        'TraverseButton
        '
        Me.TraverseButton.Location = New System.Drawing.Point(12, 32)
        Me.TraverseButton.Name = "TraverseButton"
        Me.TraverseButton.Size = New System.Drawing.Size(75, 23)
        Me.TraverseButton.TabIndex = 9
        Me.TraverseButton.Text = "Traverse"
        Me.TraverseButton.UseVisualStyleBackColor = True
        '
        'ListViewForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.SelectFolderButton)
        Me.Controls.Add(Me.FolderTextBox)
        Me.Controls.Add(Me.CancelButton)
        Me.Controls.Add(Me.TraverseButton)
        Me.Controls.Add(Me.ListView1)
        Me.Name = "ListViewForm"
        Me.Text = "ListView Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListView1 As ListView
    Friend WithEvents NameHeader As ColumnHeader
    Friend WithEvents LocationHeader As ColumnHeader
    Friend WithEvents ModifiedHeader As ColumnHeader
    Friend WithEvents SelectFolderButton As Button
    Friend WithEvents FolderTextBox As TextBox
    Friend WithEvents CancelButton As Button
    Friend WithEvents TraverseButton As Button
End Class
