<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucDays
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cbDay = New System.Windows.Forms.CheckBox()
        Me.lbDay = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.cbDay)
        Me.Panel1.Controls.Add(Me.lbDay)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(110, 70)
        Me.Panel1.TabIndex = 0
        '
        'cbDay
        '
        Me.cbDay.AutoSize = True
        Me.cbDay.Location = New System.Drawing.Point(18, 11)
        Me.cbDay.Name = "cbDay"
        Me.cbDay.Size = New System.Drawing.Size(22, 21)
        Me.cbDay.TabIndex = 1
        Me.cbDay.UseVisualStyleBackColor = True
        '
        'lbDay
        '
        Me.lbDay.AutoSize = True
        Me.lbDay.Dock = System.Windows.Forms.DockStyle.Right
        Me.lbDay.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbDay.Location = New System.Drawing.Point(70, 0)
        Me.lbDay.Name = "lbDay"
        Me.lbDay.Size = New System.Drawing.Size(40, 32)
        Me.lbDay.TabIndex = 0
        Me.lbDay.Text = "00"
        Me.lbDay.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'ucDays
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Controls.Add(Me.Panel1)
        Me.Name = "ucDays"
        Me.Size = New System.Drawing.Size(110, 70)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents cbDay As CheckBox
    Friend WithEvents lbDay As Label
End Class
