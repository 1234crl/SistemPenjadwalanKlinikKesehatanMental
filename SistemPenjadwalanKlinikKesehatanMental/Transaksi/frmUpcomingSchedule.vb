Public Class frmUpcomingSchedule
    Dim DTDokter As DataTable
    Dim DTBookingAktif As DataTable
    Dim currentStatus As Integer

    Dim booking As New Booking
    Dim detailBooking As New DetailBooking

    Dim fDetailBooking As frmBookingDetail
    Dim IdDokter As Integer
    Public Sub New(IdDokter As Integer)
        InitializeComponent()

        Me.IdDokter = IdDokter

        DTDokter = My.Application.DBA.DokterListAktif()
        If IdDokter <> 0 Then

            With cbDokter
                .DataSource = DTDokter
                .DisplayMember = "NamaDokter"
                .ValueMember = "IdDokter"
                .SelectedValue = IdDokter
                .Enabled = False
            End With

        Else
            Dim DRow As DataRow = DTDokter.NewRow()
            DRow("IdDokter") = 0
            DRow("NamaDokter") = "Show All"
            DTDokter.Rows.Add(DRow)

            With cbDokter
                .DataSource = DTDokter
                .DisplayMember = "NamaDokter"
                .ValueMember = "IdDokter"
                .SelectedValue = 0
            End With

        End If

        With cbStatus
            .SelectedIndex = 2
        End With

        If cbStatus.SelectedIndex = 2 Then
            currentStatus = -1
        Else
            currentStatus = cbStatus.SelectedIndex
        End If

        DTBookingAktif = My.Application.DBA.BookingListAktif(cbDokter.SelectedValue, currentStatus)
        dgvBooking.DataSource = DTBookingAktif

    End Sub

    Private Sub cbDokter_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbDokter.SelectionChangeCommitted
        RefreshData()
    End Sub



    Public Sub RefreshData()

        If cbStatus.SelectedIndex = 2 Then
            currentStatus = -1
        Else
            currentStatus = cbStatus.SelectedIndex
        End If

        DTBookingAktif = My.Application.DBA.BookingListAktif(cbDokter.SelectedValue, currentStatus)
        dgvBooking.DataSource = DTBookingAktif
    End Sub

    Private Sub dgvBooking_MouseDown(sender As Object, e As MouseEventArgs) Handles dgvBooking.MouseDown
        If e.Button = MouseButtons.Right Then
            Dim HT As DataGridView.HitTestInfo
            HT = dgvBooking.HitTest(e.X, e.Y)
            If HT.Type = DataGridViewHitTestType.Cell Then

                booking = New Booking
                detailBooking = New DetailBooking

                booking.IdBooking = dgvBooking.Item("IdBookingCol", HT.RowIndex).Value
                booking.TglBooking = dgvBooking.Item("TglBookingCol", HT.RowIndex).Value
                booking.JenisStr = dgvBooking.Item("JenisLayananStrCol", HT.RowIndex).Value

                detailBooking.IdDetailBooking = dgvBooking.Item("IdDetailBookingCol", HT.RowIndex).Value
                detailBooking.TglSesi = dgvBooking.Item("TglSesiCol", HT.RowIndex).Value
                detailBooking.Jam = dgvBooking.Item("JamCol", HT.RowIndex).Value.ToString()
                detailBooking.Durasi = dgvBooking.Item("DurasiCol", HT.RowIndex).Value
                detailBooking.StatusStr = dgvBooking.Item("StatusCol", HT.RowIndex).Value
                detailBooking.NamaDokter = dgvBooking.Item("NamaDokterCol", HT.RowIndex).Value
                detailBooking.NamaPasien = dgvBooking.Item("NamaPasienCol", HT.RowIndex).Value

                dgvBooking.Rows(HT.RowIndex).Selected = True
                dgvBooking.ContextMenuStrip = cmDetail
            Else
                dgvBooking.ContextMenuStrip = Nothing
            End If
        Else
            dgvBooking.ContextMenuStrip = Nothing
        End If

    End Sub

    Private Sub cbStatus_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbStatus.SelectionChangeCommitted
        RefreshData()
    End Sub

    Private Sub DetailToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DetailToolStripMenuItem.Click
        If (fDetailBooking Is Nothing) Then
            fDetailBooking = New frmBookingDetail(Me, booking, detailBooking)
            AddHandler fDetailBooking.FormClosed, AddressOf frmBookingDetail_FormClosed
            fDetailBooking.MdiParent = MainPage
            fDetailBooking.Dock = DockStyle.Fill
            fDetailBooking.Show()
        Else
            fDetailBooking.Activate()
        End If

    End Sub

    Private Sub frmBookingDetail_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        fDetailBooking = Nothing
    End Sub

    Private Sub UpdateStatusToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateStatusToolStripMenuItem.Click
        Dim fUpdateStatusTransaksi As New frmUpdateStatusTransaksi(Me, detailBooking)
        fUpdateStatusTransaksi.Show()
    End Sub
End Class