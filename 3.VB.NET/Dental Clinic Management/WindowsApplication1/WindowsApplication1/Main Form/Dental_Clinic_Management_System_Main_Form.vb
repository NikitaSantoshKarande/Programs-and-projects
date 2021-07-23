Public Class Frm_Dental_Clinic_Management_System_Main_Form

    Private Sub Btn_Doctor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Doctor.Click
        Frm_Doctor.Show()
        Me.Hide()
    End Sub

    Private Sub Btn_Patient_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Patient.Click
        Frm_Patient.Show()
        Me.Hide()
    End Sub

    Private Sub Btn_Appointment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Appointment.Click
        Frm_Appointment.Show()
        Me.Hide()
    End Sub

    Private Sub Btn_Employee_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Employee.Click
        Frm_Empolyee.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox9.Click
        MessageBox.Show("Are you sure logout")
        Frm_Login.Show()
        Me.Hide()
    End Sub

    Private Sub Btn_Lab_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Lab.Click
        Frm_Lab.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Frm_Doctor.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Frm_Appointment.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        Frm_Patient.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox5.Click
        Frm_Empolyee.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        Frm_Lab.Show()
        Me.Hide()
    End Sub

   Private Sub Notepad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Notepad.Click
        Dim myapp As New System.Diagnostics.ProcessStartInfo("Notepad")
        Process.Start(myapp)
    End Sub

    Private Sub Btn_Report_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Report.Click
        Report.Show()
        Me.Hide()
    End Sub

    Private Sub Calculator_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Calculator.Click
        System.Diagnostics.Process.Start("calc.exe")
        Shell("calc.exe")
    End Sub
End Class
