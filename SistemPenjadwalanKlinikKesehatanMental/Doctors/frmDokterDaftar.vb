Public Class frmDokterDaftar

    Dim DTDokter As New DataTable
    Dim dokter As Doctors

    Dim fDoctorInsert As frmDokterTambah
    Dim fDoctorSpecialization As frmDokterSpesifikasi
    Dim fDoctorDetail As frmDokterDetail

    Private Sub Search()

        If cbTitles.SelectedItem IsNot Nothing AndAlso Not String.IsNullOrEmpty(cbTitles.SelectedItem.ToString()) Then

            If cbTitles.SelectedItem.ToString() = "All" Then
                DTDokter.DefaultView.RowFilter = ""
            Else
                Dim filter As String = "(NamaDokter LIKE '%" & tbSearch.Text & "%' OR JabatanDokter LIKE '%" & tbSearch.Text & "%')"

                ' Tambahkan filter JabatanDokter jika ComboBox memiliki item yang dipilih
                filter &= " AND JabatanDokter LIKE '%" & cbTitles.SelectedItem.ToString() & "%'"

                ' Terapkan filter
                DTDokter.DefaultView.RowFilter = filter

            End If
        Else
            If Not String.IsNullOrEmpty(tbSearch.Text) And Not String.IsNullOrWhiteSpace(tbSearch.Text) Then

                DTDokter.DefaultView.RowFilter = "NamaDokter LIKE '%" & tbSearch.Text & "%' OR 
                        JabatanDokter LIKE '%" & tbSearch.Text & "%'"
            Else
                DTDokter.DefaultView.RowFilter = ""
            End If
        End If

    End Sub

    Public Sub New()
        InitializeComponent()

        DTDokter = My.Application.DBA.DokterListDetil()
        dgvDokter.DataSource = DTDokter


    End Sub

    Public Sub RefreshData()
        'Supaya dia bisa ambil data baru yang ditambahkan
        DTDokter = My.Application.DBA.DokterListDetil()
        dgvDokter.DataSource = DTDokter
    End Sub

    Private Sub cbTitles_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbTitles.SelectionChangeCommitted
        Search()
    End Sub

    Private Sub tbSearch_KeyUp(sender As Object, e As KeyEventArgs) Handles tbSearch.KeyUp
        Search()
    End Sub

    Private Sub dgvDokter_MouseDown(sender As Object, e As MouseEventArgs) Handles dgvDokter.MouseDown
        If e.Button = MouseButtons.Right Then
            Dim HT As DataGridView.HitTestInfo
            HT = dgvDokter.HitTest(e.X, e.Y)
            If HT.Type = DataGridViewHitTestType.Cell Then

                dokter = New Doctors

                dokter.IdDokter = dgvDokter.Item("IdDokterCol", HT.RowIndex).Value
                dokter.NamaDokter = dgvDokter.Item("NamaDokterCol", HT.RowIndex).Value
                dokter.JK = dgvDokter.Item("JKCol", HT.RowIndex).Value
                dokter.NoTelp = dgvDokter.Item("NoTelpCol", HT.RowIndex).Value
                dokter.Status = dgvDokter.Item("StatusCol", HT.RowIndex).Value
                dokter.Usia = dgvDokter.Item("UmurCol", HT.RowIndex).Value
                dokter.TglLahir = dgvDokter.Item("TglLahirCol", HT.RowIndex).Value
                dokter.Jabatan = dgvDokter.Item("JabatanCol", HT.RowIndex).Value

                dgvDokter.Rows(HT.RowIndex).Selected = True
                dgvDokter.ContextMenuStrip = cmDokter
            Else
                dgvDokter.ContextMenuStrip = Nothing
            End If
        Else
            dgvDokter.ContextMenuStrip = Nothing
        End If

    End Sub

    Private Sub AddNewDoctorsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddNewDoctorsToolStripMenuItem.Click
        If (fDoctorInsert Is Nothing) Then
            fDoctorInsert = New frmDokterTambah(Me)
            AddHandler fDoctorInsert.FormClosed, AddressOf frmDokterTambah_FormClosed
            fDoctorInsert.MdiParent = MainPage
            fDoctorInsert.Dock = DockStyle.Fill
            fDoctorInsert.Show()
        Else
            fDoctorInsert.Activate()
        End If
    End Sub

    Private Sub frmDokterTambah_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        fDoctorInsert = Nothing
    End Sub

    Private Sub UpdateProfileToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub DetailSpecializationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DetailSpecializationToolStripMenuItem.Click
        If (fDoctorSpecialization Is Nothing) Then
            fDoctorSpecialization = New frmDokterSpesifikasi(Me, dokter)
            AddHandler fDoctorSpecialization.FormClosed, AddressOf frmDokterSpesifikasi_FormClosed
            fDoctorSpecialization.MdiParent = MainPage
            fDoctorSpecialization.Dock = DockStyle.Fill
            fDoctorSpecialization.Show()
        Else
            fDoctorSpecialization.Activate()
        End If
    End Sub

    Private Sub frmDokterSpesifikasi_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        fDoctorSpecialization = Nothing
    End Sub

    Private Sub DetailProfileToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DetailProfileToolStripMenuItem1.Click
        If (fDoctorDetail Is Nothing) Then
            fDoctorDetail = New frmDokterDetail(Me, dokter)
            AddHandler fDoctorDetail.FormClosed, AddressOf frmDokterDetail_FormClosed
            fDoctorDetail.MdiParent = MainPage
            fDoctorDetail.Dock = DockStyle.Fill
            fDoctorDetail.Show()
        Else
            fDoctorDetail.Activate()
        End If
    End Sub

    Private Sub frmDokterDetail_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        fDoctorDetail = Nothing
    End Sub

End Class