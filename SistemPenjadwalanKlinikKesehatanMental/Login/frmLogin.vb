Public Class frmLogin
    Dim sec As New Security
    Dim PForm As MainPage

    Public Sub New(pForm As MainPage)
        InitializeComponent()
        Me.PForm = pForm
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If String.IsNullOrEmpty(tbUsername.Text) Or String.IsNullOrWhiteSpace(tbUsername.Text) Or
            String.IsNullOrEmpty(tbPassword.Text) Or String.IsNullOrWhiteSpace(tbPassword.Text) Then
            MessageBox.Show("Please fill your username/password.", "Login Page", MessageBoxButtons.OK,
            MessageBoxIcon.Warning)
        Else
            My.Application.User = My.Application.DBA.UserLogin(Trim(tbUsername.Text),
            sec.GetHash(Trim(tbPassword.Text)))

            If Not My.Application.User Is Nothing Then
                PForm.Login()
                Close()
            Else
                MessageBox.Show("Username/Password is Incorrect", "Login Page", MessageBoxButtons.OK,
            MessageBoxIcon.Warning)
            End If
        End If
    End Sub

    'Private Sub tbPassword_KeyUp(sender As Object, e As KeyEventArgs) Handles tbPassword.KeyUp
    '    If e.KeyCode = Keys.Enter Then
    '        If String.IsNullOrEmpty(tbUsername.Text) Or String.IsNullOrWhiteSpace(tbUsername.Text) Or
    '            String.IsNullOrEmpty(tbPassword.Text) Or String.IsNullOrWhiteSpace(tbPassword.Text) Then
    '            MessageBox.Show("Please fill your username/password.", "Login Page", MessageBoxButtons.OK,
    '            MessageBoxIcon.Warning)
    '        Else
    '            My.Application.User = My.Application.DBA.UserLogin(Trim(tbUsername.Text),
    '            sec.GetHash(Trim(tbPassword.Text)))

    '            If Not My.Application.User Is Nothing Then
    '                PForm.Login()
    '                Close()
    '            Else
    '                MessageBox.Show("Username/Password is Incorrect", "Login Page", MessageBoxButtons.OK,
    '            MessageBoxIcon.Warning)
    '            End If
    '        End If
    '    End If

    'End Sub

    Private Sub CrownGroupBox1_Enter(sender As Object, e As EventArgs) Handles CrownGroupBox1.Enter

    End Sub
End Class