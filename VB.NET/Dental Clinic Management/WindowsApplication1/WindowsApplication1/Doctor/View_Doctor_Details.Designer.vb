﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_View_Doctor_Details
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_View_Doctor_Details))
        Me.Dgv_Doctor_Details = New System.Windows.Forms.DataGridView()
        Me.Lbl_View_Doctor_Details = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Btn_Other_Details = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.Dgv_Doctor_Details, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Dgv_Doctor_Details
        '
        Me.Dgv_Doctor_Details.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Dgv_Doctor_Details.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv_Doctor_Details.Enabled = False
        Me.Dgv_Doctor_Details.Location = New System.Drawing.Point(0, 87)
        Me.Dgv_Doctor_Details.Name = "Dgv_Doctor_Details"
        Me.Dgv_Doctor_Details.Size = New System.Drawing.Size(1377, 642)
        Me.Dgv_Doctor_Details.TabIndex = 85
        '
        'Lbl_View_Doctor_Details
        '
        Me.Lbl_View_Doctor_Details.AutoSize = True
        Me.Lbl_View_Doctor_Details.Font = New System.Drawing.Font("Rockwell Condensed", 48.0!, System.Drawing.FontStyle.Bold)
        Me.Lbl_View_Doctor_Details.ForeColor = System.Drawing.Color.LemonChiffon
        Me.Lbl_View_Doctor_Details.Image = CType(resources.GetObject("Lbl_View_Doctor_Details.Image"), System.Drawing.Image)
        Me.Lbl_View_Doctor_Details.Location = New System.Drawing.Point(485, 9)
        Me.Lbl_View_Doctor_Details.Name = "Lbl_View_Doctor_Details"
        Me.Lbl_View_Doctor_Details.Size = New System.Drawing.Size(533, 75)
        Me.Lbl_View_Doctor_Details.TabIndex = 63
        Me.Lbl_View_Doctor_Details.Text = "View Doctor Details"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Blue
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.Btn_Other_Details)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Lbl_View_Doctor_Details)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1350, 92)
        Me.Panel1.TabIndex = 84
        '
        'Btn_Other_Details
        '
        Me.Btn_Other_Details.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Btn_Other_Details.Font = New System.Drawing.Font("Rockwell Condensed", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Other_Details.ForeColor = System.Drawing.Color.Cornsilk
        Me.Btn_Other_Details.Location = New System.Drawing.Point(1107, 42)
        Me.Btn_Other_Details.Name = "Btn_Other_Details"
        Me.Btn_Other_Details.Size = New System.Drawing.Size(231, 42)
        Me.Btn_Other_Details.TabIndex = 187
        Me.Btn_Other_Details.Text = "Other Details"
        Me.Btn_Other_Details.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(258, 89)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 86
        Me.PictureBox1.TabStop = False
        '
        'Frm_View_Doctor_Details
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1350, 729)
        Me.ControlBox = False
        Me.Controls.Add(Me.Dgv_Doctor_Details)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Frm_View_Doctor_Details"
        Me.Text = "View Doctor Details"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.Dgv_Doctor_Details, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Dgv_Doctor_Details As System.Windows.Forms.DataGridView
    Friend WithEvents Lbl_View_Doctor_Details As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Btn_Other_Details As System.Windows.Forms.Button
End Class
