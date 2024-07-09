Imports System.Data.OleDb
Imports System.IO
Imports System.Net.Http.Headers
Imports System.Security.Cryptography

Public Class FrmAddRooms


    Private publicRoomID As Integer = -1


    Dim imagePath As String


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnAddRoom.Click

        'ADDING THE ROOM
        Me.dgvAddRoom.Rows.Add(ComboBox3.SelectedItem, ComboBox1.SelectedItem, ComboBox2.SelectedItem, txtPrice.Text)
        If dbConnect() Then
            Dim SQLCmd As New OleDbCommand
            'ADDING NEW CUSTOMERS
            With SQLCmd
                .Connection = cn
                If ComboBox1.Text = "" Or ComboBox2.Text = "" Or ComboBox3.Text = "" Or txtPrice.Text = "" Then
                    MessageBox.Show("Missing information")
                End If


                .CommandText = "Insert into RoomTbl (RoomNumberID, TypeOfRoom, NumberOfPeople, PricePerNight, RoomDescription,CoffeMachine, FreeWifi, AirConditioner, DentalKit, HealthCareKit, TV, FreeWater, MiniBar, Desk, StatuesOfRoom )"
                .CommandText &= " Values (@RoomNumberID, @TypeOfRoom, @NumberOfPeople, @PricePerNight, @RoomDescription, @CoffeMachine, @FreeWifi, @AirConditioner, @DentalKit, @HealthCareKit, @TV, FreeWater, @MiniBar, @Desk, @StatuesOfRoom)"
                .Parameters.AddWithValue("@RoomNumberID", ComboBox3.SelectedItem)
                .Parameters.AddWithValue("@TypeOfRoom", ComboBox1.SelectedItem)
                .Parameters.AddWithValue("@NumberOfPeople", ComboBox2.SelectedItem)
                .Parameters.AddWithValue("@PricePerNight", txtPrice.Text)
                .Parameters.AddWithValue("RoomDescription", rtbROOM.Text)
                .Parameters.AddWithValue("CoffeMachine", CheckCoffe.Checked)
                .Parameters.AddWithValue("FreeWifi", CheckWifi.Checked)
                .Parameters.AddWithValue("AirConditioner", CheckAC.Checked)
                .Parameters.AddWithValue("DentalKit", CheckDental.Checked)
                .Parameters.AddWithValue("HealthCareKit", CheckHealth.Checked)
                .Parameters.AddWithValue("TV", CheckTV.Checked)
                .Parameters.AddWithValue("FreeWater", CheckWater.Checked)
                .Parameters.AddWithValue("MiniBar", CheckBar.Checked)
                .Parameters.AddWithValue("Desk", CheckDesk.Checked)
                .Parameters.AddWithValue("StatuesOfRoom", CheckAvailability.Checked)




                .ExecuteNonQuery()
                MessageBox.Show("Succesfully created a room")



            End With
            cn.Close()
        End If


    End Sub

    Private Sub FrmAddRooms_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'SHOWING THE DATA IN THE ROWS
        If dbConnect() Then
            Dim SQLCmd As New OleDbCommand
            With SQLCmd
                .Connection = cn
                .CommandText = "Select *" &
                    "From RoomTbl"

                .Parameters.Clear()
                Dim rs As OleDbDataReader = .ExecuteReader()
                While rs.Read
                    Dim NewDataGridRow As New DataGridViewRow()
                    NewDataGridRow.CreateCells(dgvAddRoom)
                    NewDataGridRow.SetValues({rs("RoomNumberID"), rs("TypeOfRoom"), rs("NumberOfPeople"), rs("PricePerNight")})
                    dgvAddRoom.Rows.Add(NewDataGridRow)
                End While
            End With
        End If
    End Sub

    Private Sub Displaycheck()

        'DISPLAYING SOME DATA WHEN OF ROOM WHEN SELECTED
        If dbConnect() Then

            Dim Bookingslected As Integer
            Bookingslected = ComboBox3.SelectedItem

            Dim SQLcmd As New OleDbCommand
            With SQLcmd
                .Connection = cn
                .CommandText = "Select * From RoomTbl Where RoomNumberID = @SearchID"
                .Parameters.AddWithValue("@SearchID", Bookingslected)
                Dim rs As OleDbDataReader = .ExecuteReader()

            End With

            '
        Else
            MsgBox("Could not find a room with this ID ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If


        cn.Close()

    End Sub

    Private Sub roomdescription()
        'DISPLAYING MOST DATA WHEN A ROOM IS SELECTED
        Dim description As String
        If dbConnect() Then
            Dim SQLCmd As New OleDbCommand
            With SQLCmd
                .Connection = cn
                .CommandText = "Select * " &
                    "From RoomTbl " &
                "Where RoomNumberID = @RoomNum"

                .Parameters.Clear()
                .Parameters.AddWithValue("@RoomNum", ComboBox3.SelectedItem)
                Dim rs As OleDbDataReader = .ExecuteReader()
                If rs.Read Then
                    rtbROOM.Text = rs("RoomDescription")
                    CheckAvailability.Checked = rs("StatuesOfRoom")
                    ComboBox1.Text = rs("TypeOfRoom")
                    ComboBox2.Text = rs("NumberOfPeople")
                    txtPrice.Text = rs("PricePerNight")

                    If rs("CoffeMachine") = True Then
                        CheckCoffe.Checked = True
                    Else
                        CheckCoffe.Checked = False
                    End If
                    If rs("FreeWifi") = True Then
                        CheckWifi.Checked = True
                    Else
                        CheckWifi.Checked = False

                    End If
                    If rs("AirConditioner") = True Then
                        CheckAC.Checked = True
                    Else
                        CheckAC.Checked = False
                    End If
                    If rs("DentalKit") = True Then
                        CheckDental.Checked = True
                    Else
                        CheckDental.Checked = False
                    End If
                    If rs("HealthCareKit") = True Then
                        CheckHealth.Checked = True
                    Else
                        CheckHealth.Checked = False
                    End If
                    If rs("TV") = True Then


                        CheckTV.Checked = True
                    Else
                        CheckTV.Checked = False
                    End If
                    If rs("FreeWater") = True Then
                        CheckWater.Checked = True
                    Else
                        CheckWater.Checked = False
                    End If
                    If rs("MiniBar") = True Then
                        CheckBar.Checked = True
                    Else
                        CheckBar.Checked = False
                    End If
                    If rs("Desk") = True Then
                        CheckDesk.Checked = True
                    Else
                        CheckDesk.Checked = False
                    End If
                End If





            End With
        End If
    End Sub




    Private Sub dgvAddRoom_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAddRoom.CellContentClick


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        If dbConnect() Then
            Dim SQLCmd As New OleDbCommand
            'EDITING EXISTING CUSTOMER DATA
            With SQLCmd
                .Parameters.Clear()
                .Connection = cn
                .CommandText = "Update RoomTbl Set TypeOfRoom = @Column1, NumberOfPeople = @Column2, PricePerNight = @Column3, RoomDescription = @roomdesc, CoffeMachine = @Coffe, FreeWifi = @Wifi, AirConditioner = @AC, DentalKit = @Dental, HealthCareKit = @Health, TV = @TV, FreeWater = @Water, MiniBar = @Bar, Desk = @Desk, StatuesOfRoom = @SRoom Where RoomNumberID = @SearchID"

                .Parameters.AddWithValue("@Column1", ComboBox1.SelectedItem)
                .Parameters.AddWithValue("@Column2", ComboBox2.SelectedItem.ToString)
                .Parameters.AddWithValue("@Column3", txtPrice.Text)
                .Parameters.AddWithValue("@roomdesc", rtbROOM.Text)
                .Parameters.AddWithValue("@Coffe", CheckCoffe.Checked)
                .Parameters.AddWithValue("@Wifi", CheckWifi.Checked)
                .Parameters.AddWithValue("@AC", CheckAC.Checked)
                .Parameters.AddWithValue("@Dental", CheckTV.Checked)
                .Parameters.AddWithValue("@Health", CheckDental.Checked)
                .Parameters.AddWithValue("@Water", CheckHealth.Checked)
                .Parameters.AddWithValue("@TV", CheckWater.Checked)
                .Parameters.AddWithValue("@Bar", CheckBar.Checked)
                .Parameters.AddWithValue("@Desk", CheckDesk.Checked)
                .Parameters.AddWithValue("SRoom", CheckAvailability.Checked)
                .Parameters.AddWithValue("@SearchID", ComboBox3.SelectedItem)
                MessageBox.Show("Sucesfully updated the room")

                .ExecuteNonQuery()
            End With
        Else MessageBox.Show("")
        End If
        cn.Close()
    End Sub

    Private Sub dgvAddRoom_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAddRoom.CellClick
        'MAKING INDEX TO SELECT AND DISPLAY SOME INFORMATION
        Dim index As Integer
        index = e.RowIndex


        Dim selectedrow As DataGridViewRow
        selectedrow = dgvAddRoom.Rows(index)
        ComboBox3.SelectedItem = selectedrow.Cells(0).Value.ToString()
        ComboBox1.SelectedItem = selectedrow.Cells(1).Value.ToString()
        ComboBox2.SelectedItem = selectedrow.Cells(2).Value.ToString()
        txtPrice.Text = selectedrow.Cells(3).Value.ToString()
        Displaycheck()


    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click


        'DELETING ROOM


        If vbYes Then
            If dbConnect() Then
                Dim SQLCmd As New OleDbCommand
                With SQLCmd
                    .Connection = cn
                    .CommandText = "Delete From RoomTbl Where RoomNumberID = @RoomID"
                    .Parameters.AddWithValue("@RoomID", ComboBox3.SelectedItem)
                    .ExecuteNonQuery()
                    butClear.PerformClick()
                    dgvAddRoom.Rows.RemoveAt(dgvAddRoom.SelectedRows(0).Index)
                End With
                cn.Close()
                butClear.PerformClick()
            End If

        End If




    End Sub

    Private Sub btnGOtomainmenu_Click(sender As Object, e As EventArgs) Handles btnGOtomainmenu.Click 'GOING BACK TO MAIN MENU
        Me.Hide()
        FrmMain.Show()
    End Sub

    Private uploadimage As String = ""
    Private uploaditem As String = ""


    Private Sub UploadimageToDatabase(ImagePath As String, itemID As String)
        'add picture
        If dbConnect() Then
            Dim SQLCmd As New OleDbCommand
            Try
                Dim base64Image As String = ImageToDatabase(ImagePath)
                With SQLCmd
                    .Connection = cn
                    .CommandText = "UPDATE RoomTbl SET RoomPicture = @RoomPicture Where RoomNumberID = @RoomNumberID"
                    .Parameters.AddWithValue("@RoomPicture", base64Image)
                    .Parameters.AddWithValue("@RoomNumberID", ComboBox3.SelectedItem)

                End With

                Dim rowsaffected As Integer = SQLCmd.ExecuteNonQuery()

                MessageBox.Show("images added to database: " & rowsaffected)

                If rowsaffected > 0 Then
                    MessageBox.Show("successfully uploaded image")
                Else
                    MessageBox.Show("Please try again")
                End If
            Catch ex As Exception
                MessageBox.Show("Error uploading image: " & ex.Message)
            Finally
                If cn.State = ConnectionState.Open Then
                    cn.Close()
                End If
            End Try
        End If
    End Sub

    Private Function ImageToDatabase(imagePath As String) As String
        'STORING TO DATABSE
        Try
            Dim imageBytes As Byte() = File.ReadAllBytes(imagePath)
            Return Convert.ToBase64String(imageBytes)
        Catch ex As Exception
            MessageBox.Show("Failed to convert image to base64: " & ex.Message)
            Return String.Empty
        End Try
    End Function
    Private Sub DisplayImageFromDatabase(displaylocaion As PictureBox, ItemID As String)
        'DISPLAY IMAGE FROM DATABASE
        If dbConnect() Then
            Dim sqlCmd As New OleDbCommand
            Try
                With sqlCmd
                    .Connection = cn
                    .CommandText = "SELECT RoomPicture FROM RoomTbl WHERE RoomNumberID = @RoomNumberID"
                    .Parameters.AddWithValue("@RoomNumberID", ComboBox3.SelectedItem)
                    Dim base64Image As String = .ExecuteScalar().ToString()
                    If Not String.IsNullOrEmpty(base64Image) Then
                        Dim imagebytes As Byte() = Convert.FromBase64String(base64Image)
                        Using ms As New MemoryStream(imagebytes)
                            displaylocaion.Image = Image.FromStream(ms)
                        End Using
                    End If
                End With
            Catch ex As Exception
                MessageBox.Show("error loading image:" & ex.Message)


            End Try
        End If
    End Sub
    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged
        'DISPLAY ALL INFORMATION WHEN ROOM IS SELECTED
        roomdescription()
        If ComboBox1.SelectedItem IsNot Nothing Then
            Dim SelectedCustomer As Integer = ComboBox3.SelectedItem
            'Displaycheck(SelectedCustomer)
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        'DISPLAY IMAGE
        Dim openFileDialog As New OpenFileDialog()
        ' openFileDialog.Filter = "Image Files|.jpg;.jpeg;.png;.bmp"

        If openFileDialog.ShowDialog() = DialogResult.OK Then
            Dim selectedimagepath As String = openFileDialog.FileName
            UploadimageToDatabase(selectedimagepath, CheckWifi.Text)
        End If
    End Sub

    Private Sub butClear_Click(sender As Object, e As EventArgs) Handles butClear.Click
        'CLEAR DATA
        CheckAvailability.Checked = False
        ComboBox1.Text = ""
        ComboBox2.Text = ""
        ComboBox3.Text = ""
        txtPrice.Text = ""
        CheckAC.Checked = False
        CheckBar.Checked = False
        CheckCoffe.Checked = False
        CheckDental.Checked = False
        CheckDesk.Checked = False
        CheckHealth.Checked = False
        CheckTV.Checked = False
        CheckWater.Checked = False
        CheckWifi.Checked = False
        rtbROOM.Text = ""


    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub
End Class