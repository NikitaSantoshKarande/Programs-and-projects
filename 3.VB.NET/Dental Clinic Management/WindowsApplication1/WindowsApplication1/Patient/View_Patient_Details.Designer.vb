<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_View_Patient_Details
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_View_Patient_Details))
        Me.Dgv_Patient_Details = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Btn_View_Prescription = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Lbl_View_Patient_Details = New System.Windows.Forms.Label()
        Me.Lbl_Patient_ID = New System.Windows.Forms.Label()
        Me.Tb_Patient_ID = New System.Windows.Forms.TextBox()
        Me.Btn_SEARCH = New System.Windows.Forms.Button()
        CType(Me.Dgv_Patient_Details, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Dgv_Patient_Details
        '
        Me.Dgv_Patient_Details.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv_Patient_Details.Location = New System.Drawing.Point(0, 205)
        Me.Dgv_Patient_Details.Name = "Dgv_Patient_Details"
        Me.Dgv_Patient_Details.Size = New System.Drawing.Size(1351, 529)
        Me.Dgv_Patient_Details.TabIndex = 85
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Blue
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.Btn_View_Prescription)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Lbl_View_Patient_Details)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1350, 93)
        Me.Panel1.TabIndex = 84
        '
        'Btn_View_Prescription
        '
        Me.Btn_View_Prescription.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Btn_View_Prescription.Font = New System.Drawing.Font("Bahnschrift Condensed", 20.25!, System.Drawing.FontStyle.Bold)
        Me.Btn_View_Prescription.ForeColor = System.Drawing.Color.Cornsilk
        Me.Btn_View_Prescription.Location = New System.Drawing.Point(1069, 37)
        Me.Btn_View_Prescription.Name = "Btn_View_Prescription"
        Me.Btn_View_Prescription.Size = New System.Drawing.Size(260, 42)
        Me.Btn_View_Prescription.TabIndex = 188
        Me.Btn_View_Prescription.Text = "View Prescription"
        Me.Btn_View_Prescription.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(258, 90)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 95
        Me.PictureBox1.TabStop = False
        '
        'Lbl_View_Patient_Details
        '
        Me.Lbl_View_Patient_Details.AutoSize = True
        Me.Lbl_View_Patient_Details.Font = New System.Drawing.Font("Bahnschrift Condensed", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_View_Patient_Details.ForeColor = System.Drawing.Color.LemonChiffon
        Me.Lbl_View_Patient_Details.Image = CType(resources.GetObject("Lbl_View_Patient_Details.Image"), System.Drawing.Image)
        Me.Lbl_View_Patient_Details.Location = New System.Drawing.Point(488, 9)
        Me.Lbl_View_Patient_Details.Name = "Lbl_View_Patient_Details"
        Me.Lbl_View_Patient_Details.Size = New System.Drawing.Size(455, 77)
        Me.Lbl_View_Patient_Details.TabIndex = 63
        Me.Lbl_View_Patient_Details.Text = "View Patient Details"
        '
        'Lbl_Patient_ID
        '
        Me.Lbl_Patient_ID.AutoSize = True
        Me.Lbl_Patient_ID.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Lbl_Patient_ID.Font = New System.Drawing.Font("Bahnschrift Condensed", 20.25!, System.Drawing.FontStyle.Bold)
        Me.Lbl_Patient_ID.ForeColor = System.Drawing.Color.Black
        Me.Lbl_Patient_ID.Location = New System.Drawing.Point(306, 146)
        Me.Lbl_Patient_ID.Name = "Lbl_Patient_ID"
        Me.Lbl_Patient_ID.Size = New System.Drawing.Size(100, 33)
        Me.Lbl_Patient_ID.TabIndex = 194
        Me.Lbl_Patient_ID.Text = "Patient ID"
        '
        'Tb_Patient_ID
        '
        Me.Tb_Patient_ID.Font = New System.Drawing.Font("Bahnschrift Condensed", 20.25!, System.Drawing.FontStyle.Bold)
        Me.Tb_Patient_ID.Location = New System.Drawing.Point(545, 140)
        Me.Tb_Patient_ID.Name = "Tb_Patient_ID"
        Me.Tb_Patient_ID.Size = New System.Drawing.Size(211, 40)
        Me.Tb_Patient_ID.TabIndex = 192
        '
        'Btn_SEARCH
        '
        Me.Btn_SEARCH.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Btn_SEARCH.Enabled = False
        Me.Btn_SEARCH.Font = New System.Drawing.Font("Bahnschrift Condensed", 20.25!, System.Drawing.FontStyle.Bold)
        Me.Btn_SEARCH.ForeColor = System.Drawing.Color.Cornsilk
        Me.Btn_SEARCH.Location = New System.Drawing.Point(813, 137)
        Me.Btn_SEARCH.Name = "Btn_SEARCH"
        Me.Btn_SEARCH.Size = New System.Drawing.Size(140, 42)
        Me.Btn_SEARCH.TabIndex = 193
        Me.Btn_SEARCH.Text = "SEARCH"
        Me.Btn_SEARCH.UseVisualStyleBackColor = False
        '
        'Frm_View_Patient_Details
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1350, 729)
        Me.ControlBox = False
        Me.Controls.Add(Me.Lbl_Patient_ID)
        Me.Controls.Add(Me.Tb_Patient_ID)
        Me.Controls.Add(Me.Btn_SEARCH)
        Me.Controls.Add(Me.Dgv_Patient_Details)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Frm_View_Patient_Details"
        Me.Text = "View Patient Details"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.Dgv_Patient_Details, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Dgv_Patient_Details As System.Windows.Forms.DataGridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Lbl_View_Patient_Details As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Btn_View_Prescription As System.Windows.Forms.Button
    Friend WithEvents Lbl_Patient_ID As System.Windows.Forms.Label
    Friend WithEvents Tb_Patient_ID As System.Windows.Forms.TextBox
    Friend WithEvents Btn_SEARCH As System.Windows.Forms.Button
End Class
