Public Class GIVE_WORD

    Private Sub GIVE_WORD_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Hide()

    End Sub

    Private Sub GIVE_WORD_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnproceed_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnproceed.Click

        If TextBox1.Text <> "" And txtword.Text <> "" And txtword.TextLength <= 15 Then
            If TextBox1.Text = "Proporciona una ayuda" Then
                MsgBox("Proporcione una ayuda al otro jugador", MsgBoxStyle.Exclamation, "Sujerencia no proporcionada")
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
                    MsgBox("Solamente letras son aceptables en este cuadro ..... por favor vuelva a verificar su palabra ", MsgBoxStyle.Critical, "Error de caracter")

                ElseIf err = 0 Then
                    If TextBox1.Text <> txtword.Text Then
                        local.x = txtword.Text
                        local.hola = TextBox1.Text
                        txtword.Clear()
                        TextBox1.Clear()
                        Form1.Show()
                        Me.Hide()
                    Else
                        MsgBox("La sugerencia no puede ser la misma que la palabra dada", MsgBoxStyle.Critical, "ERROR")
                    End If

                End If
            End If

        Else
            MsgBox("Error", MsgBoxStyle.Critical)
        End If
    End Sub

End Class