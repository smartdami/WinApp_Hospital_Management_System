Imports System.Data
Imports System.Data.OleDb

Public Class login

    Private Sub login_btn_Click(sender As Object, e As EventArgs) Handles login_btn.Click
        Dim tdpass, tduid As String
        Dim tdPos As String
        Dim tdcon As New OleDbConnection
        Dim tdadp As New OleDbDataAdapter
        Dim tdset As New DataSet
        Dim tdcmd As New OleDbCommand
        tdcon = New OleDbConnection("PROVIDER=" _
                & "MICROSOFT.Jet.OLEDB.4.0;" _
                & "DATA SOURCE=E:\18-PCA-003\hospital.mdb;")
        If user_txtbx.Text = "" Then
            user_txtbx.Focus()
        ElseIf pass_txtbx.Text = "" Then
            pass_txtbx.Focus()
        Else
            tdcon.Open()
            tdadp = New OleDbDataAdapter("select * From logtable Where userid=" & "'" & user_txtbx.Text & "'", tdcon)
            tdadp.Fill(tdset, "logtable")
            If (tdset.Tables("logtable").Rows.Count > 0) Then
                tduid = tdset.Tables("logtable").Rows(0).Item("userid")
                tdpass = tdset.Tables("logtable").Rows(0).Item("passcode")
                tdPos = tdset.Tables("logtable").Rows(0).Item("jpos")
                If ((user_txtbx.Text) = tduid) And ((pass_txtbx.Text) = tdpass) Then
                    If tdPos = "Admin" Or tdPos = "Manager" Then
                        masterpage.adduser_btn.Enabled = True
                        addnewuser.adduser_btn.Enabled = True
                        Addnewward.adduser_btn.Enabled = True
                        Patientregistration.adduser_btn.Enabled = True
                        patient_Information.adduser_btn.Enabled = True
                        userinformation.adduser_btn.Enabled = True
                        Patientcheckout.adduser_btn.Enabled = True
                        masterpage.Show()
                        Me.Hide()
                    Else
                        masterpage.Show()
                        tdcon.Close()
                        Me.Hide()
                    End If
                Else
                    MsgBox("Enter the Correct Password")
                End If
            Else
                MsgBox("Enter the Correct username or Password")

            End If
        End If

    End Sub
End Class