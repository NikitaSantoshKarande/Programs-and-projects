<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Search_Lab_Details
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Search_Lab_Details))
        Me.Btn_SEARCH = New System.Windows.Forms.Button()
        Me.Tb_Contact_No_1 = New System.Windows.Forms.TextBox()
        Me.Lbl_Contact_No_2 = New System.Windows.Forms.Label()
        Me.Lbl_Contact_No_1 = New System.Windows.Forms.Label()
        Me.Tb_Address = New System.Windows.Forms.TextBox()
        Me.Lbl_Address = New System.Windows.Forms.Label()
        Me.Lbl_Lab_Name = New System.Windows.Forms.Label()
        Me.Tb_Lab_Name = New System.Windows.Forms.TextBox()
        Me.Lbl_Owner_Name = New System.Windows.Forms.Label()
        Me.Tb_Owner_Name = New System.Windows.Forms.TextBox()
        Me.Tb_Contact_No_2 = New System.Windows.Forms.TextBox()
        Me.Lbl_Search_Lab_Details = New System.Windows.Forms.Label()
        Me.Gp_Test_Cases = New System.Windows.Forms.GroupBox()
        Me.Dgv_Test_Cases = New System.Windows.Forms.DataGridView()
        Me.Lab_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Test_Cases = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Charges = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Gp_Laboratory_Information = New System.Windows.Forms.GroupBox()
        Me.Btn_CLEAR = New System.Windows.Forms.Button()
        Me.Tb_Lab_ID = New System.Windows.Forms.TextBox()
        Me.Lbl_Lab_ID = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Gp_Test_Cases.SuspendLayout()
        CType(Me.Dgv_Test_Cases, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Gp_Laboratory_Information.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Btn_SEARCH
        '
        Me.Btn_SEARCH.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Btn_SEARCH.Enabled = False
        Me.Btn_SEARCH.Font = New System.Drawing.Font("Rockwell Condensed", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_SEARCH.ForeColor = System.Drawing.Color.Cornsilk
        Me.Btn_SEARCH.Location = New System.Drawing.Point(766, 113)
        Me.Btn_SEARCH.Name = "Btn_SEARCH"
        Me.Btn_SEARCH.Size = New System.Drawing.Size(144, 42)
        Me.Btn_SEARCH.TabIndex = 186
        Me.Btn_SEARCH.Text = "SEARCH"
        Me.Btn_SEARCH.UseVisualStyleBackColor = False
        '
        'Tb_Contact_No_1
        '
        Me.Tb_Contact_No_1.Enabled = False
        Me.Tb_Contact_No_1.Font = New System.Drawing.Font("Rockwell Condensed", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tb_Contact_No_1.Location = New System.Drawing.Point(243, 293)
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
        Me.Lbl_Contact_No_2.Location = New System.Drawing.Point(54, 348)
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
        Me.Lbl_Contact_No_1.Location = New System.Drawing.Point(54, 293)
        Me.Lbl_Contact_No_1.Name = "Lbl_Contact_No_1"
        Me.Lbl_Contact_No_1.Size = New System.Drawing.Size(109, 29)
        Me.Lbl_Contact_No_1.TabIndex = 202
        Me.Lbl_Contact_No_1.Text = "Contact No.1"
        '
        'Tb_Address
        '
        Me.Tb_Address.Enabled = False
        Me.Tb_Address.Font = New System.Drawing.Font("Rockwell Condensed", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tb_Address.Location = New System.Drawing.Point(243, 177)
        Me.Tb_Address.Multiline = True
        Me.Tb_Address.Name = "Tb_Address"
        Me.Tb_Address.Size = New System.Drawing.Size(267, 86)
        Me.Tb_Address.TabIndex = 4
        '
        'Lbl_Address
        '
        Me.Lbl_Address.AutoSize = True
        Me.Lbl_Address.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Lbl_Address.Font = New System.Drawing.Font("Rockwell Condensed", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Address.ForeColor = System.Drawing.Color.Red
        Me.Lbl_Address.Location = New System.Drawing.Point(54, 177)
        Me.Lbl_Address.Name = "Lbl_Address"
        Me.Lbl_Address.Size = New System.Drawing.Size(73, 29)
        Me.Lbl_Address.TabIndex = 200
        Me.Lbl_Address.Text = "Address"
        '
        'Lbl_Lab_Name
        '
        Me.Lbl_Lab_Name.AutoSize = True
        Me.Lbl_Lab_Name.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Lbl_Lab_Name.Font = New System.Drawing.Font("Rockwell Condensed", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Lab_Name.ForeColor = System.Drawing.Color.Red
        Me.Lbl_Lab_Name.Location = New System.Drawing.Point(55, 66)
        Me.Lbl_Lab_Name.Name = "Lbl_Lab_Name"
        Me.Lbl_Lab_Name.Size = New System.Drawing.Size(89, 29)
        Me.Lbl_Lab_Name.TabIndex = 196
        Me.Lbl_Lab_Name.Text = "Lab Name"
        '
        'Tb_Lab_Name
        '
        Me.Tb_Lab_Name.Enabled = False
        Me.Tb_Lab_Name.Font = New System.Drawing.Font("Rockwell Condensed", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tb_Lab_Name.Location = New System.Drawing.Point(243, 63)
        Me.Tb_Lab_Name.Name = "Tb_Lab_Name"
        Me.Tb_Lab_Name.Size = New System.Drawing.Size(267, 36)
        Me.Tb_Lab_Name.TabIndex = 2
        '
        'Lbl_Owner_Name
        '
        Me.Lbl_Owner_Name.AutoSize = True
        Me.Lbl_Owner_Name.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Lbl_Owner_Name.Font = New System.Drawing.Font("Rockwell Condensed", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Owner_Name.ForeColor = System.Drawing.Color.Red
        Me.Lbl_Owner_Name.Location = New System.Drawing.Point(54, 121)
        Me.Lbl_Owner_Name.Name = "Lbl_Owner_Name"
        Me.Lbl_Owner_Name.Size = New System.Drawing.Size(110, 29)
        Me.Lbl_Owner_Name.TabIndex = 198
        Me.Lbl_Owner_Name.Text = "Owner Name"
        '
        'Tb_Owner_Name
        '
        Me.Tb_Owner_Name.Enabled = False
        Me.Tb_Owner_Name.Font = New System.Drawing.Font("Rockwell Condensed", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tb_Owner_Name.Location = New System.Drawing.Point(243, 114)
        Me.Tb_Owner_Name.Name = "Tb_Owner_Name"
        Me.Tb_Owner_Name.Size = New System.Drawing.Size(267, 36)
        Me.Tb_Owner_Name.TabIndex = 3
        '
        'Tb_Contact_No_2
        '
        Me.Tb_Contact_No_2.Enabled = False
        Me.Tb_Contact_No_2.Font = New System.Drawing.Font("Rockwell Condensed", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tb_Contact_No_2.Location = New System.Drawing.Point(243, 348)
        Me.Tb_Contact_No_2.Name = "Tb_Contact_No_2"
        Me.Tb_Contact_No_2.Size = New System.Drawing.Size(267, 36)
        Me.Tb_Contact_No_2.TabIndex = 6
        '
        'Lbl_Search_Lab_Details
        '
        Me.Lbl_Search_Lab_Details.AutoSize = True
        Me.Lbl_Search_Lab_Details.Font = New System.Drawing.Font("Rockwell Condensed", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Search_Lab_Details.ForeColor = System.Drawing.Color.LemonChiffon
        Me.Lbl_Search_Lab_Details.Image = CType(resources.GetObject("Lbl_Search_Lab_Details.Image"), System.Drawing.Image)
        Me.Lbl_Search_Lab_Details.Location = New System.Drawing.Point(531, 9)
        Me.Lbl_Search_Lab_Details.Name = "Lbl_Search_Lab_Details"
        Me.Lbl_Search_Lab_Details.Size = New System.Drawing.Size(531, 75)
        Me.Lbl_Search_Lab_Details.TabIndex = 63
        Me.Lbl_Search_Lab_Details.Text = "Search Lab Details "
        '
        'Gp_Test_Cases
        '
        Me.Gp_Test_Cases.Controls.Add(Me.Dgv_Test_Cases)
        Me.Gp_Test_Cases.Font = New System.Drawing.Font("Rockwell Condensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Gp_Test_Cases.Location = New System.Drawing.Point(674, 203)
        Me.Gp_Test_Cases.Name = "Gp_Test_Cases"
        Me.Gp_Test_Cases.Size = New System.Drawing.Size(548, 398)
        Me.Gp_Test_Cases.TabIndex = 191
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
        Me.Dgv_Test_Cases.Location = New System.Drawing.Point(29, 68)
        Me.Dgv_Test_Cases.Name = "Dgv_Test_Cases"
        Me.Dgv_Test_Cases.ReadOnly = True
        Me.Dgv_Test_Cases.Size = New System.Drawing.Size(493, 312)
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
        Me.Gp_Laboratory_Information.Location = New System.Drawing.Point(115, 188)
        Me.Gp_Laboratory_Information.Name = "Gp_Laboratory_Information"
        Me.Gp_Laboratory_Information.Size = New System.Drawing.Size(533, 444)
        Me.Gp_Laboratory_Information.TabIndex = 190
        Me.Gp_Laboratory_Information.TabStop = False
        Me.Gp_Laboratory_Information.Text = "Laboratory Information"
        '
        'Btn_CLEAR
        '
        Me.Btn_CLEAR.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Btn_CLEAR.Font = New System.Drawing.Font("Rockwell", 21.75!, System.Drawing.FontStyle.Bold)
        Me.Btn_CLEAR.ForeColor = System.Drawing.SystemColors.Control
        Me.Btn_CLEAR.Location = New System.Drawing.Point(863, 607)
        Me.Btn_CLEAR.Name = "Btn_CLEAR"
        Me.Btn_CLEAR.Size = New System.Drawing.Size(144, 43)
        Me.Btn_CLEAR.TabIndex = 187
        Me.Btn_CLEAR.Text = "CLEAR"
        Me.Btn_CLEAR.UseVisualStyleBackColor = False
        '
        'Tb_Lab_ID
        '
        Me.Tb_Lab_ID.Font = New System.Drawing.Font("Rockwell Condensed", 20.25!, System.Drawing.FontStyle.Bold)
        Me.Tb_Lab_ID.Location = New System.Drawing.Point(451, 117)
        Me.Tb_Lab_ID.Name = "Tb_Lab_ID"
        Me.Tb_Lab_ID.Size = New System.Drawing.Size(267, 39)
        Me.Tb_Lab_ID.TabIndex = 185
        '
        'Lbl_Lab_ID
        '
        Me.Lbl_Lab_ID.AutoSize = True
        Me.Lbl_Lab_ID.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Lbl_Lab_ID.Font = New System.Drawing.Font("Rockwell Condensed", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Lab_ID.ForeColor = System.Drawing.Color.Black
        Me.Lbl_Lab_ID.Location = New System.Drawing.Point(231, 113)
        Me.Lbl_Lab_ID.Name = "Lbl_Lab_ID"
        Me.Lbl_Lab_ID.Size = New System.Drawing.Size(88, 31)
        Me.Lbl_Lab_ID.TabIndex = 189
        Me.Lbl_Lab_ID.Text = "Lab ID"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Blue
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Lbl_Search_Lab_Details)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1350, 92)
        Me.Panel1.TabIndex = 188
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(258, 92)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 95
        Me.PictureBox1.TabStop = False
        '
        'Frm_Search_Lab_Details
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1350, 729)
        Me.ControlBox = False
        Me.Controls.Add(Me.Btn_SEARCH)
        Me.Controls.Add(Me.Gp_Test_Cases)
        Me.Controls.Add(Me.Gp_Laboratory_Information)
        Me.Controls.Add(Me.Btn_CLEAR)
        Me.Controls.Add(Me.Tb_Lab_ID)
        Me.Controls.Add(Me.Lbl_Lab_ID)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Frm_Search_Lab_Details"
        Me.Text = "Search Lab Details"
        Me.Gp_Test_Cases.ResumeLayout(False)
        CType(Me.Dgv_Test_Cases, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Gp_Laboratory_Information.ResumeLayout(False)
        Me.Gp_Laboratory_Information.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Btn_SEARCH As System.Windows.Forms.Button
    Friend WithEvents Tb_Contact_No_1 As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_Contact_No_2 As System.Windows.Forms.Label
    Friend WithEvents Lbl_Contact_No_1 As System.Windows.Forms.Label
    Friend WithEvents Tb_Address As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_Address As System.Windows.Forms.Label
    Friend WithEvents Lbl_Lab_Name As System.Windows.Forms.Label
    Friend WithEvents Tb_Lab_Name As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_Owner_Name As System.Windows.Forms.Label
    Friend WithEvents Tb_Owner_Name As System.Windows.Forms.TextBox
    Friend WithEvents Tb_Contact_No_2 As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_Search_Lab_Details As System.Windows.Forms.Label
    Friend WithEvents Gp_Test_Cases As System.Windows.Forms.GroupBox
    Friend WithEvents Gp_Laboratory_Information As System.Windows.Forms.GroupBox
    Friend WithEvents Btn_CLEAR As System.Windows.Forms.Button
    Friend WithEvents Tb_Lab_ID As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_Lab_ID As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Dgv_Test_Cases As System.Windows.Forms.DataGridView
    Friend WithEvents Lab_ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Test_Cases As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Charges As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
