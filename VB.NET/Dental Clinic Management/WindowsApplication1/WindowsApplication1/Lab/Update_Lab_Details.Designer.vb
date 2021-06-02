<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Update_Lab_Details
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Update_Lab_Details))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Lbl_Update_Lab_Details = New System.Windows.Forms.Label()
        Me.Tb_Contact_No_1 = New System.Windows.Forms.TextBox()
        Me.Lbl_Contact_No_2 = New System.Windows.Forms.Label()
        Me.Lbl_Contact_No_1 = New System.Windows.Forms.Label()
        Me.Tb_Address = New System.Windows.Forms.TextBox()
        Me.Lbl_Owner_Name = New System.Windows.Forms.Label()
        Me.Tb_Lab_Name = New System.Windows.Forms.TextBox()
        Me.Lbl_Lab_Name = New System.Windows.Forms.Label()
        Me.Lbl_Address = New System.Windows.Forms.Label()
        Me.Tb_Owner_Name = New System.Windows.Forms.TextBox()
        Me.Tb_Contact_No_2 = New System.Windows.Forms.TextBox()
        Me.Gp_Laboratory_Information = New System.Windows.Forms.GroupBox()
        Me.Btn_CLEAR = New System.Windows.Forms.Button()
        Me.Btn_UPDATE = New System.Windows.Forms.Button()
        Me.Gp_Test_Cases = New System.Windows.Forms.GroupBox()
        Me.Dgv_Test_Cases = New System.Windows.Forms.DataGridView()
        Me.Lab_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Test_Cases = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Charges = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Btn_SEARCH = New System.Windows.Forms.Button()
        Me.Tb_Lab_ID = New System.Windows.Forms.TextBox()
        Me.Lbl_Lab_ID = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Gp_Laboratory_Information.SuspendLayout()
        Me.Gp_Test_Cases.SuspendLayout()
        CType(Me.Dgv_Test_Cases, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Blue
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Lbl_Update_Lab_Details)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
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
        Me.PictureBox1.Size = New System.Drawing.Size(250, 92)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 94
        Me.PictureBox1.TabStop = False
        '
        'Lbl_Update_Lab_Details
        '
        Me.Lbl_Update_Lab_Details.AutoSize = True
        Me.Lbl_Update_Lab_Details.Font = New System.Drawing.Font("Rockwell Condensed", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Update_Lab_Details.ForeColor = System.Drawing.Color.LemonChiffon
        Me.Lbl_Update_Lab_Details.Image = CType(resources.GetObject("Lbl_Update_Lab_Details.Image"), System.Drawing.Image)
        Me.Lbl_Update_Lab_Details.Location = New System.Drawing.Point(511, 9)
        Me.Lbl_Update_Lab_Details.Name = "Lbl_Update_Lab_Details"
        Me.Lbl_Update_Lab_Details.Size = New System.Drawing.Size(534, 75)
        Me.Lbl_Update_Lab_Details.TabIndex = 63
        Me.Lbl_Update_Lab_Details.Text = "Update Lab Details "
        '
        'Tb_Contact_No_1
        '
        Me.Tb_Contact_No_1.Font = New System.Drawing.Font("Rockwell Condensed", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tb_Contact_No_1.Location = New System.Drawing.Point(246, 314)
        Me.Tb_Contact_No_1.Name = "Tb_Contact_No_1"
        Me.Tb_Contact_No_1.Size = New System.Drawing.Size(267, 36)
        Me.Tb_Contact_No_1.TabIndex = 204
        '
        'Lbl_Contact_No_2
        '
        Me.Lbl_Contact_No_2.AutoSize = True
        Me.Lbl_Contact_No_2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Lbl_Contact_No_2.Font = New System.Drawing.Font("Rockwell Condensed", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Contact_No_2.ForeColor = System.Drawing.Color.Red
        Me.Lbl_Contact_No_2.Location = New System.Drawing.Point(58, 370)
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
        Me.Lbl_Contact_No_1.Location = New System.Drawing.Point(58, 317)
        Me.Lbl_Contact_No_1.Name = "Lbl_Contact_No_1"
        Me.Lbl_Contact_No_1.Size = New System.Drawing.Size(109, 29)
        Me.Lbl_Contact_No_1.TabIndex = 202
        Me.Lbl_Contact_No_1.Text = "Contact No.1"
        '
        'Tb_Address
        '
        Me.Tb_Address.Font = New System.Drawing.Font("Rockwell Condensed", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tb_Address.Location = New System.Drawing.Point(246, 201)
        Me.Tb_Address.Multiline = True
        Me.Tb_Address.Name = "Tb_Address"
        Me.Tb_Address.Size = New System.Drawing.Size(267, 86)
        Me.Tb_Address.TabIndex = 201
        '
        'Lbl_Owner_Name
        '
        Me.Lbl_Owner_Name.AutoSize = True
        Me.Lbl_Owner_Name.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Lbl_Owner_Name.Font = New System.Drawing.Font("Rockwell Condensed", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Owner_Name.ForeColor = System.Drawing.Color.Red
        Me.Lbl_Owner_Name.Location = New System.Drawing.Point(57, 137)
        Me.Lbl_Owner_Name.Name = "Lbl_Owner_Name"
        Me.Lbl_Owner_Name.Size = New System.Drawing.Size(110, 29)
        Me.Lbl_Owner_Name.TabIndex = 198
        Me.Lbl_Owner_Name.Text = "Owner Name"
        '
        'Tb_Lab_Name
        '
        Me.Tb_Lab_Name.Enabled = False
        Me.Tb_Lab_Name.Font = New System.Drawing.Font("Rockwell Condensed", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tb_Lab_Name.Location = New System.Drawing.Point(246, 61)
        Me.Tb_Lab_Name.Name = "Tb_Lab_Name"
        Me.Tb_Lab_Name.Size = New System.Drawing.Size(267, 36)
        Me.Tb_Lab_Name.TabIndex = 197
        '
        'Lbl_Lab_Name
        '
        Me.Lbl_Lab_Name.AutoSize = True
        Me.Lbl_Lab_Name.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Lbl_Lab_Name.Font = New System.Drawing.Font("Rockwell Condensed", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Lab_Name.ForeColor = System.Drawing.Color.Red
        Me.Lbl_Lab_Name.Location = New System.Drawing.Point(58, 64)
        Me.Lbl_Lab_Name.Name = "Lbl_Lab_Name"
        Me.Lbl_Lab_Name.Size = New System.Drawing.Size(89, 29)
        Me.Lbl_Lab_Name.TabIndex = 196
        Me.Lbl_Lab_Name.Text = "Lab Name"
        '
        'Lbl_Address
        '
        Me.Lbl_Address.AutoSize = True
        Me.Lbl_Address.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Lbl_Address.Font = New System.Drawing.Font("Rockwell Condensed", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Address.ForeColor = System.Drawing.Color.Red
        Me.Lbl_Address.Location = New System.Drawing.Point(58, 201)
        Me.Lbl_Address.Name = "Lbl_Address"
        Me.Lbl_Address.Size = New System.Drawing.Size(73, 29)
        Me.Lbl_Address.TabIndex = 200
        Me.Lbl_Address.Text = "Address"
        '
        'Tb_Owner_Name
        '
        Me.Tb_Owner_Name.Font = New System.Drawing.Font("Rockwell Condensed", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tb_Owner_Name.Location = New System.Drawing.Point(246, 130)
        Me.Tb_Owner_Name.Name = "Tb_Owner_Name"
        Me.Tb_Owner_Name.Size = New System.Drawing.Size(267, 36)
        Me.Tb_Owner_Name.TabIndex = 199
        '
        'Tb_Contact_No_2
        '
        Me.Tb_Contact_No_2.Font = New System.Drawing.Font("Rockwell Condensed", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tb_Contact_No_2.Location = New System.Drawing.Point(246, 370)
        Me.Tb_Contact_No_2.Name = "Tb_Contact_No_2"
        Me.Tb_Contact_No_2.Size = New System.Drawing.Size(267, 36)
        Me.Tb_Contact_No_2.TabIndex = 205
        '
        'Gp_Laboratory_Information
        '
        Me.Gp_Laboratory_Information.Controls.Add(Me.Tb_Contact_No_2)
        Me.Gp_Laboratory_Information.Controls.Add(Me.Tb_Contact_No_1)
        Me.Gp_Laboratory_Information.Controls.Add(Me.Lbl_Contact_No_2)
        Me.Gp_Laboratory_Information.Controls.Add(Me.Lbl_Contact_No_1)
        Me.Gp_Laboratory_Information.Controls.Add(Me.Tb_Address)
        Me.Gp_Laboratory_Information.Controls.Add(Me.Lbl_Address)
        Me.Gp_Laboratory_Information.Controls.Add(Me.Tb_Owner_Name)
        Me.Gp_Laboratory_Information.Controls.Add(Me.Lbl_Owner_Name)
        Me.Gp_Laboratory_Information.Controls.Add(Me.Tb_Lab_Name)
        Me.Gp_Laboratory_Information.Controls.Add(Me.Lbl_Lab_Name)
        Me.Gp_Laboratory_Information.Font = New System.Drawing.Font("Rockwell Condensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Gp_Laboratory_Information.Location = New System.Drawing.Point(103, 177)
        Me.Gp_Laboratory_Information.Name = "Gp_Laboratory_Information"
        Me.Gp_Laboratory_Information.Size = New System.Drawing.Size(570, 462)
        Me.Gp_Laboratory_Information.TabIndex = 172
        Me.Gp_Laboratory_Information.TabStop = False
        Me.Gp_Laboratory_Information.Text = "Laboratory Information"
        '
        'Btn_CLEAR
        '
        Me.Btn_CLEAR.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Btn_CLEAR.Font = New System.Drawing.Font("Rockwell", 21.75!, System.Drawing.FontStyle.Bold)
        Me.Btn_CLEAR.ForeColor = System.Drawing.SystemColors.Control
        Me.Btn_CLEAR.Location = New System.Drawing.Point(1025, 631)
        Me.Btn_CLEAR.Name = "Btn_CLEAR"
        Me.Btn_CLEAR.Size = New System.Drawing.Size(144, 52)
        Me.Btn_CLEAR.TabIndex = 174
        Me.Btn_CLEAR.Text = "CLEAR"
        Me.Btn_CLEAR.UseVisualStyleBackColor = False
        '
        'Btn_UPDATE
        '
        Me.Btn_UPDATE.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Btn_UPDATE.Font = New System.Drawing.Font("Rockwell Condensed", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_UPDATE.ForeColor = System.Drawing.Color.Cornsilk
        Me.Btn_UPDATE.Location = New System.Drawing.Point(788, 631)
        Me.Btn_UPDATE.Name = "Btn_UPDATE"
        Me.Btn_UPDATE.Size = New System.Drawing.Size(144, 52)
        Me.Btn_UPDATE.TabIndex = 171
        Me.Btn_UPDATE.Text = "UPDATE"
        Me.Btn_UPDATE.UseVisualStyleBackColor = False
        '
        'Gp_Test_Cases
        '
        Me.Gp_Test_Cases.Controls.Add(Me.Dgv_Test_Cases)
        Me.Gp_Test_Cases.Font = New System.Drawing.Font("Rockwell Condensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Gp_Test_Cases.Location = New System.Drawing.Point(691, 179)
        Me.Gp_Test_Cases.Name = "Gp_Test_Cases"
        Me.Gp_Test_Cases.Size = New System.Drawing.Size(544, 412)
        Me.Gp_Test_Cases.TabIndex = 173
        Me.Gp_Test_Cases.TabStop = False
        Me.Gp_Test_Cases.Text = "Test Cases"
        '
        'Dgv_Test_Cases
        '
        Me.Dgv_Test_Cases.AllowUserToAddRows = False
        Me.Dgv_Test_Cases.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Dgv_Test_Cases.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv_Test_Cases.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Lab_ID, Me.Test_Cases, Me.Charges})
        Me.Dgv_Test_Cases.Enabled = False
        Me.Dgv_Test_Cases.Location = New System.Drawing.Point(23, 59)
        Me.Dgv_Test_Cases.Name = "Dgv_Test_Cases"
        Me.Dgv_Test_Cases.ReadOnly = True
        Me.Dgv_Test_Cases.Size = New System.Drawing.Size(493, 329)
        Me.Dgv_Test_Cases.TabIndex = 216
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
        'Btn_SEARCH
        '
        Me.Btn_SEARCH.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Btn_SEARCH.Enabled = False
        Me.Btn_SEARCH.Font = New System.Drawing.Font("Rockwell Condensed", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_SEARCH.ForeColor = System.Drawing.Color.Cornsilk
        Me.Btn_SEARCH.Location = New System.Drawing.Point(714, 98)
        Me.Btn_SEARCH.Name = "Btn_SEARCH"
        Me.Btn_SEARCH.Size = New System.Drawing.Size(144, 42)
        Me.Btn_SEARCH.TabIndex = 170
        Me.Btn_SEARCH.Text = "SEARCH"
        Me.Btn_SEARCH.UseVisualStyleBackColor = False
        '
        'Tb_Lab_ID
        '
        Me.Tb_Lab_ID.Font = New System.Drawing.Font("Rockwell Condensed", 20.25!, System.Drawing.FontStyle.Bold)
        Me.Tb_Lab_ID.Location = New System.Drawing.Point(419, 102)
        Me.Tb_Lab_ID.Name = "Tb_Lab_ID"
        Me.Tb_Lab_ID.Size = New System.Drawing.Size(267, 39)
        Me.Tb_Lab_ID.TabIndex = 169
        '
        'Lbl_Lab_ID
        '
        Me.Lbl_Lab_ID.AutoSize = True
        Me.Lbl_Lab_ID.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Lbl_Lab_ID.Font = New System.Drawing.Font("Rockwell Condensed", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Lab_ID.ForeColor = System.Drawing.Color.Black
        Me.Lbl_Lab_ID.Location = New System.Drawing.Point(297, 110)
        Me.Lbl_Lab_ID.Name = "Lbl_Lab_ID"
        Me.Lbl_Lab_ID.Size = New System.Drawing.Size(88, 31)
        Me.Lbl_Lab_ID.TabIndex = 168
        Me.Lbl_Lab_ID.Text = "Lab ID"
        '
        'Frm_Update_Lab_Details
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1350, 729)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Gp_Laboratory_Information)
        Me.Controls.Add(Me.Btn_CLEAR)
        Me.Controls.Add(Me.Btn_UPDATE)
        Me.Controls.Add(Me.Gp_Test_Cases)
        Me.Controls.Add(Me.Btn_SEARCH)
        Me.Controls.Add(Me.Tb_Lab_ID)
        Me.Controls.Add(Me.Lbl_Lab_ID)
        Me.Name = "Frm_Update_Lab_Details"
        Me.Text = "Update Lab Details"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Gp_Laboratory_Information.ResumeLayout(False)
        Me.Gp_Laboratory_Information.PerformLayout()
        Me.Gp_Test_Cases.ResumeLayout(False)
        CType(Me.Dgv_Test_Cases, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Lbl_Update_Lab_Details As System.Windows.Forms.Label
    Friend WithEvents Tb_Contact_No_1 As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_Contact_No_2 As System.Windows.Forms.Label
    Friend WithEvents Lbl_Contact_No_1 As System.Windows.Forms.Label
    Friend WithEvents Tb_Address As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_Owner_Name As System.Windows.Forms.Label
    Friend WithEvents Tb_Lab_Name As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_Lab_Name As System.Windows.Forms.Label
    Friend WithEvents Lbl_Address As System.Windows.Forms.Label
    Friend WithEvents Tb_Owner_Name As System.Windows.Forms.TextBox
    Friend WithEvents Tb_Contact_No_2 As System.Windows.Forms.TextBox
    Friend WithEvents Gp_Laboratory_Information As System.Windows.Forms.GroupBox
    Friend WithEvents Btn_CLEAR As System.Windows.Forms.Button
    Friend WithEvents Btn_UPDATE As System.Windows.Forms.Button
    Friend WithEvents Gp_Test_Cases As System.Windows.Forms.GroupBox
    Friend WithEvents Btn_SEARCH As System.Windows.Forms.Button
    Friend WithEvents Tb_Lab_ID As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_Lab_ID As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Dgv_Test_Cases As System.Windows.Forms.DataGridView
    Friend WithEvents Lab_ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Test_Cases As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Charges As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
