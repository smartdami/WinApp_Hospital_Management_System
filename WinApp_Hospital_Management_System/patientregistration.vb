Imports System
Imports System.Data
Imports System.Data.OleDb
Public Class Patientregistration
    Dim tdbuilding, tdroomno, tdunitprice, tdroomtype As String

    Private Sub room_grid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles room_grid.CellClick
        Dim index As Integer
        index = e.RowIndex
        Dim selectedrow As DataGridViewRow
        selectedrow = room_grid.Rows(index)
        tdbuilding = selectedrow.Cells(0).Value.ToString
        tdroomtype = selectedrow.Cells(1).Value.ToString
        tdroomno = selectedrow.Cells(2).Value.ToString
        tdunitprice = selectedrow.Cells(3).Value.ToString
    End Sub

    Private Sub add_btn_Click(sender As Object, e As EventArgs) Handles add_btn.Click
        Dim tdcon As New OleDbConnection
        Dim tdadp As New OleDbDataAdapter
        Dim tdset As New DataSet
        Dim tdcmd As New OleDbCommand
        Dim tdupcmd As New OleDbCommand
        tdcon = New OleDbConnection("PROVIDER=" _
                & "MICROSOFT.Jet.OLEDB.4.0;" _
                & "DATA SOURCE=E:\18-PCA-003\hospital.mdb;")
        tdcon.Open()
        tdcmd.Connection = tdcon
        tdupcmd.Connection = tdcon
        tdcmd.CommandText = "Insert into pregtable(pid,pname,gender,age,phone,address,disease,statusofdisease,dateofreg,roomtype,building,unitprice,roomno)" _
                            & " values(" & "'" & pid_txtbx.Text & "'," _
                            & "'" & name_txtbx.Text & "'," _
                            & "'" & gender_cmbbx.Text & "'," _
                            & "'" & age_txtbx.Text & "'," _
                            & "'" & pn_txtbx.Text & "'," _
                            & "'" & address_txtbx.Text & "'," _
                            & "'" & disease_txtbx.Text & "'," _
                            & "'" & dissts_txtbx.Text & "'," _
                            & "'" & date_picker.Value & "'," _
                            & "'" & tdroomtype & "'," _
                            & "'" & tdbuilding & "'," _
                            & "'" & tdunitprice & "'," _
                            & "'" & tdroomno & "')"
        tdupcmd.CommandText = "Update wardtable set status='NotAvailable' where roomno=" & "'" & tdroomno & "'"
        tdcmd.ExecuteNonQuery()
        tdupcmd.ExecuteNonQuery()
        tdcon.Close()
        MsgBox("patient Details Are Instered Into The Database")

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

    Private Sub clr_btn_Click(sender As Object, e As EventArgs) Handles clr_btn.Click
        name_txtbx.Text = ""
        age_txtbx.Text = ""
        gender_cmbbx.Text = ""
        pn_txtbx.Text = ""
        address_txtbx.Text = ""
        disease_txtbx.Text = ""
        pid_txtbx.Text = ""
        dissts_txtbx.Text = ""

    End Sub

    Private Sub room_grid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles room_grid.CellContentClick

    End Sub

    Private Sub adduser_btn_Click(sender As Object, e As EventArgs) Handles adduser_btn.Click
        Me.Hide()
        addnewuser.Show()
    End Sub

    Private Sub logout_btn_Click(sender As Object, e As EventArgs) Handles logout_btn.Click
        Me.Hide()
        login.Show()
    End Sub

    Private Sub Patientregistration_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim tdcon As New OleDbConnection

        Dim tdset As New DataSet
        Dim tdadp As New OleDbDataAdapter
        Dim tdcmd As New OleDbCommand
        tdcon = New OleDbConnection("PROVIDER=" _
                & "MICROSOFT.Jet.OLEDB.4.0;" _
                & "DATA SOURCE=E:\18-PCA-003\hospital.mdb")
        tdcon.Open()
        tdadp = New OleDbDataAdapter("select * From wardtable Where status='AVAILABLE'", tdcon)
        tdadp.Fill(tdset, "wardtable")
        room_grid.DataSource = tdset.Tables("wardtable").DefaultView
    End Sub
End Class