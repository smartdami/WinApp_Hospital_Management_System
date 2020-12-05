Imports System.Data
Imports System.Data.OleDb
Public Class addnewuser
    Private Sub add_btn_Click(sender As Object, e As EventArgs) Handles add_btn.Click
        If uid_txtbx.Text = "" Then
            uid_txtbx.Focus()
        ElseIf uname_txtbx.Text = "" Then
            uname_txtbx.Focus()
        ElseIf pass_txtbx.Text = "" Then
            pass_txtbx.Focus()
        ElseIf jobpos_txtbx.Text = "" Then
            jobpos_txtbx.Focus()
        Else
            Dim tdcon As New OleDbConnection
            Dim tdadp As New OleDbDataAdapter
            Dim tdset As New DataSet
            Dim tdcmd As New OleDbCommand
            tdcon = New OleDbConnection("PROVIDER=" _
                & "MICROSOFT.Jet.OLEDB.4.0;" _
                & "DATA SOURCE=E:\18-PCA-003\hospital.mdb")
            tdcon.Open()
            tdcmd.Connection = tdcon
            tdcmd.CommandText = "Insert into logtable(userid,passcode,username,jpos)" _
                            & " values(" & "'" & uid_txtbx.Text & "'," _
                            & "'" & pass_txtbx.Text & "'," _
                            & "'" & uname_txtbx.Text & "'," _
                            & "'" & jobpos_txtbx.Text & "')"
            tdcmd.ExecuteNonQuery()
            tdcon.Close()
            MsgBox("User Details Are Instered Into The Database")
        End If
    End Sub

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



    Private Sub logout_btn_Click(sender As Object, e As EventArgs) Handles logout_btn.Click
        Me.Hide()
        login.Show()
    End Sub


    Private Sub addnewuser_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub clr_btn_Click(sender As Object, e As EventArgs) Handles clr_btn.Click
        jobpos_txtbx.Text = ""
        uid_txtbx.Text = ""
        pass_txtbx.Text = ""
        uname_txtbx.Text = ""
    End Sub
End Class