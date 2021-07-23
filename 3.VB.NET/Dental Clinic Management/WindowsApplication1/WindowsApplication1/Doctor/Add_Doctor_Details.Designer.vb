<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Add_Doctor_Details
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Add_Doctor_Details))
        Me.Tb_Doctor_ID = New System.Windows.Forms.TextBox()
        Me.Tb_Email_ID = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Lbl_Add_Doctor_Details = New System.Windows.Forms.Label()
        Me.Tb_Clinic_Address = New System.Windows.Forms.TextBox()
        Me.Tb_Doctor_Name = New System.Windows.Forms.TextBox()
        Me.Lbl_Specialization = New System.Windows.Forms.Label()
        Me.Lbl_Charges = New System.Windows.Forms.Label()
        Me.Btn_SAVE = New System.Windows.Forms.Button()
        Me.Lbl_Email_ID = New System.Windows.Forms.Label()
        Me.Tb_Age = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Dgv_Special_Charges = New System.Windows.Forms.DataGridView()
        Me.Doctor_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Specialization = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Charges = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tb_Specialization = New System.Windows.Forms.TextBox()
        Me.Tb_Charges = New System.Windows.Forms.TextBox()
        Me.Btn_Add = New System.Windows.Forms.Button()
        Me.Btn_CLEAR = New System.Windows.Forms.Button()
        Me.Lbl_Age = New System.Windows.Forms.Label()
        Me.Dtp_DOB = New System.Windows.Forms.DateTimePicker()
        Me.Lbl_DOB = New System.Windows.Forms.Label()
        Me.Lbl_Clinic_Address = New System.Windows.Forms.Label()
        Me.Tb_Contact_No_2 = New System.Windows.Forms.TextBox()
        Me.Tb_Contact_No_1 = New System.Windows.Forms.TextBox()
        Me.Lbl_Contact_No_2 = New System.Windows.Forms.Label()
        Me.Lbl_Contact_No_1 = New System.Windows.Forms.Label()
        Me.Lbl_Doctor_Name = New System.Windows.Forms.Label()
        Me.Lbl_Doctor_ID = New System.Windows.Forms.Label()
        Me.Dtp_Date = New System.Windows.Forms.DateTimePicker()
        Me.Lbl_Date = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Dgv_Special_Charges, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Tb_Doctor_ID
        '
        Me.Tb_Doctor_ID.Enabled = False
        Me.Tb_Doctor_ID.Font = New System.Drawing.Font("Bahnschrift Condensed", 20.25!, System.Drawing.FontStyle.Bold)
        Me.Tb_Doctor_ID.Location = New System.Drawing.Point(221, 55)
        Me.Tb_Doctor_ID.Name = "Tb_Doctor_ID"
        Me.Tb_Doctor_ID.Size = New System.Drawing.Size(267, 40)
        Me.Tb_Doctor_ID.TabIndex = 1
        '
        'Tb_Email_ID
        '
        Me.Tb_Email_ID.Font = New System.Drawing.Font("Bahnschrift Condensed", 20.25!, System.Drawing.FontStyle.Bold)
        Me.Tb_Email_ID.Location = New System.Drawing.Point(791, 173)
        Me.Tb_Email_ID.Name = "Tb_Email_ID"
        Me.Tb_Email_ID.Size = New System.Drawing.Size(267, 40)
        Me.Tb_Email_ID.TabIndex = 8
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Blue
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Lbl_Add_Doctor_Details)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1350, 92)
        Me.Panel1.TabIndex = 166
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(258, 92)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 87
        Me.PictureBox1.TabStop = False
        '
        'Lbl_Add_Doctor_Details
        '
        Me.Lbl_Add_Doctor_Details.AutoSize = True
        Me.Lbl_Add_Doctor_Details.Font = New System.Drawing.Font("Bahnschrift Condensed", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Add_Doctor_Details.ForeColor = System.Drawing.Color.LemonChiffon
        Me.Lbl_Add_Doctor_Details.Image = CType(resources.GetObject("Lbl_Add_Doctor_Details.Image"), System.Drawing.Image)
        Me.Lbl_Add_Doctor_Details.Location = New System.Drawing.Point(452, 9)
        Me.Lbl_Add_Doctor_Details.Name = "Lbl_Add_Doctor_Details"
        Me.Lbl_Add_Doctor_Details.Size = New System.Drawing.Size(423, 77)
        Me.Lbl_Add_Doctor_Details.TabIndex = 63
        Me.Lbl_Add_Doctor_Details.Text = "Add Doctor Details"
        '
        'Tb_Clinic_Address
        '
        Me.Tb_Clinic_Address.Font = New System.Drawing.Font("Bahnschrift Condensed", 20.25!, System.Drawing.FontStyle.Bold)
        Me.Tb_Clinic_Address.Location = New System.Drawing.Point(221, 326)
        Me.Tb_Clinic_Address.Multiline = True
        Me.Tb_Clinic_Address.Name = "Tb_Clinic_Address"
        Me.Tb_Clinic_Address.Size = New System.Drawing.Size(267, 88)
        Me.Tb_Clinic_Address.TabIndex = 5
        '
        'Tb_Doctor_Name
        '
        Me.Tb_Doctor_Name.Font = New System.Drawing.Font("Bahnschrift Condensed", 20.25!, System.Drawing.FontStyle.Bold)
        Me.Tb_Doctor_Name.Location = New System.Drawing.Point(221, 113)
        Me.Tb_Doctor_Name.Name = "Tb_Doctor_Name"
        Me.Tb_Doctor_Name.Size = New System.Drawing.Size(267, 40)
        Me.Tb_Doctor_Name.TabIndex = 2
        '
        'Lbl_Specialization
        '
        Me.Lbl_Specialization.AutoSize = True
        Me.Lbl_Specialization.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Lbl_Specialization.Font = New System.Drawing.Font("Bahnschrift Condensed", 20.25!, System.Drawing.FontStyle.Bold)
        Me.Lbl_Specialization.ForeColor = System.Drawing.Color.Red
        Me.Lbl_Specialization.Location = New System.Drawing.Point(589, 247)
        Me.Lbl_Specialization.Name = "Lbl_Specialization"
        Me.Lbl_Specialization.Size = New System.Drawing.Size(140, 33)
        Me.Lbl_Specialization.TabIndex = 126
        Me.Lbl_Specialization.Text = "Specialization"
        '
        'Lbl_Charges
        '
        Me.Lbl_Charges.AutoSize = True
        Me.Lbl_Charges.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Lbl_Charges.Font = New System.Drawing.Font("Bahnschrift Condensed", 20.25!, System.Drawing.FontStyle.Bold)
        Me.Lbl_Charges.ForeColor = System.Drawing.Color.Red
        Me.Lbl_Charges.Location = New System.Drawing.Point(848, 254)
        Me.Lbl_Charges.Name = "Lbl_Charges"
        Me.Lbl_Charges.Size = New System.Drawing.Size(88, 33)
        Me.Lbl_Charges.TabIndex = 127
        Me.Lbl_Charges.Text = "Charges"
        '
        'Btn_SAVE
        '
        Me.Btn_SAVE.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Btn_SAVE.Font = New System.Drawing.Font("Bahnschrift Condensed", 20.25!, System.Drawing.FontStyle.Bold)
        Me.Btn_SAVE.ForeColor = System.Drawing.Color.Cornsilk
        Me.Btn_SAVE.Location = New System.Drawing.Point(344, 466)
        Me.Btn_SAVE.Name = "Btn_SAVE"
        Me.Btn_SAVE.Size = New System.Drawing.Size(144, 46)
        Me.Btn_SAVE.TabIndex = 12
        Me.Btn_SAVE.Text = "SAVE"
        Me.Btn_SAVE.UseVisualStyleBackColor = False
        '
        'Lbl_Email_ID
        '
        Me.Lbl_Email_ID.AutoSize = True
        Me.Lbl_Email_ID.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Lbl_Email_ID.Font = New System.Drawing.Font("Bahnschrift Condensed", 20.25!, System.Drawing.FontStyle.Bold)
        Me.Lbl_Email_ID.ForeColor = System.Drawing.Color.Red
        Me.Lbl_Email_ID.Location = New System.Drawing.Point(589, 174)
        Me.Lbl_Email_ID.Name = "Lbl_Email_ID"
        Me.Lbl_Email_ID.Size = New System.Drawing.Size(86, 33)
        Me.Lbl_Email_ID.TabIndex = 125
        Me.Lbl_Email_ID.Text = "Email ID"
        '
        'Tb_Age
        '
        Me.Tb_Age.Enabled = False
        Me.Tb_Age.Font = New System.Drawing.Font("Bahnschrift Condensed", 20.25!, System.Drawing.FontStyle.Bold)
        Me.Tb_Age.Location = New System.Drawing.Point(791, 109)
        Me.Tb_Age.Name = "Tb_Age"
        Me.Tb_Age.Size = New System.Drawing.Size(267, 40)
        Me.Tb_Age.TabIndex = 7
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Dgv_Special_Charges)
        Me.GroupBox1.Controls.Add(Me.Tb_Specialization)
        Me.GroupBox1.Controls.Add(Me.Tb_Charges)
        Me.GroupBox1.Controls.Add(Me.Btn_Add)
        Me.GroupBox1.Controls.Add(Me.Btn_SAVE)
        Me.GroupBox1.Controls.Add(Me.Btn_CLEAR)
        Me.GroupBox1.Controls.Add(Me.Tb_Doctor_ID)
        Me.GroupBox1.Controls.Add(Me.Tb_Email_ID)
        Me.GroupBox1.Controls.Add(Me.Tb_Clinic_Address)
        Me.GroupBox1.Controls.Add(Me.Tb_Doctor_Name)
        Me.GroupBox1.Controls.Add(Me.Lbl_Charges)
        Me.GroupBox1.Controls.Add(Me.Lbl_Specialization)
        Me.GroupBox1.Controls.Add(Me.Lbl_Email_ID)
        Me.GroupBox1.Controls.Add(Me.Tb_Age)
        Me.GroupBox1.Controls.Add(Me.Lbl_Age)
        Me.GroupBox1.Controls.Add(Me.Dtp_DOB)
        Me.GroupBox1.Controls.Add(Me.Lbl_DOB)
        Me.GroupBox1.Controls.Add(Me.Lbl_Clinic_Address)
        Me.GroupBox1.Controls.Add(Me.Tb_Contact_No_2)
        Me.GroupBox1.Controls.Add(Me.Tb_Contact_No_1)
        Me.GroupBox1.Controls.Add(Me.Lbl_Contact_No_2)
        Me.GroupBox1.Controls.Add(Me.Lbl_Contact_No_1)
        Me.GroupBox1.Controls.Add(Me.Lbl_Doctor_Name)
        Me.GroupBox1.Controls.Add(Me.Lbl_Doctor_ID)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(111, 176)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1182, 518)
        Me.GroupBox1.TabIndex = 169
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Doctor Details"
        '
        'Dgv_Special_Charges
        '
        Me.Dgv_Special_Charges.AllowUserToAddRows = False
        Me.Dgv_Special_Charges.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Dgv_Special_Charges.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Dgv_Special_Charges.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv_Special_Charges.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Doctor_ID, Me.Specialization, Me.Charges})
        Me.Dgv_Special_Charges.Location = New System.Drawing.Point(594, 341)
        Me.Dgv_Special_Charges.Name = "Dgv_Special_Charges"
        Me.Dgv_Special_Charges.ReadOnly = True
        Me.Dgv_Special_Charges.Size = New System.Drawing.Size(391, 119)
        Me.Dgv_Special_Charges.TabIndex = 175
        '
        'Doctor_ID
        '
        Me.Doctor_ID.HeaderText = "Doctor ID"
        Me.Doctor_ID.Name = "Doctor_ID"
        Me.Doctor_ID.ReadOnly = True
        Me.Doctor_ID.Visible = False
        '
        'Specialization
        '
        Me.Specialization.HeaderText = "Specialization"
        Me.Specialization.Name = "Specialization"
        Me.Specialization.ReadOnly = True
        '
        'Charges
        '
        Me.Charges.HeaderText = "Charges"
        Me.Charges.Name = "Charges"
        Me.Charges.ReadOnly = True
        '
        'Tb_Specialization
        '
        Me.Tb_Specialization.Font = New System.Drawing.Font("Bahnschrift Condensed", 20.25!, System.Drawing.FontStyle.Bold)
        Me.Tb_Specialization.Location = New System.Drawing.Point(594, 297)
        Me.Tb_Specialization.Name = "Tb_Specialization"
        Me.Tb_Specialization.Size = New System.Drawing.Size(164, 40)
        Me.Tb_Specialization.TabIndex = 9
        '
        'Tb_Charges
        '
        Me.Tb_Charges.Font = New System.Drawing.Font("Bahnschrift Condensed", 20.25!, System.Drawing.FontStyle.Bold)
        Me.Tb_Charges.Location = New System.Drawing.Point(826, 297)
        Me.Tb_Charges.Name = "Tb_Charges"
        Me.Tb_Charges.Size = New System.Drawing.Size(156, 40)
        Me.Tb_Charges.TabIndex = 10
        '
        'Btn_Add
        '
        Me.Btn_Add.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Btn_Add.Font = New System.Drawing.Font("Bahnschrift Condensed", 20.25!, System.Drawing.FontStyle.Bold)
        Me.Btn_Add.ForeColor = System.Drawing.SystemColors.Control
        Me.Btn_Add.Location = New System.Drawing.Point(1000, 292)
        Me.Btn_Add.Name = "Btn_Add"
        Me.Btn_Add.Size = New System.Drawing.Size(95, 41)
        Me.Btn_Add.TabIndex = 11
        Me.Btn_Add.Text = "ADD"
        Me.Btn_Add.UseVisualStyleBackColor = False
        '
        'Btn_CLEAR
        '
        Me.Btn_CLEAR.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Btn_CLEAR.Font = New System.Drawing.Font("Bahnschrift Condensed", 20.25!, System.Drawing.FontStyle.Bold)
        Me.Btn_CLEAR.ForeColor = System.Drawing.SystemColors.Control
        Me.Btn_CLEAR.Location = New System.Drawing.Point(791, 466)
        Me.Btn_CLEAR.Name = "Btn_CLEAR"
        Me.Btn_CLEAR.Size = New System.Drawing.Size(130, 46)
        Me.Btn_CLEAR.TabIndex = 13
        Me.Btn_CLEAR.Text = "CLEAR"
        Me.Btn_CLEAR.UseVisualStyleBackColor = False
        '
        'Lbl_Age
        '
        Me.Lbl_Age.AutoSize = True
        Me.Lbl_Age.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Lbl_Age.Font = New System.Drawing.Font("Bahnschrift Condensed", 20.25!, System.Drawing.FontStyle.Bold)
        Me.Lbl_Age.ForeColor = System.Drawing.Color.Red
        Me.Lbl_Age.Location = New System.Drawing.Point(589, 112)
        Me.Lbl_Age.Name = "Lbl_Age"
        Me.Lbl_Age.Size = New System.Drawing.Size(49, 33)
        Me.Lbl_Age.TabIndex = 123
        Me.Lbl_Age.Text = "Age"
        '
        'Dtp_DOB
        '
        Me.Dtp_DOB.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Dtp_DOB.Font = New System.Drawing.Font("Bahnschrift Condensed", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dtp_DOB.Location = New System.Drawing.Point(791, 51)
        Me.Dtp_DOB.Name = "Dtp_DOB"
        Me.Dtp_DOB.Size = New System.Drawing.Size(267, 33)
        Me.Dtp_DOB.TabIndex = 6
        '
        'Lbl_DOB
        '
        Me.Lbl_DOB.AutoSize = True
        Me.Lbl_DOB.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Lbl_DOB.Font = New System.Drawing.Font("Bahnschrift Condensed", 20.25!, System.Drawing.FontStyle.Bold)
        Me.Lbl_DOB.ForeColor = System.Drawing.Color.Red
        Me.Lbl_DOB.Location = New System.Drawing.Point(589, 58)
        Me.Lbl_DOB.Name = "Lbl_DOB"
        Me.Lbl_DOB.Size = New System.Drawing.Size(49, 33)
        Me.Lbl_DOB.TabIndex = 121
        Me.Lbl_DOB.Text = "DOB"
        '
        'Lbl_Clinic_Address
        '
        Me.Lbl_Clinic_Address.AutoSize = True
        Me.Lbl_Clinic_Address.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Lbl_Clinic_Address.Font = New System.Drawing.Font("Bahnschrift Condensed", 20.25!, System.Drawing.FontStyle.Bold)
        Me.Lbl_Clinic_Address.ForeColor = System.Drawing.Color.Red
        Me.Lbl_Clinic_Address.Location = New System.Drawing.Point(54, 322)
        Me.Lbl_Clinic_Address.Name = "Lbl_Clinic_Address"
        Me.Lbl_Clinic_Address.Size = New System.Drawing.Size(141, 33)
        Me.Lbl_Clinic_Address.TabIndex = 120
        Me.Lbl_Clinic_Address.Text = "Clinic Address"
        '
        'Tb_Contact_No_2
        '
        Me.Tb_Contact_No_2.Font = New System.Drawing.Font("Bahnschrift Condensed", 20.25!, System.Drawing.FontStyle.Bold)
        Me.Tb_Contact_No_2.Location = New System.Drawing.Point(221, 251)
        Me.Tb_Contact_No_2.MaxLength = 10
        Me.Tb_Contact_No_2.Name = "Tb_Contact_No_2"
        Me.Tb_Contact_No_2.Size = New System.Drawing.Size(267, 40)
        Me.Tb_Contact_No_2.TabIndex = 4
        '
        'Tb_Contact_No_1
        '
        Me.Tb_Contact_No_1.Font = New System.Drawing.Font("Bahnschrift Condensed", 20.25!, System.Drawing.FontStyle.Bold)
        Me.Tb_Contact_No_1.Location = New System.Drawing.Point(221, 180)
        Me.Tb_Contact_No_1.MaxLength = 10
        Me.Tb_Contact_No_1.Name = "Tb_Contact_No_1"
        Me.Tb_Contact_No_1.Size = New System.Drawing.Size(267, 40)
        Me.Tb_Contact_No_1.TabIndex = 3
        '
        'Lbl_Contact_No_2
        '
        Me.Lbl_Contact_No_2.AutoSize = True
        Me.Lbl_Contact_No_2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Lbl_Contact_No_2.Font = New System.Drawing.Font("Bahnschrift Condensed", 20.25!, System.Drawing.FontStyle.Bold)
        Me.Lbl_Contact_No_2.ForeColor = System.Drawing.Color.Red
        Me.Lbl_Contact_No_2.Location = New System.Drawing.Point(54, 247)
        Me.Lbl_Contact_No_2.Name = "Lbl_Contact_No_2"
        Me.Lbl_Contact_No_2.Size = New System.Drawing.Size(124, 33)
        Me.Lbl_Contact_No_2.TabIndex = 117
        Me.Lbl_Contact_No_2.Text = "Contact No.2"
        '
        'Lbl_Contact_No_1
        '
        Me.Lbl_Contact_No_1.AutoSize = True
        Me.Lbl_Contact_No_1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Lbl_Contact_No_1.Font = New System.Drawing.Font("Bahnschrift Condensed", 20.25!, System.Drawing.FontStyle.Bold)
        Me.Lbl_Contact_No_1.ForeColor = System.Drawing.Color.Red
        Me.Lbl_Contact_No_1.Location = New System.Drawing.Point(54, 183)
        Me.Lbl_Contact_No_1.Name = "Lbl_Contact_No_1"
        Me.Lbl_Contact_No_1.Size = New System.Drawing.Size(120, 33)
        Me.Lbl_Contact_No_1.TabIndex = 116
        Me.Lbl_Contact_No_1.Text = "Contact No.1"
        '
        'Lbl_Doctor_Name
        '
        Me.Lbl_Doctor_Name.AutoSize = True
        Me.Lbl_Doctor_Name.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Lbl_Doctor_Name.Font = New System.Drawing.Font("Bahnschrift Condensed", 20.25!, System.Drawing.FontStyle.Bold)
        Me.Lbl_Doctor_Name.ForeColor = System.Drawing.Color.Red
        Me.Lbl_Doctor_Name.Location = New System.Drawing.Point(53, 116)
        Me.Lbl_Doctor_Name.Name = "Lbl_Doctor_Name"
        Me.Lbl_Doctor_Name.Size = New System.Drawing.Size(128, 33)
        Me.Lbl_Doctor_Name.TabIndex = 115
        Me.Lbl_Doctor_Name.Text = "Doctor Name"
        '
        'Lbl_Doctor_ID
        '
        Me.Lbl_Doctor_ID.AutoSize = True
        Me.Lbl_Doctor_ID.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Lbl_Doctor_ID.Font = New System.Drawing.Font("Bahnschrift Condensed", 20.25!, System.Drawing.FontStyle.Bold)
        Me.Lbl_Doctor_ID.ForeColor = System.Drawing.Color.Red
        Me.Lbl_Doctor_ID.Location = New System.Drawing.Point(54, 58)
        Me.Lbl_Doctor_ID.Name = "Lbl_Doctor_ID"
        Me.Lbl_Doctor_ID.Size = New System.Drawing.Size(94, 33)
        Me.Lbl_Doctor_ID.TabIndex = 114
        Me.Lbl_Doctor_ID.Text = "Doctor ID"
        '
        'Dtp_Date
        '
        Me.Dtp_Date.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Dtp_Date.Enabled = False
        Me.Dtp_Date.Font = New System.Drawing.Font("Bahnschrift Condensed", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dtp_Date.Location = New System.Drawing.Point(979, 110)
        Me.Dtp_Date.Name = "Dtp_Date"
        Me.Dtp_Date.Size = New System.Drawing.Size(267, 33)
        Me.Dtp_Date.TabIndex = 168
        '
        'Lbl_Date
        '
        Me.Lbl_Date.AutoSize = True
        Me.Lbl_Date.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Lbl_Date.Font = New System.Drawing.Font("Bahnschrift Condensed", 20.25!, System.Drawing.FontStyle.Bold)
        Me.Lbl_Date.ForeColor = System.Drawing.Color.Red
        Me.Lbl_Date.Location = New System.Drawing.Point(859, 116)
        Me.Lbl_Date.Name = "Lbl_Date"
        Me.Lbl_Date.Size = New System.Drawing.Size(56, 33)
        Me.Lbl_Date.TabIndex = 167
        Me.Lbl_Date.Text = "Date"
        '
        'Frm_Add_Doctor_Details
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1350, 729)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Dtp_Date)
        Me.Controls.Add(Me.Lbl_Date)
        Me.Name = "Frm_Add_Doctor_Details"
        Me.Text = "Add Doctor Details"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Dgv_Special_Charges, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Tb_Doctor_ID As System.Windows.Forms.TextBox
    Friend WithEvents Tb_Email_ID As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Lbl_Add_Doctor_Details As System.Windows.Forms.Label
    Friend WithEvents Tb_Clinic_Address As System.Windows.Forms.TextBox
    Friend WithEvents Tb_Doctor_Name As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_Specialization As System.Windows.Forms.Label
    Friend WithEvents Lbl_Charges As System.Windows.Forms.Label
    Friend WithEvents Btn_SAVE As System.Windows.Forms.Button
    Friend WithEvents Lbl_Email_ID As System.Windows.Forms.Label
    Friend WithEvents Tb_Age As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Lbl_Age As System.Windows.Forms.Label
    Friend WithEvents Dtp_DOB As System.Windows.Forms.DateTimePicker
    Friend WithEvents Lbl_DOB As System.Windows.Forms.Label
    Friend WithEvents Lbl_Clinic_Address As System.Windows.Forms.Label
    Friend WithEvents Tb_Contact_No_2 As System.Windows.Forms.TextBox
    Friend WithEvents Tb_Contact_No_1 As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_Contact_No_2 As System.Windows.Forms.Label
    Friend WithEvents Lbl_Contact_No_1 As System.Windows.Forms.Label
    Friend WithEvents Lbl_Doctor_Name As System.Windows.Forms.Label
    Friend WithEvents Lbl_Doctor_ID As System.Windows.Forms.Label
    Friend WithEvents Dtp_Date As System.Windows.Forms.DateTimePicker
    Friend WithEvents Lbl_Date As System.Windows.Forms.Label
    Friend WithEvents Btn_CLEAR As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Btn_Add As System.Windows.Forms.Button
    Friend WithEvents Tb_Specialization As System.Windows.Forms.TextBox
    Friend WithEvents Tb_Charges As System.Windows.Forms.TextBox
    Friend WithEvents Dgv_Special_Charges As System.Windows.Forms.DataGridView
    Friend WithEvents Doctor_ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Specialization As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Charges As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
