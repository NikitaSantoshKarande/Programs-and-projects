Public Class Frm_Empolyee

    Private Sub Btn_Add_Employee_Details_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Add_Employee_Details.Click
        Frm_Add_Employee_Details.Show()
        Me.Hide()
    End Sub

    Private Sub Btn_Update_Employee_Details_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Update_Employee_Details.Click
        Frm_Update_Employee_Details.Show()
        Me.Hide()
    End Sub

    Private Sub Btn_Search_Employee_Details_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Search_Employee_Details.Click
        Frm_Search_Employee_Details.Show()
        Me.Hide()
    End Sub

    Private Sub Btn_View_Employee_details_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_View_Employee_details.Click
        Frm_View_Employee_Details.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Frm_Dental_Clinic_Management_System_Main_Form.Show()
        Me.Hide()
    End Sub
End Class