Public Class Clue

    Private Sub Clue_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If local.x.Length <= 5 Then
            Clue2.Enabled = False
            Clue3.Enabled = False
            Clue4.Enabled = False
            lblclue2.Enabled = False
            lblclue3.Enabled = False
            lblclue4.Enabled = False


        ElseIf local.x.Length <= 8 And local.x.Length > 5 Then
            Clue3.Enabled = False
            Clue4.Enabled = False
            lblclue3.Enabled = False
            lblclue4.Enabled = False


        ElseIf local.x.Length <= 12 And local.x.Length > 8 Then
            Clue4.Enabled = False
            lblclue4.Enabled = False
        Else

            Clue2.Enabled = True
            Clue3.Enabled = True
            Clue4.Enabled = True
            lblclue2.Enabled = True
            lblclue3.Enabled = True
            lblclue4.Enabled = True

        End If
    End Sub

    Private Sub clue1_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles clue1.Leave
        If local.x.Length <= 8 Then
            Dim a As String
            Dim count As Integer
            Dim b As Integer
            b = 0
            count = 0
            For i = 1 To local.x.Length
                b = b + 1
                a = Mid(local.x, b, 1)
                If a = clue1.Text Then
                    count = count + 1
                    MsgBox(count)
                
                End If
            Next
            If count = 2 Then
                Clue2.Enabled = False
                local.y = count
            ElseIf count > 2 Then
                MsgBox("error :" & " You cannot give more than 2 clues for this word", MsgBoxStyle.Exclamation)
                MsgBox("Please give next clue......", MsgBoxStyle.Information)
                clue1.Clear()
            Else
                Clue2.Enabled = False
            End If
        End If

        If local.x.Length <= 12 And local.x.Length > 8 Then
            Dim a As String
            Dim count As Integer
            Dim b As Integer
            b = 0
            count = 0
            For i = 1 To local.x.Length
                b = b + 1
                a = Mid(local.x, b, 1)
                If a = clue1.Text Then
                    count = count + 1
                    MsgBox(count)

                End If
            Next
            If count = 3 Then
                Clue2.Enabled = False
                Clue3.Enabled = False
                local.y = count
            ElseIf count = 2 Then
                Clue3.Enabled = False
                local.y = count
            ElseIf count > 3 Then

                MsgBox("error :" & " You cannot give more than 2 clues for this word", MsgBoxStyle.Exclamation)
                MsgBox("Please give next clue......", MsgBoxStyle.Information)
                clue1.Clear()
            Else
                Clue2.Enabled = True
                Clue3.Enabled = True
            End If

        End If


        If local.x.Length <= 15 And local.x.Length > 12 Then
            Dim a As String
            Dim count As Integer
            Dim b As Integer
            b = 0
            count = 0
            For i = 1 To local.x.Length
                b = b + 1
                a = Mid(local.x, b, 1)
                If a = clue1.Text Then
                    count = count + 1
                    MsgBox(count)

                End If
            Next
            If count = 4 Then
                Clue2.Enabled = False
                Clue3.Enabled = False
                Clue4.Enabled = False
                local.y = count
            ElseIf count = 3 Then
                Clue2.Enabled = False
                Clue3.Enabled = False
                local.y = count
            ElseIf count = 2 Then
                Clue3.Enabled = False
                local.y = count
            ElseIf count > 4 Then

                MsgBox("error :" & " You cannot give more than 2 clues for this word", MsgBoxStyle.Exclamation)
                MsgBox("Please give next clue......", MsgBoxStyle.Information)
                clue1.Clear()
            Else
                Clue2.Enabled = True
                Clue3.Enabled = True
            End If

        End If

    End Sub


    Private Sub btnproceed_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnproceed.Click
        Form1.Show()
    End Sub

    Private Sub clue1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clue1.TextChanged

    End Sub

    Private Sub Clue2_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Clue2.Leave

    End Sub

    
End Class