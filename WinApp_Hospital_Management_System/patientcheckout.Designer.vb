<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Patientcheckout
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
        Me.ptinfo_panel = New System.Windows.Forms.Panel()
        Me.in_date = New System.Windows.Forms.DateTimePicker()
        Me.dout_timepicker = New System.Windows.Forms.DateTimePicker()
        Me.cls_btn = New System.Windows.Forms.Button()
        Me.price_txtbx = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.charges_txtbx = New System.Windows.Forms.TextBox()
        Me.unitprice_txtbx = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.building_txtbx = New System.Windows.Forms.TextBox()
        Me.roomtype_txtbx = New System.Windows.Forms.TextBox()
        Me.roomno_txtbx = New System.Windows.Forms.TextBox()
        Me.clr_btn = New System.Windows.Forms.Button()
        Me.Sub_btn = New System.Windows.Forms.Button()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.disease_txtbx = New System.Windows.Forms.TextBox()
        Me.Add_txtbx = New System.Windows.Forms.TextBox()
        Me.pn_txtbx = New System.Windows.Forms.TextBox()
        Me.gender_txtbx = New System.Windows.Forms.TextBox()
        Me.age_txtbx = New System.Windows.Forms.TextBox()
        Me.name_txtbx = New System.Windows.Forms.TextBox()
        Me.pid_textbx = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.pid_btn = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.pid_txtbx = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.details_grpbx = New System.Windows.Forms.GroupBox()
        Me.logout_btn = New System.Windows.Forms.Button()
        Me.addward_btn = New System.Windows.Forms.Button()
        Me.adduser_btn = New System.Windows.Forms.Button()
        Me.userinfo_btn = New System.Windows.Forms.Button()
        Me.ptinfo_btn = New System.Windows.Forms.Button()
        Me.ptchkout_btn = New System.Windows.Forms.Button()
        Me.ptreg_btn = New System.Windows.Forms.Button()
        Me.ptinfo_panel.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.details_grpbx.SuspendLayout()
        Me.SuspendLayout()
        '
        'ptinfo_panel
        '
        Me.ptinfo_panel.BackColor = System.Drawing.SystemColors.Control
        Me.ptinfo_panel.Controls.Add(Me.in_date)
        Me.ptinfo_panel.Controls.Add(Me.dout_timepicker)
        Me.ptinfo_panel.Controls.Add(Me.cls_btn)
        Me.ptinfo_panel.Controls.Add(Me.price_txtbx)
        Me.ptinfo_panel.Controls.Add(Me.Label18)
        Me.ptinfo_panel.Controls.Add(Me.Label17)
        Me.ptinfo_panel.Controls.Add(Me.charges_txtbx)
        Me.ptinfo_panel.Controls.Add(Me.unitprice_txtbx)
        Me.ptinfo_panel.Controls.Add(Me.Label2)
        Me.ptinfo_panel.Controls.Add(Me.building_txtbx)
        Me.ptinfo_panel.Controls.Add(Me.roomtype_txtbx)
        Me.ptinfo_panel.Controls.Add(Me.roomno_txtbx)
        Me.ptinfo_panel.Controls.Add(Me.clr_btn)
        Me.ptinfo_panel.Controls.Add(Me.Sub_btn)
        Me.ptinfo_panel.Controls.Add(Me.Label15)
        Me.ptinfo_panel.Controls.Add(Me.Label14)
        Me.ptinfo_panel.Controls.Add(Me.Label13)
        Me.ptinfo_panel.Controls.Add(Me.Label12)
        Me.ptinfo_panel.Controls.Add(Me.Label11)
        Me.ptinfo_panel.Controls.Add(Me.disease_txtbx)
        Me.ptinfo_panel.Controls.Add(Me.Add_txtbx)
        Me.ptinfo_panel.Controls.Add(Me.pn_txtbx)
        Me.ptinfo_panel.Controls.Add(Me.gender_txtbx)
        Me.ptinfo_panel.Controls.Add(Me.age_txtbx)
        Me.ptinfo_panel.Controls.Add(Me.name_txtbx)
        Me.ptinfo_panel.Controls.Add(Me.pid_textbx)
        Me.ptinfo_panel.Controls.Add(Me.Label10)
        Me.ptinfo_panel.Controls.Add(Me.Label9)
        Me.ptinfo_panel.Controls.Add(Me.Label8)
        Me.ptinfo_panel.Controls.Add(Me.Label7)
        Me.ptinfo_panel.Controls.Add(Me.Label6)
        Me.ptinfo_panel.Controls.Add(Me.Label5)
        Me.ptinfo_panel.Controls.Add(Me.Label4)
        Me.ptinfo_panel.Controls.Add(Me.GroupBox5)
        Me.ptinfo_panel.Controls.Add(Me.Label1)
        Me.ptinfo_panel.Location = New System.Drawing.Point(351, 65)
        Me.ptinfo_panel.Name = "ptinfo_panel"
        Me.ptinfo_panel.Size = New System.Drawing.Size(845, 472)
        Me.ptinfo_panel.TabIndex = 8
        '
        'in_date
        '
        Me.in_date.Location = New System.Drawing.Point(569, 87)
        Me.in_date.Name = "in_date"
        Me.in_date.Size = New System.Drawing.Size(100, 20)
        Me.in_date.TabIndex = 40
        '
        'dout_timepicker
        '
        Me.dout_timepicker.Location = New System.Drawing.Point(569, 125)
        Me.dout_timepicker.Name = "dout_timepicker"
        Me.dout_timepicker.Size = New System.Drawing.Size(100, 20)
        Me.dout_timepicker.TabIndex = 39
        '
        'cls_btn
        '
        Me.cls_btn.BackColor = System.Drawing.SystemColors.ControlLight
        Me.cls_btn.Location = New System.Drawing.Point(569, 388)
        Me.cls_btn.Name = "cls_btn"
        Me.cls_btn.Size = New System.Drawing.Size(100, 23)
        Me.cls_btn.TabIndex = 38
        Me.cls_btn.Text = "Close"
        Me.cls_btn.UseVisualStyleBackColor = False
        '
        'price_txtbx
        '
        Me.price_txtbx.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.price_txtbx.Enabled = False
        Me.price_txtbx.Location = New System.Drawing.Point(569, 316)
        Me.price_txtbx.Name = "price_txtbx"
        Me.price_txtbx.Size = New System.Drawing.Size(100, 20)
        Me.price_txtbx.TabIndex = 37
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.SystemColors.Control
        Me.Label18.Location = New System.Drawing.Point(491, 323)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(31, 13)
        Me.Label18.TabIndex = 36
        Me.Label18.Text = "Price"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.SystemColors.Control
        Me.Label17.Location = New System.Drawing.Point(490, 295)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(46, 13)
        Me.Label17.TabIndex = 35
        Me.Label17.Text = "Charges"
        '
        'charges_txtbx
        '
        Me.charges_txtbx.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.charges_txtbx.Location = New System.Drawing.Point(569, 288)
        Me.charges_txtbx.Name = "charges_txtbx"
        Me.charges_txtbx.Size = New System.Drawing.Size(100, 20)
        Me.charges_txtbx.TabIndex = 33
        '
        'unitprice_txtbx
        '
        Me.unitprice_txtbx.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.unitprice_txtbx.Enabled = False
        Me.unitprice_txtbx.Location = New System.Drawing.Point(569, 256)
        Me.unitprice_txtbx.Name = "unitprice_txtbx"
        Me.unitprice_txtbx.Size = New System.Drawing.Size(100, 20)
        Me.unitprice_txtbx.TabIndex = 31
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(488, 263)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Unit Price"
        '
        'building_txtbx
        '
        Me.building_txtbx.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.building_txtbx.Enabled = False
        Me.building_txtbx.Location = New System.Drawing.Point(569, 224)
        Me.building_txtbx.Name = "building_txtbx"
        Me.building_txtbx.Size = New System.Drawing.Size(100, 20)
        Me.building_txtbx.TabIndex = 29
        '
        'roomtype_txtbx
        '
        Me.roomtype_txtbx.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.roomtype_txtbx.Enabled = False
        Me.roomtype_txtbx.Location = New System.Drawing.Point(569, 192)
        Me.roomtype_txtbx.Name = "roomtype_txtbx"
        Me.roomtype_txtbx.Size = New System.Drawing.Size(100, 20)
        Me.roomtype_txtbx.TabIndex = 28
        '
        'roomno_txtbx
        '
        Me.roomno_txtbx.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.roomno_txtbx.Enabled = False
        Me.roomno_txtbx.Location = New System.Drawing.Point(569, 160)
        Me.roomno_txtbx.Name = "roomno_txtbx"
        Me.roomno_txtbx.Size = New System.Drawing.Size(100, 20)
        Me.roomno_txtbx.TabIndex = 27
        '
        'clr_btn
        '
        Me.clr_btn.BackColor = System.Drawing.SystemColors.ControlLight
        Me.clr_btn.Location = New System.Drawing.Point(569, 432)
        Me.clr_btn.Name = "clr_btn"
        Me.clr_btn.Size = New System.Drawing.Size(100, 23)
        Me.clr_btn.TabIndex = 24
        Me.clr_btn.Text = "Clear"
        Me.clr_btn.UseVisualStyleBackColor = False
        '
        'Sub_btn
        '
        Me.Sub_btn.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Sub_btn.Location = New System.Drawing.Point(569, 349)
        Me.Sub_btn.Name = "Sub_btn"
        Me.Sub_btn.Size = New System.Drawing.Size(100, 23)
        Me.Sub_btn.TabIndex = 23
        Me.Sub_btn.Text = "OK"
        Me.Sub_btn.UseVisualStyleBackColor = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.SystemColors.Control
        Me.Label15.Location = New System.Drawing.Point(488, 231)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(44, 13)
        Me.Label15.TabIndex = 22
        Me.Label15.Text = "Building"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.SystemColors.Control
        Me.Label14.Location = New System.Drawing.Point(488, 167)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(52, 13)
        Me.Label14.TabIndex = 21
        Me.Label14.Text = "Room No"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.SystemColors.Control
        Me.Label13.Location = New System.Drawing.Point(488, 199)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(62, 13)
        Me.Label13.TabIndex = 20
        Me.Label13.Text = "Room Type"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.SystemColors.Control
        Me.Label12.Location = New System.Drawing.Point(488, 131)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(50, 13)
        Me.Label12.TabIndex = 19
        Me.Label12.Text = "Date Out"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.SystemColors.Control
        Me.Label11.Location = New System.Drawing.Point(490, 94)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(42, 13)
        Me.Label11.TabIndex = 18
        Me.Label11.Text = "Date In"
        '
        'disease_txtbx
        '
        Me.disease_txtbx.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.disease_txtbx.Location = New System.Drawing.Point(265, 352)
        Me.disease_txtbx.Name = "disease_txtbx"
        Me.disease_txtbx.Size = New System.Drawing.Size(138, 20)
        Me.disease_txtbx.TabIndex = 17
        '
        'Add_txtbx
        '
        Me.Add_txtbx.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Add_txtbx.Enabled = False
        Me.Add_txtbx.Location = New System.Drawing.Point(263, 261)
        Me.Add_txtbx.Multiline = True
        Me.Add_txtbx.Name = "Add_txtbx"
        Me.Add_txtbx.Size = New System.Drawing.Size(139, 75)
        Me.Add_txtbx.TabIndex = 16
        '
        'pn_txtbx
        '
        Me.pn_txtbx.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.pn_txtbx.Enabled = False
        Me.pn_txtbx.Location = New System.Drawing.Point(263, 220)
        Me.pn_txtbx.Name = "pn_txtbx"
        Me.pn_txtbx.Size = New System.Drawing.Size(138, 20)
        Me.pn_txtbx.TabIndex = 15
        '
        'gender_txtbx
        '
        Me.gender_txtbx.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.gender_txtbx.Enabled = False
        Me.gender_txtbx.Location = New System.Drawing.Point(263, 188)
        Me.gender_txtbx.Name = "gender_txtbx"
        Me.gender_txtbx.Size = New System.Drawing.Size(138, 20)
        Me.gender_txtbx.TabIndex = 14
        '
        'age_txtbx
        '
        Me.age_txtbx.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.age_txtbx.Enabled = False
        Me.age_txtbx.Location = New System.Drawing.Point(263, 153)
        Me.age_txtbx.Name = "age_txtbx"
        Me.age_txtbx.Size = New System.Drawing.Size(138, 20)
        Me.age_txtbx.TabIndex = 13
        '
        'name_txtbx
        '
        Me.name_txtbx.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.name_txtbx.Enabled = False
        Me.name_txtbx.Location = New System.Drawing.Point(263, 118)
        Me.name_txtbx.Name = "name_txtbx"
        Me.name_txtbx.Size = New System.Drawing.Size(138, 20)
        Me.name_txtbx.TabIndex = 12
        '
        'pid_textbx
        '
        Me.pid_textbx.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.pid_textbx.Enabled = False
        Me.pid_textbx.Location = New System.Drawing.Point(263, 84)
        Me.pid_textbx.Name = "pid_textbx"
        Me.pid_textbx.Size = New System.Drawing.Size(138, 20)
        Me.pid_textbx.TabIndex = 11
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.SystemColors.Control
        Me.Label10.Location = New System.Drawing.Point(205, 359)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(45, 13)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "Disease"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.SystemColors.Control
        Me.Label9.Location = New System.Drawing.Point(208, 295)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(45, 13)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Address"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.SystemColors.Control
        Me.Label8.Location = New System.Drawing.Point(208, 227)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(38, 13)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Phone"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.Control
        Me.Label7.Location = New System.Drawing.Point(208, 195)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 13)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Gender"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.Control
        Me.Label6.Location = New System.Drawing.Point(208, 160)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(26, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Age"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.Location = New System.Drawing.Point(208, 125)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.Location = New System.Drawing.Point(208, 91)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(25, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "PID"
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox5.Controls.Add(Me.pid_btn)
        Me.GroupBox5.Controls.Add(Me.Label3)
        Me.GroupBox5.Controls.Add(Me.pid_txtbx)
        Me.GroupBox5.Location = New System.Drawing.Point(15, 91)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(166, 127)
        Me.GroupBox5.TabIndex = 3
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Patient's Details"
        '
        'pid_btn
        '
        Me.pid_btn.BackColor = System.Drawing.SystemColors.ControlLight
        Me.pid_btn.Location = New System.Drawing.Point(39, 87)
        Me.pid_btn.Name = "pid_btn"
        Me.pid_btn.Size = New System.Drawing.Size(75, 23)
        Me.pid_btn.TabIndex = 3
        Me.pid_btn.Text = "OK"
        Me.pid_btn.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Location = New System.Drawing.Point(36, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Input Patient's ID"
        '
        'pid_txtbx
        '
        Me.pid_txtbx.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.pid_txtbx.Location = New System.Drawing.Point(39, 50)
        Me.pid_txtbx.Name = "pid_txtbx"
        Me.pid_txtbx.Size = New System.Drawing.Size(100, 20)
        Me.pid_txtbx.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label1.Location = New System.Drawing.Point(240, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(151, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Patient Checkout"
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
        Me.details_grpbx.Location = New System.Drawing.Point(12, 50)
        Me.details_grpbx.Name = "details_grpbx"
        Me.details_grpbx.Size = New System.Drawing.Size(283, 487)
        Me.details_grpbx.TabIndex = 41
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
        'Patientcheckout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1350, 729)
        Me.Controls.Add(Me.details_grpbx)
        Me.Controls.Add(Me.ptinfo_panel)
        Me.Name = "Patientcheckout"
        Me.Text = "Loyola Hospital | Patient Checkout"
        Me.ptinfo_panel.ResumeLayout(False)
        Me.ptinfo_panel.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.details_grpbx.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ptinfo_panel As Panel
    Friend WithEvents building_txtbx As TextBox
    Friend WithEvents roomtype_txtbx As TextBox
    Friend WithEvents roomno_txtbx As TextBox
    Friend WithEvents clr_btn As Button
    Friend WithEvents Sub_btn As Button
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents disease_txtbx As TextBox
    Friend WithEvents Add_txtbx As TextBox
    Friend WithEvents pn_txtbx As TextBox
    Friend WithEvents gender_txtbx As TextBox
    Friend WithEvents age_txtbx As TextBox
    Friend WithEvents name_txtbx As TextBox
    Friend WithEvents pid_textbx As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents pid_btn As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents pid_txtbx As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents charges_txtbx As TextBox
    Friend WithEvents unitprice_txtbx As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents price_txtbx As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents cls_btn As Button
    Friend WithEvents dout_timepicker As DateTimePicker
    Friend WithEvents in_date As DateTimePicker
    Friend WithEvents details_grpbx As GroupBox
    Friend WithEvents logout_btn As Button
    Friend WithEvents addward_btn As Button
    Friend WithEvents adduser_btn As Button
    Friend WithEvents userinfo_btn As Button
    Friend WithEvents ptinfo_btn As Button
    Friend WithEvents ptchkout_btn As Button
    Friend WithEvents ptreg_btn As Button
End Class
