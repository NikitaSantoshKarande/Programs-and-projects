<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_View_Prescription_Details
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
        Me.Btn_x = New System.Windows.Forms.Button()
        Me.Lbl_Patient_ID = New System.Windows.Forms.Label()
        Me.Tb_Patient_ID = New System.Windows.Forms.TextBox()
        Me.Btn_SEARCH = New System.Windows.Forms.Button()
        Me.Dgv_View_Prescription_Details = New System.Windows.Forms.DataGridView()
        CType(Me.Dgv_View_Prescription_Details, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Btn_x
        '
        Me.Btn_x.BackColor = System.Drawing.Color.Red
        Me.Btn_x.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_x.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_x.ForeColor = System.Drawing.SystemColors.InactiveBorder
        Me.Btn_x.Location = New System.Drawing.Point(1194, -3)
        Me.Btn_x.Name = "Btn_x"
        Me.Btn_x.Size = New System.Drawing.Size(50, 43)
        Me.Btn_x.TabIndex = 192
        Me.Btn_x.Text = "x"
        Me.Btn_x.UseVisualStyleBackColor = False
        '
        'Lbl_Patient_ID
        '
        Me.Lbl_Patient_ID.AutoSize = True
        Me.Lbl_Patient_ID.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Lbl_Patient_ID.Font = New System.Drawing.Font("Bahnschrift Condensed", 20.25!, System.Drawing.FontStyle.Bold)
        Me.Lbl_Patient_ID.ForeColor = System.Drawing.Color.Black
        Me.Lbl_Patient_ID.Location = New System.Drawing.Point(254, 21)
        Me.Lbl_Patient_ID.Name = "Lbl_Patient_ID"
        Me.Lbl_Patient_ID.Size = New System.Drawing.Size(100, 33)
        Me.Lbl_Patient_ID.TabIndex = 191
        Me.Lbl_Patient_ID.Text = "Patient ID"
        '
        'Tb_Patient_ID
        '
        Me.Tb_Patient_ID.Font = New System.Drawing.Font("Bahnschrift Condensed", 20.25!, System.Drawing.FontStyle.Bold)
        Me.Tb_Patient_ID.Location = New System.Drawing.Point(493, 15)
        Me.Tb_Patient_ID.Name = "Tb_Patient_ID"
        Me.Tb_Patient_ID.Size = New System.Drawing.Size(157, 40)
        Me.Tb_Patient_ID.TabIndex = 189
        '
        'Btn_SEARCH
        '
        Me.Btn_SEARCH.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Btn_SEARCH.Enabled = False
        Me.Btn_SEARCH.Font = New System.Drawing.Font("Bahnschrift Condensed", 20.25!, System.Drawing.FontStyle.Bold)
        Me.Btn_SEARCH.ForeColor = System.Drawing.Color.Cornsilk
        Me.Btn_SEARCH.Location = New System.Drawing.Point(761, 12)
        Me.Btn_SEARCH.Name = "Btn_SEARCH"
        Me.Btn_SEARCH.Size = New System.Drawing.Size(140, 42)
        Me.Btn_SEARCH.TabIndex = 190
        Me.Btn_SEARCH.Text = "SEARCH"
        Me.Btn_SEARCH.UseVisualStyleBackColor = False
        '
        'Dgv_View_Prescription_Details
        '
        Me.Dgv_View_Prescription_Details.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Dgv_View_Prescription_Details.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv_View_Prescription_Details.Enabled = False
        Me.Dgv_View_Prescription_Details.Location = New System.Drawing.Point(-4, 78)
        Me.Dgv_View_Prescription_Details.Name = "Dgv_View_Prescription_Details"
        Me.Dgv_View_Prescription_Details.Size = New System.Drawing.Size(1248, 270)
        Me.Dgv_View_Prescription_Details.TabIndex = 188
        '
        'Frm_View_Prescription_Details
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1240, 348)
        Me.ControlBox = False
        Me.Controls.Add(Me.Btn_x)
        Me.Controls.Add(Me.Lbl_Patient_ID)
        Me.Controls.Add(Me.Tb_Patient_ID)
        Me.Controls.Add(Me.Btn_SEARCH)
        Me.Controls.Add(Me.Dgv_View_Prescription_Details)
        Me.Name = "Frm_View_Prescription_Details"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Frm View Prescription Details"
        CType(Me.Dgv_View_Prescription_Details, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Btn_x As System.Windows.Forms.Button
    Friend WithEvents Lbl_Patient_ID As System.Windows.Forms.Label
    Friend WithEvents Tb_Patient_ID As System.Windows.Forms.TextBox
    Friend WithEvents Btn_SEARCH As System.Windows.Forms.Button
    Friend WithEvents Dgv_View_Prescription_Details As System.Windows.Forms.DataGridView
End Class
