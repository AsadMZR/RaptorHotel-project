Public Class FrmMain
    Private Sub btnGotocustomer_Click(sender As Object, e As EventArgs) Handles btnGotoStaff.Click
        'GO TO CUSTOMER FORM
        Me.Hide()
        frmCustomers.Show()

    End Sub

    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'DISPLAY INFO OF STAFF
        LabelSName.Text = PublicStaffName
    End Sub

    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        'GO BACK
        frmLogIn.btnClear.PerformClick()
        Me.Hide()
        frmLogIn.Show()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnGoToCustomers.Click
        ''GO TO FORM STAFF
        Me.Close()
        FrmStaff.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonRooms.Click
        'GO TO ROOM FORM
        Me.Hide()
        FrmAddRooms.Show()
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles ButtonReports.Click
        'GO TO FORM REPORT
        Me.Close()
        FrmReport.Show()
    End Sub
End Class