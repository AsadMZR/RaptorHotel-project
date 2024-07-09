Imports System.Data.OleDb

Public Class FrmEditInfo
    Private CurrentCustomerID As Integer = -1
    Private Sub FrmEditInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'DISPLAYING CUSTOMER INFORMATION
        DisplayCustomer(PublicCustID)
    End Sub
    Private Sub DisplayCustomer(customerID As Integer)
        'DISPLAYING CUSTOMER INFROMATION

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
                    txtTelNo.Text = rs("CTel")
                    txtUsername.Text = rs("CUsername")
                    txtPassword.Text = rs("CPassword")



                Else
                    MessageBox.Show("Could not find a Customer with ID " & customerID, "Find Customer", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
                rs.Close()
            End With
            cn.Close()
        End If

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
                    'ADDIING NEW CUSTOMERS
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
                        MsgBox("Your information has been updated")
                    End With
                End If
                cn.Close()
            End If
        End If


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'GOING BACK
        Me.Hide()
        FrmCustMain.Show()
    End Sub
End Class