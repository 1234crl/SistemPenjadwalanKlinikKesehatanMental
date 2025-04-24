Public Class frmSchedule
    Dim DTLayanan As New DataTable
    Dim DTDokter As New DataTable
    Dim DTPasien As New DataTable

    Public Sub New()
        InitializeComponent()

        DTLayanan = My.Application.DBA.DokterListLayanan()
        DTDokter = My.Application.DBA.DokterListAktif()
        DTPasien = My.Application.DBA.PasienListDetil()

        Dim DRow As DataRow = DTLayanan.NewRow()
        DRow("IdJenis") = 0
        DRow("NamaJenis") = "All Services"
        DTLayanan.Rows.Add(DRow)

        With cbLayanan
            .DataSource = DTLayanan
            .DisplayMember = "NamaJenis"
            .ValueMember = "IdJenis"
            .SelectedValue = 0
        End With

        With cbDokter
            .DataSource = DTDokter
            .DisplayMember = "NamaDokter"
            .ValueMember = "IdDokter"
            .SelectedValue = DTDokter.Rows(0)("IdDokter")
        End With


        With cbPasien
            .DataSource = DTPasien
            .DisplayMember = "NamaPasien"
            .ValueMember = "IdPasien"
            .SelectedValue = 1
        End With

        dtpTime.CustomFormat = "HH:mm"
        dtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        dtpTime.ShowUpDown = True

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim JumlahBooking As Integer = dgvSchedule.RowCount
        Dim hasil As Integer

        If JumlahBooking <> 0 Then
            For Each drow As DataGridViewRow In dgvSchedule.Rows
                If Not drow.IsNewRow Then
                    ' Ambil nilai dari DataGridView
                    Dim tglBooking = DateTime.Now()
                    Dim idDokter As Integer = Convert.ToInt32(drow.Cells("IdDokterCol").Value)
                    Dim idPasien As Integer = Convert.ToInt32(drow.Cells("IdPasienCol").Value)
                    Dim tglSesi As Date = Convert.ToString(drow.Cells("TglSesiCol").Value)
                    Dim jam As String = Convert.ToString(drow.Cells("JamCol").Value)
                    'MessageBox.Show(tglSesi)
                    Dim durasi As Integer = Convert.ToInt32(drow.Cells("DurasiCol").Value)
                    Dim jenisLayanan As Integer = Convert.ToInt32(drow.Cells("JenisIntCol").Value)
                    hasil = My.Application.DBA.BookingInsert(jenisLayanan, tglBooking, idDokter, idPasien, tglSesi,
                                                                jam, durasi, JumlahBooking)
                    If hasil = 1 Then
                        MessageBox.Show("Booking has been succesfully added.", "Succeed",
                                            MessageBoxButtons.OK, MessageBoxIcon.Information)
                        'dgvSchedule.Rows.Clear()
                    ElseIf hasil = -1 Then
                        MessageBox.Show("The doctor has conflicted scheduled. Please check again.", "Warning",
                                            MessageBoxButtons.OK, MessageBoxIcon.Error)
                    ElseIf hasil = -2 Then
                        MessageBox.Show("Something went wrong. Please try again.", "Warning",
                                            MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End If
            Next
            dgvSchedule.Rows.Clear()
        Else
            MessageBox.Show("Please add your data.", "Warning",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub dtpDate_ValueChanged(sender As Object, e As EventArgs) Handles dtpDate.ValueChanged

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub dtpTime_ValueChanged(sender As Object, e As EventArgs) Handles dtpTime.ValueChanged

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub tbDuration_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim count As Integer = dgvSchedule.RowCount
        Dim DataScheduleByDetil As New ArrayList
        Dim hasil As Integer
        Dim booking As Booking
        Dim detailBooking As DetailBooking

        'BOOKING
        booking.TglBooking = DateTime.Now()
        booking.Jenis = cbLayanan.SelectedValue()

        Try
            If String.IsNullOrEmpty(cbLayanan.Text) OrElse cbLayanan.SelectedValue = 0 Then
                MessageBox.Show("Please choose the service.", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            ElseIf String.IsNullOrEmpty(cbDuration.Text) Then
                MessageBox.Show("Please choose the duration.", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If
            'DETAIL BOOKING
            detailBooking.IdDokter = cbDokter.SelectedValue()
            detailBooking.IdPasien = cbPasien.SelectedValue()
            detailBooking.Jam = dtpTime.Value.ToString("HH:mm")
            detailBooking.Durasi = Integer.Parse(cbDuration.Text())
            detailBooking.TglSesi = dtpDate.Value.Date()

            Dim dtBooking As New DataTable()
            dgvSchedule.Rows.Add(
                count + 1,
            cbDokter.Text,
            cbPasien.Text,
            detailBooking.IdDokter,
            detailBooking.IdPasien,
            cbLayanan.Text,
            booking.Jenis,
            detailBooking.TglSesi,
            detailBooking.Jam,
            detailBooking.Durasi
        )

        Catch ex As Exception
            MessageBox.Show("There is an unexpecteed error: " & ex.Message, "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        dgvSchedule.Rows.Clear()
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        If dgvSchedule.CurrentRow IsNot Nothing Then
            Dim rowIndex As Integer = dgvSchedule.CurrentRow.Index
            dgvSchedule.Rows.RemoveAt(rowIndex)
        Else
            MessageBox.Show("No rows selected.")
        End If
    End Sub

    Private Sub dgvSchedule_MouseDown(sender As Object, e As MouseEventArgs) Handles dgvSchedule.MouseDown
        If e.Button = MouseButtons.Right Then
            dgvSchedule.ContextMenuStrip = cmDelete
        End If
    End Sub


End Class