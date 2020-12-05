<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class masterpage
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
        Me.details_grpbx = New System.Windows.Forms.GroupBox()
        Me.logout_btn = New System.Windows.Forms.Button()
        Me.addward_btn = New System.Windows.Forms.Button()
        Me.adduser_btn = New System.Windows.Forms.Button()
        Me.userinfo_btn = New System.Windows.Forms.Button()
        Me.ptinfo_btn = New System.Windows.Forms.Button()
        Me.ptchkout_btn = New System.Windows.Forms.Button()
        Me.ptreg_btn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.details_grpbx.SuspendLayout()
        Me.SuspendLayout()
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
        Me.details_grpbx.Location = New System.Drawing.Point(451, 103)
        Me.details_grpbx.Name = "details_grpbx"
        Me.details_grpbx.Size = New System.Drawing.Size(283, 472)
        Me.details_grpbx.TabIndex = 0
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(398, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(356, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "WELCOME TO LOYOLA HOSPITAL"
        '
        'masterpage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1350, 729)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.details_grpbx)
        Me.Name = "masterpage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds
        Me.Text = "Loyola Hospital"
        Me.details_grpbx.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents details_grpbx As GroupBox
    Friend WithEvents logout_btn As Button
    Friend WithEvents addward_btn As Button
    Friend WithEvents adduser_btn As Button
    Friend WithEvents userinfo_btn As Button
    Friend WithEvents ptinfo_btn As Button
    Friend WithEvents ptchkout_btn As Button
    Friend WithEvents ptreg_btn As Button
    Friend WithEvents Label1 As Label
End Class
