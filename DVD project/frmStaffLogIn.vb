Imports System.Data.OleDb

Public Class frmStaffLogIn
    Private Sub btnLogIn_Click(sender As Object, e As EventArgs) Handles btnLogIn.Click
        'CHECKING LOG IN DETAILS
        If dbConnect() Then
            Dim SQLCmd As New OleDbCommand
            With SQLCmd
                .Connection = cn
                .CommandText = "Select * From StaffTbl Where (SUsername = @StaffUsername) and (SPassword = @StaffPassword)"
                .Parameters.AddWithValue("@StaffUsername", txtUsername.Text)
                .Parameters.AddWithValue("@StaffPassword", txtPassword.Text)
                Dim rs As OleDbDataReader = .ExecuteReader()

                'IF MATCH THEN LOG IN
                If rs.Read Then
                    PublicStaffName = rs("SFName")
                    PublicStaffID = rs("StaffID")

                    FrmMain.Show()
                    ' ELSE DONT LOG IN
                Else
                    MsgBox("Sorry, Incorrect log in details entered", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

                End If
                rs.Close()
            End With
            cn.Close()
        End If
    End Sub

    Private Sub frmStaffLogIn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'CLEAR INFORMATION
        btnClear.PerformClick()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'CLEAR DATA
        PublicStaffAccessLevel = ""
        PublicStaffID = ""
        PublicStaffName = ""
        txtUsername.Text = ""
        txtPassword.Text = ""
        FrmMain.Close()
        frmCust.Close()
        frmCustomers.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonBack.Click
        'GOING BACK
        Me.Hide()
        frmLogIn.Show()
    End Sub
End Class