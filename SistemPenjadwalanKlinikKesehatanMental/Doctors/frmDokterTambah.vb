Imports System.IO
Imports System.Security.Cryptography

Public Class frmDokterTambah
    Dim MyParent As frmDokterDaftar

    Public Sub New(myParent As frmDokterDaftar)
        InitializeComponent()
        Me.MyParent = myParent 'Supaya bisa panggil prosedur di myParent

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim dokter As Doctors
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


        hasil = My.Application.DBA.DokterInsert(dokter)
        If hasil = 1 Then
            MyParent.RefreshData()
            Close()
        Else
            MessageBox.Show("Couldn't add doctors", "Error Form Doctor Insert", MessageBoxButtons.OK,
                MessageBoxIcon.Error)
        End If


    End Sub

    Private Sub btnPilihGambar_Click(sender As Object, e As EventArgs) Handles btnPilihGambar.Click
        Try
            OFD.Multiselect = False
            OFD.Title = "Choose doctor's profile picture"
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