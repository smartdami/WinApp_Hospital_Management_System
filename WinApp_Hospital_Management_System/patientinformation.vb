Imports System.Data
Imports System.Data.OleDb
Public Class patient_Information
    Private Sub staffinfo_btn_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ok_btn_Click(sender As Object, e As EventArgs) Handles ok_btn.Click
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
                Age_txtbx.Text = tdset.Tables("pregtable").Rows(0).Item("age")
                Gender_txtbx.Text = tdset.Tables("pregtable").Rows(0).Item("gender")
                pn_txtbx.Text = tdset.Tables("pregtable").Rows(0).Item("phone")
                add_txtbx.Text = tdset.Tables("pregtable").Rows(0).Item("address")
                disease_txtbx.Text = tdset.Tables("pregtable").Rows(0).Item("disease")
                dissts_txtbx.Text = tdset.Tables("pregtable").Rows(0).Item("statusofdisease")
                Chkin_txtbx.Text = tdset.Tables("pregtable").Rows(0).Item("dateofreg")
                roomtype_txtbx.Text = tdset.Tables("pregtable").Rows(0).Item("roomtype")
                roomno_txtbx.Text = tdset.Tables("pregtable").Rows(0).Item("roomno")
                building_txtbx.Text = tdset.Tables("pregtable").Rows(0).Item("building")
            Else
                MsgBox("Enter Valid Patient ID")
            End If
        End If
    End Sub

    Private Sub update_btn_Click(sender As Object, e As EventArgs) Handles update_btn.Click
        Dim tdcon As New OleDbConnection
        Dim tdadp As New OleDbDataAdapter
        Dim tdcmd As New OleDbCommand
        tdcon = New OleDbConnection("PROVIDER=" _
                & "MICROSOFT.Jet.OLEDB.4.0;" _
                & "DATA SOURCE=E:\18-PCA-003\hospital.mdb;")
        tdcon.Open()
        tdcmd.Connection = tdcon
        tdcmd.CommandText = "Update pregtable set pid=" & "'" & pid_textbx.Text & "'," & "pname=" & "'" & name_txtbx.Text & "'," & "age=" & "'" & Age_txtbx.Text & "'," & "gender=" & "'" & Gender_txtbx.Text & "'," & "phone=" & "'" & pn_txtbx.Text & "'," & "address=" & "'" & add_txtbx.Text & "'," & "disease=" & "'" & disease_txtbx.Text & "'," & "statusofdisease=" & "'" & dissts_txtbx.Text & "'" & "where pid=" & "'" & pid_textbx.Text & "'"
        tdcmd.ExecuteNonQuery()
        MsgBox("Details are updated into Patient Table")
        tdcon.Close()

    End Sub
    Private Sub ptreg_btn_Click(sender As Object, e As EventArgs) Handles ptreg_btn.Click
        Me.Hide()
        Patientregistration.Show()
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

    Private Sub clr_btn_Click(sender As Object, e As EventArgs) Handles clr_btn.Click
        pid_textbx.Text = ""
        name_txtbx.Text = ""
        Age_txtbx.Text = ""
        Gender_txtbx.Text = ""
        pn_txtbx.Text = ""
        add_txtbx.Text = ""
        disease_txtbx.Text = ""
        roomtype_txtbx.Text = ""
        roomno_txtbx.Text = ""
        building_txtbx.Text = ""

    End Sub
End Class