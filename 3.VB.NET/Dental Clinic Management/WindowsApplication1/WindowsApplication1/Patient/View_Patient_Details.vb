Imports System.Data.SqlClient

Public Class Frm_View_Patient_Details

    Dim con As New SqlConnection("Data Source=.\sqlexpress;Initial Catalog=Dental_Clinic_Management_System;Integrated Security=True")
    Dim cmd As New SqlCommand
    Function connection()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Return 0
    End Function
    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Frm_Patient.Show()
        Me.Hide()
    End Sub

    Private Sub Frm_View_Patient_Details_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            connection()
            cmd.Connection = con
            cmd.CommandText = "Select * From Tbl_Attend_Patient_Details"
            Dim da As New SqlDataAdapter(cmd)
            Dim dt As New DataTable()
            da.Fill(dt)
            Dgv_Patient_Details.DataSource = dt
            cmd.Dispose()
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Btn_View_Prescription_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_View_Prescription.Click
        Frm_View_Prescription_Details.Show()
    End Sub

    Private Sub Tb_Patient_ID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tb_Patient_ID.TextChanged
        Btn_SEARCH.Enabled = True
    End Sub

    Private Sub Btn_SEARCH_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_SEARCH.Click
        Try
            connection()
            cmd.Connection = con
            cmd.CommandText = "select * from Tbl_Attend_Patient_Details where Patient_ID = " + Tb_Patient_ID.Text + ""
            Dim da As New SqlDataAdapter(cmd)
            Dim dt As New DataTable()
            da.Fill(dt)
            Dgv_Patient_Details.DataSource = dt
            cmd.Dispose()
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class