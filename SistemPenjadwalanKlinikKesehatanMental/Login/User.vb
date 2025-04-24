Public Class User

    Private _IdUser As Integer
    Private _NamaUser As String
    Private _HakAksesUser As Integer
    Private _HakAksesUserStr As String
    Private _Uname As String
    Private _Upass As String
    Private _StatusUser As Integer
    Private _StatusUserStr As String

    Sub New()
    End Sub

    Sub New(idUser As Integer, namaUser As String, hakAksesUser As Integer)
        Me.IdUser = idUser
        Me.NamaUser = namaUser
        Me.HakAksesUser = hakAksesUser
    End Sub

    Public Property StatusUserStr() As String
        Get
            Return _StatusUserStr
        End Get
        Set(ByVal value As String)
            _StatusUserStr = value
        End Set
    End Property

    Public Property StatusUser() As Integer
        Get
            Return _StatusUser
        End Get
        Set(ByVal value As Integer)
            _StatusUser = value
        End Set
    End Property


    Public Property Upass() As String
        Get
            Return _Upass
        End Get
        Set(ByVal value As String)
            _Upass = value
        End Set
    End Property
    Public Property Uname() As String
        Get
            Return _Uname
        End Get
        Set(ByVal value As String)
            _Uname = value
        End Set
    End Property

    Public Property HakAksesUserStr() As String
        Get
            Return _HakAksesUserStr
        End Get
        Set(ByVal value As String)
            _HakAksesUserStr = value
        End Set
    End Property

    Public Property HakAksesUser() As Integer
        Get
            Return _HakAksesUser
        End Get
        Set(ByVal value As Integer)
            _HakAksesUser = value
        End Set
    End Property

    Public Property NamaUser() As String
        Get
            Return _NamaUser
        End Get
        Set(ByVal value As String)
            _NamaUser = value
        End Set
    End Property

    Public Property IdUser() As Integer
        Get
            Return _IdUser
        End Get
        Set(ByVal value As Integer)
            _IdUser = value
        End Set
    End Property

End Class
