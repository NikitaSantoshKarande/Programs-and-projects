Imports System.Data.SqlClient

Public Class Frm_View_Appointment_Details
    Dim con As New SqlConnection("Data Source=.\sqlexpress;Initial Catalog=Dental_Clinic_Management_System;Integrated Security=True")
    Dim cmd As New SqlCommand
    Function connection()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Return 0
    End Function
    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Frm_Appointment.Show()
        Me.Hide()
    End Sub

    Private Sub Frm_View_Appointment_Details_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            connection()
            cmd.Connection = con
            cmd.CommandText = "Select * From Tbl_Appointment_Details"
            Dim da As New SqlDataAdapter(cmd)
            Dim dt As New DataTable()
            da.Fill(dt)
            Dgv_Appointment_Details.DataSource = dt
            cmd.Dispose()
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class