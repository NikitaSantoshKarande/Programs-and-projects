<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Lab_Report1
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
        Me.Lab_Report_viewer = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'Lab_Report_viewer
        '
        Me.Lab_Report_viewer.ActiveViewIndex = -1
        Me.Lab_Report_viewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Lab_Report_viewer.Cursor = System.Windows.Forms.Cursors.Default
        Me.Lab_Report_viewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Lab_Report_viewer.Location = New System.Drawing.Point(0, 0)
        Me.Lab_Report_viewer.Name = "Lab_Report_viewer"
        Me.Lab_Report_viewer.Size = New System.Drawing.Size(1304, 584)
        Me.Lab_Report_viewer.TabIndex = 0
        '
        'Lab_Report1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1304, 584)
        Me.Controls.Add(Me.Lab_Report_viewer)
        Me.Name = "Lab_Report1"
        Me.Text = "Lab_Report1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Lab_Report_viewer As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
