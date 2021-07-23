Public Class Frm_Appointment

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Frm_Dental_Clinic_Management_System_Main_Form.Show()
        Me.Hide()
    End Sub

    Private Sub Btn_Add_Appointment_Details_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Add_Appointment_Details.Click
        Frm_Add_Appointment_Details.Show()
        Me.Hide()
    End Sub

    Private Sub Btn_Update_Appointment_Details_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Update_Appointment_Details.Click
        Frm_Update_Appointment_Details.Show()
        Me.Hide()
    End Sub

    Private Sub Btn_Search_Appointment_Details_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Search_Appointment_Details.Click
        Frm_Serach_Appointment_Details.Show()
        Me.Hide()
    End Sub

    Private Sub Btn_View_Appointment_details_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_View_Appointment_details.Click
        Frm_View_Appointment_Details.Show()
        Me.Hide()
    End Sub
End Class