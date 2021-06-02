﻿Imports System.Data.SqlClient

Public Class Frm_Update_Appointment_Details
    Dim con As New SqlConnection("Data Source=.\sqlexpress;Initial Catalog=Dental_Clinic_Management_System_db;Integrated Security=True")
    Dim cmd As New SqlCommand
    Dim dr As SqlDataReader
    Function connection()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Return 0
    End Function
    Function clear_control()
        Cmb_Select_Doctor.Text = ""
        Dtp_Date.Text = ""
        Tb_First_Name.Text = ""
        Tb_Last_Name.Text = ""
        Tb_Charges.Text = ""
        Dtp_Appointment_Date.Text = ""
        Dtp_Appointment_Time.Text = ""
        Tb_Address.Text = ""
        Tb_Contact_No_1.Text = ""
        Tb_Contact_No_2.Text = ""
        Tb_Age.Text = ""
        Cmb_Blood_Group.Text = ""
        Rb_Female.Checked = False
        Rb_Male.Checked = False
        Cb_High.Checked = False
        Cb_Low.Checked = False
        Cb_Normal.Checked = False
        Return 0
    End Function
    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Frm_Appointment.Show()
        Me.Hide()
    End Sub

    Private Sub Frm_Update_Appointment_Details_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Btn_SEARCH_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_SEARCH.Click
        Try
            connection()
            cmd.Connection = con
            cmd.CommandText = "Select * from Tbl_Appointment_Details where Patient_ID = " + Tb_Patient_ID.Text + ""
            dr = cmd.ExecuteReader
            If dr.Read() Then
                Dtp_Date.Text = dr("Date").ToString
                Cmb_Select_Doctor.Text = dr("Doctor_Name").ToString
                Tb_First_Name.Text = dr("First_Name").ToString
                Tb_Last_Name.Text = dr("Last_Name").ToString
                Tb_Address.Text = dr("Address").ToString
                Tb_Contact_No_1.Text = dr("Contact_No_1").ToString
                Tb_Contact_No_2.Text = dr("Contact_No_2").ToString
                Tb_Age.Text = dr("Age").ToString

                Dim gen As String = dr("Gender").ToString

                If gen = "Female" Then
                    Rb_Female.Checked = True
                ElseIf gen = "Male" Then
                    Rb_Male.Checked = True
                End If

                Cmb_Blood_Group.Text = dr("Blood_Group").ToString
                Dtp_Appointment_Date.Text = dr("Appointment_Date").ToString
                Dtp_Appointment_Time.Text = dr("Appointment_Time").ToString
                Tb_Charges.Text = dr("Charges").ToString

                If "High" = dr("Blood_Pressure").ToString Then
                    Cb_High.Checked = True
                ElseIf "Low" = dr("Blood_Pressure").ToString Then
                    Cb_Low.Checked = True
                ElseIf "Normal" = dr("Blood_Pressure").ToString Then
                    Cb_Normal.Checked = True
                End If
            Else
                MessageBox.Show("Record Not Found!!!")
                Btn_SEARCH.Enabled = False
                Tb_Patient_ID.Text = ""
                Tb_Patient_ID.Focus()

            End If
            cmd.Dispose()
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Btn_CLEAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_CLEAR.Click
        clear_control()
    End Sub

    Private Sub Btn_UPDATE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_UPDATE.Click
        Try
            connection()
            If Cmb_Select_Doctor.Text <> "" And Tb_Charges.Text <> "" And Dtp_Appointment_Date.Text <> "" And Dtp_Appointment_Time.Text <> "" Then

                cmd.CommandText = "Update Tbl_Appointment_Details SET Doctor_Name = '" + Cmb_Select_Doctor.Text + "',Appointment_Date = '" + Dtp_Appointment_Date.Text + "',Appointment_Time = '" + Dtp_Appointment_Time.Text + "',Charges = " + Tb_Charges.Text + " WHERE Patient_ID=" + Tb_Patient_ID.Text + ""
                cmd.ExecuteNonQuery()
                MessageBox.Show("Details Updated Successfully!!!")
                clear_control()
                cmd.Dispose()
                con.Close()
            Else
                MessageBox.Show("1st fill all the fields...")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Btn_SEARCH.Enabled = False
        Tb_Patient_ID.Focus()
    End Sub
End Class