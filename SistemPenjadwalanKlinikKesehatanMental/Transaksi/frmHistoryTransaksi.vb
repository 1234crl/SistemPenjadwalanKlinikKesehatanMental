Public Class frmHistoryTransaksi
    Dim DTDokter As DataTable
    Dim DTBookingAktif As DataTable
    Dim currentStatus As Integer

    Dim booking As New Booking
    Dim detailBooking As New DetailBooking

    Dim fDetailHistory As frmHistoryDetail
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
            If cbStatus.SelectedIndex = 0 Then
                currentStatus = -2
            Else
                currentStatus = 2
            End If
        End If

        DTBookingAktif = My.Application.DBA.BookingListComplete(cbDokter.SelectedValue, currentStatus)
        dgvBooking.DataSource = DTBookingAktif
        RefreshData()
    End Sub

    Private Sub RefreshData()

        If cbStatus.SelectedIndex = 2 Then
            currentStatus = -1
        Else
            If cbStatus.SelectedIndex = 0 Then
                currentStatus = -2
            Else
                currentStatus = 2
            End If

        End If

        DTBookingAktif = My.Application.DBA.BookingListComplete(cbDokter.SelectedValue, currentStatus)
        dgvBooking.DataSource = DTBookingAktif
    End Sub



    Private Sub cbDokter_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbDokter.SelectionChangeCommitted
        RefreshData()
    End Sub

    Private Sub cbStatus_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbStatus.SelectionChangeCommitted
        RefreshData()
    End Sub

    Private Sub ViewDetailToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewDetailToolStripMenuItem.Click
        If (fDetailHistory Is Nothing) Then
            fDetailHistory = New frmHistoryDetail(Me, booking, detailBooking)
            AddHandler fDetailHistory.FormClosed, AddressOf frmHistoryDetail_FormClosed
            fDetailHistory.MdiParent = MainPage
            fDetailHistory.Dock = DockStyle.Fill
            fDetailHistory.Show()
        Else
            fDetailHistory.Activate()
        End If
    End Sub

    Private Sub frmHistoryDetail_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        fDetailHistory = Nothing
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

    Private Sub btnReport_Click(sender As Object, e As EventArgs) Handles btnReport.Click
        Dim Report As New ExcelReportBooking()
        Report.Generate(DTBookingAktif)
    End Sub
End Class