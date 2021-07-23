<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Lab_Report_wf
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
        Me.CrystalReportViewer2 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.cb_Search_Name = New System.Windows.Forms.ComboBox()
        Me.cb_Search_Type = New System.Windows.Forms.ComboBox()
        Me.lbl_Search_Type = New System.Windows.Forms.Label()
        Me.Btn_SEARCH = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'CrystalReportViewer2
        '
        Me.CrystalReportViewer2.ActiveViewIndex = -1
        Me.CrystalReportViewer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer2.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer2.Location = New System.Drawing.Point(0, 115)
        Me.CrystalReportViewer2.Name = "CrystalReportViewer2"
        Me.CrystalReportViewer2.Size = New System.Drawing.Size(1304, 469)
        Me.CrystalReportViewer2.TabIndex = 0
        '
        'cb_Search_Name
        '
        Me.cb_Search_Name.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cb_Search_Name.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cb_Search_Name.Font = New System.Drawing.Font("Bahnschrift Condensed", 20.25!, System.Drawing.FontStyle.Bold)
        Me.cb_Search_Name.FormattingEnabled = True
        Me.cb_Search_Name.Location = New System.Drawing.Point(689, 51)
        Me.cb_Search_Name.Name = "cb_Search_Name"
        Me.cb_Search_Name.Size = New System.Drawing.Size(285, 41)
        Me.cb_Search_Name.TabIndex = 8
        '
        'cb_Search_Type
        '
        Me.cb_Search_Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_Search_Type.Font = New System.Drawing.Font("Bahnschrift Condensed", 20.25!, System.Drawing.FontStyle.Bold)
        Me.cb_Search_Type.FormattingEnabled = True
        Me.cb_Search_Type.Items.AddRange(New Object() {"Lab Name"})
        Me.cb_Search_Type.Location = New System.Drawing.Point(338, 50)
        Me.cb_Search_Type.Name = "cb_Search_Type"
        Me.cb_Search_Type.Size = New System.Drawing.Size(285, 41)
        Me.cb_Search_Type.TabIndex = 7
        '
        'lbl_Search_Type
        '
        Me.lbl_Search_Type.AutoSize = True
        Me.lbl_Search_Type.Font = New System.Drawing.Font("Bahnschrift Condensed", 20.25!, System.Drawing.FontStyle.Bold)
        Me.lbl_Search_Type.Location = New System.Drawing.Point(178, 52)
        Me.lbl_Search_Type.Name = "lbl_Search_Type"
        Me.lbl_Search_Type.Size = New System.Drawing.Size(123, 33)
        Me.lbl_Search_Type.TabIndex = 6
        Me.lbl_Search_Type.Text = "Search Type"
        '
        'Btn_SEARCH
        '
        Me.Btn_SEARCH.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Btn_SEARCH.Font = New System.Drawing.Font("Bahnschrift Condensed", 20.25!, System.Drawing.FontStyle.Bold)
        Me.Btn_SEARCH.ForeColor = System.Drawing.Color.Cornsilk
        Me.Btn_SEARCH.Location = New System.Drawing.Point(1023, 49)
        Me.Btn_SEARCH.Name = "Btn_SEARCH"
        Me.Btn_SEARCH.Size = New System.Drawing.Size(144, 42)
        Me.Btn_SEARCH.TabIndex = 175
        Me.Btn_SEARCH.Text = "SEARCH"
        Me.Btn_SEARCH.UseVisualStyleBackColor = False
        '
        'Lab_Report_wf
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1304, 584)
        Me.Controls.Add(Me.Btn_SEARCH)
        Me.Controls.Add(Me.cb_Search_Name)
        Me.Controls.Add(Me.cb_Search_Type)
        Me.Controls.Add(Me.lbl_Search_Type)
        Me.Controls.Add(Me.CrystalReportViewer2)
        Me.Name = "Lab_Report_wf"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lab_Report_wf"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CrystalReportViewer2 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents cb_Search_Name As System.Windows.Forms.ComboBox
    Friend WithEvents cb_Search_Type As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_Search_Type As System.Windows.Forms.Label
    Friend WithEvents Btn_SEARCH As System.Windows.Forms.Button
End Class
