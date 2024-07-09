Imports System.Data.OleDb
Imports System.Diagnostics.Eventing.Reader

Public Class FrmBooking

    Private CurrentBookingID As Integer = -1
    Private Sub FrmBooking_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Display data in data grid
        If dbConnect() Then
            Dim SQLCmd As New OleDbCommand
            With SQLCmd
                .Connection = cn
                .CommandText = "Select RoomNumberID, TypeOfRoom, NumberOfPeople, PricePerNight, StatuesOfRoom " &
                    "From RoomTbl " &
                    "Where StatuesOfRoom = True"

                .Parameters.Clear()

                Dim rs As OleDbDataReader = .ExecuteReader()
                While rs.Read
                    Dim NewDataGridRow As New DataGridViewRow()
                    NewDataGridRow.CreateCells(dgvRoomBook)
                    NewDataGridRow.SetValues({rs("RoomNumberID"), rs("TypeOfRoom"), rs("NumberOfPeople"), rs("PricePerNight")})

                    dgvRoomBook.Rows.Add(NewDataGridRow)

                End While



            End With
        End If
        cn.Close()

        Button1.Visible = False
        Button2.Visible = False
        Panel1.Visible = False
        Label2.Visible = False
        Label6.Visible = False
        lblSroom.Visible = False
        cmbSroom.Visible = False
        cmbNoOfNights.Visible = False
        Label7.Visible = False
        Label4.Visible = False
        Label9.Visible = False
        lblTpay.Visible = False
        Label3.Visible = False
        Label10.Visible = False
        Label11.Visible = False
        Label8.Visible = False
        CheckBox1.Visible = False
        CheckBox2.Visible = False
        CheckBox3.Visible = False
        CheckBox4.Visible = False
        CheckBox5.Visible = False
        Label13.Visible = False
        Label14.Visible = False

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'ADDDING THE BOOKING TO DATA BASE
        CurrentBookingID = -1
        Label7.Text = "<automatically generated>"
        If dbConnect() Then
            If cmbNoOfNights.SelectedItem = "" Or cmbSroom.SelectedItem = Nothing Then
                MsgBox("Please enter in a valid room number or number of nights To make a Booking")
            Else
                Dim SQLCmd As New OleDbCommand
                If CurrentBookingID = -1 Then
                    'ADDING NEW BOOKING
                    With SQLCmd
                        .Connection = cn
                        .CommandText = "Insert into BookingTbl (SelectedRoomNumber, CustID, StartDate," &
                                       "EndDate, NumberOfNights, TotalCost, Breakfast, Lunch, Dinner, Balcony, Pets)"
                        .CommandText &= " Values (@SelectedRoomNumber, @CustID, @StartDate, " &
                                        "@EndDate, @NumberOfNights, @TotalCost, @Breakfast, @Lunch, @Dinner, @Balcony, @Pets)"
                        .Parameters.AddWithValue("@SelectedRoomNumber", cmbSroom.SelectedItem)
                        .Parameters.AddWithValue("@CustID", PublicCustID)
                        .Parameters.AddWithValue("@StartDate", dtpStart.Value.Date)
                        .Parameters.AddWithValue("@EndDate", dtpEnd.Value.Date)
                        .Parameters.AddWithValue("@NumberOfNights", cmbNoOfNights.SelectedItem)
                        .Parameters.AddWithValue("@TotalCost", lblTpay.Text)
                        .Parameters.AddWithValue("@Breakfast", CheckBox1.Checked)
                        .Parameters.AddWithValue("@Lunch", CheckBox2.Checked)
                        .Parameters.AddWithValue("@Dinner", CheckBox3.Checked)
                        .Parameters.AddWithValue("@Balcony", CheckBox4.Checked)
                        .Parameters.AddWithValue("@Pets", CheckBox5.Checked)
                        .ExecuteNonQuery()

                        'auto generate ID
                        .CommandText = "Select @@Identity"
                        CurrentBookingID = .ExecuteScalar
                        Label7.Text = CurrentBookingID
                        MessageBox.Show("Succesfully created your booking")


                        .ExecuteNonQuery()
                    End With
                    cn.Close()
                End If
            End If
        End If
        cn.Close()

    End Sub













    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs)

    End Sub
    Public Sub DisplayPrice()
        'ADDING EXTRA CHOICES
        Dim SUM As Integer
        If CheckBox1.Checked Then
            SUM = SUM + 12
        Else
            SUM = SUM + 0
        End If
        If CheckBox2.Checked Then
            SUM = SUM + 15
        Else
            SUM = SUM + 0
        End If
        If CheckBox3.Checked Then
            SUM = SUM + 15
        Else
            SUM = SUM + 0
        End If
        If CheckBox4.Checked Then
            SUM = SUM + 10
        Else
            SUM = SUM + 0
        End If
        If CheckBox5.Checked Then
            SUM = SUM + 12
        Else
            SUM = SUM + 0
        End If
        Label8.Text = SUM.ToString

        If dbConnect() Then
            Dim SQLCmd As New OleDbCommand
            With SQLCmd
                .Connection = cn
                .CommandText = "Select PricePerNight  From RoomTbl Where StatuesOfRoom = True and RoomNumberID = @Room "
                .Parameters.AddWithValue("@Room", cmbSroom.Text)
                Dim rs As OleDbDataReader = .ExecuteReader()
                While rs.Read()
                    lblTpay.Text = rs("PricePerNight") + Val(Label8.Text)

                End While
                rs.Close()
            End With
            cn.Close()
        End If

    End Sub

    Private Sub dgvRoomBook_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'GOING BACK
        Me.Close()
        FrmCustMain.Show()
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles BtnCheck.Click
        dgvRoomBook.Rows.Clear()
        'COLLISION OBJECTIVE
        Dim BookedRooms(10) As Integer
        If dbConnect() Then




            Dim Datagridview As New DataGridViewRow()
            Dim SQLCmd As New OleDbCommand
            With SQLCmd
                .Connection = cn


                .CommandText = "Select * from RoomTbl where StatuesOfRoom = True and RoomNumberID NOT IN " &
                 "(" &
                 "Select RoomNumberID From BookingTbl, RoomTbl " &
                 "Where " &
                 "RoomTbl.RoomNumberID = BookingTbl.SelectedRoomNumber AND " &
                 "((StartDate >= @StartDate and StartDate <= @EndDate) or " &
                  "(EndDate >= @StartDate and EndDate <= @EndDate))" &
                 ")"

                .Parameters.Clear()
                .Parameters.AddWithValue("@StartDate", dtpStart.Value.Date)
                .Parameters.AddWithValue("@EndDate", dtpEnd.Value.Date)
                Dim rs As OleDbDataReader = .ExecuteReader()

                cmbSroom.Items.Clear()
                While rs.Read
                    Dim NewDataGridRow As New DataGridViewRow()
                    NewDataGridRow.CreateCells(dgvRoomBook)
                    NewDataGridRow.SetValues({rs("RoomNumberID"), rs("TypeOfRoom"), rs("NumberOfPeople"), rs("PricePerNight")})

                    dgvRoomBook.Rows.Add(NewDataGridRow)
                    cmbSroom.Items.Add(rs("RoomNumberID"))
                End While

            End With
        End If







        cn.Close()

        Button1.Visible = True
        Button2.Visible = True

        Label2.Visible = True
        Label6.Visible = True
        lblSroom.Visible = True
        cmbSroom.Visible = True
        cmbNoOfNights.Visible = True
        Label7.Visible = True
        Label4.Visible = True
        Label9.Visible = True
        lblTpay.Visible = True
        Label12.Visible = False
        Label13.Visible = True



    End Sub



    Private Sub cmbSroom_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSroom.SelectedIndexChanged

        'ADDING COST WHEN ROOM IS SELECTED
        If dbConnect() Then
            Dim SQLCmd As New OleDbCommand
            With SQLCmd
                .Connection = cn
                .CommandText = "Select PricePerNight  From RoomTbl Where StatuesOfRoom = True and RoomNumberID = @Room"
                .Parameters.AddWithValue("@Room", cmbSroom.Text)
                Dim rs As OleDbDataReader = .ExecuteReader()
                While rs.Read()
                    lblTpay.Text = rs("PricePerNight") + Val(Label8.Text)

                End While
                rs.Close()
            End With
            cn.Close()
        End If

        Panel1.Visible = True
        Label3.Visible = True
        Label10.Visible = True
        Label11.Visible = True
        Label8.Visible = True
        CheckBox1.Visible = True
        CheckBox2.Visible = True
        CheckBox3.Visible = True
        CheckBox4.Visible = True
        CheckBox5.Visible = True
        Label13.Visible = False
        Label14.Visible = True

    End Sub

    Private Sub lblTpay_Click(sender As Object, e As EventArgs) Handles lblTpay.Click


    End Sub

    Private Sub dgvRoomBook_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles dgvRoomBook.CellContentClick

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        DisplayPrice()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        DisplayPrice()
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        DisplayPrice()
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        DisplayPrice()
    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged
        DisplayPrice()
    End Sub

    Private Sub CheckBox5_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox5.CheckedChanged
        DisplayPrice()
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label8_Click_1(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub dtpEnd_ValueChanged(sender As Object, e As EventArgs) Handles dtpEnd.ValueChanged

    End Sub
End Class