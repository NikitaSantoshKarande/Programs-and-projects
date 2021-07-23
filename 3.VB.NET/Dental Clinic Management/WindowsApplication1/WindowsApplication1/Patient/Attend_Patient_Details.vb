Imports System.Data.SqlClient

Public Class Frm_Attend_Patient_Details
    Dim con As New SqlConnection("Data Source=.\sqlexpress;Initial Catalog=Dental_Clinic_Management_System;Integrated Security=True")
    Dim cmd As New SqlCommand
    Dim dr As SqlDataReader
    Dim BP As String = ""
    Dim gen As String

    Function connection()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Return 0
    End Function

    Function clear_control()
        Dtp_Date.Text = ""
        Tb_First_Name.Text = ""
        Tb_Last_Name.Text = ""
        Tb_Charges.Text = ""
        Cmb_Select_Doctor.Text = ""
        Tb_Patient_ID.Text = ""
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
        Frm_Patient.Show()
        Me.Hide()
    End Sub

    Private Sub Frm_Attend_Patient_Details_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Tb_Patient_ID.Focus()
        Me.Tb_Patient_ID.Text = Frm_Priscription.Tb_Patient_ID.Text
        Me.Cmb_Select_Doctor.Text = Frm_Priscription.Cmb_Doctor_Name.Text
        Me.Tb_First_Name.Text = Frm_Priscription.Tb_First_Name.Text
        Me.Tb_Last_Name.Text = Frm_Priscription.Tb_Last_Name.Text
        Me.Tb_Charges.Text = Frm_Priscription.Tb_Consultancy_Fees.Text
    End Sub

    Private Sub Tb_Patient_ID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tb_Patient_ID.TextChanged
        Btn_SEARCH.Enabled = True
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

                Btn_NEXT.Enabled = True
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

    Private Sub Btn_NEXT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_NEXT.Click
        connection()
        cmd.Connection = con
        If (Tb_Patient_ID.Text <> "" And Cmb_Select_Doctor.Text <> "" And Dtp_Date.Text <> "" And Tb_First_Name.Text <> "" And Tb_Address.Text <> "" And Tb_Contact_No_1.Text <> "" And Tb_Contact_No_2.Text <> "" And Tb_Age.Text <> "" And Rb_Male.Text <> "" And Rb_Female.Text <> "" And Dtp_Appointment_Date.Text <> "" And Dtp_Appointment_Time.Text <> "" And Tb_Charges.Text <> "" And Cmb_Blood_Group.Text <> "") Then
            cmd = New SqlCommand("Insert into Tbl_Attend_Patient_Details Values (" & Tb_Patient_ID.Text & ",'" & Cmb_Select_Doctor.Text & "','" & Dtp_Date.Text & "','" & Tb_First_Name.Text & "','" & Tb_Last_Name.Text & "','" & Tb_Address.Text & "'," & Tb_Contact_No_1.Text & "," & Tb_Contact_No_2.Text & "," & Tb_Age.Text & ",'" & gen & "','" & Cmb_Blood_Group.Text & "','" & Dtp_Appointment_Date.Text & "','" & Dtp_Appointment_Time.Text & "'," & Tb_Charges.Text & ",'" & BP & "')", con)
            Dim i As Integer = cmd.ExecuteNonQuery()
            MessageBox.Show("Record saved succesfully", "Success")
            Frm_Priscription.Show()

            Me.Hide()
        Else
            MessageBox.Show("server error")
        End If
        con.Close()
        cmd.Dispose()
    End Sub

    Private Sub Btn_CLEAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_CLEAR.Click
        clear_control()
    End Sub

    Private Sub Tb_Patient_ID_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Tb_Patient_ID.KeyPress
        charlock(e)
    End Sub
    Private Sub Tb_Charges_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Tb_Charges.KeyPress
        charlock(e)
    End Sub
End Class