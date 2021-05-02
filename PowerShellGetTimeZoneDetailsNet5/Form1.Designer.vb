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
        Me.GetTimeZoneDetailsButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DisplayNameTextBox = New System.Windows.Forms.TextBox()
        Me.ComputerInfoButton = New System.Windows.Forms.Button()
        Me.PropertyGrid1 = New System.Windows.Forms.PropertyGrid()
        Me.SuspendLayout()
        '
        'GetTimeZoneDetailsButton
        '
        Me.GetTimeZoneDetailsButton.Location = New System.Drawing.Point(12, 12)
        Me.GetTimeZoneDetailsButton.Name = "GetTimeZoneDetailsButton"
        Me.GetTimeZoneDetailsButton.Size = New System.Drawing.Size(579, 23)
        Me.GetTimeZoneDetailsButton.TabIndex = 0
        Me.GetTimeZoneDetailsButton.Text = "Get Timezone details"
        Me.GetTimeZoneDetailsButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Display name"
        '
        'DisplayNameTextBox
        '
        Me.DisplayNameTextBox.Location = New System.Drawing.Point(96, 55)
        Me.DisplayNameTextBox.Name = "DisplayNameTextBox"
        Me.DisplayNameTextBox.Size = New System.Drawing.Size(212, 23)
        Me.DisplayNameTextBox.TabIndex = 2
        '
        'ComputerInfoButton
        '
        Me.ComputerInfoButton.Location = New System.Drawing.Point(12, 111)
        Me.ComputerInfoButton.Name = "ComputerInfoButton"
        Me.ComputerInfoButton.Size = New System.Drawing.Size(579, 23)
        Me.ComputerInfoButton.TabIndex = 3
        Me.ComputerInfoButton.Text = "Computer (some) details"
        Me.ComputerInfoButton.UseVisualStyleBackColor = True
        '
        'PropertyGrid1
        '
        Me.PropertyGrid1.Location = New System.Drawing.Point(19, 151)
        Me.PropertyGrid1.Name = "PropertyGrid1"
        Me.PropertyGrid1.Size = New System.Drawing.Size(583, 351)
        Me.PropertyGrid1.TabIndex = 4
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(614, 514)
        Me.Controls.Add(Me.PropertyGrid1)
        Me.Controls.Add(Me.ComputerInfoButton)
        Me.Controls.Add(Me.DisplayNameTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GetTimeZoneDetailsButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Process start / Powershell"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GetTimeZoneDetailsButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents DisplayNameTextBox As TextBox
    Friend WithEvents ComputerInfoButton As Button
    Friend WithEvents PropertyGrid1 As PropertyGrid
End Class
