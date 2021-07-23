<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Login))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Lbl_User_Name = New System.Windows.Forms.Label()
        Me.Tb_User_Name = New System.Windows.Forms.TextBox()
        Me.Tb_Password = New System.Windows.Forms.TextBox()
        Me.Btn_Login = New System.Windows.Forms.Button()
        Me.Lbl_Password = New System.Windows.Forms.Label()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.Lbl_HEALTH_IS_WEALTH = New System.Windows.Forms.Label()
        Me.Lbl_Dental = New System.Windows.Forms.Label()
        Me.Btn_x = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.PictureBox4)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Lbl_User_Name)
        Me.Panel1.Controls.Add(Me.Tb_User_Name)
        Me.Panel1.Controls.Add(Me.Tb_Password)
        Me.Panel1.Controls.Add(Me.Btn_Login)
        Me.Panel1.Controls.Add(Me.Lbl_Password)
        Me.Panel1.Location = New System.Drawing.Point(0, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(363, 588)
        Me.Panel1.TabIndex = 34
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(363, 120)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 35
        Me.PictureBox4.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(221, 153)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(126, 87)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 33
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(221, 325)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(126, 81)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 32
        Me.PictureBox1.TabStop = False
        '
        'Lbl_User_Name
        '
        Me.Lbl_User_Name.AutoSize = True
        Me.Lbl_User_Name.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_User_Name.Font = New System.Drawing.Font("Bahnschrift Condensed", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_User_Name.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Lbl_User_Name.Location = New System.Drawing.Point(45, 178)
        Me.Lbl_User_Name.Name = "Lbl_User_Name"
        Me.Lbl_User_Name.Size = New System.Drawing.Size(111, 33)
        Me.Lbl_User_Name.TabIndex = 29
        Me.Lbl_User_Name.Text = "User Name"
        '
        'Tb_User_Name
        '
        Me.Tb_User_Name.BackColor = System.Drawing.Color.LightGray
        Me.Tb_User_Name.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Tb_User_Name.Font = New System.Drawing.Font("Bahnschrift Condensed", 20.25!, System.Drawing.FontStyle.Bold)
        Me.Tb_User_Name.Location = New System.Drawing.Point(16, 267)
        Me.Tb_User_Name.Name = "Tb_User_Name"
        Me.Tb_User_Name.Size = New System.Drawing.Size(332, 33)
        Me.Tb_User_Name.TabIndex = 1
        '
        'Tb_Password
        '
        Me.Tb_Password.BackColor = System.Drawing.Color.LightGray
        Me.Tb_Password.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Tb_Password.Enabled = False
        Me.Tb_Password.Font = New System.Drawing.Font("Bahnschrift Condensed", 20.25!, System.Drawing.FontStyle.Bold)
        Me.Tb_Password.Location = New System.Drawing.Point(15, 424)
        Me.Tb_Password.Name = "Tb_Password"
        Me.Tb_Password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Tb_Password.Size = New System.Drawing.Size(332, 33)
        Me.Tb_Password.TabIndex = 2
        '
        'Btn_Login
        '
        Me.Btn_Login.BackColor = System.Drawing.Color.Red
        Me.Btn_Login.Enabled = False
        Me.Btn_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Login.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Login.ForeColor = System.Drawing.SystemColors.InactiveBorder
        Me.Btn_Login.Location = New System.Drawing.Point(12, 499)
        Me.Btn_Login.Name = "Btn_Login"
        Me.Btn_Login.Size = New System.Drawing.Size(333, 51)
        Me.Btn_Login.TabIndex = 3
        Me.Btn_Login.Text = "Login"
        Me.Btn_Login.UseVisualStyleBackColor = False
        '
        'Lbl_Password
        '
        Me.Lbl_Password.AutoSize = True
        Me.Lbl_Password.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_Password.Font = New System.Drawing.Font("Bahnschrift Condensed", 20.25!, System.Drawing.FontStyle.Bold)
        Me.Lbl_Password.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Lbl_Password.Location = New System.Drawing.Point(45, 348)
        Me.Lbl_Password.Name = "Lbl_Password"
        Me.Lbl_Password.Size = New System.Drawing.Size(101, 33)
        Me.Lbl_Password.TabIndex = 30
        Me.Lbl_Password.Text = "Password"
        '
        'PictureBox5
        '
        Me.PictureBox5.BackgroundImage = CType(resources.GetObject("PictureBox5.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(380, -1)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(915, 588)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox5.TabIndex = 35
        Me.PictureBox5.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.BackgroundImage = CType(resources.GetObject("PictureBox6.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox6.Location = New System.Drawing.Point(356, 450)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(672, 137)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox6.TabIndex = 36
        Me.PictureBox6.TabStop = False
        '
        'Lbl_HEALTH_IS_WEALTH
        '
        Me.Lbl_HEALTH_IS_WEALTH.AutoSize = True
        Me.Lbl_HEALTH_IS_WEALTH.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_HEALTH_IS_WEALTH.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_HEALTH_IS_WEALTH.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Lbl_HEALTH_IS_WEALTH.Location = New System.Drawing.Point(561, 221)
        Me.Lbl_HEALTH_IS_WEALTH.Name = "Lbl_HEALTH_IS_WEALTH"
        Me.Lbl_HEALTH_IS_WEALTH.Size = New System.Drawing.Size(304, 39)
        Me.Lbl_HEALTH_IS_WEALTH.TabIndex = 38
        Me.Lbl_HEALTH_IS_WEALTH.Text = "𝓱𝓮𝓪𝓵𝓽𝓱 𝓲𝓼 𝔀𝓮𝓪𝓵𝓽𝓱"
        '
        'Lbl_Dental
        '
        Me.Lbl_Dental.AutoSize = True
        Me.Lbl_Dental.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_Dental.Font = New System.Drawing.Font("Impact", 48.0!, System.Drawing.FontStyle.Bold)
        Me.Lbl_Dental.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Lbl_Dental.Location = New System.Drawing.Point(574, 148)
        Me.Lbl_Dental.Name = "Lbl_Dental"
        Me.Lbl_Dental.Size = New System.Drawing.Size(220, 80)
        Me.Lbl_Dental.TabIndex = 39
        Me.Lbl_Dental.Text = "DENTAL"
        '
        'Btn_x
        '
        Me.Btn_x.BackColor = System.Drawing.Color.Red
        Me.Btn_x.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_x.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_x.ForeColor = System.Drawing.SystemColors.InactiveBorder
        Me.Btn_x.Location = New System.Drawing.Point(945, 2)
        Me.Btn_x.Name = "Btn_x"
        Me.Btn_x.Size = New System.Drawing.Size(72, 51)
        Me.Btn_x.TabIndex = 40
        Me.Btn_x.Text = "x"
        Me.Btn_x.UseVisualStyleBackColor = False
        '
        'Frm_Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1020, 586)
        Me.ControlBox = False
        Me.Controls.Add(Me.Btn_x)
        Me.Controls.Add(Me.Lbl_Dental)
        Me.Controls.Add(Me.Lbl_HEALTH_IS_WEALTH)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.Panel1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm_Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Lbl_User_Name As System.Windows.Forms.Label
    Friend WithEvents Tb_User_Name As System.Windows.Forms.TextBox
    Friend WithEvents Tb_Password As System.Windows.Forms.TextBox
    Friend WithEvents Btn_Login As System.Windows.Forms.Button
    Friend WithEvents Lbl_Password As System.Windows.Forms.Label
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox6 As System.Windows.Forms.PictureBox
    Friend WithEvents Lbl_HEALTH_IS_WEALTH As System.Windows.Forms.Label
    Friend WithEvents Lbl_Dental As System.Windows.Forms.Label
    Friend WithEvents Btn_x As System.Windows.Forms.Button
End Class
