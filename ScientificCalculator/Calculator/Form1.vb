Public Class Form1
    Dim temp As String = ""
    Dim first As Double = 0
    Dim second As Double = 0
    Dim op As String
    Dim tempop As Double
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        temp = TextBox1.Text
        If temp = "0" Or temp = "+" Or temp = "-" Or temp = "*" Or temp = "/" Then
            TextBox1.Text = "0"
        Else
            TextBox1.Text = temp + "0"
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        temp = TextBox1.Text
        If temp = "0" Or temp = "+" Or temp = "-" Or temp = "*" Or temp = "/" Then
            TextBox1.Text = "1"
        Else
            TextBox1.Text = temp + "1"
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        temp = TextBox1.Text
        If temp = "0" Or temp = "+" Or temp = "-" Or temp = "*" Or temp = "/" Then
            TextBox1.Text = "2"
        Else
            TextBox1.Text = temp + "2"
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        temp = TextBox1.Text
        If temp = "0" Or temp = "+" Or temp = "-" Or temp = "*" Or temp = "/" Then
            TextBox1.Text = "3"
        Else
            TextBox1.Text = temp + "3"
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        temp = TextBox1.Text
        If temp = "0" Or temp = "+" Or temp = "-" Or temp = "*" Or temp = "/" Then
            TextBox1.Text = "4"
        Else
            TextBox1.Text = temp + "4"
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        temp = TextBox1.Text
        If temp = "0" Or temp = "+" Or temp = "-" Or temp = "*" Or temp = "/" Then
            TextBox1.Text = "5"
        Else
            TextBox1.Text = temp + "5"
        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        temp = TextBox1.Text
        If temp = "0" Or temp = "+" Or temp = "-" Or temp = "*" Or temp = "/" Then
            TextBox1.Text = "6"
        Else
            TextBox1.Text = temp + "6"
        End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        temp = TextBox1.Text
        If temp = "0" Or temp = "+" Or temp = "-" Or temp = "*" Or temp = "/" Then
            TextBox1.Text = "7"
        Else
            TextBox1.Text = temp + "7"
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        temp = TextBox1.Text
        If temp = "0" Or temp = "+" Or temp = "-" Or temp = "*" Or temp = "/" Then
            TextBox1.Text = "8"
        Else
            TextBox1.Text = temp + "8"
        End If
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        temp = TextBox1.Text
        If temp = "0" Or temp = "+" Or temp = "-" Or temp = "*" Or temp = "/" Then
            TextBox1.Text = "9"
        Else
            TextBox1.Text = temp + "9"
        End If
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        temp = TextBox1.Text
        If temp = "0" Or temp = "+" Or temp = "-" Or temp = "*" Or temp = "/" Then
            TextBox1.Text = "0."
        Else
            TextBox1.Text = temp + "."
        End If
        Button11.Enabled = False
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        TextBox1.Text = "0"
        Button11.Enabled = True
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        first = CDbl(TextBox1.Text)
        TextBox1.Text = "+"
        op = "+"
        Button11.Enabled = True
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        first = CDbl(TextBox1.Text)
        TextBox1.Text = "-"
        op = "-"
        Button11.Enabled = True
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        first = CDbl(TextBox1.Text)
        TextBox1.Text = "*"
        op = "*"
        Button11.Enabled = True
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        first = CDbl(TextBox1.Text)
        TextBox1.Text = "/"
        op = "/"
        Button11.Enabled = True
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        first = CDbl(TextBox1.Text)
        TextBox1.Text = 1 / first
        Button11.Enabled = True
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        second = CDbl(TextBox1.Text)
        If op = "+" Then
            TextBox1.Text = first + second
        ElseIf op = "-" Then
            If first > second Then
                tempop = first - second
                TextBox1.Text = tempop
            Else
                tempop = second - first
                TextBox1.Text = "-" + CStr(tempop)
            End If
            'MsgBox(tempop)
        ElseIf op = "*" Then
            TextBox1.Text = first * second
        ElseIf op = "/" Then
            If second = 0 Then
                TextBox1.Text = "Error"
            Else
                TextBox1.Text = first / second
            End If

        End If
        Button11.Enabled = True

    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        first = CDbl(TextBox1.Text)
        TextBox1.Text = Math.Log10(first)
        Button11.Enabled = True
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        first = CDbl(TextBox1.Text)
        TextBox1.Text = Math.Sin(first)
        Button11.Enabled = True
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        first = CDbl(TextBox1.Text)
        TextBox1.Text = Math.Cos(first)
        Button11.Enabled = True
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        first = CDbl(TextBox1.Text)
        TextBox1.Text = Math.Tan(first)
        Button11.Enabled = True
    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        first = CDbl(TextBox1.Text)
        TextBox1.Text = Math.Sqrt(first)
        Button11.Enabled = True
    End Sub
End Class
