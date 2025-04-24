Public Class frmHistoryDetail
    Dim myparent As frmHistoryTransaksi

    Dim booking As New Booking
    Dim detailBooking As New DetailBooking

    Public Sub New(myParent As frmHistoryTransaksi, booking As Booking, detailBooking As DetailBooking)
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

        If detailBooking.StatusStr = "Cancelled" Then
            rbStatusCancel.Checked = True
            rbStatusComplete.Checked = False
        Else
            rbStatusCancel.Checked = False
            rbStatusComplete.Checked = True
        End If

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Close()
    End Sub


End Class