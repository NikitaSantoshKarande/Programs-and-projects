Imports System.Data.SqlClient

Public Class Frm_Add_Appointment_Details
    Dim con As New SqlConnection("Data Source=.\sqlexpress;Initial Catalog=Dental_Clinic_Management_System_db;Integrated Security=True")
    Dim cmd As New SqlCommand
    Dim gen As String
    Dim BP As String = ""
        Function connection()
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If
            Return 0
    End Function
    Function gender()
        If Rb_Male.Checked = True Then
            gen = "Male"
        End If
        If Rb_Female.Checked = True Then
            gen = "Female"
        End If
        Return 0
    End Function
    Function auto_increment()
        connection()
        Dim cnt As Integer
        cmd = New SqlCommand("select count(Patient_ID)from Tbl_Appointment_Details", con)
        cnt = cmd.ExecuteScalar
        If cnt = 0 Then
            cnt = 1001
        Else
            cnt += 1001
        End If
        Return cnt
    End Function
    Function value()
        If Cb_Low.Checked = True Then
            BP = BP + "Low"
        End If
        If Cb_Normal.Checked = True Then
            BP = BP + "Normal"
        End If
        If Cb_High.Checked = True Then
            BP = BP + "High"
        End If
        Return 0
    End Function
    Function clear_Control()
        Cmb_Select_Doctor.Text = ""
        Dtp_Date.Text = ""
        Tb_First_Name.Text = ""
        Tb_Last_Name.Text = ""
        Tb_Address.Text = ""
        Tb_Contact_No_1.Text = ""
        Tb_Contact_No_2.Text = ""
        Tb_Age.Text = ""
        Cmb_Blood_Group.Text = ""
        Dtp_Appointment_Date.Text = ""
        Dtp_Appointment_Time.Text = ""
        Tb_Charges.Text = ""
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

    Private Sub Btn_SAVE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_SAVE.Click
        connection()
        gender()
        value()
        If (Tb_Patient_ID.Text <> "" And Cmb_Select_Doctor.Text <> "" And Dtp_Date.Text <> "" And Tb_First_Name.Text <> "" And Tb_Address.Text <> "" And Tb_Contact_No_1.Text <> "" And Tb_Contact_No_2.Text <> "" And Tb_Age.Text <> "" And Rb_Male.Text <> "" And Rb_Female.Text <> "" And Dtp_Appointment_Date.Text <> "" And Dtp_Appointment_Time.Text <> "" And Tb_Charges.Text <> "") Then
            cmd = New SqlCommand("Insert into Tbl_Appointment_Details Values (" & Tb_Patient_ID.Text & ",'" & Cmb_Select_Doctor.Text & "','" & Dtp_Date.Text & "','" & Tb_First_Name.Text & "','" & Tb_Last_Name.Text & "','" & Tb_Address.Text & "'," & Tb_Contact_No_1.Text & "," & Tb_Contact_No_2.Text & "," & Tb_Age.Text & ",'" & gen & "','" & Cmb_Blood_Group.Text & "','" & Dtp_Appointment_Date.Text & "','" & Dtp_Appointment_Time.Text & "'," & Tb_Charges.Text & ",'" & BP & "')", con)
            Dim i As Integer = cmd.ExecuteNonQuery()
            MessageBox.Show("Record saved succesfully", "Success")
            auto_increment()
            clear_Control()
        Else
            MessageBox.Show("server error")
        End If
        con.Close()
    End Sub

    Private Sub Btn_CLEAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_CLEAR.Click
        clear_Control()
    End Sub

    Private Sub Frm_Add_Appointment_Details_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Tb_Patient_ID.Text = auto_increment()
    End Sub

    Private Sub Tb_Contact_No_1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Tb_Patient_ID.KeyPress, Tb_Contact_No_2.KeyPress, Tb_Contact_No_1.KeyPress, Tb_Age.KeyPress
        charlock(e)
    End Sub

    Private Sub Tb_Contact_No_1_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tb_Contact_No_1.Leave
        contact_No(Tb_Contact_No_1.TextLength)
    End Sub

    Private Sub Tb_Contact_No_2_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tb_Contact_No_2.Leave
        contact_No(Tb_Contact_No_2.TextLength)
    End Sub

    Private Sub Tb_Charges_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Tb_Charges.KeyPress
        charlock(e)
    End Sub

    Private Sub Cmb_Blood_Group_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Cmb_Blood_Group.KeyPress
        charlock(e)
        Numlock(e)
    End Sub

    Private Sub Cmb_Select_Doctor_DropDown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmb_Select_Doctor.DropDown
       
    End Sub

    Private Sub Cmb_Blood_Group_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmb_Blood_Group.Leave
        'If Dtp_Appointment_Date.Value < Today.Date Then
        '    MessageBox.Show("Ïnvalid Date Please Select")
        '    Dtp_Appointment_Date.Focus()
        'End If
    End Sub

    Private Sub Dtp_Appointment_Date_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Dtp_Appointment_Date.ValueChanged
        If Dtp_Appointment_Date.Value < Today.Date Then
            MessageBox.Show("Ïnvalid Date Please Select")
            Dtp_Appointment_Date.Focus()
            Btn_SAVE.Enabled = False
        Else
            Btn_SAVE.Enabled = True
        End If
    End Sub

    Private Sub Cmb_Select_Doctor_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmb_Select_Doctor.Enter
        connection()
        Dim dr As SqlDataReader
        cmd.Connection = con
        cmd.CommandText = "Select Doctor_Name from Tbl_Doctor_Details"
        Cmb_Select_Doctor.Items.Clear()
        dr = cmd.ExecuteReader()
        While dr.Read()
            Cmb_Select_Doctor.Items.Add(dr("Doctor_Name").ToString)
        End While
        dr.Close()
        con.Close()
    End Sub
End Class