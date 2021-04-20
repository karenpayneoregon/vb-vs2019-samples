<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.RunButton = New System.Windows.Forms.Button()
        Me.CancelDemo2Button = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'RunButton
        '
        Me.RunButton.Location = New System.Drawing.Point(23, 25)
        Me.RunButton.Name = "RunButton"
        Me.RunButton.Size = New System.Drawing.Size(75, 23)
        Me.RunButton.TabIndex = 1
        Me.RunButton.Text = "Go"
        Me.RunButton.UseVisualStyleBackColor = True
        '
        'CancelDemo2Button
        '
        Me.CancelDemo2Button.Location = New System.Drawing.Point(113, 25)
        Me.CancelDemo2Button.Name = "CancelDemo2Button"
        Me.CancelDemo2Button.Size = New System.Drawing.Size(75, 23)
        Me.CancelDemo2Button.TabIndex = 2
        Me.CancelDemo2Button.Text = "Cancel"
        Me.CancelDemo2Button.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(315, 182)
        Me.Controls.Add(Me.CancelDemo2Button)
        Me.Controls.Add(Me.RunButton)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RunButton As Button
    Friend WithEvents CancelDemo2Button As Button
End Class
