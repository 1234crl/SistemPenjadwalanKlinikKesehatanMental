Public Class frmPasienDaftar

    Dim DTPasien As New DataTable

    Dim pasien As New Patient

    Dim fPasienDetail As frmPasienDetail
    Dim fPasienTambah As frmPasienTambah

    Public Sub New()
        InitializeComponent()

        DTPasien = My.Application.DBA.PasienListDetil
        dgvPasien.DataSource = DTPasien
    End Sub

    Public Sub RefreshData()
        'Supaya dia bisa ambil data baru yang ditambahkan
        DTPasien = My.Application.DBA.PasienListDetil()
        dgvPasien.DataSource = DTPasien
    End Sub

    Private Sub cbStatusPasien_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbStatusPasien.SelectionChangeCommitted
        Search()
    End Sub

    Private Sub tbSearch_KeyUp(sender As Object, e As KeyEventArgs) Handles tbSearch.KeyUp
        Search()
    End Sub

    Private Sub Search()

        If cbStatusPasien.SelectedItem IsNot Nothing AndAlso Not String.IsNullOrEmpty(cbStatusPasien.SelectedItem.ToString()) Then

            If cbStatusPasien.SelectedItem.ToString() = "Show All" Then
                DTPasien.DefaultView.RowFilter = ""
            Else
                Dim filter As String = "(NamaPasien LIKE '%" & tbSearch.Text & "%')"

                ' Tambahkan filter JabatanDokter jika ComboBox memiliki item yang dipilih
                filter &= " AND StatusPasien = '%" & cbStatusPasien.SelectedItem.ToString() & "%'"

                ' Terapkan filter
                DTPasien.DefaultView.RowFilter = filter

            End If
        Else
            If Not String.IsNullOrEmpty(tbSearch.Text) And Not String.IsNullOrWhiteSpace(tbSearch.Text) Then

                DTPasien.DefaultView.RowFilter = "NamaPasien LIKE '%" & tbSearch.Text & "%' OR 
                        StatusPasien LIKE '%" & tbSearch.Text & "%'"
            Else
                DTPasien.DefaultView.RowFilter = ""
            End If
        End If

    End Sub

    Private Sub dgvPasien_MouseDown(sender As Object, e As MouseEventArgs) Handles dgvPasien.MouseDown
        If e.Button = MouseButtons.Right Then
            Dim HT As DataGridView.HitTestInfo
            HT = dgvPasien.HitTest(e.X, e.Y)
            If HT.Type = DataGridViewHitTestType.Cell Then

                pasien = New Patient

                pasien.IdPasien = dgvPasien.Item("IdPasienCol", HT.RowIndex).Value
                pasien.NamaPasien = dgvPasien.Item("NamaPasienCol", HT.RowIndex).Value
                pasien.JK = dgvPasien.Item("JKPasienCol", HT.RowIndex).Value
                pasien.NoTelp = dgvPasien.Item("NoTelpCol", HT.RowIndex).Value
                pasien.Status = dgvPasien.Item("StatusCol", HT.RowIndex).Value
                pasien.Usia = dgvPasien.Item("UsiaCol", HT.RowIndex).Value
                pasien.TglLahir = dgvPasien.Item("TanggalLahirCol", HT.RowIndex).Value
                pasien.TglDaftar = dgvPasien.Item("TanggalDaftarCol", HT.RowIndex).Value

                dgvPasien.Rows(HT.RowIndex).Selected = True
                dgvPasien.ContextMenuStrip = cmPasien
            Else
                dgvPasien.ContextMenuStrip = Nothing
            End If
        Else
            dgvPasien.ContextMenuStrip = Nothing
        End If


    End Sub

    Private Sub DetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DetailsToolStripMenuItem.Click
        If (fPasienDetail Is Nothing) Then
            fPasienDetail = New frmPasienDetail(Me, pasien)
            AddHandler fPasienDetail.FormClosed, AddressOf frmPasienDetail_FormClosed
            fPasienDetail.MdiParent = MainPage
            fPasienDetail.Dock = DockStyle.Fill
            fPasienDetail.Show()
        Else
            fPasienDetail.Activate()
        End If
    End Sub

    Private Sub frmPasienDetail_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        fPasienDetail = Nothing
    End Sub


    Private Sub frmPasienTambah_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        fPasienTambah = Nothing
    End Sub

    Private Sub AddNewPatientToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddNewPatientToolStripMenuItem.Click
        If (fPasienTambah Is Nothing) Then
            fPasienTambah = New frmPasienTambah(Me)
            AddHandler fPasienTambah.FormClosed, AddressOf frmPasienTambah_FormClosed
            fPasienTambah.MdiParent = MainPage
            fPasienTambah.Dock = DockStyle.Fill
            fPasienTambah.Show()
        Else
            fPasienTambah.Activate()
        End If
    End Sub
End Class