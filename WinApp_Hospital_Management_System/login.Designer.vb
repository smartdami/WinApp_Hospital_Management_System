<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class login
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
        Me.loyola_lbl = New System.Windows.Forms.Label()
        Me.user_lbl = New System.Windows.Forms.Label()
        Me.pass_lbl = New System.Windows.Forms.Label()
        Me.user_txtbx = New System.Windows.Forms.TextBox()
        Me.pass_txtbx = New System.Windows.Forms.TextBox()
        Me.login_btn = New System.Windows.Forms.Button()
        Me.res_btn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'loyola_lbl
        '
        Me.loyola_lbl.AutoSize = True
        Me.loyola_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loyola_lbl.Location = New System.Drawing.Point(501, 58)
        Me.loyola_lbl.Name = "loyola_lbl"
        Me.loyola_lbl.Size = New System.Drawing.Size(350, 37)
        Me.loyola_lbl.TabIndex = 0
        Me.loyola_lbl.Text = "Loyola Hospital System"
        '
        'user_lbl
        '
        Me.user_lbl.AutoSize = True
        Me.user_lbl.Location = New System.Drawing.Point(514, 175)
        Me.user_lbl.Name = "user_lbl"
        Me.user_lbl.Size = New System.Drawing.Size(57, 13)
        Me.user_lbl.TabIndex = 1
        Me.user_lbl.Text = "UserName"
        '
        'pass_lbl
        '
        Me.pass_lbl.AutoSize = True
        Me.pass_lbl.Location = New System.Drawing.Point(514, 222)
        Me.pass_lbl.Name = "pass_lbl"
        Me.pass_lbl.Size = New System.Drawing.Size(53, 13)
        Me.pass_lbl.TabIndex = 2
        Me.pass_lbl.Text = "Password"
        '
        'user_txtbx
        '
        Me.user_txtbx.Location = New System.Drawing.Point(609, 168)
        Me.user_txtbx.Name = "user_txtbx"
        Me.user_txtbx.Size = New System.Drawing.Size(100, 20)
        Me.user_txtbx.TabIndex = 3
        '
        'pass_txtbx
        '
        Me.pass_txtbx.Location = New System.Drawing.Point(609, 215)
        Me.pass_txtbx.Name = "pass_txtbx"
        Me.pass_txtbx.Size = New System.Drawing.Size(100, 20)
        Me.pass_txtbx.TabIndex = 4
        Me.pass_txtbx.UseSystemPasswordChar = True
        '
        'login_btn
        '
        Me.login_btn.Location = New System.Drawing.Point(609, 261)
        Me.login_btn.Name = "login_btn"
        Me.login_btn.Size = New System.Drawing.Size(75, 23)
        Me.login_btn.TabIndex = 5
        Me.login_btn.Text = "Login"
        Me.login_btn.UseVisualStyleBackColor = True
        '
        'res_btn
        '
        Me.res_btn.Location = New System.Drawing.Point(690, 261)
        Me.res_btn.Name = "res_btn"
        Me.res_btn.Size = New System.Drawing.Size(75, 23)
        Me.res_btn.TabIndex = 6
        Me.res_btn.Text = "Reset"
        Me.res_btn.UseVisualStyleBackColor = True
        '
        'login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1350, 729)
        Me.Controls.Add(Me.res_btn)
        Me.Controls.Add(Me.login_btn)
        Me.Controls.Add(Me.pass_txtbx)
        Me.Controls.Add(Me.user_txtbx)
        Me.Controls.Add(Me.pass_lbl)
        Me.Controls.Add(Me.user_lbl)
        Me.Controls.Add(Me.loyola_lbl)
        Me.Name = "login"
        Me.Text = "Loyola Hospital"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents loyola_lbl As Label
    Friend WithEvents user_lbl As Label
    Friend WithEvents pass_lbl As Label
    Friend WithEvents user_txtbx As TextBox
    Friend WithEvents pass_txtbx As TextBox
    Friend WithEvents login_btn As Button
    Friend WithEvents res_btn As Button
End Class
