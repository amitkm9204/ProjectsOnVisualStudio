Public Class Form1
    Dim month As Integer
    Dim year As Integer
    Dim day As Integer
    Dim odd As Integer
    Dim month_days(12) As Integer
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        year += 1
        Call month_cal()
        Call year_cal()
        Call cal_odd_days()
        Call day_cal()
        Call display_days()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        year -= 1
        Call month_cal()
        Call year_cal()
        Call cal_odd_days()
        Call day_cal()
        Call display_days()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        month += 1
        If month > 12 Then
            month = 1
            year += 1
        End If
        Call month_cal()
        Call year_cal()
        Call cal_odd_days()
        Call day_cal()
        Call display_days()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        month -= 1
        If month < 1 Then
            month = 12
            year -= 1
        End If

        Call month_cal()
        Call year_cal()
        Call cal_odd_days()
        Call day_cal()
        Call display_days()
    End Sub

    Private Sub month_cal()
        month_days(0) = 0
        month_days(1) = 31
        month_days(2) = 28
        month_days(3) = 31
        month_days(4) = 30
        month_days(5) = 31
        month_days(6) = 30
        month_days(7) = 31
        month_days(8) = 31
        month_days(9) = 30
        month_days(10) = 31
        month_days(11) = 30
        month_days(12) = 31
        If year Mod 4 = 0 Then
            If year Mod 400 = 0 Then
                month_days(2) = 29
            ElseIf year Mod 100 = 0 Then
                month_days(2) = 28
            Else
                month_days(2) = 29
            End If
        Else
            month_days(2) = 28
        End If
        If month = 1 Then
            Label5.Text = " January "
            Label2.Text = day & " Jan " & year
        ElseIf month = 2 Then
            Label5.Text = " February "
            Label2.Text = day & " Feb " & year
        ElseIf month = 3 Then
            Label5.Text = " March "
            Label2.Text = day & " Mar " & year
        ElseIf month = 4 Then
            Label5.Text = " April "
            Label2.Text = day & " Apr " & year
        ElseIf month = 5 Then
            Label5.Text = " May "
            Label2.Text = day & " May " & year
        ElseIf month = 6 Then
            Label5.Text = " June "
            Label2.Text = day & " Jun " & year
        ElseIf month = 7 Then
            Label5.Text = " July "
            Label2.Text = day & " Jul " & year
        ElseIf month = 8 Then
            Label5.Text = " August "
            Label2.Text = day & " Aug " & year
        ElseIf month = 9 Then
            Label5.Text = " September "
            Label2.Text = day & " Sep " & year
        ElseIf month = 10 Then
            Label5.Text = " October "
            Label2.Text = day & " Oct " & year
        ElseIf month = 11 Then
            Label5.Text = " November "
            Label2.Text = day & " Nov " & year
        ElseIf month = 12 Then
            Label5.Text = " December "
            Label2.Text = day & " Dec " & year
        End If
    End Sub
    Private Sub year_cal()
        Label6.Text = year
    End Sub
    Private Sub day_cal()
        Dim dd As Integer = odd
        dd = odd + day
        If dd Mod 7 = 0 Then
            Label1.Text = "Sunday,"
        ElseIf dd Mod 7 = 1 Then
            Label1.Text = "Monday,"
        ElseIf dd Mod 7 = 2 Then
            Label1.Text = "Tuesday,"
        ElseIf dd Mod 7 = 3 Then
            Label1.Text = "Wednesday,"
        ElseIf dd Mod 7 = 4 Then
            Label1.Text = "Thursday,"
        ElseIf dd Mod 7 = 5 Then
            Label1.Text = "Friday,"
        ElseIf dd Mod 7 = 6 Then
            Label1.Text = "Saturday,"
        End If
    End Sub
    Private Sub cal_odd_days()
        Dim d, m, y As Integer
        odd = 0
        d = day
        m = month - 1
        y = year - 1
        y = y Mod 400
        If y >= 300 Then
            odd += 1
            y = y Mod 300
        ElseIf y >= 200 Then
            odd += 3
            y = y Mod 200
        ElseIf y >= 100 Then
            odd += 5
            y = y Mod 100
        End If
        odd = odd + y \ 4 + y
        odd = odd Mod 7
        Do While m > 0
            odd += month_days(m)
            m -= 1
        Loop
        odd = odd Mod 7
    End Sub
    Private Sub system_date()
        Dim value As Date = Date.Now.Date
        Dim dayString As String = value.Day.ToString()
        Dim monthString As String = value.Month.ToString()
        Dim yearString As String = value.Year.ToString()
        day = dayString
        month = monthString
        year = yearString
    End Sub
    Private Sub display_days()
        Dim odd_t As Integer = odd + 1
        Label13.Text = 6 - odd_t + 1
        Label14.Text = 6 - odd_t + 2
        Label15.Text = 6 - odd_t + 3
        Label16.Text = 6 - odd_t + 4
        Label17.Text = 6 - odd_t + 5
        Label18.Text = 6 - odd_t + 6
        Label19.Text = 6 - odd_t + 7
        Label20.Text = 6 - odd_t + 8
        Label21.Text = 6 - odd_t + 9
        Label22.Text = 6 - odd_t + 10
        Label23.Text = 6 - odd_t + 11
        Label24.Text = 6 - odd_t + 12
        Label25.Text = 6 - odd_t + 13
        Label26.Text = 6 - odd_t + 14
        Label27.Text = 6 - odd_t + 15
        Label28.Text = 6 - odd_t + 16
        Label29.Text = 6 - odd_t + 17
        Label30.Text = 6 - odd_t + 18
        Label31.Text = 6 - odd_t + 19
        Label32.Text = 6 - odd_t + 20
        Label33.Text = 6 - odd_t + 21
        Label34.Text = 6 - odd_t + 22
        If odd_t = 0 Then
            Label7.Text = 1
            Label8.Text = 2
            Label9.Text = 3
            Label10.Text = 4
            Label11.Text = 5
            Label12.Text = 6
            Label35.Text = ""
            Label36.Text = ""
            Label37.Text = ""
            Label38.Text = ""
            Label39.Text = ""
            Label40.Text = ""
            Label41.Text = ""
            If month_days(month) = 29 Then
                Label35.Text = 29
            ElseIf month_days(month) = 30 Then
                Label36.Text = 30
                Label35.Text = 29
            ElseIf month_days(month) = 31 Then
                Label37.Text = 31
                Label36.Text = 30
                Label35.Text = 29
            End If
        ElseIf odd_t = 1 Then
            Label7.Text = ""
            Label8.Text = 1
            Label9.Text = 2
            Label10.Text = 3
            Label11.Text = 4
            Label12.Text = 5
            Label35.Text = 28
            Label36.Text = ""
            Label37.Text = ""
            Label38.Text = ""
            Label39.Text = ""
            Label40.Text = ""
            Label41.Text = ""
            If month_days(month) = 29 Then
                Label36.Text = 29
            ElseIf month_days(month) = 30 Then
                Label37.Text = 30
                Label36.Text = 29
            ElseIf month_days(month) = 31 Then
                Label38.Text = 31
                Label37.Text = 30
                Label36.Text = 29
            End If
        ElseIf odd_t = 2 Then
            Label7.Text = ""
            Label8.Text = ""
            Label9.Text = 1
            Label10.Text = 2
            Label11.Text = 3
            Label12.Text = 4
            Label35.Text = 27
            Label36.Text = 28
            Label37.Text = ""
            Label38.Text = ""
            Label39.Text = ""
            Label40.Text = ""
            Label41.Text = ""
            If month_days(month) = 29 Then
                Label37.Text = 29
            ElseIf month_days(month) = 30 Then
                Label37.Text = 29
                Label38.Text = 30
            ElseIf month_days(month) = 31 Then
                Label39.Text = 31
                Label37.Text = 29
                Label38.Text = 30
            End If
        ElseIf odd_t = 3 Then
            Label7.Text = ""
            Label8.Text = ""
            Label9.Text = ""
            Label10.Text = 1
            Label11.Text = 2
            Label12.Text = 3
            Label35.Text = 26
            Label36.Text = 27
            Label37.Text = 28
            Label38.Text = ""
            Label39.Text = ""
            Label40.Text = ""
            Label41.Text = ""
            If month_days(month) = 29 Then
                Label38.Text = 29
            ElseIf month_days(month) = 30 Then
                Label38.Text = 29
                Label39.Text = 30
            ElseIf month_days(month) = 31 Then
                Label40.Text = 31
                Label38.Text = 29
                Label39.Text = 30
            End If
        ElseIf odd_t = 4 Then
            Label7.Text = ""
            Label8.Text = ""
            Label9.Text = ""
            Label10.Text = ""
            Label11.Text = 1
            Label12.Text = 2
            Label35.Text = 25
            Label36.Text = 26
            Label37.Text = 27
            Label38.Text = 28
            Label39.Text = ""
            Label40.Text = ""
            Label41.Text = ""
            If month_days(month) = 29 Then
                Label39.Text = 29
            ElseIf month_days(month) = 30 Then
                Label39.Text = 29
                Label40.Text = 30
            ElseIf month_days(month) = 31 Then
                Label41.Text = 31
                Label39.Text = 29
                Label40.Text = 30
            End If
        ElseIf odd_t = 5 Then
            Label7.Text = ""
            Label8.Text = ""
            Label9.Text = ""
            Label10.Text = ""
            Label11.Text = ""
            Label12.Text = 1
            Label35.Text = 24
            Label36.Text = 25
            Label37.Text = 26
            Label38.Text = 27
            Label39.Text = 28
            Label40.Text = ""
            Label41.Text = ""
            If month_days(month) = 29 Then
                Label40.Text = 29
            ElseIf month_days(month) = 30 Then
                Label40.Text = 29
                Label41.Text = 30
            ElseIf month_days(month) = 31 Then
                Label7.Text = 31
                Label40.Text = 29
                Label41.Text = 30
            End If
        ElseIf odd_t = 6 Then
            Label7.Text = ""
            Label8.Text = ""
            Label9.Text = ""
            Label10.Text = ""
            Label11.Text = ""
            Label12.Text = ""
            Label35.Text = 23
            Label36.Text = 24
            Label37.Text = 25
            Label38.Text = 26
            Label39.Text = 27
            Label40.Text = 28
            Label41.Text = ""
            If month_days(month) = 29 Then
                Label41.Text = 29
            ElseIf month_days(month) = 30 Then
                Label41.Text = 29
                Label7.Text = 30
            ElseIf month_days(month) = 31 Then
                Label8.Text = 31
                Label41.Text = 29
                Label7.Text = 30
            End If
        End If

    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call system_date()
        Call month_cal()
        Call year_cal()
        Call cal_odd_days()
        Call day_cal()
        Call display_days()
        Label42.Enabled = False
        Label43.Enabled = False
        Label44.Enabled = False
        Label45.Enabled = False
        Label46.Enabled = False
        Label47.Enabled = False
        Label48.Enabled = False
    End Sub


End Class
