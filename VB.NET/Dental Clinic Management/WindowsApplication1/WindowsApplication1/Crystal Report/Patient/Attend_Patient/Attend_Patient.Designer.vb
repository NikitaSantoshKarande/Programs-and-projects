<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Attend_Patient_rpt
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
        Me.Attend_Patient_rpt = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.Btn_SEARCH = New System.Windows.Forms.Button()
        Me.lbl_To = New System.Windows.Forms.Label()
        Me.lbl_From = New System.Windows.Forms.Label()
        Me.dtp_to = New System.Windows.Forms.DateTimePicker()
        Me.dtp_from = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'Attend_Patient_rpt
        '
        Me.Attend_Patient_rpt.ActiveViewIndex = -1
        Me.Attend_Patient_rpt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Attend_Patient_rpt.Cursor = System.Windows.Forms.Cursors.Default
        Me.Attend_Patient_rpt.Location = New System.Drawing.Point(0, 102)
        Me.Attend_Patient_rpt.Name = "Attend_Patient_rpt"
        Me.Attend_Patient_rpt.Size = New System.Drawing.Size(1304, 482)
        Me.Attend_Patient_rpt.TabIndex = 0
        '
        'Btn_SEARCH
        '
        Me.Btn_SEARCH.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Btn_SEARCH.Font = New System.Drawing.Font("Rockwell Condensed", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_SEARCH.ForeColor = System.Drawing.Color.Cornsilk
        Me.Btn_SEARCH.Location = New System.Drawing.Point(790, 27)
        Me.Btn_SEARCH.Name = "Btn_SEARCH"
        Me.Btn_SEARCH.Size = New System.Drawing.Size(144, 42)
        Me.Btn_SEARCH.TabIndex = 174
        Me.Btn_SEARCH.Text = "SEARCH"
        Me.Btn_SEARCH.UseVisualStyleBackColor = False
        '
        'lbl_To
        '
        Me.lbl_To.AutoSize = True
        Me.lbl_To.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_To.Location = New System.Drawing.Point(453, 42)
        Me.lbl_To.Name = "lbl_To"
        Me.lbl_To.Size = New System.Drawing.Size(29, 20)
        Me.lbl_To.TabIndex = 178
        Me.lbl_To.Text = "To"
        '
        'lbl_From
        '
        Me.lbl_From.AutoSize = True
        Me.lbl_From.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_From.Location = New System.Drawing.Point(98, 42)
        Me.lbl_From.Name = "lbl_From"
        Me.lbl_From.Size = New System.Drawing.Size(50, 20)
        Me.lbl_From.TabIndex = 177
        Me.lbl_From.Text = "From"
        '
        'dtp_to
        '
        Me.dtp_to.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_to.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_to.Location = New System.Drawing.Point(505, 36)
        Me.dtp_to.Name = "dtp_to"
        Me.dtp_to.Size = New System.Drawing.Size(200, 29)
        Me.dtp_to.TabIndex = 176
        '
        'dtp_from
        '
        Me.dtp_from.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_from.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_from.Location = New System.Drawing.Point(181, 36)
        Me.dtp_from.Name = "dtp_from"
        Me.dtp_from.Size = New System.Drawing.Size(200, 29)
        Me.dtp_from.TabIndex = 175
        '
        'frm_Attend_Patient_rpt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1304, 584)
        Me.Controls.Add(Me.lbl_To)
        Me.Controls.Add(Me.lbl_From)
        Me.Controls.Add(Me.dtp_to)
        Me.Controls.Add(Me.dtp_from)
        Me.Controls.Add(Me.Btn_SEARCH)
        Me.Controls.Add(Me.Attend_Patient_rpt)
        Me.Name = "frm_Attend_Patient_rpt"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Attend_Patient"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Attend_Patient_rpt As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents Btn_SEARCH As System.Windows.Forms.Button
    Friend WithEvents lbl_To As System.Windows.Forms.Label
    Friend WithEvents lbl_From As System.Windows.Forms.Label
    Friend WithEvents dtp_to As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp_from As System.Windows.Forms.DateTimePicker
End Class
