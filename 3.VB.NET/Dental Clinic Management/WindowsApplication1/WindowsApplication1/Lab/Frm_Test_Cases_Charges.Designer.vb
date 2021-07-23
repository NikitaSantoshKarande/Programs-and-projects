<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Test_Cases_Charges
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
        Me.Lbl_Lab_ID = New System.Windows.Forms.Label()
        Me.Tb_Lab_ID = New System.Windows.Forms.TextBox()
        Me.Btn_SEARCH = New System.Windows.Forms.Button()
        Me.Dgv_Test_case_And_Charge = New System.Windows.Forms.DataGridView()
        CType(Me.Dgv_Test_case_And_Charge, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Btn_x
        '
        Me.Btn_x.BackColor = System.Drawing.Color.Red
        Me.Btn_x.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_x.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_x.ForeColor = System.Drawing.SystemColors.InactiveBorder
        Me.Btn_x.Location = New System.Drawing.Point(582, -6)
        Me.Btn_x.Name = "Btn_x"
        Me.Btn_x.Size = New System.Drawing.Size(50, 43)
        Me.Btn_x.TabIndex = 192
        Me.Btn_x.Text = "x"
        Me.Btn_x.UseVisualStyleBackColor = False
        '
        'Lbl_Lab_ID
        '
        Me.Lbl_Lab_ID.AutoSize = True
        Me.Lbl_Lab_ID.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Lbl_Lab_ID.Font = New System.Drawing.Font("Bahnschrift Condensed", 20.25!, System.Drawing.FontStyle.Bold)
        Me.Lbl_Lab_ID.ForeColor = System.Drawing.Color.Black
        Me.Lbl_Lab_ID.Location = New System.Drawing.Point(75, 56)
        Me.Lbl_Lab_ID.Name = "Lbl_Lab_ID"
        Me.Lbl_Lab_ID.Size = New System.Drawing.Size(69, 33)
        Me.Lbl_Lab_ID.TabIndex = 191
        Me.Lbl_Lab_ID.Text = "Lab ID"
        '
        'Tb_Lab_ID
        '
        Me.Tb_Lab_ID.Font = New System.Drawing.Font("Bahnschrift Condensed", 20.25!, System.Drawing.FontStyle.Bold)
        Me.Tb_Lab_ID.Location = New System.Drawing.Point(217, 54)
        Me.Tb_Lab_ID.Name = "Tb_Lab_ID"
        Me.Tb_Lab_ID.Size = New System.Drawing.Size(157, 40)
        Me.Tb_Lab_ID.TabIndex = 189
        '
        'Btn_SEARCH
        '
        Me.Btn_SEARCH.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Btn_SEARCH.Enabled = False
        Me.Btn_SEARCH.Font = New System.Drawing.Font("Bahnschrift Condensed", 20.25!, System.Drawing.FontStyle.Bold)
        Me.Btn_SEARCH.ForeColor = System.Drawing.Color.Cornsilk
        Me.Btn_SEARCH.Location = New System.Drawing.Point(437, 51)
        Me.Btn_SEARCH.Name = "Btn_SEARCH"
        Me.Btn_SEARCH.Size = New System.Drawing.Size(140, 42)
        Me.Btn_SEARCH.TabIndex = 190
        Me.Btn_SEARCH.Text = "SEARCH"
        Me.Btn_SEARCH.UseVisualStyleBackColor = False
        '
        'Dgv_Test_case_And_Charge
        '
        Me.Dgv_Test_case_And_Charge.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Dgv_Test_case_And_Charge.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv_Test_case_And_Charge.Enabled = False
        Me.Dgv_Test_case_And_Charge.Location = New System.Drawing.Point(25, 115)
        Me.Dgv_Test_case_And_Charge.Name = "Dgv_Test_case_And_Charge"
        Me.Dgv_Test_case_And_Charge.Size = New System.Drawing.Size(569, 258)
        Me.Dgv_Test_case_And_Charge.TabIndex = 188
        '
        'Frm_Test_Cases_Charges
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(633, 399)
        Me.ControlBox = False
        Me.Controls.Add(Me.Btn_x)
        Me.Controls.Add(Me.Lbl_Lab_ID)
        Me.Controls.Add(Me.Tb_Lab_ID)
        Me.Controls.Add(Me.Btn_SEARCH)
        Me.Controls.Add(Me.Dgv_Test_case_And_Charge)
        Me.Name = "Frm_Test_Cases_Charges"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Frm_Test_Cases_Charges"
        CType(Me.Dgv_Test_case_And_Charge, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Btn_x As System.Windows.Forms.Button
    Friend WithEvents Lbl_Lab_ID As System.Windows.Forms.Label
    Friend WithEvents Tb_Lab_ID As System.Windows.Forms.TextBox
    Friend WithEvents Btn_SEARCH As System.Windows.Forms.Button
    Friend WithEvents Dgv_Test_case_And_Charge As System.Windows.Forms.DataGridView
End Class
