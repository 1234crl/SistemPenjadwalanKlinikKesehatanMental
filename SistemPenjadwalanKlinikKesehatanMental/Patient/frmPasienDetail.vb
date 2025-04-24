Imports System.IO

Public Class frmPasienDetail
    Dim MyParent As frmPasienDaftar

    Dim pasien As New Patient


    Public Sub New(myParent As frmPasienDaftar, pasien As Patient)
        InitializeComponent()

        Me.MyParent = myParent
        Me.pasien = pasien

        tbNama.Text = pasien.NamaPasien
        tbUsia.Text = pasien.Usia
        cbGender.SelectedItem = pasien.JK
        tbNoTelp.Text = pasien.NoTelp
        dtpDateOfBirth.Value = DateTime.Parse(pasien.TglLahir)
        dtpRegistration.Value = DateTime.Parse(pasien.TglDaftar)

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim hasil As Integer

        pasien.NamaPasien = Trim(tbNama.Text)
        pasien.Usia = Trim(tbUsia.Text)
        pasien.JK = cbGender.SelectedItem.ToString()
        pasien.NoTelp = Trim(tbNoTelp.Text)
        pasien.TglLahir = dtpDateOfBirth.Value
        pasien.TglDaftar = dtpRegistration.Value

        hasil = My.Application.DBA.PasienUpdate(pasien)
        If hasil = 1 Then
            MyParent.RefreshData()
            Close()
        Else
            MessageBox.Show("Couldn't update data", "Error Form Patient Update", MessageBoxButtons.OK,
                MessageBoxIcon.Error)
        End If
    End Sub
End Class