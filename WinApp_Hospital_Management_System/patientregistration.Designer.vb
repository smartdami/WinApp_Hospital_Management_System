<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Patientregistration
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
        Me.ptreg_panel = New System.Windows.Forms.Panel()
        Me.clr_btn = New System.Windows.Forms.Button()
        Me.add_btn = New System.Windows.Forms.Button()
        Me.pinfo_grpbx = New System.Windows.Forms.GroupBox()
        Me.gender_cmbbx = New System.Windows.Forms.ComboBox()
        Me.name_txtbx = New System.Windows.Forms.TextBox()
        Me.age_txtbx = New System.Windows.Forms.TextBox()
        Me.pn_txtbx = New System.Windows.Forms.TextBox()
        Me.address_txtbx = New System.Windows.Forms.TextBox()
        Me.dissts_txtbx = New System.Windows.Forms.TextBox()
        Me.disease_txtbx = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.roominfo_grpbx = New System.Windows.Forms.GroupBox()
        Me.room_grid = New System.Windows.Forms.DataGridView()
        Me.regid_grpbx = New System.Windows.Forms.GroupBox()
        Me.date_picker = New System.Windows.Forms.DateTimePicker()
        Me.pid_txtbx = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.details_grpbx = New System.Windows.Forms.GroupBox()
        Me.logout_btn = New System.Windows.Forms.Button()
        Me.addward_btn = New System.Windows.Forms.Button()
        Me.adduser_btn = New System.Windows.Forms.Button()
        Me.userinfo_btn = New System.Windows.Forms.Button()
        Me.ptinfo_btn = New System.Windows.Forms.Button()
        Me.ptchkout_btn = New System.Windows.Forms.Button()
        Me.ptreg_btn = New System.Windows.Forms.Button()
        Me.ptreg_panel.SuspendLayout()
        Me.pinfo_grpbx.SuspendLayout()
        Me.roominfo_grpbx.SuspendLayout()
        CType(Me.room_grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.regid_grpbx.SuspendLayout()
        Me.details_grpbx.SuspendLayout()
        Me.SuspendLayout()
        '
        'ptreg_panel
        '
        Me.ptreg_panel.BackColor = System.Drawing.SystemColors.Control
        Me.ptreg_panel.Controls.Add(Me.clr_btn)
        Me.ptreg_panel.Controls.Add(Me.add_btn)
        Me.ptreg_panel.Controls.Add(Me.pinfo_grpbx)
        Me.ptreg_panel.Controls.Add(Me.roominfo_grpbx)
        Me.ptreg_panel.Controls.Add(Me.regid_grpbx)
        Me.ptreg_panel.Controls.Add(Me.Label1)
        Me.ptreg_panel.Location = New System.Drawing.Point(331, 26)
        Me.ptreg_panel.Name = "ptreg_panel"
        Me.ptreg_panel.Size = New System.Drawing.Size(844, 550)
        Me.ptreg_panel.TabIndex = 4
        '
        'clr_btn
        '
        Me.clr_btn.Location = New System.Drawing.Point(493, 440)
        Me.clr_btn.Name = "clr_btn"
        Me.clr_btn.Size = New System.Drawing.Size(75, 23)
        Me.clr_btn.TabIndex = 6
        Me.clr_btn.Text = "Clear"
        Me.clr_btn.UseVisualStyleBackColor = True
        '
        'add_btn
        '
        Me.add_btn.Location = New System.Drawing.Point(391, 440)
        Me.add_btn.Name = "add_btn"
        Me.add_btn.Size = New System.Drawing.Size(75, 23)
        Me.add_btn.TabIndex = 5
        Me.add_btn.Text = "Add"
        Me.add_btn.UseVisualStyleBackColor = True
        '
        'pinfo_grpbx
        '
        Me.pinfo_grpbx.Controls.Add(Me.gender_cmbbx)
        Me.pinfo_grpbx.Controls.Add(Me.name_txtbx)
        Me.pinfo_grpbx.Controls.Add(Me.age_txtbx)
        Me.pinfo_grpbx.Controls.Add(Me.pn_txtbx)
        Me.pinfo_grpbx.Controls.Add(Me.address_txtbx)
        Me.pinfo_grpbx.Controls.Add(Me.dissts_txtbx)
        Me.pinfo_grpbx.Controls.Add(Me.disease_txtbx)
        Me.pinfo_grpbx.Controls.Add(Me.Label11)
        Me.pinfo_grpbx.Controls.Add(Me.Label10)
        Me.pinfo_grpbx.Controls.Add(Me.Label9)
        Me.pinfo_grpbx.Controls.Add(Me.Label8)
        Me.pinfo_grpbx.Controls.Add(Me.Label7)
        Me.pinfo_grpbx.Controls.Add(Me.Label6)
        Me.pinfo_grpbx.Controls.Add(Me.Label5)
        Me.pinfo_grpbx.Location = New System.Drawing.Point(36, 176)
        Me.pinfo_grpbx.Name = "pinfo_grpbx"
        Me.pinfo_grpbx.Size = New System.Drawing.Size(306, 287)
        Me.pinfo_grpbx.TabIndex = 2
        Me.pinfo_grpbx.TabStop = False
        Me.pinfo_grpbx.Text = "Patient Information"
        '
        'gender_cmbbx
        '
        Me.gender_cmbbx.FormattingEnabled = True
        Me.gender_cmbbx.Items.AddRange(New Object() {"Male", "Female", "Others"})
        Me.gender_cmbbx.Location = New System.Drawing.Point(100, 73)
        Me.gender_cmbbx.Name = "gender_cmbbx"
        Me.gender_cmbbx.Size = New System.Drawing.Size(146, 21)
        Me.gender_cmbbx.TabIndex = 14
        '
        'name_txtbx
        '
        Me.name_txtbx.Location = New System.Drawing.Point(100, 38)
        Me.name_txtbx.Name = "name_txtbx"
        Me.name_txtbx.Size = New System.Drawing.Size(146, 20)
        Me.name_txtbx.TabIndex = 11
        '
        'age_txtbx
        '
        Me.age_txtbx.Location = New System.Drawing.Point(100, 103)
        Me.age_txtbx.Name = "age_txtbx"
        Me.age_txtbx.Size = New System.Drawing.Size(146, 20)
        Me.age_txtbx.TabIndex = 13
        '
        'pn_txtbx
        '
        Me.pn_txtbx.Location = New System.Drawing.Point(100, 135)
        Me.pn_txtbx.Name = "pn_txtbx"
        Me.pn_txtbx.Size = New System.Drawing.Size(146, 20)
        Me.pn_txtbx.TabIndex = 12
        '
        'address_txtbx
        '
        Me.address_txtbx.Location = New System.Drawing.Point(100, 162)
        Me.address_txtbx.Multiline = True
        Me.address_txtbx.Name = "address_txtbx"
        Me.address_txtbx.Size = New System.Drawing.Size(146, 47)
        Me.address_txtbx.TabIndex = 11
        '
        'dissts_txtbx
        '
        Me.dissts_txtbx.Location = New System.Drawing.Point(100, 249)
        Me.dissts_txtbx.Name = "dissts_txtbx"
        Me.dissts_txtbx.Size = New System.Drawing.Size(146, 20)
        Me.dissts_txtbx.TabIndex = 10
        '
        'disease_txtbx
        '
        Me.disease_txtbx.Location = New System.Drawing.Point(100, 215)
        Me.disease_txtbx.Name = "disease_txtbx"
        Me.disease_txtbx.Size = New System.Drawing.Size(146, 20)
        Me.disease_txtbx.TabIndex = 9
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(7, 252)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(92, 13)
        Me.Label11.TabIndex = 8
        Me.Label11.Text = "Status Of Disease"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(7, 218)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(45, 13)
        Me.Label10.TabIndex = 7
        Me.Label10.Text = "Disease"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(7, 178)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(45, 13)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "Address"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(7, 138)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(38, 13)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "Phone"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(7, 106)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(26, 13)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Age"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(7, 73)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 13)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Gender"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 41)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Name"
        '
        'roominfo_grpbx
        '
        Me.roominfo_grpbx.Controls.Add(Me.room_grid)
        Me.roominfo_grpbx.Location = New System.Drawing.Point(385, 59)
        Me.roominfo_grpbx.Name = "roominfo_grpbx"
        Me.roominfo_grpbx.Size = New System.Drawing.Size(420, 337)
        Me.roominfo_grpbx.TabIndex = 3
        Me.roominfo_grpbx.TabStop = False
        Me.roominfo_grpbx.Text = "Room Information"
        '
        'room_grid
        '
        Me.room_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.room_grid.Location = New System.Drawing.Point(6, 47)
        Me.room_grid.Name = "room_grid"
        Me.room_grid.Size = New System.Drawing.Size(408, 258)
        Me.room_grid.TabIndex = 10
        '
        'regid_grpbx
        '
        Me.regid_grpbx.Controls.Add(Me.date_picker)
        Me.regid_grpbx.Controls.Add(Me.pid_txtbx)
        Me.regid_grpbx.Controls.Add(Me.Label3)
        Me.regid_grpbx.Controls.Add(Me.Label2)
        Me.regid_grpbx.Location = New System.Drawing.Point(36, 59)
        Me.regid_grpbx.Name = "regid_grpbx"
        Me.regid_grpbx.Size = New System.Drawing.Size(306, 100)
        Me.regid_grpbx.TabIndex = 1
        Me.regid_grpbx.TabStop = False
        Me.regid_grpbx.Text = "Registraion ID"
        '
        'date_picker
        '
        Me.date_picker.Location = New System.Drawing.Point(52, 56)
        Me.date_picker.Name = "date_picker"
        Me.date_picker.Size = New System.Drawing.Size(113, 20)
        Me.date_picker.TabIndex = 3
        Me.date_picker.Value = New Date(2019, 10, 11, 0, 0, 0, 0)
        '
        'pid_txtbx
        '
        Me.pid_txtbx.Location = New System.Drawing.Point(52, 19)
        Me.pid_txtbx.Name = "pid_txtbx"
        Me.pid_txtbx.Size = New System.Drawing.Size(113, 20)
        Me.pid_txtbx.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Date"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(21, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "No"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label1.Location = New System.Drawing.Point(240, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(169, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Patient Registration"
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
        Me.details_grpbx.Location = New System.Drawing.Point(23, 26)
        Me.details_grpbx.Name = "details_grpbx"
        Me.details_grpbx.Size = New System.Drawing.Size(283, 550)
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
        'Patientregistration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1350, 729)
        Me.Controls.Add(Me.details_grpbx)
        Me.Controls.Add(Me.ptreg_panel)
        Me.Name = "Patientregistration"
        Me.Text = "Patient_s_Registration"
        Me.ptreg_panel.ResumeLayout(False)
        Me.ptreg_panel.PerformLayout()
        Me.pinfo_grpbx.ResumeLayout(False)
        Me.pinfo_grpbx.PerformLayout()
        Me.roominfo_grpbx.ResumeLayout(False)
        CType(Me.room_grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.regid_grpbx.ResumeLayout(False)
        Me.regid_grpbx.PerformLayout()
        Me.details_grpbx.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ptreg_panel As Panel
    Friend WithEvents pinfo_grpbx As GroupBox
    Friend WithEvents roominfo_grpbx As GroupBox
    Friend WithEvents regid_grpbx As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents pid_txtbx As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents name_txtbx As TextBox
    Friend WithEvents age_txtbx As TextBox
    Friend WithEvents pn_txtbx As TextBox
    Friend WithEvents address_txtbx As TextBox
    Friend WithEvents dissts_txtbx As TextBox
    Friend WithEvents disease_txtbx As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents date_picker As DateTimePicker
    Friend WithEvents clr_btn As Button
    Friend WithEvents add_btn As Button
    Friend WithEvents gender_cmbbx As ComboBox
    Friend WithEvents room_grid As DataGridView
    Friend WithEvents details_grpbx As GroupBox
    Friend WithEvents logout_btn As Button
    Friend WithEvents addward_btn As Button
    Friend WithEvents adduser_btn As Button
    Friend WithEvents userinfo_btn As Button
    Friend WithEvents ptinfo_btn As Button
    Friend WithEvents ptchkout_btn As Button
    Friend WithEvents ptreg_btn As Button
End Class
