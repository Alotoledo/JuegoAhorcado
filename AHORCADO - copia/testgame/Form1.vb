Public Class Form1

    Dim word As String
    Dim chance As Integer = 8

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Label5.Text = local.hola
        word = local.x
        Dim wordlength As Integer
        wordlength = local.x.Length
        Dim s As Integer
        For s = 1 To wordlength
            TextBox1.Text = TextBox1.Text + "-"
        Next

    End Sub

   

    Private Sub A_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles A.Click
        TextBox2.Text = TextBox2.Text & "A"
        Dim i As Integer
        Dim lettercount As Integer = 0
        For i = 1 To word.Length
            If Mid(word, i, 1) = A.Text Then
                lettercount = lettercount + 1
                Mid(TextBox1.Text, i, 1) = A.Text
            End If
        Next

        If lettercount < 1 Then
            MsgBox("La letra no esta en esta palabra")
            chance = chance - 1
            If chance = 0 Then
                MsgBox("Fin del Juego" & Chr(13) & "La palabra era: " & word, MsgBoxStyle.Critical)
                GroupBox1.Enabled = False

            End If

        End If
        A.Enabled = False
        Label3.Text = chance
        If TextBox1.Text = word Then
            If MsgBox("Felicitaciones. . ." & "Lo has logrado", MsgBoxStyle.Information) = MsgBoxResult.Ok Then
                Me.Close()
                GIVE_WORD.Show()
            End If
        End If

    End Sub

    Private Sub B_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B.Click
        TextBox2.Text = TextBox2.Text & "B"
        Dim i As Integer
        Dim lettercount As Integer = 0
        For i = 1 To word.Length
            If Mid(word, i, 1) = B.Text Then
                lettercount = lettercount + 1
                Mid(TextBox1.Text, i, 1) = B.Text
            End If
        Next

        If lettercount < 1 Then
            MsgBox("La letra no esta en esta palabra")
            chance = chance - 1
            If chance = 0 Then
                MsgBox("Fin del Juego" & Chr(13) & "La palabra era: " & word, MsgBoxStyle.Critical)
                GroupBox1.Enabled = False

            End If
        End If
        B.Enabled = False
        Label3.Text = chance
        If TextBox1.Text = word Then
            If MsgBox("Felicitaciones. . ." & "Lo has logrado", MsgBoxStyle.Information) = MsgBoxResult.Ok Then
                Me.Close()
                GIVE_WORD.Show()
            End If
        End If

    End Sub

    Private Sub C_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C.Click
        TextBox2.Text = TextBox2.Text & "C"
        Dim i As Integer
        Dim lettercount As Integer = 0
        For i = 1 To word.Length
            If Mid(word, i, 1) = C.Text Then
                lettercount = lettercount + 1
                Mid(TextBox1.Text, i, 1) = C.Text
            End If
        Next

        If lettercount < 1 Then
            MsgBox("La letra no esta en esta palabra")
            chance = chance - 1
            If chance = 0 Then
                MsgBox("Fin del Juego" & Chr(13) & "La palabra era: " & word, MsgBoxStyle.Critical)
                GroupBox1.Enabled = False

            End If
        End If
        C.Enabled = False
        Label3.Text = chance
        If TextBox1.Text = word Then
            If MsgBox("Felicitaciones. . ." & "Lo has logrado", MsgBoxStyle.Information) = MsgBoxResult.Ok Then
                Me.Close()
                GIVE_WORD.Show()
            End If
        End If
    End Sub

    Private Sub D_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles D.Click
        TextBox2.Text = TextBox2.Text & "D"
        Dim i As Integer
        Dim lettercount As Integer = 0
        For i = 1 To word.Length
            If Mid(word, i, 1) = D.Text Then
                lettercount = lettercount + 1
                Mid(TextBox1.Text, i, 1) = D.Text
            End If
        Next

        If lettercount < 1 Then
            MsgBox("La letra no esta en esta palabra")
            chance = chance - 1
            If chance = 0 Then
                MsgBox("Fin del Juego" & Chr(13) & "La palabra era: " & word, MsgBoxStyle.Critical)
                GroupBox1.Enabled = False

            End If
        End If
        D.Enabled = False
        Label3.Text = chance
        If TextBox1.Text = word Then
            If MsgBox("Felicitaciones. . ." & "Lo has logrado", MsgBoxStyle.Information) = MsgBoxResult.Ok Then
                Me.Close()
                GIVE_WORD.Show()
            End If
        End If
    End Sub

    Private Sub E_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles E.Click
        TextBox2.Text = TextBox2.Text & "E"
        Dim i As Integer
        Dim lettercount As Integer = 0
        For i = 1 To word.Length
            If Mid(word, i, 1) = Me.E.Text Then
                lettercount = lettercount + 1
                Mid(TextBox1.Text, i, 1) = Me.E.Text
            End If
        Next

        If lettercount < 1 Then
            MsgBox("La letra no esta en esta palabra")
            chance = chance - 1
            If chance = 0 Then
                MsgBox("Fin del Juego" & Chr(13) & "La palabra era: " & word, MsgBoxStyle.Critical)
                GroupBox1.Enabled = False

            End If
        End If
        Me.E.Enabled = False
        Label3.Text = chance
        If TextBox1.Text = word Then
            If MsgBox("Felicitaciones. . ." & "Lo has logrado", MsgBoxStyle.Information) = MsgBoxResult.Ok Then
                Me.Close()
                GIVE_WORD.Show()
            End If
        End If
    End Sub

    Private Sub F_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F.Click
        TextBox2.Text = TextBox2.Text & "F"
        Dim i As Integer
        Dim lettercount As Integer = 0
        For i = 1 To word.Length
            If Mid(word, i, 1) = F.Text Then
                lettercount = lettercount + 1
                Mid(TextBox1.Text, i, 1) = F.Text
            End If
        Next

        If lettercount < 1 Then
            MsgBox("La letra no esta en esta palabra")
            chance = chance - 1
            If chance = 0 Then
                MsgBox("Fin del Juego" & Chr(13) & "La palabra era: " & word, MsgBoxStyle.Critical)
                GroupBox1.Enabled = False

            End If
        End If
        F.Enabled = False
        Label3.Text = chance
        If TextBox1.Text = word Then
            If MsgBox("Felicitaciones. . ." & "Lo has logrado", MsgBoxStyle.Information) = MsgBoxResult.Ok Then
                Me.Close()
                GIVE_WORD.Show()
            End If
        End If
    End Sub

    Private Sub G_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles G.Click
        TextBox2.Text = TextBox2.Text & "G"
        Dim i As Integer
        Dim lettercount As Integer = 0
        For i = 1 To word.Length
            If Mid(word, i, 1) = G.Text Then
                lettercount = lettercount + 1
                Mid(TextBox1.Text, i, 1) = G.Text
            End If
        Next

        If lettercount < 1 Then
            MsgBox("La letra no esta en esta palabra")
            chance = chance - 1
            If chance = 0 Then
                MsgBox("Fin del Juego" & Chr(13) & "La palabra era: " & word, MsgBoxStyle.Critical)
                GroupBox1.Enabled = False

            End If
        End If
        G.Enabled = False
        Label3.Text = chance
        If TextBox1.Text = word Then
            If MsgBox("Felicitaciones. . ." & "Lo has logrado", MsgBoxStyle.Information) = MsgBoxResult.Ok Then
                Me.Close()
                GIVE_WORD.Show()
            End If
        End If
    End Sub

    Private Sub H_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles H.Click
        TextBox2.Text = TextBox2.Text & "H"
        Dim i As Integer
        Dim lettercount As Integer = 0
        For i = 1 To word.Length
            If Mid(word, i, 1) = H.Text Then
                lettercount = lettercount + 1
                Mid(TextBox1.Text, i, 1) = H.Text
            End If
        Next

        If lettercount < 1 Then
            MsgBox("La letra no esta en esta palabra")
            chance = chance - 1
            If chance = 0 Then
                MsgBox("Fin del Juego" & Chr(13) & "La palabra era: " & word, MsgBoxStyle.Critical)
                GroupBox1.Enabled = False

            End If
        End If
        H.Enabled = False
        Label3.Text = chance
        If TextBox1.Text = word Then
            If MsgBox("Felicitaciones. . ." & "Lo has logrado", MsgBoxStyle.Information) = MsgBoxResult.Ok Then
                Me.Close()
                GIVE_WORD.Show()
            End If
        End If
    End Sub

    Private Sub I_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles I.Click
        TextBox2.Text = TextBox2.Text & "I"
        Dim i As Integer
        Dim lettercount As Integer = 0
        For i = 1 To word.Length
            If Mid(word, i, 1) = Me.I.Text Then
                lettercount = lettercount + 1
                Mid(TextBox1.Text, i, 1) = Me.I.Text
            End If
        Next

        If lettercount < 1 Then
            MsgBox("La letra no esta en esta palabra")
            chance = chance - 1
            If chance = 0 Then
                MsgBox("Fin del Juego" & Chr(13) & "La palabra era: " & word, MsgBoxStyle.Critical)
                GroupBox1.Enabled = False

            End If
        End If
        Me.I.Enabled = False
        Label3.Text = chance
        If TextBox1.Text = word Then
            If MsgBox("Felicitaciones. . ." & "Lo has logrado", MsgBoxStyle.Information) = MsgBoxResult.Ok Then
                Me.Close()
                GIVE_WORD.Show()
            End If
        End If
    End Sub

    Private Sub J_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles J.Click
        TextBox2.Text = TextBox2.Text & "J"
        Dim i As Integer
        Dim lettercount As Integer = 0
        For i = 1 To word.Length
            If Mid(word, i, 1) = J.Text Then
                lettercount = lettercount + 1
                Mid(TextBox1.Text, i, 1) = J.Text
            End If
        Next

        If lettercount < 1 Then
            MsgBox("La letra no esta en esta palabra")
            chance = chance - 1
            If chance = 0 Then
                MsgBox("Fin del Juego" & Chr(13) & "La palabra era: " & word, MsgBoxStyle.Critical)
                GroupBox1.Enabled = False

            End If
        End If
        J.Enabled = False
        Label3.Text = chance
        If TextBox1.Text = word Then
            If MsgBox("Felicitaciones. . ." & "Lo has logrado", MsgBoxStyle.Information) = MsgBoxResult.Ok Then
                Me.Close()
                GIVE_WORD.Show()
            End If
        End If
    End Sub

    Private Sub K_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles K.Click
        TextBox2.Text = TextBox2.Text & "K"
        Dim i As Integer
        Dim lettercount As Integer = 0
        For i = 1 To word.Length
            If Mid(word, i, 1) = K.Text Then
                lettercount = lettercount + 1
                Mid(TextBox1.Text, i, 1) = K.Text
            End If
        Next

        If lettercount < 1 Then
            MsgBox("La letra no esta en esta palabra")
            chance = chance - 1
            If chance = 0 Then
                MsgBox("Fin del Juego" & Chr(13) & "La palabra era: " & word, MsgBoxStyle.Critical)
                GroupBox1.Enabled = False

            End If
        End If
        K.Enabled = False
        Label3.Text = chance
        If TextBox1.Text = word Then
            If MsgBox("Felicitaciones. . ." & "Lo has logrado", MsgBoxStyle.Information) = MsgBoxResult.Ok Then
                Me.Close()
                GIVE_WORD.Show()
            End If
        End If
    End Sub

    Private Sub L_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles L.Click
        TextBox2.Text = TextBox2.Text & "L"
        Dim i As Integer
        Dim lettercount As Integer = 0
        For i = 1 To word.Length
            If Mid(word, i, 1) = L.Text Then
                lettercount = lettercount + 1
                Mid(TextBox1.Text, i, 1) = L.Text
            End If
        Next

        If lettercount < 1 Then
            MsgBox("La letra no esta en esta palabra")
            chance = chance - 1
            If chance = 0 Then
                MsgBox("Fin del Juego" & Chr(13) & "La palabra era: " & word, MsgBoxStyle.Critical)
                GroupBox1.Enabled = False

            End If
        End If
        L.Enabled = False
        Label3.Text = chance
        If TextBox1.Text = word Then
            If MsgBox("Felicitaciones. . ." & "Lo has logrado", MsgBoxStyle.Information) = MsgBoxResult.Ok Then
                Me.Close()
                GIVE_WORD.Show()
            End If
        End If
    End Sub

    Private Sub M_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles M.Click
        TextBox2.Text = TextBox2.Text & "M"
        Dim i As Integer
        Dim lettercount As Integer = 0
        For i = 1 To word.Length
            If Mid(word, i, 1) = M.Text Then
                lettercount = lettercount + 1
                Mid(TextBox1.Text, i, 1) = M.Text
            End If
        Next

        If lettercount < 1 Then
            MsgBox("La letra no esta en esta palabra")
            chance = chance - 1
            If chance = 0 Then
                MsgBox("Fin del Juego" & Chr(13) & "La palabra era: " & word, MsgBoxStyle.Critical)
                GroupBox1.Enabled = False

            End If
        End If
        M.Enabled = False
        Label3.Text = chance
        If TextBox1.Text = word Then
            If MsgBox("Felicitaciones. . ." & "Lo has logrado", MsgBoxStyle.Information) = MsgBoxResult.Ok Then
                Me.Close()
                GIVE_WORD.Show()
            End If
        End If
    End Sub

    Private Sub N_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles N.Click
        TextBox2.Text = TextBox2.Text & "N"
        Dim i As Integer
        Dim lettercount As Integer = 0
        For i = 1 To word.Length
            If Mid(word, i, 1) = N.Text Then
                lettercount = lettercount + 1
                Mid(TextBox1.Text, i, 1) = N.Text
            End If
        Next

        If lettercount < 1 Then
            MsgBox("La letra no esta en esta palabra")
            chance = chance - 1
            If chance = 0 Then
                MsgBox("Fin del Juego" & Chr(13) & "La palabra era: " & word, MsgBoxStyle.Critical)
                GroupBox1.Enabled = False

            End If
        End If
        N.Enabled = False
        Label3.Text = chance
        If TextBox1.Text = word Then
            If MsgBox("Felicitaciones. . ." & "Lo has logrado", MsgBoxStyle.Information) = MsgBoxResult.Ok Then
                Me.Close()
                GIVE_WORD.Show()
            End If
        End If
    End Sub

    Private Sub O_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles O.Click
        TextBox2.Text = TextBox2.Text & "O"
        Dim i As Integer
        Dim lettercount As Integer = 0
        For i = 1 To word.Length
            If Mid(word, i, 1) = O.Text Then
                lettercount = lettercount + 1
                Mid(TextBox1.Text, i, 1) = O.Text
            End If
        Next

        If lettercount < 1 Then
            MsgBox("La letra no esta en esta palabra")
            chance = chance - 1
            If chance = 0 Then
                MsgBox("Fin del Juego" & Chr(13) & "La palabra era: " & word, MsgBoxStyle.Critical)
                GroupBox1.Enabled = False

            End If
        End If
        O.Enabled = False
        Label3.Text = chance
        If TextBox1.Text = word Then
            If MsgBox("Felicitaciones. . ." & "Lo has logrado", MsgBoxStyle.Information) = MsgBoxResult.Ok Then
                Me.Close()
                GIVE_WORD.Show()
            End If
        End If
    End Sub

    Private Sub P_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles P.Click
        TextBox2.Text = TextBox2.Text & "P"
        Dim i As Integer
        Dim lettercount As Integer = 0
        For i = 1 To word.Length
            If Mid(word, i, 1) = P.Text Then
                lettercount = lettercount + 1
                Mid(TextBox1.Text, i, 1) = P.Text
            End If
        Next

        If lettercount < 1 Then
            MsgBox("La letra no esta en esta palabra")
            chance = chance - 1
            If chance = 0 Then
                MsgBox("Fin del Juego" & Chr(13) & "La palabra era: " & word, MsgBoxStyle.Critical)
                GroupBox1.Enabled = False

            End If
        End If
        P.Enabled = False
        Label3.Text = chance
        If TextBox1.Text = word Then
            If MsgBox("Felicitaciones. . ." & "Lo has logrado", MsgBoxStyle.Information) = MsgBoxResult.Ok Then
                Me.Close()
                GIVE_WORD.Show()
            End If
        End If
    End Sub

    Private Sub Q_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Q.Click
        TextBox2.Text = TextBox2.Text & "Q"
        Dim i As Integer
        Dim lettercount As Integer = 0
        For i = 1 To word.Length
            If Mid(word, i, 1) = Q.Text Then
                lettercount = lettercount + 1
                Mid(TextBox1.Text, i, 1) = Q.Text
            End If
        Next

        If lettercount < 1 Then
            MsgBox("La letra no esta en esta palabra")
            chance = chance - 1
            If chance = 0 Then
                MsgBox("Fin del Juego" & Chr(13) & "La palabra era: " & word, MsgBoxStyle.Critical)
                GroupBox1.Enabled = False

            End If
        End If
        Q.Enabled = False
        Label3.Text = chance
        If TextBox1.Text = word Then
            If MsgBox("Felicitaciones. . ." & "Lo has logrado", MsgBoxStyle.Information) = MsgBoxResult.Ok Then
                Me.Close()
                GIVE_WORD.Show()
            End If
        End If
    End Sub

    Private Sub R_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles R.Click
        TextBox2.Text = TextBox2.Text & "R"
        Dim i As Integer
        Dim lettercount As Integer = 0
        For i = 1 To word.Length
            If Mid(word, i, 1) = R.Text Then
                lettercount = lettercount + 1
                Mid(TextBox1.Text, i, 1) = R.Text
            End If
        Next

        If lettercount < 1 Then
            MsgBox("La letra no esta en esta palabra")
            chance = chance - 1
            If chance = 0 Then
                MsgBox("Fin del Juego" & Chr(13) & "La palabra era: " & word, MsgBoxStyle.Critical)
                GroupBox1.Enabled = False

            End If
        End If
        R.Enabled = False
        Label3.Text = chance
        If TextBox1.Text = word Then
            If MsgBox("Felicitaciones. . ." & "Lo has logrado", MsgBoxStyle.Information) = MsgBoxResult.Ok Then
                Me.Close()
                GIVE_WORD.Show()
            End If
        End If
    End Sub

    Private Sub S_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S.Click
        TextBox2.Text = TextBox2.Text & "S"
        Dim i As Integer
        Dim lettercount As Integer = 0
        For i = 1 To word.Length
            If Mid(word, i, 1) = S.Text Then
                lettercount = lettercount + 1
                Mid(TextBox1.Text, i, 1) = S.Text
            End If
        Next

        If lettercount < 1 Then
            MsgBox("La letra no esta en esta palabra")
            chance = chance - 1
            If chance = 0 Then
                MsgBox("Fin del Juego" & Chr(13) & "La palabra era: " & word, MsgBoxStyle.Critical)
                GroupBox1.Enabled = False

            End If
        End If
        S.Enabled = False
        Label3.Text = chance
        If TextBox1.Text = word Then
            If MsgBox("Felicitaciones. . ." & "Lo has logrado", MsgBoxStyle.Information) = MsgBoxResult.Ok Then
                Me.Close()
                GIVE_WORD.Show()
            End If
        End If
    End Sub

    Private Sub T_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles T.Click
        TextBox2.Text = TextBox2.Text & "T"
        Dim i As Integer
        Dim lettercount As Integer = 0
        For i = 1 To word.Length
            If Mid(word, i, 1) = T.Text Then
                lettercount = lettercount + 1
                Mid(TextBox1.Text, i, 1) = T.Text
            End If
        Next

        If lettercount < 1 Then
            MsgBox("La letra no esta en esta palabra")
            chance = chance - 1
            If chance = 0 Then
                MsgBox("Fin del Juego" & Chr(13) & "La palabra era: " & word, MsgBoxStyle.Critical)
                GroupBox1.Enabled = False

            End If
        End If
        T.Enabled = False
        Label3.Text = chance
        If TextBox1.Text = word Then
            If MsgBox("Felicitaciones. . ." & "Lo has logrado", MsgBoxStyle.Information) = MsgBoxResult.Ok Then
                Me.Close()
                GIVE_WORD.Show()
            End If
        End If
    End Sub

    Private Sub U_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles U.Click
        TextBox2.Text = TextBox2.Text & "U"
        Dim i As Integer
        Dim lettercount As Integer = 0
        For i = 1 To word.Length
            If Mid(word, i, 1) = U.Text Then
                lettercount = lettercount + 1
                Mid(TextBox1.Text, i, 1) = U.Text
            End If
        Next

        If lettercount < 1 Then
            MsgBox("La letra no esta en esta palabra")
            chance = chance - 1
            If chance = 0 Then
                MsgBox("Fin del Juego" & Chr(13) & "La palabra era: " & word, MsgBoxStyle.Critical)
                GroupBox1.Enabled = False

            End If
        End If
        U.Enabled = False
        Label3.Text = chance
        If TextBox1.Text = word Then
            If MsgBox("Felicitaciones. . ." & "Lo has logrado", MsgBoxStyle.Information) = MsgBoxResult.Ok Then
                Me.Close()
                GIVE_WORD.Show()
            End If
        End If
    End Sub

    Private Sub V_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles V.Click
        TextBox2.Text = TextBox2.Text & "V"
        Dim i As Integer
        Dim lettercount As Integer = 0
        For i = 1 To word.Length
            If Mid(word, i, 1) = V.Text Then
                lettercount = lettercount + 1
                Mid(TextBox1.Text, i, 1) = V.Text
            End If
        Next

        If lettercount < 1 Then
            MsgBox("La letra no esta en esta palabra")
            chance = chance - 1
            If chance = 0 Then
                MsgBox("Fin del Juego" & Chr(13) & "La palabra era: " & word, MsgBoxStyle.Critical)
                GroupBox1.Enabled = False

            End If
        End If
        V.Enabled = False
        Label3.Text = chance
        If TextBox1.Text = word Then
            If MsgBox("Felicitaciones. . ." & "Lo has logrado", MsgBoxStyle.Information) = MsgBoxResult.Ok Then
                Me.Close()
                GIVE_WORD.Show()
            End If
        End If
    End Sub

    Private Sub W_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles W.Click
        TextBox2.Text = TextBox2.Text & "W"
        Dim i As Integer
        Dim lettercount As Integer = 0
        For i = 1 To word.Length
            If Mid(word, i, 1) = W.Text Then
                lettercount = lettercount + 1
                Mid(TextBox1.Text, i, 1) = W.Text
            End If
        Next

        If lettercount < 1 Then
            MsgBox("La letra no esta en esta palabra")
            chance = chance - 1
            If chance = 0 Then
                MsgBox("Fin del Juego" & Chr(13) & "La palabra era: " & word, MsgBoxStyle.Critical)
                GroupBox1.Enabled = False

            End If
        End If
        W.Enabled = False
        Label3.Text = chance
        If TextBox1.Text = word Then
            If MsgBox("Felicitaciones. . ." & "Lo has logrado", MsgBoxStyle.Information) = MsgBoxResult.Ok Then
                Me.Close()
                GIVE_WORD.Show()
            End If
        End If
    End Sub

    Private Sub X_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles X.Click
        TextBox2.Text = TextBox2.Text & "X"
        Dim i As Integer
        Dim lettercount As Integer = 0
        For i = 1 To word.Length
            If Mid(word, i, 1) = X.Text Then
                lettercount = lettercount + 1
                Mid(TextBox1.Text, i, 1) = X.Text
            End If
        Next

        If lettercount < 1 Then
            MsgBox("La letra no esta en esta palabra")
            chance = chance - 1
            If chance = 0 Then
                MsgBox("Fin del Juego" & Chr(13) & "La palabra era: " & word, MsgBoxStyle.Critical)
                GroupBox1.Enabled = False

            End If
        End If
        X.Enabled = False
        Label3.Text = chance
        If TextBox1.Text = word Then
            If MsgBox("Felicitaciones. . ." & "Lo has logrado", MsgBoxStyle.Information) = MsgBoxResult.Ok Then
                Me.Close()
                GIVE_WORD.Show()
            End If
        End If
    End Sub

    Private Sub Y_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Y.Click
        TextBox2.Text = TextBox2.Text & "Y"
        Dim i As Integer
        Dim lettercount As Integer = 0
        For i = 1 To word.Length
            If Mid(word, i, 1) = Y.Text Then
                lettercount = lettercount + 1
                Mid(TextBox1.Text, i, 1) = Y.Text
            End If
        Next

        If lettercount < 1 Then
            MsgBox("La letra no esta en esta palabra")
            chance = chance - 1
            If chance = 0 Then
                MsgBox("Fin del Juego" & Chr(13) & "La palabra era: " & word, MsgBoxStyle.Critical)
                GroupBox1.Enabled = False

            End If
        End If
        Y.Enabled = False
        Label3.Text = chance
        If TextBox1.Text = word Then
            If MsgBox("Felicitaciones. . ." & "Lo has logrado", MsgBoxStyle.Information) = MsgBoxResult.Ok Then
                Me.Close()
                GIVE_WORD.Show()
            End If
        End If

    End Sub

    Private Sub Z_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Z.Click
        TextBox2.Text = TextBox2.Text & "Z"
        Dim i As Integer
        Dim lettercount As Integer = 0
        For i = 1 To word.Length
            If Mid(word, i, 1) = Z.Text Then
                lettercount = lettercount + 1
                Mid(TextBox1.Text, i, 1) = Z.Text
            End If
        Next

        If lettercount < 1 Then
            MsgBox("La letra no esta en esta palabra")
            chance = chance - 1
            If chance = 0 Then
                MsgBox("Fin del Juego" & Chr(13) & "La palabra era: " & word, MsgBoxStyle.Critical)
                GroupBox1.Enabled = False

            End If
        End If
        Z.Enabled = False
        Label3.Text = chance
        If TextBox1.Text = word Then
            If MsgBox("Felicitaciones. . ." & "Lo has logrado", MsgBoxStyle.Information) = MsgBoxResult.Ok Then
                Me.Close()
                GIVE_WORD.Show()
            End If
        End If
    End Sub

    

    Private Sub Label3_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label3.TextChanged
        
        If Label3.Text = 8 Then
            PictureBox1.Image = My.Resources.BLANCO
        ElseIf Label3.Text = 7 Then
            PictureBox1.Image = My.Resources.ahor1_1
        ElseIf Label3.Text = 6 Then
            PictureBox1.Image = My.Resources.ahor2_1
        ElseIf Label3.Text = 5 Then
            PictureBox1.Image = My.Resources.ahor2_2
        ElseIf Label3.Text = 4 Then
            PictureBox1.Image = My.Resources.ahor2_3
        ElseIf Label3.Text = 3 Then
            PictureBox1.Image = My.Resources.ahor2_4
        ElseIf Label3.Text = 2 Then
            PictureBox1.Image = My.Resources.ahor2_5
        ElseIf Label3.Text = 1 Then
            PictureBox1.Image = My.Resources.ahor2_6
        ElseIf Label3.Text = 0 Then
            PictureBox1.Image = My.Resources.ahor3
            Timer1.Start()

        End If
    End Sub



    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Label6.Text = Label6.Text + 1
        If Label6.Text = 2 Then
            Timer1.Stop()
            If MsgBox(" Quieres jugar de nuevo? ", MsgBoxStyle.YesNo, "Fin del juego") = MsgBoxResult.Yes Then
                Me.Close()
                GIVE_WORD.Text = GIVE_WORD.Text & ":" & " Pruebe con otras palabras "
                GIVE_WORD.Show()
            Else
                Me.Close()
               

            End If

        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        GIVE_WORD.Close()

    End Sub
End Class
