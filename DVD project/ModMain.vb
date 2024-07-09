Imports System.Data.OleDb

Module ModMain
    Public PublicStaffName, PublicStaffID, PublicStaffAccessLevel As String
    Public PublicRoomID As String

    Public Const DataBasePath As String = "Provider=Microsoft.JET.OLEDB.4.0;Data Source='..\..\..\Raptor Hotel DataBase.mdb';Persist Security Info=False;"
    Public cn As OleDbConnection
    Public Function dbConnect() As Boolean
        Try
            cn = New OleDbConnection(DataBasePath)
            cn.Open()
            Return True
        Catch ex As Exception
            MessageBox.Show("Unable to open the database :" & ex.Message)
            Return False
        End Try
    End Function
    Public Class ListBoxData
        Public Data As String
        Public Identifier As Integer

        Public Sub New(NewData As String, NewIdentifier As Integer)
            Data = NewData
            Identifier = NewIdentifier
        End Sub
        Public Overrides Function ToString() As String
            Return Data
        End Function
    End Class

    Public publicCustName As String
    Public publicCPassword As String

    Public PublicCustID, PublicDaysLeft As Integer
    Public PublicRoomStatues As Boolean
    Public publicBookingID As String


End Module
