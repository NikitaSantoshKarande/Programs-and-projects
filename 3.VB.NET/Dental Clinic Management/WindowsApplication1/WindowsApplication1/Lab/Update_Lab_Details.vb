Imports System.Data.SqlClient

Public Class Frm_Update_Lab_Details
    Dim con As New SqlConnection("Data Source=.\sqlexpress;Initial Catalog=Dental_Clinic_Management_System;Integrated Security=True")
    Dim cmd As New SqlCommand
    Dim dr As SqlDataReader
    Function connection()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Return 0
    End Function
    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Frm_Lab.Show()
        Me.Hide()
    End Sub

    Private Sub Frm_Update_Lab_Details_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Tb_Lab_ID.Focus()
    End Sub

    Private Sub Tb_Lab_ID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tb_Lab_ID.TextChanged
        Btn_SEARCH.Enabled = True
    End Sub

    Private Sub Btn_CLEAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_CLEAR.Click
        Tb_Lab_ID.Text = ""
        Tb_Lab_Name.Text = ""
        Tb_Owner_Name.Text = ""
        Tb_Address.Text = ""
        Tb_Contact_No_1.Text = ""
        Tb_Contact_No_2.Text = ""
        Dgv_Test_Cases.Rows.Clear()

    End Sub

    Private Sub Btn_SEARCH_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_SEARCH.Click
        Try
            connection()
            cmd.Connection = con
            cmd.CommandText = "Select * from Tbl_Lab_Details where Lab_ID = " + Tb_Lab_ID.Text + ""
            dr = cmd.ExecuteReader

            If dr.Read() Then
                Tb_Lab_Name.Text = dr("Lab_Name").ToString
                Tb_Owner_Name.Text = dr("Owner_Name").ToString
                Tb_Address.Text = dr("Lab_Address").ToString
                Tb_Contact_No_1.Text = dr("Contact_No_1").ToString
                Tb_Contact_No_2.Text = dr("Contact_No_2").ToString
            Else
                MessageBox.Show("Record Not Found!!!")
                Btn_SEARCH.Enabled = False
                Tb_Lab_ID.Text = ""
                Tb_Lab_ID.Focus()
            End If
            cmd.Dispose()
            dr.Close()
            cmd = New SqlCommand("select * from Tbl_Test_case_And_Charge where Lab_ID= " & Tb_Lab_ID.Text & "", con)
            dr = cmd.ExecuteReader

            While dr.Read()
                Dgv_Test_Cases.Rows.Add(dr("Lab_ID").ToString, dr("Test_Cases").ToString, dr("L_Charges").ToString)
            End While
            dr.Close()
            cmd.Dispose()
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Btn_UPDATE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_UPDATE.Click
        Try
            connection()
            If Tb_Lab_ID.Text <> "" And Tb_Lab_Name.Text <> "" And Tb_Owner_Name.Text <> "" And Tb_Address.Text <> "" And Tb_Contact_No_1.Text <> "" And Tb_Contact_No_2.Text <> "" Then

                cmd.CommandText = "Update Tbl_Lab_Details SET Lab_Name = '" + Tb_Lab_Name.Text + "',Owner_Name = '" + Tb_Owner_Name.Text + "',Lab_Address = '" + Tb_Address.Text + "',Contact_No_1 = " + Tb_Contact_No_1.Text + ",Contact_No_2 = " + Tb_Contact_No_2.Text + "WHERE Lab_ID=" + Tb_Lab_ID.Text + ""
                cmd.ExecuteNonQuery()
                MessageBox.Show("Lab Details Updated Successfully!!!")
                Tb_Lab_Name.Text = ""
                Tb_Owner_Name.Text = ""
                Tb_Address.Text = ""
                Tb_Contact_No_1.Text = ""
                Tb_Contact_No_2.Text = ""
                cmd.Dispose()
                con.Close()
            Else
                MessageBox.Show("1st fill all the fields...")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Btn_SEARCH.Enabled = False
        Tb_Lab_ID.Focus()
    End Sub

    Private Sub Tb_Contact_No_1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Tb_Contact_No_2.KeyPress, Tb_Contact_No_1.KeyPress
        charlock(e)
    End Sub

    Private Sub Tb_Owner_Name_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Tb_Owner_Name.KeyPress
        Numlock(e)
    End Sub

    Private Sub Tb_Contact_No_1_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tb_Contact_No_1.Leave
        contact_No(Tb_Contact_No_1.TextLength)
    End Sub

    Private Sub Tb_Contact_No_2_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tb_Contact_No_2.Leave
        contact_No(Tb_Contact_No_2.TextLength)
    End Sub

    Private Sub Tb_Lab_ID_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Tb_Lab_ID.KeyPress
        charlock(e)
    End Sub
End Class