<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Attend_Patient_Details
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Attend_Patient_Details))
        Me.Tb_Patient_ID = New System.Windows.Forms.TextBox()
        Me.Lbl_Blood_Pressure = New System.Windows.Forms.Label()
        Me.Btn_NEXT = New System.Windows.Forms.Button()
        Me.Tb_Contact_No_2 = New System.Windows.Forms.TextBox()
        Me.Btn_SEARCH = New System.Windows.Forms.Button()
        Me.Tb_Contact_No_1 = New System.Windows.Forms.TextBox()
        Me.Lbl_Patient_ID = New System.Windows.Forms.Label()
        Me.Lbl_Contact_No_2 = New System.Windows.Forms.Label()
        Me.Dtp_Date = New System.Windows.Forms.DateTimePicker()
        Me.Lbl_Appointment_Date = New System.Windows.Forms.Label()
        Me.Lbl_Appointment_Time = New System.Windows.Forms.Label()
        Me.Lbl_Date = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Lbl_Attend_Patient_Details = New System.Windows.Forms.Label()
        Me.Lbl_Contact_No_1 = New System.Windows.Forms.Label()
        Me.Tb_Address = New System.Windows.Forms.TextBox()
        Me.Gp_Patient_Details = New System.Windows.Forms.GroupBox()
        Me.Gp_Gender = New System.Windows.Forms.GroupBox()
        Me.Rb_Male = New System.Windows.Forms.RadioButton()
        Me.Rb_Female = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Cb_Low = New System.Windows.Forms.CheckBox()
        Me.Cb_Normal = New System.Windows.Forms.CheckBox()
        Me.Cb_High = New System.Windows.Forms.CheckBox()
        Me.Cmb_Blood_Group = New System.Windows.Forms.ComboBox()
        Me.Tb_Charges = New System.Windows.Forms.TextBox()
        Me.Lbl_Charges = New System.Windows.Forms.Label()
        Me.Dtp_Appointment_Time = New System.Windows.Forms.DateTimePicker()
        Me.Dtp_Appointment_Date = New System.Windows.Forms.DateTimePicker()
        Me.Lbl_Gender = New System.Windows.Forms.Label()
        Me.Lbl_Blood_Group = New System.Windows.Forms.Label()
        Me.Tb_Age = New System.Windows.Forms.TextBox()
        Me.Lbl_Age = New System.Windows.Forms.Label()
        Me.Tb_Last_Name = New System.Windows.Forms.TextBox()
        Me.Tb_First_Name = New System.Windows.Forms.TextBox()
        Me.Lbl_Last_Name = New System.Windows.Forms.Label()
        Me.Lbl_Address = New System.Windows.Forms.Label()
        Me.Lbl_First_Name = New System.Windows.Forms.Label()
        Me.Btn_CLEAR = New System.Windows.Forms.Button()
        Me.Lbl_Doctor_Name = New System.Windows.Forms.Label()
        Me.Cmb_Select_Doctor = New System.Windows.Forms.ComboBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Gp_Patient_Details.SuspendLayout()
        Me.Gp_Gender.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Tb_Patient_ID
        '
        Me.Tb_Patient_ID.Font = New System.Drawing.Font("Bahnschrift Condensed", 20.25!, System.Drawing.FontStyle.Bold)
        Me.Tb_Patient_ID.Location = New System.Drawing.Point(162, 134)
        Me.Tb_Patient_ID.Name = "Tb_Patient_ID"
        Me.Tb_Patient_ID.Size = New System.Drawing.Size(179, 40)
        Me.Tb_Patient_ID.TabIndex = 185
        '
        'Lbl_Blood_Pressure
        '
        Me.Lbl_Blood_Pressure.AutoSize = True
        Me.Lbl_Blood_Pressure.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Lbl_Blood_Pressure.Font = New System.Drawing.Font("Bahnschrift Condensed", 20.25!, System.Drawing.FontStyle.Bold)
        Me.Lbl_Blood_Pressure.ForeColor = System.Drawing.Color.Red
        Me.Lbl_Blood_Pressure.Location = New System.Drawing.Point(619, 381)
        Me.Lbl_Blood_Pressure.Name = "Lbl_Blood_Pressure"
        Me.Lbl_Blood_Pressure.Size = New System.Drawing.Size(148, 33)
        Me.Lbl_Blood_Pressure.TabIndex = 192
        Me.Lbl_Blood_Pressure.Text = "Blood Pressure"
        '
        'Btn_NEXT
        '
        Me.Btn_NEXT.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Btn_NEXT.Enabled = False
        Me.Btn_NEXT.Font = New System.Drawing.Font("Bahnschrift Condensed", 20.25!, System.Drawing.FontStyle.Bold)
        Me.Btn_NEXT.ForeColor = System.Drawing.Color.Cornsilk
        Me.Btn_NEXT.Location = New System.Drawing.Point(320, 629)
        Me.Btn_NEXT.Name = "Btn_NEXT"
        Me.Btn_NEXT.Size = New System.Drawing.Size(144, 52)
        Me.Btn_NEXT.TabIndex = 187
        Me.Btn_NEXT.Text = "NEXT"
        Me.Btn_NEXT.UseVisualStyleBackColor = False
        '
        'Tb_Contact_No_2
        '
        Me.Tb_Contact_No_2.Enabled = False
        Me.Tb_Contact_No_2.Font = New System.Drawing.Font("Bahnschrift Condensed", 20.25!, System.Drawing.FontStyle.Bold)
        Me.Tb_Contact_No_2.Location = New System.Drawing.Point(223, 313)
        Me.Tb_Contact_No_2.Name = "Tb_Contact_No_2"
        Me.Tb_Contact_No_2.Size = New System.Drawing.Size(267, 40)
        Me.Tb_Contact_No_2.TabIndex = 189
        '
        'Btn_SEARCH
        '
        Me.Btn_SEARCH.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Btn_SEARCH.Enabled = False
        Me.Btn_SEARCH.Font = New System.Drawing.Font("Bahnschrift Condensed", 20.25!, System.Drawing.FontStyle.Bold)
        Me.Btn_SEARCH.ForeColor = System.Drawing.Color.Cornsilk
        Me.Btn_SEARCH.Location = New System.Drawing.Point(347, 131)
        Me.Btn_SEARCH.Name = "Btn_SEARCH"
        Me.Btn_SEARCH.Size = New System.Drawing.Size(144, 42)
        Me.Btn_SEARCH.TabIndex = 186
        Me.Btn_SEARCH.Text = "SEARCH"
        Me.Btn_SEARCH.UseVisualStyleBackColor = False
        '
        'Tb_Contact_No_1
        '
        Me.Tb_Contact_No_1.Enabled = False
        Me.Tb_Contact_No_1.Font = New System.Drawing.Font("Bahnschrift Condensed", 20.25!, System.Drawing.FontStyle.Bold)
        Me.Tb_Contact_No_1.Location = New System.Drawing.Point(223, 260)
        Me.Tb_Contact_No_1.Name = "Tb_Contact_No_1"
        Me.Tb_Contact_No_1.Size = New System.Drawing.Size(267, 40)
        Me.Tb_Contact_No_1.TabIndex = 188
        '
        'Lbl_Patient_ID
        '
        Me.Lbl_Patient_ID.AutoSize = True
        Me.Lbl_Patient_ID.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Lbl_Patient_ID.Font = New System.Drawing.Font("Bahnschrift Condensed", 20.25!, System.Drawing.FontStyle.Bold)
        Me.Lbl_Patient_ID.ForeColor = System.Drawing.Color.Black
        Me.Lbl_Patient_ID.Location = New System.Drawing.Point(23, 134)
        Me.Lbl_Patient_ID.Name = "Lbl_Patient_ID"
        Me.Lbl_Patient_ID.Size = New System.Drawing.Size(100, 33)
        Me.Lbl_Patient_ID.TabIndex = 193
        Me.Lbl_Patient_ID.Text = "Patient ID"
        '
        'Lbl_Contact_No_2
        '
        Me.Lbl_Contact_No_2.AutoSize = True
        Me.Lbl_Contact_No_2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Lbl_Contact_No_2.Font = New System.Drawing.Font("Bahnschrift Condensed", 20.25!, System.Drawing.FontStyle.Bold)
        Me.Lbl_Contact_No_2.ForeColor = System.Drawing.Color.Red
        Me.Lbl_Contact_No_2.Location = New System.Drawing.Point(57, 316)
        Me.Lbl_Contact_No_2.Name = "Lbl_Contact_No_2"
        Me.Lbl_Contact_No_2.Size = New System.Drawing.Size(124, 33)
        Me.Lbl_Contact_No_2.TabIndex = 187
        Me.Lbl_Contact_No_2.Text = "Contact No.2"
        '
        'Dtp_Date
        '
        Me.Dtp_Date.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Dtp_Date.Enabled = False
        Me.Dtp_Date.Font = New System.Drawing.Font("Bahnschrift Condensed", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dtp_Date.Location = New System.Drawing.Point(1083, 137)
        Me.Dtp_Date.Name = "Dtp_Date"
        Me.Dtp_Date.Size = New System.Drawing.Size(267, 33)
        Me.Dtp_Date.TabIndex = 191
        '
        'Lbl_Appointment_Date
        '
        Me.Lbl_Appointment_Date.AutoSize = True
        Me.Lbl_Appointment_Date.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Lbl_Appointment_Date.Font = New System.Drawing.Font("Bahnschrift Condensed", 20.25!, System.Drawing.FontStyle.Bold)
        Me.Lbl_Appointment_Date.ForeColor = System.Drawing.Color.Red
        Me.Lbl_Appointment_Date.Location = New System.Drawing.Point(610, 172)
        Me.Lbl_Appointment_Date.Name = "Lbl_Appointment_Date"
        Me.Lbl_Appointment_Date.Size = New System.Drawing.Size(179, 33)
        Me.Lbl_Appointment_Date.TabIndex = 197
        Me.Lbl_Appointment_Date.Text = " Appointment Date"
        '
        'Lbl_Appointment_Time
        '
        Me.Lbl_Appointment_Time.AutoSize = True
        Me.Lbl_Appointment_Time.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Lbl_Appointment_Time.Font = New System.Drawing.Font("Bahnschrift Condensed", 20.25!, System.Drawing.FontStyle.Bold)
        Me.Lbl_Appointment_Time.ForeColor = System.Drawing.Color.Red
        Me.Lbl_Appointment_Time.Location = New System.Drawing.Point(608, 246)
        Me.Lbl_Appointment_Time.Name = "Lbl_Appointment_Time"
        Me.Lbl_Appointment_Time.Size = New System.Drawing.Size(180, 33)
        Me.Lbl_Appointment_Time.TabIndex = 196
        Me.Lbl_Appointment_Time.Text = " Appointment Time"
        '
        'Lbl_Date
        '
        Me.Lbl_Date.AutoSize = True
        Me.Lbl_Date.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Lbl_Date.Font = New System.Drawing.Font("Bahnschrift Condensed", 20.25!, System.Drawing.FontStyle.Bold)
        Me.Lbl_Date.ForeColor = System.Drawing.Color.Red
        Me.Lbl_Date.Location = New System.Drawing.Point(1002, 140)
        Me.Lbl_Date.Name = "Lbl_Date"
        Me.Lbl_Date.Size = New System.Drawing.Size(56, 33)
        Me.Lbl_Date.TabIndex = 190
        Me.Lbl_Date.Text = "Date"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Blue
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Lbl_Attend_Patient_Details)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1350, 92)
        Me.Panel1.TabIndex = 189
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(258, 92)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 93
        Me.PictureBox1.TabStop = False
        '
        'Lbl_Attend_Patient_Details
        '
        Me.Lbl_Attend_Patient_Details.AutoSize = True
        Me.Lbl_Attend_Patient_Details.Font = New System.Drawing.Font("Bahnschrift Condensed", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Attend_Patient_Details.ForeColor = System.Drawing.Color.LemonChiffon
        Me.Lbl_Attend_Patient_Details.Image = CType(resources.GetObject("Lbl_Attend_Patient_Details.Image"), System.Drawing.Image)
        Me.Lbl_Attend_Patient_Details.Location = New System.Drawing.Point(469, 9)
        Me.Lbl_Attend_Patient_Details.Name = "Lbl_Attend_Patient_Details"
        Me.Lbl_Attend_Patient_Details.Size = New System.Drawing.Size(497, 77)
        Me.Lbl_Attend_Patient_Details.TabIndex = 63
        Me.Lbl_Attend_Patient_Details.Text = "Attend Patient Details"
        '
        'Lbl_Contact_No_1
        '
        Me.Lbl_Contact_No_1.AutoSize = True
        Me.Lbl_Contact_No_1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Lbl_Contact_No_1.Font = New System.Drawing.Font("Bahnschrift Condensed", 20.25!, System.Drawing.FontStyle.Bold)
        Me.Lbl_Contact_No_1.ForeColor = System.Drawing.Color.Red
        Me.Lbl_Contact_No_1.Location = New System.Drawing.Point(57, 263)
        Me.Lbl_Contact_No_1.Name = "Lbl_Contact_No_1"
        Me.Lbl_Contact_No_1.Size = New System.Drawing.Size(120, 33)
        Me.Lbl_Contact_No_1.TabIndex = 186
        Me.Lbl_Contact_No_1.Text = "Contact No.1"
        '
        'Tb_Address
        '
        Me.Tb_Address.Enabled = False
        Me.Tb_Address.Font = New System.Drawing.Font("Bahnschrift Condensed", 20.25!, System.Drawing.FontStyle.Bold)
        Me.Tb_Address.Location = New System.Drawing.Point(223, 149)
        Me.Tb_Address.Multiline = True
        Me.Tb_Address.Name = "Tb_Address"
        Me.Tb_Address.Size = New System.Drawing.Size(267, 85)
        Me.Tb_Address.TabIndex = 185
        '
        'Gp_Patient_Details
        '
        Me.Gp_Patient_Details.Controls.Add(Me.Gp_Gender)
        Me.Gp_Patient_Details.Controls.Add(Me.GroupBox1)
        Me.Gp_Patient_Details.Controls.Add(Me.Cmb_Blood_Group)
        Me.Gp_Patient_Details.Controls.Add(Me.Tb_Charges)
        Me.Gp_Patient_Details.Controls.Add(Me.Lbl_Charges)
        Me.Gp_Patient_Details.Controls.Add(Me.Dtp_Appointment_Time)
        Me.Gp_Patient_Details.Controls.Add(Me.Dtp_Appointment_Date)
        Me.Gp_Patient_Details.Controls.Add(Me.Lbl_Appointment_Date)
        Me.Gp_Patient_Details.Controls.Add(Me.Lbl_Appointment_Time)
        Me.Gp_Patient_Details.Controls.Add(Me.Lbl_Blood_Pressure)
        Me.Gp_Patient_Details.Controls.Add(Me.Tb_Contact_No_2)
        Me.Gp_Patient_Details.Controls.Add(Me.Tb_Contact_No_1)
        Me.Gp_Patient_Details.Controls.Add(Me.Lbl_Contact_No_2)
        Me.Gp_Patient_Details.Controls.Add(Me.Lbl_Contact_No_1)
        Me.Gp_Patient_Details.Controls.Add(Me.Tb_Address)
        Me.Gp_Patient_Details.Controls.Add(Me.Lbl_Gender)
        Me.Gp_Patient_Details.Controls.Add(Me.Lbl_Blood_Group)
        Me.Gp_Patient_Details.Controls.Add(Me.Tb_Age)
        Me.Gp_Patient_Details.Controls.Add(Me.Lbl_Age)
        Me.Gp_Patient_Details.Controls.Add(Me.Tb_Last_Name)
        Me.Gp_Patient_Details.Controls.Add(Me.Tb_First_Name)
        Me.Gp_Patient_Details.Controls.Add(Me.Lbl_Last_Name)
        Me.Gp_Patient_Details.Controls.Add(Me.Lbl_Address)
        Me.Gp_Patient_Details.Controls.Add(Me.Lbl_First_Name)
        Me.Gp_Patient_Details.Font = New System.Drawing.Font("Bahnschrift Condensed", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Gp_Patient_Details.Location = New System.Drawing.Point(133, 194)
        Me.Gp_Patient_Details.Name = "Gp_Patient_Details"
        Me.Gp_Patient_Details.Size = New System.Drawing.Size(1094, 429)
        Me.Gp_Patient_Details.TabIndex = 192
        Me.Gp_Patient_Details.TabStop = False
        Me.Gp_Patient_Details.Text = "Patient Details"
        '
        'Gp_Gender
        '
        Me.Gp_Gender.Controls.Add(Me.Rb_Male)
        Me.Gp_Gender.Controls.Add(Me.Rb_Female)
        Me.Gp_Gender.Enabled = False
        Me.Gp_Gender.Font = New System.Drawing.Font("Bahnschrift Condensed", 20.25!, System.Drawing.FontStyle.Bold)
        Me.Gp_Gender.Location = New System.Drawing.Point(799, 14)
        Me.Gp_Gender.Name = "Gp_Gender"
        Me.Gp_Gender.Size = New System.Drawing.Size(267, 78)
        Me.Gp_Gender.TabIndex = 977
        Me.Gp_Gender.TabStop = False
        '
        'Rb_Male
        '
        Me.Rb_Male.AutoSize = True
        Me.Rb_Male.Font = New System.Drawing.Font("Bahnschrift Condensed", 20.25!, System.Drawing.FontStyle.Bold)
        Me.Rb_Male.ForeColor = System.Drawing.Color.Black
        Me.Rb_Male.Location = New System.Drawing.Point(36, 31)
        Me.Rb_Male.Name = "Rb_Male"
        Me.Rb_Male.Size = New System.Drawing.Size(76, 37)
        Me.Rb_Male.TabIndex = 9
        Me.Rb_Male.Text = "Male"
        Me.Rb_Male.UseVisualStyleBackColor = True
        '
        'Rb_Female
        '
        Me.Rb_Female.AutoSize = True
        Me.Rb_Female.Font = New System.Drawing.Font("Bahnschrift Condensed", 20.25!, System.Drawing.FontStyle.Bold)
        Me.Rb_Female.ForeColor = System.Drawing.Color.Black
        Me.Rb_Female.Location = New System.Drawing.Point(150, 31)
        Me.Rb_Female.Name = "Rb_Female"
        Me.Rb_Female.Size = New System.Drawing.Size(99, 37)
        Me.Rb_Female.TabIndex = 10
        Me.Rb_Female.Text = "Female"
        Me.Rb_Female.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Cb_Low)
        Me.GroupBox1.Controls.Add(Me.Cb_Normal)
        Me.GroupBox1.Controls.Add(Me.Cb_High)
        Me.GroupBox1.Enabled = False
        Me.GroupBox1.Font = New System.Drawing.Font("Bahnschrift Condensed", 20.25!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.Location = New System.Drawing.Point(771, 349)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(317, 68)
        Me.GroupBox1.TabIndex = 203
        Me.GroupBox1.TabStop = False
        '
        'Cb_Low
        '
        Me.Cb_Low.AutoSize = True
        Me.Cb_Low.Location = New System.Drawing.Point(19, 31)
        Me.Cb_Low.Name = "Cb_Low"
        Me.Cb_Low.Size = New System.Drawing.Size(68, 37)
        Me.Cb_Low.TabIndex = 2
        Me.Cb_Low.Text = "Low"
        Me.Cb_Low.UseVisualStyleBackColor = True
        '
        'Cb_Normal
        '
        Me.Cb_Normal.AutoSize = True
        Me.Cb_Normal.Location = New System.Drawing.Point(103, 31)
        Me.Cb_Normal.Name = "Cb_Normal"
        Me.Cb_Normal.Size = New System.Drawing.Size(98, 37)
        Me.Cb_Normal.TabIndex = 1
        Me.Cb_Normal.Text = "Normal"
        Me.Cb_Normal.UseVisualStyleBackColor = True
        '
        'Cb_High
        '
        Me.Cb_High.AutoSize = True
        Me.Cb_High.Location = New System.Drawing.Point(204, 31)
        Me.Cb_High.Name = "Cb_High"
        Me.Cb_High.Size = New System.Drawing.Size(72, 37)
        Me.Cb_High.TabIndex = 0
        Me.Cb_High.Text = "High"
        Me.Cb_High.UseVisualStyleBackColor = True
        '
        'Cmb_Blood_Group
        '
        Me.Cmb_Blood_Group.Enabled = False
        Me.Cmb_Blood_Group.Font = New System.Drawing.Font("Bahnschrift Condensed", 20.25!, System.Drawing.FontStyle.Bold)
        Me.Cmb_Blood_Group.FormattingEnabled = True
        Me.Cmb_Blood_Group.Items.AddRange(New Object() {"A+", "B+", "C+", "D+", "O+", "O-"})
        Me.Cmb_Blood_Group.Location = New System.Drawing.Point(799, 98)
        Me.Cmb_Blood_Group.Name = "Cmb_Blood_Group"
        Me.Cmb_Blood_Group.Size = New System.Drawing.Size(265, 41)
        Me.Cmb_Blood_Group.TabIndex = 202
        '
        'Tb_Charges
        '
        Me.Tb_Charges.Enabled = False
        Me.Tb_Charges.Font = New System.Drawing.Font("Bahnschrift Condensed", 20.25!, System.Drawing.FontStyle.Bold)
        Me.Tb_Charges.Location = New System.Drawing.Point(797, 313)
        Me.Tb_Charges.Name = "Tb_Charges"
        Me.Tb_Charges.Size = New System.Drawing.Size(267, 40)
        Me.Tb_Charges.TabIndex = 201
        '
        'Lbl_Charges
        '
        Me.Lbl_Charges.AutoSize = True
        Me.Lbl_Charges.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Lbl_Charges.Font = New System.Drawing.Font("Bahnschrift Condensed", 20.25!, System.Drawing.FontStyle.Bold)
        Me.Lbl_Charges.ForeColor = System.Drawing.Color.Red
        Me.Lbl_Charges.Location = New System.Drawing.Point(619, 317)
        Me.Lbl_Charges.Name = "Lbl_Charges"
        Me.Lbl_Charges.Size = New System.Drawing.Size(88, 33)
        Me.Lbl_Charges.TabIndex = 200
        Me.Lbl_Charges.Text = "Charges"
        '
        'Dtp_Appointment_Time
        '
        Me.Dtp_Appointment_Time.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Dtp_Appointment_Time.Enabled = False
        Me.Dtp_Appointment_Time.Font = New System.Drawing.Font("Bahnschrift Condensed", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dtp_Appointment_Time.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.Dtp_Appointment_Time.Location = New System.Drawing.Point(797, 239)
        Me.Dtp_Appointment_Time.Name = "Dtp_Appointment_Time"
        Me.Dtp_Appointment_Time.Size = New System.Drawing.Size(267, 33)
        Me.Dtp_Appointment_Time.TabIndex = 199
        '
        'Dtp_Appointment_Date
        '
        Me.Dtp_Appointment_Date.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Dtp_Appointment_Date.Enabled = False
        Me.Dtp_Appointment_Date.Font = New System.Drawing.Font("Bahnschrift Condensed", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dtp_Appointment_Date.Location = New System.Drawing.Point(797, 165)
        Me.Dtp_Appointment_Date.Name = "Dtp_Appointment_Date"
        Me.Dtp_Appointment_Date.Size = New System.Drawing.Size(267, 33)
        Me.Dtp_Appointment_Date.TabIndex = 198
        '
        'Lbl_Gender
        '
        Me.Lbl_Gender.AutoSize = True
        Me.Lbl_Gender.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Lbl_Gender.Font = New System.Drawing.Font("Bahnschrift Condensed", 20.25!, System.Drawing.FontStyle.Bold)
        Me.Lbl_Gender.ForeColor = System.Drawing.Color.Red
        Me.Lbl_Gender.Location = New System.Drawing.Point(619, 36)
        Me.Lbl_Gender.Name = "Lbl_Gender"
        Me.Lbl_Gender.Size = New System.Drawing.Size(79, 33)
        Me.Lbl_Gender.TabIndex = 183
        Me.Lbl_Gender.Text = "Gender"
        '
        'Lbl_Blood_Group
        '
        Me.Lbl_Blood_Group.AutoSize = True
        Me.Lbl_Blood_Group.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Lbl_Blood_Group.Font = New System.Drawing.Font("Bahnschrift Condensed", 20.25!, System.Drawing.FontStyle.Bold)
        Me.Lbl_Blood_Group.ForeColor = System.Drawing.Color.Red
        Me.Lbl_Blood_Group.Location = New System.Drawing.Point(619, 98)
        Me.Lbl_Blood_Group.Name = "Lbl_Blood_Group"
        Me.Lbl_Blood_Group.Size = New System.Drawing.Size(120, 33)
        Me.Lbl_Blood_Group.TabIndex = 181
        Me.Lbl_Blood_Group.Text = "Blood Group"
        '
        'Tb_Age
        '
        Me.Tb_Age.Enabled = False
        Me.Tb_Age.Font = New System.Drawing.Font("Bahnschrift Condensed", 20.25!, System.Drawing.FontStyle.Bold)
        Me.Tb_Age.Location = New System.Drawing.Point(223, 381)
        Me.Tb_Age.Name = "Tb_Age"
        Me.Tb_Age.Size = New System.Drawing.Size(267, 40)
        Me.Tb_Age.TabIndex = 180
        '
        'Lbl_Age
        '
        Me.Lbl_Age.AutoSize = True
        Me.Lbl_Age.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Lbl_Age.Font = New System.Drawing.Font("Bahnschrift Condensed", 20.25!, System.Drawing.FontStyle.Bold)
        Me.Lbl_Age.ForeColor = System.Drawing.Color.Red
        Me.Lbl_Age.Location = New System.Drawing.Point(57, 381)
        Me.Lbl_Age.Name = "Lbl_Age"
        Me.Lbl_Age.Size = New System.Drawing.Size(49, 33)
        Me.Lbl_Age.TabIndex = 178
        Me.Lbl_Age.Text = "Age"
        '
        'Tb_Last_Name
        '
        Me.Tb_Last_Name.Enabled = False
        Me.Tb_Last_Name.Font = New System.Drawing.Font("Bahnschrift Condensed", 20.25!, System.Drawing.FontStyle.Bold)
        Me.Tb_Last_Name.Location = New System.Drawing.Point(223, 91)
        Me.Tb_Last_Name.Name = "Tb_Last_Name"
        Me.Tb_Last_Name.Size = New System.Drawing.Size(267, 40)
        Me.Tb_Last_Name.TabIndex = 175
        '
        'Tb_First_Name
        '
        Me.Tb_First_Name.Enabled = False
        Me.Tb_First_Name.Font = New System.Drawing.Font("Bahnschrift Condensed", 20.25!, System.Drawing.FontStyle.Bold)
        Me.Tb_First_Name.Location = New System.Drawing.Point(223, 29)
        Me.Tb_First_Name.Name = "Tb_First_Name"
        Me.Tb_First_Name.Size = New System.Drawing.Size(267, 40)
        Me.Tb_First_Name.TabIndex = 174
        '
        'Lbl_Last_Name
        '
        Me.Lbl_Last_Name.AutoSize = True
        Me.Lbl_Last_Name.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Lbl_Last_Name.Font = New System.Drawing.Font("Bahnschrift Condensed", 20.25!, System.Drawing.FontStyle.Bold)
        Me.Lbl_Last_Name.ForeColor = System.Drawing.Color.Red
        Me.Lbl_Last_Name.Location = New System.Drawing.Point(57, 91)
        Me.Lbl_Last_Name.Name = "Lbl_Last_Name"
        Me.Lbl_Last_Name.Size = New System.Drawing.Size(109, 33)
        Me.Lbl_Last_Name.TabIndex = 173
        Me.Lbl_Last_Name.Text = "Last Name"
        '
        'Lbl_Address
        '
        Me.Lbl_Address.AutoSize = True
        Me.Lbl_Address.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Lbl_Address.Font = New System.Drawing.Font("Bahnschrift Condensed", 20.25!, System.Drawing.FontStyle.Bold)
        Me.Lbl_Address.ForeColor = System.Drawing.Color.Red
        Me.Lbl_Address.Location = New System.Drawing.Point(57, 147)
        Me.Lbl_Address.Name = "Lbl_Address"
        Me.Lbl_Address.Size = New System.Drawing.Size(88, 33)
        Me.Lbl_Address.TabIndex = 171
        Me.Lbl_Address.Text = "Address"
        '
        'Lbl_First_Name
        '
        Me.Lbl_First_Name.AutoSize = True
        Me.Lbl_First_Name.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Lbl_First_Name.Font = New System.Drawing.Font("Bahnschrift Condensed", 20.25!, System.Drawing.FontStyle.Bold)
        Me.Lbl_First_Name.ForeColor = System.Drawing.Color.Red
        Me.Lbl_First_Name.Location = New System.Drawing.Point(57, 32)
        Me.Lbl_First_Name.Name = "Lbl_First_Name"
        Me.Lbl_First_Name.Size = New System.Drawing.Size(111, 33)
        Me.Lbl_First_Name.TabIndex = 172
        Me.Lbl_First_Name.Text = "First Name"
        '
        'Btn_CLEAR
        '
        Me.Btn_CLEAR.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Btn_CLEAR.Font = New System.Drawing.Font("Bahnschrift Condensed", 20.25!, System.Drawing.FontStyle.Bold)
        Me.Btn_CLEAR.ForeColor = System.Drawing.SystemColors.Control
        Me.Btn_CLEAR.Location = New System.Drawing.Point(733, 629)
        Me.Btn_CLEAR.Name = "Btn_CLEAR"
        Me.Btn_CLEAR.Size = New System.Drawing.Size(144, 52)
        Me.Btn_CLEAR.TabIndex = 188
        Me.Btn_CLEAR.Text = "CLEAR"
        Me.Btn_CLEAR.UseVisualStyleBackColor = False
        '
        'Lbl_Doctor_Name
        '
        Me.Lbl_Doctor_Name.AutoSize = True
        Me.Lbl_Doctor_Name.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Lbl_Doctor_Name.Font = New System.Drawing.Font("Bahnschrift Condensed", 20.25!, System.Drawing.FontStyle.Bold)
        Me.Lbl_Doctor_Name.ForeColor = System.Drawing.Color.Red
        Me.Lbl_Doctor_Name.Location = New System.Drawing.Point(550, 137)
        Me.Lbl_Doctor_Name.Name = "Lbl_Doctor_Name"
        Me.Lbl_Doctor_Name.Size = New System.Drawing.Size(128, 33)
        Me.Lbl_Doctor_Name.TabIndex = 195
        Me.Lbl_Doctor_Name.Text = "Doctor Name"
        '
        'Cmb_Select_Doctor
        '
        Me.Cmb_Select_Doctor.Enabled = False
        Me.Cmb_Select_Doctor.Font = New System.Drawing.Font("Bahnschrift Condensed", 20.25!, System.Drawing.FontStyle.Bold)
        Me.Cmb_Select_Doctor.FormattingEnabled = True
        Me.Cmb_Select_Doctor.Items.AddRange(New Object() {"A.A.Patil", "S.P.Bagal"})
        Me.Cmb_Select_Doctor.Location = New System.Drawing.Point(711, 137)
        Me.Cmb_Select_Doctor.Name = "Cmb_Select_Doctor"
        Me.Cmb_Select_Doctor.Size = New System.Drawing.Size(265, 41)
        Me.Cmb_Select_Doctor.TabIndex = 194
        '
        'Frm_Attend_Patient_Details
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1350, 729)
        Me.ControlBox = False
        Me.Controls.Add(Me.Lbl_Doctor_Name)
        Me.Controls.Add(Me.Cmb_Select_Doctor)
        Me.Controls.Add(Me.Tb_Patient_ID)
        Me.Controls.Add(Me.Btn_NEXT)
        Me.Controls.Add(Me.Btn_SEARCH)
        Me.Controls.Add(Me.Lbl_Patient_ID)
        Me.Controls.Add(Me.Dtp_Date)
        Me.Controls.Add(Me.Lbl_Date)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Gp_Patient_Details)
        Me.Controls.Add(Me.Btn_CLEAR)
        Me.Name = "Frm_Attend_Patient_Details"
        Me.Text = "Attend Patient Details"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Gp_Patient_Details.ResumeLayout(False)
        Me.Gp_Patient_Details.PerformLayout()
        Me.Gp_Gender.ResumeLayout(False)
        Me.Gp_Gender.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Tb_Patient_ID As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_Blood_Pressure As System.Windows.Forms.Label
    Friend WithEvents Btn_NEXT As System.Windows.Forms.Button
    Friend WithEvents Tb_Contact_No_2 As System.Windows.Forms.TextBox
    Friend WithEvents Btn_SEARCH As System.Windows.Forms.Button
    Friend WithEvents Tb_Contact_No_1 As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_Patient_ID As System.Windows.Forms.Label
    Friend WithEvents Lbl_Contact_No_2 As System.Windows.Forms.Label
    Friend WithEvents Dtp_Date As System.Windows.Forms.DateTimePicker
    Friend WithEvents Lbl_Appointment_Date As System.Windows.Forms.Label
    Friend WithEvents Lbl_Appointment_Time As System.Windows.Forms.Label
    Friend WithEvents Lbl_Date As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Lbl_Attend_Patient_Details As System.Windows.Forms.Label
    Friend WithEvents Lbl_Contact_No_1 As System.Windows.Forms.Label
    Friend WithEvents Tb_Address As System.Windows.Forms.TextBox
    Friend WithEvents Gp_Patient_Details As System.Windows.Forms.GroupBox
    Friend WithEvents Lbl_Gender As System.Windows.Forms.Label
    Friend WithEvents Lbl_Blood_Group As System.Windows.Forms.Label
    Friend WithEvents Tb_Age As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_Age As System.Windows.Forms.Label
    Friend WithEvents Tb_Last_Name As System.Windows.Forms.TextBox
    Friend WithEvents Tb_First_Name As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_Last_Name As System.Windows.Forms.Label
    Friend WithEvents Lbl_Address As System.Windows.Forms.Label
    Friend WithEvents Lbl_First_Name As System.Windows.Forms.Label
    Friend WithEvents Btn_CLEAR As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Lbl_Doctor_Name As System.Windows.Forms.Label
    Friend WithEvents Cmb_Select_Doctor As System.Windows.Forms.ComboBox
    Friend WithEvents Dtp_Appointment_Time As System.Windows.Forms.DateTimePicker
    Friend WithEvents Dtp_Appointment_Date As System.Windows.Forms.DateTimePicker
    Friend WithEvents Tb_Charges As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_Charges As System.Windows.Forms.Label
    Friend WithEvents Cmb_Blood_Group As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Cb_Low As System.Windows.Forms.CheckBox
    Friend WithEvents Cb_Normal As System.Windows.Forms.CheckBox
    Friend WithEvents Cb_High As System.Windows.Forms.CheckBox
    Friend WithEvents Gp_Gender As System.Windows.Forms.GroupBox
    Friend WithEvents Rb_Male As System.Windows.Forms.RadioButton
    Friend WithEvents Rb_Female As System.Windows.Forms.RadioButton
End Class
