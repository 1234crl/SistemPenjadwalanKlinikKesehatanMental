Imports System.Runtime.CompilerServices

Public Class MainPage

    Dim menuExpand As Boolean = False
    Dim sidebarExpand As Boolean = True

    'ALL CHILD FORMS 
    Dim fDoctors As frmDokterDaftar
    Dim fOverview As frmOverview
    Dim fPatients As frmPasienDaftar
    Dim fSchedule As frmSchedule
    Dim fUpcomingSchedule As frmUpcomingSchedule
    Dim fHistorySchedule As frmHistoryTransaksi
    Dim fUserList As frmUserList

    Dim IdDokter As Integer

    Public Sub New()
        InitializeComponent()

        Dim fLogin As New frmLogin(Me)
        fLogin.MdiParent = Me
        fLogin.Show()

        Panel2.Visible = False
        Panel5.Visible = False
        Panel6.Visible = False
        Panel7.Visible = False
        Panel8.Visible = False
        Panel9.Visible = False
        menuContainer.Visible = False

    End Sub

    Private Sub menuTransition_Tick(sender As Object, e As EventArgs) Handles menuTransition.Tick
        If menuExpand = False Then
            menuContainer.Height += 40
            If menuContainer.Height >= 165 Then
                menuTransition.Stop()
                menuExpand = True
            End If
        Else
            menuContainer.Height -= 10
            If (menuContainer.Height <= 53) Then
                menuTransition.Stop()
                menuExpand = False
            End If
        End If
    End Sub

    Private Sub btnSchedule_Click(sender As Object, e As EventArgs) Handles btnSchedule.Click
        menuTransition.Start()
    End Sub

    Private Sub sidebarTransition_Tick(sender As Object, e As EventArgs) Handles sidebarTransition.Tick
        If sidebarExpand = True Then
            sidebar.Width -= 5
            If sidebar.Width <= 60 Then
                sidebarExpand = False
                sidebarTransition.Stop()

                Panel2.Width = sidebar.Width
                Panel5.Width = sidebar.Width
                Panel6.Width = sidebar.Width
                Panel7.Width = sidebar.Width
                Panel8.Width = sidebar.Width
                Panel9.Width = sidebar.Width
                menuContainer.Width = sidebar.Width
            End If

        Else
            sidebar.Width += 5
            If sidebar.Width >= 251 Then
                sidebarExpand = True
                sidebarTransition.Stop()

                Panel2.Width = sidebar.Width
                Panel5.Width = sidebar.Width
                Panel6.Width = sidebar.Width
                Panel7.Width = sidebar.Width
                Panel8.Width = sidebar.Width
                Panel9.Width = sidebar.Width
                menuContainer.Width = sidebar.Width
            End If
        End If
    End Sub

    Private Sub btnItem_Click(sender As Object, e As EventArgs) Handles btnItem.Click
        sidebarTransition.Start()
    End Sub

    Private Sub btnDoctors_Click(sender As Object, e As EventArgs) Handles btnDoctors.Click
        If (fDoctors Is Nothing) Then
            fDoctors = New frmDokterDaftar()
            AddHandler fDoctors.FormClosed, AddressOf frmDokterDaftar_FormClosed
            fDoctors.MdiParent = Me
            fDoctors.Dock = DockStyle.Fill
            fDoctors.Show()
        Else
            fDoctors.Activate()
        End If
    End Sub

    Private Sub frmDokterDaftar_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        fDoctors = Nothing
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles btnOverview.Click
        If (fOverview Is Nothing) Then
            fOverview = New frmOverview()
            AddHandler fOverview.FormClosed, AddressOf frmOverview_FormClosed
            fOverview.MdiParent = Me
            fOverview.Dock = DockStyle.Fill
            fOverview.Show()
        Else
            fOverview.Activate()
        End If

    End Sub

    Private Sub frmOverview_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        fOverview = Nothing
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnPatient.Click
        If (fPatients Is Nothing) Then
            fPatients = New frmPasienDaftar()
            AddHandler fPatients.FormClosed, AddressOf frmPasienDaftar_FormClosed
            fPatients.MdiParent = Me
            fPatients.Dock = DockStyle.Fill
            fPatients.Show()
        Else
            fPatients.Activate()
        End If
    End Sub

    Private Sub frmPasienDaftar_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        fPatients = Nothing
    End Sub

    Private Sub btnNewSchedule_Click(sender As Object, e As EventArgs) Handles btnNewSchedule.Click
        If (fSchedule Is Nothing) Then
            fSchedule = New frmSchedule()
            AddHandler fSchedule.FormClosed, AddressOf frmSchedule_FormClosed
            fSchedule.MdiParent = Me
            fSchedule.Dock = DockStyle.Fill
            fSchedule.Show()
        Else
            fSchedule.Activate()
        End If

    End Sub

    Private Sub frmSchedule_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        fSchedule = Nothing
    End Sub

    Private Sub btnUpcomingSchedule_Click(sender As Object, e As EventArgs) Handles btnUpcomingSchedule.Click
        If (fUpcomingSchedule Is Nothing) Then
            'MessageBox.Show(IdDokter.ToString())
            fUpcomingSchedule = New frmUpcomingSchedule(IdDokter)
            AddHandler fUpcomingSchedule.FormClosed, AddressOf frmUpcomingSchedule_FormClosed
            fUpcomingSchedule.MdiParent = Me
            fUpcomingSchedule.Dock = DockStyle.Fill
            fUpcomingSchedule.Show()
        Else
            fUpcomingSchedule.Activate()
        End If
    End Sub

    Private Sub frmUpcomingSchedule_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        fUpcomingSchedule = Nothing
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If (fHistorySchedule Is Nothing) Then
            fHistorySchedule = New frmHistoryTransaksi(IdDokter)
            AddHandler fHistorySchedule.FormClosed, AddressOf frmHistoryTransaksi_FormClosed
            fHistorySchedule.MdiParent = Me
            fHistorySchedule.Dock = DockStyle.Fill
            fHistorySchedule.Show()
        Else
            fHistorySchedule.Activate()
        End If
    End Sub

    Private Sub frmHistoryTransaksi_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        fHistorySchedule = Nothing
    End Sub

    Public Sub Login()

        Panel2.Visible = True
        Panel6.Visible = True
        Panel8.Visible = True
        Panel9.Visible = True
        menuContainer.Visible = True

        If My.Application.User.HakAksesUser = 0 Then
            Panel5.Visible = True
            Panel7.Visible = True
        ElseIf My.Application.User.HakAksesUser = 1 Then
            Panel5.Visible = False
            Panel7.Visible = False
            Panel8.Visible = False
            btnNewSchedule.Enabled = False

            IdDokter = My.Application.DBA.GetIdDokter(My.Application.User.IdUser)
        End If
    End Sub

    Public Sub Logout()
        btnOverview.Visible = False
        btnSchedule.Visible = False
        btnUpcomingSchedule.Visible = False
        btnNewSchedule.Visible = False
        Button4.Visible = False
        btnDoctors.Visible = False
        btnPatient.Visible = False
        btnUserList.Visible = False
        btnLogout.Visible = False

        For Each cForm In MdiChildren
            cForm.Close()
        Next

        Dim fLogin As New frmLogin(Me)
        fLogin.MdiParent = Me
        fLogin.Show()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Logout()
    End Sub

    Private Sub btnUserList_Click(sender As Object, e As EventArgs) Handles btnUserList.Click
        If (fUserList Is Nothing) Then
            fUserList = New frmUserList()
            AddHandler fUserList.FormClosed, AddressOf frmUserList_FormClosed
            fUserList.MdiParent = Me
            fUserList.Dock = DockStyle.Fill
            fUserList.Show()
        Else
            fUserList.Activate()
        End If
    End Sub

    Private Sub frmUserList_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        fUserList = Nothing
    End Sub
End Class