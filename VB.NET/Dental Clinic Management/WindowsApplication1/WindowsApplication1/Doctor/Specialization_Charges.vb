Imports System.Data.SqlClient

Public Class Frm_Specialization_Charges
    Dim con As New SqlConnection("Data Source=.\sqlexpress;Initial Catalog=Dental_Clinic_Management_System_db;Integrated Security=True")
    Dim cmd As New SqlCommand
    Dim dr As SqlDataReader
    Function connection()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Return 0
    End Function
    Private Sub Tb_Doctor_ID_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Tb_Doctor_ID.KeyPress
        charlock(e)
    End Sub

    Private Sub Specialization_Charges_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Tb_Doctor_ID.Focus()
        Try
            connection()
            cmd.Connection = con
            cmd.CommandText = "Select * From Tbl_Specialization_And_Charges"
            Dim da As New SqlDataAdapter(cmd)
            Dim dt As New DataTable()
            da.Fill(dt)
            Dgv_Specialization_and_Charges.DataSource = dt
            cmd.Dispose()
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Tb_Doctor_ID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tb_Doctor_ID.TextChanged
        Btn_SEARCH.Enabled = True
    End Sub

    Private Sub Btn_x_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_x.Click
        Me.Hide()
        Frm_View_Doctor_Details.Show()
    End Sub

    Private Sub Btn_SEARCH_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_SEARCH.Click
        Try
            connection()
            cmd.Connection = con
            cmd.CommandText = "select * from Tbl_Specialization_And_Charges where Doctor_ID = " + Tb_Doctor_ID.Text + ""
            Dim da As New SqlDataAdapter(cmd)
            Dim dt As New DataTable()
            da.Fill(dt)
            Dgv_Specialization_and_Charges.DataSource = dt
            cmd.Dispose()
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Dgv_Specialization_and_Charges_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Dgv_Specialization_and_Charges.CellContentClick

    End Sub

    Private Sub Lbl_Select_Type_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Lbl_Doctor_ID.Click

    End Sub
End Class