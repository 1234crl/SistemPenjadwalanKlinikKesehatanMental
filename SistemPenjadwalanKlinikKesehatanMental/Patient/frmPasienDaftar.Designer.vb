<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPasienDaftar
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.CrownGroupBox1 = New ReaLTaiizor.Controls.CrownGroupBox()
        Me.cbStatusPasien = New System.Windows.Forms.ComboBox()
        Me.CrownGroupBox2 = New ReaLTaiizor.Controls.CrownGroupBox()
        Me.tbSearch = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgvPasien = New System.Windows.Forms.DataGridView()
        Me.IdPasienCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TanggalDaftarCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamaPasienCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JKPasienCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NoTelpCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TanggalLahirCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsiaCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmPasien = New ReaLTaiizor.Controls.CrownContextMenuStrip()
        Me.AddNewPatientToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KToolStripMenuItem = New System.Windows.Forms.ToolStripSeparator()
        Me.DetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CrownGroupBox1.SuspendLayout()
        Me.CrownGroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvPasien, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmPasien.SuspendLayout()
        Me.SuspendLayout()
        '
        'CrownGroupBox1
        '
        Me.CrownGroupBox1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.CrownGroupBox1.Controls.Add(Me.cbStatusPasien)
        Me.CrownGroupBox1.Location = New System.Drawing.Point(4, 12)
        Me.CrownGroupBox1.Name = "CrownGroupBox1"
        Me.CrownGroupBox1.Size = New System.Drawing.Size(500, 126)
        Me.CrownGroupBox1.TabIndex = 0
        Me.CrownGroupBox1.TabStop = False
        Me.CrownGroupBox1.Text = "Patient Status"
        '
        'cbStatusPasien
        '
        Me.cbStatusPasien.FormattingEnabled = True
        Me.cbStatusPasien.Items.AddRange(New Object() {"Not in Appointment", "In Appointment", "Show All"})
        Me.cbStatusPasien.Location = New System.Drawing.Point(21, 53)
        Me.cbStatusPasien.Name = "cbStatusPasien"
        Me.cbStatusPasien.Size = New System.Drawing.Size(457, 33)
        Me.cbStatusPasien.TabIndex = 0
        '
        'CrownGroupBox2
        '
        Me.CrownGroupBox2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.CrownGroupBox2.Controls.Add(Me.tbSearch)
        Me.CrownGroupBox2.Location = New System.Drawing.Point(510, 12)
        Me.CrownGroupBox2.Name = "CrownGroupBox2"
        Me.CrownGroupBox2.Size = New System.Drawing.Size(508, 126)
        Me.CrownGroupBox2.TabIndex = 1
        Me.CrownGroupBox2.TabStop = False
        Me.CrownGroupBox2.Text = "Search"
        '
        'tbSearch
        '
        Me.tbSearch.Location = New System.Drawing.Point(16, 53)
        Me.tbSearch.Multiline = True
        Me.tbSearch.Name = "tbSearch"
        Me.tbSearch.Size = New System.Drawing.Size(474, 35)
        Me.tbSearch.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dgvPasien)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox1.Location = New System.Drawing.Point(0, 159)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1023, 474)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Patient List"
        '
        'dgvPasien
        '
        Me.dgvPasien.AllowUserToAddRows = False
        Me.dgvPasien.AllowUserToDeleteRows = False
        Me.dgvPasien.AllowUserToResizeColumns = False
        Me.dgvPasien.AllowUserToResizeRows = False
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvPasien.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.MenuText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvPasien.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvPasien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPasien.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdPasienCol, Me.TanggalDaftarCol, Me.NamaPasienCol, Me.JKPasienCol, Me.NoTelpCol, Me.TanggalLahirCol, Me.UsiaCol, Me.StatusCol})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.InfoText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvPasien.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvPasien.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvPasien.Location = New System.Drawing.Point(3, 27)
        Me.dgvPasien.MultiSelect = False
        Me.dgvPasien.Name = "dgvPasien"
        Me.dgvPasien.ReadOnly = True
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.InfoText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvPasien.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvPasien.RowHeadersVisible = False
        Me.dgvPasien.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.LightBlue
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.LightGray
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvPasien.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvPasien.RowTemplate.Height = 28
        Me.dgvPasien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPasien.Size = New System.Drawing.Size(1017, 444)
        Me.dgvPasien.TabIndex = 0
        '
        'IdPasienCol
        '
        Me.IdPasienCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.IdPasienCol.DataPropertyName = "IdPasien"
        Me.IdPasienCol.HeaderText = "ID"
        Me.IdPasienCol.MinimumWidth = 8
        Me.IdPasienCol.Name = "IdPasienCol"
        Me.IdPasienCol.ReadOnly = True
        Me.IdPasienCol.Width = 66
        '
        'TanggalDaftarCol
        '
        Me.TanggalDaftarCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.TanggalDaftarCol.DataPropertyName = "TanggalDaftarPasien"
        Me.TanggalDaftarCol.HeaderText = "Tanggal Daftar"
        Me.TanggalDaftarCol.MinimumWidth = 8
        Me.TanggalDaftarCol.Name = "TanggalDaftarCol"
        Me.TanggalDaftarCol.ReadOnly = True
        Me.TanggalDaftarCol.Width = 163
        '
        'NamaPasienCol
        '
        Me.NamaPasienCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.NamaPasienCol.DataPropertyName = "NamaPasien"
        Me.NamaPasienCol.HeaderText = "Nama"
        Me.NamaPasienCol.MinimumWidth = 8
        Me.NamaPasienCol.Name = "NamaPasienCol"
        Me.NamaPasienCol.ReadOnly = True
        '
        'JKPasienCol
        '
        Me.JKPasienCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.JKPasienCol.DataPropertyName = "JKPasien"
        Me.JKPasienCol.HeaderText = "Jenis Kelamin"
        Me.JKPasienCol.MinimumWidth = 8
        Me.JKPasienCol.Name = "JKPasienCol"
        Me.JKPasienCol.ReadOnly = True
        Me.JKPasienCol.Width = 152
        '
        'NoTelpCol
        '
        Me.NoTelpCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.NoTelpCol.DataPropertyName = "NoTeleponPasien"
        Me.NoTelpCol.HeaderText = "Nomor Telepon"
        Me.NoTelpCol.MinimumWidth = 8
        Me.NoTelpCol.Name = "NoTelpCol"
        Me.NoTelpCol.ReadOnly = True
        Me.NoTelpCol.Width = 171
        '
        'TanggalLahirCol
        '
        Me.TanggalLahirCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.TanggalLahirCol.DataPropertyName = "TanggalLahirPasien"
        Me.TanggalLahirCol.HeaderText = "Tanggal Lahir"
        Me.TanggalLahirCol.MinimumWidth = 8
        Me.TanggalLahirCol.Name = "TanggalLahirCol"
        Me.TanggalLahirCol.ReadOnly = True
        Me.TanggalLahirCol.Width = 151
        '
        'UsiaCol
        '
        Me.UsiaCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.UsiaCol.DataPropertyName = "UsiaPasien"
        Me.UsiaCol.HeaderText = "Usia"
        Me.UsiaCol.MinimumWidth = 8
        Me.UsiaCol.Name = "UsiaCol"
        Me.UsiaCol.ReadOnly = True
        Me.UsiaCol.Width = 81
        '
        'StatusCol
        '
        Me.StatusCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.StatusCol.DataPropertyName = "StatusPasien"
        Me.StatusCol.HeaderText = "Status"
        Me.StatusCol.MinimumWidth = 8
        Me.StatusCol.Name = "StatusCol"
        Me.StatusCol.ReadOnly = True
        '
        'cmPasien
        '
        Me.cmPasien.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.cmPasien.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.cmPasien.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.cmPasien.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddNewPatientToolStripMenuItem, Me.KToolStripMenuItem, Me.DetailsToolStripMenuItem})
        Me.cmPasien.Name = "cmPasien"
        Me.cmPasien.Size = New System.Drawing.Size(241, 108)
        '
        'AddNewPatientToolStripMenuItem
        '
        Me.AddNewPatientToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.AddNewPatientToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.AddNewPatientToolStripMenuItem.Name = "AddNewPatientToolStripMenuItem"
        Me.AddNewPatientToolStripMenuItem.Size = New System.Drawing.Size(240, 32)
        Me.AddNewPatientToolStripMenuItem.Text = "Add New Patient"
        '
        'KToolStripMenuItem
        '
        Me.KToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.KToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.KToolStripMenuItem.Margin = New System.Windows.Forms.Padding(0, 0, 0, 1)
        Me.KToolStripMenuItem.Name = "KToolStripMenuItem"
        Me.KToolStripMenuItem.Size = New System.Drawing.Size(237, 6)
        '
        'DetailsToolStripMenuItem
        '
        Me.DetailsToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.DetailsToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.DetailsToolStripMenuItem.Name = "DetailsToolStripMenuItem"
        Me.DetailsToolStripMenuItem.Size = New System.Drawing.Size(240, 32)
        Me.DetailsToolStripMenuItem.Text = "Details"
        '
        'frmPasienDaftar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1023, 633)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.CrownGroupBox2)
        Me.Controls.Add(Me.CrownGroupBox1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmPasienDaftar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmPasienDaftar"
        Me.CrownGroupBox1.ResumeLayout(False)
        Me.CrownGroupBox2.ResumeLayout(False)
        Me.CrownGroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgvPasien, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmPasien.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CrownGroupBox1 As ReaLTaiizor.Controls.CrownGroupBox
    Friend WithEvents cbStatusPasien As ComboBox
    Friend WithEvents CrownGroupBox2 As ReaLTaiizor.Controls.CrownGroupBox
    Friend WithEvents tbSearch As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dgvPasien As DataGridView
    Friend WithEvents IdPasienCol As DataGridViewTextBoxColumn
    Friend WithEvents TanggalDaftarCol As DataGridViewTextBoxColumn
    Friend WithEvents NamaPasienCol As DataGridViewTextBoxColumn
    Friend WithEvents JKPasienCol As DataGridViewTextBoxColumn
    Friend WithEvents NoTelpCol As DataGridViewTextBoxColumn
    Friend WithEvents TanggalLahirCol As DataGridViewTextBoxColumn
    Friend WithEvents UsiaCol As DataGridViewTextBoxColumn
    Friend WithEvents StatusCol As DataGridViewTextBoxColumn
    Friend WithEvents cmPasien As ReaLTaiizor.Controls.CrownContextMenuStrip
    Friend WithEvents AddNewPatientToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KToolStripMenuItem As ToolStripSeparator
    Friend WithEvents DetailsToolStripMenuItem As ToolStripMenuItem
End Class
