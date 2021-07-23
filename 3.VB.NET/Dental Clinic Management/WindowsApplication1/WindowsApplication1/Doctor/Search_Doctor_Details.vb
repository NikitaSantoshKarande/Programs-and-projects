Imports System.Data.SqlClient

Public Class Frm_Search_Doctor_Details
    Dim cmd As New SqlCommand
    Dim dr As SqlDataReader
    Public con As New SqlConnection("Data Source=.\sqlexpress;Initial Catalog=Dental_Clinic_Management_System;Integrated Security=True")

    Public Sub connection()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
    End Sub

    Private Sub Search_Doctor_Details_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Tb_Doctor_ID.Focus()
    End Sub

    Private Sub Tb_Doctor_ID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tb_Doctor_ID.TextChanged
        Btn_SEARCH.Enabled = True
    End Sub
    Function Clear_Control()
        Tb_Doctor_ID.Text = ""
        Tb_Contact_No_1.Text = ""
        Tb_Contact_No_2.Text = ""
        Tb_Clinic_Address.Text = ""
        Tb_Age.Text = ""
        Tb_Email_ID.Text = ""
        Dtp_Joining_Date.Text = ""
        Tb_Doctor_Name.Text = ""
        Dtp_DOB.Text = ""
        Dgv_Special_Charges.Rows.Clear()
        Return 0
    End Function

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

            While dr.Read()
                Dgv_Special_Charges.Rows.Add(dr("Doctor_ID").ToString, dr("Specialization").ToString, dr("S_Charges").ToString)
            End While
            dr.Close()
            cmd.Dispose()
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Btn_CLEAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_CLEAR.Click
        Clear_Control()
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Frm_Doctor.Show()
        Me.Hide()
    End Sub

    Private Sub Tb_Doctor_ID_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Tb_Doctor_ID.KeyPress
        charlock(e)
    End Sub
End Class