Imports System.Data
Imports System.Data.OleDb
Public Class userinformation

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



    Private Sub adduser_btn_Click(sender As Object, e As EventArgs) Handles adduser_btn.Click
        Me.Hide()
        addnewuser.Show()
    End Sub

    Private Sub logout_btn_Click(sender As Object, e As EventArgs) Handles logout_btn.Click
        Me.Hide()
        login.Show()
    End Sub


    Private Sub show_btn_Click(sender As Object, e As EventArgs) Handles show_btn.Click
        Dim tdcon As New OleDbConnection
        Dim tdadp As New OleDbDataAdapter
        Dim tdset As New DataSet
        Dim tdcmd As New OleDbCommand
        tdcon = New OleDbConnection("PROVIDER=" _
                & "MICROSOFT.Jet.OLEDB.4.0;" _
                & "DATA SOURCE=E:\18-PCA-003\hospital.mdb;")
        tdcon.Open()
        tdadp = New OleDbDataAdapter("select * From logtable", tdcon)
        tdadp.Fill(tdset, "logtable")
        user_grid.DataSource = tdset.Tables("logtable").DefaultView
        tdcon.Close()
    End Sub

    Private Sub clear_btn_Click(sender As Object, e As EventArgs) Handles clear_btn.Click
        user_grid.DataSource = ""
    End Sub
End Class