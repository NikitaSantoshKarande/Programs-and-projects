Imports System.Data.SqlClient

Public Class Frm_Update_Doctor_Details
        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader
    Public con As New SqlConnection("Data Source=.\sqlexpress;Initial Catalog=Dental_Clinic_Management_System_db;Integrated Security=True")

        Public Sub connection()
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If
        End Sub
        Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
            Frm_Doctor.Show()
            Me.Hide()
    End Sub
    Function Clear_Controls()
        Try
            Tb_Doctor_ID.Text = ""
            Tb_Contact_No_1.Text = ""
            Tb_Contact_No_2.Text = ""
            Tb_Clinic_Address.Text = ""
            Tb_Age.Text = ""
            Tb_Email_ID.Text = ""
            Dtp_Joining_Date.Text = ""
            Tb_Doctor_Name.Text = ""
            Dtp_DOB.Text = ""
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return 0
    End Function

        Private Sub Frm_Update_Doctor_Details_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            Tb_Doctor_ID.Focus()
        End Sub
    Private Sub Tb_Doctor_ID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tb_Doctor_ID.TextChanged
        Btn_SEARCH.Enabled = True
    End Sub

    Private Sub Btn_SEARCH_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_SEARCH.Click
        Try
            connection()
            cmd.Connection = con
            cmd.CommandText = "Select * from Tbl_Doctor_Details where Doctor_ID = " + Tb_Doctor_ID.Text + ""
            dr = cmd.ExecuteReader

            If dr.Read() Then
                Tb_Doctor_Name.Text = dr("Doctor_Name").ToString
                Tb_Contact_No_1.Text = dr("Contact_No_1").ToString
                Tb_Contact_No_2.Text = dr("Contact_No_2").ToString
                Tb_Clinic_Address.Text = dr("Clinic_Address").ToString
                Dtp_Joining_Date.Text = dr("Date").ToString
                Dtp_DOB.Text = dr("DOB").ToString
                Tb_Age.Text = dr("Age").ToString
                Tb_Email_ID.Text = dr("Email_ID").ToString
            Else
                MessageBox.Show("Record Not Found!!!")
                Btn_SEARCH.Enabled = False
                Tb_Doctor_ID.Text = ""
                Tb_Doctor_ID.Focus()
            End If
            cmd.Dispose()
            dr.Close()
            cmd = New SqlCommand("select * from Tbl_Specialization_And_Charges where Doctor_ID = " + Tb_Doctor_ID.Text + "", con)
            dr = cmd.ExecuteReader
            cmd.Dispose()
            dr.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Btn_UPDATE.Enabled = True
        Tb_Contact_No_1.Enabled = True
        Tb_Contact_No_2.Enabled = True
        Tb_Clinic_Address.Enabled = True
        Tb_Email_ID.Enabled = True
    End Sub

    Private Sub Btn_UPDATE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_UPDATE.Click
        Try
            connection()
            If Tb_Doctor_ID.Text <> "" And Tb_Doctor_Name.Text <> "" And Tb_Contact_No_1.Text <> "" And Tb_Contact_No_2.Text <> "" And Tb_Clinic_Address.Text <> "" And Dtp_Joining_Date.Text <> "" And Dtp_DOB.Text <> "" And Tb_Age.Text <> "" And Tb_Email_ID.Text <> "" Then

                cmd.CommandText = "Update Tbl_Doctor_Details SET Contact_No_1 = " + Tb_Contact_No_1.Text + ",Contact_No_2 = " + Tb_Contact_No_2.Text + ",Clinic_Address = '" + Tb_Clinic_Address.Text + "',Age = " + Tb_Age.Text + ",Email_ID = '" + Tb_Email_ID.Text + "'WHERE Doctor_ID='" + Tb_Doctor_ID.Text + "'"
                cmd.ExecuteNonQuery()

                MessageBox.Show("Doctor Details Updated Successfully!!!")
                Clear_Controls()
                cmd.Dispose()
                con.Close()
            Else
                MessageBox.Show("1st fill all the fields...")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Btn_SEARCH.Enabled = False
        Tb_Doctor_ID.Focus()
    End Sub

    Private Sub Btn_CLEAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_CLEAR.Click
        Clear_Controls()
    End Sub

    Private Sub Tb_Contact_No_1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Tb_Contact_No_1.KeyPress
        charlock(e)
    End Sub

    Private Sub Tb_Contact_No_2_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Tb_Contact_No_2.KeyPress
        charlock(e)
    End Sub

    Private Sub Tb_Contact_No_1_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tb_Contact_No_1.Leave
        contact_No(Tb_Contact_No_1.TextLength)
    End Sub

    Private Sub Tb_Contact_No_2_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tb_Contact_No_2.Leave
        contact_No(Tb_Contact_No_2.TextLength)
    End Sub

    Private Sub Tb_Doctor_ID_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Tb_Doctor_ID.KeyPress
        charlock(e)
    End Sub
End Class