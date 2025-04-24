<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDokterDaftar
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
        Me.CrownGroupBox1 = New ReaLTaiizor.Controls.CrownGroupBox()
        Me.cbTitles = New ReaLTaiizor.Controls.PoisonComboBox()
        Me.tbSearch = New ReaLTaiizor.Controls.CrownTextBox()
        Me.CrownGroupBox2 = New ReaLTaiizor.Controls.CrownGroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgvDokter = New System.Windows.Forms.DataGridView()
        Me.IdDokterCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamaDokterCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JKCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NoTelpCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TglLahirCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UmurCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JabatanCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmDokter = New ReaLTaiizor.Controls.CrownContextMenuStrip()
        Me.AddNewDoctorsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KToolStripMenuItem = New System.Windows.Forms.ToolStripSeparator()
        Me.DetailProfileToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DetailSpecializationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DetailProfileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CrownGroupBox1.SuspendLayout()
        Me.CrownGroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvDokter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmDokter.SuspendLayout()
        Me.SuspendLayout()
        '
        'CrownGroupBox1
        '
        Me.CrownGroupBox1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.CrownGroupBox1.Controls.Add(Me.cbTitles)
        Me.CrownGroupBox1.Location = New System.Drawing.Point(2, 4)
        Me.CrownGroupBox1.Name = "CrownGroupBox1"
        Me.CrownGroupBox1.Size = New System.Drawing.Size(500, 126)
        Me.CrownGroupBox1.TabIndex = 1
        Me.CrownGroupBox1.TabStop = False
        Me.CrownGroupBox1.Text = "Professionals Titles"
        '
        'cbTitles
        '
        Me.cbTitles.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbTitles.FormattingEnabled = True
        Me.cbTitles.ItemHeight = 23
        Me.cbTitles.Items.AddRange(New Object() {"Psikolog", "Sp. Jiwa", "All"})
        Me.cbTitles.Location = New System.Drawing.Point(21, 53)
        Me.cbTitles.Name = "cbTitles"
        Me.cbTitles.Size = New System.Drawing.Size(455, 29)
        Me.cbTitles.TabIndex = 3
        Me.cbTitles.UseSelectable = True
        '
        'tbSearch
        '
        Me.tbSearch.BackColor = System.Drawing.Color.White
        Me.tbSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbSearch.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbSearch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tbSearch.Location = New System.Drawing.Point(12, 54)
        Me.tbSearch.Name = "tbSearch"
        Me.tbSearch.Size = New System.Drawing.Size(469, 34)
        Me.tbSearch.TabIndex = 4
        '
        'CrownGroupBox2
        '
        Me.CrownGroupBox2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.CrownGroupBox2.Controls.Add(Me.tbSearch)
        Me.CrownGroupBox2.Location = New System.Drawing.Point(508, 4)
        Me.CrownGroupBox2.Name = "CrownGroupBox2"
        Me.CrownGroupBox2.Size = New System.Drawing.Size(514, 126)
        Me.CrownGroupBox2.TabIndex = 2
        Me.CrownGroupBox2.TabStop = False
        Me.CrownGroupBox2.Text = "Search"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dgvDokter)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox1.Location = New System.Drawing.Point(0, 149)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1023, 484)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Psychologist | Psychiatrist List"
        '
        'dgvDokter
        '
        Me.dgvDokter.AllowUserToAddRows = False
        Me.dgvDokter.AllowUserToDeleteRows = False
        Me.dgvDokter.AllowUserToResizeColumns = False
        Me.dgvDokter.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.dgvDokter.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvDokter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDokter.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDokterCol, Me.NamaDokterCol, Me.JKCol, Me.NoTelpCol, Me.StatusCol, Me.TglLahirCol, Me.UmurCol, Me.JabatanCol})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(253, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvDokter.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvDokter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvDokter.Location = New System.Drawing.Point(3, 27)
        Me.dgvDokter.MultiSelect = False
        Me.dgvDokter.Name = "dgvDokter"
        Me.dgvDokter.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(253, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDokter.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvDokter.RowHeadersVisible = False
        Me.dgvDokter.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.dgvDokter.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvDokter.RowTemplate.Height = 28
        Me.dgvDokter.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDokter.Size = New System.Drawing.Size(1017, 454)
        Me.dgvDokter.TabIndex = 0
        '
        'IdDokterCol
        '
        Me.IdDokterCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.IdDokterCol.DataPropertyName = "IdDokter"
        Me.IdDokterCol.HeaderText = "ID"
        Me.IdDokterCol.MinimumWidth = 8
        Me.IdDokterCol.Name = "IdDokterCol"
        Me.IdDokterCol.ReadOnly = True
        Me.IdDokterCol.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.IdDokterCol.Width = 66
        '
        'NamaDokterCol
        '
        Me.NamaDokterCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.NamaDokterCol.DataPropertyName = "NamaDokter"
        Me.NamaDokterCol.HeaderText = "Nama"
        Me.NamaDokterCol.MinimumWidth = 8
        Me.NamaDokterCol.Name = "NamaDokterCol"
        Me.NamaDokterCol.ReadOnly = True
        Me.NamaDokterCol.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'JKCol
        '
        Me.JKCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.JKCol.DataPropertyName = "JKDokter"
        Me.JKCol.HeaderText = "Gender"
        Me.JKCol.MinimumWidth = 8
        Me.JKCol.Name = "JKCol"
        Me.JKCol.ReadOnly = True
        Me.JKCol.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.JKCol.Width = 105
        '
        'NoTelpCol
        '
        Me.NoTelpCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.NoTelpCol.DataPropertyName = "NoTeleponDokter"
        Me.NoTelpCol.HeaderText = "Nomor Telepon"
        Me.NoTelpCol.MinimumWidth = 8
        Me.NoTelpCol.Name = "NoTelpCol"
        Me.NoTelpCol.ReadOnly = True
        Me.NoTelpCol.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.NoTelpCol.Width = 171
        '
        'StatusCol
        '
        Me.StatusCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.StatusCol.DataPropertyName = "StatusDokter"
        Me.StatusCol.HeaderText = "Status"
        Me.StatusCol.MinimumWidth = 8
        Me.StatusCol.Name = "StatusCol"
        Me.StatusCol.ReadOnly = True
        Me.StatusCol.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.StatusCol.Width = 96
        '
        'TglLahirCol
        '
        Me.TglLahirCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.TglLahirCol.DataPropertyName = "TanggalLahirDokter"
        Me.TglLahirCol.HeaderText = "Tanggal Lahir"
        Me.TglLahirCol.MinimumWidth = 8
        Me.TglLahirCol.Name = "TglLahirCol"
        Me.TglLahirCol.ReadOnly = True
        Me.TglLahirCol.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.TglLahirCol.Width = 151
        '
        'UmurCol
        '
        Me.UmurCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.UmurCol.DataPropertyName = "UsiaDokter"
        Me.UmurCol.HeaderText = "Umur"
        Me.UmurCol.MinimumWidth = 8
        Me.UmurCol.Name = "UmurCol"
        Me.UmurCol.ReadOnly = True
        Me.UmurCol.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.UmurCol.Width = 92
        '
        'JabatanCol
        '
        Me.JabatanCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.JabatanCol.DataPropertyName = "JabatanDokter"
        Me.JabatanCol.HeaderText = "Jabatan"
        Me.JabatanCol.MinimumWidth = 8
        Me.JabatanCol.Name = "JabatanCol"
        Me.JabatanCol.ReadOnly = True
        Me.JabatanCol.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'cmDokter
        '
        Me.cmDokter.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.cmDokter.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.cmDokter.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.cmDokter.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddNewDoctorsToolStripMenuItem, Me.KToolStripMenuItem, Me.DetailProfileToolStripMenuItem1, Me.DetailSpecializationToolStripMenuItem})
        Me.cmDokter.Name = "cmDokter"
        Me.cmDokter.Size = New System.Drawing.Size(241, 140)
        '
        'AddNewDoctorsToolStripMenuItem
        '
        Me.AddNewDoctorsToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.AddNewDoctorsToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.AddNewDoctorsToolStripMenuItem.Name = "AddNewDoctorsToolStripMenuItem"
        Me.AddNewDoctorsToolStripMenuItem.Size = New System.Drawing.Size(240, 32)
        Me.AddNewDoctorsToolStripMenuItem.Text = "Add new doctors"
        '
        'KToolStripMenuItem
        '
        Me.KToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.KToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.KToolStripMenuItem.Margin = New System.Windows.Forms.Padding(0, 0, 0, 1)
        Me.KToolStripMenuItem.Name = "KToolStripMenuItem"
        Me.KToolStripMenuItem.Size = New System.Drawing.Size(237, 6)
        '
        'DetailProfileToolStripMenuItem1
        '
        Me.DetailProfileToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.DetailProfileToolStripMenuItem1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.DetailProfileToolStripMenuItem1.Name = "DetailProfileToolStripMenuItem1"
        Me.DetailProfileToolStripMenuItem1.Size = New System.Drawing.Size(240, 32)
        Me.DetailProfileToolStripMenuItem1.Text = "Detail Profile"
        '
        'DetailSpecializationToolStripMenuItem
        '
        Me.DetailSpecializationToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.DetailSpecializationToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.DetailSpecializationToolStripMenuItem.Name = "DetailSpecializationToolStripMenuItem"
        Me.DetailSpecializationToolStripMenuItem.Size = New System.Drawing.Size(240, 32)
        Me.DetailSpecializationToolStripMenuItem.Text = "Insert Specialization"
        '
        'DetailProfileToolStripMenuItem
        '
        Me.DetailProfileToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.DetailProfileToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.DetailProfileToolStripMenuItem.Name = "DetailProfileToolStripMenuItem"
        Me.DetailProfileToolStripMenuItem.Size = New System.Drawing.Size(241, 32)
        Me.DetailProfileToolStripMenuItem.Text = "Detail Profile"
        '
        'frmDokterDaftar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1023, 633)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.CrownGroupBox2)
        Me.Controls.Add(Me.CrownGroupBox1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmDokterDaftar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DAILY DOSE OF SUNSHINE CLINIC | Doctors"
        Me.CrownGroupBox1.ResumeLayout(False)
        Me.CrownGroupBox2.ResumeLayout(False)
        Me.CrownGroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgvDokter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmDokter.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CrownGroupBox1 As ReaLTaiizor.Controls.CrownGroupBox
    Friend WithEvents CrownGroupBox2 As ReaLTaiizor.Controls.CrownGroupBox
    Friend WithEvents cbTitles As ReaLTaiizor.Controls.PoisonComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dgvDokter As DataGridView
    Friend WithEvents tbSearch As ReaLTaiizor.Controls.CrownTextBox
    Friend WithEvents IdDokterCol As DataGridViewTextBoxColumn
    Friend WithEvents NamaDokterCol As DataGridViewTextBoxColumn
    Friend WithEvents JKCol As DataGridViewTextBoxColumn
    Friend WithEvents NoTelpCol As DataGridViewTextBoxColumn
    Friend WithEvents StatusCol As DataGridViewTextBoxColumn
    Friend WithEvents TglLahirCol As DataGridViewTextBoxColumn
    Friend WithEvents UmurCol As DataGridViewTextBoxColumn
    Friend WithEvents JabatanCol As DataGridViewTextBoxColumn
    Friend WithEvents cmDokter As ReaLTaiizor.Controls.CrownContextMenuStrip
    Friend WithEvents AddNewDoctorsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DetailSpecializationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KToolStripMenuItem As ToolStripSeparator
    Friend WithEvents DetailProfileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DetailProfileToolStripMenuItem1 As ToolStripMenuItem
End Class
