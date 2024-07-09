
Imports System.Data.OleDb
Public Class FrmCustMain
    Private Sub FrmCustMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'LABELS
        LabelName.Text = publicCustName

        LabelID.Text = PublicCustID



    End Sub




    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonReservations.Click
        'BOOKING ROOM
        Me.Hide()
        FrmBooking.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles ButtonBookings.Click
        'VALIDATING
        Dim ID As Integer
        ID = InputBox("Please, Enter your ID")
        If ID = PublicCustID Then
            frmRoom.Show()
            Me.Close()
        Else
            MsgBox("Please enter your own ID")
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles ButtonRooms.Click
        ' VIEW ROOM
        FrmViewRooms.Show()
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles LabelID.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles LabelName.Click

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles ButtonEditInfo.Click
        'VALIDATION
        Dim password As String
        password = InputBox("Please, Enter your ID")
        If password = PublicCustID Then
            FrmEditInfo.Show()
            Me.Close()
        Else
            MsgBox("Please enter your own ID")
        End If

    End Sub

    Private Sub BtnLogOut_Click(sender As Object, e As EventArgs) Handles BtnLogOut.Click
        'GOING BACK
        Me.Hide()
        frmLogIn.Show()

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class