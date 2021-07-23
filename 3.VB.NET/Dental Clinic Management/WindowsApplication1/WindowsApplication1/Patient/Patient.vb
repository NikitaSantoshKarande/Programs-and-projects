Public Class Frm_Patient

    Private Sub Btn_Add_Patient_Details_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Add_Patient_Details.Click
        Frm_Attend_Patient_Details.Show()
        Me.Hide()
    End Sub

    Private Sub Btn_Update_Patient_Details_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Frm_Search_Patient_Details.Show()
        Me.Hide()
    End Sub

    Private Sub Btn_View_Patient_details_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_View_Patient_details.Click
        Frm_View_Patient_Details.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Frm_Dental_Clinic_Management_System_Main_Form.Show()
        Me.Hide()
    End Sub
End Class