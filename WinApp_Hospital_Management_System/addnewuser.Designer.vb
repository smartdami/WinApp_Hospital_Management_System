<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class addnewuser
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
        Me.Adduser_pan = New System.Windows.Forms.Panel()
        Me.pass_lbl = New System.Windows.Forms.Label()
        Me.job_lbl = New System.Windows.Forms.Label()
        Me.jobpos_txtbx = New System.Windows.Forms.TextBox()
        Me.userid_lbl = New System.Windows.Forms.Label()
        Me.uname_lbl = New System.Windows.Forms.Label()
        Me.add_btn = New System.Windows.Forms.Button()
        Me.pass_txtbx = New System.Windows.Forms.TextBox()
        Me.uname_txtbx = New System.Windows.Forms.TextBox()
        Me.adduser_lbl = New System.Windows.Forms.Label()
        Me.uid_txtbx = New System.Windows.Forms.TextBox()
        Me.details_grpbx = New System.Windows.Forms.GroupBox()
        Me.logout_btn = New System.Windows.Forms.Button()
        Me.addward_btn = New System.Windows.Forms.Button()
        Me.adduser_btn = New System.Windows.Forms.Button()
        Me.userinfo_btn = New System.Windows.Forms.Button()
        Me.ptinfo_btn = New System.Windows.Forms.Button()
        Me.ptchkout_btn = New System.Windows.Forms.Button()
        Me.ptreg_btn = New System.Windows.Forms.Button()
        Me.clr_btn = New System.Windows.Forms.Button()
        Me.Adduser_pan.SuspendLayout()
        Me.details_grpbx.SuspendLayout()
        Me.SuspendLayout()
        '
        'Adduser_pan
        '
        Me.Adduser_pan.BackColor = System.Drawing.SystemColors.Control
        Me.Adduser_pan.Controls.Add(Me.clr_btn)
        Me.Adduser_pan.Controls.Add(Me.pass_lbl)
        Me.Adduser_pan.Controls.Add(Me.job_lbl)
        Me.Adduser_pan.Controls.Add(Me.jobpos_txtbx)
        Me.Adduser_pan.Controls.Add(Me.userid_lbl)
        Me.Adduser_pan.Controls.Add(Me.uname_lbl)
        Me.Adduser_pan.Controls.Add(Me.add_btn)
        Me.Adduser_pan.Controls.Add(Me.pass_txtbx)
        Me.Adduser_pan.Controls.Add(Me.uname_txtbx)
        Me.Adduser_pan.Controls.Add(Me.adduser_lbl)
        Me.Adduser_pan.Controls.Add(Me.uid_txtbx)
        Me.Adduser_pan.Location = New System.Drawing.Point(344, 44)
        Me.Adduser_pan.Name = "Adduser_pan"
        Me.Adduser_pan.Size = New System.Drawing.Size(652, 472)
        Me.Adduser_pan.TabIndex = 15
        '
        'pass_lbl
        '
        Me.pass_lbl.AutoSize = True
        Me.pass_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pass_lbl.Location = New System.Drawing.Point(275, 194)
        Me.pass_lbl.Name = "pass_lbl"
        Me.pass_lbl.Size = New System.Drawing.Size(68, 16)
        Me.pass_lbl.TabIndex = 5
        Me.pass_lbl.Text = "Password"
        '
        'job_lbl
        '
        Me.job_lbl.AutoSize = True
        Me.job_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.job_lbl.Location = New System.Drawing.Point(275, 286)
        Me.job_lbl.Name = "job_lbl"
        Me.job_lbl.Size = New System.Drawing.Size(79, 16)
        Me.job_lbl.TabIndex = 13
        Me.job_lbl.Text = "JobPosition"
        '
        'jobpos_txtbx
        '
        Me.jobpos_txtbx.Location = New System.Drawing.Point(361, 282)
        Me.jobpos_txtbx.Name = "jobpos_txtbx"
        Me.jobpos_txtbx.Size = New System.Drawing.Size(121, 20)
        Me.jobpos_txtbx.TabIndex = 16
        '
        'userid_lbl
        '
        Me.userid_lbl.AutoSize = True
        Me.userid_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.userid_lbl.Location = New System.Drawing.Point(275, 149)
        Me.userid_lbl.Name = "userid_lbl"
        Me.userid_lbl.Size = New System.Drawing.Size(50, 16)
        Me.userid_lbl.TabIndex = 11
        Me.userid_lbl.Text = "UserID"
        '
        'uname_lbl
        '
        Me.uname_lbl.AutoSize = True
        Me.uname_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.uname_lbl.Location = New System.Drawing.Point(275, 239)
        Me.uname_lbl.Name = "uname_lbl"
        Me.uname_lbl.Size = New System.Drawing.Size(74, 16)
        Me.uname_lbl.TabIndex = 4
        Me.uname_lbl.Text = "UserName"
        '
        'add_btn
        '
        Me.add_btn.BackColor = System.Drawing.SystemColors.Control
        Me.add_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.add_btn.Location = New System.Drawing.Point(361, 324)
        Me.add_btn.Name = "add_btn"
        Me.add_btn.Size = New System.Drawing.Size(110, 30)
        Me.add_btn.TabIndex = 7
        Me.add_btn.Text = "ADD New User"
        Me.add_btn.UseVisualStyleBackColor = False
        '
        'pass_txtbx
        '
        Me.pass_txtbx.Location = New System.Drawing.Point(361, 190)
        Me.pass_txtbx.Name = "pass_txtbx"
        Me.pass_txtbx.Size = New System.Drawing.Size(121, 20)
        Me.pass_txtbx.TabIndex = 15
        '
        'uname_txtbx
        '
        Me.uname_txtbx.Location = New System.Drawing.Point(361, 235)
        Me.uname_txtbx.Name = "uname_txtbx"
        Me.uname_txtbx.Size = New System.Drawing.Size(121, 20)
        Me.uname_txtbx.TabIndex = 14
        '
        'adduser_lbl
        '
        Me.adduser_lbl.AutoSize = True
        Me.adduser_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.adduser_lbl.ForeColor = System.Drawing.SystemColors.Desktop
        Me.adduser_lbl.Location = New System.Drawing.Point(315, 43)
        Me.adduser_lbl.Name = "adduser_lbl"
        Me.adduser_lbl.Size = New System.Drawing.Size(137, 24)
        Me.adduser_lbl.TabIndex = 0
        Me.adduser_lbl.Text = "ADD New User"
        '
        'uid_txtbx
        '
        Me.uid_txtbx.Location = New System.Drawing.Point(361, 145)
        Me.uid_txtbx.Name = "uid_txtbx"
        Me.uid_txtbx.Size = New System.Drawing.Size(121, 20)
        Me.uid_txtbx.TabIndex = 12
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
        Me.details_grpbx.Location = New System.Drawing.Point(12, 31)
        Me.details_grpbx.Name = "details_grpbx"
        Me.details_grpbx.Size = New System.Drawing.Size(283, 485)
        Me.details_grpbx.TabIndex = 16
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
        Me.clr_btn.Location = New System.Drawing.Point(361, 371)
        Me.clr_btn.Name = "clr_btn"
        Me.clr_btn.Size = New System.Drawing.Size(110, 30)
        Me.clr_btn.TabIndex = 17
        Me.clr_btn.Text = "Clear"
        Me.clr_btn.UseVisualStyleBackColor = False
        '
        'addnewuser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1350, 729)
        Me.Controls.Add(Me.details_grpbx)
        Me.Controls.Add(Me.Adduser_pan)
        Me.Name = "addnewuser"
        Me.Text = "Addnewuser"
        Me.Adduser_pan.ResumeLayout(False)
        Me.Adduser_pan.PerformLayout()
        Me.details_grpbx.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Adduser_pan As Panel
    Friend WithEvents adduser_lbl As Label
    Friend WithEvents add_btn As Button
    Friend WithEvents uname_txtbx As TextBox
    Friend WithEvents job_lbl As Label
    Friend WithEvents uid_txtbx As TextBox
    Friend WithEvents userid_lbl As Label
    Friend WithEvents pass_lbl As Label
    Friend WithEvents uname_lbl As Label
    Friend WithEvents pass_txtbx As TextBox
    Friend WithEvents jobpos_txtbx As TextBox
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
