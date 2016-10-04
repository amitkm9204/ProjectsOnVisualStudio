Public Class Form

    Dim turn As Integer
    Private Sub Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        turn = 1
    End Sub
    Private Sub Win()
        If Button1.Text = "X" And Button2.Text = "X" And Button3.Text = "X" Then
            MsgBox("player X wins")
            Label7.Text += 1
            Call disablebuttons()
        ElseIf Button4.Text = "X" And Button5.Text = "X" And Button6.Text = "X" Then
            MsgBox("player X wins")
            Label7.Text += 1
            Call disablebuttons()
        ElseIf Button7.Text = "X" And Button8.Text = "X" And Button9.Text = "X" Then
            MsgBox("player X wins")
            Label7.Text += 1
            Call disablebuttons()
        ElseIf Button1.Text = "X" And Button4.Text = "X" And Button7.Text = "X" Then
            MsgBox("player X wins")
            Label7.Text += 1
            Call disablebuttons()
        ElseIf Button2.Text = "X" And Button5.Text = "X" And Button8.Text = "X" Then
            MsgBox("player X wins")
            Label7.Text += 1
            Call disablebuttons()
        ElseIf Button3.Text = "X" And Button6.Text = "X" And Button9.Text = "X" Then
            MsgBox("player X wins")
            Label7.Text += 1
            Call disablebuttons()
        ElseIf Button1.Text = "X" And Button5.Text = "X" And Button9.Text = "X" Then
            MsgBox("player X wins")
            Label7.Text += 1
            Call disablebuttons()
        ElseIf Button3.Text = "X" And Button5.Text = "X" And Button7.Text = "X" Then
            MsgBox("player X wins")
            Label7.Text += 1
            Call disablebuttons()
            '' for O doing the above things
        ElseIf Button1.Text = "O" And Button2.Text = "O" And Button3.Text = "O" Then
            MsgBox("player O wins")
            Label6.Text += 1
            Call disablebuttons()
        ElseIf Button4.Text = "O" And Button5.Text = "O" And Button6.Text = "O" Then
            MsgBox("player X wins")
            Label6.Text += 1
            Call disablebuttons()
        ElseIf Button7.Text = "O" And Button8.Text = "O" And Button9.Text = "O" Then
            MsgBox("player O wins")
            Label6.Text += 1
            Call disablebuttons()
        ElseIf Button1.Text = "O" And Button4.Text = "O" And Button7.Text = "O" Then
            MsgBox("player O wins")
            Label6.Text += 1
            Call disablebuttons()
        ElseIf Button2.Text = "O" And Button5.Text = "O" And Button8.Text = "O" Then
            MsgBox("player O wins")
            Label6.Text += 1
            Call disablebuttons()
        ElseIf Button3.Text = "O" And Button6.Text = "O" And Button9.Text = "O" Then
            MsgBox("player O wins")
            Label6.Text += 1
            Call disablebuttons()
        ElseIf Button1.Text = "O" And Button5.Text = "O" And Button9.Text = "O" Then
            MsgBox("player O wins")
            Label6.Text += 1
            Call disablebuttons()
        ElseIf Button3.Text = "O" And Button5.Text = "O" And Button7.Text = "O" Then
            MsgBox("player O wins")
            Label6.Text += 1
            Call disablebuttons()
        End If
    End Sub
    Private Sub disablebuttons()
        Button1.Enabled = False
        Button2.Enabled = False
        Button3.Enabled = False
        Button4.Enabled = False
        Button5.Enabled = False
        Button9.Enabled = False
        Button6.Enabled = False
        Button7.Enabled = False
        Button8.Enabled = False
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If turn = 1 Then
            Button1.Text = "O"
            Label2.Text = "X"
        Else
            Button1.Text = "X"
            Label2.Text = "O"
        End If
        turn += 1
        If turn > 2 Then
            turn = 1
        End If
        Call Win()
        Button1.Enabled = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If turn = 1 Then
            Button2.Text = "O"
            Label2.Text = "X"
        Else
            Button2.Text = "X"
            Label2.Text = "O"
        End If
        turn += 1
        If turn > 2 Then
            turn = 1
        End If
        Call Win()
        Button2.Enabled = False
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If turn = 1 Then
            Button3.Text = "O"
            Label2.Text = "X"
        Else
            Button3.Text = "X"
            Label2.Text = "O"
        End If
        turn += 1
        If turn > 2 Then
            turn = 1
        End If
        Call Win()
        Button3.Enabled = False
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If turn = 1 Then
            Button4.Text = "O"
            Label2.Text = "X"
        Else
            Button4.Text = "X"
            Label2.Text = "O"
        End If
        turn += 1
        If turn > 2 Then
            turn = 1
        End If
        Call Win()
        Button4.Enabled = False
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If turn = 1 Then
            Button5.Text = "O"
            Label2.Text = "X"
        Else
            Button5.Text = "X"
            Label2.Text = "O"
        End If
        turn += 1
        If turn > 2 Then
            turn = 1
        End If
        Call Win()
        Button5.Enabled = False
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If turn = 1 Then
            Button6.Text = "O"
            Label2.Text = "X"
        Else
            Button6.Text = "X"
            Label2.Text = "O"
        End If
        turn += 1
        If turn > 2 Then
            turn = 1
        End If
        Call Win()
        Button6.Enabled = False
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If turn = 1 Then
            Button7.Text = "O"
            Label2.Text = "X"
        Else
            Button7.Text = "X"
            Label2.Text = "O"
        End If
        turn += 1
        If turn > 2 Then
            turn = 1
        End If
        Call Win()
        Button7.Enabled = False
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If turn = 1 Then
            Button8.Text = "O"
            Label2.Text = "X"
        Else
            Button8.Text = "X"
            Label2.Text = "O"
        End If
        turn += 1
        If turn > 2 Then
            turn = 1
        End If
        Call Win()
        Button8.Enabled = False
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If turn = 1 Then
            Button9.Text = "O"
            Label2.Text = "X"
        Else
            Button9.Text = "X"
            Label2.Text = "O"
        End If
        turn += 1
        If turn > 2 Then
            turn = 1
        End If
        Call Win()
        Button9.Enabled = False
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Button1.Text = ""
        Button1.Enabled = True
        Button2.Text = ""
        Button2.Enabled = True
        Button3.Text = ""
        Button3.Enabled = True
        Button4.Text = ""
        Button4.Enabled = True
        Button5.Text = ""
        Button5.Enabled = True
        Button6.Text = ""
        Button6.Enabled = True
        Button7.Text = ""
        Button7.Enabled = True
        Button8.Text = ""
        Button8.Enabled = True
        Button9.Text = ""
        Button9.Enabled = True
    End Sub
End Class
