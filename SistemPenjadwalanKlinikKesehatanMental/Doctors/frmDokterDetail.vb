Imports System.IO
Imports System.Security.Cryptography

Public Class frmDokterDetail
    Dim MyParent As frmDokterDaftar

    Dim dokter As New Doctors

    Public Sub New(myParent As frmDokterDaftar, dokter As Doctors)
        InitializeComponent()
        Me.MyParent = myParent
        Me.dokter = dokter

        tbNama.Text = dokter.NamaDokter
        tbUsia.Text = dokter.Usia
        cbGender.SelectedItem = dokter.JK
        cbJabatan.SelectedItem = dokter.Jabatan
        tbNoTelp.Text = dokter.NoTelp
        dtpDateOfBirth.Value = DateTime.Parse(dokter.TglLahir)

        If dokter.Status = "Aktif" Then
            rbStatusAct.Checked = True
            rbStatusInact.Checked = False
        Else
            rbStatusAct.Checked = False
            rbStatusInact.Checked = True
        End If

        Dim DataFoto As Byte() = My.Application.DBA.DokterGambar(dokter.IdDokter)

        If Not DataFoto Is Nothing Then
            ''Cara mengambil data Byte lalu ditampilkan sbg picture
            Using MemoryStream As New MemoryStream(DataFoto, 0, DataFoto.Length)
                MemoryStream.Write(DataFoto, 0, DataFoto.Length)
                pbGambarDokter.Image = Image.FromStream(MemoryStream)
            End Using
        End If


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim hasil As Integer

        dokter.NamaDokter = Trim(tbNama.Text)
        dokter.Usia = Trim(tbUsia.Text)
        dokter.JK = cbGender.SelectedItem.ToString()
        dokter.NoTelp = Trim(tbNoTelp.Text)
        dokter.Jabatan = cbJabatan.SelectedItem.ToString()
        dokter.TglLahir = dtpDateOfBirth.Value

        ''ADA IF UNTUK CEK WHETHER THE IMAGE IN BEING INPUTED OR NOT    

        If Not String.IsNullOrEmpty(tbGambar.Text) And
            Not String.IsNullOrWhiteSpace(tbGambar.Text) Then

            Try
                Dim MemoryStream As New MemoryStream()
                pbGambarDokter.Image.Save(MemoryStream, pbGambarDokter.Image.RawFormat)
                Dim DataFoto As Byte() = MemoryStream.GetBuffer()
                hasil = My.Application.DBA.DokterGambarInsert(dokter.IdDokter, DataFoto)

            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error Penyimpanan Gambar",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        End If

        hasil = My.Application.DBA.DokterUpdate(dokter)
        If hasil = 1 Then
            MyParent.RefreshData()
            Close()
        Else
            MessageBox.Show("Couldn't update data", "Error Form Doctor Update", MessageBoxButtons.OK,
                MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Close()
    End Sub

    Private Sub btnPath_Click(sender As Object, e As EventArgs) Handles btnPilihGambar.Click
        Try
            OFD.Multiselect = False
            OFD.Title = "Pilih Gambar Untuk Buku"
            OFD.InitialDirectory = Environment.SpecialFolder.MyPictures
            OFD.Filter = "Berkas Gambar | *.bmp;*.jpg;*.jpeg;*.png;"

            If OFD.ShowDialog = DialogResult.OK Then
                tbGambar.Text = OFD.FileName
                pbGambarDokter.Image = Image.FromFile(OFD.FileName)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Pemilihan Gambar", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


End Class