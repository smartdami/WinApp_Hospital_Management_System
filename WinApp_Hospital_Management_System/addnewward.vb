Imports System
Imports System.Data.OleDb
Public Class Addnewward
    Private Sub adddet_btn_Click(sender As Object, e As EventArgs) Handles adddet_btn.Click
        If building_txtbx.Text = "" Then
            building_txtbx.Focus()
        ElseIf roomtype_combx.Text = "" Then
            roomtype_combx.Focus()
        ElseIf roomno_txtbx.Text = "" Then
            roomno_txtbx.Focus()
        ElseIf uprice_txtbx.Text = "" Then
            uprice_txtbx.Focus()
        Else
            Dim tdcon As New OleDbConnection
        Dim tdcmd As New OleDbCommand
        tdcon = New OleDbConnection("PROVIDER=" _
                & "MICROSOFT.Jet.OLEDB.4.0;" _
                & "DATA SOURCE=E:\18-PCA-003\hospital.mdb;")
        tdcon.Open()
        tdcmd.Connection = tdcon
        tdcmd.CommandText = "Insert into wardtable(building,roomtype,roomno,unitprice,status)" _
                            & " values(" & "'" & building_txtbx.Text & "'," _
                            & "'" & roomtype_combx.Text & "'," _
                            & "'" & roomno_txtbx.Text & "'," _
                            & "'" & uprice_txtbx.Text & "'," _
                            & "'Available')"

        tdcmd.ExecuteNonQuery()
        tdcon.Close()
            MsgBox("Ward Details Are Instered Into The Database")
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

    Private Sub clr_btn_Click(sender As Object, e As EventArgs) Handles clr_btn.Click
        building_txtbx.Text = ""
        roomno_txtbx.Text = ""
        roomtype_combx.Text = ""
        uprice_txtbx.Text = ""

    End Sub
End Class