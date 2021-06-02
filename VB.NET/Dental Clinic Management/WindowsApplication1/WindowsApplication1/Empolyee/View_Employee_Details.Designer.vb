<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_View_Employee_Details
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_View_Employee_Details))
        Me.TblEmployeeDetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Lbl_View_Employee_Details = New System.Windows.Forms.Label()
        Me.TblEmployeeDetailsBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblEmployeeDetailsBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Dgv_Employee_Details = New System.Windows.Forms.DataGridView()
        CType(Me.TblEmployeeDetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblEmployeeDetailsBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblEmployeeDetailsBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dgv_Employee_Details, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TblEmployeeDetailsBindingSource
        '
        Me.TblEmployeeDetailsBindingSource.DataMember = "Tbl_Employee_Details"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Blue
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Lbl_View_Employee_Details)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1350, 90)
        Me.Panel1.TabIndex = 84
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(258, 89)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 98
        Me.PictureBox1.TabStop = False
        '
        'Lbl_View_Employee_Details
        '
        Me.Lbl_View_Employee_Details.AutoSize = True
        Me.Lbl_View_Employee_Details.Font = New System.Drawing.Font("Rockwell Condensed", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_View_Employee_Details.ForeColor = System.Drawing.Color.LemonChiffon
        Me.Lbl_View_Employee_Details.Image = CType(resources.GetObject("Lbl_View_Employee_Details.Image"), System.Drawing.Image)
        Me.Lbl_View_Employee_Details.Location = New System.Drawing.Point(490, 9)
        Me.Lbl_View_Employee_Details.Name = "Lbl_View_Employee_Details"
        Me.Lbl_View_Employee_Details.Size = New System.Drawing.Size(613, 75)
        Me.Lbl_View_Employee_Details.TabIndex = 63
        Me.Lbl_View_Employee_Details.Text = "View Employee Details"
        '
        'TblEmployeeDetailsBindingSource1
        '
        Me.TblEmployeeDetailsBindingSource1.DataMember = "Tbl_Employee_Details"
        '
        'TblEmployeeDetailsBindingSource2
        '
        Me.TblEmployeeDetailsBindingSource2.DataMember = "Tbl_Employee_Details"
        '
        'Dgv_Employee_Details
        '
        Me.Dgv_Employee_Details.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Dgv_Employee_Details.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv_Employee_Details.Location = New System.Drawing.Point(0, 87)
        Me.Dgv_Employee_Details.Name = "Dgv_Employee_Details"
        Me.Dgv_Employee_Details.Size = New System.Drawing.Size(1375, 644)
        Me.Dgv_Employee_Details.TabIndex = 85
        '
        'Frm_View_Employee_Details
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1350, 729)
        Me.ControlBox = False
        Me.Controls.Add(Me.Dgv_Employee_Details)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Frm_View_Employee_Details"
        Me.Text = "View Employee Details"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.TblEmployeeDetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblEmployeeDetailsBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblEmployeeDetailsBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dgv_Employee_Details, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Lbl_View_Employee_Details As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents TblEmployeeDetailsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblEmployeeDetailsBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents TblEmployeeDetailsBindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents EmployeeIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmployeeNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AddressDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EducationDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ContactNo1DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ContactNo2DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ExprienceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents JoiningDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SalaryDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Dgv_Employee_Details As System.Windows.Forms.DataGridView
End Class
