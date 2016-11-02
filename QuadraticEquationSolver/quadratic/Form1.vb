Public Class Form1
    Dim D As Double
    Dim A As Integer = 1
    Dim B As Integer = 1
    Dim C As Integer = 1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        A = CInt(TextBox1.Text)
        B = CInt(TextBox2.Text)
        C = CInt(TextBox3.Text)
        D = CDbl(B * B - 4 * A * C)
        If D > 0.0 Then
            Label5.Text = (CDbl(-B) + Math.Sqrt(D)) / CDbl(2 * A)
            Label6.Text = (CDbl(-B) - Math.Sqrt(D)) / CDbl(2 * A)
        ElseIf D = 0 Then
            Label5.Text = CDbl(-B) / CDbl(2 * A)
            Label6.Text = CDbl(-B) / CDbl(2 * A)
        Else
            Dim real As Double
            Dim imag As Double
            real = CDbl(-B) / CDbl(2 * A)
            imag = Math.Sqrt(-D) / CDbl(2 * A)
            imag = Math.Round(imag, 6)
            real = Math.Round(real, 6)

            Label5.Text = CStr(real) + "+" + CStr(imag) + "i"
            Label6.Text = CStr(real) + "-" + CStr(imag) + "i"
        End If
    End Sub
End Class
