<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Add_Lab_Details
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Add_Lab_Details))
        Me.Tb_Contact_No_1 = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Lbl_Add_Lab_Details = New System.Windows.Forms.Label()
        Me.Tb_Contact_No_2 = New System.Windows.Forms.TextBox()
        Me.Tb_Charges = New System.Windows.Forms.TextBox()
        Me.Lbl_Contact_No_2 = New System.Windows.Forms.Label()
        Me.Lbl_Contact_No_1 = New System.Windows.Forms.Label()
        Me.Tb_Address = New System.Windows.Forms.TextBox()
        Me.Tb_Test_Cases = New System.Windows.Forms.TextBox()
        Me.Lbl_Charges = New System.Windows.Forms.Label()
        Me.Lbl_Test_Cases = New System.Windows.Forms.Label()
        Me.Lbl_Lab_Address = New System.Windows.Forms.Label()
        Me.Tb_Owner_Name = New System.Windows.Forms.TextBox()
        Me.Lbl_Owner_Name = New System.Windows.Forms.Label()
        Me.Tb_Lab_Name = New System.Windows.Forms.TextBox()
        Me.Lbl_Lab_Name = New System.Windows.Forms.Label()
        Me.Gp_Laboratory_Information = New System.Windows.Forms.GroupBox()
        Me.Tb_Lab_ID = New System.Windows.Forms.TextBox()
        Me.Lbl_Lab_ID = New System.Windows.Forms.Label()
        Me.Btn_SAVE = New System.Windows.Forms.Button()
        Me.Gp_Test_Cases = New System.Windows.Forms.GroupBox()
        Me.Btn_Add = New System.Windows.Forms.Button()
        Me.Dgv_Test_Cases = New System.Windows.Forms.DataGridView()
        Me.Lab_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Test_Cases = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Charges = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Btn_CLEAR = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Gp_Laboratory_Information.SuspendLayout()
        Me.Gp_Test_Cases.SuspendLayout()
        CType(Me.Dgv_Test_Cases, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Tb_Contact_No_1
        '
        Me.Tb_Contact_No_1.Font = New System.Drawing.Font("Rockwell Condensed", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tb_Contact_No_1.Location = New System.Drawing.Point(243, 385)
        Me.Tb_Contact_No_1.MaxLength = 10
        Me.Tb_Contact_No_1.Name = "Tb_Contact_No_1"
        Me.Tb_Contact_No_1.Size = New System.Drawing.Size(267, 36)
        Me.Tb_Contact_No_1.TabIndex = 5
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Blue
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Lbl_Add_Lab_Details)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1350, 92)
        Me.Panel1.TabIndex = 153
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(261, 92)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 93
        Me.PictureBox1.TabStop = False
        '
        'Lbl_Add_Lab_Details
        '
        Me.Lbl_Add_Lab_Details.AutoSize = True
        Me.Lbl_Add_Lab_Details.Font = New System.Drawing.Font("Rockwell Condensed", 48.0!, System.Drawing.FontStyle.Bold)
        Me.Lbl_Add_Lab_Details.ForeColor = System.Drawing.Color.LemonChiffon
        Me.Lbl_Add_Lab_Details.Image = CType(resources.GetObject("Lbl_Add_Lab_Details.Image"), System.Drawing.Image)
        Me.Lbl_Add_Lab_Details.Location = New System.Drawing.Point(512, 9)
        Me.Lbl_Add_Lab_Details.Name = "Lbl_Add_Lab_Details"
        Me.Lbl_Add_Lab_Details.Size = New System.Drawing.Size(438, 75)
        Me.Lbl_Add_Lab_Details.TabIndex = 63
        Me.Lbl_Add_Lab_Details.Text = "Add Lab Details"
        '
        'Tb_Contact_No_2
        '
        Me.Tb_Contact_No_2.Font = New System.Drawing.Font("Rockwell Condensed", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tb_Contact_No_2.Location = New System.Drawing.Point(243, 428)
        Me.Tb_Contact_No_2.MaxLength = 10
        Me.Tb_Contact_No_2.Name = "Tb_Contact_No_2"
        Me.Tb_Contact_No_2.Size = New System.Drawing.Size(267, 36)
        Me.Tb_Contact_No_2.TabIndex = 6
        '
        'Tb_Charges
        '
        Me.Tb_Charges.Font = New System.Drawing.Font("Rockwell Condensed", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tb_Charges.Location = New System.Drawing.Point(237, 106)
        Me.Tb_Charges.Name = "Tb_Charges"
        Me.Tb_Charges.Size = New System.Drawing.Size(139, 36)
        Me.Tb_Charges.TabIndex = 8
        '
        'Lbl_Contact_No_2
        '
        Me.Lbl_Contact_No_2.AutoSize = True
        Me.Lbl_Contact_No_2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Lbl_Contact_No_2.Font = New System.Drawing.Font("Rockwell Condensed", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Contact_No_2.ForeColor = System.Drawing.Color.Red
        Me.Lbl_Contact_No_2.Location = New System.Drawing.Point(55, 428)
        Me.Lbl_Contact_No_2.Name = "Lbl_Contact_No_2"
        Me.Lbl_Contact_No_2.Size = New System.Drawing.Size(109, 29)
        Me.Lbl_Contact_No_2.TabIndex = 203
        Me.Lbl_Contact_No_2.Text = "Contact No.2"
        '
        'Lbl_Contact_No_1
        '
        Me.Lbl_Contact_No_1.AutoSize = True
        Me.Lbl_Contact_No_1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Lbl_Contact_No_1.Font = New System.Drawing.Font("Rockwell Condensed", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Contact_No_1.ForeColor = System.Drawing.Color.Red
        Me.Lbl_Contact_No_1.Location = New System.Drawing.Point(55, 375)
        Me.Lbl_Contact_No_1.Name = "Lbl_Contact_No_1"
        Me.Lbl_Contact_No_1.Size = New System.Drawing.Size(109, 29)
        Me.Lbl_Contact_No_1.TabIndex = 202
        Me.Lbl_Contact_No_1.Text = "Contact No.1"
        '
        'Tb_Address
        '
        Me.Tb_Address.Font = New System.Drawing.Font("Rockwell Condensed", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tb_Address.Location = New System.Drawing.Point(243, 259)
        Me.Tb_Address.Multiline = True
        Me.Tb_Address.Name = "Tb_Address"
        Me.Tb_Address.Size = New System.Drawing.Size(267, 86)
        Me.Tb_Address.TabIndex = 4
        '
        'Tb_Test_Cases
        '
        Me.Tb_Test_Cases.Font = New System.Drawing.Font("Rockwell Condensed", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tb_Test_Cases.Location = New System.Drawing.Point(38, 106)
        Me.Tb_Test_Cases.Name = "Tb_Test_Cases"
        Me.Tb_Test_Cases.Size = New System.Drawing.Size(176, 36)
        Me.Tb_Test_Cases.TabIndex = 7
        '
        'Lbl_Charges
        '
        Me.Lbl_Charges.AutoSize = True
        Me.Lbl_Charges.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Lbl_Charges.Font = New System.Drawing.Font("Rockwell Condensed", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Charges.ForeColor = System.Drawing.Color.Red
        Me.Lbl_Charges.Location = New System.Drawing.Point(265, 43)
        Me.Lbl_Charges.Name = "Lbl_Charges"
        Me.Lbl_Charges.Size = New System.Drawing.Size(73, 29)
        Me.Lbl_Charges.TabIndex = 209
        Me.Lbl_Charges.Text = "Charges"
        '
        'Lbl_Test_Cases
        '
        Me.Lbl_Test_Cases.AutoSize = True
        Me.Lbl_Test_Cases.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Lbl_Test_Cases.Font = New System.Drawing.Font("Rockwell Condensed", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Test_Cases.ForeColor = System.Drawing.Color.Red
        Me.Lbl_Test_Cases.Location = New System.Drawing.Point(63, 43)
        Me.Lbl_Test_Cases.Name = "Lbl_Test_Cases"
        Me.Lbl_Test_Cases.Size = New System.Drawing.Size(96, 29)
        Me.Lbl_Test_Cases.TabIndex = 208
        Me.Lbl_Test_Cases.Text = "Test Cases"
        '
        'Lbl_Lab_Address
        '
        Me.Lbl_Lab_Address.AutoSize = True
        Me.Lbl_Lab_Address.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Lbl_Lab_Address.Font = New System.Drawing.Font("Rockwell Condensed", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Lab_Address.ForeColor = System.Drawing.Color.Red
        Me.Lbl_Lab_Address.Location = New System.Drawing.Point(55, 259)
        Me.Lbl_Lab_Address.Name = "Lbl_Lab_Address"
        Me.Lbl_Lab_Address.Size = New System.Drawing.Size(108, 29)
        Me.Lbl_Lab_Address.TabIndex = 200
        Me.Lbl_Lab_Address.Text = "Lab Address"
        '
        'Tb_Owner_Name
        '
        Me.Tb_Owner_Name.Font = New System.Drawing.Font("Rockwell Condensed", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tb_Owner_Name.Location = New System.Drawing.Point(243, 188)
        Me.Tb_Owner_Name.Name = "Tb_Owner_Name"
        Me.Tb_Owner_Name.Size = New System.Drawing.Size(267, 36)
        Me.Tb_Owner_Name.TabIndex = 3
        '
        'Lbl_Owner_Name
        '
        Me.Lbl_Owner_Name.AutoSize = True
        Me.Lbl_Owner_Name.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Lbl_Owner_Name.Font = New System.Drawing.Font("Rockwell Condensed", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Owner_Name.ForeColor = System.Drawing.Color.Red
        Me.Lbl_Owner_Name.Location = New System.Drawing.Point(54, 195)
        Me.Lbl_Owner_Name.Name = "Lbl_Owner_Name"
        Me.Lbl_Owner_Name.Size = New System.Drawing.Size(110, 29)
        Me.Lbl_Owner_Name.TabIndex = 198
        Me.Lbl_Owner_Name.Text = "Owner Name"
        '
        'Tb_Lab_Name
        '
        Me.Tb_Lab_Name.Font = New System.Drawing.Font("Rockwell Condensed", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tb_Lab_Name.Location = New System.Drawing.Point(243, 119)
        Me.Tb_Lab_Name.Name = "Tb_Lab_Name"
        Me.Tb_Lab_Name.Size = New System.Drawing.Size(267, 36)
        Me.Tb_Lab_Name.TabIndex = 2
        '
        'Lbl_Lab_Name
        '
        Me.Lbl_Lab_Name.AutoSize = True
        Me.Lbl_Lab_Name.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Lbl_Lab_Name.Font = New System.Drawing.Font("Rockwell Condensed", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Lab_Name.ForeColor = System.Drawing.Color.Red
        Me.Lbl_Lab_Name.Location = New System.Drawing.Point(55, 122)
        Me.Lbl_Lab_Name.Name = "Lbl_Lab_Name"
        Me.Lbl_Lab_Name.Size = New System.Drawing.Size(89, 29)
        Me.Lbl_Lab_Name.TabIndex = 196
        Me.Lbl_Lab_Name.Text = "Lab Name"
        '
        'Gp_Laboratory_Information
        '
        Me.Gp_Laboratory_Information.Controls.Add(Me.Tb_Contact_No_2)
        Me.Gp_Laboratory_Information.Controls.Add(Me.Tb_Contact_No_1)
        Me.Gp_Laboratory_Information.Controls.Add(Me.Lbl_Contact_No_2)
        Me.Gp_Laboratory_Information.Controls.Add(Me.Lbl_Contact_No_1)
        Me.Gp_Laboratory_Information.Controls.Add(Me.Tb_Address)
        Me.Gp_Laboratory_Information.Controls.Add(Me.Lbl_Lab_Address)
        Me.Gp_Laboratory_Information.Controls.Add(Me.Tb_Owner_Name)
        Me.Gp_Laboratory_Information.Controls.Add(Me.Lbl_Owner_Name)
        Me.Gp_Laboratory_Information.Controls.Add(Me.Tb_Lab_Name)
        Me.Gp_Laboratory_Information.Controls.Add(Me.Lbl_Lab_Name)
        Me.Gp_Laboratory_Information.Controls.Add(Me.Tb_Lab_ID)
        Me.Gp_Laboratory_Information.Controls.Add(Me.Lbl_Lab_ID)
        Me.Gp_Laboratory_Information.Font = New System.Drawing.Font("Rockwell Condensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Gp_Laboratory_Information.Location = New System.Drawing.Point(116, 136)
        Me.Gp_Laboratory_Information.Name = "Gp_Laboratory_Information"
        Me.Gp_Laboratory_Information.Size = New System.Drawing.Size(551, 513)
        Me.Gp_Laboratory_Information.TabIndex = 154
        Me.Gp_Laboratory_Information.TabStop = False
        Me.Gp_Laboratory_Information.Text = "Laboratory Information"
        '
        'Tb_Lab_ID
        '
        Me.Tb_Lab_ID.Enabled = False
        Me.Tb_Lab_ID.Font = New System.Drawing.Font("Rockwell Condensed", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tb_Lab_ID.Location = New System.Drawing.Point(243, 52)
        Me.Tb_Lab_ID.Name = "Tb_Lab_ID"
        Me.Tb_Lab_ID.Size = New System.Drawing.Size(267, 36)
        Me.Tb_Lab_ID.TabIndex = 567
        '
        'Lbl_Lab_ID
        '
        Me.Lbl_Lab_ID.AutoSize = True
        Me.Lbl_Lab_ID.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Lbl_Lab_ID.Font = New System.Drawing.Font("Rockwell Condensed", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Lab_ID.ForeColor = System.Drawing.Color.Red
        Me.Lbl_Lab_ID.Location = New System.Drawing.Point(55, 55)
        Me.Lbl_Lab_ID.Name = "Lbl_Lab_ID"
        Me.Lbl_Lab_ID.Size = New System.Drawing.Size(65, 29)
        Me.Lbl_Lab_ID.TabIndex = 194
        Me.Lbl_Lab_ID.Text = "Lab ID"
        '
        'Btn_SAVE
        '
        Me.Btn_SAVE.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Btn_SAVE.Font = New System.Drawing.Font("Rockwell Condensed", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_SAVE.ForeColor = System.Drawing.Color.Cornsilk
        Me.Btn_SAVE.Location = New System.Drawing.Point(732, 608)
        Me.Btn_SAVE.Name = "Btn_SAVE"
        Me.Btn_SAVE.Size = New System.Drawing.Size(144, 60)
        Me.Btn_SAVE.TabIndex = 151
        Me.Btn_SAVE.Text = "SAVE"
        Me.Btn_SAVE.UseVisualStyleBackColor = False
        '
        'Gp_Test_Cases
        '
        Me.Gp_Test_Cases.Controls.Add(Me.Btn_Add)
        Me.Gp_Test_Cases.Controls.Add(Me.Dgv_Test_Cases)
        Me.Gp_Test_Cases.Controls.Add(Me.Tb_Charges)
        Me.Gp_Test_Cases.Controls.Add(Me.Tb_Test_Cases)
        Me.Gp_Test_Cases.Controls.Add(Me.Lbl_Charges)
        Me.Gp_Test_Cases.Controls.Add(Me.Lbl_Test_Cases)
        Me.Gp_Test_Cases.Font = New System.Drawing.Font("Rockwell Condensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Gp_Test_Cases.Location = New System.Drawing.Point(694, 145)
        Me.Gp_Test_Cases.Name = "Gp_Test_Cases"
        Me.Gp_Test_Cases.Size = New System.Drawing.Size(542, 412)
        Me.Gp_Test_Cases.TabIndex = 155
        Me.Gp_Test_Cases.TabStop = False
        Me.Gp_Test_Cases.Text = "Test Cases"
        '
        'Btn_Add
        '
        Me.Btn_Add.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Btn_Add.Font = New System.Drawing.Font("Rockwell Condensed", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Add.ForeColor = System.Drawing.Color.Cornsilk
        Me.Btn_Add.Location = New System.Drawing.Point(406, 100)
        Me.Btn_Add.Name = "Btn_Add"
        Me.Btn_Add.Size = New System.Drawing.Size(94, 42)
        Me.Btn_Add.TabIndex = 156
        Me.Btn_Add.Text = "ADD"
        Me.Btn_Add.UseVisualStyleBackColor = False
        '
        'Dgv_Test_Cases
        '
        Me.Dgv_Test_Cases.AllowUserToAddRows = False
        Me.Dgv_Test_Cases.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Dgv_Test_Cases.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv_Test_Cases.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Lab_ID, Me.Test_Cases, Me.Charges})
        Me.Dgv_Test_Cases.Location = New System.Drawing.Point(38, 179)
        Me.Dgv_Test_Cases.Name = "Dgv_Test_Cases"
        Me.Dgv_Test_Cases.ReadOnly = True
        Me.Dgv_Test_Cases.Size = New System.Drawing.Size(493, 213)
        Me.Dgv_Test_Cases.TabIndex = 210
        '
        'Lab_ID
        '
        Me.Lab_ID.HeaderText = "Lab ID"
        Me.Lab_ID.Name = "Lab_ID"
        Me.Lab_ID.ReadOnly = True
        Me.Lab_ID.Visible = False
        '
        'Test_Cases
        '
        Me.Test_Cases.HeaderText = "Test Cases"
        Me.Test_Cases.Name = "Test_Cases"
        Me.Test_Cases.ReadOnly = True
        '
        'Charges
        '
        Me.Charges.HeaderText = "Charges"
        Me.Charges.Name = "Charges"
        Me.Charges.ReadOnly = True
        '
        'Btn_CLEAR
        '
        Me.Btn_CLEAR.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Btn_CLEAR.Font = New System.Drawing.Font("Rockwell", 21.75!, System.Drawing.FontStyle.Bold)
        Me.Btn_CLEAR.ForeColor = System.Drawing.SystemColors.Control
        Me.Btn_CLEAR.Location = New System.Drawing.Point(1007, 608)
        Me.Btn_CLEAR.Name = "Btn_CLEAR"
        Me.Btn_CLEAR.Size = New System.Drawing.Size(144, 60)
        Me.Btn_CLEAR.TabIndex = 152
        Me.Btn_CLEAR.Text = "CLEAR"
        Me.Btn_CLEAR.UseVisualStyleBackColor = False
        '
        'Frm_Add_Lab_Details
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1350, 729)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Gp_Laboratory_Information)
        Me.Controls.Add(Me.Btn_SAVE)
        Me.Controls.Add(Me.Gp_Test_Cases)
        Me.Controls.Add(Me.Btn_CLEAR)
        Me.Name = "Frm_Add_Lab_Details"
        Me.Text = "Add Lab Details"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Gp_Laboratory_Information.ResumeLayout(False)
        Me.Gp_Laboratory_Information.PerformLayout()
        Me.Gp_Test_Cases.ResumeLayout(False)
        Me.Gp_Test_Cases.PerformLayout()
        CType(Me.Dgv_Test_Cases, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Tb_Contact_No_1 As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Lbl_Add_Lab_Details As System.Windows.Forms.Label
    Friend WithEvents Tb_Contact_No_2 As System.Windows.Forms.TextBox
    Friend WithEvents Tb_Charges As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_Contact_No_2 As System.Windows.Forms.Label
    Friend WithEvents Lbl_Contact_No_1 As System.Windows.Forms.Label
    Friend WithEvents Tb_Address As System.Windows.Forms.TextBox
    Friend WithEvents Tb_Test_Cases As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_Charges As System.Windows.Forms.Label
    Friend WithEvents Lbl_Test_Cases As System.Windows.Forms.Label
    Friend WithEvents Lbl_Lab_Address As System.Windows.Forms.Label
    Friend WithEvents Tb_Owner_Name As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_Owner_Name As System.Windows.Forms.Label
    Friend WithEvents Tb_Lab_Name As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_Lab_Name As System.Windows.Forms.Label
    Friend WithEvents Gp_Laboratory_Information As System.Windows.Forms.GroupBox
    Friend WithEvents Tb_Lab_ID As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_Lab_ID As System.Windows.Forms.Label
    Friend WithEvents Btn_SAVE As System.Windows.Forms.Button
    Friend WithEvents Gp_Test_Cases As System.Windows.Forms.GroupBox
    Friend WithEvents Btn_CLEAR As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Btn_Add As System.Windows.Forms.Button
    Friend WithEvents Dgv_Test_Cases As System.Windows.Forms.DataGridView
    Friend WithEvents Lab_ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Test_Cases As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Charges As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
