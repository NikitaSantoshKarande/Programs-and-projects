Public Class Frm_Doctor
    Private Sub Btn_Add_Doctor_Details_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Add_Doctor_Details.Click
        Frm_Add_Doctor_Details.Show()
        Me.Hide()
    End Sub

    Private Sub Btn_Update_Doctor_Details_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Update_Doctor_Details.Click
        Frm_Update_Doctor_Details.Show()
        Me.Hide()
    End Sub

    Private Sub Btn_View_Doctor_details_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_View_Doctor_details.Click
        Frm_View_Doctor_Details.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Frm_Dental_Clinic_Management_System_Main_Form.Show()
        Me.Hide()
    End Sub

    Private Sub Btn_Search_Details_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Search_Details.Click
        Frm_Search_Doctor_Details.Show()
        Me.Hide()
    End Sub
End Class