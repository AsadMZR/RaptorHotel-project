<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCustMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCustMain))
        Me.ButtonEditInfo = New System.Windows.Forms.Button()
        Me.ButtonRooms = New System.Windows.Forms.Button()
        Me.ButtonBookings = New System.Windows.Forms.Button()
        Me.ButtonReservations = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LabelName = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LabelID = New System.Windows.Forms.Label()
        Me.BtnLogOut = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonEditInfo
        '
        Me.ButtonEditInfo.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ButtonEditInfo.Location = New System.Drawing.Point(789, 184)
        Me.ButtonEditInfo.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonEditInfo.Name = "ButtonEditInfo"
        Me.ButtonEditInfo.Size = New System.Drawing.Size(236, 251)
        Me.ButtonEditInfo.TabIndex = 3
        Me.ButtonEditInfo.Text = "Edit Information"
        Me.ButtonEditInfo.UseVisualStyleBackColor = False
        '
        'ButtonRooms
        '
        Me.ButtonRooms.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ButtonRooms.Location = New System.Drawing.Point(57, 184)
        Me.ButtonRooms.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonRooms.Name = "ButtonRooms"
        Me.ButtonRooms.Size = New System.Drawing.Size(236, 251)
        Me.ButtonRooms.TabIndex = 2
        Me.ButtonRooms.Text = "View Rooms"
        Me.ButtonRooms.UseVisualStyleBackColor = False
        '
        'ButtonBookings
        '
        Me.ButtonBookings.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ButtonBookings.Location = New System.Drawing.Point(545, 184)
        Me.ButtonBookings.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonBookings.Name = "ButtonBookings"
        Me.ButtonBookings.Size = New System.Drawing.Size(236, 251)
        Me.ButtonBookings.TabIndex = 1
        Me.ButtonBookings.Text = "Your Bookings"
        Me.ButtonBookings.UseVisualStyleBackColor = False
        '
        'ButtonReservations
        '
        Me.ButtonReservations.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ButtonReservations.Location = New System.Drawing.Point(301, 184)
        Me.ButtonReservations.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonReservations.Name = "ButtonReservations"
        Me.ButtonReservations.Size = New System.Drawing.Size(236, 251)
        Me.ButtonReservations.TabIndex = 0
        Me.ButtonReservations.Text = "Reservations"
        Me.ButtonReservations.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(39, 58)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Customer Name:"
        '
        'LabelName
        '
        Me.LabelName.AutoSize = True
        Me.LabelName.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LabelName.Location = New System.Drawing.Point(175, 59)
        Me.LabelName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelName.Name = "LabelName"
        Me.LabelName.Size = New System.Drawing.Size(48, 16)
        Me.LabelName.TabIndex = 2
        Me.LabelName.Text = "Label2"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(872, 59)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(23, 16)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "ID:"
        '
        'LabelID
        '
        Me.LabelID.AutoSize = True
        Me.LabelID.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LabelID.Location = New System.Drawing.Point(921, 58)
        Me.LabelID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelID.Name = "LabelID"
        Me.LabelID.Size = New System.Drawing.Size(48, 16)
        Me.LabelID.TabIndex = 6
        Me.LabelID.Text = "Label6"
        '
        'BtnLogOut
        '
        Me.BtnLogOut.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BtnLogOut.Location = New System.Drawing.Point(897, 82)
        Me.BtnLogOut.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnLogOut.Name = "BtnLogOut"
        Me.BtnLogOut.Size = New System.Drawing.Size(100, 28)
        Me.BtnLogOut.TabIndex = 7
        Me.BtnLogOut.Text = "Log Out"
        Me.BtnLogOut.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-1, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1068, 506)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'FrmCustMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1067, 505)
        Me.Controls.Add(Me.ButtonEditInfo)
        Me.Controls.Add(Me.ButtonRooms)
        Me.Controls.Add(Me.BtnLogOut)
        Me.Controls.Add(Me.ButtonBookings)
        Me.Controls.Add(Me.LabelID)
        Me.Controls.Add(Me.ButtonReservations)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.LabelName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmCustMain"
        Me.Text = "FrmCustMain"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents LabelName As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents LabelID As Label
    Friend WithEvents ButtonBookings As Button
    Friend WithEvents ButtonReservations As Button
    Friend WithEvents ButtonRooms As Button
    Friend WithEvents ButtonEditInfo As Button
    Friend WithEvents BtnLogOut As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
