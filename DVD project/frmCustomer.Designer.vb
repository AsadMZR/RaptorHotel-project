<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCustomers
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCustomers))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblCustID = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.btnCustNew = New System.Windows.Forms.Button()
        Me.btnSaveCust = New System.Windows.Forms.Button()
        Me.DatBOD = New System.Windows.Forms.DateTimePicker()
        Me.btnDeleteCust = New System.Windows.Forms.Button()
        Me.txtTelNo = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.txtSurname = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnGOtomainmenu = New System.Windows.Forms.Button()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.dgvCurrentOrders = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtSurnameSearch = New System.Windows.Forms.TextBox()
        Me.txtIDSearch = New System.Windows.Forms.TextBox()
        Me.btnClearSearch = New System.Windows.Forms.Button()
        Me.BtnSearch = New System.Windows.Forms.Button()
        Me.PanSearchList = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lstCustomers = New System.Windows.Forms.ListBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.dgvCurrentOrders, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.PanSearchList.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Silver
        Me.Label2.Location = New System.Drawing.Point(427, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Find Customer..."
        '
        'lblCustID
        '
        Me.lblCustID.AutoSize = True
        Me.lblCustID.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblCustID.Location = New System.Drawing.Point(165, 40)
        Me.lblCustID.Name = "lblCustID"
        Me.lblCustID.Size = New System.Drawing.Size(165, 16)
        Me.lblCustID.TabIndex = 25
        Me.lblCustID.Text = "<automatically generated>"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button2.Location = New System.Drawing.Point(176, 343)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(121, 23)
        Me.Button2.TabIndex = 24
        Me.Button2.Tag = "View Orders"
        Me.Button2.Text = "View Booking"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label14.Location = New System.Drawing.Point(32, 285)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(67, 16)
        Me.Label14.TabIndex = 22
        Me.Label14.Text = "Password"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(28, 252)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(70, 16)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "Username"
        '
        'txtPassword
        '
        Me.txtPassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtPassword.Location = New System.Drawing.Point(165, 285)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(132, 22)
        Me.txtPassword.TabIndex = 20
        '
        'txtUsername
        '
        Me.txtUsername.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtUsername.Location = New System.Drawing.Point(166, 252)
        Me.txtUsername.Margin = New System.Windows.Forms.Padding(4)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(132, 22)
        Me.txtUsername.TabIndex = 19
        '
        'btnCustNew
        '
        Me.btnCustNew.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnCustNew.Location = New System.Drawing.Point(76, 343)
        Me.btnCustNew.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnCustNew.Name = "btnCustNew"
        Me.btnCustNew.Size = New System.Drawing.Size(75, 23)
        Me.btnCustNew.TabIndex = 18
        Me.btnCustNew.Text = "Clear"
        Me.btnCustNew.UseVisualStyleBackColor = False
        '
        'btnSaveCust
        '
        Me.btnSaveCust.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnSaveCust.Location = New System.Drawing.Point(336, 343)
        Me.btnSaveCust.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSaveCust.Name = "btnSaveCust"
        Me.btnSaveCust.Size = New System.Drawing.Size(75, 23)
        Me.btnSaveCust.TabIndex = 17
        Me.btnSaveCust.Text = "Save"
        Me.btnSaveCust.UseVisualStyleBackColor = False
        '
        'DatBOD
        '
        Me.DatBOD.Location = New System.Drawing.Point(165, 182)
        Me.DatBOD.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DatBOD.Name = "DatBOD"
        Me.DatBOD.Size = New System.Drawing.Size(200, 22)
        Me.DatBOD.TabIndex = 15
        '
        'btnDeleteCust
        '
        Me.btnDeleteCust.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnDeleteCust.Location = New System.Drawing.Point(336, 46)
        Me.btnDeleteCust.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnDeleteCust.Name = "btnDeleteCust"
        Me.btnDeleteCust.Size = New System.Drawing.Size(75, 23)
        Me.btnDeleteCust.TabIndex = 16
        Me.btnDeleteCust.Text = "Delete"
        Me.btnDeleteCust.UseVisualStyleBackColor = False
        '
        'txtTelNo
        '
        Me.txtTelNo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtTelNo.Location = New System.Drawing.Point(209, 220)
        Me.txtTelNo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtTelNo.Name = "txtTelNo"
        Me.txtTelNo.Size = New System.Drawing.Size(121, 22)
        Me.txtTelNo.TabIndex = 13
        '
        'txtEmail
        '
        Me.txtEmail.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtEmail.Location = New System.Drawing.Point(166, 149)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(152, 22)
        Me.txtEmail.TabIndex = 11
        '
        'txtFirstName
        '
        Me.txtFirstName.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtFirstName.Location = New System.Drawing.Point(165, 113)
        Me.txtFirstName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(152, 22)
        Me.txtFirstName.TabIndex = 10
        '
        'txtSurname
        '
        Me.txtSurname.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtSurname.Location = New System.Drawing.Point(166, 77)
        Me.txtSurname.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtSurname.Name = "txtSurname"
        Me.txtSurname.Size = New System.Drawing.Size(152, 22)
        Me.txtSurname.TabIndex = 9
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(24, 229)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(97, 16)
        Me.Label13.TabIndex = 6
        Me.Label13.Text = "Telephone No:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(20, 190)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(84, 16)
        Me.Label12.TabIndex = 5
        Me.Label12.Text = "Date Of Birth:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(46, 149)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(44, 16)
        Me.Label10.TabIndex = 3
        Me.Label10.Text = "Email:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(24, 113)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(82, 16)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "First Names:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(30, 77)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(64, 16)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Surname:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(24, 40)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(83, 16)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Customer ID:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Silver
        Me.Label6.Location = New System.Drawing.Point(19, 6)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(109, 16)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Customer Details"
        '
        'btnGOtomainmenu
        '
        Me.btnGOtomainmenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnGOtomainmenu.Location = New System.Drawing.Point(625, 7)
        Me.btnGOtomainmenu.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnGOtomainmenu.Name = "btnGOtomainmenu"
        Me.btnGOtomainmenu.Size = New System.Drawing.Size(119, 23)
        Me.btnGOtomainmenu.TabIndex = 4
        Me.btnGOtomainmenu.Text = "Control Pannel"
        Me.btnGOtomainmenu.UseVisualStyleBackColor = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Silver
        Me.Label15.Location = New System.Drawing.Point(197, 6)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(36, 16)
        Me.Label15.TabIndex = 5
        Me.Label15.Text = "Staff:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(253, 7)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(67, 16)
        Me.Label16.TabIndex = 6
        Me.Label16.Text = "LabelStaff"
        '
        'dgvCurrentOrders
        '
        Me.dgvCurrentOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvCurrentOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCurrentOrders.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        Me.dgvCurrentOrders.Location = New System.Drawing.Point(45, 416)
        Me.dgvCurrentOrders.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgvCurrentOrders.Name = "dgvCurrentOrders"
        Me.dgvCurrentOrders.RowHeadersWidth = 51
        Me.dgvCurrentOrders.RowTemplate.Height = 24
        Me.dgvCurrentOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCurrentOrders.Size = New System.Drawing.Size(739, 150)
        Me.dgvCurrentOrders.TabIndex = 0
        '
        'Column1
        '
        Me.Column1.HeaderText = "Room Number"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Booking ID"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "Start Date"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "End Date"
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.HeaderText = "Total Cost"
        Me.Column5.MinimumWidth = 6
        Me.Column5.Name = "Column5"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel1.Controls.Add(Me.txtSurnameSearch)
        Me.Panel1.Controls.Add(Me.txtIDSearch)
        Me.Panel1.Controls.Add(Me.btnClearSearch)
        Me.Panel1.Controls.Add(Me.BtnSearch)
        Me.Panel1.Controls.Add(Me.PanSearchList)
        Me.Panel1.Controls.Add(Me.Label17)
        Me.Panel1.Controls.Add(Me.Label18)
        Me.Panel1.Controls.Add(Me.Label19)
        Me.Panel1.Location = New System.Drawing.Point(427, 52)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(357, 314)
        Me.Panel1.TabIndex = 26
        '
        'txtSurnameSearch
        '
        Me.txtSurnameSearch.Location = New System.Drawing.Point(93, 95)
        Me.txtSurnameSearch.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtSurnameSearch.Name = "txtSurnameSearch"
        Me.txtSurnameSearch.Size = New System.Drawing.Size(152, 22)
        Me.txtSurnameSearch.TabIndex = 7
        '
        'txtIDSearch
        '
        Me.txtIDSearch.Location = New System.Drawing.Point(93, 57)
        Me.txtIDSearch.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtIDSearch.Name = "txtIDSearch"
        Me.txtIDSearch.Size = New System.Drawing.Size(100, 22)
        Me.txtIDSearch.TabIndex = 6
        '
        'btnClearSearch
        '
        Me.btnClearSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnClearSearch.Location = New System.Drawing.Point(267, 95)
        Me.btnClearSearch.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnClearSearch.Name = "btnClearSearch"
        Me.btnClearSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnClearSearch.TabIndex = 5
        Me.btnClearSearch.Text = "Clear"
        Me.btnClearSearch.UseVisualStyleBackColor = False
        '
        'BtnSearch
        '
        Me.BtnSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnSearch.Location = New System.Drawing.Point(267, 54)
        Me.BtnSearch.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnSearch.Name = "BtnSearch"
        Me.BtnSearch.Size = New System.Drawing.Size(75, 23)
        Me.BtnSearch.TabIndex = 4
        Me.BtnSearch.Text = "Search"
        Me.BtnSearch.UseVisualStyleBackColor = False
        '
        'PanSearchList
        '
        Me.PanSearchList.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.PanSearchList.Controls.Add(Me.Label5)
        Me.PanSearchList.Controls.Add(Me.lstCustomers)
        Me.PanSearchList.Location = New System.Drawing.Point(0, 142)
        Me.PanSearchList.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PanSearchList.Name = "PanSearchList"
        Me.PanSearchList.Size = New System.Drawing.Size(362, 172)
        Me.PanSearchList.TabIndex = 3
        Me.PanSearchList.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 12)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(325, 16)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "The following Staff members match the search criteria:"
        '
        'lstCustomers
        '
        Me.lstCustomers.FormattingEnabled = True
        Me.lstCustomers.ItemHeight = 16
        Me.lstCustomers.Location = New System.Drawing.Point(4, 42)
        Me.lstCustomers.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lstCustomers.Name = "lstCustomers"
        Me.lstCustomers.Size = New System.Drawing.Size(337, 116)
        Me.lstCustomers.TabIndex = 0
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(7, 95)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(64, 16)
        Me.Label17.TabIndex = 2
        Me.Label17.Text = "Surname:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(3, 57)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(83, 16)
        Me.Label18.TabIndex = 1
        Me.Label18.Text = "Customer ID:"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(4, 16)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(295, 16)
        Me.Label19.TabIndex = 0
        Me.Label19.Text = "Enter an ID or Surname below to find a  Customer"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-10, -13)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(859, 619)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 27
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(162, 223)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 16)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "+44"
        '
        'frmCustomers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(836, 598)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.dgvCurrentOrders)
        Me.Controls.Add(Me.lblCustID)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.btnGOtomainmenu)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnCustNew)
        Me.Controls.Add(Me.btnSaveCust)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DatBOD)
        Me.Controls.Add(Me.btnDeleteCust)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtTelNo)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtSurname)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.PictureBox1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "frmCustomers"
        Me.Text = "Form1"
        CType(Me.dgvCurrentOrders, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.PanSearchList.ResumeLayout(False)
        Me.PanSearchList.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents txtSurname As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnCustNew As Button
    Friend WithEvents btnSaveCust As Button
    Friend WithEvents btnDeleteCust As Button
    Friend WithEvents DatBOD As DateTimePicker
    Friend WithEvents txtTelNo As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents btnGOtomainmenu As Button
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents dgvCurrentOrders As DataGridView
    Friend WithEvents Label14 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Button2 As Button
    Friend WithEvents lblCustID As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtSurnameSearch As TextBox
    Friend WithEvents txtIDSearch As TextBox
    Friend WithEvents btnClearSearch As Button
    Friend WithEvents BtnSearch As Button
    Friend WithEvents PanSearchList As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents lstCustomers As ListBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
End Class
