<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUpcomingSchedule
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
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
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
        Me.DetailToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateStatusToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.CrownGroupBox1.TabIndex = 1
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
        Me.cbStatus.Items.AddRange(New Object() {"Still in Booked", "Currently Running", "View All"})
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
        Me.GroupBox1.Controls.Add(Me.dgvBooking)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox1.Location = New System.Drawing.Point(0, 180)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(989, 443)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Scheduled List:"
        '
        'dgvBooking
        '
        Me.dgvBooking.AllowUserToAddRows = False
        Me.dgvBooking.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvBooking.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvBooking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBooking.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdBookingCol, Me.TglBookingCol, Me.IdDetailBookingCol, Me.NamaDokterCol, Me.NamaPasienCol, Me.JenisLayananStrCol, Me.TglSesiCol, Me.JamCol, Me.DurasiCol, Me.StatusCol, Me.IdDokterCol, Me.IdPasienCol, Me.JenisLayananCol})
        Me.dgvBooking.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvBooking.Location = New System.Drawing.Point(3, 27)
        Me.dgvBooking.MultiSelect = False
        Me.dgvBooking.Name = "dgvBooking"
        Me.dgvBooking.ReadOnly = True
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvBooking.RowHeadersDefaultCellStyle = DataGridViewCellStyle12
        Me.dgvBooking.RowHeadersVisible = False
        Me.dgvBooking.RowHeadersWidth = 62
        Me.dgvBooking.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvBooking.RowTemplate.Height = 28
        Me.dgvBooking.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvBooking.Size = New System.Drawing.Size(983, 413)
        Me.dgvBooking.TabIndex = 0
        '
        'IdBookingCol
        '
        Me.IdBookingCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.IdBookingCol.DataPropertyName = "IdBooking"
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        Me.IdBookingCol.DefaultCellStyle = DataGridViewCellStyle2
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
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        Me.TglBookingCol.DefaultCellStyle = DataGridViewCellStyle3
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
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        Me.IdDetailBookingCol.DefaultCellStyle = DataGridViewCellStyle4
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
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black
        Me.NamaDokterCol.DefaultCellStyle = DataGridViewCellStyle5
        Me.NamaDokterCol.HeaderText = "Doctor"
        Me.NamaDokterCol.MinimumWidth = 8
        Me.NamaDokterCol.Name = "NamaDokterCol"
        Me.NamaDokterCol.ReadOnly = True
        '
        'NamaPasienCol
        '
        Me.NamaPasienCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.NamaPasienCol.DataPropertyName = "NamaPasien"
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black
        Me.NamaPasienCol.DefaultCellStyle = DataGridViewCellStyle6
        Me.NamaPasienCol.HeaderText = "Patient"
        Me.NamaPasienCol.MinimumWidth = 8
        Me.NamaPasienCol.Name = "NamaPasienCol"
        Me.NamaPasienCol.ReadOnly = True
        '
        'JenisLayananStrCol
        '
        Me.JenisLayananStrCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.JenisLayananStrCol.DataPropertyName = "JenisLayananStr"
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black
        Me.JenisLayananStrCol.DefaultCellStyle = DataGridViewCellStyle7
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
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black
        Me.TglSesiCol.DefaultCellStyle = DataGridViewCellStyle8
        Me.TglSesiCol.HeaderText = "Day/Date"
        Me.TglSesiCol.MinimumWidth = 8
        Me.TglSesiCol.Name = "TglSesiCol"
        Me.TglSesiCol.ReadOnly = True
        '
        'JamCol
        '
        Me.JamCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.JamCol.DataPropertyName = "Jam"
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black
        Me.JamCol.DefaultCellStyle = DataGridViewCellStyle9
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
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black
        Me.DurasiCol.DefaultCellStyle = DataGridViewCellStyle10
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
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Black
        Me.StatusCol.DefaultCellStyle = DataGridViewCellStyle11
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
        Me.cmDetail.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DetailToolStripMenuItem, Me.UpdateStatusToolStripMenuItem})
        Me.cmDetail.Name = "cmDetail"
        Me.cmDetail.Size = New System.Drawing.Size(241, 101)
        '
        'DetailToolStripMenuItem
        '
        Me.DetailToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.DetailToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.DetailToolStripMenuItem.Name = "DetailToolStripMenuItem"
        Me.DetailToolStripMenuItem.Size = New System.Drawing.Size(240, 32)
        Me.DetailToolStripMenuItem.Text = "Detail"
        '
        'UpdateStatusToolStripMenuItem
        '
        Me.UpdateStatusToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.UpdateStatusToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.UpdateStatusToolStripMenuItem.Name = "UpdateStatusToolStripMenuItem"
        Me.UpdateStatusToolStripMenuItem.Size = New System.Drawing.Size(240, 32)
        Me.UpdateStatusToolStripMenuItem.Text = "Update Status"
        '
        'frmUpcomingSchedule
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(989, 623)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.CrownGroupBox1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmUpcomingSchedule"
        Me.Text = "frmUpcomingSchedule"
        Me.TopMost = True
        Me.CrownGroupBox1.ResumeLayout(False)
        Me.CrownGroupBox1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgvBooking, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmDetail.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CrownGroupBox1 As ReaLTaiizor.Controls.CrownGroupBox
    Friend WithEvents cbDokter As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents dgvBooking As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents cbStatus As ComboBox
    Friend WithEvents cmDetail As ReaLTaiizor.Controls.CrownContextMenuStrip
    Friend WithEvents DetailToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UpdateStatusToolStripMenuItem As ToolStripMenuItem
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
End Class
