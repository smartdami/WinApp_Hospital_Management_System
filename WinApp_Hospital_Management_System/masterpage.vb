Public Class masterpage

    Private Sub ptreg_btn_Click(sender As Object, e As EventArgs) Handles ptreg_btn.Click
        Me.Hide()
        Patientregistration.Show()
    End Sub

    Private Sub ptinfo_btn_Click(sender As Object, e As EventArgs) Handles ptinfo_btn.Click
        Me.Hide()
        patient_Information.Show()
    End Sub

    Private Sub ptchkout_btn_Click(sender As Object, e As EventArgs) Handles ptchkout_btn.Click
        Me.Hide()
        Patientcheckout.Show()

    End Sub


    Private Sub addward_btn_Click(sender As Object, e As EventArgs) Handles addward_btn.Click
        Me.Hide()
        Addnewward.Show()
    End Sub

    Private Sub userinfo_btn_Click(sender As Object, e As EventArgs) Handles userinfo_btn.Click
        Me.Hide()
        userinformation.Show()
    End Sub

    Private Sub adduser_btn_Click(sender As Object, e As EventArgs) Handles adduser_btn.Click
        Me.Hide()
        addnewuser.Show()
    End Sub

    Private Sub logout_btn_Click(sender As Object, e As EventArgs) Handles logout_btn.Click
        Me.Hide()
        login.Show()
    End Sub

    Private Sub masterpage_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class