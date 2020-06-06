Public Class GIVE_WORD

    Private Sub GIVE_WORD_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Main.Enabled = True

    End Sub

    Private Sub GIVE_WORD_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnproceed_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnproceed.Click

        'Dim b As Integer
        'b = 0
        'For i = 1 To txtword.TextLength
        '    b = b + 1
        '    Dim a As String
        '    a = Mid(txtword.Text, b, 1)

        '    If IsNumeric(a) = False Then

        '    Else
        '        MsgBox("Your word should not include numbers", MsgBoxStyle.Critical)
        '    End If
        'Next i
        If TextBox1.Text <> "" And txtword.Text <> "" And txtword.TextLength <= 15 Then
            If TextBox1.Text = "PROVIDE HINT" Then
                MsgBox("Please provide the hint to 2nd player", MsgBoxStyle.Exclamation, "No Hint provided")
                TextBox1.Focus()
            Else
                Dim a As Integer
                Dim s As Integer
                Dim err As Integer = 0
                For a = 1 To txtword.Text.Length
                    s = Asc(Mid(txtword.Text, a, 1))
                    If s <= 64 Or s >= 91 Then
                        err = err + 1
                    End If
                Next a
                If err > 0 Then
                    MsgBox("Only alphabets are acceptable in this box.....please recheck your word ", MsgBoxStyle.Critical, "Character Error")

                ElseIf err = 0 Then
                    If TextBox1.Text <> txtword.Text Then
                        local.x = txtword.Text
                        local.hint = TextBox1.Text
                        txtword.Clear()
                        TextBox1.Clear()
                        Form1.Show()
                        Me.Close()
                    Else
                        MsgBox("Hint can't be same as the given word", MsgBoxStyle.Critical, "ERROR")
                    End If

                End If
            End If
           
        Else
            MsgBox("Error", MsgBoxStyle.Critical)
        End If
    End Sub
End Class