Imports System.Data.OleDb
Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button

Public Class FrmRoom1

    Private Sub Label2_Click(sender As Object, e As EventArgs)
    End Sub






    Private Sub FrmRoom110_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'SHOWS ROOM NUMBER IN LISTBOX
        Searchbooking()


    End Sub
    Private Sub DisplayNumber(CustomerID As Integer)

        'DISPLAY INFORMATION ABOUT ROOM
        If dbConnect() Then
            Dim Bookingslected As New ListBoxData("", 0)
            Bookingslected = ListBox1.SelectedItem

            Dim SQLcmd As New OleDbCommand
            With SQLcmd
                .Connection = cn
                .CommandText = "Select * From RoomTbl"
                .Parameters.Clear()

                Dim rs As OleDbDataReader = .ExecuteReader()



                If rs.Read Then
                    lblRoom.Text = rs("RoomNumberID")
                    LblDescription.Text = rs("RoomDescription")


                Else
                    MsgBox("Could not find a Booking with this ID ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
                rs.Close()
            End With
            cn.Close()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Searchbooking()
        'DISPLAY ROOM NUMBER IN LIST
        If dbConnect() Then
            Dim SQLcmd As New OleDbCommand
            With SQLcmd
                .Connection = cn
                .CommandText = "Select RoomNumberID From RoomTbl  "
                .Parameters.Clear()

                Dim rs As OleDbDataReader = .ExecuteReader()




                While rs.Read

                    Dim DisplayValue As String = "Room Number " & rs("RoomNumberID")
                    Dim CustomerItem As New ListBoxData(DisplayValue, rs("RoomNumberID"))
                    ListBox1.Items.Add(CustomerItem)





                End While
                rs.Close()
            End With
            cn.Close()
        End If

    End Sub
    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        'DISPLAYING ROOM INFORMATION

        If ListBox1.SelectedItem IsNot Nothing Then
            Dim selectedRow As ListBoxData = ListBox1.SelectedItem
            Dim room As Integer = selectedRow.Identifier
            DisplayImageFromDatabase(PictureBox2, room)

            If dbConnect() Then
                Dim SQLcmd As New OleDbCommand
                With SQLcmd
                    .Connection = cn
                    .CommandText = "Select * From RoomTbl Where RoomNumberID = @RoomNumberID"
                    .Parameters.Clear()
                    .Parameters.AddWithValue("@RoomNumberID", room)
                    Dim rs As OleDbDataReader = .ExecuteReader()



                    If rs.Read Then
                        lblRoom.Text = rs("RoomNumberID")
                        LblDescription.Text = rs("RoomDescription")
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
                    DisplayImageFromDatabase(PictureBox2, room)
                    rs.Close()
                End With
                cn.Close()
            End If
        End If


    End Sub


    Private Sub DisplayImageFromDatabase(dislaylocaion As PictureBox, RoomID As Integer)
        'DISPLAYING IMAGE FROM DATABBASE
        If dbConnect() Then
            Dim sqlCmd As New OleDbCommand
            Try
                With sqlCmd
                    .Connection = cn
                    .CommandText = "SELECT RoomPicture FROM RoomTbl WHERE RoomNumberID = @RoomNumberID"
                    .Parameters.AddWithValue("@RoomNumberID", RoomID)
                    Dim base64Image As String = .ExecuteScalar().ToString()
                    If Not String.IsNullOrEmpty(base64Image) Then

                        Dim imagebytes As Byte() = Convert.FromBase64String(base64Image)
                        Using ms As New MemoryStream(imagebytes)
                            dislaylocaion.Image = Image.FromStream(ms)
                        End Using
                    End If
                End With
            Catch ex As Exception
                MessageBox.Show("error loading image:" & ex.Message)


            End Try
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub LblDescription_Click(sender As Object, e As EventArgs) Handles LblDescription.Click

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox2_Click_1(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        'GOING BACK
        Me.Hide()
        FrmCustMain.Show()
    End Sub
End Class