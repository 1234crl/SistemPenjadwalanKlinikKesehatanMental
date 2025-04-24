<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHistoryTransaksi
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
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle24 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle21 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle22 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle23 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.CrownGroupBox1 = New ReaLTaiizor.Controls.CrownGroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbStatus = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbDokter = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgvBooking = New System.Windows.Forms.DataGridView()
        Me.IdBookingCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TglBookingCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdDetailBookingCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamaDokterCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamaPasienCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JenisLayananStrCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TglSesiCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JamCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DurasiCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdDokterCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdPasienCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JenisLayananCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmDetail = New ReaLTaiizor.Controls.CrownContextMenuStrip()
        Me.ViewDetailToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnReport = New System.Windows.Forms.Button()
        Me.CrownGroupBox1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvBooking, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmDetail.SuspendLayout()
        Me.SuspendLayout()
        '
        'CrownGroupBox1
        '
        Me.CrownGroupBox1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.CrownGroupBox1.Controls.Add(Me.Label1)
        Me.CrownGroupBox1.Controls.Add(Me.cbStatus)
        Me.CrownGroupBox1.Controls.Add(Me.Label2)
        Me.CrownGroupBox1.Controls.Add(Me.cbDokter)
        Me.CrownGroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.CrownGroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.CrownGroupBox1.Name = "CrownGroupBox1"
        Me.CrownGroupBox1.Size = New System.Drawing.Size(989, 201)
        Me.CrownGroupBox1.TabIndex = 3
        Me.CrownGroupBox1.TabStop = False
        Me.CrownGroupBox1.Text = "Filtered by Status"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(283, 110)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 25)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Status:"
        '
        'cbStatus
        '
        Me.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbStatus.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbStatus.FormattingEnabled = True
        Me.cbStatus.Items.AddRange(New Object() {"Cancelled", "Completed", "View All"})
        Me.cbStatus.Location = New System.Drawing.Point(353, 104)
        Me.cbStatus.Name = "cbStatus"
        Me.cbStatus.Size = New System.Drawing.Size(344, 36)
        Me.cbStatus.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(277, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 25)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Dokter:"
        '
        'cbDokter
        '
        Me.cbDokter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbDokter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbDokter.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbDokter.FormattingEnabled = True
        Me.cbDokter.Location = New System.Drawing.Point(353, 46)
        Me.cbDokter.Name = "cbDokter"
        Me.cbDokter.Size = New System.Drawing.Size(344, 36)
        Me.cbDokter.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnReport)
        Me.GroupBox1.Controls.Add(Me.dgvBooking)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox1.Location = New System.Drawing.Point(0, 207)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(989, 466)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Scheduled List:"
        '
        'dgvBooking
        '
        Me.dgvBooking.AllowUserToAddRows = False
        Me.dgvBooking.AllowUserToDeleteRows = False
        DataGridViewCellStyle13.BackColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle13.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvBooking.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle13
        Me.dgvBooking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBooking.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdBookingCol, Me.TglBookingCol, Me.IdDetailBookingCol, Me.NamaDokterCol, Me.NamaPasienCol, Me.JenisLayananStrCol, Me.TglSesiCol, Me.JamCol, Me.DurasiCol, Me.StatusCol, Me.IdDokterCol, Me.IdPasienCol, Me.JenisLayananCol})
        Me.dgvBooking.Dock = System.Windows.Forms.DockStyle.Top
        Me.dgvBooking.Location = New System.Drawing.Point(3, 27)
        Me.dgvBooking.MultiSelect = False
        Me.dgvBooking.Name = "dgvBooking"
        Me.dgvBooking.ReadOnly = True
        DataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle24.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle24.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle24.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle24.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle24.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvBooking.RowHeadersDefaultCellStyle = DataGridViewCellStyle24
        Me.dgvBooking.RowHeadersVisible = False
        Me.dgvBooking.RowHeadersWidth = 62
        Me.dgvBooking.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvBooking.RowTemplate.Height = 28
        Me.dgvBooking.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvBooking.Size = New System.Drawing.Size(983, 361)
        Me.dgvBooking.TabIndex = 0
        '
        'IdBookingCol
        '
        Me.IdBookingCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.IdBookingCol.DataPropertyName = "IdBooking"
        DataGridViewCellStyle14.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.Black
        Me.IdBookingCol.DefaultCellStyle = DataGridViewCellStyle14
        Me.IdBookingCol.HeaderText = "Booking ID"
        Me.IdBookingCol.MinimumWidth = 8
        Me.IdBookingCol.Name = "IdBookingCol"
        Me.IdBookingCol.ReadOnly = True
        Me.IdBookingCol.Width = 137
        '
        'TglBookingCol
        '
        Me.TglBookingCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.TglBookingCol.DataPropertyName = "TglBooking"
        DataGridViewCellStyle15.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.Black
        Me.TglBookingCol.DefaultCellStyle = DataGridViewCellStyle15
        Me.TglBookingCol.HeaderText = "Booking Date:"
        Me.TglBookingCol.MinimumWidth = 8
        Me.TglBookingCol.Name = "TglBookingCol"
        Me.TglBookingCol.ReadOnly = True
        Me.TglBookingCol.Visible = False
        Me.TglBookingCol.Width = 150
        '
        'IdDetailBookingCol
        '
        Me.IdDetailBookingCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.IdDetailBookingCol.DataPropertyName = "IdDetailBooking"
        DataGridViewCellStyle16.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.Black
        Me.IdDetailBookingCol.DefaultCellStyle = DataGridViewCellStyle16
        Me.IdDetailBookingCol.HeaderText = "Detail Booking ID"
        Me.IdDetailBookingCol.MinimumWidth = 8
        Me.IdDetailBookingCol.Name = "IdDetailBookingCol"
        Me.IdDetailBookingCol.ReadOnly = True
        Me.IdDetailBookingCol.Visible = False
        Me.IdDetailBookingCol.Width = 150
        '
        'NamaDokterCol
        '
        Me.NamaDokterCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.NamaDokterCol.DataPropertyName = "NamaDokter"
        DataGridViewCellStyle17.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.Black
        Me.NamaDokterCol.DefaultCellStyle = DataGridViewCellStyle17
        Me.NamaDokterCol.HeaderText = "Doctor"
        Me.NamaDokterCol.MinimumWidth = 8
        Me.NamaDokterCol.Name = "NamaDokterCol"
        Me.NamaDokterCol.ReadOnly = True
        '
        'NamaPasienCol
        '
        Me.NamaPasienCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.NamaPasienCol.DataPropertyName = "NamaPasien"
        DataGridViewCellStyle18.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.Black
        Me.NamaPasienCol.DefaultCellStyle = DataGridViewCellStyle18
        Me.NamaPasienCol.HeaderText = "Patient"
        Me.NamaPasienCol.MinimumWidth = 8
        Me.NamaPasienCol.Name = "NamaPasienCol"
        Me.NamaPasienCol.ReadOnly = True
        '
        'JenisLayananStrCol
        '
        Me.JenisLayananStrCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.JenisLayananStrCol.DataPropertyName = "JenisLayananStr"
        DataGridViewCellStyle19.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.Black
        Me.JenisLayananStrCol.DefaultCellStyle = DataGridViewCellStyle19
        Me.JenisLayananStrCol.HeaderText = "Treatment"
        Me.JenisLayananStrCol.MinimumWidth = 8
        Me.JenisLayananStrCol.Name = "JenisLayananStrCol"
        Me.JenisLayananStrCol.ReadOnly = True
        Me.JenisLayananStrCol.Visible = False
        '
        'TglSesiCol
        '
        Me.TglSesiCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.TglSesiCol.DataPropertyName = "TglSesi"
        DataGridViewCellStyle20.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.Black
        Me.TglSesiCol.DefaultCellStyle = DataGridViewCellStyle20
        Me.TglSesiCol.HeaderText = "Day/Date"
        Me.TglSesiCol.MinimumWidth = 8
        Me.TglSesiCol.Name = "TglSesiCol"
        Me.TglSesiCol.ReadOnly = True
        '
        'JamCol
        '
        Me.JamCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.JamCol.DataPropertyName = "Jam"
        DataGridViewCellStyle21.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle21.SelectionForeColor = System.Drawing.Color.Black
        Me.JamCol.DefaultCellStyle = DataGridViewCellStyle21
        Me.JamCol.HeaderText = "Time"
        Me.JamCol.MinimumWidth = 8
        Me.JamCol.Name = "JamCol"
        Me.JamCol.ReadOnly = True
        Me.JamCol.Width = 86
        '
        'DurasiCol
        '
        Me.DurasiCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DurasiCol.DataPropertyName = "Durasi"
        DataGridViewCellStyle22.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle22.SelectionForeColor = System.Drawing.Color.Black
        Me.DurasiCol.DefaultCellStyle = DataGridViewCellStyle22
        Me.DurasiCol.HeaderText = "Duration (Minutes)"
        Me.DurasiCol.MinimumWidth = 8
        Me.DurasiCol.Name = "DurasiCol"
        Me.DurasiCol.ReadOnly = True
        Me.DurasiCol.Visible = False
        Me.DurasiCol.Width = 150
        '
        'StatusCol
        '
        Me.StatusCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.StatusCol.DataPropertyName = "StatusBooking"
        DataGridViewCellStyle23.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle23.SelectionForeColor = System.Drawing.Color.Black
        Me.StatusCol.DefaultCellStyle = DataGridViewCellStyle23
        Me.StatusCol.HeaderText = "Status"
        Me.StatusCol.MinimumWidth = 8
        Me.StatusCol.Name = "StatusCol"
        Me.StatusCol.ReadOnly = True
        '
        'IdDokterCol
        '
        Me.IdDokterCol.DataPropertyName = "IdDokter"
        Me.IdDokterCol.HeaderText = "ID Dokter"
        Me.IdDokterCol.MinimumWidth = 8
        Me.IdDokterCol.Name = "IdDokterCol"
        Me.IdDokterCol.ReadOnly = True
        Me.IdDokterCol.Visible = False
        Me.IdDokterCol.Width = 150
        '
        'IdPasienCol
        '
        Me.IdPasienCol.DataPropertyName = "IdPasien"
        Me.IdPasienCol.HeaderText = "ID Pasien"
        Me.IdPasienCol.MinimumWidth = 8
        Me.IdPasienCol.Name = "IdPasienCol"
        Me.IdPasienCol.ReadOnly = True
        Me.IdPasienCol.Visible = False
        Me.IdPasienCol.Width = 150
        '
        'JenisLayananCol
        '
        Me.JenisLayananCol.DataPropertyName = "JenisLayanan"
        Me.JenisLayananCol.HeaderText = "Jenis Layanan INT"
        Me.JenisLayananCol.MinimumWidth = 8
        Me.JenisLayananCol.Name = "JenisLayananCol"
        Me.JenisLayananCol.ReadOnly = True
        Me.JenisLayananCol.Visible = False
        Me.JenisLayananCol.Width = 150
        '
        'cmDetail
        '
        Me.cmDetail.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.cmDetail.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.cmDetail.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.cmDetail.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewDetailToolStripMenuItem})
        Me.cmDetail.Name = "cmDetail"
        Me.cmDetail.Size = New System.Drawing.Size(130, 36)
        '
        'ViewDetailToolStripMenuItem
        '
        Me.ViewDetailToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.ViewDetailToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.ViewDetailToolStripMenuItem.Name = "ViewDetailToolStripMenuItem"
        Me.ViewDetailToolStripMenuItem.Size = New System.Drawing.Size(129, 32)
        Me.ViewDetailToolStripMenuItem.Text = "Detail"
        '
        'btnReport
        '
        Me.btnReport.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReport.ForeColor = System.Drawing.Color.Black
        Me.btnReport.Location = New System.Drawing.Point(792, 400)
        Me.btnReport.Name = "btnReport"
        Me.btnReport.Size = New System.Drawing.Size(197, 60)
        Me.btnReport.TabIndex = 1
        Me.btnReport.Text = "Generate to Report"
        Me.btnReport.UseVisualStyleBackColor = True
        '
        'frmHistoryTransaksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(989, 673)
        Me.Controls.Add(Me.CrownGroupBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmHistoryTransaksi"
        Me.Text = "frmHistoryTransaksi"
        Me.CrownGroupBox1.ResumeLayout(False)
        Me.CrownGroupBox1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgvBooking, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmDetail.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CrownGroupBox1 As ReaLTaiizor.Controls.CrownGroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cbStatus As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cbDokter As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dgvBooking As DataGridView
    Friend WithEvents IdBookingCol As DataGridViewTextBoxColumn
    Friend WithEvents TglBookingCol As DataGridViewTextBoxColumn
    Friend WithEvents IdDetailBookingCol As DataGridViewTextBoxColumn
    Friend WithEvents NamaDokterCol As DataGridViewTextBoxColumn
    Friend WithEvents NamaPasienCol As DataGridViewTextBoxColumn
    Friend WithEvents JenisLayananStrCol As DataGridViewTextBoxColumn
    Friend WithEvents TglSesiCol As DataGridViewTextBoxColumn
    Friend WithEvents JamCol As DataGridViewTextBoxColumn
    Friend WithEvents DurasiCol As DataGridViewTextBoxColumn
    Friend WithEvents StatusCol As DataGridViewTextBoxColumn
    Friend WithEvents IdDokterCol As DataGridViewTextBoxColumn
    Friend WithEvents IdPasienCol As DataGridViewTextBoxColumn
    Friend WithEvents JenisLayananCol As DataGridViewTextBoxColumn
    Friend WithEvents cmDetail As ReaLTaiizor.Controls.CrownContextMenuStrip
    Friend WithEvents ViewDetailToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnReport As Button
End Class
