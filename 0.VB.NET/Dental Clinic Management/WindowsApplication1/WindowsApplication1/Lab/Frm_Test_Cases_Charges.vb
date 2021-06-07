Imports System.Data.SqlClient

Public Class Frm_Test_Cases_Charges
    Dim con As New SqlConnection("Data Source=.\sqlexpress;Initial Catalog=Dental_Clinic_Management_System_db;Integrated Security=True")
    Dim cmd As New SqlCommand
    Function connection()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Return 0
    End Function
    
    Private Sub Frm_Test_Cases_Charges_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Tb_Lab_ID.Focus()
        Try
            connection()
            cmd.Connection = con
            cmd.CommandText = "Select * From Tbl_Test_case_And_Charge"
            Dim da As New SqlDataAdapter(cmd)
            Dim dt As New DataTable()
            da.Fill(dt)
            Dgv_Test_case_And_Charge.DataSource = dt
            cmd.Dispose()
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Tb_Lab_ID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tb_Lab_ID.TextChanged
        Btn_SEARCH.Enabled = True
    End Sub

    Private Sub Btn_SEARCH_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_SEARCH.Click
        Try
            connection()
            cmd.Connection = con
            cmd.CommandText = "select * from Tbl_Test_case_And_Charge where Lab_ID = " + Tb_Lab_ID.Text + ""
            Dim da As New SqlDataAdapter(cmd)
            Dim dt As New DataTable()
            da.Fill(dt)
            Dgv_Test_case_And_Charge.DataSource = dt
            cmd.Dispose()
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Btn_x_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_x.Click
        Me.Close()
        Frm_View_Lab_Details.Show()
    End Sub

    Private Sub Tb_Lab_ID_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Tb_Lab_ID.KeyPress
        charlock(e)
    End Sub
End Class