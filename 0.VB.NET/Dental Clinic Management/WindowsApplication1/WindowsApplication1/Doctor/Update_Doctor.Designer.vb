<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Update_Doctor_Details
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Update_Doctor_Details))
        Me.Btn_UPDATE = New System.Windows.Forms.Button()
        Me.Lbl_Update_Doctor_Details = New System.Windows.Forms.Label()
        Me.Btn_SEARCH = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Dtp_Joining_Date = New System.Windows.Forms.DateTimePicker()
        Me.Lbl_Joining_Date = New System.Windows.Forms.Label()
        Me.Btn_CLEAR = New System.Windows.Forms.Button()
        Me.Tb_Email_ID = New System.Windows.Forms.TextBox()
        Me.Tb_Clinic_Address = New System.Windows.Forms.TextBox()
        Me.Tb_Doctor_Name = New System.Windows.Forms.TextBox()
        Me.Lbl_Email_ID = New System.Windows.Forms.Label()
        Me.Tb_Age = New System.Windows.Forms.TextBox()
        Me.Lbl_Age = New System.Windows.Forms.Label()
        Me.Dtp_DOB = New System.Windows.Forms.DateTimePicker()
        Me.Lbl_DOB = New System.Windows.Forms.Label()
        Me.Lbl_Clinic_Address = New System.Windows.Forms.Label()
        Me.Tb_Contact_No_2 = New System.Windows.Forms.TextBox()
        Me.Tb_Contact_No_1 = New System.Windows.Forms.TextBox()
        Me.Lbl_Contact_No_2 = New System.Windows.Forms.Label()
        Me.Lbl_Contact_No_1 = New System.Windows.Forms.Label()
        Me.Lbl_Doctor_Name = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Lbl_Doctor_ID = New System.Windows.Forms.Label()
        Me.Tb_Doctor_ID = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Btn_UPDATE
        '
        Me.Btn_UPDATE.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Btn_UPDATE.Enabled = False
        Me.Btn_UPDATE.Font = New System.Drawing.Font("Rockwell", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_UPDATE.ForeColor = System.Drawing.Color.Cornsilk
        Me.Btn_UPDATE.Location = New System.Drawing.Point(404, 444)
        Me.Btn_UPDATE.Name = "Btn_UPDATE"
        Me.Btn_UPDATE.Size = New System.Drawing.Size(144, 54)
        Me.Btn_UPDATE.TabIndex = 179
        Me.Btn_UPDATE.Text = "UPDATE"
        Me.Btn_UPDATE.UseVisualStyleBackColor = False
        '
        'Lbl_Update_Doctor_Details
        '
        Me.Lbl_Update_Doctor_Details.AutoSize = True
        Me.Lbl_Update_Doctor_Details.Font = New System.Drawing.Font("Rockwell Condensed", 48.0!, System.Drawing.FontStyle.Bold)
        Me.Lbl_Update_Doctor_Details.ForeColor = System.Drawing.Color.LemonChiffon
        Me.Lbl_Update_Doctor_Details.Image = CType(resources.GetObject("Lbl_Update_Doctor_Details.Image"), System.Drawing.Image)
        Me.Lbl_Update_Doctor_Details.Location = New System.Drawing.Point(480, 17)
        Me.Lbl_Update_Doctor_Details.Name = "Lbl_Update_Doctor_Details"
        Me.Lbl_Update_Doctor_Details.Size = New System.Drawing.Size(584, 75)
        Me.Lbl_Update_Doctor_Details.TabIndex = 63
        Me.Lbl_Update_Doctor_Details.Text = "Update Doctor Details"
        '
        'Btn_SEARCH
        '
        Me.Btn_SEARCH.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Btn_SEARCH.Enabled = False
        Me.Btn_SEARCH.Font = New System.Drawing.Font("Rockwell Condensed", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_SEARCH.ForeColor = System.Drawing.Color.Cornsilk
        Me.Btn_SEARCH.Location = New System.Drawing.Point(828, 156)
        Me.Btn_SEARCH.Name = "Btn_SEARCH"
        Me.Btn_SEARCH.Size = New System.Drawing.Size(144, 42)
        Me.Btn_SEARCH.TabIndex = 178
        Me.Btn_SEARCH.Text = "SEARCH"
        Me.Btn_SEARCH.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Btn_UPDATE)
        Me.GroupBox1.Controls.Add(Me.Dtp_Joining_Date)
        Me.GroupBox1.Controls.Add(Me.Lbl_Joining_Date)
        Me.GroupBox1.Controls.Add(Me.Btn_CLEAR)
        Me.GroupBox1.Controls.Add(Me.Tb_Email_ID)
        Me.GroupBox1.Controls.Add(Me.Tb_Clinic_Address)
        Me.GroupBox1.Controls.Add(Me.Tb_Doctor_Name)
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
        Me.GroupBox1.Font = New System.Drawing.Font("Rockwell Condensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(113, 204)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1132, 513)
        Me.GroupBox1.TabIndex = 177
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Doctor Details"
        '
        'Dtp_Joining_Date
        '
        Me.Dtp_Joining_Date.CalendarFont = New System.Drawing.Font("Rockwell Condensed", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Dtp_Joining_Date.Enabled = False
        Me.Dtp_Joining_Date.Font = New System.Drawing.Font("Rockwell Condensed", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dtp_Joining_Date.Location = New System.Drawing.Point(281, 366)
        Me.Dtp_Joining_Date.Name = "Dtp_Joining_Date"
        Me.Dtp_Joining_Date.Size = New System.Drawing.Size(267, 36)
        Me.Dtp_Joining_Date.TabIndex = 146
        '
        'Lbl_Joining_Date
        '
        Me.Lbl_Joining_Date.AutoSize = True
        Me.Lbl_Joining_Date.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Lbl_Joining_Date.Font = New System.Drawing.Font("Rockwell Condensed", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Joining_Date.ForeColor = System.Drawing.Color.Red
        Me.Lbl_Joining_Date.Location = New System.Drawing.Point(95, 372)
        Me.Lbl_Joining_Date.Name = "Lbl_Joining_Date"
        Me.Lbl_Joining_Date.Size = New System.Drawing.Size(106, 29)
        Me.Lbl_Joining_Date.TabIndex = 145
        Me.Lbl_Joining_Date.Text = "Joining Date"
        '
        'Btn_CLEAR
        '
        Me.Btn_CLEAR.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Btn_CLEAR.Font = New System.Drawing.Font("Rockwell", 21.75!, System.Drawing.FontStyle.Bold)
        Me.Btn_CLEAR.ForeColor = System.Drawing.SystemColors.Control
        Me.Btn_CLEAR.Location = New System.Drawing.Point(640, 446)
        Me.Btn_CLEAR.Name = "Btn_CLEAR"
        Me.Btn_CLEAR.Size = New System.Drawing.Size(144, 52)
        Me.Btn_CLEAR.TabIndex = 180
        Me.Btn_CLEAR.Text = "CLEAR"
        Me.Btn_CLEAR.UseVisualStyleBackColor = False
        '
        'Tb_Email_ID
        '
        Me.Tb_Email_ID.Enabled = False
        Me.Tb_Email_ID.Font = New System.Drawing.Font("Rockwell Condensed", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tb_Email_ID.Location = New System.Drawing.Point(824, 252)
        Me.Tb_Email_ID.Name = "Tb_Email_ID"
        Me.Tb_Email_ID.Size = New System.Drawing.Size(267, 36)
        Me.Tb_Email_ID.TabIndex = 130
        '
        'Tb_Clinic_Address
        '
        Me.Tb_Clinic_Address.Enabled = False
        Me.Tb_Clinic_Address.Font = New System.Drawing.Font("Rockwell Condensed", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tb_Clinic_Address.Location = New System.Drawing.Point(281, 266)
        Me.Tb_Clinic_Address.Multiline = True
        Me.Tb_Clinic_Address.Name = "Tb_Clinic_Address"
        Me.Tb_Clinic_Address.Size = New System.Drawing.Size(267, 88)
        Me.Tb_Clinic_Address.TabIndex = 129
        '
        'Tb_Doctor_Name
        '
        Me.Tb_Doctor_Name.Enabled = False
        Me.Tb_Doctor_Name.Font = New System.Drawing.Font("Rockwell Condensed", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tb_Doctor_Name.Location = New System.Drawing.Point(281, 53)
        Me.Tb_Doctor_Name.Name = "Tb_Doctor_Name"
        Me.Tb_Doctor_Name.Size = New System.Drawing.Size(267, 36)
        Me.Tb_Doctor_Name.TabIndex = 128
        '
        'Lbl_Email_ID
        '
        Me.Lbl_Email_ID.AutoSize = True
        Me.Lbl_Email_ID.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Lbl_Email_ID.Font = New System.Drawing.Font("Rockwell Condensed", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Email_ID.ForeColor = System.Drawing.Color.Red
        Me.Lbl_Email_ID.Location = New System.Drawing.Point(635, 257)
        Me.Lbl_Email_ID.Name = "Lbl_Email_ID"
        Me.Lbl_Email_ID.Size = New System.Drawing.Size(80, 29)
        Me.Lbl_Email_ID.TabIndex = 125
        Me.Lbl_Email_ID.Text = "Email ID"
        '
        'Tb_Age
        '
        Me.Tb_Age.Enabled = False
        Me.Tb_Age.Font = New System.Drawing.Font("Rockwell Condensed", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tb_Age.Location = New System.Drawing.Point(824, 188)
        Me.Tb_Age.Name = "Tb_Age"
        Me.Tb_Age.Size = New System.Drawing.Size(267, 36)
        Me.Tb_Age.TabIndex = 124
        '
        'Lbl_Age
        '
        Me.Lbl_Age.AutoSize = True
        Me.Lbl_Age.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Lbl_Age.Font = New System.Drawing.Font("Rockwell Condensed", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Age.ForeColor = System.Drawing.Color.Red
        Me.Lbl_Age.Location = New System.Drawing.Point(635, 195)
        Me.Lbl_Age.Name = "Lbl_Age"
        Me.Lbl_Age.Size = New System.Drawing.Size(41, 29)
        Me.Lbl_Age.TabIndex = 123
        Me.Lbl_Age.Text = "Age"
        '
        'Dtp_DOB
        '
        Me.Dtp_DOB.CalendarFont = New System.Drawing.Font("Rockwell Condensed", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Dtp_DOB.Enabled = False
        Me.Dtp_DOB.Font = New System.Drawing.Font("Rockwell Condensed", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dtp_DOB.Location = New System.Drawing.Point(824, 130)
        Me.Dtp_DOB.Name = "Dtp_DOB"
        Me.Dtp_DOB.Size = New System.Drawing.Size(267, 36)
        Me.Dtp_DOB.TabIndex = 122
        '
        'Lbl_DOB
        '
        Me.Lbl_DOB.AutoSize = True
        Me.Lbl_DOB.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Lbl_DOB.Font = New System.Drawing.Font("Rockwell Condensed", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_DOB.ForeColor = System.Drawing.Color.Red
        Me.Lbl_DOB.Location = New System.Drawing.Point(635, 141)
        Me.Lbl_DOB.Name = "Lbl_DOB"
        Me.Lbl_DOB.Size = New System.Drawing.Size(44, 29)
        Me.Lbl_DOB.TabIndex = 121
        Me.Lbl_DOB.Text = "DOB"
        '
        'Lbl_Clinic_Address
        '
        Me.Lbl_Clinic_Address.AutoSize = True
        Me.Lbl_Clinic_Address.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Lbl_Clinic_Address.Font = New System.Drawing.Font("Rockwell Condensed", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Clinic_Address.ForeColor = System.Drawing.Color.Red
        Me.Lbl_Clinic_Address.Location = New System.Drawing.Point(95, 266)
        Me.Lbl_Clinic_Address.Name = "Lbl_Clinic_Address"
        Me.Lbl_Clinic_Address.Size = New System.Drawing.Size(123, 29)
        Me.Lbl_Clinic_Address.TabIndex = 120
        Me.Lbl_Clinic_Address.Text = "Clinic Address"
        '
        'Tb_Contact_No_2
        '
        Me.Tb_Contact_No_2.Enabled = False
        Me.Tb_Contact_No_2.Font = New System.Drawing.Font("Rockwell Condensed", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tb_Contact_No_2.Location = New System.Drawing.Point(281, 191)
        Me.Tb_Contact_No_2.MaxLength = 10
        Me.Tb_Contact_No_2.Name = "Tb_Contact_No_2"
        Me.Tb_Contact_No_2.Size = New System.Drawing.Size(267, 36)
        Me.Tb_Contact_No_2.TabIndex = 119
        '
        'Tb_Contact_No_1
        '
        Me.Tb_Contact_No_1.Enabled = False
        Me.Tb_Contact_No_1.Font = New System.Drawing.Font("Rockwell Condensed", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tb_Contact_No_1.Location = New System.Drawing.Point(281, 120)
        Me.Tb_Contact_No_1.MaxLength = 10
        Me.Tb_Contact_No_1.Name = "Tb_Contact_No_1"
        Me.Tb_Contact_No_1.Size = New System.Drawing.Size(267, 36)
        Me.Tb_Contact_No_1.TabIndex = 118
        '
        'Lbl_Contact_No_2
        '
        Me.Lbl_Contact_No_2.AutoSize = True
        Me.Lbl_Contact_No_2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Lbl_Contact_No_2.Font = New System.Drawing.Font("Rockwell Condensed", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Contact_No_2.ForeColor = System.Drawing.Color.Red
        Me.Lbl_Contact_No_2.Location = New System.Drawing.Point(95, 191)
        Me.Lbl_Contact_No_2.Name = "Lbl_Contact_No_2"
        Me.Lbl_Contact_No_2.Size = New System.Drawing.Size(109, 29)
        Me.Lbl_Contact_No_2.TabIndex = 117
        Me.Lbl_Contact_No_2.Text = "Contact No.2"
        '
        'Lbl_Contact_No_1
        '
        Me.Lbl_Contact_No_1.AutoSize = True
        Me.Lbl_Contact_No_1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Lbl_Contact_No_1.Font = New System.Drawing.Font("Rockwell Condensed", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Contact_No_1.ForeColor = System.Drawing.Color.Red
        Me.Lbl_Contact_No_1.Location = New System.Drawing.Point(95, 127)
        Me.Lbl_Contact_No_1.Name = "Lbl_Contact_No_1"
        Me.Lbl_Contact_No_1.Size = New System.Drawing.Size(109, 29)
        Me.Lbl_Contact_No_1.TabIndex = 116
        Me.Lbl_Contact_No_1.Text = "Contact No.1"
        '
        'Lbl_Doctor_Name
        '
        Me.Lbl_Doctor_Name.AutoSize = True
        Me.Lbl_Doctor_Name.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Lbl_Doctor_Name.Font = New System.Drawing.Font("Rockwell Condensed", 18.0!)
        Me.Lbl_Doctor_Name.ForeColor = System.Drawing.Color.Red
        Me.Lbl_Doctor_Name.Location = New System.Drawing.Point(95, 60)
        Me.Lbl_Doctor_Name.Name = "Lbl_Doctor_Name"
        Me.Lbl_Doctor_Name.Size = New System.Drawing.Size(110, 29)
        Me.Lbl_Doctor_Name.TabIndex = 115
        Me.Lbl_Doctor_Name.Text = "Doctor Name"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Blue
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Lbl_Update_Doctor_Details)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1350, 92)
        Me.Panel1.TabIndex = 176
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-5, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(260, 92)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 182
        Me.PictureBox1.TabStop = False
        '
        'Lbl_Doctor_ID
        '
        Me.Lbl_Doctor_ID.AutoSize = True
        Me.Lbl_Doctor_ID.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Lbl_Doctor_ID.Font = New System.Drawing.Font("Rockwell", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Doctor_ID.ForeColor = System.Drawing.Color.Black
        Me.Lbl_Doctor_ID.Location = New System.Drawing.Point(322, 159)
        Me.Lbl_Doctor_ID.Name = "Lbl_Doctor_ID"
        Me.Lbl_Doctor_ID.Size = New System.Drawing.Size(127, 29)
        Me.Lbl_Doctor_ID.TabIndex = 174
        Me.Lbl_Doctor_ID.Text = "Doctor ID"
        '
        'Tb_Doctor_ID
        '
        Me.Tb_Doctor_ID.Font = New System.Drawing.Font("Rockwell Condensed", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tb_Doctor_ID.Location = New System.Drawing.Point(505, 156)
        Me.Tb_Doctor_ID.Name = "Tb_Doctor_ID"
        Me.Tb_Doctor_ID.Size = New System.Drawing.Size(267, 36)
        Me.Tb_Doctor_ID.TabIndex = 1
        '
        'Frm_Update_Doctor_Details
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1350, 729)
        Me.ControlBox = False
        Me.Controls.Add(Me.Btn_SEARCH)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Lbl_Doctor_ID)
        Me.Controls.Add(Me.Tb_Doctor_ID)
        Me.Name = "Frm_Update_Doctor_Details"
        Me.Text = "Update Doctor Details"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Btn_UPDATE As System.Windows.Forms.Button
    Friend WithEvents Lbl_Update_Doctor_Details As System.Windows.Forms.Label
    Friend WithEvents Btn_SEARCH As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Dtp_Joining_Date As System.Windows.Forms.DateTimePicker
    Friend WithEvents Lbl_Joining_Date As System.Windows.Forms.Label
    Friend WithEvents Tb_Email_ID As System.Windows.Forms.TextBox
    Friend WithEvents Tb_Clinic_Address As System.Windows.Forms.TextBox
    Friend WithEvents Tb_Doctor_Name As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_Email_ID As System.Windows.Forms.Label
    Friend WithEvents Tb_Age As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_Age As System.Windows.Forms.Label
    Friend WithEvents Dtp_DOB As System.Windows.Forms.DateTimePicker
    Friend WithEvents Lbl_DOB As System.Windows.Forms.Label
    Friend WithEvents Lbl_Clinic_Address As System.Windows.Forms.Label
    Friend WithEvents Tb_Contact_No_2 As System.Windows.Forms.TextBox
    Friend WithEvents Tb_Contact_No_1 As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_Contact_No_2 As System.Windows.Forms.Label
    Friend WithEvents Lbl_Contact_No_1 As System.Windows.Forms.Label
    Friend WithEvents Lbl_Doctor_Name As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Lbl_Doctor_ID As System.Windows.Forms.Label
    Friend WithEvents Tb_Doctor_ID As System.Windows.Forms.TextBox
    Friend WithEvents Btn_CLEAR As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
