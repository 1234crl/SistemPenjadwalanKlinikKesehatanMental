Imports System.Data.SqlClient
Imports System.Data.SqlTypes

Public Class DBAccess
    Private SqlConn As SqlConnection
    Private ServerAddress As String
    Private DBInstance As String
    Private DBName As String
    Private UserDB As String
    Private PassDB As String

    Public Sub New(serverAddress As String, dBInstance As String, dBName As String, userDB As String, passDB As String)
        Me.ServerAddress = serverAddress
        Me.DBInstance = dBInstance
        Me.DBName = dBName
        Me.UserDB = userDB
        Me.PassDB = passDB
    End Sub

    Public Sub OpenSqlConn()
        SqlConn = New SqlConnection(
        "Data Source=" & ServerAddress & "\" & DBInstance & "; 
        Database=" & DBName & ";
        User Id=" & UserDB & ";
        Password=" & PassDB & ";"
    )
        If SqlConn.State = ConnectionState.Closed Then
            SqlConn.Open()
        ElseIf SqlConn.State = ConnectionState.Broken Then
            SqlConn.Close()
            SqlConn.Open()
        End If
    End Sub

    Public Sub CloseSqlConn()
        If SqlConn.State = ConnectionState.Open Then
            SqlConn.Close()
        ElseIf SqlConn.State = ConnectionState.Connecting Then
            SqlConn.Close()
        ElseIf SqlConn.State = ConnectionState.Broken Then
            SqlConn.Close()
        End If
    End Sub

    Public Function CheckDBConn() As Boolean
        Try
            OpenSqlConn()
            If SqlConn.State = ConnectionState.Open Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Return False
        Finally
            CloseSqlConn()
        End Try
    End Function

    Public Function DokterListDetil() As DataTable

        Dim DTDokter As New DataTable

        Try
            OpenSqlConn()
            Dim DA As New SqlDataAdapter("usp_DokterListDetil", SqlConn)
            DA.SelectCommand.CommandType = CommandType.StoredProcedure
            DA.Fill(DTDokter)
            Return DTDokter

        Catch ex As Exception
            MessageBox.Show("Error Pengambilan Data Dokter: " & ex.Message,
                            "ERROR DBA.DokterListDetil()",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
            Return DTDokter
        Finally
            CloseSqlConn()

        End Try

    End Function

    Public Function DokterListAktif() As DataTable

        Dim DTDokter As New DataTable

        Try
            OpenSqlConn()
            Dim DA As New SqlDataAdapter("usp_DokterListAktif", SqlConn)
            DA.SelectCommand.CommandType = CommandType.StoredProcedure
            DA.Fill(DTDokter)
            Return DTDokter

        Catch ex As Exception
            MessageBox.Show("Error Pengambilan Data Dokter: " & ex.Message,
                            "ERROR DBA.DokterListDetil()",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
            Return DTDokter
        Finally
            CloseSqlConn()

        End Try

    End Function

    Public Function PasienListDetil() As DataTable

        Dim DTPasien As New DataTable

        Try
            OpenSqlConn()
            Dim DA As New SqlDataAdapter("usp_PasienListDetil", SqlConn)
            DA.SelectCommand.CommandType = CommandType.StoredProcedure
            DA.Fill(DTPasien)
            Return DTPasien

        Catch ex As Exception
            MessageBox.Show("Error Pengambilan Data Pasien: " & ex.Message,
                            "ERROR DBA.PasienListDetil()",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
            Return DTPasien
        Finally
            CloseSqlConn()

        End Try

    End Function

    Public Function DokterListSpesifikasi() As DataTable

        Dim DTSpesifikasi As New DataTable

        Try
            OpenSqlConn()
            Dim DA As New SqlDataAdapter("usp_DokterListSpesifikasi", SqlConn)
            DA.SelectCommand.CommandType = CommandType.StoredProcedure
            DA.Fill(DTSpesifikasi)
            Return DTSpesifikasi

        Catch ex As Exception
            MessageBox.Show("Error Pengambilan Data Spesifikasi: " & ex.Message,
                            "ERROR DBA.DokterListSpesifikasi()",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
            Return DTSpesifikasi
        Finally
            CloseSqlConn()
        End Try

    End Function

    Public Function DokterInsert(dokter As Doctors) As Integer

        Try
            OpenSqlConn()

            'Memanggil usp dengan command
            Dim SQLcmd As New SqlCommand("usp_DokterInsert", SqlConn)
            SQLcmd.CommandType = CommandType.StoredProcedure

            SQLcmd.Parameters.Add("@nama", SqlDbType.NVarChar, 255)
            SQLcmd.Parameters("@nama").Direction = ParameterDirection.Input
            SQLcmd.Parameters("@nama").Value = dokter.NamaDokter

            SQLcmd.Parameters.Add("@noTelepon", SqlDbType.NVarChar, 100)
            SQLcmd.Parameters("@noTelepon").Direction = ParameterDirection.Input
            SQLcmd.Parameters("@noTelepon").Value = dokter.NoTelp

            SQLcmd.Parameters.Add("@tglLahir", SqlDbType.Date)
            SQLcmd.Parameters("@tglLahir").Direction = ParameterDirection.Input
            SQLcmd.Parameters("@tglLahir").Value = dokter.TglLahir

            SQLcmd.Parameters.Add("@usia", SqlDbType.Int)
            SQLcmd.Parameters("@usia").Direction = ParameterDirection.Input
            SQLcmd.Parameters("@usia").Value = dokter.Usia

            SQLcmd.Parameters.Add("@jenisKelamin", SqlDbType.NVarChar, 50)
            SQLcmd.Parameters("@jenisKelamin").Direction = ParameterDirection.Input
            SQLcmd.Parameters("@jenisKelamin").Value = dokter.JK

            SQLcmd.Parameters.Add("@jabatan", SqlDbType.NVarChar, 100)
            SQLcmd.Parameters("@jabatan").Direction = ParameterDirection.Input
            SQLcmd.Parameters("@jabatan").Value = dokter.Jabatan


            'Code untuk menjalankan tiap hal di atas
            SQLcmd.ExecuteNonQuery()

            Return 1

        Catch ex As Exception
            MessageBox.Show("Error Insert Data Dokter: " & ex.Message,
                            "ERROR DBA.DokterInsert()",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
            Return -1

        Finally
            CloseSqlConn()
        End Try

    End Function

    Public Function DokterSpesialisasiInsert(dokter As Doctors, selectedSpecializations As List(Of Integer)) As Integer

        Try
            OpenSqlConn()

            For Each item In selectedSpecializations
                'Memanggil usp dengan command
                Dim SQLcmd As New SqlCommand("usp_DokterSpesialisasiInsert", SqlConn)
                SQLcmd.CommandType = CommandType.StoredProcedure

                SQLcmd.Parameters.Add("@IdDokter", SqlDbType.Int)
                SQLcmd.Parameters("@IdDokter").Direction = ParameterDirection.Input
                SQLcmd.Parameters("@IdDokter").Value = dokter.IdDokter

                SQLcmd.Parameters.Add("@IdSpesialisasi", SqlDbType.Int)
                SQLcmd.Parameters("@IdSpesialisasi").Direction = ParameterDirection.Input
                SQLcmd.Parameters("@IdSpesialisasi").Value = item

                'Code untuk menjalankan tiap hal di atas
                SQLcmd.ExecuteNonQuery()

            Next

            Return 1

        Catch ex As Exception
            MessageBox.Show("Error Insert Data Dokter Spesialisasi : " & ex.Message,
                            "ERROR DBA.DokterSpesialisasiInsert()",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
            Return -1

        Finally
            CloseSqlConn()
        End Try

    End Function

    Public Function DokterUpdate(dokter As Doctors) As Integer

        Try
            OpenSqlConn()

            'Memanggil usp dengan command
            Dim SQLcmd As New SqlCommand("usp_DokterUpdate", SqlConn)
            SQLcmd.CommandType = CommandType.StoredProcedure

            SQLcmd.Parameters.Add("@idDokter", SqlDbType.Int)
            SQLcmd.Parameters("@idDokter").Direction = ParameterDirection.Input
            SQLcmd.Parameters("@idDokter").Value = dokter.IdDokter

            SQLcmd.Parameters.Add("@nama", SqlDbType.NVarChar, 255)
            SQLcmd.Parameters("@nama").Direction = ParameterDirection.Input
            SQLcmd.Parameters("@nama").Value = dokter.NamaDokter

            SQLcmd.Parameters.Add("@noTelepon", SqlDbType.NVarChar, 100)
            SQLcmd.Parameters("@noTelepon").Direction = ParameterDirection.Input
            SQLcmd.Parameters("@noTelepon").Value = dokter.NoTelp

            SQLcmd.Parameters.Add("@tglLahir", SqlDbType.Date)
            SQLcmd.Parameters("@tglLahir").Direction = ParameterDirection.Input
            SQLcmd.Parameters("@tglLahir").Value = dokter.TglLahir

            SQLcmd.Parameters.Add("@usia", SqlDbType.Int)
            SQLcmd.Parameters("@usia").Direction = ParameterDirection.Input
            SQLcmd.Parameters("@usia").Value = dokter.Usia

            SQLcmd.Parameters.Add("@jenisKelamin", SqlDbType.NVarChar, 50)
            SQLcmd.Parameters("@jenisKelamin").Direction = ParameterDirection.Input
            SQLcmd.Parameters("@jenisKelamin").Value = dokter.JK

            SQLcmd.Parameters.Add("@jabatan", SqlDbType.NVarChar, 100)
            SQLcmd.Parameters("@jabatan").Direction = ParameterDirection.Input
            SQLcmd.Parameters("@jabatan").Value = dokter.Jabatan

            SQLcmd.Parameters.Add("@status", SqlDbType.Int)
            SQLcmd.Parameters("@status").Direction = ParameterDirection.Input
            If dokter.Status = "Active" Then
                SQLcmd.Parameters("@status").Value = 1
            Else
                SQLcmd.Parameters("@status").Value = 0
            End If


            'Code untuk menjalankan tiap hal di atas
            SQLcmd.ExecuteNonQuery()

            Return 1

        Catch ex As Exception
            MessageBox.Show("Error Update Data Dokter: " & ex.Message,
                            "ERROR DBA.DokterUpdate()",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
            Return -1

        Finally
            CloseSqlConn()
        End Try

    End Function

    Public Function DokterGambarInsert(IdDokter As Integer, DataFoto As Byte()) As Integer

        Try
            OpenSqlConn()

            Dim SQLcmd As New SqlCommand("usp_DokterGambarInsert", SqlConn)
            SQLcmd.CommandType = CommandType.StoredProcedure

            SQLcmd.Parameters.Add("@IdDokter", SqlDbType.Int)
            SQLcmd.Parameters("@IdDokter").Direction = ParameterDirection.Input
            SQLcmd.Parameters("@IdDokter").Value = IdDokter

            SQLcmd.Parameters.Add("@Gambar", SqlDbType.Image)
            SQLcmd.Parameters("@Gambar").Direction = ParameterDirection.Input
            SQLcmd.Parameters("@Gambar").Value = DataFoto

            SQLcmd.ExecuteNonQuery()

            Return 1

        Catch ex As Exception
            MessageBox.Show("Error Insert Gambar Dokter: " & ex.Message,
                            "ERROR DBA.DokterGambarInsert()",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
            Return -1
        Finally
            OpenSqlConn()
        End Try

    End Function

    Public Function DokterGambar(IdDokter As Integer) As Byte()

        Try
            OpenSqlConn()

            Dim SQLcmd As New SqlCommand("usp_DokterFotoDetil", SqlConn)
            SQLcmd.CommandType = CommandType.StoredProcedure

            SQLcmd.Parameters.Add("@idDokter", SqlDbType.Int)
            SQLcmd.Parameters("@idDokter").Direction = ParameterDirection.Input
            SQLcmd.Parameters("@idDokter").Value = IdDokter

            ''Execute Scalar = execute yg return nya baris pertama, kolom pertama = 1 single value saja
            Dim DataFoto As Byte() = DirectCast(SQLcmd.ExecuteScalar(), Byte())

            Return DataFoto

        Catch ex As Exception
            MessageBox.Show("Error DokterGambar: " & ex.Message,
                            "ERROR DBA.DokterFotoDetil()",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
            Return {0} ''kalau eror
        Finally
            CloseSqlConn()
        End Try

    End Function

    Public Function DokterSpesialisasiDetil() As DataTable

        Dim DTSpesifikasi As New DataTable

        Try
            OpenSqlConn()
            Dim DA As New SqlDataAdapter("usp_DokterSpesialisasiDetil", SqlConn)
            DA.SelectCommand.CommandType = CommandType.StoredProcedure
            DA.Fill(DTSpesifikasi)
            Return DTSpesifikasi

        Catch ex As Exception
            MessageBox.Show("Error Pengambilan Data Spesialisasi Detil: " & ex.Message,
                            "ERROR DBA.DokterSpesialisasiDetil()",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
            Return DTSpesifikasi
        Finally
            CloseSqlConn()
        End Try

    End Function

    Public Function PasienUpdate(pasien As Patient) As Integer

        Try
            OpenSqlConn()

            'Memanggil usp dengan command
            Dim SQLcmd As New SqlCommand("usp_PasienUpdate", SqlConn)
            SQLcmd.CommandType = CommandType.StoredProcedure
            SQLcmd.Parameters.Add("@idPasien", SqlDbType.Int)
            SQLcmd.Parameters("@idPasien").Direction = ParameterDirection.Input
            SQLcmd.Parameters("@idPasien").Value = pasien.IdPasien

            SQLcmd.Parameters.Add("@nama", SqlDbType.NVarChar, 255)
            SQLcmd.Parameters("@nama").Direction = ParameterDirection.Input
            SQLcmd.Parameters("@nama").Value = pasien.NamaPasien

            SQLcmd.Parameters.Add("@noTelepon", SqlDbType.NVarChar, 15)
            SQLcmd.Parameters("@noTelepon").Direction = ParameterDirection.Input
            SQLcmd.Parameters("@noTelepon").Value = pasien.NoTelp

            SQLcmd.Parameters.Add("@tglLahir", SqlDbType.Date)
            SQLcmd.Parameters("@tglLahir").Direction = ParameterDirection.Input
            SQLcmd.Parameters("@tglLahir").Value = pasien.TglLahir

            SQLcmd.Parameters.Add("@tglDaftar", SqlDbType.Date)
            SQLcmd.Parameters("@tglDaftar").Direction = ParameterDirection.Input
            SQLcmd.Parameters("@tglDaftar").Value = pasien.TglDaftar

            SQLcmd.Parameters.Add("@usia", SqlDbType.Int)
            SQLcmd.Parameters("@usia").Direction = ParameterDirection.Input
            SQLcmd.Parameters("@usia").Value = pasien.Usia

            SQLcmd.Parameters.Add("@jenisKelamin", SqlDbType.NVarChar, 50)
            SQLcmd.Parameters("@jenisKelamin").Direction = ParameterDirection.Input
            SQLcmd.Parameters("@jenisKelamin").Value = pasien.JK

            'Code untuk menjalankan tiap hal di atas
            SQLcmd.ExecuteNonQuery()

            Return 1

        Catch ex As Exception
            MessageBox.Show("Error Update Data Pasien: " & ex.Message,
                            "ERROR DBA.PasienUpdate()",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
            Return -1

        Finally
            CloseSqlConn()
        End Try

    End Function

    Public Function PasienInsert(pasien As Patient) As Integer

        Try
            OpenSqlConn()

            'Memanggil usp dengan command
            Dim SQLcmd As New SqlCommand("usp_PasienInsert", SqlConn)
            SQLcmd.CommandType = CommandType.StoredProcedure

            SQLcmd.Parameters.Add("@nama", SqlDbType.NVarChar, 255)
            SQLcmd.Parameters("@nama").Direction = ParameterDirection.Input
            SQLcmd.Parameters("@nama").Value = pasien.NamaPasien

            SQLcmd.Parameters.Add("@noTelepon", SqlDbType.NVarChar, 100)
            SQLcmd.Parameters("@noTelepon").Direction = ParameterDirection.Input
            SQLcmd.Parameters("@noTelepon").Value = pasien.NoTelp

            SQLcmd.Parameters.Add("@tglLahir", SqlDbType.Date)
            SQLcmd.Parameters("@tglLahir").Direction = ParameterDirection.Input
            SQLcmd.Parameters("@tglLahir").Value = pasien.TglLahir

            SQLcmd.Parameters.Add("@usia", SqlDbType.Int)
            SQLcmd.Parameters("@usia").Direction = ParameterDirection.Input
            SQLcmd.Parameters("@usia").Value = pasien.Usia

            SQLcmd.Parameters.Add("@jenisKelamin", SqlDbType.NVarChar, 50)
            SQLcmd.Parameters("@jenisKelamin").Direction = ParameterDirection.Input
            SQLcmd.Parameters("@jenisKelamin").Value = pasien.JK

            SQLcmd.Parameters.Add("@tglDaftar", SqlDbType.Date)
            SQLcmd.Parameters("@tglDaftar").Direction = ParameterDirection.Input
            SQLcmd.Parameters("@tglDaftar").Value = pasien.TglDaftar

            'Code untuk menjalankan tiap hal di atas
            SQLcmd.ExecuteNonQuery()

            Return 1

        Catch ex As Exception
            MessageBox.Show("Error Insert Data Pasien: " & ex.Message,
                            "ERROR DBA.PasienInsert()",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
            Return -1

        Finally
            CloseSqlConn()
        End Try

    End Function

    Public Function DokterListLayanan() As DataTable

        Dim DTLayanan As New DataTable

        Try
            OpenSqlConn()
            Dim DA As New SqlDataAdapter("usp_JenisLayanan", SqlConn)
            DA.SelectCommand.CommandType = CommandType.StoredProcedure
            DA.Fill(DTLayanan)
            Return DTLayanan

        Catch ex As Exception
            MessageBox.Show("Error Pengambilan Data Jenis Layanan: " & ex.Message,
                            "ERROR DBA.JenisLayanan()",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
            Return DTLayanan
        Finally
            CloseSqlConn()
        End Try

    End Function

    Public Function BookingInsert(jenis As Integer, tglBooking As Date, idDokter As Integer,
                                  idPasien As Integer, tglSesi As String, jam As String,
                                  durasi As Integer, JumlahBooking As Integer) As Integer

        Dim IdBooking As Integer = 0
        Try
            OpenSqlConn()

            Dim SqlCmd As New SqlCommand("usp_BookingInsert", SqlConn)
            SqlCmd.CommandType = CommandType.StoredProcedure

            SqlCmd.Parameters.Add("@idDok", SqlDbType.Int)
            SqlCmd.Parameters("@idDok").Direction = ParameterDirection.Input
            SqlCmd.Parameters("@idDok").Value = idDokter

            SqlCmd.Parameters.Add("@idPasien", SqlDbType.Int)
            SqlCmd.Parameters("@idPasien").Direction = ParameterDirection.Input
            SqlCmd.Parameters("@idPasien").Value = idPasien

            SqlCmd.Parameters.Add("@durasi_jam", SqlDbType.Int)
            SqlCmd.Parameters("@durasi_jam").Direction = ParameterDirection.Input
            SqlCmd.Parameters("@durasi_jam").Value = durasi

            SqlCmd.Parameters.Add("@jenis", SqlDbType.Int)
            SqlCmd.Parameters("@jenis").Direction = ParameterDirection.Input
            SqlCmd.Parameters("@jenis").Value = jenis

            SqlCmd.Parameters.Add("@tgl_booking", SqlDbType.Date)
            SqlCmd.Parameters("@tgl_booking").Direction = ParameterDirection.Input
            SqlCmd.Parameters("@tgl_booking").Value = tglBooking

            SqlCmd.Parameters.Add("@tgl_sesi", SqlDbType.Date)
            SqlCmd.Parameters("@tgl_sesi").Direction = ParameterDirection.Input
            SqlCmd.Parameters("@tgl_sesi").Value = tglSesi

            SqlCmd.Parameters.Add("@jam_sesi", SqlDbType.DateTime)
            SqlCmd.Parameters("@jam_sesi").Direction = ParameterDirection.Input
            SqlCmd.Parameters("@jam_sesi").Value = jam

            IdBooking = SqlCmd.ExecuteScalar()

            If IdBooking = 0 Then
                Return -1
            Else
                'For i As Integer = 1 To JumlahBooking
                SqlCmd = New SqlCommand("usp_DBookingInsert", SqlConn)
                    SqlCmd.CommandType = CommandType.StoredProcedure

                    SqlCmd.Parameters.Add("@idBooking", SqlDbType.Int)
                    SqlCmd.Parameters("@idBooking").Direction = ParameterDirection.Input
                    SqlCmd.Parameters("@idBooking").Value = IdBooking

                    SqlCmd.Parameters.Add("@idDokter", SqlDbType.Int)
                    SqlCmd.Parameters("@idDokter").Direction = ParameterDirection.Input
                    SqlCmd.Parameters("@idDokter").Value = idDokter

                    SqlCmd.Parameters.Add("@idPasien", SqlDbType.Int)
                    SqlCmd.Parameters("@idPasien").Direction = ParameterDirection.Input
                    SqlCmd.Parameters("@idPasien").Value = idPasien

                    SqlCmd.Parameters.Add("@durasi_jam", SqlDbType.Int)
                    SqlCmd.Parameters("@durasi_jam").Direction = ParameterDirection.Input
                    SqlCmd.Parameters("@durasi_jam").Value = durasi

                    SqlCmd.Parameters.Add("@tglSesi", SqlDbType.Date)
                    SqlCmd.Parameters("@tglSesi").Direction = ParameterDirection.Input
                    SqlCmd.Parameters("@tglSesi").Value = tglSesi

                    SqlCmd.Parameters.Add("@jam", SqlDbType.Time)
                    SqlCmd.Parameters("@jam").Direction = ParameterDirection.Input
                    SqlCmd.Parameters("@jam").Value = jam

                    SqlCmd.ExecuteNonQuery()
                '    i += 1
                'Next
            End If
            Return 1
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERROR DBA.BookingInsert()",
                           MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return -2
        Finally
            CloseSqlConn()
        End Try

    End Function

    Public Function BookingListAktif(IdDokter As Integer, Status As Integer) As DataTable

        Dim DTBookingAktif As New DataTable

        Try
            OpenSqlConn()

            Dim SqlCmd As New SqlCommand("usp_BookingListAktif", SqlConn)
            SqlCmd.CommandType = CommandType.StoredProcedure

            SqlCmd.Parameters.Add("@IdDokter", SqlDbType.Int).Value = IdDokter
            SqlCmd.Parameters.Add("@Status", SqlDbType.Int).Value = Status
            Dim DA As New SqlDataAdapter(SqlCmd)
            DA.Fill(DTBookingAktif)

            ' Kembalikan DataTable yang terisi
            Return DTBookingAktif

        Catch ex As Exception
            MessageBox.Show("Error Pengambilan Data BookingAktif: " & ex.Message,
                            "ERROR DBA.BookingListAktif()",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
            Return DTBookingAktif
        Finally
            CloseSqlConn()
        End Try

    End Function

    Public Function BookingListDetil() As DataTable

        Dim DTBooking As New DataTable

        Try
            OpenSqlConn()
            Dim DA As New SqlDataAdapter("usp_BookingListDetil", SqlConn)
            DA.SelectCommand.CommandType = CommandType.StoredProcedure
            DA.Fill(DTBooking)
            Return DTBooking

        Catch ex As Exception
            MessageBox.Show("Error Pengambilan Data BookingDetil: " & ex.Message,
                            "ERROR DBA.BookingListDetil()",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
            Return DTBooking
        Finally
            CloseSqlConn()
        End Try

    End Function

    Public Function UpdateStatusBooking(IdDetailBooking As Integer, Status As Integer) As Integer

        Try
            OpenSqlConn()

            Dim SqlCmd As New SqlCommand("usp_UpdateStatusBooking", SqlConn)
            SqlCmd.CommandType = CommandType.StoredProcedure

            SqlCmd.Parameters.Add("@IdDetailBooking", SqlDbType.Int)
            SqlCmd.Parameters("@IdDetailBooking").Direction = ParameterDirection.Input
            SqlCmd.Parameters("@IdDetailBooking").Value = IdDetailBooking

            SqlCmd.Parameters.Add("@Status", SqlDbType.Int)
            SqlCmd.Parameters("@Status").Direction = ParameterDirection.Input
            SqlCmd.Parameters("@Status").Value = Status

            SqlCmd.ExecuteNonQuery()
            Return 1

        Catch ex As Exception
            MessageBox.Show("Error Update Status Booking: " & ex.Message,
                            "ERROR DBA.UpdateStatusBooking()",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
            Return -1
        Finally
            CloseSqlConn()
        End Try

    End Function

    Public Function BookingListComplete(IdDokter As Integer, Status As Integer) As DataTable

        Dim DTBookingAktif As New DataTable

        Try
            OpenSqlConn()

            Dim SqlCmd As New SqlCommand("usp_BookingListCompleted", SqlConn)
            SqlCmd.CommandType = CommandType.StoredProcedure

            SqlCmd.Parameters.Add("@IdDokter", SqlDbType.Int).Value = IdDokter
            SqlCmd.Parameters.Add("@Status", SqlDbType.Int).Value = Status
            Dim DA As New SqlDataAdapter(SqlCmd)
            DA.Fill(DTBookingAktif)

            ' Kembalikan DataTable yang terisi
            Return DTBookingAktif

        Catch ex As Exception
            MessageBox.Show("Error Pengambilan Data BookingComplete: " & ex.Message,
                            "ERROR DBA.BookingListComplete()",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
            Return DTBookingAktif
        Finally
            CloseSqlConn()
        End Try

    End Function

    Public Function UserLogin(Uname As String, PasswordChipper As String) As User
        Dim p As User
        Try
            OpenSqlConn()
            Dim SQLCmd As New SqlCommand("usp_UserLogin", Me.SqlConn)
            SQLCmd.CommandType = CommandType.StoredProcedure

            SQLCmd.Parameters.Add("@Uname", SqlDbType.NVarChar, 100)
            SQLCmd.Parameters("@Uname").Direction = ParameterDirection.Input
            SQLCmd.Parameters("@Uname").Value = Uname

            SQLCmd.Parameters.Add("@Upass", SqlDbType.NVarChar, -1)
            SQLCmd.Parameters("@Upass").Direction = ParameterDirection.Input
            SQLCmd.Parameters("@Upass").Value = PasswordChipper

            Dim reader As SqlDataReader
            reader = SQLCmd.ExecuteReader()

            While reader.Read
                If reader.HasRows() Then
                    p = New User(reader.Item("IdUser"),
                                 reader.Item("UsernameUser"),
                                 reader.Item("HakAksesUser"))
                    Return p
                Else
                    p = Nothing
                End If
            End While
            reader.Close()
            Return Nothing
        Catch ex As Exception
            MessageBox.Show("Error Data Login: " & ex.Message,
                            "ERROR DBA.UserLogin()",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
            Return Nothing
        Finally
            CloseSqlConn()
        End Try
    End Function

    Public Function PenggunaInsert(ByVal Pengguna As User, IdDokter As Integer, IdAdmin As Integer) As Integer
        Try
            OpenSqlConn()
            Dim SQLCmd As New SqlCommand("usp_userInsert", Me.SqlConn)
            SQLCmd.CommandType = CommandType.StoredProcedure

            SQLCmd.Parameters.Add("@uname", SqlDbType.NVarChar, 100)
            SQLCmd.Parameters("@uname").Direction = ParameterDirection.Input
            SQLCmd.Parameters("@uname").Value = Pengguna.Uname

            SQLCmd.Parameters.Add("@upass", SqlDbType.NVarChar, -1)
            SQLCmd.Parameters("@upass").Direction = ParameterDirection.Input
            SQLCmd.Parameters("@upass").Value = Pengguna.Upass

            SQLCmd.Parameters.Add("@HakAkses", SqlDbType.Int)
            SQLCmd.Parameters("@HakAkses").Direction = ParameterDirection.Input
            SQLCmd.Parameters("@HakAkses").Value = Pengguna.HakAksesUser

            SQLCmd.Parameters.Add("@idAdmin", SqlDbType.Int)
            SQLCmd.Parameters("@idAdmin").Direction = ParameterDirection.Input
            SQLCmd.Parameters("@idAdmin").Value = IdAdmin

            SQLCmd.Parameters.Add("@idDokter", SqlDbType.Int)
            SQLCmd.Parameters("@idDokter").Direction = ParameterDirection.Input
            SQLCmd.Parameters("@idDokter").Value = IdDokter

            SQLCmd.ExecuteNonQuery()
            Return 1
        Catch ex As Exception
            MessageBox.Show("Error Insert Pengguna: " & ex.Message,
                            "ERROR DBA.PenggunaInsert()",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
            Return -1
        Finally
            CloseSqlConn()
        End Try
    End Function

    Public Function PenggunaList() As DataTable
        Dim DT As New DataTable
        Try
            Dim DA As New SqlDataAdapter("usp_UserList", Me.SqlConn)
            DA.SelectCommand.CommandType = CommandType.StoredProcedure
            DA.Fill(DT)
            Return DT
        Catch ex As Exception
            Return DT
        Finally
            CloseSqlConn()
        End Try
    End Function

    Public Function AdminListDetil() As DataTable

        Dim DTAdmin As New DataTable

        Try
            OpenSqlConn()
            Dim DA As New SqlDataAdapter("usp_AdminListDetil", SqlConn)
            DA.SelectCommand.CommandType = CommandType.StoredProcedure
            DA.Fill(DTAdmin)
            Return DTAdmin

        Catch ex As Exception
            MessageBox.Show("Error Pengambilan Data Admin: " & ex.Message,
                            "ERROR DBA.AdminListDetil()",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
            Return DTAdmin
        Finally
            CloseSqlConn()

        End Try

    End Function

    Public Function GetIdDokter(IdUser As Integer) As Integer

        Dim IdDokter As Integer = 0

        Try
            ' Buka koneksi SQL
            OpenSqlConn()

            ' Siapkan command untuk prosedur tersimpan
            Using cmd As New SqlCommand("usp_GetIdDokter", SqlConn)
                cmd.CommandType = CommandType.StoredProcedure

                ' Tambahkan parameter input
                cmd.Parameters.AddWithValue("@IdUser", IdUser)

                ' Tambahkan parameter output
                Dim outputParam As New SqlParameter("@IdDokter", SqlDbType.Int)
                outputParam.Direction = ParameterDirection.Output
                cmd.Parameters.Add(outputParam)

                ' Eksekusi perintah
                cmd.ExecuteNonQuery()

                ' Ambil nilai output
                IdDokter = Convert.ToInt32(cmd.Parameters("@IdDokter").Value)
            End Using

        Catch ex As Exception
            MessageBox.Show("Error Pengambilan Data Dokter: " & ex.Message,
                            "ERROR DBA.GetIdDokter()",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
        Finally
            ' Tutup koneksi SQL
            CloseSqlConn()
        End Try

        Return IdDokter
    End Function
End Class
