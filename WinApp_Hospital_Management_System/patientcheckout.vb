Imports System.Data
Imports System.Data.OleDb
Public Class Patientcheckout


    Private Sub ptreg_btn_Click(sender As Object, e As EventArgs) Handles ptreg_btn.Click
        Me.Hide()
        Patientregistration.Show()
    End Sub

    Private Sub ptinfo_btn_Click(sender As Object, e As EventArgs) Handles ptinfo_btn.Click
        Me.Hide()
        patient_Information.Show()
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


    Private Sub pid_btn_Click(sender As Object, e As EventArgs) Handles pid_btn.Click
        If pid_txtbx.Text = "" Then
            pid_txtbx.Focus()
        Else
            Dim tdcon As New OleDbConnection
            Dim tdadp As New OleDbDataAdapter
        Dim tdset As New DataSet
        Dim tdcmd As New OleDbCommand
        tdcon = New OleDbConnection("PROVIDER=" _
                & "MICROSOFT.Jet.OLEDB.4.0;" _
                & "DATA SOURCE=E:\18-PCA-003\hospital.mdb;")
        tdcon.Open()
        tdadp = New OleDbDataAdapter("select * From pregtable Where pid=" & "'" & pid_txtbx.Text & "'", tdcon)
        tdadp.Fill(tdset, "pregtable")
        If (tdset.Tables("pregtable").Rows.Count > 0) Then
            pid_textbx.Text = tdset.Tables("pregtable").Rows(0).Item("pid")
            name_txtbx.Text = tdset.Tables("pregtable").Rows(0).Item("pname")
            age_txtbx.Text = tdset.Tables("pregtable").Rows(0).Item("age")
            gender_txtbx.Text = tdset.Tables("pregtable").Rows(0).Item("gender")
            pn_txtbx.Text = tdset.Tables("pregtable").Rows(0).Item("phone")
            Add_txtbx.Text = tdset.Tables("pregtable").Rows(0).Item("address")
            disease_txtbx.Text = tdset.Tables("pregtable").Rows(0).Item("disease")
            in_date.Value = tdset.Tables("pregtable").Rows(0).Item("dateofreg")
            roomtype_txtbx.Text = tdset.Tables("pregtable").Rows(0).Item("roomtype")
            roomno_txtbx.Text = tdset.Tables("pregtable").Rows(0).Item("roomno")
            building_txtbx.Text = tdset.Tables("pregtable").Rows(0).Item("building")
            unitprice_txtbx.Text = tdset.Tables("pregtable").Rows(0).Item("unitprice")
            building_txtbx.Text = tdset.Tables("pregtable").Rows(0).Item("building")
        Else
            MsgBox("Enter Valid Patient ID")
        End If
        End If
    End Sub

    Private Sub Sub_btn_Click(sender As Object, e As EventArgs) Handles Sub_btn.Click
        If charges_txtbx.Text = "" Then
            charges_txtbx.Focus()
        Else
            Dim d1 As DateTime = in_date.Value
        Dim d2 As DateTime = dout_timepicker.Value
        Dim res As TimeSpan = d2.Subtract(d1)
        Dim x As Integer = res.TotalDays
        price_txtbx.Text = CDbl(charges_txtbx.Text) + (x * unitprice_txtbx.Text)
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
        tdcmd.CommandText = "Update pregtable set dateofdischarge=" & "'" & dout_timepicker.Value & "'" & "where pid=" & "'" & pid_txtbx.Text & "'"
        tdcmd.ExecuteNonQuery()
        tdupcmd.CommandText = "Update wardtable set status='Available' where roomno=" & "'" & roomno_txtbx.Text & "'"
        tdupcmd.ExecuteNonQuery()
        tdcon.Close()
        End If
    End Sub

    Private Sub clr_btn_Click(sender As Object, e As EventArgs) Handles clr_btn.Click
        pid_textbx.Text = ""
        name_txtbx.Text = ""
        age_txtbx.Text = ""
        gender_txtbx.Text = ""
        pn_txtbx.Text = ""
        Add_txtbx.Text = ""
        disease_txtbx.Text = ""
        roomtype_txtbx.Text = ""
        roomno_txtbx.Text = ""
        building_txtbx.Text = ""
        unitprice_txtbx.Text = ""
        building_txtbx.Text = ""
    End Sub
End Class