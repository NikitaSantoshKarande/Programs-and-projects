Imports System.Data.SqlClient

Public Class Frm_Login
    Private Sub Frm_Login_Form_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Tb_User_Name.Focus()
    End Sub

    Private Sub Tb_User_Name_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tb_User_Name.TextChanged
        Tb_Password.Enabled = True
    End Sub

    Private Sub Tb_Password_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tb_Password.TextChanged
        Btn_Login.Enabled = True
    End Sub
    Private Sub Btn_Submit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Login.Click
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        con.ConnectionString = "Data Source=.\sqlexpress;Initial Catalog=Dental_Clinic_Management_System;Integrated Security=True"
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "select * from tbl_Login where User_Name='" & Tb_User_Name.Text & "' And Password = '" & Tb_Password.Text & "'"
        If cmd.ExecuteScalar <> "" Then
            MessageBox.Show("Login Succesfully...", "Notification")
            Me.Hide()
            Frm_Dental_Clinic_Management_System_Main_Form.Show()
        Else
            MessageBox.Show("Invalid value")
        End If
        Tb_User_Name.Text = ""
        Tb_Password.Text = ""
        Btn_Login.Enabled = False
        Tb_Password.Enabled = False
        con.Close()
    End Sub

    Private Sub Btn_x_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_x.Click
        Me.Close()
    End Sub
End Class
