Public Class About

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Main.Enabled = False And Main.Visible = True Then
            Main.Enabled = True
            Me.Hide()
        Else
            Main.Show()
            Me.Hide()
        End If
    End Sub
End Class