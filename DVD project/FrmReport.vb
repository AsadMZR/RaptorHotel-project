Imports System.Data.OleDb
Imports System.Reflection.Emit
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button

Public Class FrmReport
    Private Sub FrmReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'DISPLAYING INFORMATION ABOUT BOOKING
        DisplayBook(PublicCustID)
        DisplayExtras(PublicCustID)

    End Sub

    Public Sub DisplayBook(ID As Integer)
        'DISPLAYING INFORMATION ABOUT BOOKING


        If dbConnect() Then
            Dim SQLCmd As New OleDbCommand
            With SQLCmd
                .Connection = cn
                .CommandText = "Select *  From BookingTbl Order by StartDate DESC"
                '.Parameters.AddWithValue("@SearchID", PublicCustID)
                Dim rs As OleDbDataReader = .ExecuteReader()
                While rs.Read()
                    Dim NewRow As New DataGridViewRow
                    NewRow.CreateCells(dgvCustomer)

                    NewRow.Cells(0).Value = rs("BookingID")
                    NewRow.Cells(1).Value = rs("SelectedRoomNumber")
                    NewRow.Cells(2).Value = rs("CustID")
                    NewRow.Cells(3).Value = rs("NumberOfNights")
                    NewRow.Cells(4).Value = rs("StartDate")
                    NewRow.Cells(5).Value = rs("EndDate")
                    NewRow.Cells(6).Value = rs("TotalCost")
                    dgvCustomer.Rows.Add(NewRow)

                End While
                rs.Close()
            End With
            cn.Close()
        End If
    End Sub
    Public Sub DisplayExtras(ID As Integer)
        'DISPLAYING INFORMATION ABOUT EXTRA CHOICES (PART OF BOOKING) IN ANOTHER DATA GRID VIEW


        If dbConnect() Then
            Dim SQLCmd As New OleDbCommand
            With SQLCmd
                .Connection = cn
                .CommandText = "Select *  From BookingTbl Order by EndDate DESC"
                '.Parameters.AddWithValue("@SearchID", PublicCustID)
                Dim rs As OleDbDataReader = .ExecuteReader()
                While rs.Read()
                    Dim NewRow As New DataGridViewRow
                    NewRow.CreateCells(DgvExtra)

                    NewRow.Cells(0).Value = rs("CustID")
                    NewRow.Cells(1).Value = rs("Breakfast")
                    NewRow.Cells(2).Value = rs("Lunch")
                    NewRow.Cells(3).Value = rs("Dinner")
                    NewRow.Cells(4).Value = rs("Balcony")
                    NewRow.Cells(5).Value = rs("Pets")
                    DgvExtra.Rows.Add(NewRow)

                End While
                rs.Close()
            End With
            cn.Close()
        End If
    End Sub

    Private Sub btnGOtomainmenu_Click(sender As Object, e As EventArgs) Handles btnGOtomainmenu.Click
        'GOING BACK
        Me.Hide()
        FrmCustMain.Show()
    End Sub

    Private Sub dgvCustomer_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCustomer.CellContentClick

    End Sub

    Private Sub DgvExtra_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvExtra.CellContentClick

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class