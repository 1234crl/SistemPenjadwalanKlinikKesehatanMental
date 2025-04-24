<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBookingDetail
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.gbStatus = New System.Windows.Forms.GroupBox()
        Me.rbStatusRun = New System.Windows.Forms.RadioButton()
        Me.rbStatusBook = New System.Windows.Forms.RadioButton()
        Me.tbDokter = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpTglBooking = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnBack = New ReaLTaiizor.Controls.Button()
        Me.tbID = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbPasien = New System.Windows.Forms.TextBox()
        Me.tbLayanan = New System.Windows.Forms.TextBox()
        Me.dtpTglSesi = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tbDurasi = New System.Windows.Forms.TextBox()
        Me.tbJam = New System.Windows.Forms.TextBox()
        Me.gbStatus.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbStatus
        '
        Me.gbStatus.BackColor = System.Drawing.Color.Transparent
        Me.gbStatus.Controls.Add(Me.rbStatusRun)
        Me.gbStatus.Controls.Add(Me.rbStatusBook)
        Me.gbStatus.Location = New System.Drawing.Point(342, 354)
        Me.gbStatus.Name = "gbStatus"
        Me.gbStatus.Size = New System.Drawing.Size(409, 72)
        Me.gbStatus.TabIndex = 54
        Me.gbStatus.TabStop = False
        '
        'rbStatusRun
        '
        Me.rbStatusRun.AutoSize = True
        Me.rbStatusRun.Enabled = False
        Me.rbStatusRun.ForeColor = System.Drawing.Color.Black
        Me.rbStatusRun.Location = New System.Drawing.Point(221, 30)
        Me.rbStatusRun.Name = "rbStatusRun"
        Me.rbStatusRun.Size = New System.Drawing.Size(179, 29)
        Me.rbStatusRun.TabIndex = 1
        Me.rbStatusRun.TabStop = True
        Me.rbStatusRun.Text = "Currently Running"
        Me.rbStatusRun.UseVisualStyleBackColor = True
        '
        'rbStatusBook
        '
        Me.rbStatusBook.AutoSize = True
        Me.rbStatusBook.Enabled = False
        Me.rbStatusBook.ForeColor = System.Drawing.Color.Black
        Me.rbStatusBook.Location = New System.Drawing.Point(17, 30)
        Me.rbStatusBook.Name = "rbStatusBook"
        Me.rbStatusBook.Size = New System.Drawing.Size(149, 29)
        Me.rbStatusBook.TabIndex = 0
        Me.rbStatusBook.TabStop = True
        Me.rbStatusBook.Text = "Still in Booked"
        Me.rbStatusBook.UseVisualStyleBackColor = True
        '
        'tbDokter
        '
        Me.tbDokter.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbDokter.Location = New System.Drawing.Point(156, 106)
        Me.tbDokter.Multiline = True
        Me.tbDokter.Name = "tbDokter"
        Me.tbDokter.ReadOnly = True
        Me.tbDokter.Size = New System.Drawing.Size(274, 40)
        Me.tbDokter.TabIndex = 51
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label6.Location = New System.Drawing.Point(55, 185)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 28)
        Me.Label6.TabIndex = 50
        Me.Label6.Text = "Patient:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label3.Location = New System.Drawing.Point(249, 385)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 28)
        Me.Label3.TabIndex = 55
        Me.Label3.Text = "Status:"
        '
        'dtpTglBooking
        '
        Me.dtpTglBooking.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpTglBooking.Location = New System.Drawing.Point(649, 42)
        Me.dtpTglBooking.Name = "dtpTglBooking"
        Me.dtpTglBooking.Size = New System.Drawing.Size(333, 34)
        Me.dtpTglBooking.TabIndex = 53
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label7.Location = New System.Drawing.Point(504, 109)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(127, 28)
        Me.Label7.TabIndex = 52
        Me.Label7.Text = "Session Date:"
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.Transparent
        Me.btnBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBack.EnteredColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btnBack.Image = Nothing
        Me.btnBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBack.InactiveColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.btnBack.Location = New System.Drawing.Point(834, 498)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.PressedColor = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.btnBack.Size = New System.Drawing.Size(157, 52)
        Me.btnBack.TabIndex = 47
        Me.btnBack.Text = "Back"
        Me.btnBack.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'tbID
        '
        Me.tbID.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbID.Location = New System.Drawing.Point(156, 36)
        Me.tbID.Multiline = True
        Me.tbID.Name = "tbID"
        Me.tbID.ReadOnly = True
        Me.tbID.Size = New System.Drawing.Size(90, 40)
        Me.tbID.TabIndex = 44
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label5.Location = New System.Drawing.Point(56, 103)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 28)
        Me.Label5.TabIndex = 43
        Me.Label5.Text = "Doctor:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label4.Location = New System.Drawing.Point(502, 46)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(129, 28)
        Me.Label4.TabIndex = 42
        Me.Label4.Text = "Booked Date:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label2.Location = New System.Drawing.Point(29, 255)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 28)
        Me.Label2.TabIndex = 41
        Me.Label2.Text = "Treatment:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label1.Location = New System.Drawing.Point(19, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 28)
        Me.Label1.TabIndex = 40
        Me.Label1.Text = "ID Booking:"
        '
        'tbPasien
        '
        Me.tbPasien.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbPasien.Location = New System.Drawing.Point(156, 176)
        Me.tbPasien.Multiline = True
        Me.tbPasien.Name = "tbPasien"
        Me.tbPasien.ReadOnly = True
        Me.tbPasien.Size = New System.Drawing.Size(274, 40)
        Me.tbPasien.TabIndex = 56
        '
        'tbLayanan
        '
        Me.tbLayanan.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbLayanan.Location = New System.Drawing.Point(156, 252)
        Me.tbLayanan.Multiline = True
        Me.tbLayanan.Name = "tbLayanan"
        Me.tbLayanan.ReadOnly = True
        Me.tbLayanan.Size = New System.Drawing.Size(274, 40)
        Me.tbLayanan.TabIndex = 57
        '
        'dtpTglSesi
        '
        Me.dtpTglSesi.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpTglSesi.Location = New System.Drawing.Point(651, 110)
        Me.dtpTglSesi.Name = "dtpTglSesi"
        Me.dtpTglSesi.Size = New System.Drawing.Size(333, 34)
        Me.dtpTglSesi.TabIndex = 58
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label8.Location = New System.Drawing.Point(573, 188)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 28)
        Me.Label8.TabIndex = 59
        Me.Label8.Text = "Time:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label9.Location = New System.Drawing.Point(538, 252)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(93, 28)
        Me.Label9.TabIndex = 61
        Me.Label9.Text = "Duration:"
        '
        'tbDurasi
        '
        Me.tbDurasi.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbDurasi.Location = New System.Drawing.Point(649, 252)
        Me.tbDurasi.Multiline = True
        Me.tbDurasi.Name = "tbDurasi"
        Me.tbDurasi.ReadOnly = True
        Me.tbDurasi.Size = New System.Drawing.Size(90, 40)
        Me.tbDurasi.TabIndex = 62
        '
        'tbJam
        '
        Me.tbJam.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbJam.Location = New System.Drawing.Point(649, 182)
        Me.tbJam.Multiline = True
        Me.tbJam.Name = "tbJam"
        Me.tbJam.ReadOnly = True
        Me.tbJam.Size = New System.Drawing.Size(90, 40)
        Me.tbJam.TabIndex = 63
        '
        'frmBookingDetail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1003, 562)
        Me.Controls.Add(Me.tbJam)
        Me.Controls.Add(Me.tbDurasi)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.dtpTglSesi)
        Me.Controls.Add(Me.tbLayanan)
        Me.Controls.Add(Me.tbPasien)
        Me.Controls.Add(Me.gbStatus)
        Me.Controls.Add(Me.tbDokter)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dtpTglBooking)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.tbID)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmBookingDetail"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmBookingDetail"
        Me.gbStatus.ResumeLayout(False)
        Me.gbStatus.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gbStatus As GroupBox
    Friend WithEvents rbStatusRun As RadioButton
    Friend WithEvents rbStatusBook As RadioButton
    Friend WithEvents tbDokter As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents dtpTglBooking As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents btnBack As ReaLTaiizor.Controls.Button
    Friend WithEvents tbID As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents tbPasien As TextBox
    Friend WithEvents tbLayanan As TextBox
    Friend WithEvents dtpTglSesi As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents tbDurasi As TextBox
    Friend WithEvents tbJam As TextBox
End Class
