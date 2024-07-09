Imports System.Data.OleDb

Public Class FrmStaff

    Private CurrentStaffID As Integer = -1 'MAKE NEW UNIQUE ID FOR EACH STAFF MEMBER
    Private Sub FrmStaff_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'DISPLAY STAFF INFORMATION
        Label16.Text = PublicStaffName
        btnClearSearch.PerformClick()
        btnCustNew.PerformClick()
    End Sub

    Private Sub btnClearSearch_Click(sender As Object, e As EventArgs) Handles btnClearSearch.Click '
        'CLEAR DATA
        txtIDSearch.Text = ""
        txtIDSearch.Focus()
        PanSearchList.Visible = False
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
                If CurrentStaffID = -1 Then
                    'ADDING NEW CUSTOMERS
                    With SQLCmd
                        .Connection = cn
                        .CommandText = "Insert into StaffTbl (SFName, SSName, SEmail, SDOB, STel, SUsername, SPassword)"
                        .CommandText &= " Values (@FirstName, @Surname, @Email, @DOB, @TelNo, @Username, @Password)"
                        .Parameters.AddWithValue("@FirstName", txtFirstName.Text)
                        .Parameters.AddWithValue("@Surname", txtSurname.Text)
                        .Parameters.AddWithValue("@Email", txtEmail.Text)
                        .Parameters.AddWithValue("@DOB", DatBOD.Value.Date)
                        .Parameters.AddWithValue("@TelNo", txtTelNo.Text)
                        .Parameters.AddWithValue("@Username", txtUsername.Text)
                        .Parameters.AddWithValue("@Password", txtPassword.Text)
                        MessageBox.Show("Succesfully created an account")

                        .ExecuteNonQuery()

                        'auto generate ID
                        .CommandText = "Select @@Identity"
                        CurrentStaffID = .ExecuteScalar
                        lblStaffID.Text = CurrentStaffID
                        MessageBox.Show("Succesfully created an account")
                    End With
                Else
                    'EDITING EXISTING CUSTOMER DATA
                    With SQLCmd
                        .Connection = cn
                        .CommandText = "Update StaffTbl Set SFName = @FirstName, SSName = @Surname, SEmail = @Email,"
                        .CommandText &= "SDOB = @DOB, STel = @TelNo, SUsername = @Username, SPassword = @Password where StaffID = @CurrentStaffID"
                        .Parameters.AddWithValue("@FirstName", txtFirstName.Text)
                        .Parameters.AddWithValue("@Surname", txtSurname.Text)
                        .Parameters.AddWithValue("@Email", txtEmail.Text)
                        .Parameters.AddWithValue("@DOB", DatBOD.Value)
                        .Parameters.AddWithValue("@TelNo", txtTelNo.Text)
                        .Parameters.AddWithValue("@Username", txtUsername.Text)
                        .Parameters.AddWithValue("@Password", txtPassword.Text)
                        .Parameters.AddWithValue("@CurrentStaffID", CurrentStaffID)
                        .ExecuteNonQuery()
                        MessageBox.Show("Succesfully updated details")
                    End With
                End If
                cn.Close()
            End If
        End If
    End Sub

    Private Sub btnDeleteCust_Click(sender As Object, e As EventArgs) Handles btnDeleteCust.Click
        'DELETING CUSTOMER INFORMATION
        Dim Confirmation As Boolean
        Confirmation = MsgBox("Do you want to delete", vbYesNo)


        If vbYes Then
            If dbConnect() Then
                Dim SQLCmd As New OleDbCommand
                With SQLCmd
                    .Connection = cn
                    .CommandText = "Delete From BookingTbl Where StaffID = @StaffID"
                    .Parameters.AddWithValue("@StaffID", CurrentStaffID)
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
                    .CommandText = "Delete From StaffTbl Where StaffID = @StaffID"
                    .Parameters.AddWithValue("@StaffID", CurrentStaffID)
                    .ExecuteNonQuery()
                    btnClearSearch.PerformClick()
                End With
                cn.Close()
                btnClearSearch.PerformClick()
            End If
        End If
    End Sub

    Private Sub btnCustNew_Click(sender As Object, e As EventArgs) Handles btnCustNew.Click
        'CLEARING DATA
        CurrentStaffID = -1
        lblStaffID.Text = "<automatically generated>"
        txtSurname.Text = ""
        txtFirstName.Text = ""
        txtEmail.Text = ""
        DatBOD.Value = Now.AddYears(-18)
        txtTelNo.Text = ""
        btnDeleteCust.Enabled = False
        txtPassword.Text = ""
        txtUsername.Text = ""
    End Sub

    Private Sub DisplayStaff(StaffID As Integer)
        'DISPLAYING STAF INFORMATION
        If dbConnect() Then
            Dim SQLcmd As New OleDbCommand
            With SQLcmd
                .Connection = cn
                .CommandText = "Select * From StaffTbl Where StaffID = @SearchID"
                .Parameters.AddWithValue("@SearchID", StaffID)
                Dim rs As OleDbDataReader = .ExecuteReader()



                If rs.Read Then
                    CurrentStaffID = StaffID
                    lblStaffID.Text = rs("StaffID")
                    txtSurname.Text = rs("SSName")
                    txtFirstName.Text = rs("SFName")
                    DatBOD.Value = rs("SDOB")
                    txtTelNo.Text = rs("STel")
                    txtEmail.Text = rs("SEmail")
                    txtUsername.Text = rs("SUsername")
                    txtPassword.Text = rs("SPassword")


                    btnDeleteCust.Enabled = True

                Else
                    MessageBox.Show("Could not find a Staff with ID " & StaffID, "Find Staff", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
                rs.Close()
            End With
            cn.Close()
        End If
    End Sub

    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click

        If IsNumeric(txtIDSearch.Text) Then

            'FIND CUSTOMER BY ID
            DisplayStaff(txtIDSearch.Text)
        ElseIf txtSurnameSearch.Text.Length > 0 Then
            'FIND ANY MATCHING STUDENT BY SURNAME AND DISPLAY IN LIST
            If dbConnect() Then
                lstStaff.Items.Clear()
                Dim SQLCmd As New OleDbCommand
                With SQLCmd
                    .Connection = cn
                    .CommandText = "Select * From StaffTbl Where SSName Like @SurnameSearch"
                    .Parameters.AddWithValue("@SurnameSearch", "%" & txtSurnameSearch.Text & "%")
                    Dim rs As OleDbDataReader = .ExecuteReader()

                    While rs.Read
                        Dim DisplayValue As String = rs("SFName") & " " & rs("SSName") & "(" & rs("SDOB") & ")"
                        Dim CustomerItem As New ListBoxData(DisplayValue, rs("StaffID"))
                        lstStaff.Items.Add(CustomerItem)
                    End While
                    rs.Close()
                    If lstStaff.Items.Count = 1 Then
                        'Auto select if theres only 1 name
                        PanSearchList.Visible = False
                        lstStaff.SelectedIndex = 0
                    ElseIf lstStaff.Items.Count > 1 Then
                        'Show list
                        PanSearchList.Visible = True
                    Else
                        PanSearchList.Visible = False
                        MessageBox.Show("There are no Staff with that surname", "Find Staff", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    End If
                End With
                cn.Close()
            End If

        End If
    End Sub

    Private Sub lstStaff_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstStaff.SelectedIndexChanged
        'DISPLAY INFROMATION IF STAFF NAME IS CLICKED IN THE LIST
        If lstStaff.SelectedItem IsNot Nothing Then
            Dim SelectedCustomer As ListBoxData = lstStaff.SelectedItem
            DisplayStaff(SelectedCustomer.Identifier)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'GOING BACK
        Me.Hide()
        FrmMain.Show()
    End Sub

    Private Sub txtIDSearch_TextChanged(sender As Object, e As EventArgs) Handles txtIDSearch.TextChanged

    End Sub

    Private Sub lblStaffID_Click(sender As Object, e As EventArgs) Handles lblStaffID.Click

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub txtSurnameSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSurnameSearch.TextChanged

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PanSearchList_Paint(sender As Object, e As PaintEventArgs) Handles PanSearchList.Paint

    End Sub
End Class