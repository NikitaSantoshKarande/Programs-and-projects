Imports System.Data.SqlClient

Public Class Frm_Add_Lab_Details
    Dim con As New SqlConnection("Data Source=.\sqlexpress;Initial Catalog=Dental_Clinic_Management_System_db;Integrated Security=True")
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
        cmd = New SqlCommand("select count(Lab_ID)from Tbl_Lab_Details", con)
        cnt = cmd.ExecuteScalar
        If cnt = 0 Then
            cnt = 1001
        Else
            cnt += 1001
        End If
        Return cnt
    End Function

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Frm_Lab.Show()
        Me.Hide()
    End Sub

    Private Sub Btn_SAVE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_SAVE.Click
        connection()
        If Tb_Lab_ID.Text <> "" And Tb_Lab_Name.Text <> "" And Tb_Owner_Name.Text <> "" And Tb_Address.Text <> "" And Tb_Contact_No_1.Text <> "" And Tb_Contact_No_2.Text <> "" Then
            cmd = New SqlCommand("Insert into Tbl_Lab_Details Values (" & Tb_Lab_ID.Text & ",'" & Tb_Lab_Name.Text & "','" & Tb_Owner_Name.Text & "','" & Tb_Address.Text & "'," & Tb_Contact_No_1.Text & "," & Tb_Contact_No_2.Text & ")", con)
        End If
        Dim i As Integer = cmd.ExecuteNonQuery()
        cmd.Dispose()
        i = 0
        For Each row As DataGridViewRow In Dgv_Test_Cases.Rows
            cmd = New SqlCommand("Insert into Tbl_Test_case_And_Charge Values (" + Dgv_Test_Cases.Rows(i).Cells(0).Value + ",'" + Dgv_Test_Cases.Rows(i).Cells(1).Value + "'," + Dgv_Test_Cases.Rows(i).Cells(2).Value + ")", con)
            cmd.ExecuteNonQuery()
            i = i + 1
        Next

        If (i > 0) Then
            MessageBox.Show("Record saved succesfully", "Success")
            auto_increment()
            Tb_Lab_Name.Text = ""
            Tb_Owner_Name.Text = ""
            Tb_Address.Text = ""
            Tb_Contact_No_1.Text = ""
            Tb_Contact_No_2.Text = ""
            Tb_Test_Cases.Text = ""
            Tb_Charges.Text = ""
            Dgv_Test_Cases.Rows.Clear()
            con.Close()
        Else
            MessageBox.Show("server error")

        End If
    End Sub

    Private Sub Frm_Add_Lab_Details_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Tb_Lab_ID.Text = auto_increment()
    End Sub

    Private Sub Btn_CLEAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_CLEAR.Click
        Tb_Lab_Name.Text = ""
        Tb_Lab_Name.Text = ""
        Tb_Owner_Name.Text = ""
        Tb_Address.Text = ""
        Tb_Contact_No_1.Text = ""
        Tb_Contact_No_2.Text = ""
        Tb_Test_Cases.Text = ""
    End Sub

    Private Sub Btn_Add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Add.Click
            If Tb_Test_Cases.Text <> "" And Tb_Charges.Text <> "" Then
                Dgv_Test_Cases.Rows.Add(Tb_Lab_ID.Text, Tb_Test_Cases.Text, Tb_Charges.Text)
                Tb_Test_Cases.Text = ""
                Tb_Charges.Text = ""
            End If
    End Sub

    Private Sub Tb_Lab_ID_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Tb_Lab_ID.KeyPress
        charlock(e)
    End Sub

    Private Sub Tb_Lab_Name_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Tb_Test_Cases.KeyPress, Tb_Owner_Name.KeyPress, Tb_Lab_Name.KeyPress
        Numlock(e)
    End Sub

    Private Sub Tb_Charges_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Tb_Contact_No_2.KeyPress, Tb_Contact_No_1.KeyPress, Tb_Charges.KeyPress
        charlock(e)
    End Sub

    Private Sub Tb_Contact_No_1_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tb_Contact_No_1.Leave
        contact_No(Tb_Contact_No_1.TextLength)
    End Sub

    Private Sub Tb_Contact_No_2_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tb_Contact_No_2.Leave
        contact_No(Tb_Contact_No_2.TextLength)
    End Sub
End Class