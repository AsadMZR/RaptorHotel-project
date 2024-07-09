Imports System.Data.OleDb
Imports System.Diagnostics.Eventing.Reader

Public Class frmCust
    Private CurrentCustomerID As Integer = -1 'CREATE A UNIQUE ID EACH TIME

    Private Sub btnCustNew_Click_1(sender As Object, e As EventArgs) Handles btnCustNew.Click
        'VALIDATION
        CurrentCustomerID = -1
        txtCustID.Text = "<automatically generated>"
        If dbConnect() Then
            If txtCPassword.Text = "" Or txtCUsername.Text = "" Or txtCustID.Text = "" Or txtEmail.Text = "" Or txtFirstName.Text = "" Or txtSurname.Text = "" Or txtTelNo.Text = "" Then
                MsgBox("Missing Information")
            ElseIf txtCPassword.Text.Length >= 50 Or txtCUsername.Text.Length >= 50 Or txtEmail.Text.Length >= 50 Or txtFirstName.Text.Length >= 50 Or txtSurname.Text.Length >= 50 Or txtTelNo.Text.Length <> 10 Then
                MsgBox("Please, double check your details as they exeed the charecter/digit limmit")
            ElseIf DatBOD.Value > Now.AddYears(-18) Then
                MessageBox.Show("Sorry, you must be atleast 18 years old to use out service")
                'ADDING CUSTOMER
            Else
                Dim SQLCmd As New OleDbCommand
                If CurrentCustomerID = -1 Then
                    'ADDING NEW CUSTOMERS
                    With SQLCmd
                        .Connection = cn

                        .CommandText = "Insert into CustomerTbl (CFName, CSName, CEmail, CDOB, CTel, CUsername, CPassword)"
                        .CommandText &= " Values (@FirstName, @Surname, @CEmail, @CDOB, @CTel, @CUsername, @CPassword)"
                        .Parameters.AddWithValue("@FirstName", txtFirstName.Text)
                        .Parameters.AddWithValue("@Surname", txtSurname.Text)
                        .Parameters.AddWithValue("@CEmail", txtEmail.Text)
                        .Parameters.AddWithValue("@CDOB", DatBOD.Value.Date)
                        .Parameters.AddWithValue("@CTel", txtTelNo.Text)
                        .Parameters.AddWithValue("@CUsername", txtCUsername.Text)
                        .Parameters.AddWithValue("@CPassword", txtCPassword.Text)
                        .ExecuteNonQuery()


                        'auto generate ID
                        .CommandText = "Select @@Identity"
                        CurrentCustomerID = .ExecuteScalar
                        txtCustID.Text = CurrentCustomerID
                        Dim rs As OleDbDataReader = .ExecuteReader()
                        MessageBox.Show("Succesfully created an account")
                        frmLogIn.Show()
                        Me.Close()

                    End With
                    cn.Close()
                End If
            End If
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'GOING BACK
        Me.Hide()
        frmLogIn.Show()
    End Sub

    Private Sub frmCust_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TEXT FOR CUST ID
        txtCustID.Text = "<Automatically Generated>"

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub txtCustID_TextChanged(sender As Object, e As EventArgs) Handles txtCustID.TextChanged

    End Sub

    Private Sub DatBOD_ValueChanged(sender As Object, e As EventArgs) Handles DatBOD.ValueChanged


    End Sub
End Class