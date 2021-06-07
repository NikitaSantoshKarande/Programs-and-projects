<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Priscription
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Priscription))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Lbl_Quantity = New System.Windows.Forms.Label()
        Me.Lbl_Medication = New System.Windows.Forms.Label()
        Me.Dtp_Date = New System.Windows.Forms.DateTimePicker()
        Me.Tb_Jaw_Teeth_No = New System.Windows.Forms.TextBox()
        Me.Tb_Grand_Total = New System.Windows.Forms.TextBox()
        Me.Gp_Patient_Details = New System.Windows.Forms.GroupBox()
        Me.Tb_Patient_ID = New System.Windows.Forms.TextBox()
        Me.Lbl_Patient_ID = New System.Windows.Forms.Label()
        Me.Cmb_Doctor_Name = New System.Windows.Forms.ComboBox()
        Me.Tb_Consultancy_Fees = New System.Windows.Forms.TextBox()
        Me.Lbl_Consultancy_Fees = New System.Windows.Forms.Label()
        Me.Lbl_Doctor_Name = New System.Windows.Forms.Label()
        Me.Tb_First_Name = New System.Windows.Forms.TextBox()
        Me.Lbl_Patient_Name = New System.Windows.Forms.Label()
        Me.Lbl_Jaw_Teeth_No = New System.Windows.Forms.Label()
        Me.Lbl_Grand_Total = New System.Windows.Forms.Label()
        Me.Tb_Medication = New System.Windows.Forms.TextBox()
        Me.Tb_Quantity = New System.Windows.Forms.TextBox()
        Me.Lbl_Treatment_Charges = New System.Windows.Forms.Label()
        Me.Btn_SAVE_AND_PRINT = New System.Windows.Forms.Button()
        Me.Gp_Treatment = New System.Windows.Forms.GroupBox()
        Me.Clb_Treatment = New System.Windows.Forms.CheckedListBox()
        Me.Lbl_Treatment = New System.Windows.Forms.Label()
        Me.Tb_Charges = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Btn_ADD = New System.Windows.Forms.Button()
        Me.Dgv_Medication_Quantity = New System.Windows.Forms.DataGridView()
        Me.Appointment_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Medication = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Quantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tb_Last_Name = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Gp_Patient_Details.SuspendLayout()
        Me.Gp_Treatment.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dgv_Medication_Quantity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Lbl_Quantity
        '
        Me.Lbl_Quantity.AutoSize = True
        Me.Lbl_Quantity.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Lbl_Quantity.Font = New System.Drawing.Font("Rockwell Condensed", 18.0!)
        Me.Lbl_Quantity.ForeColor = System.Drawing.Color.Red
        Me.Lbl_Quantity.Location = New System.Drawing.Point(485, 473)
        Me.Lbl_Quantity.Name = "Lbl_Quantity"
        Me.Lbl_Quantity.Size = New System.Drawing.Size(77, 29)
        Me.Lbl_Quantity.TabIndex = 200
        Me.Lbl_Quantity.Text = "Quantity"
        '
        'Lbl_Medication
        '
        Me.Lbl_Medication.AutoSize = True
        Me.Lbl_Medication.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Lbl_Medication.Font = New System.Drawing.Font("Rockwell Condensed", 18.0!)
        Me.Lbl_Medication.ForeColor = System.Drawing.Color.Red
        Me.Lbl_Medication.Location = New System.Drawing.Point(100, 473)
        Me.Lbl_Medication.Name = "Lbl_Medication"
        Me.Lbl_Medication.Size = New System.Drawing.Size(94, 29)
        Me.Lbl_Medication.TabIndex = 199
        Me.Lbl_Medication.Text = "Medication"
        '
        'Dtp_Date
        '
        Me.Dtp_Date.CalendarFont = New System.Drawing.Font("Rockwell Condensed", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Dtp_Date.Enabled = False
        Me.Dtp_Date.Font = New System.Drawing.Font("Rockwell Condensed", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dtp_Date.Location = New System.Drawing.Point(984, 24)
        Me.Dtp_Date.Name = "Dtp_Date"
        Me.Dtp_Date.Size = New System.Drawing.Size(267, 36)
        Me.Dtp_Date.TabIndex = 162
        '
        'Tb_Jaw_Teeth_No
        '
        Me.Tb_Jaw_Teeth_No.Font = New System.Drawing.Font("Rockwell Condensed", 18.0!)
        Me.Tb_Jaw_Teeth_No.Location = New System.Drawing.Point(165, 39)
        Me.Tb_Jaw_Teeth_No.Multiline = True
        Me.Tb_Jaw_Teeth_No.Name = "Tb_Jaw_Teeth_No"
        Me.Tb_Jaw_Teeth_No.Size = New System.Drawing.Size(182, 115)
        Me.Tb_Jaw_Teeth_No.TabIndex = 1
        '
        'Tb_Grand_Total
        '
        Me.Tb_Grand_Total.Enabled = False
        Me.Tb_Grand_Total.Font = New System.Drawing.Font("Rockwell Condensed", 18.0!)
        Me.Tb_Grand_Total.Location = New System.Drawing.Point(1045, 575)
        Me.Tb_Grand_Total.Multiline = True
        Me.Tb_Grand_Total.Name = "Tb_Grand_Total"
        Me.Tb_Grand_Total.Size = New System.Drawing.Size(267, 52)
        Me.Tb_Grand_Total.TabIndex = 11
        '
        'Gp_Patient_Details
        '
        Me.Gp_Patient_Details.BackColor = System.Drawing.Color.White
        Me.Gp_Patient_Details.Controls.Add(Me.Tb_Patient_ID)
        Me.Gp_Patient_Details.Controls.Add(Me.Lbl_Patient_ID)
        Me.Gp_Patient_Details.Controls.Add(Me.Cmb_Doctor_Name)
        Me.Gp_Patient_Details.Controls.Add(Me.Tb_Consultancy_Fees)
        Me.Gp_Patient_Details.Controls.Add(Me.Lbl_Consultancy_Fees)
        Me.Gp_Patient_Details.Controls.Add(Me.Lbl_Doctor_Name)
        Me.Gp_Patient_Details.Font = New System.Drawing.Font("Rockwell Condensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Gp_Patient_Details.Location = New System.Drawing.Point(12, 91)
        Me.Gp_Patient_Details.Name = "Gp_Patient_Details"
        Me.Gp_Patient_Details.Size = New System.Drawing.Size(1326, 167)
        Me.Gp_Patient_Details.TabIndex = 195
        Me.Gp_Patient_Details.TabStop = False
        Me.Gp_Patient_Details.Text = "Patient Details"
        '
        'Tb_Patient_ID
        '
        Me.Tb_Patient_ID.Enabled = False
        Me.Tb_Patient_ID.Font = New System.Drawing.Font("Rockwell Condensed", 18.0!)
        Me.Tb_Patient_ID.Location = New System.Drawing.Point(616, 29)
        Me.Tb_Patient_ID.Name = "Tb_Patient_ID"
        Me.Tb_Patient_ID.Size = New System.Drawing.Size(267, 36)
        Me.Tb_Patient_ID.TabIndex = 167
        '
        'Lbl_Patient_ID
        '
        Me.Lbl_Patient_ID.AutoSize = True
        Me.Lbl_Patient_ID.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Lbl_Patient_ID.Font = New System.Drawing.Font("Rockwell Condensed", 18.0!)
        Me.Lbl_Patient_ID.ForeColor = System.Drawing.Color.Red
        Me.Lbl_Patient_ID.Location = New System.Drawing.Point(394, 36)
        Me.Lbl_Patient_ID.Name = "Lbl_Patient_ID"
        Me.Lbl_Patient_ID.Size = New System.Drawing.Size(91, 29)
        Me.Lbl_Patient_ID.TabIndex = 168
        Me.Lbl_Patient_ID.Text = "Patient ID"
        '
        'Cmb_Doctor_Name
        '
        Me.Cmb_Doctor_Name.Enabled = False
        Me.Cmb_Doctor_Name.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmb_Doctor_Name.FormattingEnabled = True
        Me.Cmb_Doctor_Name.Items.AddRange(New Object() {"A.A.Patil", "S.P.Bagal"})
        Me.Cmb_Doctor_Name.Location = New System.Drawing.Point(271, 97)
        Me.Cmb_Doctor_Name.Name = "Cmb_Doctor_Name"
        Me.Cmb_Doctor_Name.Size = New System.Drawing.Size(265, 37)
        Me.Cmb_Doctor_Name.TabIndex = 166
        '
        'Tb_Consultancy_Fees
        '
        Me.Tb_Consultancy_Fees.Enabled = False
        Me.Tb_Consultancy_Fees.Font = New System.Drawing.Font("Rockwell Condensed", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tb_Consultancy_Fees.Location = New System.Drawing.Point(888, 102)
        Me.Tb_Consultancy_Fees.Name = "Tb_Consultancy_Fees"
        Me.Tb_Consultancy_Fees.Size = New System.Drawing.Size(267, 36)
        Me.Tb_Consultancy_Fees.TabIndex = 4
        '
        'Lbl_Consultancy_Fees
        '
        Me.Lbl_Consultancy_Fees.AutoSize = True
        Me.Lbl_Consultancy_Fees.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Lbl_Consultancy_Fees.Font = New System.Drawing.Font("Rockwell Condensed", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Consultancy_Fees.ForeColor = System.Drawing.Color.Red
        Me.Lbl_Consultancy_Fees.Location = New System.Drawing.Point(663, 109)
        Me.Lbl_Consultancy_Fees.Name = "Lbl_Consultancy_Fees"
        Me.Lbl_Consultancy_Fees.Size = New System.Drawing.Size(145, 29)
        Me.Lbl_Consultancy_Fees.TabIndex = 159
        Me.Lbl_Consultancy_Fees.Text = "Consultancy Fees"
        '
        'Lbl_Doctor_Name
        '
        Me.Lbl_Doctor_Name.AutoSize = True
        Me.Lbl_Doctor_Name.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Lbl_Doctor_Name.Font = New System.Drawing.Font("Rockwell Condensed", 18.0!)
        Me.Lbl_Doctor_Name.ForeColor = System.Drawing.Color.Red
        Me.Lbl_Doctor_Name.Location = New System.Drawing.Point(49, 105)
        Me.Lbl_Doctor_Name.Name = "Lbl_Doctor_Name"
        Me.Lbl_Doctor_Name.Size = New System.Drawing.Size(110, 29)
        Me.Lbl_Doctor_Name.TabIndex = 157
        Me.Lbl_Doctor_Name.Text = "Doctor Name"
        '
        'Tb_First_Name
        '
        Me.Tb_First_Name.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Tb_First_Name.Font = New System.Drawing.Font("Rockwell Condensed", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tb_First_Name.ForeColor = System.Drawing.Color.Fuchsia
        Me.Tb_First_Name.Location = New System.Drawing.Point(471, 24)
        Me.Tb_First_Name.Name = "Tb_First_Name"
        Me.Tb_First_Name.Size = New System.Drawing.Size(212, 38)
        Me.Tb_First_Name.TabIndex = 168
        '
        'Lbl_Patient_Name
        '
        Me.Lbl_Patient_Name.AutoSize = True
        Me.Lbl_Patient_Name.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Lbl_Patient_Name.Font = New System.Drawing.Font("Rockwell Condensed", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Patient_Name.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Lbl_Patient_Name.Location = New System.Drawing.Point(286, 21)
        Me.Lbl_Patient_Name.Name = "Lbl_Patient_Name"
        Me.Lbl_Patient_Name.Size = New System.Drawing.Size(155, 38)
        Me.Lbl_Patient_Name.TabIndex = 167
        Me.Lbl_Patient_Name.Text = "Patient Name"
        '
        'Lbl_Jaw_Teeth_No
        '
        Me.Lbl_Jaw_Teeth_No.AutoSize = True
        Me.Lbl_Jaw_Teeth_No.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Lbl_Jaw_Teeth_No.Font = New System.Drawing.Font("Rockwell Condensed", 18.0!)
        Me.Lbl_Jaw_Teeth_No.ForeColor = System.Drawing.Color.Red
        Me.Lbl_Jaw_Teeth_No.Location = New System.Drawing.Point(16, 60)
        Me.Lbl_Jaw_Teeth_No.Name = "Lbl_Jaw_Teeth_No"
        Me.Lbl_Jaw_Teeth_No.Size = New System.Drawing.Size(118, 29)
        Me.Lbl_Jaw_Teeth_No.TabIndex = 146
        Me.Lbl_Jaw_Teeth_No.Text = "Jaw Teeth No"
        '
        'Lbl_Grand_Total
        '
        Me.Lbl_Grand_Total.AutoSize = True
        Me.Lbl_Grand_Total.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Lbl_Grand_Total.Font = New System.Drawing.Font("Rockwell Condensed", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Grand_Total.ForeColor = System.Drawing.Color.Black
        Me.Lbl_Grand_Total.Location = New System.Drawing.Point(1093, 498)
        Me.Lbl_Grand_Total.Name = "Lbl_Grand_Total"
        Me.Lbl_Grand_Total.Size = New System.Drawing.Size(158, 44)
        Me.Lbl_Grand_Total.TabIndex = 198
        Me.Lbl_Grand_Total.Text = "Grand Total"
        '
        'Tb_Medication
        '
        Me.Tb_Medication.Font = New System.Drawing.Font("Rockwell Condensed", 18.0!)
        Me.Tb_Medication.Location = New System.Drawing.Point(200, 470)
        Me.Tb_Medication.Name = "Tb_Medication"
        Me.Tb_Medication.Size = New System.Drawing.Size(267, 36)
        Me.Tb_Medication.TabIndex = 4
        '
        'Tb_Quantity
        '
        Me.Tb_Quantity.Font = New System.Drawing.Font("Rockwell Condensed", 18.0!)
        Me.Tb_Quantity.Location = New System.Drawing.Point(568, 473)
        Me.Tb_Quantity.Name = "Tb_Quantity"
        Me.Tb_Quantity.Size = New System.Drawing.Size(267, 36)
        Me.Tb_Quantity.TabIndex = 5
        '
        'Lbl_Treatment_Charges
        '
        Me.Lbl_Treatment_Charges.AutoSize = True
        Me.Lbl_Treatment_Charges.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Lbl_Treatment_Charges.Font = New System.Drawing.Font("Rockwell Condensed", 18.0!)
        Me.Lbl_Treatment_Charges.ForeColor = System.Drawing.Color.Red
        Me.Lbl_Treatment_Charges.Location = New System.Drawing.Point(915, 60)
        Me.Lbl_Treatment_Charges.Name = "Lbl_Treatment_Charges"
        Me.Lbl_Treatment_Charges.Size = New System.Drawing.Size(155, 29)
        Me.Lbl_Treatment_Charges.TabIndex = 159
        Me.Lbl_Treatment_Charges.Text = "Treatment charges"
        '
        'Btn_SAVE_AND_PRINT
        '
        Me.Btn_SAVE_AND_PRINT.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Btn_SAVE_AND_PRINT.Enabled = False
        Me.Btn_SAVE_AND_PRINT.Font = New System.Drawing.Font("Rockwell", 21.75!, System.Drawing.FontStyle.Bold)
        Me.Btn_SAVE_AND_PRINT.ForeColor = System.Drawing.Color.Cornsilk
        Me.Btn_SAVE_AND_PRINT.Location = New System.Drawing.Point(302, 665)
        Me.Btn_SAVE_AND_PRINT.Name = "Btn_SAVE_AND_PRINT"
        Me.Btn_SAVE_AND_PRINT.Size = New System.Drawing.Size(512, 52)
        Me.Btn_SAVE_AND_PRINT.TabIndex = 7
        Me.Btn_SAVE_AND_PRINT.Text = "SAVE "
        Me.Btn_SAVE_AND_PRINT.UseVisualStyleBackColor = False
        '
        'Gp_Treatment
        '
        Me.Gp_Treatment.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Gp_Treatment.Controls.Add(Me.Clb_Treatment)
        Me.Gp_Treatment.Controls.Add(Me.Lbl_Jaw_Teeth_No)
        Me.Gp_Treatment.Controls.Add(Me.Tb_Jaw_Teeth_No)
        Me.Gp_Treatment.Controls.Add(Me.Lbl_Treatment)
        Me.Gp_Treatment.Controls.Add(Me.Tb_Charges)
        Me.Gp_Treatment.Controls.Add(Me.Lbl_Treatment_Charges)
        Me.Gp_Treatment.Font = New System.Drawing.Font("Rockwell Condensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Gp_Treatment.Location = New System.Drawing.Point(12, 264)
        Me.Gp_Treatment.Name = "Gp_Treatment"
        Me.Gp_Treatment.Size = New System.Drawing.Size(1326, 181)
        Me.Gp_Treatment.TabIndex = 196
        Me.Gp_Treatment.TabStop = False
        Me.Gp_Treatment.Text = "Treatment"
        '
        'Clb_Treatment
        '
        Me.Clb_Treatment.FormattingEnabled = True
        Me.Clb_Treatment.Items.AddRange(New Object() {"Braces", "Crowns and Caps", "Bridges and Impletns", "Dentures", "Gun Surgery", "Filling And Repairs"})
        Me.Clb_Treatment.Location = New System.Drawing.Point(534, 11)
        Me.Clb_Treatment.Name = "Clb_Treatment"
        Me.Clb_Treatment.Size = New System.Drawing.Size(330, 154)
        Me.Clb_Treatment.TabIndex = 2
        '
        'Lbl_Treatment
        '
        Me.Lbl_Treatment.AutoSize = True
        Me.Lbl_Treatment.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Lbl_Treatment.Font = New System.Drawing.Font("Rockwell Condensed", 18.0!)
        Me.Lbl_Treatment.ForeColor = System.Drawing.Color.Red
        Me.Lbl_Treatment.Location = New System.Drawing.Point(394, 60)
        Me.Lbl_Treatment.Name = "Lbl_Treatment"
        Me.Lbl_Treatment.Size = New System.Drawing.Size(89, 29)
        Me.Lbl_Treatment.TabIndex = 161
        Me.Lbl_Treatment.Text = "Treatment"
        '
        'Tb_Charges
        '
        Me.Tb_Charges.Font = New System.Drawing.Font("Rockwell Condensed", 18.0!)
        Me.Tb_Charges.Location = New System.Drawing.Point(1089, 53)
        Me.Tb_Charges.Name = "Tb_Charges"
        Me.Tb_Charges.Size = New System.Drawing.Size(193, 36)
        Me.Tb_Charges.TabIndex = 3
        Me.Tb_Charges.Text = "0"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(229, 83)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 204
        Me.PictureBox1.TabStop = False
        '
        'Btn_ADD
        '
        Me.Btn_ADD.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Btn_ADD.Enabled = False
        Me.Btn_ADD.Font = New System.Drawing.Font("Rockwell Condensed", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_ADD.ForeColor = System.Drawing.Color.Cornsilk
        Me.Btn_ADD.Location = New System.Drawing.Point(856, 470)
        Me.Btn_ADD.Name = "Btn_ADD"
        Me.Btn_ADD.Size = New System.Drawing.Size(144, 45)
        Me.Btn_ADD.TabIndex = 6
        Me.Btn_ADD.Text = "ADD"
        Me.Btn_ADD.UseVisualStyleBackColor = False
        '
        'Dgv_Medication_Quantity
        '
        Me.Dgv_Medication_Quantity.AllowUserToAddRows = False
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Rockwell Condensed", 15.75!)
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Dgv_Medication_Quantity.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.Dgv_Medication_Quantity.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Dgv_Medication_Quantity.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Rockwell Condensed", 15.75!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Dgv_Medication_Quantity.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.Dgv_Medication_Quantity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv_Medication_Quantity.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Appointment_ID, Me.Medication, Me.Quantity})
        Me.Dgv_Medication_Quantity.Location = New System.Drawing.Point(12, 529)
        Me.Dgv_Medication_Quantity.Name = "Dgv_Medication_Quantity"
        Me.Dgv_Medication_Quantity.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Rockwell Condensed", 15.75!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Dgv_Medication_Quantity.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.Dgv_Medication_Quantity.Size = New System.Drawing.Size(979, 130)
        Me.Dgv_Medication_Quantity.TabIndex = 203
        '
        'Appointment_ID
        '
        Me.Appointment_ID.HeaderText = "Appointment ID"
        Me.Appointment_ID.Name = "Appointment_ID"
        Me.Appointment_ID.ReadOnly = True
        Me.Appointment_ID.Visible = False
        '
        'Medication
        '
        Me.Medication.HeaderText = "Medication"
        Me.Medication.Name = "Medication"
        Me.Medication.ReadOnly = True
        '
        'Quantity
        '
        Me.Quantity.HeaderText = "Quantity"
        Me.Quantity.Name = "Quantity"
        Me.Quantity.ReadOnly = True
        '
        'Tb_Last_Name
        '
        Me.Tb_Last_Name.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Tb_Last_Name.Font = New System.Drawing.Font("Rockwell Condensed", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tb_Last_Name.ForeColor = System.Drawing.Color.Fuchsia
        Me.Tb_Last_Name.Location = New System.Drawing.Point(625, 24)
        Me.Tb_Last_Name.Name = "Tb_Last_Name"
        Me.Tb_Last_Name.Size = New System.Drawing.Size(189, 38)
        Me.Tb_Last_Name.TabIndex = 169
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Red
        Me.Button1.Font = New System.Drawing.Font("Rockwell Condensed", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Cornsilk
        Me.Button1.Location = New System.Drawing.Point(847, 672)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(144, 45)
        Me.Button1.TabIndex = 205
        Me.Button1.Text = "Print"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Frm_Priscription
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1350, 729)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Tb_Last_Name)
        Me.Controls.Add(Me.Tb_First_Name)
        Me.Controls.Add(Me.Btn_ADD)
        Me.Controls.Add(Me.Lbl_Patient_Name)
        Me.Controls.Add(Me.Dtp_Date)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Dgv_Medication_Quantity)
        Me.Controls.Add(Me.Lbl_Quantity)
        Me.Controls.Add(Me.Lbl_Medication)
        Me.Controls.Add(Me.Tb_Grand_Total)
        Me.Controls.Add(Me.Gp_Patient_Details)
        Me.Controls.Add(Me.Lbl_Grand_Total)
        Me.Controls.Add(Me.Tb_Medication)
        Me.Controls.Add(Me.Tb_Quantity)
        Me.Controls.Add(Me.Btn_SAVE_AND_PRINT)
        Me.Controls.Add(Me.Gp_Treatment)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Frm_Priscription"
        Me.Text = "Priscription"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Gp_Patient_Details.ResumeLayout(False)
        Me.Gp_Patient_Details.PerformLayout()
        Me.Gp_Treatment.ResumeLayout(False)
        Me.Gp_Treatment.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dgv_Medication_Quantity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Lbl_Quantity As System.Windows.Forms.Label
    Friend WithEvents Lbl_Medication As System.Windows.Forms.Label
    Friend WithEvents Dtp_Date As System.Windows.Forms.DateTimePicker
    Friend WithEvents Tb_Jaw_Teeth_No As System.Windows.Forms.TextBox
    Friend WithEvents Tb_Grand_Total As System.Windows.Forms.TextBox
    Friend WithEvents Gp_Patient_Details As System.Windows.Forms.GroupBox
    Friend WithEvents Lbl_Jaw_Teeth_No As System.Windows.Forms.Label
    Friend WithEvents Tb_Consultancy_Fees As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_Consultancy_Fees As System.Windows.Forms.Label
    Friend WithEvents Lbl_Doctor_Name As System.Windows.Forms.Label
    Friend WithEvents Lbl_Grand_Total As System.Windows.Forms.Label
    Friend WithEvents Tb_Medication As System.Windows.Forms.TextBox
    Friend WithEvents Tb_Quantity As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_Treatment_Charges As System.Windows.Forms.Label
    Friend WithEvents Btn_SAVE_AND_PRINT As System.Windows.Forms.Button
    Friend WithEvents Gp_Treatment As System.Windows.Forms.GroupBox
    Friend WithEvents Lbl_Treatment As System.Windows.Forms.Label
    Friend WithEvents Tb_Charges As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Btn_ADD As System.Windows.Forms.Button
    Friend WithEvents Cmb_Doctor_Name As System.Windows.Forms.ComboBox
    Friend WithEvents Dgv_Medication_Quantity As System.Windows.Forms.DataGridView
    Friend WithEvents Appointment_ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Medication As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Quantity As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Tb_First_Name As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_Patient_Name As System.Windows.Forms.Label
    Friend WithEvents Tb_Last_Name As System.Windows.Forms.TextBox
    Friend WithEvents Tb_Patient_ID As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_Patient_ID As System.Windows.Forms.Label
    Friend WithEvents Clb_Treatment As System.Windows.Forms.CheckedListBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
