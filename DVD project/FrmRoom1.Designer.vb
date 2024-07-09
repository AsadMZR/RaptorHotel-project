<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmRoom1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmRoom1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LblDescription = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.lblRoom = New System.Windows.Forms.Label()
        Me.CheckDesk = New System.Windows.Forms.CheckBox()
        Me.CheckBar = New System.Windows.Forms.CheckBox()
        Me.CheckWater = New System.Windows.Forms.CheckBox()
        Me.CheckTV = New System.Windows.Forms.CheckBox()
        Me.CheckAC = New System.Windows.Forms.CheckBox()
        Me.CheckWifi = New System.Windows.Forms.CheckBox()
        Me.CheckCoffe = New System.Windows.Forms.CheckBox()
        Me.CheckHealth = New System.Windows.Forms.CheckBox()
        Me.CheckDental = New System.Windows.Forms.CheckBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Silver
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(108, 39)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(137, 46)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Room :"
        '
        'LblDescription
        '
        Me.LblDescription.BackColor = System.Drawing.Color.Silver
        Me.LblDescription.Location = New System.Drawing.Point(317, 263)
        Me.LblDescription.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblDescription.Name = "LblDescription"
        Me.LblDescription.Size = New System.Drawing.Size(289, 228)
        Me.LblDescription.TabIndex = 3
        Me.LblDescription.Text = "Label6"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(710, 285)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(240, 27)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Contains (list the items)"
        '
        'ListBox1
        '
        Me.ListBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 16
        Me.ListBox1.Location = New System.Drawing.Point(47, 154)
        Me.ListBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(224, 244)
        Me.ListBox1.TabIndex = 8
        '
        'lblRoom
        '
        Me.lblRoom.AutoSize = True
        Me.lblRoom.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblRoom.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRoom.Location = New System.Drawing.Point(256, 39)
        Me.lblRoom.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRoom.Name = "lblRoom"
        Me.lblRoom.Size = New System.Drawing.Size(40, 46)
        Me.lblRoom.TabIndex = 9
        Me.lblRoom.Text = "1"
        '
        'CheckDesk
        '
        Me.CheckDesk.AutoSize = True
        Me.CheckDesk.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.CheckDesk.Location = New System.Drawing.Point(881, 387)
        Me.CheckDesk.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckDesk.Name = "CheckDesk"
        Me.CheckDesk.Size = New System.Drawing.Size(61, 20)
        Me.CheckDesk.TabIndex = 82
        Me.CheckDesk.Text = "Desk"
        Me.CheckDesk.UseVisualStyleBackColor = False
        '
        'CheckBar
        '
        Me.CheckBar.AutoSize = True
        Me.CheckBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.CheckBar.Location = New System.Drawing.Point(881, 359)
        Me.CheckBar.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckBar.Name = "CheckBar"
        Me.CheckBar.Size = New System.Drawing.Size(77, 20)
        Me.CheckBar.TabIndex = 81
        Me.CheckBar.Text = "Mini Bar"
        Me.CheckBar.UseVisualStyleBackColor = False
        '
        'CheckWater
        '
        Me.CheckWater.AutoSize = True
        Me.CheckWater.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.CheckWater.Location = New System.Drawing.Point(881, 331)
        Me.CheckWater.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckWater.Name = "CheckWater"
        Me.CheckWater.Size = New System.Drawing.Size(92, 20)
        Me.CheckWater.TabIndex = 80
        Me.CheckWater.Text = "Free water"
        Me.CheckWater.UseVisualStyleBackColor = False
        '
        'CheckTV
        '
        Me.CheckTV.AutoSize = True
        Me.CheckTV.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.CheckTV.Location = New System.Drawing.Point(715, 471)
        Me.CheckTV.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckTV.Name = "CheckTV"
        Me.CheckTV.Size = New System.Drawing.Size(47, 20)
        Me.CheckTV.TabIndex = 77
        Me.CheckTV.Text = "TV"
        Me.CheckTV.UseVisualStyleBackColor = False
        '
        'CheckAC
        '
        Me.CheckAC.AutoSize = True
        Me.CheckAC.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.CheckAC.Location = New System.Drawing.Point(715, 387)
        Me.CheckAC.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckAC.Name = "CheckAC"
        Me.CheckAC.Size = New System.Drawing.Size(116, 20)
        Me.CheckAC.TabIndex = 76
        Me.CheckAC.Text = "Air Conditioner"
        Me.CheckAC.UseVisualStyleBackColor = False
        '
        'CheckWifi
        '
        Me.CheckWifi.AutoSize = True
        Me.CheckWifi.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.CheckWifi.Location = New System.Drawing.Point(715, 359)
        Me.CheckWifi.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckWifi.Name = "CheckWifi"
        Me.CheckWifi.Size = New System.Drawing.Size(82, 20)
        Me.CheckWifi.TabIndex = 75
        Me.CheckWifi.Text = "Free Wifi"
        Me.CheckWifi.UseVisualStyleBackColor = False
        '
        'CheckCoffe
        '
        Me.CheckCoffe.AutoSize = True
        Me.CheckCoffe.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.CheckCoffe.Location = New System.Drawing.Point(715, 331)
        Me.CheckCoffe.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckCoffe.Name = "CheckCoffe"
        Me.CheckCoffe.Size = New System.Drawing.Size(114, 20)
        Me.CheckCoffe.TabIndex = 74
        Me.CheckCoffe.Text = "Coffe Machine"
        Me.CheckCoffe.UseVisualStyleBackColor = False
        '
        'CheckHealth
        '
        Me.CheckHealth.AutoSize = True
        Me.CheckHealth.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.CheckHealth.Location = New System.Drawing.Point(715, 443)
        Me.CheckHealth.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckHealth.Name = "CheckHealth"
        Me.CheckHealth.Size = New System.Drawing.Size(117, 20)
        Me.CheckHealth.TabIndex = 85
        Me.CheckHealth.Text = "Health Care Kit"
        Me.CheckHealth.UseVisualStyleBackColor = False
        '
        'CheckDental
        '
        Me.CheckDental.AutoSize = True
        Me.CheckDental.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.CheckDental.Location = New System.Drawing.Point(715, 415)
        Me.CheckDental.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckDental.Name = "CheckDental"
        Me.CheckDental.Size = New System.Drawing.Size(85, 20)
        Me.CheckDental.TabIndex = 84
        Me.CheckDental.Text = "Dental Kit"
        Me.CheckDental.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.PictureBox2.Location = New System.Drawing.Point(647, 13)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(380, 256)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 87
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-1, -12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1081, 567)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 88
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(931, 485)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 89
        Me.Button1.Text = "Back"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'FrmRoom1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1067, 554)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.CheckCoffe)
        Me.Controls.Add(Me.LblDescription)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.CheckHealth)
        Me.Controls.Add(Me.CheckDental)
        Me.Controls.Add(Me.CheckDesk)
        Me.Controls.Add(Me.CheckBar)
        Me.Controls.Add(Me.CheckWater)
        Me.Controls.Add(Me.CheckTV)
        Me.Controls.Add(Me.CheckAC)
        Me.Controls.Add(Me.CheckWifi)
        Me.Controls.Add(Me.lblRoom)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmRoom1"
        Me.Text = "FrmRoom110"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents LblDescription As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents lblRoom As Label
    Friend WithEvents CheckDesk As CheckBox
    Friend WithEvents CheckBar As CheckBox
    Friend WithEvents CheckWater As CheckBox
    Friend WithEvents CheckTV As CheckBox
    Friend WithEvents CheckAC As CheckBox
    Friend WithEvents CheckWifi As CheckBox
    Friend WithEvents CheckCoffe As CheckBox
    Friend WithEvents CheckHealth As CheckBox
    Friend WithEvents CheckDental As CheckBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
End Class
