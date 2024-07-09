Imports System.Data.OleDb
Imports System.Diagnostics.Eventing.Reader

Public Class frmRoom
    Private Sub dgvCurrentOrders_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        'GOING BACK
        Me.Close()
        FrmCustMain.Show()
    End Sub

    Private Sub frmRoom_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'DISABLING CUSTOMERS TO MAKE CHANGES/ STOP CONFUSION

        cmbNoOfNights.Enabled = False
        cmbSroom.Enabled = False
        CheckBox1.Enabled = False
        CheckBox2.Enabled = False
        CheckBox3.Enabled = False
        CheckBox4.Enabled = False
        CheckBox5.Enabled = False
        dtpEnd.Enabled = False
        dtpStart.Enabled = False
        Label10.Visible = False

        Searchbooking()

    End Sub


    Private Sub Searchbooking()
        'DISPLAYS BOOKINNG NUMBER IN LIST
        If dbConnect() Then
            Dim SQLcmd As New OleDbCommand
            With SQLcmd
                .Connection = cn
                .CommandText = "Select BookingID From BookingTbl Where CustID = @SearchID "
                .Parameters.AddWithValue("@SearchID", PublicCustID)
                Dim rs As OleDbDataReader = .ExecuteReader()




                While rs.Read

                    Dim DisplayValue As String = "Booking Number " & rs("BookingID")
                    Dim CustomerItem As New ListBoxData(DisplayValue, rs("BookingID"))
                    ListBox1.Items.Add(CustomerItem)




                End While
                rs.Close()
            End With
            cn.Close()
        End If

    End Sub


    Private Sub dgvRoomBook_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub




    Private Sub Button1_Click_1(sender As Object, e As EventArgs)
    End Sub
    Private Sub DisplayNumber(CustomerID As Integer)

        ' IDSPLAY INFORMATION OF BOOKING
        If dbConnect() Then
            Dim Bookingslected As New ListBoxData("", 0)
            Bookingslected = ListBox1.SelectedItem

            Dim SQLcmd As New OleDbCommand
            With SQLcmd
                .Connection = cn
                .CommandText = "Select * From BookingTbl Where BookingID = @SearchID"
                .Parameters.AddWithValue("@SearchID", Bookingslected.identifier)
                Dim rs As OleDbDataReader = .ExecuteReader()



                If rs.Read Then
                    Label7.Text = rs("BookingID")
                    cmbSroom.Text = rs("SelectedRoomNumber")
                    cmbNoOfNights.Text = rs("NumberOfNights")
                    CheckBox1.Checked = rs("Breakfast")
                    CheckBox2.Checked = rs("Lunch")
                    CheckBox3.Checked = rs("Dinner")
                    CheckBox4.Checked = rs("Balcony")
                    CheckBox5.Checked = rs("Pets")
                    dtpStart.Value = rs("StartDate")
                    dtpEnd.Value = rs("EndDate")
                    lblTpay.Text = rs("TotalCost")

                Else
                    MsgBox("Could not find a Booking with this ID ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
                rs.Close()
            End With
            cn.Close()
        End If
    End Sub
    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        'DISPLAY BOOKING INFO WHEN BOOKING NUMBER CLICKED(IN LIST)
        If ListBox1.SelectedItem IsNot Nothing Then
            Dim SelectedCustomer As ListBoxData = ListBox1.SelectedItem
            DisplayNumber(SelectedCustomer.Identifier)
            Label9.Visible = False
            Label10.Visible = True
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'CLEAR DATA
        Label7.Text = "<automatically generated>"
        cmbSroom.SelectedItem = ""
        cmbNoOfNights.SelectedItem = ""
        CheckBox1.Checked = False
        CheckBox2.Checked = False
        CheckBox3.Checked = False
        CheckBox4.Checked = False
        CheckBox5.Checked = False
        dtpStart.Value = Now
        dtpEnd.Value = Now
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'GOING BACK
        Me.Hide()
        FrmCustMain.Show()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class