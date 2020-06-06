<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Clue
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
        Me.clue1 = New System.Windows.Forms.TextBox
        Me.Clue2 = New System.Windows.Forms.TextBox
        Me.Clue3 = New System.Windows.Forms.TextBox
        Me.Clue4 = New System.Windows.Forms.TextBox
        Me.lblclue1 = New System.Windows.Forms.Label
        Me.lblclue2 = New System.Windows.Forms.Label
        Me.lblclue3 = New System.Windows.Forms.Label
        Me.lblclue4 = New System.Windows.Forms.Label
        Me.btnproceed = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'clue1
        '
        Me.clue1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.clue1.Location = New System.Drawing.Point(93, 27)
        Me.clue1.MaxLength = 1
        Me.clue1.Name = "clue1"
        Me.clue1.Size = New System.Drawing.Size(100, 20)
        Me.clue1.TabIndex = 1
        '
        'Clue2
        '
        Me.Clue2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Clue2.Location = New System.Drawing.Point(93, 53)
        Me.Clue2.MaxLength = 1
        Me.Clue2.Name = "Clue2"
        Me.Clue2.Size = New System.Drawing.Size(100, 20)
        Me.Clue2.TabIndex = 2
        '
        'Clue3
        '
        Me.Clue3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Clue3.Location = New System.Drawing.Point(93, 79)
        Me.Clue3.MaxLength = 1
        Me.Clue3.Name = "Clue3"
        Me.Clue3.Size = New System.Drawing.Size(100, 20)
        Me.Clue3.TabIndex = 3
        '
        'Clue4
        '
        Me.Clue4.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Clue4.Location = New System.Drawing.Point(93, 105)
        Me.Clue4.MaxLength = 1
        Me.Clue4.Name = "Clue4"
        Me.Clue4.Size = New System.Drawing.Size(100, 20)
        Me.Clue4.TabIndex = 4
        '
        'lblclue1
        '
        Me.lblclue1.AutoSize = True
        Me.lblclue1.Location = New System.Drawing.Point(22, 30)
        Me.lblclue1.Name = "lblclue1"
        Me.lblclue1.Size = New System.Drawing.Size(34, 13)
        Me.lblclue1.TabIndex = 1
        Me.lblclue1.Text = "Clue1"
        '
        'lblclue2
        '
        Me.lblclue2.AutoSize = True
        Me.lblclue2.Location = New System.Drawing.Point(22, 56)
        Me.lblclue2.Name = "lblclue2"
        Me.lblclue2.Size = New System.Drawing.Size(34, 13)
        Me.lblclue2.TabIndex = 1
        Me.lblclue2.Text = "Clue2"
        '
        'lblclue3
        '
        Me.lblclue3.AutoSize = True
        Me.lblclue3.Location = New System.Drawing.Point(22, 82)
        Me.lblclue3.Name = "lblclue3"
        Me.lblclue3.Size = New System.Drawing.Size(34, 13)
        Me.lblclue3.TabIndex = 1
        Me.lblclue3.Text = "Clue3"
        '
        'lblclue4
        '
        Me.lblclue4.AutoSize = True
        Me.lblclue4.Location = New System.Drawing.Point(22, 108)
        Me.lblclue4.Name = "lblclue4"
        Me.lblclue4.Size = New System.Drawing.Size(34, 13)
        Me.lblclue4.TabIndex = 1
        Me.lblclue4.Text = "Clue4"
        '
        'btnproceed
        '
        Me.btnproceed.Location = New System.Drawing.Point(199, 103)
        Me.btnproceed.Name = "btnproceed"
        Me.btnproceed.Size = New System.Drawing.Size(75, 23)
        Me.btnproceed.TabIndex = 5
        Me.btnproceed.Text = "Proceed"
        Me.btnproceed.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(1, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(297, 12)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Type letters that you want to give as clue........"
        '
        'Clue
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(290, 132)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnproceed)
        Me.Controls.Add(Me.lblclue4)
        Me.Controls.Add(Me.lblclue3)
        Me.Controls.Add(Me.lblclue2)
        Me.Controls.Add(Me.lblclue1)
        Me.Controls.Add(Me.Clue4)
        Me.Controls.Add(Me.Clue3)
        Me.Controls.Add(Me.Clue2)
        Me.Controls.Add(Me.clue1)
        Me.Name = "Clue"
        Me.Text = "Clue"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents clue1 As System.Windows.Forms.TextBox
    Friend WithEvents Clue2 As System.Windows.Forms.TextBox
    Friend WithEvents Clue3 As System.Windows.Forms.TextBox
    Friend WithEvents Clue4 As System.Windows.Forms.TextBox
    Friend WithEvents lblclue1 As System.Windows.Forms.Label
    Friend WithEvents lblclue2 As System.Windows.Forms.Label
    Friend WithEvents lblclue3 As System.Windows.Forms.Label
    Friend WithEvents lblclue4 As System.Windows.Forms.Label
    Friend WithEvents btnproceed As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
