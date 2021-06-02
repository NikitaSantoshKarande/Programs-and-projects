<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Add_Employee_Details
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Add_Employee_Details))
        Me.Tb_Contact_No_2 = New System.Windows.Forms.TextBox()
        Me.Tb_Contact_No_1 = New System.Windows.Forms.TextBox()
        Me.Lbl_Contact_No_2 = New System.Windows.Forms.Label()
        Me.Lbl_Contact_No_1 = New System.Windows.Forms.Label()
        Me.Tb_Employee_Name = New System.Windows.Forms.TextBox()
        Me.Tb_Employee_ID = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Lbl_Add_Employee = New System.Windows.Forms.Label()
        Me.Tb_Exprience = New System.Windows.Forms.TextBox()
        Me.Tb_Education = New System.Windows.Forms.TextBox()
        Me.Btn_SAVE = New System.Windows.Forms.Button()
        Me.Tb_Salary = New System.Windows.Forms.TextBox()
        Me.Gp_Employee_details = New System.Windows.Forms.GroupBox()
        Me.Dtp_Joining_Date = New System.Windows.Forms.DateTimePicker()
        Me.Btn_CLEAR = New System.Windows.Forms.Button()
        Me.Lbl_Joining_Date = New System.Windows.Forms.Label()
        Me.Lbl_Exprience = New System.Windows.Forms.Label()
        Me.Lbl_Education = New System.Windows.Forms.Label()
        Me.Lbl_Salary = New System.Windows.Forms.Label()
        Me.Tb_Address = New System.Windows.Forms.TextBox()
        Me.Lbl_Address = New System.Windows.Forms.Label()
        Me.Lbl_Employee_ID = New System.Windows.Forms.Label()
        Me.Lbl_Employee_Name = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Gp_Employee_details.SuspendLayout()
        Me.SuspendLayout()
        '
        'Tb_Contact_No_2
        '
        Me.Tb_Contact_No_2.Font = New System.Drawing.Font("Rockwell Condensed", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tb_Contact_No_2.Location = New System.Drawing.Point(795, 131)
        Me.Tb_Contact_No_2.MaxLength = 10
        Me.Tb_Contact_No_2.Name = "Tb_Contact_No_2"
        Me.Tb_Contact_No_2.Size = New System.Drawing.Size(267, 36)
        Me.Tb_Contact_No_2.TabIndex = 6
        '
        'Tb_Contact_No_1
        '
        Me.Tb_Contact_No_1.Font = New System.Drawing.Font("Rockwell Condensed", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tb_Contact_No_1.Location = New System.Drawing.Point(795, 61)
        Me.Tb_Contact_No_1.MaxLength = 10
        Me.Tb_Contact_No_1.Name = "Tb_Contact_No_1"
        Me.Tb_Contact_No_1.Size = New System.Drawing.Size(267, 36)
        Me.Tb_Contact_No_1.TabIndex = 5
        '
        'Lbl_Contact_No_2
        '
        Me.Lbl_Contact_No_2.AutoSize = True
        Me.Lbl_Contact_No_2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Lbl_Contact_No_2.Font = New System.Drawing.Font("Rockwell Condensed", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Contact_No_2.ForeColor = System.Drawing.Color.Red
        Me.Lbl_Contact_No_2.Location = New System.Drawing.Point(624, 133)
        Me.Lbl_Contact_No_2.Name = "Lbl_Contact_No_2"
        Me.Lbl_Contact_No_2.Size = New System.Drawing.Size(109, 29)
        Me.Lbl_Contact_No_2.TabIndex = 139
        Me.Lbl_Contact_No_2.Text = "Contact No.2"
        '
        'Lbl_Contact_No_1
        '
        Me.Lbl_Contact_No_1.AutoSize = True
        Me.Lbl_Contact_No_1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Lbl_Contact_No_1.Font = New System.Drawing.Font("Rockwell Condensed", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Contact_No_1.ForeColor = System.Drawing.Color.Red
        Me.Lbl_Contact_No_1.Location = New System.Drawing.Point(624, 58)
        Me.Lbl_Contact_No_1.Name = "Lbl_Contact_No_1"
        Me.Lbl_Contact_No_1.Size = New System.Drawing.Size(109, 29)
        Me.Lbl_Contact_No_1.TabIndex = 138
        Me.Lbl_Contact_No_1.Text = "Contact No.1"
        '
        'Tb_Employee_Name
        '
        Me.Tb_Employee_Name.Font = New System.Drawing.Font("Rockwell Condensed", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tb_Employee_Name.Location = New System.Drawing.Point(247, 126)
        Me.Tb_Employee_Name.Name = "Tb_Employee_Name"
        Me.Tb_Employee_Name.Size = New System.Drawing.Size(267, 36)
        Me.Tb_Employee_Name.TabIndex = 2
        '
        'Tb_Employee_ID
        '
        Me.Tb_Employee_ID.Enabled = False
        Me.Tb_Employee_ID.Font = New System.Drawing.Font("Rockwell Condensed", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tb_Employee_ID.Location = New System.Drawing.Point(247, 58)
        Me.Tb_Employee_ID.Name = "Tb_Employee_ID"
        Me.Tb_Employee_ID.Size = New System.Drawing.Size(267, 36)
        Me.Tb_Employee_ID.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Blue
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Lbl_Add_Employee)
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
        Me.PictureBox1.TabIndex = 98
        Me.PictureBox1.TabStop = False
        '
        'Lbl_Add_Employee
        '
        Me.Lbl_Add_Employee.AutoSize = True
        Me.Lbl_Add_Employee.Font = New System.Drawing.Font("Rockwell Condensed", 48.0!, System.Drawing.FontStyle.Bold)
        Me.Lbl_Add_Employee.ForeColor = System.Drawing.Color.LemonChiffon
        Me.Lbl_Add_Employee.Image = CType(resources.GetObject("Lbl_Add_Employee.Image"), System.Drawing.Image)
        Me.Lbl_Add_Employee.Location = New System.Drawing.Point(513, 9)
        Me.Lbl_Add_Employee.Name = "Lbl_Add_Employee"
        Me.Lbl_Add_Employee.Size = New System.Drawing.Size(417, 75)
        Me.Lbl_Add_Employee.TabIndex = 63
        Me.Lbl_Add_Employee.Text = "Add Employee "
        '
        'Tb_Exprience
        '
        Me.Tb_Exprience.Font = New System.Drawing.Font("Rockwell Condensed", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tb_Exprience.Location = New System.Drawing.Point(795, 207)
        Me.Tb_Exprience.Name = "Tb_Exprience"
        Me.Tb_Exprience.Size = New System.Drawing.Size(267, 36)
        Me.Tb_Exprience.TabIndex = 7
        '
        'Tb_Education
        '
        Me.Tb_Education.Font = New System.Drawing.Font("Rockwell Condensed", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tb_Education.Location = New System.Drawing.Point(247, 377)
        Me.Tb_Education.Name = "Tb_Education"
        Me.Tb_Education.Size = New System.Drawing.Size(267, 36)
        Me.Tb_Education.TabIndex = 4
        '
        'Btn_SAVE
        '
        Me.Btn_SAVE.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Btn_SAVE.Font = New System.Drawing.Font("Rockwell", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_SAVE.ForeColor = System.Drawing.Color.Cornsilk
        Me.Btn_SAVE.Location = New System.Drawing.Point(370, 451)
        Me.Btn_SAVE.Name = "Btn_SAVE"
        Me.Btn_SAVE.Size = New System.Drawing.Size(144, 52)
        Me.Btn_SAVE.TabIndex = 10
        Me.Btn_SAVE.Text = "SAVE"
        Me.Btn_SAVE.UseVisualStyleBackColor = False
        '
        'Tb_Salary
        '
        Me.Tb_Salary.Font = New System.Drawing.Font("Rockwell Condensed", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tb_Salary.Location = New System.Drawing.Point(795, 370)
        Me.Tb_Salary.Name = "Tb_Salary"
        Me.Tb_Salary.Size = New System.Drawing.Size(267, 36)
        Me.Tb_Salary.TabIndex = 9
        '
        'Gp_Employee_details
        '
        Me.Gp_Employee_details.Controls.Add(Me.Dtp_Joining_Date)
        Me.Gp_Employee_details.Controls.Add(Me.Tb_Contact_No_2)
        Me.Gp_Employee_details.Controls.Add(Me.Btn_SAVE)
        Me.Gp_Employee_details.Controls.Add(Me.Tb_Contact_No_1)
        Me.Gp_Employee_details.Controls.Add(Me.Lbl_Contact_No_2)
        Me.Gp_Employee_details.Controls.Add(Me.Btn_CLEAR)
        Me.Gp_Employee_details.Controls.Add(Me.Lbl_Contact_No_1)
        Me.Gp_Employee_details.Controls.Add(Me.Tb_Employee_Name)
        Me.Gp_Employee_details.Controls.Add(Me.Tb_Employee_ID)
        Me.Gp_Employee_details.Controls.Add(Me.Tb_Exprience)
        Me.Gp_Employee_details.Controls.Add(Me.Tb_Education)
        Me.Gp_Employee_details.Controls.Add(Me.Tb_Salary)
        Me.Gp_Employee_details.Controls.Add(Me.Lbl_Joining_Date)
        Me.Gp_Employee_details.Controls.Add(Me.Lbl_Exprience)
        Me.Gp_Employee_details.Controls.Add(Me.Lbl_Education)
        Me.Gp_Employee_details.Controls.Add(Me.Lbl_Salary)
        Me.Gp_Employee_details.Controls.Add(Me.Tb_Address)
        Me.Gp_Employee_details.Controls.Add(Me.Lbl_Address)
        Me.Gp_Employee_details.Controls.Add(Me.Lbl_Employee_ID)
        Me.Gp_Employee_details.Controls.Add(Me.Lbl_Employee_Name)
        Me.Gp_Employee_details.Font = New System.Drawing.Font("Rockwell Condensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Gp_Employee_details.Location = New System.Drawing.Point(125, 150)
        Me.Gp_Employee_details.Name = "Gp_Employee_details"
        Me.Gp_Employee_details.Size = New System.Drawing.Size(1117, 531)
        Me.Gp_Employee_details.TabIndex = 167
        Me.Gp_Employee_details.TabStop = False
        Me.Gp_Employee_details.Text = "Employee details"
        '
        'Dtp_Joining_Date
        '
        Me.Dtp_Joining_Date.Font = New System.Drawing.Font("Rockwell Condensed", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dtp_Joining_Date.Location = New System.Drawing.Point(795, 288)
        Me.Dtp_Joining_Date.Name = "Dtp_Joining_Date"
        Me.Dtp_Joining_Date.Size = New System.Drawing.Size(267, 36)
        Me.Dtp_Joining_Date.TabIndex = 8
        '
        'Btn_CLEAR
        '
        Me.Btn_CLEAR.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Btn_CLEAR.Font = New System.Drawing.Font("Rockwell", 21.75!, System.Drawing.FontStyle.Bold)
        Me.Btn_CLEAR.ForeColor = System.Drawing.SystemColors.Control
        Me.Btn_CLEAR.Location = New System.Drawing.Point(795, 451)
        Me.Btn_CLEAR.Name = "Btn_CLEAR"
        Me.Btn_CLEAR.Size = New System.Drawing.Size(144, 52)
        Me.Btn_CLEAR.TabIndex = 11
        Me.Btn_CLEAR.Text = "CLEAR"
        Me.Btn_CLEAR.UseVisualStyleBackColor = False
        '
        'Lbl_Joining_Date
        '
        Me.Lbl_Joining_Date.AutoSize = True
        Me.Lbl_Joining_Date.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Lbl_Joining_Date.Font = New System.Drawing.Font("Rockwell Condensed", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Joining_Date.ForeColor = System.Drawing.Color.Red
        Me.Lbl_Joining_Date.Location = New System.Drawing.Point(627, 288)
        Me.Lbl_Joining_Date.Name = "Lbl_Joining_Date"
        Me.Lbl_Joining_Date.Size = New System.Drawing.Size(106, 29)
        Me.Lbl_Joining_Date.TabIndex = 131
        Me.Lbl_Joining_Date.Text = "Joining Date"
        '
        'Lbl_Exprience
        '
        Me.Lbl_Exprience.AutoSize = True
        Me.Lbl_Exprience.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Lbl_Exprience.Font = New System.Drawing.Font("Rockwell Condensed", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Exprience.ForeColor = System.Drawing.Color.Red
        Me.Lbl_Exprience.Location = New System.Drawing.Point(627, 207)
        Me.Lbl_Exprience.Name = "Lbl_Exprience"
        Me.Lbl_Exprience.Size = New System.Drawing.Size(85, 29)
        Me.Lbl_Exprience.TabIndex = 130
        Me.Lbl_Exprience.Text = "Exprience"
        '
        'Lbl_Education
        '
        Me.Lbl_Education.AutoSize = True
        Me.Lbl_Education.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Lbl_Education.Font = New System.Drawing.Font("Rockwell Condensed", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Education.ForeColor = System.Drawing.Color.Red
        Me.Lbl_Education.Location = New System.Drawing.Point(54, 380)
        Me.Lbl_Education.Name = "Lbl_Education"
        Me.Lbl_Education.Size = New System.Drawing.Size(86, 29)
        Me.Lbl_Education.TabIndex = 129
        Me.Lbl_Education.Text = "Education"
        '
        'Lbl_Salary
        '
        Me.Lbl_Salary.AutoSize = True
        Me.Lbl_Salary.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Lbl_Salary.Font = New System.Drawing.Font("Rockwell Condensed", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Salary.ForeColor = System.Drawing.Color.Red
        Me.Lbl_Salary.Location = New System.Drawing.Point(627, 370)
        Me.Lbl_Salary.Name = "Lbl_Salary"
        Me.Lbl_Salary.Size = New System.Drawing.Size(62, 29)
        Me.Lbl_Salary.TabIndex = 128
        Me.Lbl_Salary.Text = "Salary"
        '
        'Tb_Address
        '
        Me.Tb_Address.Font = New System.Drawing.Font("Rockwell Condensed", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tb_Address.Location = New System.Drawing.Point(247, 208)
        Me.Tb_Address.Multiline = True
        Me.Tb_Address.Name = "Tb_Address"
        Me.Tb_Address.Size = New System.Drawing.Size(267, 116)
        Me.Tb_Address.TabIndex = 3
        '
        'Lbl_Address
        '
        Me.Lbl_Address.AutoSize = True
        Me.Lbl_Address.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Lbl_Address.Font = New System.Drawing.Font("Rockwell Condensed", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Address.ForeColor = System.Drawing.Color.Red
        Me.Lbl_Address.Location = New System.Drawing.Point(54, 211)
        Me.Lbl_Address.Name = "Lbl_Address"
        Me.Lbl_Address.Size = New System.Drawing.Size(73, 29)
        Me.Lbl_Address.TabIndex = 126
        Me.Lbl_Address.Text = "Address"
        '
        'Lbl_Employee_ID
        '
        Me.Lbl_Employee_ID.AutoSize = True
        Me.Lbl_Employee_ID.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Lbl_Employee_ID.Font = New System.Drawing.Font("Rockwell Condensed", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Employee_ID.ForeColor = System.Drawing.Color.Red
        Me.Lbl_Employee_ID.Location = New System.Drawing.Point(54, 63)
        Me.Lbl_Employee_ID.Name = "Lbl_Employee_ID"
        Me.Lbl_Employee_ID.Size = New System.Drawing.Size(109, 29)
        Me.Lbl_Employee_ID.TabIndex = 125
        Me.Lbl_Employee_ID.Text = "Employee ID"
        '
        'Lbl_Employee_Name
        '
        Me.Lbl_Employee_Name.AutoSize = True
        Me.Lbl_Employee_Name.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Lbl_Employee_Name.Font = New System.Drawing.Font("Rockwell Condensed", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Employee_Name.ForeColor = System.Drawing.Color.Red
        Me.Lbl_Employee_Name.Location = New System.Drawing.Point(54, 133)
        Me.Lbl_Employee_Name.Name = "Lbl_Employee_Name"
        Me.Lbl_Employee_Name.Size = New System.Drawing.Size(133, 29)
        Me.Lbl_Employee_Name.TabIndex = 124
        Me.Lbl_Employee_Name.Text = "Employee Name"
        '
        'Frm_Add_Employee_Details
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1350, 729)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Gp_Employee_details)
        Me.Name = "Frm_Add_Employee_Details"
        Me.Text = "Add Employee Details"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Gp_Employee_details.ResumeLayout(False)
        Me.Gp_Employee_details.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Tb_Contact_No_2 As System.Windows.Forms.TextBox
    Friend WithEvents Tb_Contact_No_1 As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_Contact_No_2 As System.Windows.Forms.Label
    Friend WithEvents Lbl_Contact_No_1 As System.Windows.Forms.Label
    Friend WithEvents Tb_Employee_Name As System.Windows.Forms.TextBox
    Friend WithEvents Tb_Employee_ID As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Lbl_Add_Employee As System.Windows.Forms.Label
    Friend WithEvents Tb_Exprience As System.Windows.Forms.TextBox
    Friend WithEvents Tb_Education As System.Windows.Forms.TextBox
    Friend WithEvents Btn_SAVE As System.Windows.Forms.Button
    Friend WithEvents Tb_Salary As System.Windows.Forms.TextBox
    Friend WithEvents Gp_Employee_details As System.Windows.Forms.GroupBox
    Friend WithEvents Lbl_Joining_Date As System.Windows.Forms.Label
    Friend WithEvents Lbl_Exprience As System.Windows.Forms.Label
    Friend WithEvents Lbl_Education As System.Windows.Forms.Label
    Friend WithEvents Lbl_Salary As System.Windows.Forms.Label
    Friend WithEvents Tb_Address As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_Address As System.Windows.Forms.Label
    Friend WithEvents Lbl_Employee_Name As System.Windows.Forms.Label
    Friend WithEvents Btn_CLEAR As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Dtp_Joining_Date As System.Windows.Forms.DateTimePicker
    Friend WithEvents Lbl_Employee_ID As System.Windows.Forms.Label
End Class
