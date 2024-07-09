<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmAddRooms
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAddRooms))
        Me.dgvAddRoom = New System.Windows.Forms.DataGridView()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnGOtomainmenu = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.CheckAC = New System.Windows.Forms.CheckBox()
        Me.CheckBar = New System.Windows.Forms.CheckBox()
        Me.CheckHealth = New System.Windows.Forms.CheckBox()
        Me.rtbROOM = New System.Windows.Forms.RichTextBox()
        Me.CheckCoffe = New System.Windows.Forms.CheckBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CheckTV = New System.Windows.Forms.CheckBox()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CheckWater = New System.Windows.Forms.CheckBox()
        Me.CheckAvailability = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.CheckWifi = New System.Windows.Forms.CheckBox()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BtnAddRoom = New System.Windows.Forms.Button()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.CheckDental = New System.Windows.Forms.CheckBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CheckDesk = New System.Windows.Forms.CheckBox()
        Me.butClear = New System.Windows.Forms.Button()
        Me.BtnUpdate = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        CType(Me.dgvAddRoom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvAddRoom
        '
        Me.dgvAddRoom.BackgroundColor = System.Drawing.Color.Silver
        Me.dgvAddRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAddRoom.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column5, Me.Column1, Me.Column2, Me.Column3})
        Me.dgvAddRoom.GridColor = System.Drawing.SystemColors.ActiveBorder
        Me.dgvAddRoom.Location = New System.Drawing.Point(102, 518)
        Me.dgvAddRoom.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvAddRoom.Name = "dgvAddRoom"
        Me.dgvAddRoom.RowHeadersWidth = 51
        Me.dgvAddRoom.Size = New System.Drawing.Size(737, 209)
        Me.dgvAddRoom.TabIndex = 1
        '
        'Column5
        '
        Me.Column5.HeaderText = "Room Number"
        Me.Column5.MinimumWidth = 6
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 125
        '
        'Column1
        '
        Me.Column1.HeaderText = "Room Type:"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 125
        '
        'Column2
        '
        Me.Column2.HeaderText = "Suitable For (no. people):"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 125
        '
        'Column3
        '
        Me.Column3.HeaderText = "Price Per Night:"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 125
        '
        'btnGOtomainmenu
        '
        Me.btnGOtomainmenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnGOtomainmenu.Location = New System.Drawing.Point(823, 25)
        Me.btnGOtomainmenu.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnGOtomainmenu.Name = "btnGOtomainmenu"
        Me.btnGOtomainmenu.Size = New System.Drawing.Size(119, 23)
        Me.btnGOtomainmenu.TabIndex = 20
        Me.btnGOtomainmenu.Text = "Control Pannel"
        Me.btnGOtomainmenu.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(820, 64)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(207, 16)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Click on the red box to add picture"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.PictureBox1.Location = New System.Drawing.Point(791, 56)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(271, 204)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 23
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(-54, 90)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(1116, 767)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 24
        Me.PictureBox2.TabStop = False
        '
        'ComboBox2
        '
        Me.ComboBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8"})
        Me.ComboBox2.Location = New System.Drawing.Point(296, 120)
        Me.ComboBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(160, 24)
        Me.ComboBox2.TabIndex = 52
        '
        'CheckAC
        '
        Me.CheckAC.AutoSize = True
        Me.CheckAC.BackColor = System.Drawing.Color.Silver
        Me.CheckAC.Location = New System.Drawing.Point(296, 429)
        Me.CheckAC.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckAC.Name = "CheckAC"
        Me.CheckAC.Size = New System.Drawing.Size(116, 20)
        Me.CheckAC.TabIndex = 66
        Me.CheckAC.Text = "Air Conditioner"
        Me.CheckAC.UseVisualStyleBackColor = False
        '
        'CheckBar
        '
        Me.CheckBar.AutoSize = True
        Me.CheckBar.BackColor = System.Drawing.Color.Silver
        Me.CheckBar.Location = New System.Drawing.Point(573, 401)
        Me.CheckBar.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckBar.Name = "CheckBar"
        Me.CheckBar.Size = New System.Drawing.Size(77, 20)
        Me.CheckBar.TabIndex = 71
        Me.CheckBar.Text = "Mini Bar"
        Me.CheckBar.UseVisualStyleBackColor = False
        '
        'CheckHealth
        '
        Me.CheckHealth.AutoSize = True
        Me.CheckHealth.BackColor = System.Drawing.Color.Silver
        Me.CheckHealth.Location = New System.Drawing.Point(428, 429)
        Me.CheckHealth.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckHealth.Name = "CheckHealth"
        Me.CheckHealth.Size = New System.Drawing.Size(117, 20)
        Me.CheckHealth.TabIndex = 69
        Me.CheckHealth.Text = "Health Care Kit"
        Me.CheckHealth.UseVisualStyleBackColor = False
        '
        'rtbROOM
        '
        Me.rtbROOM.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.rtbROOM.Location = New System.Drawing.Point(296, 215)
        Me.rtbROOM.Margin = New System.Windows.Forms.Padding(4)
        Me.rtbROOM.Name = "rtbROOM"
        Me.rtbROOM.Size = New System.Drawing.Size(312, 141)
        Me.rtbROOM.TabIndex = 62
        Me.rtbROOM.Text = ""
        '
        'CheckCoffe
        '
        Me.CheckCoffe.AutoSize = True
        Me.CheckCoffe.BackColor = System.Drawing.Color.Silver
        Me.CheckCoffe.Location = New System.Drawing.Point(296, 370)
        Me.CheckCoffe.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckCoffe.Name = "CheckCoffe"
        Me.CheckCoffe.Size = New System.Drawing.Size(114, 20)
        Me.CheckCoffe.TabIndex = 64
        Me.CheckCoffe.Text = "Coffe Machine"
        Me.CheckCoffe.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(148, 162)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(96, 16)
        Me.Label6.TabIndex = 45
        Me.Label6.Text = "Price Per Night"
        '
        'CheckTV
        '
        Me.CheckTV.AutoSize = True
        Me.CheckTV.BackColor = System.Drawing.Color.Silver
        Me.CheckTV.Location = New System.Drawing.Point(428, 370)
        Me.CheckTV.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckTV.Name = "CheckTV"
        Me.CheckTV.Size = New System.Drawing.Size(47, 20)
        Me.CheckTV.TabIndex = 67
        Me.CheckTV.Text = "TV"
        Me.CheckTV.UseVisualStyleBackColor = False
        '
        'BtnDelete
        '
        Me.BtnDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BtnDelete.Location = New System.Drawing.Point(636, 232)
        Me.BtnDelete.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(100, 28)
        Me.BtnDelete.TabIndex = 56
        Me.BtnDelete.Text = "Deleate"
        Me.BtnDelete.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(148, 65)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 16)
        Me.Label2.TabIndex = 54
        Me.Label2.Text = "Room Number"
        '
        'CheckWater
        '
        Me.CheckWater.AutoSize = True
        Me.CheckWater.BackColor = System.Drawing.Color.Silver
        Me.CheckWater.Location = New System.Drawing.Point(573, 372)
        Me.CheckWater.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckWater.Name = "CheckWater"
        Me.CheckWater.Size = New System.Drawing.Size(92, 20)
        Me.CheckWater.TabIndex = 70
        Me.CheckWater.Text = "Free water"
        Me.CheckWater.UseVisualStyleBackColor = False
        '
        'CheckAvailability
        '
        Me.CheckAvailability.AutoSize = True
        Me.CheckAvailability.BackColor = System.Drawing.Color.Silver
        Me.CheckAvailability.Location = New System.Drawing.Point(296, 188)
        Me.CheckAvailability.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckAvailability.Name = "CheckAvailability"
        Me.CheckAvailability.Size = New System.Drawing.Size(89, 20)
        Me.CheckAvailability.TabIndex = 59
        Me.CheckAvailability.Text = "Avalilable"
        Me.CheckAvailability.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(164, 90)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 16)
        Me.Label1.TabIndex = 40
        Me.Label1.Text = "Room Type"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(89, 129)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(153, 16)
        Me.Label5.TabIndex = 44
        Me.Label5.Text = "Suitable for (No. People)"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(160, 370)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(99, 16)
        Me.Label11.TabIndex = 63
        Me.Label11.Text = "Room Contains"
        '
        'CheckWifi
        '
        Me.CheckWifi.AutoSize = True
        Me.CheckWifi.BackColor = System.Drawing.Color.Silver
        Me.CheckWifi.Location = New System.Drawing.Point(296, 399)
        Me.CheckWifi.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckWifi.Name = "CheckWifi"
        Me.CheckWifi.Size = New System.Drawing.Size(82, 20)
        Me.CheckWifi.TabIndex = 65
        Me.CheckWifi.Text = "Free Wifi"
        Me.CheckWifi.UseVisualStyleBackColor = False
        '
        'ComboBox3
        '
        Me.ComboBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.ComboBox3.Location = New System.Drawing.Point(296, 56)
        Me.ComboBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(160, 24)
        Me.ComboBox3.TabIndex = 53
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(134, 186)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 16)
        Me.Label3.TabIndex = 58
        Me.Label3.Text = "Statues Of Room"
        '
        'BtnAddRoom
        '
        Me.BtnAddRoom.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BtnAddRoom.Location = New System.Drawing.Point(636, 312)
        Me.BtnAddRoom.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnAddRoom.Name = "BtnAddRoom"
        Me.BtnAddRoom.Size = New System.Drawing.Size(100, 28)
        Me.BtnAddRoom.TabIndex = 32
        Me.BtnAddRoom.Text = "Add Room"
        Me.BtnAddRoom.UseVisualStyleBackColor = False
        '
        'txtPrice
        '
        Me.txtPrice.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtPrice.Location = New System.Drawing.Point(296, 156)
        Me.txtPrice.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(132, 22)
        Me.txtPrice.TabIndex = 35
        '
        'CheckDental
        '
        Me.CheckDental.AutoSize = True
        Me.CheckDental.BackColor = System.Drawing.Color.Silver
        Me.CheckDental.Location = New System.Drawing.Point(428, 398)
        Me.CheckDental.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckDental.Name = "CheckDental"
        Me.CheckDental.Size = New System.Drawing.Size(102, 20)
        Me.CheckDental.TabIndex = 68
        Me.CheckDental.Text = "Dental Pack"
        Me.CheckDental.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(134, 218)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(123, 16)
        Me.Label7.TabIndex = 60
        Me.Label7.Text = "Description of room"
        '
        'CheckDesk
        '
        Me.CheckDesk.AutoSize = True
        Me.CheckDesk.BackColor = System.Drawing.Color.Silver
        Me.CheckDesk.Location = New System.Drawing.Point(573, 429)
        Me.CheckDesk.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckDesk.Name = "CheckDesk"
        Me.CheckDesk.Size = New System.Drawing.Size(61, 20)
        Me.CheckDesk.TabIndex = 72
        Me.CheckDesk.Text = "Desk"
        Me.CheckDesk.UseVisualStyleBackColor = False
        '
        'butClear
        '
        Me.butClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.butClear.Location = New System.Drawing.Point(636, 188)
        Me.butClear.Margin = New System.Windows.Forms.Padding(4)
        Me.butClear.Name = "butClear"
        Me.butClear.Size = New System.Drawing.Size(100, 28)
        Me.butClear.TabIndex = 17
        Me.butClear.Text = "Clear"
        Me.butClear.UseVisualStyleBackColor = False
        '
        'BtnUpdate
        '
        Me.BtnUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BtnUpdate.Location = New System.Drawing.Point(636, 268)
        Me.BtnUpdate.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(100, 28)
        Me.BtnUpdate.TabIndex = 55
        Me.BtnUpdate.Text = "Update"
        Me.BtnUpdate.UseVisualStyleBackColor = False
        '
        'ComboBox1
        '
        Me.ComboBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Standard", "Standard-City View", "Superior", "Superior-City View", "One Bedroom Suite", "Family", "Suite", "Single", "Double", "Triple"})
        Me.ComboBox1.Location = New System.Drawing.Point(296, 90)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(160, 24)
        Me.ComboBox1.TabIndex = 51
        '
        'FrmAddRooms
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1088, 753)
        Me.Controls.Add(Me.CheckDesk)
        Me.Controls.Add(Me.CheckBar)
        Me.Controls.Add(Me.CheckWater)
        Me.Controls.Add(Me.CheckHealth)
        Me.Controls.Add(Me.CheckDental)
        Me.Controls.Add(Me.CheckTV)
        Me.Controls.Add(Me.CheckAC)
        Me.Controls.Add(Me.rtbROOM)
        Me.Controls.Add(Me.CheckWifi)
        Me.Controls.Add(Me.BtnAddRoom)
        Me.Controls.Add(Me.CheckCoffe)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.butClear)
        Me.Controls.Add(Me.CheckAvailability)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.BtnDelete)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.BtnUpdate)
        Me.Controls.Add(Me.ComboBox3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnGOtomainmenu)
        Me.Controls.Add(Me.dgvAddRoom)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmAddRooms"
        Me.Text = "FrmAddRooms"
        CType(Me.dgvAddRoom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvAddRoom As DataGridView
    Friend WithEvents btnGOtomainmenu As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents CheckAC As CheckBox
    Friend WithEvents CheckBar As CheckBox
    Friend WithEvents CheckHealth As CheckBox
    Friend WithEvents rtbROOM As RichTextBox
    Friend WithEvents CheckCoffe As CheckBox
    Friend WithEvents Label6 As Label
    Friend WithEvents CheckTV As CheckBox
    Friend WithEvents BtnDelete As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents CheckWater As CheckBox
    Friend WithEvents CheckAvailability As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents CheckWifi As CheckBox
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents BtnAddRoom As Button
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents CheckDental As CheckBox
    Friend WithEvents Label7 As Label
    Friend WithEvents CheckDesk As CheckBox
    Friend WithEvents butClear As Button
    Friend WithEvents BtnUpdate As Button
    Friend WithEvents ComboBox1 As ComboBox
End Class
