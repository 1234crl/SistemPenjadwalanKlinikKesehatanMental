Public Class frmBookingDetail
    Dim myparent As frmUpcomingSchedule

    Dim booking As New Booking
    Dim detailBooking As New DetailBooking

    Public Sub New(myParent As frmUpcomingSchedule, booking As Booking, detailBooking As DetailBooking)
        InitializeComponent()
        Me.myparent = myParent

        Me.booking = booking
        Me.detailBooking = detailBooking

        tbID.Text = booking.IdBooking
        tbDokter.Text = detailBooking.NamaDokter
        tbPasien.Text = detailBooking.NamaPasien
        tbDurasi.Text = detailBooking.Durasi.ToString()
        tbLayanan.Text = booking.JenisStr
        tbJam.Text = detailBooking.Jam
        dtpTglSesi.Value = DateTime.Parse(detailBooking.TglSesi)
        dtpTglBooking.Value = DateTime.Parse(booking.TglBooking)

        If detailBooking.StatusStr = "Currently Running" Then
            rbStatusRun.Checked = True
            rbStatusBook.Checked = False
        Else
            rbStatusRun.Checked = False
            rbStatusBook.Checked = True
        End If


    End Sub


    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Close()
    End Sub
End Class