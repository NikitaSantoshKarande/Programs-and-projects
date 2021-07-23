Imports System.Data.SqlClient

Public Class Frm_View_Prescription_Details

    Dim con As New SqlConnection("Data Source=.\sqlexpress;Initial Catalog=Dental_Clinic_Management_System;Integrated Security=True")
    Dim cmd As New SqlCommand
    Function connection()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Return 0
    End Function
    Private Sub Btn_x_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_x.Click
        Me.Hide()
        Frm_View_Patient_Details.Show()
    End Sub

    Private Sub Frm_View_Prescription_Details_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            connection()
            cmd.Connection = con
            cmd.CommandText = "Select * From Tbl_Medication_Quantity"
            Dim da As New SqlDataAdapter(cmd)
            Dim dt As New DataTable()
            da.Fill(dt)
            Dgv_View_Prescription_Details.DataSource = dt
            cmd.Dispose()
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Btn_SEARCH_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_SEARCH.Click
        Try
            connection()
            cmd.Connection = con
            cmd.CommandText = "select * from Tbl_Prescription_Details where Patient_ID = " + Tb_Patient_ID.Text + ""
            Dim da As New SqlDataAdapter(cmd)
            Dim dt As New DataTable()
            da.Fill(dt)
            Dgv_View_Prescription_Details.DataSource = dt
            cmd.Dispose()
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Tb_Patient_ID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tb_Patient_ID.TextChanged
        Btn_SEARCH.Enabled = True
    End Sub

    Private Sub Lbl_Patient_ID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Lbl_Patient_ID.Click

    End Sub
End Class