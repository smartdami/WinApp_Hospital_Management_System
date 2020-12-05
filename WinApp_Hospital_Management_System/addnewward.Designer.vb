<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Addnewward
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
        Me.addward_pan = New System.Windows.Forms.Panel()
        Me.adddet_btn = New System.Windows.Forms.Button()
        Me.addward_grpbx = New System.Windows.Forms.GroupBox()
        Me.uprice_txtbx = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.building_txtbx = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.roomno_txtbx = New System.Windows.Forms.TextBox()
        Me.roomtype_combx = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.addward_lbl = New System.Windows.Forms.Label()
        Me.details_grpbx = New System.Windows.Forms.GroupBox()
        Me.logout_btn = New System.Windows.Forms.Button()
        Me.addward_btn = New System.Windows.Forms.Button()
        Me.adduser_btn = New System.Windows.Forms.Button()
        Me.userinfo_btn = New System.Windows.Forms.Button()
        Me.ptinfo_btn = New System.Windows.Forms.Button()
        Me.ptchkout_btn = New System.Windows.Forms.Button()
        Me.ptreg_btn = New System.Windows.Forms.Button()
        Me.clr_btn = New System.Windows.Forms.Button()
        Me.addward_pan.SuspendLayout()
        Me.addward_grpbx.SuspendLayout()
        Me.details_grpbx.SuspendLayout()
        Me.SuspendLayout()
        '
        'addward_pan
        '
        Me.addward_pan.BackColor = System.Drawing.SystemColors.Control
        Me.addward_pan.Controls.Add(Me.clr_btn)
        Me.addward_pan.Controls.Add(Me.adddet_btn)
        Me.addward_pan.Controls.Add(Me.addward_grpbx)
        Me.addward_pan.Controls.Add(Me.addward_lbl)
        Me.addward_pan.Location = New System.Drawing.Point(381, 48)
        Me.addward_pan.Name = "addward_pan"
        Me.addward_pan.Size = New System.Drawing.Size(652, 472)
        Me.addward_pan.TabIndex = 10
        '
        'adddet_btn
        '
        Me.adddet_btn.BackColor = System.Drawing.SystemColors.Control
        Me.adddet_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.adddet_btn.Location = New System.Drawing.Point(263, 309)
        Me.adddet_btn.Name = "adddet_btn"
        Me.adddet_btn.Size = New System.Drawing.Size(121, 30)
        Me.adddet_btn.TabIndex = 9
        Me.adddet_btn.Text = "Add Details"
        Me.adddet_btn.UseVisualStyleBackColor = False
        '
        'addward_grpbx
        '
        Me.addward_grpbx.Controls.Add(Me.uprice_txtbx)
        Me.addward_grpbx.Controls.Add(Me.Label3)
        Me.addward_grpbx.Controls.Add(Me.building_txtbx)
        Me.addward_grpbx.Controls.Add(Me.Label2)
        Me.addward_grpbx.Controls.Add(Me.roomno_txtbx)
        Me.addward_grpbx.Controls.Add(Me.roomtype_combx)
        Me.addward_grpbx.Controls.Add(Me.Label15)
        Me.addward_grpbx.Controls.Add(Me.Label14)
        Me.addward_grpbx.Controls.Add(Me.Label13)
        Me.addward_grpbx.Location = New System.Drawing.Point(159, 98)
        Me.addward_grpbx.Name = "addward_grpbx"
        Me.addward_grpbx.Size = New System.Drawing.Size(298, 194)
        Me.addward_grpbx.TabIndex = 3
        Me.addward_grpbx.TabStop = False
        '
        'uprice_txtbx
        '
        Me.uprice_txtbx.Location = New System.Drawing.Point(104, 129)
        Me.uprice_txtbx.Name = "uprice_txtbx"
        Me.uprice_txtbx.Size = New System.Drawing.Size(121, 20)
        Me.uprice_txtbx.TabIndex = 14
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 101)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "RoomNo"
        '
        'building_txtbx
        '
        Me.building_txtbx.Location = New System.Drawing.Point(104, 21)
        Me.building_txtbx.Name = "building_txtbx"
        Me.building_txtbx.Size = New System.Drawing.Size(121, 20)
        Me.building_txtbx.TabIndex = 12
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Building"
        '
        'roomno_txtbx
        '
        Me.roomno_txtbx.Location = New System.Drawing.Point(104, 94)
        Me.roomno_txtbx.Name = "roomno_txtbx"
        Me.roomno_txtbx.Size = New System.Drawing.Size(121, 20)
        Me.roomno_txtbx.TabIndex = 10
        '
        'roomtype_combx
        '
        Me.roomtype_combx.FormattingEnabled = True
        Me.roomtype_combx.Items.AddRange(New Object() {"Normal", "Medium", "VIP"})
        Me.roomtype_combx.Location = New System.Drawing.Point(104, 57)
        Me.roomtype_combx.Name = "roomtype_combx"
        Me.roomtype_combx.Size = New System.Drawing.Size(121, 21)
        Me.roomtype_combx.TabIndex = 8
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(20, 136)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(50, 13)
        Me.Label15.TabIndex = 6
        Me.Label15.Text = "UnitPrice"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(20, 65)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(59, 13)
        Me.Label14.TabIndex = 5
        Me.Label14.Text = "RoomType"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(20, 56)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(0, 13)
        Me.Label13.TabIndex = 4
        '
        'addward_lbl
        '
        Me.addward_lbl.AutoSize = True
        Me.addward_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addward_lbl.ForeColor = System.Drawing.SystemColors.Desktop
        Me.addward_lbl.Location = New System.Drawing.Point(245, 52)
        Me.addward_lbl.Name = "addward_lbl"
        Me.addward_lbl.Size = New System.Drawing.Size(139, 24)
        Me.addward_lbl.TabIndex = 0
        Me.addward_lbl.Text = "Add New Ward"
        '
        'details_grpbx
        '
        Me.details_grpbx.Controls.Add(Me.logout_btn)
        Me.details_grpbx.Controls.Add(Me.addward_btn)
        Me.details_grpbx.Controls.Add(Me.adduser_btn)
        Me.details_grpbx.Controls.Add(Me.userinfo_btn)
        Me.details_grpbx.Controls.Add(Me.ptinfo_btn)
        Me.details_grpbx.Controls.Add(Me.ptchkout_btn)
        Me.details_grpbx.Controls.Add(Me.ptreg_btn)
        Me.details_grpbx.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.details_grpbx.Location = New System.Drawing.Point(12, 48)
        Me.details_grpbx.Name = "details_grpbx"
        Me.details_grpbx.Size = New System.Drawing.Size(283, 472)
        Me.details_grpbx.TabIndex = 17
        Me.details_grpbx.TabStop = False
        '
        'logout_btn
        '
        Me.logout_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.logout_btn.Location = New System.Drawing.Point(53, 396)
        Me.logout_btn.Name = "logout_btn"
        Me.logout_btn.Size = New System.Drawing.Size(185, 30)
        Me.logout_btn.TabIndex = 4
        Me.logout_btn.Text = "LogOut"
        Me.logout_btn.UseVisualStyleBackColor = True
        '
        'addward_btn
        '
        Me.addward_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addward_btn.Location = New System.Drawing.Point(53, 217)
        Me.addward_btn.Name = "addward_btn"
        Me.addward_btn.Size = New System.Drawing.Size(185, 30)
        Me.addward_btn.TabIndex = 8
        Me.addward_btn.Text = "Add New Ward"
        Me.addward_btn.UseVisualStyleBackColor = True
        '
        'adduser_btn
        '
        Me.adduser_btn.Enabled = False
        Me.adduser_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.adduser_btn.Location = New System.Drawing.Point(53, 337)
        Me.adduser_btn.Name = "adduser_btn"
        Me.adduser_btn.Size = New System.Drawing.Size(185, 30)
        Me.adduser_btn.TabIndex = 6
        Me.adduser_btn.Text = "Add New User"
        Me.adduser_btn.UseVisualStyleBackColor = True
        '
        'userinfo_btn
        '
        Me.userinfo_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.userinfo_btn.Location = New System.Drawing.Point(53, 276)
        Me.userinfo_btn.Name = "userinfo_btn"
        Me.userinfo_btn.Size = New System.Drawing.Size(185, 30)
        Me.userinfo_btn.TabIndex = 5
        Me.userinfo_btn.Text = "User Information"
        Me.userinfo_btn.UseVisualStyleBackColor = True
        '
        'ptinfo_btn
        '
        Me.ptinfo_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ptinfo_btn.Location = New System.Drawing.Point(53, 104)
        Me.ptinfo_btn.Name = "ptinfo_btn"
        Me.ptinfo_btn.Size = New System.Drawing.Size(185, 30)
        Me.ptinfo_btn.TabIndex = 2
        Me.ptinfo_btn.Text = "Patient Information"
        Me.ptinfo_btn.UseVisualStyleBackColor = True
        '
        'ptchkout_btn
        '
        Me.ptchkout_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ptchkout_btn.Location = New System.Drawing.Point(53, 158)
        Me.ptchkout_btn.Name = "ptchkout_btn"
        Me.ptchkout_btn.Size = New System.Drawing.Size(185, 30)
        Me.ptchkout_btn.TabIndex = 1
        Me.ptchkout_btn.Text = "Patient Checkout"
        Me.ptchkout_btn.UseVisualStyleBackColor = True
        '
        'ptreg_btn
        '
        Me.ptreg_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ptreg_btn.Location = New System.Drawing.Point(53, 50)
        Me.ptreg_btn.Name = "ptreg_btn"
        Me.ptreg_btn.Size = New System.Drawing.Size(185, 30)
        Me.ptreg_btn.TabIndex = 0
        Me.ptreg_btn.Text = "Patient Registration"
        Me.ptreg_btn.UseVisualStyleBackColor = True
        '
        'clr_btn
        '
        Me.clr_btn.BackColor = System.Drawing.SystemColors.Control
        Me.clr_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clr_btn.Location = New System.Drawing.Point(263, 345)
        Me.clr_btn.Name = "clr_btn"
        Me.clr_btn.Size = New System.Drawing.Size(110, 33)
        Me.clr_btn.TabIndex = 18
        Me.clr_btn.Text = "Clear"
        Me.clr_btn.UseVisualStyleBackColor = False
        '
        'Addnewward
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1350, 729)
        Me.Controls.Add(Me.details_grpbx)
        Me.Controls.Add(Me.addward_pan)
        Me.Name = "Addnewward"
        Me.Text = "Loyola Hospital | Add New Ward Details"
        Me.addward_pan.ResumeLayout(False)
        Me.addward_pan.PerformLayout()
        Me.addward_grpbx.ResumeLayout(False)
        Me.addward_grpbx.PerformLayout()
        Me.details_grpbx.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents addward_pan As Panel
    Friend WithEvents addward_grpbx As GroupBox
    Friend WithEvents uprice_txtbx As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents building_txtbx As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents roomno_txtbx As TextBox
    Friend WithEvents roomtype_combx As ComboBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents addward_lbl As Label
    Friend WithEvents adddet_btn As Button
    Friend WithEvents details_grpbx As GroupBox
    Friend WithEvents logout_btn As Button
    Friend WithEvents addward_btn As Button
    Friend WithEvents adduser_btn As Button
    Friend WithEvents userinfo_btn As Button
    Friend WithEvents ptinfo_btn As Button
    Friend WithEvents ptchkout_btn As Button
    Friend WithEvents ptreg_btn As Button
    Friend WithEvents clr_btn As Button
End Class
