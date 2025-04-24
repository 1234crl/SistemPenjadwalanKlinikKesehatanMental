Imports System.Reflection

Public Class frmDokterSpesifikasi

    Dim dokter As New Doctors

    Dim DTSpesifikasi As DataTable
    Dim DTSpesifikasiDetil As DataTable

    Dim MyParent As frmDokterDaftar

    Dim kolomPertama As Object = Nothing

    Public Sub New(myParent As frmDokterDaftar, dokter As Doctors)
        InitializeComponent()
        Me.MyParent = myParent
        Me.dokter = dokter

        tbNama.Text = dokter.NamaDokter
        cbJabatan.SelectedItem = dokter.Jabatan

        DTSpesifikasi = My.Application.DBA.DokterListSpesifikasi
        DTSpesifikasiDetil = My.Application.DBA.DokterSpesialisasiDetil

        For Each row As DataRow In DTSpesifikasi.Rows
            clbSpesialis.Items.Add(row("NamaSpesifikasi").ToString())
        Next

        For Each row As DataRow In DTSpesifikasiDetil.Rows
            Dim kolomPertama As Object = row("IdDokter")
            Dim idSpesifikasi As Integer = row("IdSpesifikasi")

            If kolomPertama = dokter.IdDokter Then
                'Dim index As Integer = clbSpesialis.Items.IndexOf(idSpesifikasi)
                clbSpesialis.SetItemChecked(idSpesifikasi, True)
            End If
        Next

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim selectedSpecializations As New List(Of Integer)
        Dim hasil As Integer

        For Each Index As Integer In clbSpesialis.CheckedIndices
            selectedSpecializations.Add(Index)
        Next

        hasil = My.Application.DBA.DokterSpesialisasiInsert(dokter, selectedSpecializations)

        If hasil = 1 Then
            MyParent.RefreshData()
            Close()
        Else
            MessageBox.Show("Couldn't add specialization", "Error from Doctor Specialization Insert",
            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Close()
    End Sub
End Class