<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Patient
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Patient))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Btn_View_Patient_details = New System.Windows.Forms.Button()
        Me.Btn_Add_Patient_Details = New System.Windows.Forms.Button()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-1, -3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(258, 89)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 92
        Me.PictureBox1.TabStop = False
        '
        'Btn_View_Patient_details
        '
        Me.Btn_View_Patient_details.Font = New System.Drawing.Font("MV Boli", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_View_Patient_details.ForeColor = System.Drawing.SystemColors.Control
        Me.Btn_View_Patient_details.Image = CType(resources.GetObject("Btn_View_Patient_details.Image"), System.Drawing.Image)
        Me.Btn_View_Patient_details.Location = New System.Drawing.Point(311, 355)
        Me.Btn_View_Patient_details.Name = "Btn_View_Patient_details"
        Me.Btn_View_Patient_details.Size = New System.Drawing.Size(621, 91)
        Me.Btn_View_Patient_details.TabIndex = 90
        Me.Btn_View_Patient_details.Text = "View Patient details"
        Me.Btn_View_Patient_details.UseVisualStyleBackColor = True
        '
        'Btn_Add_Patient_Details
        '
        Me.Btn_Add_Patient_Details.Font = New System.Drawing.Font("MV Boli", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Add_Patient_Details.ForeColor = System.Drawing.SystemColors.Control
        Me.Btn_Add_Patient_Details.Image = CType(resources.GetObject("Btn_Add_Patient_Details.Image"), System.Drawing.Image)
        Me.Btn_Add_Patient_Details.Location = New System.Drawing.Point(311, 245)
        Me.Btn_Add_Patient_Details.Name = "Btn_Add_Patient_Details"
        Me.Btn_Add_Patient_Details.Size = New System.Drawing.Size(621, 91)
        Me.Btn_Add_Patient_Details.TabIndex = 88
        Me.Btn_Add_Patient_Details.Text = "Attend Patient Details"
        Me.Btn_Add_Patient_Details.UseVisualStyleBackColor = True
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(926, 223)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(143, 113)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 103
        Me.PictureBox4.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(926, 342)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(143, 113)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox5.TabIndex = 104
        Me.PictureBox5.TabStop = False
        '
        'Frm_Patient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1350, 729)
        Me.ControlBox = False
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Btn_View_Patient_details)
        Me.Controls.Add(Me.Btn_Add_Patient_Details)
        Me.Name = "Frm_Patient"
        Me.Text = "Patient"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Btn_View_Patient_details As System.Windows.Forms.Button
    Friend WithEvents Btn_Add_Patient_Details As System.Windows.Forms.Button
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
End Class
