Imports System.IO

Public Class frmPasienTambah

    Dim MyParent As frmPasienDaftar

    Public Sub New(myParent As frmPasienDaftar)
        InitializeComponent()
        Me.MyParent = myParent

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim pasien As Patient
        Dim hasil As Integer

        pasien.NamaPasien = Trim(tbNama.Text)
        pasien.Usia = Trim(tbUsia.Text)
        pasien.JK = cbGender.SelectedItem.ToString()
        pasien.NoTelp = Trim(tbNoTelp.Text)
        pasien.TglLahir = dtpDateOfBirth.Value
        pasien.TglDaftar = DateTime.Now()

        ''ADA IF UNTUK CEK WHETHER THE IMAGE IN BEING INPUTED OR NOT    

        hasil = My.Application.DBA.PasienInsert(pasien)
        If hasil = 1 Then
            MyParent.RefreshData()
            Close()
        Else
            MessageBox.Show("Couldn't add patients", "Error Form Patient Insert", MessageBoxButtons.OK,
                MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Close()
    End Sub
End Class