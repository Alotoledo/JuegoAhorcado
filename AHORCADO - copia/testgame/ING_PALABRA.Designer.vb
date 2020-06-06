<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GIVE_WORD
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
        Me.txtword = New System.Windows.Forms.TextBox()
        Me.lblword = New System.Windows.Forms.Label()
        Me.btnproceed = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtword
        '
        Me.txtword.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtword.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtword.Location = New System.Drawing.Point(147, 68)
        Me.txtword.Name = "txtword"
        Me.txtword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9688)
        Me.txtword.Size = New System.Drawing.Size(235, 26)
        Me.txtword.TabIndex = 2
        '
        'lblword
        '
        Me.lblword.AutoSize = True
        Me.lblword.Location = New System.Drawing.Point(28, 76)
        Me.lblword.Name = "lblword"
        Me.lblword.Size = New System.Drawing.Size(114, 13)
        Me.lblword.TabIndex = 1
        Me.lblword.Text = "ESCRIBA LA PALARA"
        '
        'btnproceed
        '
        Me.btnproceed.Location = New System.Drawing.Point(307, 108)
        Me.btnproceed.Name = "btnproceed"
        Me.btnproceed.Size = New System.Drawing.Size(75, 23)
        Me.btnproceed.TabIndex = 3
        Me.btnproceed.Text = "&Hecho"
        Me.btnproceed.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(147, 30)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(235, 26)
        Me.TextBox1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(102, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "PISTA"
        '
        'GIVE_WORD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(430, 148)
        Me.Controls.Add(Me.btnproceed)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblword)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.txtword)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Name = "GIVE_WORD"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Palabra                                                                          " &
    "                       TOLEDO"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtword As System.Windows.Forms.TextBox
    Friend WithEvents lblword As System.Windows.Forms.Label
    Friend WithEvents btnproceed As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
