<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUserList
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
        Me.dgvUser = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.IdCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamaCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnameCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HakAksesCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HakAksesIntCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CrownGroupBox1.SuspendLayout()
        CType(Me.dgvUser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'CrownGroupBox1
        '
        Me.CrownGroupBox1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.CrownGroupBox1.Controls.Add(Me.dgvUser)
        Me.CrownGroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.CrownGroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.CrownGroupBox1.Name = "CrownGroupBox1"
        Me.CrownGroupBox1.Size = New System.Drawing.Size(978, 522)
        Me.CrownGroupBox1.TabIndex = 0
        Me.CrownGroupBox1.TabStop = False
        Me.CrownGroupBox1.Text = "User List"
        '
        'dgvUser
        '
        Me.dgvUser.AllowUserToAddRows = False
        Me.dgvUser.AllowUserToDeleteRows = False
        Me.dgvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvUser.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdCol, Me.NamaCol, Me.UnameCol, Me.HakAksesCol, Me.HakAksesIntCol})
        Me.dgvUser.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvUser.Location = New System.Drawing.Point(3, 30)
        Me.dgvUser.MultiSelect = False
        Me.dgvUser.Name = "dgvUser"
        Me.dgvUser.ReadOnly = True
        Me.dgvUser.RowHeadersVisible = False
        Me.dgvUser.RowHeadersWidth = 62
        Me.dgvUser.RowTemplate.Height = 28
        Me.dgvUser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvUser.Size = New System.Drawing.Size(972, 489)
        Me.dgvUser.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnClose)
        Me.GroupBox1.Controls.Add(Me.btnAdd)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox1.Location = New System.Drawing.Point(0, 530)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(978, 100)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'btnClose
        '
        Me.btnClose.ForeColor = System.Drawing.Color.Black
        Me.btnClose.Location = New System.Drawing.Point(833, 33)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(133, 55)
        Me.btnClose.TabIndex = 1
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.ForeColor = System.Drawing.Color.Black
        Me.btnAdd.Location = New System.Drawing.Point(12, 33)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(133, 55)
        Me.btnAdd.TabIndex = 0
        Me.btnAdd.Text = "Add User"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'IdCol
        '
        Me.IdCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.IdCol.DataPropertyName = "IdUser"
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.IdCol.DefaultCellStyle = DataGridViewCellStyle1
        Me.IdCol.HeaderText = "ID"
        Me.IdCol.MinimumWidth = 8
        Me.IdCol.Name = "IdCol"
        Me.IdCol.ReadOnly = True
        Me.IdCol.Width = 67
        '
        'NamaCol
        '
        Me.NamaCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.NamaCol.DataPropertyName = "Nama"
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        Me.NamaCol.DefaultCellStyle = DataGridViewCellStyle2
        Me.NamaCol.HeaderText = "Name"
        Me.NamaCol.MinimumWidth = 8
        Me.NamaCol.Name = "NamaCol"
        Me.NamaCol.ReadOnly = True
        '
        'UnameCol
        '
        Me.UnameCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.UnameCol.DataPropertyName = "Uname"
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        Me.UnameCol.DefaultCellStyle = DataGridViewCellStyle3
        Me.UnameCol.HeaderText = "Username"
        Me.UnameCol.MinimumWidth = 8
        Me.UnameCol.Name = "UnameCol"
        Me.UnameCol.ReadOnly = True
        '
        'HakAksesCol
        '
        Me.HakAksesCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.HakAksesCol.DataPropertyName = "StatusHakAkses"
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        Me.HakAksesCol.DefaultCellStyle = DataGridViewCellStyle4
        Me.HakAksesCol.HeaderText = "Role"
        Me.HakAksesCol.MinimumWidth = 8
        Me.HakAksesCol.Name = "HakAksesCol"
        Me.HakAksesCol.ReadOnly = True
        Me.HakAksesCol.Width = 86
        '
        'HakAksesIntCol
        '
        Me.HakAksesIntCol.DataPropertyName = "HakAkses"
        Me.HakAksesIntCol.HeaderText = "HakAksesInt"
        Me.HakAksesIntCol.MinimumWidth = 8
        Me.HakAksesIntCol.Name = "HakAksesIntCol"
        Me.HakAksesIntCol.ReadOnly = True
        Me.HakAksesIntCol.Visible = False
        Me.HakAksesIntCol.Width = 150
        '
        'frmUserList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 28.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(978, 630)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.CrownGroupBox1)
        Me.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmUserList"
        Me.Text = "frmUserList"
        Me.CrownGroupBox1.ResumeLayout(False)
        CType(Me.dgvUser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CrownGroupBox1 As ReaLTaiizor.Controls.CrownGroupBox
    Friend WithEvents dgvUser As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnClose As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents IdCol As DataGridViewTextBoxColumn
    Friend WithEvents NamaCol As DataGridViewTextBoxColumn
    Friend WithEvents UnameCol As DataGridViewTextBoxColumn
    Friend WithEvents HakAksesCol As DataGridViewTextBoxColumn
    Friend WithEvents HakAksesIntCol As DataGridViewTextBoxColumn
End Class
