Imports System.Runtime.CompilerServices

Public Class ucDays

    Dim _day As String
    Dim _date As String
    Dim _weekDay As String

    Public Sub New(day As String)
        InitializeComponent()
        _day = day
        lbDay.Text = day
        cbDay.Hide()
        'Dim currentDate As Integer = frmOverview._month + "/" + _day.ToString() + frmOverview._year
    End Sub

    Private Sub sundays()
        Try
            Dim day As DateTime = DateTime.Parse(_date)
            _weekDay = day.ToString("ddd")
            If _weekDay = "Sun" Then
                lbDay.ForeColor = Color.FromArgb(255, 128, 128)
            Else
                lbDay.ForeColor = Color.Black
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ucDays_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sundays()
    End Sub

    Private Sub Panel1_Click(sender As Object, e As EventArgs) Handles Panel1.Click
        If cbDay.Checked = False Then
            cbDay.Checked = True
            Me.BackColor = Color.FromArgb(255, 150, 79)
        Else
            cbDay.Checked = False
            Me.BackColor = Color.White
        End If
    End Sub
End Class
