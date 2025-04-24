Public Class frmUpdateStatusTransaksi
    Dim myParent As New frmUpcomingSchedule(0)
    Dim detailBooking As New DetailBooking
    Dim statusInt As Integer

    Public Sub New(myParent As frmUpcomingSchedule, detailBooking As DetailBooking)
        InitializeComponent()
        Me.myParent = myParent
        Me.detailBooking = detailBooking

        tbID.Text = detailBooking.IdDetailBooking
        cbStatus.SelectedItem = detailBooking.StatusStr
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim hasil As New Integer

        If cbStatus.SelectedItem = "Cancelled" Then
            statusInt = -2
        ElseIf cbStatus.SelectedItem = "Still in Booked" Then
            statusInt = 0
        ElseIf cbStatus.SelectedItem = "Currently Running" Then
            statusInt = 1
        ElseIf cbStatus.SelectedItem = "Completed" Then
            statusInt = 2
        End If
        'MessageBox.Show("Status has been updated.", statusInt.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Information)

        hasil = My.Application.DBA.UpdateStatusBooking(detailBooking.IdDetailBooking, statusInt)

        If hasil = 1 Then
            MessageBox.Show("Status has been updated.", "Succeed", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Something went wrong. Please try again.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

        Close()
        myParent.RefreshData()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub
End Class