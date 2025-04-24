<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSchedule
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
        Me.pn_full = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnClear = New ReaLTaiizor.Controls.Button()
        Me.btnSave = New ReaLTaiizor.Controls.Button()
        Me.dgvSchedule = New System.Windows.Forms.DataGridView()
        Me.NoCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamaDokterCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamaPasienCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdDokterCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdPasienCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JenisLayananCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JenisIntCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TglSesiCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JamCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DurasiCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CrownGroupBox1 = New ReaLTaiizor.Controls.CrownGroupBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbDuration = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cbDokter = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpTime = New System.Windows.Forms.DateTimePicker()
        Me.dtpDate = New System.Windows.Forms.DateTimePicker()
        Me.cbPasien = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbLayanan = New System.Windows.Forms.ComboBox()
        Me.cmDelete = New ReaLTaiizor.Controls.CrownContextMenuStrip()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.pn_full.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvSchedule, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CrownGroupBox1.SuspendLayout()
        Me.cmDelete.SuspendLayout()
        Me.SuspendLayout()
        '
        'pn_full
        '
        Me.pn_full.Controls.Add(Me.GroupBox1)
        Me.pn_full.Controls.Add(Me.CrownGroupBox1)
        Me.pn_full.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pn_full.Location = New System.Drawing.Point(0, 0)
        Me.pn_full.Name = "pn_full"
        Me.pn_full.Size = New System.Drawing.Size(1030, 717)
        Me.pn_full.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnClear)
        Me.GroupBox1.Controls.Add(Me.btnSave)
        Me.GroupBox1.Controls.Add(Me.dgvSchedule)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(0, 299)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1030, 418)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Scheduled:"
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.Transparent
        Me.btnClear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClear.EnteredColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btnClear.Image = Nothing
        Me.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClear.InactiveColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.btnClear.Location = New System.Drawing.Point(847, 354)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.PressedColor = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.btnClear.Size = New System.Drawing.Size(120, 47)
        Me.btnClear.TabIndex = 47
        Me.btnClear.Text = "Clear"
        Me.btnClear.TextAlignment = System.Drawing.StringAlignment.Center
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
        Me.btnSave.Location = New System.Drawing.Point(706, 354)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.PressedColor = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.btnSave.Size = New System.Drawing.Size(120, 47)
        Me.btnSave.TabIndex = 46
        Me.btnSave.Text = "Add"
        Me.btnSave.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'dgvSchedule
        '
        Me.dgvSchedule.AllowUserToAddRows = False
        Me.dgvSchedule.AllowUserToDeleteRows = False
        Me.dgvSchedule.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvSchedule.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSchedule.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NoCol, Me.NamaDokterCol, Me.NamaPasienCol, Me.IdDokterCol, Me.IdPasienCol, Me.JenisLayananCol, Me.JenisIntCol, Me.TglSesiCol, Me.JamCol, Me.DurasiCol})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvSchedule.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvSchedule.Location = New System.Drawing.Point(3, 30)
        Me.dgvSchedule.MultiSelect = False
        Me.dgvSchedule.Name = "dgvSchedule"
        Me.dgvSchedule.ReadOnly = True
        Me.dgvSchedule.RowHeadersVisible = False
        Me.dgvSchedule.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightGray
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvSchedule.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvSchedule.RowTemplate.Height = 28
        Me.dgvSchedule.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSchedule.Size = New System.Drawing.Size(1024, 311)
        Me.dgvSchedule.TabIndex = 0
        '
        'NoCol
        '
        Me.NoCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.NoCol.HeaderText = "No."
        Me.NoCol.MinimumWidth = 8
        Me.NoCol.Name = "NoCol"
        Me.NoCol.ReadOnly = True
        Me.NoCol.Width = 76
        '
        'NamaDokterCol
        '
        Me.NamaDokterCol.HeaderText = "Doctor"
        Me.NamaDokterCol.MinimumWidth = 8
        Me.NamaDokterCol.Name = "NamaDokterCol"
        Me.NamaDokterCol.ReadOnly = True
        Me.NamaDokterCol.Width = 150
        '
        'NamaPasienCol
        '
        Me.NamaPasienCol.HeaderText = "Patient"
        Me.NamaPasienCol.MinimumWidth = 8
        Me.NamaPasienCol.Name = "NamaPasienCol"
        Me.NamaPasienCol.ReadOnly = True
        Me.NamaPasienCol.Width = 150
        '
        'IdDokterCol
        '
        Me.IdDokterCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.IdDokterCol.HeaderText = "Doctor ID"
        Me.IdDokterCol.MinimumWidth = 8
        Me.IdDokterCol.Name = "IdDokterCol"
        Me.IdDokterCol.ReadOnly = True
        Me.IdDokterCol.Visible = False
        Me.IdDokterCol.Width = 150
        '
        'IdPasienCol
        '
        Me.IdPasienCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.IdPasienCol.HeaderText = "Patient ID"
        Me.IdPasienCol.MinimumWidth = 8
        Me.IdPasienCol.Name = "IdPasienCol"
        Me.IdPasienCol.ReadOnly = True
        Me.IdPasienCol.Visible = False
        Me.IdPasienCol.Width = 150
        '
        'JenisLayananCol
        '
        Me.JenisLayananCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.JenisLayananCol.HeaderText = "Treatment"
        Me.JenisLayananCol.MinimumWidth = 8
        Me.JenisLayananCol.Name = "JenisLayananCol"
        Me.JenisLayananCol.ReadOnly = True
        '
        'JenisIntCol
        '
        Me.JenisIntCol.HeaderText = "JenisInt"
        Me.JenisIntCol.MinimumWidth = 8
        Me.JenisIntCol.Name = "JenisIntCol"
        Me.JenisIntCol.ReadOnly = True
        Me.JenisIntCol.Visible = False
        Me.JenisIntCol.Width = 150
        '
        'TglSesiCol
        '
        Me.TglSesiCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.TglSesiCol.HeaderText = "Day/Date"
        Me.TglSesiCol.MinimumWidth = 8
        Me.TglSesiCol.Name = "TglSesiCol"
        Me.TglSesiCol.ReadOnly = True
        '
        'JamCol
        '
        Me.JamCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.JamCol.HeaderText = "Time"
        Me.JamCol.MinimumWidth = 8
        Me.JamCol.Name = "JamCol"
        Me.JamCol.ReadOnly = True
        Me.JamCol.Width = 86
        '
        'DurasiCol
        '
        Me.DurasiCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DurasiCol.HeaderText = "Duration (Minutes)"
        Me.DurasiCol.MinimumWidth = 8
        Me.DurasiCol.Name = "DurasiCol"
        Me.DurasiCol.ReadOnly = True
        Me.DurasiCol.Width = 179
        '
        'CrownGroupBox1
        '
        Me.CrownGroupBox1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.CrownGroupBox1.Controls.Add(Me.btnAdd)
        Me.CrownGroupBox1.Controls.Add(Me.Label4)
        Me.CrownGroupBox1.Controls.Add(Me.cbDuration)
        Me.CrownGroupBox1.Controls.Add(Me.Label9)
        Me.CrownGroupBox1.Controls.Add(Me.Label8)
        Me.CrownGroupBox1.Controls.Add(Me.Label3)
        Me.CrownGroupBox1.Controls.Add(Me.Label7)
        Me.CrownGroupBox1.Controls.Add(Me.cbDokter)
        Me.CrownGroupBox1.Controls.Add(Me.Label2)
        Me.CrownGroupBox1.Controls.Add(Me.dtpTime)
        Me.CrownGroupBox1.Controls.Add(Me.dtpDate)
        Me.CrownGroupBox1.Controls.Add(Me.cbPasien)
        Me.CrownGroupBox1.Controls.Add(Me.Label1)
        Me.CrownGroupBox1.Controls.Add(Me.cbLayanan)
        Me.CrownGroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.CrownGroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CrownGroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.CrownGroupBox1.Name = "CrownGroupBox1"
        Me.CrownGroupBox1.Size = New System.Drawing.Size(1030, 293)
        Me.CrownGroupBox1.TabIndex = 0
        Me.CrownGroupBox1.TabStop = False
        Me.CrownGroupBox1.Text = "Add New Appointment"
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.White
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.ForeColor = System.Drawing.Color.Black
        Me.btnAdd.Location = New System.Drawing.Point(861, 192)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(106, 42)
        Me.btnAdd.TabIndex = 13
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(765, 156)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 25)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "minutes"
        '
        'cbDuration
        '
        Me.cbDuration.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbDuration.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbDuration.FormattingEnabled = True
        Me.cbDuration.Items.AddRange(New Object() {"60", "90", "120"})
        Me.cbDuration.Location = New System.Drawing.Point(677, 148)
        Me.cbDuration.Name = "cbDuration"
        Me.cbDuration.Size = New System.Drawing.Size(82, 33)
        Me.cbDuration.TabIndex = 11
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label9.Location = New System.Drawing.Point(569, 151)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(85, 25)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Duration:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label8.Location = New System.Drawing.Point(590, 95)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(54, 25)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Time:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(591, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 25)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Date:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label7.Location = New System.Drawing.Point(21, 152)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(94, 25)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Treatment:"
        '
        'cbDokter
        '
        Me.cbDokter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbDokter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbDokter.FormattingEnabled = True
        Me.cbDokter.Items.AddRange(New Object() {"Not in Appointment", "In Appointment", "Show All"})
        Me.cbDokter.Location = New System.Drawing.Point(135, 94)
        Me.cbDokter.Name = "cbDokter"
        Me.cbDokter.Size = New System.Drawing.Size(334, 33)
        Me.cbDokter.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(44, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 25)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Doctor:"
        '
        'dtpTime
        '
        Me.dtpTime.CustomFormat = """hh:mm tt"""
        Me.dtpTime.Location = New System.Drawing.Point(677, 95)
        Me.dtpTime.Name = "dtpTime"
        Me.dtpTime.Size = New System.Drawing.Size(82, 31)
        Me.dtpTime.TabIndex = 6
        Me.dtpTime.Value = New Date(2024, 12, 6, 0, 0, 0, 0)
        '
        'dtpDate
        '
        Me.dtpDate.Location = New System.Drawing.Point(677, 33)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(290, 31)
        Me.dtpDate.TabIndex = 5
        '
        'cbPasien
        '
        Me.cbPasien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbPasien.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbPasien.FormattingEnabled = True
        Me.cbPasien.Items.AddRange(New Object() {"Not in Appointment", "In Appointment", "Show All"})
        Me.cbPasien.Location = New System.Drawing.Point(135, 39)
        Me.cbPasien.Name = "cbPasien"
        Me.cbPasien.Size = New System.Drawing.Size(334, 33)
        Me.cbPasien.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(46, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Patient:"
        '
        'cbLayanan
        '
        Me.cbLayanan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbLayanan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbLayanan.FormattingEnabled = True
        Me.cbLayanan.Items.AddRange(New Object() {"Not in Appointment", "In Appointment", "Show All"})
        Me.cbLayanan.Location = New System.Drawing.Point(135, 148)
        Me.cbLayanan.Name = "cbLayanan"
        Me.cbLayanan.Size = New System.Drawing.Size(214, 33)
        Me.cbLayanan.TabIndex = 4
        '
        'cmDelete
        '
        Me.cmDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.cmDelete.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.cmDelete.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.cmDelete.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DeleteToolStripMenuItem})
        Me.cmDelete.Name = "cmDelete"
        Me.cmDelete.Size = New System.Drawing.Size(135, 36)
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.DeleteToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(134, 32)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'frmSchedule
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1030, 717)
        Me.Controls.Add(Me.pn_full)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmSchedule"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmSchedule"
        Me.pn_full.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgvSchedule, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CrownGroupBox1.ResumeLayout(False)
        Me.CrownGroupBox1.PerformLayout()
        Me.cmDelete.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pn_full As Panel
    Friend WithEvents CrownGroupBox1 As ReaLTaiizor.Controls.CrownGroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cbDokter As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cbPasien As ComboBox
    Friend WithEvents cbLayanan As ComboBox
    Friend WithEvents dtpTime As DateTimePicker
    Friend WithEvents dtpDate As DateTimePicker
    Friend WithEvents btnClear As ReaLTaiizor.Controls.Button
    Friend WithEvents btnSave As ReaLTaiizor.Controls.Button
    Friend WithEvents Label7 As Label
    Friend WithEvents dgvSchedule As DataGridView
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cbDuration As ComboBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents NoCol As DataGridViewTextBoxColumn
    Friend WithEvents NamaDokterCol As DataGridViewTextBoxColumn
    Friend WithEvents NamaPasienCol As DataGridViewTextBoxColumn
    Friend WithEvents IdDokterCol As DataGridViewTextBoxColumn
    Friend WithEvents IdPasienCol As DataGridViewTextBoxColumn
    Friend WithEvents JenisLayananCol As DataGridViewTextBoxColumn
    Friend WithEvents JenisIntCol As DataGridViewTextBoxColumn
    Friend WithEvents TglSesiCol As DataGridViewTextBoxColumn
    Friend WithEvents JamCol As DataGridViewTextBoxColumn
    Friend WithEvents DurasiCol As DataGridViewTextBoxColumn
    Friend WithEvents cmDelete As ReaLTaiizor.Controls.CrownContextMenuStrip
    Friend WithEvents DeleteToolStripMenuItem As ToolStripMenuItem
End Class
