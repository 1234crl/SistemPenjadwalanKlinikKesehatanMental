<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainPage
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
        Me.components = New System.ComponentModel.Container()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.NightControlBox1 = New ReaLTaiizor.Controls.NightControlBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.sidebar = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.menuContainer = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.menuTransition = New System.Windows.Forms.Timer(Me.components)
        Me.sidebarTransition = New System.Windows.Forms.Timer(Me.components)
        Me.btnOverview = New System.Windows.Forms.Button()
        Me.btnSchedule = New System.Windows.Forms.Button()
        Me.btnNewSchedule = New System.Windows.Forms.Button()
        Me.btnUpcomingSchedule = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.btnDoctors = New System.Windows.Forms.Button()
        Me.btnPatient = New System.Windows.Forms.Button()
        Me.btnUserList = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.btnItem = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.sidebar.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.menuContainer.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel9.SuspendLayout()
        CType(Me.btnItem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.NightControlBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.btnItem)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1024, 48)
        Me.Panel1.TabIndex = 0
        '
        'NightControlBox1
        '
        Me.NightControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NightControlBox1.BackColor = System.Drawing.Color.Transparent
        Me.NightControlBox1.CloseHoverColor = System.Drawing.Color.FromArgb(CType(CType(199, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.NightControlBox1.CloseHoverForeColor = System.Drawing.Color.White
        Me.NightControlBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.NightControlBox1.DefaultLocation = True
        Me.NightControlBox1.DisableMaximizeColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.NightControlBox1.DisableMinimizeColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.NightControlBox1.EnableCloseColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.NightControlBox1.EnableMaximizeButton = True
        Me.NightControlBox1.EnableMaximizeColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.NightControlBox1.EnableMinimizeButton = True
        Me.NightControlBox1.EnableMinimizeColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.NightControlBox1.Location = New System.Drawing.Point(885, 0)
        Me.NightControlBox1.MaximizeHoverColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.NightControlBox1.MaximizeHoverForeColor = System.Drawing.Color.White
        Me.NightControlBox1.MinimizeHoverColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.NightControlBox1.MinimizeHoverForeColor = System.Drawing.Color.White
        Me.NightControlBox1.Name = "NightControlBox1"
        Me.NightControlBox1.Size = New System.Drawing.Size(139, 31)
        Me.NightControlBox1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(43, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(436, 28)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "DAILY DOSE OF SUNSHINE CLINIC | Main Page"
        '
        'sidebar
        '
        Me.sidebar.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.sidebar.Controls.Add(Me.Panel2)
        Me.sidebar.Controls.Add(Me.menuContainer)
        Me.sidebar.Controls.Add(Me.Panel6)
        Me.sidebar.Controls.Add(Me.Panel7)
        Me.sidebar.Controls.Add(Me.Panel5)
        Me.sidebar.Controls.Add(Me.Panel8)
        Me.sidebar.Controls.Add(Me.Panel9)
        Me.sidebar.Dock = System.Windows.Forms.DockStyle.Left
        Me.sidebar.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.sidebar.Location = New System.Drawing.Point(0, 48)
        Me.sidebar.Name = "sidebar"
        Me.sidebar.Size = New System.Drawing.Size(251, 619)
        Me.sidebar.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnOverview)
        Me.Panel2.Location = New System.Drawing.Point(3, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(248, 53)
        Me.Panel2.TabIndex = 5
        '
        'menuContainer
        '
        Me.menuContainer.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.menuContainer.Controls.Add(Me.btnSchedule)
        Me.menuContainer.Controls.Add(Me.btnNewSchedule)
        Me.menuContainer.Controls.Add(Me.btnUpcomingSchedule)
        Me.menuContainer.Location = New System.Drawing.Point(3, 62)
        Me.menuContainer.Name = "menuContainer"
        Me.menuContainer.Size = New System.Drawing.Size(248, 56)
        Me.menuContainer.TabIndex = 9
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.Button4)
        Me.Panel6.Location = New System.Drawing.Point(3, 124)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(248, 53)
        Me.Panel6.TabIndex = 5
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.btnDoctors)
        Me.Panel7.Location = New System.Drawing.Point(3, 183)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(248, 53)
        Me.Panel7.TabIndex = 6
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.btnPatient)
        Me.Panel5.Location = New System.Drawing.Point(3, 242)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(248, 53)
        Me.Panel5.TabIndex = 4
        '
        'Panel8
        '
        Me.Panel8.Controls.Add(Me.btnUserList)
        Me.Panel8.Location = New System.Drawing.Point(3, 301)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(248, 53)
        Me.Panel8.TabIndex = 7
        '
        'Panel9
        '
        Me.Panel9.Controls.Add(Me.btnLogout)
        Me.Panel9.Location = New System.Drawing.Point(3, 360)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(248, 53)
        Me.Panel9.TabIndex = 8
        '
        'menuTransition
        '
        Me.menuTransition.Interval = 10
        '
        'sidebarTransition
        '
        Me.sidebarTransition.Interval = 10
        '
        'btnOverview
        '
        Me.btnOverview.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.btnOverview.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOverview.FlatAppearance.BorderSize = 0
        Me.btnOverview.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOverview.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOverview.ForeColor = System.Drawing.Color.White
        Me.btnOverview.Image = Global.SistemPenjadwalanKlinikKesehatanMental.My.Resources.Resources.menu_button_24x24
        Me.btnOverview.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOverview.Location = New System.Drawing.Point(3, -1)
        Me.btnOverview.Name = "btnOverview"
        Me.btnOverview.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.btnOverview.Size = New System.Drawing.Size(245, 52)
        Me.btnOverview.TabIndex = 3
        Me.btnOverview.Text = "           Overview"
        Me.btnOverview.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOverview.UseVisualStyleBackColor = False
        '
        'btnSchedule
        '
        Me.btnSchedule.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.btnSchedule.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSchedule.FlatAppearance.BorderSize = 0
        Me.btnSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSchedule.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSchedule.ForeColor = System.Drawing.Color.White
        Me.btnSchedule.Image = Global.SistemPenjadwalanKlinikKesehatanMental.My.Resources.Resources.calendar_24x24
        Me.btnSchedule.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSchedule.Location = New System.Drawing.Point(3, 3)
        Me.btnSchedule.Name = "btnSchedule"
        Me.btnSchedule.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.btnSchedule.Size = New System.Drawing.Size(245, 52)
        Me.btnSchedule.TabIndex = 3
        Me.btnSchedule.Text = "           Schedule"
        Me.btnSchedule.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSchedule.UseVisualStyleBackColor = False
        '
        'btnNewSchedule
        '
        Me.btnNewSchedule.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.btnNewSchedule.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNewSchedule.FlatAppearance.BorderSize = 0
        Me.btnNewSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNewSchedule.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNewSchedule.ForeColor = System.Drawing.Color.White
        Me.btnNewSchedule.Image = Global.SistemPenjadwalanKlinikKesehatanMental.My.Resources.Resources.add_24x24
        Me.btnNewSchedule.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNewSchedule.Location = New System.Drawing.Point(3, 61)
        Me.btnNewSchedule.Name = "btnNewSchedule"
        Me.btnNewSchedule.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.btnNewSchedule.Size = New System.Drawing.Size(230, 52)
        Me.btnNewSchedule.TabIndex = 4
        Me.btnNewSchedule.Text = "           New Schedule"
        Me.btnNewSchedule.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNewSchedule.UseVisualStyleBackColor = False
        '
        'btnUpcomingSchedule
        '
        Me.btnUpcomingSchedule.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.btnUpcomingSchedule.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUpcomingSchedule.FlatAppearance.BorderSize = 0
        Me.btnUpcomingSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpcomingSchedule.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpcomingSchedule.ForeColor = System.Drawing.Color.White
        Me.btnUpcomingSchedule.Image = Global.SistemPenjadwalanKlinikKesehatanMental.My.Resources.Resources.clock_24x24
        Me.btnUpcomingSchedule.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUpcomingSchedule.Location = New System.Drawing.Point(3, 119)
        Me.btnUpcomingSchedule.Name = "btnUpcomingSchedule"
        Me.btnUpcomingSchedule.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.btnUpcomingSchedule.Size = New System.Drawing.Size(230, 52)
        Me.btnUpcomingSchedule.TabIndex = 5
        Me.btnUpcomingSchedule.Text = "           Upcoming"
        Me.btnUpcomingSchedule.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUpcomingSchedule.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Image = Global.SistemPenjadwalanKlinikKesehatanMental.My.Resources.Resources.to_do_list_24x24
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.Location = New System.Drawing.Point(3, 0)
        Me.Button4.Name = "Button4"
        Me.Button4.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.Button4.Size = New System.Drawing.Size(242, 52)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "           History"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.UseVisualStyleBackColor = False
        '
        'btnDoctors
        '
        Me.btnDoctors.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.btnDoctors.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDoctors.FlatAppearance.BorderSize = 0
        Me.btnDoctors.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDoctors.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDoctors.ForeColor = System.Drawing.Color.White
        Me.btnDoctors.Image = Global.SistemPenjadwalanKlinikKesehatanMental.My.Resources.Resources.doctors_24x24
        Me.btnDoctors.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDoctors.Location = New System.Drawing.Point(3, 0)
        Me.btnDoctors.Name = "btnDoctors"
        Me.btnDoctors.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.btnDoctors.Size = New System.Drawing.Size(242, 52)
        Me.btnDoctors.TabIndex = 3
        Me.btnDoctors.Text = "           Doctors"
        Me.btnDoctors.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDoctors.UseVisualStyleBackColor = False
        '
        'btnPatient
        '
        Me.btnPatient.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.btnPatient.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPatient.FlatAppearance.BorderSize = 0
        Me.btnPatient.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPatient.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPatient.ForeColor = System.Drawing.Color.White
        Me.btnPatient.Image = Global.SistemPenjadwalanKlinikKesehatanMental.My.Resources.Resources.patients_24x24
        Me.btnPatient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPatient.Location = New System.Drawing.Point(2, 1)
        Me.btnPatient.Name = "btnPatient"
        Me.btnPatient.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.btnPatient.Size = New System.Drawing.Size(243, 52)
        Me.btnPatient.TabIndex = 3
        Me.btnPatient.Text = "           Patients"
        Me.btnPatient.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPatient.UseVisualStyleBackColor = False
        '
        'btnUserList
        '
        Me.btnUserList.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.btnUserList.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUserList.FlatAppearance.BorderSize = 0
        Me.btnUserList.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUserList.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUserList.ForeColor = System.Drawing.Color.White
        Me.btnUserList.Image = Global.SistemPenjadwalanKlinikKesehatanMental.My.Resources.Resources.settings
        Me.btnUserList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUserList.Location = New System.Drawing.Point(-1, -1)
        Me.btnUserList.Name = "btnUserList"
        Me.btnUserList.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.btnUserList.Size = New System.Drawing.Size(246, 52)
        Me.btnUserList.TabIndex = 3
        Me.btnUserList.Text = "            User List"
        Me.btnUserList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUserList.UseVisualStyleBackColor = False
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogout.FlatAppearance.BorderSize = 0
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.ForeColor = System.Drawing.Color.White
        Me.btnLogout.Image = Global.SistemPenjadwalanKlinikKesehatanMental.My.Resources.Resources.logout_24x24
        Me.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLogout.Location = New System.Drawing.Point(-1, 0)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.btnLogout.Size = New System.Drawing.Size(246, 52)
        Me.btnLogout.TabIndex = 3
        Me.btnLogout.Text = "            Log Out"
        Me.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'btnItem
        '
        Me.btnItem.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnItem.ErrorImage = Nothing
        Me.btnItem.Image = Global.SistemPenjadwalanKlinikKesehatanMental.My.Resources.Resources.hamburger_menu
        Me.btnItem.Location = New System.Drawing.Point(18, 13)
        Me.btnItem.Name = "btnItem"
        Me.btnItem.Size = New System.Drawing.Size(20, 22)
        Me.btnItem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnItem.TabIndex = 1
        Me.btnItem.TabStop = False
        '
        'MainPage
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(1024, 667)
        Me.ControlBox = False
        Me.Controls.Add(Me.sidebar)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.IsMdiContainer = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "MainPage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.sidebar.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.menuContainer.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel8.ResumeLayout(False)
        Me.Panel9.ResumeLayout(False)
        CType(Me.btnItem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnItem As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents NightControlBox1 As ReaLTaiizor.Controls.NightControlBox
    Friend WithEvents sidebar As FlowLayoutPanel
    Friend WithEvents btnSchedule As Button
    Friend WithEvents Panel5 As Panel
    Friend WithEvents btnPatient As Button
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Button4 As Button
    Friend WithEvents Panel7 As Panel
    Friend WithEvents btnDoctors As Button
    Friend WithEvents Panel8 As Panel
    Friend WithEvents btnUserList As Button
    Friend WithEvents Panel9 As Panel
    Friend WithEvents btnLogout As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnOverview As Button
    Friend WithEvents menuContainer As FlowLayoutPanel
    Friend WithEvents btnNewSchedule As Button
    Friend WithEvents menuTransition As Timer
    Friend WithEvents btnUpcomingSchedule As Button
    Friend WithEvents sidebarTransition As Timer
End Class
