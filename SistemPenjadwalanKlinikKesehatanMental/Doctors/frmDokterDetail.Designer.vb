<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDokterDetail
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dtpDateOfBirth = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tbUsia = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbJabatan = New System.Windows.Forms.ComboBox()
        Me.cbGender = New System.Windows.Forms.ComboBox()
        Me.btnCancel = New ReaLTaiizor.Controls.Button()
        Me.btnSave = New ReaLTaiizor.Controls.Button()
        Me.tbNoTelp = New System.Windows.Forms.TextBox()
        Me.tbNama = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gbStatus = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.rbStatusAct = New System.Windows.Forms.RadioButton()
        Me.rbStatusInact = New System.Windows.Forms.RadioButton()
        Me.tbGambar = New System.Windows.Forms.TextBox()
        Me.btnPilihGambar = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.pbGambarDokter = New System.Windows.Forms.PictureBox()
        Me.OFD = New System.Windows.Forms.OpenFileDialog()
        Me.GroupBox1.SuspendLayout()
        Me.gbStatus.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.pbGambarDokter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.tbGambar)
        Me.GroupBox1.Controls.Add(Me.btnPilihGambar)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.gbStatus)
        Me.GroupBox1.Controls.Add(Me.dtpDateOfBirth)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.tbUsia)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.cbJabatan)
        Me.GroupBox1.Controls.Add(Me.cbGender)
        Me.GroupBox1.Controls.Add(Me.btnCancel)
        Me.GroupBox1.Controls.Add(Me.btnSave)
        Me.GroupBox1.Controls.Add(Me.tbNoTelp)
        Me.GroupBox1.Controls.Add(Me.tbNama)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(942, 621)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Doctor Profile"
        '
        'dtpDateOfBirth
        '
        Me.dtpDateOfBirth.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDateOfBirth.Location = New System.Drawing.Point(583, 328)
        Me.dtpDateOfBirth.Name = "dtpDateOfBirth"
        Me.dtpDateOfBirth.Size = New System.Drawing.Size(333, 34)
        Me.dtpDateOfBirth.TabIndex = 37
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label7.Location = New System.Drawing.Point(433, 330)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(126, 28)
        Me.Label7.TabIndex = 36
        Me.Label7.Text = "Date of Birth:"
        '
        'tbUsia
        '
        Me.tbUsia.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbUsia.Location = New System.Drawing.Point(583, 104)
        Me.tbUsia.Multiline = True
        Me.tbUsia.Name = "tbUsia"
        Me.tbUsia.Size = New System.Drawing.Size(333, 40)
        Me.tbUsia.TabIndex = 35
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label6.Location = New System.Drawing.Point(508, 107)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 28)
        Me.Label6.TabIndex = 34
        Me.Label6.Text = "Age:"
        '
        'cbJabatan
        '
        Me.cbJabatan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbJabatan.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbJabatan.FormattingEnabled = True
        Me.cbJabatan.Items.AddRange(New Object() {"Psikolog", "Sp. Jiwa"})
        Me.cbJabatan.Location = New System.Drawing.Point(583, 204)
        Me.cbJabatan.Name = "cbJabatan"
        Me.cbJabatan.Size = New System.Drawing.Size(333, 36)
        Me.cbJabatan.TabIndex = 32
        '
        'cbGender
        '
        Me.cbGender.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbGender.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbGender.FormattingEnabled = True
        Me.cbGender.Items.AddRange(New Object() {"Laki-laki", "Perempuan"})
        Me.cbGender.Location = New System.Drawing.Point(583, 155)
        Me.cbGender.Name = "cbGender"
        Me.cbGender.Size = New System.Drawing.Size(333, 36)
        Me.cbGender.TabIndex = 31
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Transparent
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.EnteredColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btnCancel.Image = Nothing
        Me.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancel.InactiveColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.btnCancel.Location = New System.Drawing.Point(759, 541)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.PressedColor = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.btnCancel.Size = New System.Drawing.Size(157, 52)
        Me.btnCancel.TabIndex = 30
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.Transparent
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.EnteredColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btnSave.Image = Nothing
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.InactiveColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.btnSave.Location = New System.Drawing.Point(572, 541)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.PressedColor = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.btnSave.Size = New System.Drawing.Size(157, 52)
        Me.btnSave.TabIndex = 29
        Me.btnSave.Text = "Save"
        Me.btnSave.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'tbNoTelp
        '
        Me.tbNoTelp.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbNoTelp.Location = New System.Drawing.Point(583, 266)
        Me.tbNoTelp.Multiline = True
        Me.tbNoTelp.Name = "tbNoTelp"
        Me.tbNoTelp.Size = New System.Drawing.Size(333, 40)
        Me.tbNoTelp.TabIndex = 28
        '
        'tbNama
        '
        Me.tbNama.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbNama.Location = New System.Drawing.Point(583, 54)
        Me.tbNama.Multiline = True
        Me.tbNama.Name = "tbNama"
        Me.tbNama.Size = New System.Drawing.Size(333, 40)
        Me.tbNama.TabIndex = 27
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label5.Location = New System.Drawing.Point(479, 155)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 28)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "Gender:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label4.Location = New System.Drawing.Point(411, 271)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(148, 28)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Phone Number:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label2.Location = New System.Drawing.Point(473, 204)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 28)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Position:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label1.Location = New System.Drawing.Point(455, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 28)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Full Name:"
        '
        'gbStatus
        '
        Me.gbStatus.BackColor = System.Drawing.Color.Transparent
        Me.gbStatus.Controls.Add(Me.rbStatusInact)
        Me.gbStatus.Controls.Add(Me.rbStatusAct)
        Me.gbStatus.Location = New System.Drawing.Point(583, 388)
        Me.gbStatus.Name = "gbStatus"
        Me.gbStatus.Size = New System.Drawing.Size(333, 72)
        Me.gbStatus.TabIndex = 38
        Me.gbStatus.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label3.Location = New System.Drawing.Point(490, 419)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 28)
        Me.Label3.TabIndex = 39
        Me.Label3.Text = "Status:"
        '
        'rbStatusAct
        '
        Me.rbStatusAct.AutoSize = True
        Me.rbStatusAct.Location = New System.Drawing.Point(17, 30)
        Me.rbStatusAct.Name = "rbStatusAct"
        Me.rbStatusAct.Size = New System.Drawing.Size(85, 29)
        Me.rbStatusAct.TabIndex = 0
        Me.rbStatusAct.TabStop = True
        Me.rbStatusAct.Text = "Active"
        Me.rbStatusAct.UseVisualStyleBackColor = True
        '
        'rbStatusInact
        '
        Me.rbStatusInact.AutoSize = True
        Me.rbStatusInact.Location = New System.Drawing.Point(221, 30)
        Me.rbStatusInact.Name = "rbStatusInact"
        Me.rbStatusInact.Size = New System.Drawing.Size(97, 29)
        Me.rbStatusInact.TabIndex = 1
        Me.rbStatusInact.TabStop = True
        Me.rbStatusInact.Text = "Inactive"
        Me.rbStatusInact.UseVisualStyleBackColor = True
        '
        'tbGambar
        '
        Me.tbGambar.Location = New System.Drawing.Point(27, 481)
        Me.tbGambar.Multiline = True
        Me.tbGambar.Name = "tbGambar"
        Me.tbGambar.ReadOnly = True
        Me.tbGambar.Size = New System.Drawing.Size(266, 50)
        Me.tbGambar.TabIndex = 42
        '
        'btnPilihGambar
        '
        Me.btnPilihGambar.Location = New System.Drawing.Point(305, 481)
        Me.btnPilihGambar.Name = "btnPilihGambar"
        Me.btnPilihGambar.Size = New System.Drawing.Size(71, 50)
        Me.btnPilihGambar.TabIndex = 41
        Me.btnPilihGambar.Text = "..."
        Me.btnPilihGambar.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.pbGambarDokter)
        Me.GroupBox2.Location = New System.Drawing.Point(27, 34)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(349, 426)
        Me.GroupBox2.TabIndex = 40
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Picture"
        '
        'pbGambarDokter
        '
        Me.pbGambarDokter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pbGambarDokter.Location = New System.Drawing.Point(3, 27)
        Me.pbGambarDokter.Name = "pbGambarDokter"
        Me.pbGambarDokter.Size = New System.Drawing.Size(343, 396)
        Me.pbGambarDokter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbGambarDokter.TabIndex = 0
        Me.pbGambarDokter.TabStop = False
        '
        'OFD
        '
        Me.OFD.FileName = "OpenFileDialog1"
        '
        'frmDokterDetail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(942, 621)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmDokterDetail"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmDokterDetail"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.gbStatus.ResumeLayout(False)
        Me.gbStatus.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.pbGambarDokter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dtpDateOfBirth As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents tbUsia As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cbJabatan As ComboBox
    Friend WithEvents cbGender As ComboBox
    Friend WithEvents btnCancel As ReaLTaiizor.Controls.Button
    Friend WithEvents btnSave As ReaLTaiizor.Controls.Button
    Friend WithEvents tbNoTelp As TextBox
    Friend WithEvents tbNama As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents gbStatus As GroupBox
    Friend WithEvents rbStatusAct As RadioButton
    Friend WithEvents rbStatusInact As RadioButton
    Friend WithEvents tbGambar As TextBox
    Friend WithEvents btnPilihGambar As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents pbGambarDokter As PictureBox
    Friend WithEvents OFD As OpenFileDialog
End Class
