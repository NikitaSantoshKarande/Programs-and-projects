Imports System.Data.SqlClient

Public Class Frm_Add_Doctor_Details
    Dim con As New SqlConnection("Data Source=.\sqlexpress;Initial Catalog=Dental_Clinic_Management_System;Integrated Security=True")
    Dim cmd As New SqlCommand
    Dim currentage As Integer
    Function connection()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Return 0
    End Function
    Function auto_increment()
        connection()
        Dim cnt As Integer
        cmd = New SqlCommand("select count(Doctor_ID)from Tbl_Doctor_Details", con)
        cnt = cmd.ExecuteScalar
        If cnt = 0 Then
            cnt = 1001
        Else
            cnt += 1001
        End If
        Return cnt
    End Function

    Function Clear_Controls()
        Tb_Doctor_ID.Text = auto_increment()
        Tb_Doctor_Name.Text = ""
        Tb_Contact_No_1.Text = ""
        Tb_Contact_No_2.Text = ""
        Tb_Clinic_Address.Text = ""
        Dtp_DOB.Text = ""
        Tb_Age.Text = ""
        Tb_Email_ID.Text = ""
        Tb_Specialization.Text = ""
        Tb_Charges.Text = ""
        Dgv_Special_Charges.Rows.Clear()

        Return 0
    End Function

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Frm_Doctor.Show()
        Me.Hide()
    End Sub

    Private Sub Frm_Add_Doctor_Details_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Tb_Doctor_ID.Text = auto_increment()
        Me.Tb_Doctor_Name.Text = Frm_Add_Appointment_Details.Cmb_Select_Doctor.Text
    End Sub

    Private Sub Btn_CLEAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_CLEAR.Click
        Clear_Controls()
    End Sub
    Private Sub Btn_Add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Add.Click
        Try
            If Tb_Specialization.Text <> "" And Tb_Charges.Text <> "" Then
                Dgv_Special_Charges.Rows.Add(Tb_Doctor_ID.Text, Tb_Specialization.Text, Tb_Charges.Text)
                Tb_Specialization.Text = ""
                Tb_Charges.Text = ""
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Btn_SAVE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_SAVE.Click
        connection()
        cmd = New SqlCommand("Insert into Tbl_Doctor_Details Values (" & Tb_Doctor_ID.Text & ",'" & Tb_Doctor_Name.Text & "'," & Tb_Contact_No_1.Text & "," & Tb_Contact_No_2.Text & ",'" & Tb_Clinic_Address.Text & "','" & Dtp_DOB.Text & "', " & Tb_Age.Text & ",'" & Tb_Email_ID.Text & "','" & Dtp_Date.Text & "' )", con)
        Dim i As Integer = cmd.ExecuteNonQuery()

        cmd.Dispose()
        i = 0
        For Each row As DataGridViewRow In Dgv_Special_Charges.Rows
            cmd = New SqlCommand("Insert into Tbl_Specialization_And_Charges Values (" + Dgv_Special_Charges.Rows(i).Cells(0).Value + ",'" + Dgv_Special_Charges.Rows(i).Cells(1).Value + "'," + Dgv_Special_Charges.Rows(i).Cells(2).Value + ")", con)
            cmd.ExecuteNonQuery()
            i = i + 1
        Next

        If (i > 0) Then
            MessageBox.Show("Record saved succesfully", "Success")
            auto_increment()
            Clear_Controls()
            con.Close()
        Else
            MessageBox.Show("server error")
        End If
    End Sub
    Private Sub Tb_Contact_No_1_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tb_Contact_No_1.Leave
        contact_No(Tb_Contact_No_1.TextLength)
    End Sub

    Private Sub Tb_Contact_No_2_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tb_Contact_No_2.Leave
        contact_No(Tb_Contact_No_2.TextLength)
    End Sub

    Private Sub Tb_Contact_No_1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Tb_Contact_No_1.KeyPress
        charlock(e)
    End Sub

    Private Sub Tb_Age_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Tb_Age.KeyPress
        charlock(e)
    End Sub

    Private Sub Tb_Doctor_Name_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Tb_Doctor_Name.KeyPress
        Numlock(e)
    End Sub

    Private Sub Tb_Specialization_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Tb_Specialization.KeyPress
        Numlock(e)
    End Sub

    Private Sub Tb_Charges_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Tb_Charges.KeyPress
        charlock(e)
    End Sub

    Private Sub Tb_Doctor_ID_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Tb_Doctor_ID.KeyPress
        charlock(e)
    End Sub

    Private Sub Dtp_DOB_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Dtp_DOB.Leave
        If Dtp_DOB.Value.Year > Date.Today.Year Then
            MessageBox.Show("Ïnvalid Date Please Select Valid DOB")
            Dtp_DOB.Focus()
        Else
            Tb_Age.Text = Date.Today.Year - Dtp_DOB.Value.Year
        End If
    End Sub
End Class
