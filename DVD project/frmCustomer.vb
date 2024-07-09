Imports System.Data.OleDb

Public Class frmCustomers

    Private CurrentCustomerID As Integer = -1
    Private Sub FrmStaff_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'DISPLAYING DATA
        Label16.Text = PublicStaffName
        btnClearSearch.PerformClick()
        btnCustNew.PerformClick()
    End Sub



    Private Sub DisplayCustomer(customerID As Integer)
        'DISLAYING CUSTOMER INFO
        If dbConnect() Then
            Dim SQLcmd As New OleDbCommand
            With SQLcmd
                .Connection = cn
                .CommandText = "Select * From CustomerTbl Where CustID = @SearchID"
                .Parameters.AddWithValue("@SearchID", customerID)
                Dim rs As OleDbDataReader = .ExecuteReader()



                If rs.Read Then
                    CurrentCustomerID = customerID
                    lblCustID.Text = rs("CustID")
                    txtSurname.Text = rs("CSName")
                    txtFirstName.Text = rs("CFName")
                    txtEmail.Text = rs("CEmail")
                    DatBOD.Value = rs("CDOB")
                    txtTelNo.Text = rs("CTel").ToString
                    txtUsername.Text = rs("CUsername")
                    txtPassword.Text = rs("CPassword")

                    btnDeleteCust.Enabled = True

                Else
                    MessageBox.Show("Could not find a Customer with ID " & customerID, "Find Customer", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
                rs.Close()
            End With
            cn.Close()
        End If

    End Sub



    Private Sub btnCustNew_Click(sender As Object, e As EventArgs) Handles btnCustNew.Click
        'CLEARING DATA
        CurrentCustomerID = -1
        lblCustID.Text = "<automatically generated>"
        txtSurname.Text = ""
        txtFirstName.Text = ""
        txtEmail.Text = ""
        DatBOD.Value = Now.AddYears(-18)
        txtTelNo.Text = ""
        btnDeleteCust.Enabled = False
        txtUsername.Text = ""
        txtPassword.Text = ""

    End Sub

    Private Sub btnSaveCust_Click(sender As Object, e As EventArgs) Handles btnSaveCust.Click
        'VALIDATION
        If dbConnect() Then
            If txtPassword.Text = "" Or txtUsername.Text = "" Or txtEmail.Text = "" Or txtFirstName.Text = "" Or txtSurname.Text = "" Or txtTelNo.Text = "" Then
                MsgBox("Missing Information")
            ElseIf txtPassword.Text.Length >= 50 Or txtUsername.Text.Length >= 50 Or txtEmail.Text.Length >= 50 Or txtFirstName.Text.Length >= 50 Or txtSurname.Text.Length >= 50 Or txtTelNo.Text.Length <> 10 Then
                MsgBox("Please, double check your details as they exeed the charecter/digit limmit")
            ElseIf DatBOD.Value > Now.AddYears(-18) Then
                MessageBox.Show("Sorry, you must be atleast 18 years old to use out service")

            Else
                Dim SQLCmd As New OleDbCommand
                If CurrentCustomerID = -1 Then
                    'ADDING NEW CUSTOMERS
                    With SQLCmd
                        .Connection = cn
                        .CommandText = "Insert into CustomerTbl (CFName, CSName, CEmail, CDOB, CTel, CUsername, CPassword)"
                        .CommandText &= " Values (@FirstName, @Surname, @Email, @DOB, @TelNo, @Username, @Password)"
                        .Parameters.AddWithValue("@FirstName", txtFirstName.Text)
                        .Parameters.AddWithValue("@Surname", txtSurname.Text)
                        .Parameters.AddWithValue("@Email", txtEmail.Text)
                        .Parameters.AddWithValue("@DOB", DatBOD.Value.Date)
                        .Parameters.AddWithValue("@TelNo", txtTelNo.Text)
                        .Parameters.AddWithValue("@Username", txtUsername.Text)
                        .Parameters.AddWithValue("@Password", txtPassword.Text)

                        .ExecuteNonQuery()


                        'auto generate ID
                        .CommandText = "Select @@Identity"
                        CurrentCustomerID = .ExecuteScalar
                        lblCustID.Text = CurrentCustomerID
                        MessageBox.Show("Succesfully created an account")
                    End With
                Else
                    'EDITING EXISTING CUSTOMER DATA
                    With SQLCmd
                        .Connection = cn
                        .CommandText = "Update CustomerTbl Set CFName = @FirstName, CSName = @Surname, CEmail = @Email,"
                        .CommandText &= "CDOB = @DOB, CTel = @TelNo, CUsername = @Username, CPassword = @Password where CustID = @CurrentCustomerID"
                        .Parameters.AddWithValue("@FirstName", txtFirstName.Text)
                        .Parameters.AddWithValue("@Surname", txtSurname.Text)
                        .Parameters.AddWithValue("@Email", txtEmail.Text)
                        .Parameters.AddWithValue("@DOB", DatBOD.Value)
                        .Parameters.AddWithValue("@TelNo", txtTelNo.Text)
                        .Parameters.AddWithValue("@Username", txtUsername.Text)
                        .Parameters.AddWithValue("@Password", txtPassword.Text)
                        .Parameters.AddWithValue("@CurrentCustomerID", CurrentCustomerID)
                        .ExecuteNonQuery()
                        MessageBox.Show("Succesfully updated the customers details")
                    End With
                End If
                cn.Close()
            End If
        End If

    End Sub

    Private Sub btnDeleteCust_Click(sender As Object, e As EventArgs) Handles btnDeleteCust.Click
        'DELETING CUSTOMER DATA
        Dim Confirmation As Boolean
        Confirmation = MsgBox("Do you want to delete", vbYesNo)


        If vbYes Then
            If dbConnect() Then
                Dim SQLCmd As New OleDbCommand
                With SQLCmd
                    .Connection = cn
                    .CommandText = "Delete From BookingTbl Where CustID = @CustID"
                    .Parameters.AddWithValue("@CustID", CurrentCustomerID)
                    .ExecuteNonQuery()
                    btnClearSearch.PerformClick()
                End With
                cn.Close()
                btnClearSearch.PerformClick()
            End If
            If dbConnect() Then
                Dim SQLCmd As New OleDbCommand
                With SQLCmd
                    .Connection = cn
                    .CommandText = "Delete From CustomerTbl Where CustID = @CustID"
                    .Parameters.AddWithValue("@CustID", CurrentCustomerID)
                    .ExecuteNonQuery()
                    btnClearSearch.PerformClick()
                End With
                cn.Close()
                btnClearSearch.PerformClick()
            End If
        End If


    End Sub

    Private Sub btnGOtomainmenu_Click(sender As Object, e As EventArgs) Handles btnGOtomainmenu.Click
        'GOING BACK
        Me.Hide()
        FrmMain.Show()

    End Sub



    Private Sub dgvCurrentOrders_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCurrentOrders.CellContentClick

    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'DISPLAY BOOKING INFORMATION
        DisplayBookings()
    End Sub
    Public Sub DisplayBookings()

        'DISPLAYING CUSTOMER / BOOKING INFO

        If dbConnect() Then
            Dim SQLCmd As New OleDbCommand
            With SQLCmd
                .Connection = cn
                .CommandText = "Select *  From BookingTbl Where CustID = @SearchID Order by EndDate DESC"
                .Parameters.AddWithValue("@SearchID", lblCustID.Text)
                Dim rs As OleDbDataReader = .ExecuteReader()
                While rs.Read()
                    Dim NewRow As New DataGridViewRow
                    NewRow.CreateCells(dgvCurrentOrders)
                    NewRow.Cells(0).Value = rs("SelectedRoomNumber")
                    NewRow.Cells(1).Value = rs("BookingID")
                    NewRow.Cells(2).Value = rs("StartDate")
                    NewRow.Cells(3).Value = rs("EndDate")
                    NewRow.Cells(4).Value = rs("TotalCost")
                    dgvCurrentOrders.Rows.Add(NewRow)

                End While
                rs.Close()
            End With
            cn.Close()
        End If
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub txtCustID_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub DatBOD_ValueChanged(sender As Object, e As EventArgs) Handles DatBOD.ValueChanged

    End Sub

    Private Sub PanSearchList_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub BtnSearch_Click_1(sender As Object, e As EventArgs) Handles BtnSearch.Click
        If IsNumeric(txtIDSearch.Text) Then

            'FIND CUSTOMER BY ID
            DisplayCustomer(txtIDSearch.Text)
        ElseIf txtSurnameSearch.Text.Length > 0 Then
            'FIND ANY MATCHING STUDENT BY SURNAME AND DISPLAY IN LIST
            If dbConnect() Then
                lstCustomers.Items.Clear()
                Dim SQLCmd As New OleDbCommand
                With SQLCmd
                    .Connection = cn
                    .CommandText = "Select * From CustomerTbl Where CSName Like @SurnameSearch"
                    .Parameters.AddWithValue("@SurnameSearch", "%" & txtSurnameSearch.Text & "%")
                    Dim rs As OleDbDataReader = .ExecuteReader()

                    While rs.Read
                        Dim DisplayValue As String = rs("CFName") & " " & rs("CSName") & "(" & rs("CDOB") & ")"
                        Dim CustomerItem As New ListBoxData(DisplayValue, rs("CustID"))
                        lstCustomers.Items.Add(CustomerItem)
                    End While
                    rs.Close()
                    If lstCustomers.Items.Count = 1 Then
                        'Auto select if theres only 1 name
                        PanSearchList.Visible = False
                        lstCustomers.SelectedIndex = 0
                    ElseIf lstCustomers.Items.Count > 1 Then
                        'Show list
                        PanSearchList.Visible = True
                    Else
                        PanSearchList.Visible = False
                        MessageBox.Show("There are no customers with that surname", "Find Customer", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    End If
                End With
                cn.Close()
            End If

        End If
    End Sub

    Private Sub lstCustomers_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles lstCustomers.SelectedIndexChanged
        'SELECTING DATA FROM LISTBOX
        If lstCustomers.SelectedItem IsNot Nothing Then
            Dim SelectedCustomer As ListBoxData = lstCustomers.SelectedItem
            DisplayCustomer(SelectedCustomer.Identifier)
        End If
    End Sub

    Private Sub btnClearSearch_Click(sender As Object, e As EventArgs) Handles btnClearSearch.Click
        'CLEAR DATA
        txtIDSearch.Text = ""
        txtSurnameSearch.Text = ""
        txtIDSearch.Focus()
        Panel1.Visible = True
    End Sub

    Private Sub PanSearchList_Paint_1(sender As Object, e As PaintEventArgs) Handles PanSearchList.Paint

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub txtIDSearch_TextChanged(sender As Object, e As EventArgs) Handles txtIDSearch.TextChanged

    End Sub
End Class
