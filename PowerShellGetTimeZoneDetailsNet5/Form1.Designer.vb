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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TimeLabel = New System.Windows.Forms.Label()
        Me.StartTimerButton = New System.Windows.Forms.Button()
        Me.StopTimerButton = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
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
        Me.ComputerInfoButton.Location = New System.Drawing.Point(16, 137)
        Me.ComputerInfoButton.Name = "ComputerInfoButton"
        Me.ComputerInfoButton.Size = New System.Drawing.Size(579, 23)
        Me.ComputerInfoButton.TabIndex = 3
        Me.ComputerInfoButton.Text = "Computer (some) details"
        Me.ComputerInfoButton.UseVisualStyleBackColor = True
        '
        'PropertyGrid1
        '
        Me.PropertyGrid1.Location = New System.Drawing.Point(12, 194)
        Me.PropertyGrid1.Name = "PropertyGrid1"
        Me.PropertyGrid1.Size = New System.Drawing.Size(583, 351)
        Me.PropertyGrid1.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 164)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 15)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Elapsed  time:"
        '
        'TimeLabel
        '
        Me.TimeLabel.AutoSize = True
        Me.TimeLabel.Location = New System.Drawing.Point(100, 165)
        Me.TimeLabel.Name = "TimeLabel"
        Me.TimeLabel.Size = New System.Drawing.Size(31, 15)
        Me.TimeLabel.TabIndex = 6
        Me.TimeLabel.Text = "0:0:0"
        '
        'StartTimerButton
        '
        Me.StartTimerButton.Location = New System.Drawing.Point(25, 27)
        Me.StartTimerButton.Name = "StartTimerButton"
        Me.StartTimerButton.Size = New System.Drawing.Size(75, 23)
        Me.StartTimerButton.TabIndex = 7
        Me.StartTimerButton.Text = "Start"
        Me.StartTimerButton.UseVisualStyleBackColor = True
        '
        'StopTimerButton
        '
        Me.StopTimerButton.Location = New System.Drawing.Point(106, 26)
        Me.StopTimerButton.Name = "StopTimerButton"
        Me.StopTimerButton.Size = New System.Drawing.Size(75, 23)
        Me.StopTimerButton.TabIndex = 8
        Me.StopTimerButton.Text = "Stop"
        Me.StopTimerButton.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.StopTimerButton)
        Me.GroupBox1.Controls.Add(Me.StartTimerButton)
        Me.GroupBox1.Location = New System.Drawing.Point(390, 55)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(201, 60)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Stop watch example"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(614, 557)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TimeLabel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PropertyGrid1)
        Me.Controls.Add(Me.ComputerInfoButton)
        Me.Controls.Add(Me.DisplayNameTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GetTimeZoneDetailsButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Process start / Powershell"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout

End Sub

    Friend WithEvents GetTimeZoneDetailsButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents DisplayNameTextBox As TextBox
    Friend WithEvents ComputerInfoButton As Button
    Friend WithEvents PropertyGrid1 As PropertyGrid
    Friend WithEvents Label2 As Label
    Friend WithEvents TimeLabel As Label
    Friend WithEvents StartTimerButton As Button
    Friend WithEvents StopTimerButton As Button
    Friend WithEvents GroupBox1 As GroupBox
End Class
