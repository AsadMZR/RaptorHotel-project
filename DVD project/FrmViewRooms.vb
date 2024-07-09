Public Class FrmViewRooms
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'GO TO ROOM FORM
        Me.Hide()
        FrmRoom1.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'GOING BACK
        Me.Hide()
        FrmCustMain.Show()
    End Sub
End Class