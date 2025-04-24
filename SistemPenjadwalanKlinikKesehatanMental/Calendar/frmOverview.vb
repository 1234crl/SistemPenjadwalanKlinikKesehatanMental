Imports System.Globalization

Public Class frmOverview
    'MASIH SALAHHHH

    Public _year As Integer
    Public _month As Integer
    Public maxLineWidth As Integer = 500
    Public currentLineWidth As Integer = 0
    Public totalWeek As Integer = 7
    Public count As Integer = 1


    Public Sub New()
        InitializeComponent()

    End Sub

    Sub showDays(month As Integer, year As Integer)
        flowPanelCalendar.Controls.Clear()
        _month = month
        _year = year

        Dim monthName As String = New DateTimeFormatInfo().GetMonthName(month)
        lbMonth.Text = monthName.ToUpper() + " " + year.ToString()
        Dim startOfTheMonth As DateTime = New DateTime(year, month, 1)
        Dim day As Integer = DateTime.DaysInMonth(year, month)
        Dim week As Integer = Convert.ToInt32(startOfTheMonth.DayOfWeek.ToString("d"))

        flowPanelCalendar.WrapContents = True
        flowPanelCalendar.FlowDirection = FlowDirection.LeftToRight

        For i As Integer = 0 To week - 1
            Dim uc As New ucDays("")
            flowPanelCalendar.Controls.Add(uc)
        Next

        ' Menambahkan kontrol untuk setiap hari dalam bulan
        For i As Integer = 1 To day
            Dim uc As New ucDays(i.ToString()) ' Kontrol untuk setiap hari
            flowPanelCalendar.Controls.Add(uc)

            ' Memulai baris baru setelah 7 kontrol
            If (i + week) Mod 7 = 0 Then
                flowPanelCalendar.SetFlowBreak(uc, True)
            Else
                flowPanelCalendar.SetFlowBreak(uc, False)
            End If
        Next

        ' Placeholder untuk hari kosong setelah akhir bulan (jika ada)
        Dim remainingDays As Integer = (7 - ((day + week) Mod 7)) Mod 7
        For i As Integer = 1 To remainingDays
            Dim uc As New ucDays("") ' Kontrol kosong untuk hari setelah akhir bulan
            flowPanelCalendar.Controls.Add(uc)
        Next


        'For i As Integer = 1 To week
        '    Dim uc As ucDays = New ucDays("")
        '    flowPanelCalendar.Controls.Add(uc)

        '    If uc.Width > maxLineWidth Then
        '        flowPanelCalendar.SetFlowBreak(uc, True)
        '    Else
        '        flowPanelCalendar.SetFlowBreak(uc, False)
        '    End If
        'Next


        'For i As Integer = 1 To day
        '    Dim uc As ucDays = New ucDays(i.ToString())
        '    flowPanelCalendar.Controls.Add(uc)

        '    currentLineWidth += uc.Width + uc.Margin.Horizontal

        '    If currentLineWidth >= maxLineWidth Then
        '        flowPanelCalendar.SetFlowBreak(uc, True)
        '        currentLineWidth = 0
        '    Else
        '        flowPanelCalendar.SetFlowBreak(uc, False)
        '    End If
        'Next

    End Sub


    Private Sub frmOverview_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        showDays(DateTime.Now.Month, DateTime.Now.Year)
    End Sub

    Private Sub pbBefore_Click(sender As Object, e As EventArgs) Handles pbBefore.Click
        _month -= 1
        If _month < 1 Then
            _month = 12
            _year -= 1
        End If
        showDays(_month, _year)

    End Sub

    Private Sub pbAfter_Click(sender As Object, e As EventArgs) Handles pbAfter.Click
        _month += 1
        If _month > 12 Then
            _month = 1
            _year += 1
        End If
        showDays(_month, _year)
    End Sub
End Class