Imports System.Data.SqlClient

Public Class Frm_Search_Employee_Details
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

    Private Sub Frm_Search_Employee_Details_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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

    Private Sub Tb_Employee_ID_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Tb_Employee_ID.KeyPress
        charlock(e)
    End Sub
End Class