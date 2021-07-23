<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Search_Patient_Details
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Search_Patient_Details))
        Me.Dtp_Time = New System.Windows.Forms.DateTimePicker()
        Me.Dtp_Date_Of_Birth = New System.Windows.Forms.DateTimePicker()
        Me.Lbl_Appointment_Time = New System.Windows.Forms.Label()
        Me.Lbl_Search_Patient_Details = New System.Windows.Forms.Label()
        Me.Lbl_Appointment_Date = New System.Windows.Forms.Label()
        Me.Gp_Gender = New System.Windows.Forms.GroupBox()
        Me.Rb_Male = New System.Windows.Forms.RadioButton()
        Me.Rb_Female = New System.Windows.Forms.RadioButton()
        Me.Tb_Blood_Pressure = New System.Windows.Forms.TextBox()
        Me.Dtp_Date = New System.Windows.Forms.DateTimePicker()
        Me.Tb_Suger = New System.Windows.Forms.TextBox()
        Me.Lbl_Blood_Pressure = New System.Windows.Forms.Label()
        Me.Lbl_Suger = New System.Windows.Forms.Label()
        Me.Lbl_Date = New System.Windows.Forms.Label()
        Me.Tb_Contact_No_2 = New System.Windows.Forms.TextBox()
        Me.Tb_Contact_No_1 = New System.Windows.Forms.TextBox()
        Me.Lbl_Contact_No_2 = New System.Windows.Forms.Label()
        Me.Lbl_Contact_No_1 = New System.Windows.Forms.Label()
        Me.Tb_Address = New System.Windows.Forms.TextBox()
        Me.Tb_Patient_ID = New System.Windows.Forms.TextBox()
        Me.Lbl_Gender = New System.Windows.Forms.Label()
        Me.Tb_Blood_Group = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Lbl_Patient_ID = New System.Windows.Forms.Label()
        Me.Lbl_Blood_Group = New System.Windows.Forms.Label()
        Me.Tb_Age = New System.Windows.Forms.TextBox()
        Me.Lbl_Age = New System.Windows.Forms.Label()
        Me.Gp_Patient_Details = New System.Windows.Forms.GroupBox()
        Me.Tb_Last_Name = New System.Windows.Forms.TextBox()
        Me.Tb_First_Name = New System.Windows.Forms.TextBox()
        Me.Lbl_Last_Name = New System.Windows.Forms.Label()
        Me.Lbl_Address = New System.Windows.Forms.Label()
        Me.Lbl_First_Name = New System.Windows.Forms.Label()
        Me.Btn_SEARCH = New System.Windows.Forms.Button()
        Me.Btn_CLEAR = New System.Windows.Forms.Button()
        Me.Gp_Gender.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Gp_Patient_Details.SuspendLayout()
        Me.SuspendLayout()
        '
        'Dtp_Time
        '
        Me.Dtp_Time.CalendarFont = New System.Drawing.Font("Rockwell Condensed", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Dtp_Time.Enabled = False
        Me.Dtp_Time.Font = New System.Drawing.Font("Rockwell Condensed", 18.0!)
        Me.Dtp_Time.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.Dtp_Time.Location = New System.Drawing.Point(811, 250)
        Me.Dtp_Time.Name = "Dtp_Time"
        Me.Dtp_Time.Size = New System.Drawing.Size(267, 36)
        Me.Dtp_Time.TabIndex = 199
        '
        'Dtp_Date_Of_Birth
        '
        Me.Dtp_Date_Of_Birth.CalendarFont = New System.Drawing.Font("Rockwell Condensed", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Dtp_Date_Of_Birth.Enabled = False
        Me.Dtp_Date_Of_Birth.Font = New System.Drawing.Font("Rockwell Condensed", 18.0!)
        Me.Dtp_Date_Of_Birth.Location = New System.Drawing.Point(811, 176)
        Me.Dtp_Date_Of_Birth.Name = "Dtp_Date_Of_Birth"
        Me.Dtp_Date_Of_Birth.Size = New System.Drawing.Size(267, 36)
        Me.Dtp_Date_Of_Birth.TabIndex = 198
        '
        'Lbl_Appointment_Time
        '
        Me.Lbl_Appointment_Time.AutoSize = True
        Me.Lbl_Appointment_Time.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Lbl_Appointment_Time.Font = New System.Drawing.Font("Rockwell Condensed", 18.0!)
        Me.Lbl_Appointment_Time.ForeColor = System.Drawing.Color.Red
        Me.Lbl_Appointment_Time.Location = New System.Drawing.Point(622, 247)
        Me.Lbl_Appointment_Time.Name = "Lbl_Appointment_Time"
        Me.Lbl_Appointment_Time.Size = New System.Drawing.Size(158, 29)
        Me.Lbl_Appointment_Time.TabIndex = 196
        Me.Lbl_Appointment_Time.Text = " Appointment Time"
        '
        'Lbl_Search_Patient_Details
        '
        Me.Lbl_Search_Patient_Details.AutoSize = True
        Me.Lbl_Search_Patient_Details.Font = New System.Drawing.Font("Rockwell Condensed", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Search_Patient_Details.ForeColor = System.Drawing.Color.LemonChiffon
        Me.Lbl_Search_Patient_Details.Image = CType(resources.GetObject("Lbl_Search_Patient_Details.Image"), System.Drawing.Image)
        Me.Lbl_Search_Patient_Details.Location = New System.Drawing.Point(457, 9)
        Me.Lbl_Search_Patient_Details.Name = "Lbl_Search_Patient_Details"
        Me.Lbl_Search_Patient_Details.Size = New System.Drawing.Size(620, 75)
        Me.Lbl_Search_Patient_Details.TabIndex = 63
        Me.Lbl_Search_Patient_Details.Text = "Search Patient Details "
        '
        'Lbl_Appointment_Date
        '
        Me.Lbl_Appointment_Date.AutoSize = True
        Me.Lbl_Appointment_Date.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Lbl_Appointment_Date.Font = New System.Drawing.Font("Rockwell Condensed", 18.0!)
        Me.Lbl_Appointment_Date.ForeColor = System.Drawing.Color.Red
        Me.Lbl_Appointment_Date.Location = New System.Drawing.Point(624, 176)
        Me.Lbl_Appointment_Date.Name = "Lbl_Appointment_Date"
        Me.Lbl_Appointment_Date.Size = New System.Drawing.Size(156, 29)
        Me.Lbl_Appointment_Date.TabIndex = 197
        Me.Lbl_Appointment_Date.Text = " Appointment Date"
        '
        'Gp_Gender
        '
        Me.Gp_Gender.Controls.Add(Me.Rb_Male)
        Me.Gp_Gender.Controls.Add(Me.Rb_Female)
        Me.Gp_Gender.Enabled = False
        Me.Gp_Gender.Font = New System.Drawing.Font("Rockwell Condensed", 18.0!)
        Me.Gp_Gender.Location = New System.Drawing.Point(811, 22)
        Me.Gp_Gender.Name = "Gp_Gender"
        Me.Gp_Gender.Size = New System.Drawing.Size(267, 78)
        Me.Gp_Gender.TabIndex = 195
        Me.Gp_Gender.TabStop = False
        '
        'Rb_Male
        '
        Me.Rb_Male.AutoSize = True
        Me.Rb_Male.Font = New System.Drawing.Font("Rockwell Condensed", 18.0!)
        Me.Rb_Male.ForeColor = System.Drawing.Color.Black
        Me.Rb_Male.Location = New System.Drawing.Point(35, 28)
        Me.Rb_Male.Name = "Rb_Male"
        Me.Rb_Male.Size = New System.Drawing.Size(67, 33)
        Me.Rb_Male.TabIndex = 94
        Me.Rb_Male.TabStop = True
        Me.Rb_Male.Text = "Male"
        Me.Rb_Male.UseVisualStyleBackColor = True
        '
        'Rb_Female
        '
        Me.Rb_Female.AutoSize = True
        Me.Rb_Female.Font = New System.Drawing.Font("Rockwell Condensed", 18.0!)
        Me.Rb_Female.ForeColor = System.Drawing.Color.Black
        Me.Rb_Female.Location = New System.Drawing.Point(149, 28)
        Me.Rb_Female.Name = "Rb_Female"
        Me.Rb_Female.Size = New System.Drawing.Size(83, 33)
        Me.Rb_Female.TabIndex = 97
        Me.Rb_Female.TabStop = True
        Me.Rb_Female.Text = "Female"
        Me.Rb_Female.UseVisualStyleBackColor = True
        '
        'Tb_Blood_Pressure
        '
        Me.Tb_Blood_Pressure.Enabled = False
        Me.Tb_Blood_Pressure.Font = New System.Drawing.Font("Rockwell Condensed", 18.0!)
        Me.Tb_Blood_Pressure.Location = New System.Drawing.Point(811, 382)
        Me.Tb_Blood_Pressure.Name = "Tb_Blood_Pressure"
        Me.Tb_Blood_Pressure.Size = New System.Drawing.Size(267, 36)
        Me.Tb_Blood_Pressure.TabIndex = 194
        '
        'Dtp_Date
        '
        Me.Dtp_Date.CalendarFont = New System.Drawing.Font("Rockwell Condensed", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Dtp_Date.Font = New System.Drawing.Font("Rockwell Condensed", 18.0!)
        Me.Dtp_Date.Location = New System.Drawing.Point(894, 116)
        Me.Dtp_Date.Name = "Dtp_Date"
        Me.Dtp_Date.Size = New System.Drawing.Size(267, 36)
        Me.Dtp_Date.TabIndex = 197
        '
        'Tb_Suger
        '
        Me.Tb_Suger.Enabled = False
        Me.Tb_Suger.Font = New System.Drawing.Font("Rockwell Condensed", 18.0!)
        Me.Tb_Suger.Location = New System.Drawing.Point(811, 317)
        Me.Tb_Suger.Name = "Tb_Suger"
        Me.Tb_Suger.Size = New System.Drawing.Size(267, 36)
        Me.Tb_Suger.TabIndex = 193
        '
        'Lbl_Blood_Pressure
        '
        Me.Lbl_Blood_Pressure.AutoSize = True
        Me.Lbl_Blood_Pressure.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Lbl_Blood_Pressure.Font = New System.Drawing.Font("Rockwell Condensed", 18.0!)
        Me.Lbl_Blood_Pressure.ForeColor = System.Drawing.Color.Red
        Me.Lbl_Blood_Pressure.Location = New System.Drawing.Point(633, 382)
        Me.Lbl_Blood_Pressure.Name = "Lbl_Blood_Pressure"
        Me.Lbl_Blood_Pressure.Size = New System.Drawing.Size(126, 29)
        Me.Lbl_Blood_Pressure.TabIndex = 192
        Me.Lbl_Blood_Pressure.Text = "Blood Pressure"
        '
        'Lbl_Suger
        '
        Me.Lbl_Suger.AutoSize = True
        Me.Lbl_Suger.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Lbl_Suger.Font = New System.Drawing.Font("Rockwell Condensed", 18.0!)
        Me.Lbl_Suger.ForeColor = System.Drawing.Color.Red
        Me.Lbl_Suger.Location = New System.Drawing.Point(633, 317)
        Me.Lbl_Suger.Name = "Lbl_Suger"
        Me.Lbl_Suger.Size = New System.Drawing.Size(55, 29)
        Me.Lbl_Suger.TabIndex = 191
        Me.Lbl_Suger.Text = "Suger"
        '
        'Lbl_Date
        '
        Me.Lbl_Date.AutoSize = True
        Me.Lbl_Date.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Lbl_Date.Font = New System.Drawing.Font("Rockwell Condensed", 18.0!)
        Me.Lbl_Date.ForeColor = System.Drawing.Color.Red
        Me.Lbl_Date.Location = New System.Drawing.Point(759, 119)
        Me.Lbl_Date.Name = "Lbl_Date"
        Me.Lbl_Date.Size = New System.Drawing.Size(47, 29)
        Me.Lbl_Date.TabIndex = 196
        Me.Lbl_Date.Text = "Date"
        '
        'Tb_Contact_No_2
        '
        Me.Tb_Contact_No_2.Enabled = False
        Me.Tb_Contact_No_2.Font = New System.Drawing.Font("Rockwell Condensed", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tb_Contact_No_2.Location = New System.Drawing.Point(213, 324)
        Me.Tb_Contact_No_2.Name = "Tb_Contact_No_2"
        Me.Tb_Contact_No_2.Size = New System.Drawing.Size(267, 36)
        Me.Tb_Contact_No_2.TabIndex = 189
        '
        'Tb_Contact_No_1
        '
        Me.Tb_Contact_No_1.Enabled = False
        Me.Tb_Contact_No_1.Font = New System.Drawing.Font("Rockwell Condensed", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tb_Contact_No_1.Location = New System.Drawing.Point(213, 271)
        Me.Tb_Contact_No_1.Name = "Tb_Contact_No_1"
        Me.Tb_Contact_No_1.Size = New System.Drawing.Size(267, 36)
        Me.Tb_Contact_No_1.TabIndex = 188
        '
        'Lbl_Contact_No_2
        '
        Me.Lbl_Contact_No_2.AutoSize = True
        Me.Lbl_Contact_No_2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Lbl_Contact_No_2.Font = New System.Drawing.Font("Rockwell Condensed", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Contact_No_2.ForeColor = System.Drawing.Color.Red
        Me.Lbl_Contact_No_2.Location = New System.Drawing.Point(47, 327)
        Me.Lbl_Contact_No_2.Name = "Lbl_Contact_No_2"
        Me.Lbl_Contact_No_2.Size = New System.Drawing.Size(109, 29)
        Me.Lbl_Contact_No_2.TabIndex = 187
        Me.Lbl_Contact_No_2.Text = "Contact No.2"
        '
        'Lbl_Contact_No_1
        '
        Me.Lbl_Contact_No_1.AutoSize = True
        Me.Lbl_Contact_No_1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Lbl_Contact_No_1.Font = New System.Drawing.Font("Rockwell Condensed", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Contact_No_1.ForeColor = System.Drawing.Color.Red
        Me.Lbl_Contact_No_1.Location = New System.Drawing.Point(47, 274)
        Me.Lbl_Contact_No_1.Name = "Lbl_Contact_No_1"
        Me.Lbl_Contact_No_1.Size = New System.Drawing.Size(109, 29)
        Me.Lbl_Contact_No_1.TabIndex = 186
        Me.Lbl_Contact_No_1.Text = "Contact No.1"
        '
        'Tb_Address
        '
        Me.Tb_Address.Enabled = False
        Me.Tb_Address.Font = New System.Drawing.Font("Rockwell Condensed", 18.0!)
        Me.Tb_Address.Location = New System.Drawing.Point(213, 160)
        Me.Tb_Address.Multiline = True
        Me.Tb_Address.Name = "Tb_Address"
        Me.Tb_Address.Size = New System.Drawing.Size(267, 85)
        Me.Tb_Address.TabIndex = 185
        '
        'Tb_Patient_ID
        '
        Me.Tb_Patient_ID.Font = New System.Drawing.Font("Rockwell Condensed", 18.0!)
        Me.Tb_Patient_ID.Location = New System.Drawing.Point(315, 116)
        Me.Tb_Patient_ID.Name = "Tb_Patient_ID"
        Me.Tb_Patient_ID.Size = New System.Drawing.Size(179, 36)
        Me.Tb_Patient_ID.TabIndex = 192
        '
        'Lbl_Gender
        '
        Me.Lbl_Gender.AutoSize = True
        Me.Lbl_Gender.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Lbl_Gender.Font = New System.Drawing.Font("Rockwell Condensed", 18.0!)
        Me.Lbl_Gender.ForeColor = System.Drawing.Color.Red
        Me.Lbl_Gender.Location = New System.Drawing.Point(633, 44)
        Me.Lbl_Gender.Name = "Lbl_Gender"
        Me.Lbl_Gender.Size = New System.Drawing.Size(64, 29)
        Me.Lbl_Gender.TabIndex = 183
        Me.Lbl_Gender.Text = "Gender"
        '
        'Tb_Blood_Group
        '
        Me.Tb_Blood_Group.Enabled = False
        Me.Tb_Blood_Group.Font = New System.Drawing.Font("Rockwell Condensed", 18.0!)
        Me.Tb_Blood_Group.Location = New System.Drawing.Point(811, 106)
        Me.Tb_Blood_Group.Name = "Tb_Blood_Group"
        Me.Tb_Blood_Group.Size = New System.Drawing.Size(267, 36)
        Me.Tb_Blood_Group.TabIndex = 182
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Blue
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Lbl_Search_Patient_Details)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1350, 92)
        Me.Panel1.TabIndex = 195
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(258, 92)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 94
        Me.PictureBox1.TabStop = False
        '
        'Lbl_Patient_ID
        '
        Me.Lbl_Patient_ID.AutoSize = True
        Me.Lbl_Patient_ID.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Lbl_Patient_ID.Font = New System.Drawing.Font("Rockwell", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Patient_ID.ForeColor = System.Drawing.Color.Black
        Me.Lbl_Patient_ID.Location = New System.Drawing.Point(179, 119)
        Me.Lbl_Patient_ID.Name = "Lbl_Patient_ID"
        Me.Lbl_Patient_ID.Size = New System.Drawing.Size(130, 29)
        Me.Lbl_Patient_ID.TabIndex = 199
        Me.Lbl_Patient_ID.Text = "Patient ID"
        '
        'Lbl_Blood_Group
        '
        Me.Lbl_Blood_Group.AutoSize = True
        Me.Lbl_Blood_Group.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Lbl_Blood_Group.Font = New System.Drawing.Font("Rockwell Condensed", 18.0!)
        Me.Lbl_Blood_Group.ForeColor = System.Drawing.Color.Red
        Me.Lbl_Blood_Group.Location = New System.Drawing.Point(633, 106)
        Me.Lbl_Blood_Group.Name = "Lbl_Blood_Group"
        Me.Lbl_Blood_Group.Size = New System.Drawing.Size(104, 29)
        Me.Lbl_Blood_Group.TabIndex = 181
        Me.Lbl_Blood_Group.Text = "Blood Group"
        '
        'Tb_Age
        '
        Me.Tb_Age.Enabled = False
        Me.Tb_Age.Font = New System.Drawing.Font("Rockwell Condensed", 18.0!)
        Me.Tb_Age.Location = New System.Drawing.Point(213, 392)
        Me.Tb_Age.Name = "Tb_Age"
        Me.Tb_Age.Size = New System.Drawing.Size(267, 36)
        Me.Tb_Age.TabIndex = 180
        '
        'Lbl_Age
        '
        Me.Lbl_Age.AutoSize = True
        Me.Lbl_Age.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Lbl_Age.Font = New System.Drawing.Font("Rockwell Condensed", 18.0!)
        Me.Lbl_Age.ForeColor = System.Drawing.Color.Red
        Me.Lbl_Age.Location = New System.Drawing.Point(47, 392)
        Me.Lbl_Age.Name = "Lbl_Age"
        Me.Lbl_Age.Size = New System.Drawing.Size(41, 29)
        Me.Lbl_Age.TabIndex = 178
        Me.Lbl_Age.Text = "Age"
        '
        'Gp_Patient_Details
        '
        Me.Gp_Patient_Details.Controls.Add(Me.Dtp_Time)
        Me.Gp_Patient_Details.Controls.Add(Me.Dtp_Date_Of_Birth)
        Me.Gp_Patient_Details.Controls.Add(Me.Lbl_Appointment_Date)
        Me.Gp_Patient_Details.Controls.Add(Me.Lbl_Appointment_Time)
        Me.Gp_Patient_Details.Controls.Add(Me.Gp_Gender)
        Me.Gp_Patient_Details.Controls.Add(Me.Tb_Blood_Pressure)
        Me.Gp_Patient_Details.Controls.Add(Me.Tb_Suger)
        Me.Gp_Patient_Details.Controls.Add(Me.Lbl_Blood_Pressure)
        Me.Gp_Patient_Details.Controls.Add(Me.Lbl_Suger)
        Me.Gp_Patient_Details.Controls.Add(Me.Tb_Contact_No_2)
        Me.Gp_Patient_Details.Controls.Add(Me.Tb_Contact_No_1)
        Me.Gp_Patient_Details.Controls.Add(Me.Lbl_Contact_No_2)
        Me.Gp_Patient_Details.Controls.Add(Me.Lbl_Contact_No_1)
        Me.Gp_Patient_Details.Controls.Add(Me.Tb_Address)
        Me.Gp_Patient_Details.Controls.Add(Me.Lbl_Gender)
        Me.Gp_Patient_Details.Controls.Add(Me.Tb_Blood_Group)
        Me.Gp_Patient_Details.Controls.Add(Me.Lbl_Blood_Group)
        Me.Gp_Patient_Details.Controls.Add(Me.Tb_Age)
        Me.Gp_Patient_Details.Controls.Add(Me.Lbl_Age)
        Me.Gp_Patient_Details.Controls.Add(Me.Tb_Last_Name)
        Me.Gp_Patient_Details.Controls.Add(Me.Tb_First_Name)
        Me.Gp_Patient_Details.Controls.Add(Me.Lbl_Last_Name)
        Me.Gp_Patient_Details.Controls.Add(Me.Lbl_Address)
        Me.Gp_Patient_Details.Controls.Add(Me.Lbl_First_Name)
        Me.Gp_Patient_Details.Font = New System.Drawing.Font("Rockwell Condensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Gp_Patient_Details.Location = New System.Drawing.Point(109, 175)
        Me.Gp_Patient_Details.Name = "Gp_Patient_Details"
        Me.Gp_Patient_Details.Size = New System.Drawing.Size(1132, 443)
        Me.Gp_Patient_Details.TabIndex = 198
        Me.Gp_Patient_Details.TabStop = False
        Me.Gp_Patient_Details.Text = "Patient Details"
        '
        'Tb_Last_Name
        '
        Me.Tb_Last_Name.Enabled = False
        Me.Tb_Last_Name.Font = New System.Drawing.Font("Rockwell Condensed", 18.0!)
        Me.Tb_Last_Name.Location = New System.Drawing.Point(213, 102)
        Me.Tb_Last_Name.Name = "Tb_Last_Name"
        Me.Tb_Last_Name.Size = New System.Drawing.Size(267, 36)
        Me.Tb_Last_Name.TabIndex = 175
        '
        'Tb_First_Name
        '
        Me.Tb_First_Name.Enabled = False
        Me.Tb_First_Name.Font = New System.Drawing.Font("Rockwell Condensed", 18.0!)
        Me.Tb_First_Name.Location = New System.Drawing.Point(213, 40)
        Me.Tb_First_Name.Name = "Tb_First_Name"
        Me.Tb_First_Name.Size = New System.Drawing.Size(267, 36)
        Me.Tb_First_Name.TabIndex = 174
        '
        'Lbl_Last_Name
        '
        Me.Lbl_Last_Name.AutoSize = True
        Me.Lbl_Last_Name.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Lbl_Last_Name.Font = New System.Drawing.Font("Rockwell Condensed", 18.0!)
        Me.Lbl_Last_Name.ForeColor = System.Drawing.Color.Red
        Me.Lbl_Last_Name.Location = New System.Drawing.Point(47, 102)
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
        Me.Lbl_Address.Location = New System.Drawing.Point(47, 158)
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
        Me.Lbl_First_Name.Location = New System.Drawing.Point(47, 43)
        Me.Lbl_First_Name.Name = "Lbl_First_Name"
        Me.Lbl_First_Name.Size = New System.Drawing.Size(97, 29)
        Me.Lbl_First_Name.TabIndex = 172
        Me.Lbl_First_Name.Text = "First Name"
        '
        'Btn_SEARCH
        '
        Me.Btn_SEARCH.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Btn_SEARCH.Font = New System.Drawing.Font("Rockwell Condensed", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_SEARCH.ForeColor = System.Drawing.Color.Cornsilk
        Me.Btn_SEARCH.Location = New System.Drawing.Point(523, 112)
        Me.Btn_SEARCH.Name = "Btn_SEARCH"
        Me.Btn_SEARCH.Size = New System.Drawing.Size(144, 42)
        Me.Btn_SEARCH.TabIndex = 193
        Me.Btn_SEARCH.Text = "SEARCH"
        Me.Btn_SEARCH.UseVisualStyleBackColor = False
        '
        'Btn_CLEAR
        '
        Me.Btn_CLEAR.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Btn_CLEAR.Font = New System.Drawing.Font("Rockwell", 21.75!, System.Drawing.FontStyle.Bold)
        Me.Btn_CLEAR.ForeColor = System.Drawing.SystemColors.Control
        Me.Btn_CLEAR.Location = New System.Drawing.Point(620, 624)
        Me.Btn_CLEAR.Name = "Btn_CLEAR"
        Me.Btn_CLEAR.Size = New System.Drawing.Size(144, 53)
        Me.Btn_CLEAR.TabIndex = 194
        Me.Btn_CLEAR.Text = "CLEAR"
        Me.Btn_CLEAR.UseVisualStyleBackColor = False
        '
        'Frm_Search_Patient_Details
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1350, 729)
        Me.ControlBox = False
        Me.Controls.Add(Me.Dtp_Date)
        Me.Controls.Add(Me.Lbl_Date)
        Me.Controls.Add(Me.Tb_Patient_ID)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Lbl_Patient_ID)
        Me.Controls.Add(Me.Gp_Patient_Details)
        Me.Controls.Add(Me.Btn_SEARCH)
        Me.Controls.Add(Me.Btn_CLEAR)
        Me.Name = "Frm_Search_Patient_Details"
        Me.Text = "Search Patient Details"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Gp_Gender.ResumeLayout(False)
        Me.Gp_Gender.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Gp_Patient_Details.ResumeLayout(False)
        Me.Gp_Patient_Details.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Dtp_Time As System.Windows.Forms.DateTimePicker
    Friend WithEvents Dtp_Date_Of_Birth As System.Windows.Forms.DateTimePicker
    Friend WithEvents Lbl_Appointment_Time As System.Windows.Forms.Label
    Friend WithEvents Lbl_Search_Patient_Details As System.Windows.Forms.Label
    Friend WithEvents Lbl_Appointment_Date As System.Windows.Forms.Label
    Friend WithEvents Gp_Gender As System.Windows.Forms.GroupBox
    Friend WithEvents Rb_Male As System.Windows.Forms.RadioButton
    Friend WithEvents Rb_Female As System.Windows.Forms.RadioButton
    Friend WithEvents Tb_Blood_Pressure As System.Windows.Forms.TextBox
    Friend WithEvents Dtp_Date As System.Windows.Forms.DateTimePicker
    Friend WithEvents Tb_Suger As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_Blood_Pressure As System.Windows.Forms.Label
    Friend WithEvents Lbl_Suger As System.Windows.Forms.Label
    Friend WithEvents Lbl_Date As System.Windows.Forms.Label
    Friend WithEvents Tb_Contact_No_2 As System.Windows.Forms.TextBox
    Friend WithEvents Tb_Contact_No_1 As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_Contact_No_2 As System.Windows.Forms.Label
    Friend WithEvents Lbl_Contact_No_1 As System.Windows.Forms.Label
    Friend WithEvents Tb_Address As System.Windows.Forms.TextBox
    Friend WithEvents Tb_Patient_ID As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_Gender As System.Windows.Forms.Label
    Friend WithEvents Tb_Blood_Group As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Lbl_Patient_ID As System.Windows.Forms.Label
    Friend WithEvents Lbl_Blood_Group As System.Windows.Forms.Label
    Friend WithEvents Tb_Age As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_Age As System.Windows.Forms.Label
    Friend WithEvents Gp_Patient_Details As System.Windows.Forms.GroupBox
    Friend WithEvents Tb_Last_Name As System.Windows.Forms.TextBox
    Friend WithEvents Tb_First_Name As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_Last_Name As System.Windows.Forms.Label
    Friend WithEvents Lbl_Address As System.Windows.Forms.Label
    Friend WithEvents Lbl_First_Name As System.Windows.Forms.Label
    Friend WithEvents Btn_SEARCH As System.Windows.Forms.Button
    Friend WithEvents Btn_CLEAR As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
