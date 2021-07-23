Imports System.Data.SqlClient

Public Class Frm_Add_Employee_Details
    Dim con As New SqlConnection("Data Source=.\sqlexpress;Initial Catalog=Dental_Clinic_Management_System;Integrated Security=True")
    Dim cmd As New SqlCommand
    Function connection()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Return 0
    End Function
    Function auto_increment()
        connection()
        Dim cnt As Integer
        cmd = New SqlCommand("select count(Employee_ID)from Tbl_Employee_Details", con)
        cnt = cmd.ExecuteScalar
        If cnt = 0 Then
            cnt = 1001
        Else
            cnt += 1001
        End If
        Return cnt
    End Function

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Frm_Empolyee.Show()
        Me.Hide()
    End Sub
    Private Sub Btn_SAVE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_SAVE.Click
        connection()
        If Tb_Employee_ID.Text <> "" And Tb_Employee_Name.Text <> "" And Tb_Address.Text <> "" And Tb_Education.Text <> "" And Tb_Contact_No_1.Text <> "" And Tb_Contact_No_2.Text <> "" And Tb_Exprience.Text <> "" And Dtp_Joining_Date.Text <> "" And Tb_Salary.Text <> "" Then
            cmd = New SqlCommand("Insert into Tbl_Employee_Details Values (" + Tb_Employee_ID.Text + ",'" + Tb_Employee_Name.Text + "','" + Tb_Address.Text + "','" + Tb_Education.Text + "'," + Tb_Contact_No_1.Text + "," + Tb_Contact_No_2.Text + ",'" + Tb_Exprience.Text + "','" + Dtp_Joining_Date.Text + "'," + Tb_Salary.Text + ")", con)
        End If
        Dim i As Integer = cmd.ExecuteNonQuery()
        If (i > 0) Then
            MessageBox.Show("Record saved succesfully", "Success")
            Tb_Employee_ID.Text = auto_increment()
            Tb_Employee_Name.Text = ""
            Tb_Address.Text = ""
            Tb_Education.Text = ""
            Tb_Contact_No_1.Text = ""
            Tb_Contact_No_2.Text = ""
            Tb_Exprience.Text = ""
            Tb_Salary.Text = ""
        Else
            MessageBox.Show("server error")
            con.Close()
        End If
    End Sub

    Private Sub Btn_CLEAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_CLEAR.Click
        Tb_Employee_ID.Text = ""
        Tb_Employee_Name.Text = ""
        Tb_Address.Text = ""
        Tb_Contact_No_1.Text = ""
        Tb_Contact_No_2.Text = ""
        Tb_Education.Text = ""
        Tb_Exprience.Text = ""
        Tb_Salary.Text = ""
    End Sub

    Private Sub Frm_Add_Employee_Details_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Tb_Employee_ID.Text = auto_increment()
    End Sub

    Private Sub Tb_Employee_ID_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        charlock(e)
    End Sub

    Private Sub Tb_Employee_Name_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Tb_Employee_Name.KeyPress
        Numlock(e)
    End Sub

    Private Sub Tb_Contact_No_1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        charlock(e)
    End Sub

    Private Sub Tb_Contact_No_2_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        charlock(e)
    End Sub

    Private Sub Tb_Salary_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Tb_Salary.KeyPress, Tb_Employee_ID.KeyPress, Tb_Contact_No_2.KeyPress, Tb_Contact_No_1.KeyPress
        charlock(e)
    End Sub

    Private Sub Tb_Contact_No_1_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tb_Contact_No_1.Leave
        contact_No(Tb_Contact_No_1.TextLength)
    End Sub

    Private Sub Tb_Contact_No_2_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tb_Contact_No_2.Leave
        contact_No(Tb_Contact_No_2.TextLength)
    End Sub
End Class