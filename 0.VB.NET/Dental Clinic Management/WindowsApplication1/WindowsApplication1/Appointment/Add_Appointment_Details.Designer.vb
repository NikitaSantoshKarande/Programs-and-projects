<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Add_Appointment_Details
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Add_Appointment_Details))
        Me.Lbl_Blood_Pressure = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Lbl_Add_Appointment = New System.Windows.Forms.Label()
        Me.Dtp_Appointment_Time = New System.Windows.Forms.DateTimePicker()
        Me.Tb_Contact_No_2 = New System.Windows.Forms.TextBox()
        Me.Tb_Contact_No_1 = New System.Windows.Forms.TextBox()
        Me.Rb_Male = New System.Windows.Forms.RadioButton()
        Me.Lbl_Contact_No_2 = New System.Windows.Forms.Label()
        Me.Rb_Female = New System.Windows.Forms.RadioButton()
        Me.Lbl_Contact_No_1 = New System.Windows.Forms.Label()
        Me.Gp_Appointment_Form = New System.Windows.Forms.GroupBox()
        Me.Gp_Gender = New System.Windows.Forms.GroupBox()
        Me.Cmb_Blood_Group = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Cb_Low = New System.Windows.Forms.CheckBox()
        Me.Cb_Normal = New System.Windows.Forms.CheckBox()
        Me.Cb_High = New System.Windows.Forms.CheckBox()
        Me.Tb_Charges = New System.Windows.Forms.TextBox()
        Me.Lbl_Charges = New System.Windows.Forms.Label()
        Me.Btn_CLEAR = New System.Windows.Forms.Button()
        Me.Btn_SAVE = New System.Windows.Forms.Button()
        Me.Tb_Address = New System.Windows.Forms.TextBox()
        Me.Lbl_Gender = New System.Windows.Forms.Label()
        Me.Lbl_Blood_Group = New System.Windows.Forms.Label()
        Me.Tb_Age = New System.Windows.Forms.TextBox()
        Me.Dtp_Appointment_Date = New System.Windows.Forms.DateTimePicker()
        Me.Lbl_Age = New System.Windows.Forms.Label()
        Me.Lbl_Appointment_Date = New System.Windows.Forms.Label()
        Me.Lbl_Appointment_Time = New System.Windows.Forms.Label()
        Me.Tb_Last_Name = New System.Windows.Forms.TextBox()
        Me.Tb_First_Name = New System.Windows.Forms.TextBox()
        Me.Lbl_Last_Name = New System.Windows.Forms.Label()
        Me.Lbl_Address = New System.Windows.Forms.Label()
        Me.Lbl_First_Name = New System.Windows.Forms.Label()
        Me.Tb_Patient_ID = New System.Windows.Forms.TextBox()
        Me.Lbl_Date = New System.Windows.Forms.Label()
        Me.Lbl_Patient_ID = New System.Windows.Forms.Label()
        Me.Dtp_Date = New System.Windows.Forms.DateTimePicker()
        Me.Lbl_Select_Doctor = New System.Windows.Forms.Label()
        Me.Cmb_Select_Doctor = New System.Windows.Forms.ComboBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Gp_Appointment_Form.SuspendLayout()
        Me.Gp_Gender.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Lbl_Blood_Pressure
        '
        Me.Lbl_Blood_Pressure.AutoSize = True
        Me.Lbl_Blood_Pressure.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Lbl_Blood_Pressure.Font = New System.Drawing.Font("Rockwell Condensed", 18.0!)
        Me.Lbl_Blood_Pressure.ForeColor = System.Drawing.Color.Red
        Me.Lbl_Blood_Pressure.Location = New System.Drawing.Point(632, 381)
        Me.Lbl_Blood_Pressure.Name = "Lbl_Blood_Pressure"
        Me.Lbl_Blood_Pressure.Size = New System.Drawing.Size(126, 29)
        Me.Lbl_Blood_Pressure.TabIndex = 192
        Me.Lbl_Blood_Pressure.Text = "Blood Pressure"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Blue
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Lbl_Add_Appointment)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Font = New System.Drawing.Font("Rockwell Condensed", 18.0!)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1350, 92)
        Me.Panel1.TabIndex = 167
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
        'Lbl_Add_Appointment
        '
        Me.Lbl_Add_Appointment.AutoSize = True
        Me.Lbl_Add_Appointment.Font = New System.Drawing.Font("Rockwell Condensed", 48.0!, System.Drawing.FontStyle.Bold)
        Me.Lbl_Add_Appointment.ForeColor = System.Drawing.Color.LemonChiffon
        Me.Lbl_Add_Appointment.Image = CType(resources.GetObject("Lbl_Add_Appointment.Image"), System.Drawing.Image)
        Me.Lbl_Add_Appointment.Location = New System.Drawing.Point(537, 9)
        Me.Lbl_Add_Appointment.Name = "Lbl_Add_Appointment"
        Me.Lbl_Add_Appointment.Size = New System.Drawing.Size(500, 75)
        Me.Lbl_Add_Appointment.TabIndex = 63
        Me.Lbl_Add_Appointment.Text = "Add Appointment "
        '
        'Dtp_Appointment_Time
        '
        Me.Dtp_Appointment_Time.CalendarFont = New System.Drawing.Font("Rockwell Condensed", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Dtp_Appointment_Time.Font = New System.Drawing.Font("Rockwell Condensed", 18.0!)
        Me.Dtp_Appointment_Time.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.Dtp_Appointment_Time.Location = New System.Drawing.Point(810, 260)
        Me.Dtp_Appointment_Time.Name = "Dtp_Appointment_Time"
        Me.Dtp_Appointment_Time.Size = New System.Drawing.Size(267, 36)
        Me.Dtp_Appointment_Time.TabIndex = 13
        '
        'Tb_Contact_No_2
        '
        Me.Tb_Contact_No_2.Font = New System.Drawing.Font("Rockwell Condensed", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tb_Contact_No_2.Location = New System.Drawing.Point(235, 313)
        Me.Tb_Contact_No_2.MaxLength = 10
        Me.Tb_Contact_No_2.Name = "Tb_Contact_No_2"
        Me.Tb_Contact_No_2.Size = New System.Drawing.Size(267, 36)
        Me.Tb_Contact_No_2.TabIndex = 7
        '
        'Tb_Contact_No_1
        '
        Me.Tb_Contact_No_1.Font = New System.Drawing.Font("Rockwell Condensed", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tb_Contact_No_1.Location = New System.Drawing.Point(235, 260)
        Me.Tb_Contact_No_1.MaxLength = 10
        Me.Tb_Contact_No_1.Name = "Tb_Contact_No_1"
        Me.Tb_Contact_No_1.Size = New System.Drawing.Size(267, 36)
        Me.Tb_Contact_No_1.TabIndex = 6
        '
        'Rb_Male
        '
        Me.Rb_Male.AutoSize = True
        Me.Rb_Male.Font = New System.Drawing.Font("Rockwell Condensed", 18.0!)
        Me.Rb_Male.ForeColor = System.Drawing.Color.Black
        Me.Rb_Male.Location = New System.Drawing.Point(36, 31)
        Me.Rb_Male.Name = "Rb_Male"
        Me.Rb_Male.Size = New System.Drawing.Size(67, 33)
        Me.Rb_Male.TabIndex = 9
        Me.Rb_Male.Text = "Male"
        Me.Rb_Male.UseVisualStyleBackColor = True
        '
        'Lbl_Contact_No_2
        '
        Me.Lbl_Contact_No_2.AutoSize = True
        Me.Lbl_Contact_No_2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Lbl_Contact_No_2.Font = New System.Drawing.Font("Rockwell Condensed", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Contact_No_2.ForeColor = System.Drawing.Color.Red
        Me.Lbl_Contact_No_2.Location = New System.Drawing.Point(69, 316)
        Me.Lbl_Contact_No_2.Name = "Lbl_Contact_No_2"
        Me.Lbl_Contact_No_2.Size = New System.Drawing.Size(109, 29)
        Me.Lbl_Contact_No_2.TabIndex = 187
        Me.Lbl_Contact_No_2.Text = "Contact No.2"
        '
        'Rb_Female
        '
        Me.Rb_Female.AutoSize = True
        Me.Rb_Female.Font = New System.Drawing.Font("Rockwell Condensed", 18.0!)
        Me.Rb_Female.ForeColor = System.Drawing.Color.Black
        Me.Rb_Female.Location = New System.Drawing.Point(150, 31)
        Me.Rb_Female.Name = "Rb_Female"
        Me.Rb_Female.Size = New System.Drawing.Size(83, 33)
        Me.Rb_Female.TabIndex = 10
        Me.Rb_Female.Text = "Female"
        Me.Rb_Female.UseVisualStyleBackColor = True
        '
        'Lbl_Contact_No_1
        '
        Me.Lbl_Contact_No_1.AutoSize = True
        Me.Lbl_Contact_No_1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Lbl_Contact_No_1.Font = New System.Drawing.Font("Rockwell Condensed", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Contact_No_1.ForeColor = System.Drawing.Color.Red
        Me.Lbl_Contact_No_1.Location = New System.Drawing.Point(69, 263)
        Me.Lbl_Contact_No_1.Name = "Lbl_Contact_No_1"
        Me.Lbl_Contact_No_1.Size = New System.Drawing.Size(109, 29)
        Me.Lbl_Contact_No_1.TabIndex = 186
        Me.Lbl_Contact_No_1.Text = "Contact No.1"
        '
        'Gp_Appointment_Form
        '
        Me.Gp_Appointment_Form.Controls.Add(Me.Gp_Gender)
        Me.Gp_Appointment_Form.Controls.Add(Me.Cmb_Blood_Group)
        Me.Gp_Appointment_Form.Controls.Add(Me.GroupBox1)
        Me.Gp_Appointment_Form.Controls.Add(Me.Tb_Charges)
        Me.Gp_Appointment_Form.Controls.Add(Me.Lbl_Charges)
        Me.Gp_Appointment_Form.Controls.Add(Me.Btn_CLEAR)
        Me.Gp_Appointment_Form.Controls.Add(Me.Btn_SAVE)
        Me.Gp_Appointment_Form.Controls.Add(Me.Lbl_Blood_Pressure)
        Me.Gp_Appointment_Form.Controls.Add(Me.Dtp_Appointment_Time)
        Me.Gp_Appointment_Form.Controls.Add(Me.Tb_Contact_No_2)
        Me.Gp_Appointment_Form.Controls.Add(Me.Tb_Contact_No_1)
        Me.Gp_Appointment_Form.Controls.Add(Me.Lbl_Contact_No_2)
        Me.Gp_Appointment_Form.Controls.Add(Me.Lbl_Contact_No_1)
        Me.Gp_Appointment_Form.Controls.Add(Me.Tb_Address)
        Me.Gp_Appointment_Form.Controls.Add(Me.Lbl_Gender)
        Me.Gp_Appointment_Form.Controls.Add(Me.Lbl_Blood_Group)
        Me.Gp_Appointment_Form.Controls.Add(Me.Tb_Age)
        Me.Gp_Appointment_Form.Controls.Add(Me.Dtp_Appointment_Date)
        Me.Gp_Appointment_Form.Controls.Add(Me.Lbl_Age)
        Me.Gp_Appointment_Form.Controls.Add(Me.Lbl_Appointment_Date)
        Me.Gp_Appointment_Form.Controls.Add(Me.Lbl_Appointment_Time)
        Me.Gp_Appointment_Form.Controls.Add(Me.Tb_Last_Name)
        Me.Gp_Appointment_Form.Controls.Add(Me.Tb_First_Name)
        Me.Gp_Appointment_Form.Controls.Add(Me.Lbl_Last_Name)
        Me.Gp_Appointment_Form.Controls.Add(Me.Lbl_Address)
        Me.Gp_Appointment_Form.Controls.Add(Me.Lbl_First_Name)
        Me.Gp_Appointment_Form.Font = New System.Drawing.Font("Rockwell Condensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Gp_Appointment_Form.Location = New System.Drawing.Point(83, 189)
        Me.Gp_Appointment_Form.Name = "Gp_Appointment_Form"
        Me.Gp_Appointment_Form.Size = New System.Drawing.Size(1134, 516)
        Me.Gp_Appointment_Form.TabIndex = 173
        Me.Gp_Appointment_Form.TabStop = False
        Me.Gp_Appointment_Form.Text = "Appointment Form"
        '
        'Gp_Gender
        '
        Me.Gp_Gender.Controls.Add(Me.Rb_Male)
        Me.Gp_Gender.Controls.Add(Me.Rb_Female)
        Me.Gp_Gender.Location = New System.Drawing.Point(810, 32)
        Me.Gp_Gender.Name = "Gp_Gender"
        Me.Gp_Gender.Size = New System.Drawing.Size(267, 78)
        Me.Gp_Gender.TabIndex = 976
        Me.Gp_Gender.TabStop = False
        '
        'Cmb_Blood_Group
        '
        Me.Cmb_Blood_Group.Font = New System.Drawing.Font("Rockwell Condensed", 18.0!)
        Me.Cmb_Blood_Group.FormattingEnabled = True
        Me.Cmb_Blood_Group.Items.AddRange(New Object() {"A+", "B+", "C+", "D+", "O+", "O-"})
        Me.Cmb_Blood_Group.Location = New System.Drawing.Point(810, 116)
        Me.Cmb_Blood_Group.Name = "Cmb_Blood_Group"
        Me.Cmb_Blood_Group.Size = New System.Drawing.Size(265, 37)
        Me.Cmb_Blood_Group.TabIndex = 11
        Me.Cmb_Blood_Group.Text = "Select Blood Group"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Cb_Low)
        Me.GroupBox1.Controls.Add(Me.Cb_Normal)
        Me.GroupBox1.Controls.Add(Me.Cb_High)
        Me.GroupBox1.Location = New System.Drawing.Point(811, 358)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(317, 80)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        '
        'Cb_Low
        '
        Me.Cb_Low.AutoSize = True
        Me.Cb_Low.Location = New System.Drawing.Point(19, 31)
        Me.Cb_Low.Name = "Cb_Low"
        Me.Cb_Low.Size = New System.Drawing.Size(58, 29)
        Me.Cb_Low.TabIndex = 15
        Me.Cb_Low.Text = "Low"
        Me.Cb_Low.UseVisualStyleBackColor = True
        '
        'Cb_Normal
        '
        Me.Cb_Normal.AutoSize = True
        Me.Cb_Normal.Location = New System.Drawing.Point(103, 31)
        Me.Cb_Normal.Name = "Cb_Normal"
        Me.Cb_Normal.Size = New System.Drawing.Size(78, 29)
        Me.Cb_Normal.TabIndex = 16
        Me.Cb_Normal.Text = "Normal"
        Me.Cb_Normal.UseVisualStyleBackColor = True
        '
        'Cb_High
        '
        Me.Cb_High.AutoSize = True
        Me.Cb_High.Location = New System.Drawing.Point(204, 31)
        Me.Cb_High.Name = "Cb_High"
        Me.Cb_High.Size = New System.Drawing.Size(62, 29)
        Me.Cb_High.TabIndex = 17
        Me.Cb_High.Text = "High"
        Me.Cb_High.UseVisualStyleBackColor = True
        '
        'Tb_Charges
        '
        Me.Tb_Charges.Font = New System.Drawing.Font("Rockwell Condensed", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tb_Charges.Location = New System.Drawing.Point(810, 316)
        Me.Tb_Charges.Name = "Tb_Charges"
        Me.Tb_Charges.Size = New System.Drawing.Size(267, 36)
        Me.Tb_Charges.TabIndex = 14
        '
        'Lbl_Charges
        '
        Me.Lbl_Charges.AutoSize = True
        Me.Lbl_Charges.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Lbl_Charges.Font = New System.Drawing.Font("Rockwell Condensed", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Charges.ForeColor = System.Drawing.Color.Red
        Me.Lbl_Charges.Location = New System.Drawing.Point(632, 320)
        Me.Lbl_Charges.Name = "Lbl_Charges"
        Me.Lbl_Charges.Size = New System.Drawing.Size(73, 29)
        Me.Lbl_Charges.TabIndex = 195
        Me.Lbl_Charges.Text = "Charges"
        '
        'Btn_CLEAR
        '
        Me.Btn_CLEAR.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Btn_CLEAR.Font = New System.Drawing.Font("Rockwell", 21.75!, System.Drawing.FontStyle.Bold)
        Me.Btn_CLEAR.ForeColor = System.Drawing.SystemColors.Control
        Me.Btn_CLEAR.Location = New System.Drawing.Point(811, 458)
        Me.Btn_CLEAR.Name = "Btn_CLEAR"
        Me.Btn_CLEAR.Size = New System.Drawing.Size(144, 52)
        Me.Btn_CLEAR.TabIndex = 19
        Me.Btn_CLEAR.Text = "CLEAR"
        Me.Btn_CLEAR.UseVisualStyleBackColor = False
        '
        'Btn_SAVE
        '
        Me.Btn_SAVE.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Btn_SAVE.Font = New System.Drawing.Font("Rockwell", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_SAVE.ForeColor = System.Drawing.Color.Cornsilk
        Me.Btn_SAVE.Location = New System.Drawing.Point(321, 458)
        Me.Btn_SAVE.Name = "Btn_SAVE"
        Me.Btn_SAVE.Size = New System.Drawing.Size(144, 50)
        Me.Btn_SAVE.TabIndex = 18
        Me.Btn_SAVE.Text = "SAVE"
        Me.Btn_SAVE.UseVisualStyleBackColor = False
        '
        'Tb_Address
        '
        Me.Tb_Address.Font = New System.Drawing.Font("Rockwell Condensed", 18.0!)
        Me.Tb_Address.Location = New System.Drawing.Point(235, 149)
        Me.Tb_Address.Multiline = True
        Me.Tb_Address.Name = "Tb_Address"
        Me.Tb_Address.Size = New System.Drawing.Size(267, 85)
        Me.Tb_Address.TabIndex = 5
        '
        'Lbl_Gender
        '
        Me.Lbl_Gender.AutoSize = True
        Me.Lbl_Gender.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Lbl_Gender.Font = New System.Drawing.Font("Rockwell Condensed", 18.0!)
        Me.Lbl_Gender.ForeColor = System.Drawing.Color.Red
        Me.Lbl_Gender.Location = New System.Drawing.Point(632, 49)
        Me.Lbl_Gender.Name = "Lbl_Gender"
        Me.Lbl_Gender.Size = New System.Drawing.Size(64, 29)
        Me.Lbl_Gender.TabIndex = 183
        Me.Lbl_Gender.Text = "Gender"
        '
        'Lbl_Blood_Group
        '
        Me.Lbl_Blood_Group.AutoSize = True
        Me.Lbl_Blood_Group.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Lbl_Blood_Group.Font = New System.Drawing.Font("Rockwell Condensed", 18.0!)
        Me.Lbl_Blood_Group.ForeColor = System.Drawing.Color.Red
        Me.Lbl_Blood_Group.Location = New System.Drawing.Point(632, 116)
        Me.Lbl_Blood_Group.Name = "Lbl_Blood_Group"
        Me.Lbl_Blood_Group.Size = New System.Drawing.Size(104, 29)
        Me.Lbl_Blood_Group.TabIndex = 181
        Me.Lbl_Blood_Group.Text = "Blood Group"
        '
        'Tb_Age
        '
        Me.Tb_Age.Font = New System.Drawing.Font("Rockwell Condensed", 18.0!)
        Me.Tb_Age.Location = New System.Drawing.Point(235, 381)
        Me.Tb_Age.MaxLength = 3
        Me.Tb_Age.Name = "Tb_Age"
        Me.Tb_Age.Size = New System.Drawing.Size(267, 36)
        Me.Tb_Age.TabIndex = 8
        '
        'Dtp_Appointment_Date
        '
        Me.Dtp_Appointment_Date.CalendarFont = New System.Drawing.Font("Rockwell Condensed", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Dtp_Appointment_Date.Font = New System.Drawing.Font("Rockwell Condensed", 18.0!)
        Me.Dtp_Appointment_Date.Location = New System.Drawing.Point(811, 189)
        Me.Dtp_Appointment_Date.Name = "Dtp_Appointment_Date"
        Me.Dtp_Appointment_Date.Size = New System.Drawing.Size(267, 36)
        Me.Dtp_Appointment_Date.TabIndex = 12
        '
        'Lbl_Age
        '
        Me.Lbl_Age.AutoSize = True
        Me.Lbl_Age.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Lbl_Age.Font = New System.Drawing.Font("Rockwell Condensed", 18.0!)
        Me.Lbl_Age.ForeColor = System.Drawing.Color.Red
        Me.Lbl_Age.Location = New System.Drawing.Point(69, 381)
        Me.Lbl_Age.Name = "Lbl_Age"
        Me.Lbl_Age.Size = New System.Drawing.Size(41, 29)
        Me.Lbl_Age.TabIndex = 178
        Me.Lbl_Age.Text = "Age"
        '
        'Lbl_Appointment_Date
        '
        Me.Lbl_Appointment_Date.AutoSize = True
        Me.Lbl_Appointment_Date.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Lbl_Appointment_Date.Font = New System.Drawing.Font("Rockwell Condensed", 18.0!)
        Me.Lbl_Appointment_Date.ForeColor = System.Drawing.Color.Red
        Me.Lbl_Appointment_Date.Location = New System.Drawing.Point(623, 189)
        Me.Lbl_Appointment_Date.Name = "Lbl_Appointment_Date"
        Me.Lbl_Appointment_Date.Size = New System.Drawing.Size(156, 29)
        Me.Lbl_Appointment_Date.TabIndex = 177
        Me.Lbl_Appointment_Date.Text = " Appointment Date"
        '
        'Lbl_Appointment_Time
        '
        Me.Lbl_Appointment_Time.AutoSize = True
        Me.Lbl_Appointment_Time.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Lbl_Appointment_Time.Font = New System.Drawing.Font("Rockwell Condensed", 18.0!)
        Me.Lbl_Appointment_Time.ForeColor = System.Drawing.Color.Red
        Me.Lbl_Appointment_Time.Location = New System.Drawing.Point(621, 260)
        Me.Lbl_Appointment_Time.Name = "Lbl_Appointment_Time"
        Me.Lbl_Appointment_Time.Size = New System.Drawing.Size(158, 29)
        Me.Lbl_Appointment_Time.TabIndex = 176
        Me.Lbl_Appointment_Time.Text = " Appointment Time"
        '
        'Tb_Last_Name
        '
        Me.Tb_Last_Name.Font = New System.Drawing.Font("Rockwell Condensed", 18.0!)
        Me.Tb_Last_Name.Location = New System.Drawing.Point(235, 91)
        Me.Tb_Last_Name.Name = "Tb_Last_Name"
        Me.Tb_Last_Name.Size = New System.Drawing.Size(267, 36)
        Me.Tb_Last_Name.TabIndex = 4
        '
        'Tb_First_Name
        '
        Me.Tb_First_Name.Font = New System.Drawing.Font("Rockwell Condensed", 18.0!)
        Me.Tb_First_Name.Location = New System.Drawing.Point(235, 29)
        Me.Tb_First_Name.Name = "Tb_First_Name"
        Me.Tb_First_Name.Size = New System.Drawing.Size(267, 36)
        Me.Tb_First_Name.TabIndex = 3
        '
        'Lbl_Last_Name
        '
        Me.Lbl_Last_Name.AutoSize = True
        Me.Lbl_Last_Name.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Lbl_Last_Name.Font = New System.Drawing.Font("Rockwell Condensed", 18.0!)
        Me.Lbl_Last_Name.ForeColor = System.Drawing.Color.Red
        Me.Lbl_Last_Name.Location = New System.Drawing.Point(69, 91)
        Me.Lbl_Last_Name.Name = "Lbl_Last_Name"
        Me.Lbl_Last_Name.Size = New System.Drawing.Size(94, 29)
        Me.Lbl_Last_Name.TabIndex = 173
        Me.Lbl_Last_Name.Text = "Last Name"
        '
        'Lbl_Address
        '
        Me.Lbl_Address.AutoSize = True
        Me.Lbl_Address.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Lbl_Address.Font = New System.Drawing.Font("Rockwell Condensed", 18.0!)
        Me.Lbl_Address.ForeColor = System.Drawing.Color.Red
        Me.Lbl_Address.Location = New System.Drawing.Point(69, 147)
        Me.Lbl_Address.Name = "Lbl_Address"
        Me.Lbl_Address.Size = New System.Drawing.Size(73, 29)
        Me.Lbl_Address.TabIndex = 171
        Me.Lbl_Address.Text = "Address"
        '
        'Lbl_First_Name
        '
        Me.Lbl_First_Name.AutoSize = True
        Me.Lbl_First_Name.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Lbl_First_Name.Font = New System.Drawing.Font("Rockwell Condensed", 18.0!)
        Me.Lbl_First_Name.ForeColor = System.Drawing.Color.Red
        Me.Lbl_First_Name.Location = New System.Drawing.Point(69, 32)
        Me.Lbl_First_Name.Name = "Lbl_First_Name"
        Me.Lbl_First_Name.Size = New System.Drawing.Size(97, 29)
        Me.Lbl_First_Name.TabIndex = 172
        Me.Lbl_First_Name.Text = "First Name"
        '
        'Tb_Patient_ID
        '
        Me.Tb_Patient_ID.Enabled = False
        Me.Tb_Patient_ID.Font = New System.Drawing.Font("Rockwell Condensed", 18.0!)
        Me.Tb_Patient_ID.Location = New System.Drawing.Point(248, 123)
        Me.Tb_Patient_ID.Name = "Tb_Patient_ID"
        Me.Tb_Patient_ID.Size = New System.Drawing.Size(254, 36)
        Me.Tb_Patient_ID.TabIndex = 164
        '
        'Lbl_Date
        '
        Me.Lbl_Date.AutoSize = True
        Me.Lbl_Date.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Lbl_Date.Font = New System.Drawing.Font("Rockwell Condensed", 18.0!)
        Me.Lbl_Date.ForeColor = System.Drawing.Color.Red
        Me.Lbl_Date.Location = New System.Drawing.Point(924, 122)
        Me.Lbl_Date.Name = "Lbl_Date"
        Me.Lbl_Date.Size = New System.Drawing.Size(47, 29)
        Me.Lbl_Date.TabIndex = 171
        Me.Lbl_Date.Text = "Date"
        '
        'Lbl_Patient_ID
        '
        Me.Lbl_Patient_ID.AutoSize = True
        Me.Lbl_Patient_ID.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Lbl_Patient_ID.Font = New System.Drawing.Font("Rockwell Condensed", 18.0!)
        Me.Lbl_Patient_ID.ForeColor = System.Drawing.Color.Red
        Me.Lbl_Patient_ID.Location = New System.Drawing.Point(125, 122)
        Me.Lbl_Patient_ID.Name = "Lbl_Patient_ID"
        Me.Lbl_Patient_ID.Size = New System.Drawing.Size(91, 29)
        Me.Lbl_Patient_ID.TabIndex = 169
        Me.Lbl_Patient_ID.Text = "Patient ID"
        '
        'Dtp_Date
        '
        Me.Dtp_Date.CalendarFont = New System.Drawing.Font("Rockwell Condensed", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Dtp_Date.Enabled = False
        Me.Dtp_Date.Font = New System.Drawing.Font("Rockwell Condensed", 18.0!)
        Me.Dtp_Date.Location = New System.Drawing.Point(977, 122)
        Me.Dtp_Date.Name = "Dtp_Date"
        Me.Dtp_Date.Size = New System.Drawing.Size(267, 36)
        Me.Dtp_Date.TabIndex = 172
        '
        'Lbl_Select_Doctor
        '
        Me.Lbl_Select_Doctor.AutoSize = True
        Me.Lbl_Select_Doctor.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Lbl_Select_Doctor.Font = New System.Drawing.Font("Rockwell Condensed", 18.0!)
        Me.Lbl_Select_Doctor.ForeColor = System.Drawing.Color.Red
        Me.Lbl_Select_Doctor.Location = New System.Drawing.Point(519, 122)
        Me.Lbl_Select_Doctor.Name = "Lbl_Select_Doctor"
        Me.Lbl_Select_Doctor.Size = New System.Drawing.Size(113, 29)
        Me.Lbl_Select_Doctor.TabIndex = 170
        Me.Lbl_Select_Doctor.Text = "Select Doctor"
        '
        'Cmb_Select_Doctor
        '
        Me.Cmb_Select_Doctor.Font = New System.Drawing.Font("Rockwell Condensed", 18.0!)
        Me.Cmb_Select_Doctor.FormattingEnabled = True
        Me.Cmb_Select_Doctor.Items.AddRange(New Object() {"A.A.Patil", "S.P.Bagal"})
        Me.Cmb_Select_Doctor.Location = New System.Drawing.Point(638, 123)
        Me.Cmb_Select_Doctor.Name = "Cmb_Select_Doctor"
        Me.Cmb_Select_Doctor.Size = New System.Drawing.Size(265, 37)
        Me.Cmb_Select_Doctor.TabIndex = 165
        '
        'Frm_Add_Appointment_Details
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1350, 729)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Gp_Appointment_Form)
        Me.Controls.Add(Me.Tb_Patient_ID)
        Me.Controls.Add(Me.Lbl_Date)
        Me.Controls.Add(Me.Lbl_Patient_ID)
        Me.Controls.Add(Me.Dtp_Date)
        Me.Controls.Add(Me.Lbl_Select_Doctor)
        Me.Controls.Add(Me.Cmb_Select_Doctor)
        Me.MinimizeBox = False
        Me.Name = "Frm_Add_Appointment_Details"
        Me.Text = "Add Appointment Details"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Gp_Appointment_Form.ResumeLayout(False)
        Me.Gp_Appointment_Form.PerformLayout()
        Me.Gp_Gender.ResumeLayout(False)
        Me.Gp_Gender.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Lbl_Blood_Pressure As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Lbl_Add_Appointment As System.Windows.Forms.Label
    Friend WithEvents Dtp_Appointment_Time As System.Windows.Forms.DateTimePicker
    Friend WithEvents Tb_Contact_No_2 As System.Windows.Forms.TextBox
    Friend WithEvents Tb_Contact_No_1 As System.Windows.Forms.TextBox
    Friend WithEvents Rb_Male As System.Windows.Forms.RadioButton
    Friend WithEvents Lbl_Contact_No_2 As System.Windows.Forms.Label
    Friend WithEvents Rb_Female As System.Windows.Forms.RadioButton
    Friend WithEvents Lbl_Contact_No_1 As System.Windows.Forms.Label
    Friend WithEvents Gp_Appointment_Form As System.Windows.Forms.GroupBox
    Friend WithEvents Tb_Address As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_Gender As System.Windows.Forms.Label
    Friend WithEvents Lbl_Blood_Group As System.Windows.Forms.Label
    Friend WithEvents Tb_Age As System.Windows.Forms.TextBox
    Friend WithEvents Dtp_Appointment_Date As System.Windows.Forms.DateTimePicker
    Friend WithEvents Lbl_Age As System.Windows.Forms.Label
    Friend WithEvents Lbl_Appointment_Date As System.Windows.Forms.Label
    Friend WithEvents Lbl_Appointment_Time As System.Windows.Forms.Label
    Friend WithEvents Tb_Last_Name As System.Windows.Forms.TextBox
    Friend WithEvents Tb_First_Name As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_Last_Name As System.Windows.Forms.Label
    Friend WithEvents Lbl_Address As System.Windows.Forms.Label
    Friend WithEvents Lbl_First_Name As System.Windows.Forms.Label
    Friend WithEvents Tb_Patient_ID As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_Date As System.Windows.Forms.Label
    Friend WithEvents Lbl_Patient_ID As System.Windows.Forms.Label
    Friend WithEvents Dtp_Date As System.Windows.Forms.DateTimePicker
    Friend WithEvents Lbl_Select_Doctor As System.Windows.Forms.Label
    Friend WithEvents Cmb_Select_Doctor As System.Windows.Forms.ComboBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Btn_CLEAR As System.Windows.Forms.Button
    Friend WithEvents Btn_SAVE As System.Windows.Forms.Button
    Friend WithEvents Tb_Charges As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_Charges As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Cb_Low As System.Windows.Forms.CheckBox
    Friend WithEvents Cb_Normal As System.Windows.Forms.CheckBox
    Friend WithEvents Cb_High As System.Windows.Forms.CheckBox
    Friend WithEvents Cmb_Blood_Group As System.Windows.Forms.ComboBox
    Friend WithEvents Gp_Gender As System.Windows.Forms.GroupBox
End Class
