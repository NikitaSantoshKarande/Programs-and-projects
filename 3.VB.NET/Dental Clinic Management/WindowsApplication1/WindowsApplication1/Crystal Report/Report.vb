Imports System.Data.SqlClient

Public Class Report
    Dim id As Integer
    Dim con As New SqlConnection("Data Source=.\sqlexpress;Initial Catalog=Dental_Clinic_Management_System;Integrated Security=True")
    Dim cmd As New SqlCommand
    Function connection()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Return 0
    End Function
    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Frm_Dental_Clinic_Management_System_Main_Form.Show()
        Me.Hide()
    End Sub
    Private Sub Btn_Lab_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Lab.Click
        Lab_Report_wf.Show()      
    End Sub

    Private Sub Btn_Doctor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Doctor.Click
        connection()
        Dim dt As New DataTable
        cmd = New SqlCommand("select * from Tbl_Doctor_Details", con)
        Dim adb = New SqlDataAdapter(cmd)
        adb.Fill(dt)

        Dim rpt As New CrystalReportDoctor
        rpt.Database.Tables("Tbl_Doctor_Details").SetDataSource(dt)

        Frm_doctor_Report.CrystalReportViewer3.ReportSource = Nothing
        Frm_doctor_Report.CrystalReportViewer3.ReportSource = rpt
        con.Close()
        Frm_doctor_Report.ShowDialog()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            connection()
            Dim dt As New DataTable
            cmd = New SqlCommand("select * from Tbl_Employee_Details", con)
            Dim adb = New SqlDataAdapter(cmd)
            adb.Fill(dt)
            Dim rpt As New CrystalReportEmployee1
            rpt.Database.Tables("Tbl_Employee_Details").SetDataSource(dt)

            Frm_Employee_Report.CrystalReportViewer4.ReportSource = Nothing
            Frm_Employee_Report.CrystalReportViewer4.ReportSource = rpt
            con.Close()
            Frm_Employee_Report.Show()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Btn_Patient_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Patient.Click
        frm_Attend_Patient_rpt.Show()
    End Sub
End Class