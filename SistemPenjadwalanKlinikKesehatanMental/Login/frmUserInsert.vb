Public Class frmUserInsert
    Dim myParent As frmUserList
    Dim DTDokter As New DataTable
    Dim DTAdmin As New DataTable

    Public Sub New(MyParent As frmUserList)
        InitializeComponent()

        Me.myParent = MyParent
        DTDokter = My.Application.DBA.DokterListDetil()
        DTAdmin = My.Application.DBA.AdminListDetil()

        cbPosition.SelectedIndex = 0
        If cbPosition.SelectedItem = "Doctor" Then
            With cbNama
                .DataSource = DTDokter
                .DisplayMember = "NamaDokter"
                .ValueMember = "IdDokter"
            End With
        Else
            With cbNama
                .DataSource = DTAdmin
                .DisplayMember = "NamaAdmin"
                .ValueMember = "IdAdmin"
            End With

        End If

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim sec As New Security
        Dim Pengguna As New User()
        Dim hasil As Integer
        Dim IdDokter As Integer
        Dim IdAdmin As Integer

        Pengguna.Uname = Trim(tbUname.Text)
        Pengguna.Upass = Trim(sec.GetHash(tbPassword.Text))
        Pengguna.HakAksesUser = cbPosition.SelectedIndex

        If tbPassword.Text = tbRetype.Text Then
            If cbPosition.SelectedItem = "Doctor" Then
                IdDokter = cbNama.SelectedValue
                IdAdmin = 0
                MessageBox.Show(IdDokter.ToString())
                hasil = My.Application.DBA.PenggunaInsert(Pengguna, IdDokter, IdAdmin)
            Else
                IdAdmin = cbNama.SelectedValue
                IdDokter = 0
                hasil = My.Application.DBA.PenggunaInsert(Pengguna, IdDokter, IdAdmin)
            End If

        Else
            MessageBox.Show("Password is not matched. Please try again.")
        End If


        If hasil = 1 Then
            MyParent.RefreshData()
            Close()
        End If

    End Sub

    Private Sub cbPosition_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbPosition.SelectionChangeCommitted
        If cbPosition.SelectedItem = "Doctor" Then
            With cbNama
                .DataSource = DTDokter
                .DisplayMember = "NamaDokter"
                .ValueMember = "IdDokter"
            End With
        Else
            With cbNama
                .DataSource = DTAdmin
                .DisplayMember = "NamaAdmin"
                .ValueMember = "IdAdmin"
            End With

        End If
    End Sub
End Class