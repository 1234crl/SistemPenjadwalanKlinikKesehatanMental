Public Class frmUserList
    Dim DTPengguna As New DataTable
    Dim DTStatus As New DataTable

    Dim IdPengguna As Integer
    Dim NamaPengguna As String
    Dim Username As String
    Dim StatusPengguna As String

    Dim fUserInsert As frmUserInsert

    Public Sub New()
        InitializeComponent()

        DTPengguna = My.Application.DBA.PenggunaList
        dgvUser.DataSource = DTPengguna
    End Sub

    Public Sub RefreshData()
        DTPengguna = My.Application.DBA.PenggunaList
        dgvUser.DataSource = DTPengguna
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If (fUserInsert Is Nothing) Then
            fUserInsert = New frmUserInsert(Me)
            AddHandler fUserInsert.FormClosed, AddressOf frmUserInsert_FormClosed
            fUserInsert.MdiParent = MainPage
            fUserInsert.Dock = DockStyle.Fill
            fUserInsert.Show()
        Else
            fUserInsert.Activate()
        End If

    End Sub

    Private Sub frmUserInsert_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        fUserInsert = Nothing
    End Sub

End Class