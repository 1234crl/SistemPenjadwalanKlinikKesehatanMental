<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmOverview
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.flowPanelCalendar = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lbMonth = New System.Windows.Forms.Label()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.pbAfter = New System.Windows.Forms.PictureBox()
        Me.pbBefore = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.flowPanelCalendar.SuspendLayout()
        Me.Panel8.SuspendLayout()
        CType(Me.pbAfter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbBefore, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'flowPanelCalendar
        '
        Me.flowPanelCalendar.Controls.Add(Me.Panel1)
        Me.flowPanelCalendar.Location = New System.Drawing.Point(12, 120)
        Me.flowPanelCalendar.Name = "flowPanelCalendar"
        Me.flowPanelCalendar.Size = New System.Drawing.Size(999, 658)
        Me.flowPanelCalendar.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(29, 87)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 30)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Sunday"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(163, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 30)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Monday"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(308, 87)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 30)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Tuesday"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(451, 87)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(127, 30)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Wednesday"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(603, 87)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(103, 30)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Thursday"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(763, 87)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 30)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Friday"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(899, 87)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(100, 30)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Saturday"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbMonth
        '
        Me.lbMonth.AutoSize = True
        Me.lbMonth.Font = New System.Drawing.Font("Segoe UI Semibold", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbMonth.Location = New System.Drawing.Point(7, 27)
        Me.lbMonth.Name = "lbMonth"
        Me.lbMonth.Size = New System.Drawing.Size(121, 38)
        Me.lbMonth.TabIndex = 8
        Me.lbMonth.Text = "MONTH"
        Me.lbMonth.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel8
        '
        Me.Panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel8.Controls.Add(Me.lbMonth)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel8.Location = New System.Drawing.Point(0, 0)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(1028, 74)
        Me.Panel8.TabIndex = 9
        '
        'pbAfter
        '
        Me.pbAfter.Image = Global.SistemPenjadwalanKlinikKesehatanMental.My.Resources.Resources.right_24x24
        Me.pbAfter.Location = New System.Drawing.Point(227, 28)
        Me.pbAfter.Name = "pbAfter"
        Me.pbAfter.Size = New System.Drawing.Size(29, 30)
        Me.pbAfter.TabIndex = 10
        Me.pbAfter.TabStop = False
        '
        'pbBefore
        '
        Me.pbBefore.Image = Global.SistemPenjadwalanKlinikKesehatanMental.My.Resources.Resources.left_24x24
        Me.pbBefore.Location = New System.Drawing.Point(192, 28)
        Me.pbBefore.Name = "pbBefore"
        Me.pbBefore.Size = New System.Drawing.Size(29, 30)
        Me.pbBefore.TabIndex = 9
        Me.pbBefore.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(88, 82)
        Me.Panel1.TabIndex = 0
        '
        'frmOverview
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(1028, 801)
        Me.Controls.Add(Me.pbAfter)
        Me.Controls.Add(Me.pbBefore)
        Me.Controls.Add(Me.Panel8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.flowPanelCalendar)
        Me.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmOverview"
        Me.flowPanelCalendar.ResumeLayout(False)
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        CType(Me.pbAfter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbBefore, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents flowPanelCalendar As FlowLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lbMonth As Label
    Friend WithEvents Panel8 As Panel
    Friend WithEvents pbBefore As PictureBox
    Friend WithEvents pbAfter As PictureBox
    Friend WithEvents Panel1 As Panel
End Class
