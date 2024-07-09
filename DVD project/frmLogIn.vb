Imports System.Data.OleDb

Public Class frmLogIn
    Private Sub frmLogIn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'CLEAR ALL DATA WHEN FORM LOADS
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

    Private Sub btnLogIn_Click(sender As Object, e As EventArgs) Handles btnLogIn.Click
        'VALIDATING LOG IN INFORMATION
        If dbConnect() Then

            Dim SQLCmd As New OleDbCommand
            With SQLCmd
                .Connection = cn
                .CommandText = "Select * From CustomerTbl Where (CUsername = @CUsername) and (CPassword = @CPassword)"
                .Parameters.AddWithValue("@CUsername", txtUsername.Text)
                .Parameters.AddWithValue("@CPassword", txtPassword.Text)
                Dim rs As OleDbDataReader = .ExecuteReader()
                If rs.Read Then
                    publicCustName = rs("CFName")
                    PublicCustID = rs("CustID")
                    FrmCustMain.Show()
                    'Me.Close()
                Else
                    MsgBox("Sorry, Incorrect log in details entered", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If

                rs.Close()
            End With
            cn.Close()
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub btnCreateLogIn_Click(sender As Object, e As EventArgs) Handles btnCreateLogIn.Click
        'CREATE LOG IN
        Me.Hide()
        frmCust.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnStaff.Click
        'STAFF LOG IN
        Me.Hide()
        frmStaffLogIn.Show()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class