<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Specialization_Charges
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
        Me.Dgv_Specialization_and_Charges = New System.Windows.Forms.DataGridView()
        Me.Lbl_Doctor_ID = New System.Windows.Forms.Label()
        Me.Btn_SEARCH = New System.Windows.Forms.Button()
        Me.Btn_x = New System.Windows.Forms.Button()
        Me.Tb_Doctor_ID = New System.Windows.Forms.TextBox()
        CType(Me.Dgv_Specialization_and_Charges, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Dgv_Specialization_and_Charges
        '
        Me.Dgv_Specialization_and_Charges.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Dgv_Specialization_and_Charges.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv_Specialization_and_Charges.Enabled = False
        Me.Dgv_Specialization_and_Charges.Location = New System.Drawing.Point(26, 113)
        Me.Dgv_Specialization_and_Charges.Name = "Dgv_Specialization_and_Charges"
        Me.Dgv_Specialization_and_Charges.Size = New System.Drawing.Size(569, 258)
        Me.Dgv_Specialization_and_Charges.TabIndex = 0
        '
        'Lbl_Doctor_ID
        '
        Me.Lbl_Doctor_ID.AutoSize = True
        Me.Lbl_Doctor_ID.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Lbl_Doctor_ID.Font = New System.Drawing.Font("Bahnschrift Condensed", 20.25!, System.Drawing.FontStyle.Bold)
        Me.Lbl_Doctor_ID.ForeColor = System.Drawing.Color.Black
        Me.Lbl_Doctor_ID.Location = New System.Drawing.Point(31, 52)
        Me.Lbl_Doctor_ID.Name = "Lbl_Doctor_ID"
        Me.Lbl_Doctor_ID.Size = New System.Drawing.Size(94, 33)
        Me.Lbl_Doctor_ID.TabIndex = 184
        Me.Lbl_Doctor_ID.Text = "Doctor ID"
        '
        'Btn_SEARCH
        '
        Me.Btn_SEARCH.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Btn_SEARCH.Enabled = False
        Me.Btn_SEARCH.Font = New System.Drawing.Font("Bahnschrift Condensed", 20.25!, System.Drawing.FontStyle.Bold)
        Me.Btn_SEARCH.ForeColor = System.Drawing.Color.Cornsilk
        Me.Btn_SEARCH.Location = New System.Drawing.Point(438, 49)
        Me.Btn_SEARCH.Name = "Btn_SEARCH"
        Me.Btn_SEARCH.Size = New System.Drawing.Size(140, 42)
        Me.Btn_SEARCH.TabIndex = 2
        Me.Btn_SEARCH.Text = "SEARCH"
        Me.Btn_SEARCH.UseVisualStyleBackColor = False
        '
        'Btn_x
        '
        Me.Btn_x.BackColor = System.Drawing.Color.Red
        Me.Btn_x.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_x.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_x.ForeColor = System.Drawing.SystemColors.InactiveBorder
        Me.Btn_x.Location = New System.Drawing.Point(583, -8)
        Me.Btn_x.Name = "Btn_x"
        Me.Btn_x.Size = New System.Drawing.Size(50, 43)
        Me.Btn_x.TabIndex = 187
        Me.Btn_x.Text = "x"
        Me.Btn_x.UseVisualStyleBackColor = False
        '
        'Tb_Doctor_ID
        '
        Me.Tb_Doctor_ID.Font = New System.Drawing.Font("Bahnschrift Condensed", 20.25!, System.Drawing.FontStyle.Bold)
        Me.Tb_Doctor_ID.Location = New System.Drawing.Point(218, 52)
        Me.Tb_Doctor_ID.Name = "Tb_Doctor_ID"
        Me.Tb_Doctor_ID.Size = New System.Drawing.Size(157, 40)
        Me.Tb_Doctor_ID.TabIndex = 1
        '
        'Frm_Specialization_Charges
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(633, 399)
        Me.ControlBox = False
        Me.Controls.Add(Me.Btn_x)
        Me.Controls.Add(Me.Lbl_Doctor_ID)
        Me.Controls.Add(Me.Tb_Doctor_ID)
        Me.Controls.Add(Me.Btn_SEARCH)
        Me.Controls.Add(Me.Dgv_Specialization_and_Charges)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm_Specialization_Charges"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Specialization_Charges"
        CType(Me.Dgv_Specialization_and_Charges, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Dgv_Specialization_and_Charges As System.Windows.Forms.DataGridView
    Friend WithEvents Lbl_Doctor_ID As System.Windows.Forms.Label
    Friend WithEvents Btn_SEARCH As System.Windows.Forms.Button
    Friend WithEvents Btn_x As System.Windows.Forms.Button
    Friend WithEvents Tb_Doctor_ID As System.Windows.Forms.TextBox
End Class
