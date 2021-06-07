Imports System.Data.SqlClient

Public Class Frm_Update_Employee_Details
    Dim con As New SqlConnection("Data Source=.\sqlexpress;Initial Catalog=Dental_Clinic_Management_System_db;Integrated Security=True")
    Dim cmd As New SqlCommand
    Dim dr As SqlDataReader
    Function connection()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Return 0
    End Function
    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Frm_Empolyee.Show()
        Me.Hide()
    End Sub

    Private Sub Frm_Update_Employee_Details_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Tb_Employee_ID.Focus()
    End Sub
    Private Sub Tb_Employee_ID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tb_Employee_ID.TextChanged
        Btn_SEARCH.Enabled = True
    End Sub

    Private Sub Btn_SEARCH_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_SEARCH.Click
        Try
            connection()
            cmd.Connection = con
            cmd.CommandText = "Select * from Tbl_Employee_Details where Employee_ID = " + Tb_Employee_ID.Text + ""
            dr = cmd.ExecuteReader

            If dr.Read() Then
                Tb_Employee_Name.Text = dr("Employee_Name").ToString
                Tb_Address.Text = dr("Address").ToString
                Tb_Education.Text = dr("Education").ToString
                Tb_Contact_No_1.Text = dr("Contact_No_1").ToString
                Tb_Contact_No_2.Text = dr("Contact_No_2").ToString
                Tb_Exprience.Text = dr("Exprience").ToString
                Tb_Joining_Date.Text = dr("Joining_Date").ToString
                Tb_Salary.Text = dr("Salary").ToString
            Else
                MessageBox.Show("Record Not Found!!!")
                Btn_SEARCH.Enabled = False
                Tb_Employee_ID.Text = ""
                Tb_Employee_ID.Focus()
            End If
            cmd.Dispose()
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Btn_Update_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Update.Click
        Try
            connection()
            If Tb_Employee_ID.Text <> "" And Tb_Employee_Name.Text <> "" And Tb_Contact_No_1.Text <> "" And Tb_Contact_No_2.Text <> "" And Tb_Address.Text <> "" And Tb_Education.Text <> "" And Tb_Exprience.Text <> "" And Tb_Joining_Date.Text <> "" And Tb_Salary.Text <> "" Then

                cmd.CommandText = "Update Tbl_Employee_Details SET Contact_No_1 = " + Tb_Contact_No_1.Text + ",Contact_No_2 = " + Tb_Contact_No_2.Text + ",Address = '" + Tb_Address.Text + "',Education = '" + Tb_Education.Text + "',Exprience ='" + Tb_Exprience.Text + "',Salary = " + Tb_Salary.Text + " WHERE Employee_ID=" + Tb_Employee_ID.Text + ""
                cmd.ExecuteNonQuery()

                MessageBox.Show("Employee Details Updated Successfully!!!")
                Tb_Employee_ID.Text = ""
                Tb_Employee_Name.Text = ""
                Tb_Address.Text = ""
                Tb_Contact_No_1.Text = ""
                Tb_Contact_No_2.Text = ""
                Tb_Education.Text = ""
                Tb_Exprience.Text = ""
                Tb_Joining_Date.Text = ""
                Tb_Salary.Text = ""
                cmd.Dispose()
                con.Close()
            Else
                MessageBox.Show("1st fill all the fields...")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Btn_SEARCH.Enabled = False
        Tb_Employee_ID.Focus()
    End Sub

    Private Sub Btn_Clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Clear.Click
        Tb_Employee_ID.Text = ""
        Tb_Employee_Name.Text = ""
        Tb_Address.Text = ""
        Tb_Contact_No_1.Text = ""
        Tb_Contact_No_2.Text = ""
        Tb_Education.Text = ""
        Tb_Exprience.Text = ""
        Tb_Joining_Date.Text = ""
        Tb_Salary.Text = ""
    End Sub

    Private Sub Tb_Contact_No_1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        charlock(e)
    End Sub

    Private Sub Tb_Contact_No_2_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        charlock(e)
    End Sub

    Private Sub Tb_Salary_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        charlock(e)
    End Sub

    Private Sub Tb_Employee_ID_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Tb_Salary.KeyPress, Tb_Employee_ID.KeyPress, Tb_Contact_No_2.KeyPress, Tb_Contact_No_1.KeyPress
        charlock(e)
    End Sub

    Private Sub Tb_Employee_Name_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Tb_Employee_Name.KeyPress
        Numlock(e)
    End Sub

    Private Sub Tb_Contact_No_1_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tb_Contact_No_1.Leave
        contact_No(Tb_Contact_No_1.TextLength)
    End Sub

    Private Sub Tb_Contact_No_2_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tb_Contact_No_2.Leave
        contact_No(Tb_Contact_No_2.TextLength)
    End Sub
End Class