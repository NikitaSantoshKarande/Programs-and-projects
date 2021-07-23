Imports System.Data.SqlClient

Public Class Frm_Priscription
    Dim id As Integer
    Dim con As New SqlConnection("Data Source=.\sqlexpress;Initial Catalog=Dental_Clinic_Management_System;Integrated Security=True")
    Dim cmd As New SqlCommand
    Dim treatment As String = ""
    Dim price As Double = 0
    Dim c1, c2, c3, c4, c5, c6 As Integer
    Function connection()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Return 0
    End Function
    Function values()
        For Each item In Clb_Treatment.CheckedItems
            treatment = treatment + item + " "
        Next
        Return 0
    End Function
    Function Clear_Control()
        Tb_First_Name.Text = ""
        Tb_Last_Name.Text = ""
        Tb_Patient_ID.Text = ""
        Tb_Consultancy_Fees.Text = ""
        Tb_Jaw_Teeth_No.Text = ""
        Tb_Medication.Text = ""
        Tb_Charges.Text = ""
        Tb_Quantity.Text = ""
        Tb_Grand_Total.Text = ""
        Cmb_Doctor_Name.Text = ""
        Dgv_Medication_Quantity.Rows.Clear()
        Return 0
    End Function
    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Frm_Attend_Patient_Details.Show()
        Me.Hide()
    End Sub
    Private Sub Btn_ADD_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_ADD.Click
        Try
            If Tb_Medication.Text <> "" And Tb_Quantity.Text <> "" Then
                Dgv_Medication_Quantity.Rows.Add(Tb_Patient_ID.Text, Tb_Medication.Text, Tb_Quantity.Text)
                Tb_Medication.Text = ""
                Tb_Quantity.Text = ""
                Tb_Grand_Total.Text = Val(Tb_Charges.Text) + Val(Tb_Consultancy_Fees.Text)
            End If
            Btn_SAVE_AND_PRINT.Enabled = True
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Btn_SAVE_AND_PRINT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_SAVE_AND_PRINT.Click
        connection()
        cmd = New SqlCommand("Insert into Tbl_Prescription_Details Values (" & Tb_Patient_ID.Text & ",'" & Tb_First_Name.Text & "','" & Tb_Last_Name.Text & "','" & Dtp_Date.Text & "','" & Cmb_Doctor_Name.Text & "'," & Tb_Consultancy_Fees.Text & "," & Tb_Jaw_Teeth_No.Text & ",'" & treatment & "'," & Tb_Charges.Text & "," & Tb_Grand_Total.Text & ")", con)
        Dim i As Integer = cmd.ExecuteNonQuery()

        cmd.Dispose()
        i = 0
        For Each row As DataGridViewRow In Dgv_Medication_Quantity.Rows
            cmd = New SqlCommand("Insert into Tbl_Medication_Quantity Values (" + Dgv_Medication_Quantity.Rows(i).Cells(0).Value + ",'" + Dgv_Medication_Quantity.Rows(i).Cells(1).Value + "'," + Dgv_Medication_Quantity.Rows(i).Cells(2).Value + ")", con)
            cmd.ExecuteNonQuery()
            i = i + 1
        Next
        If (i > 0) Then
            MessageBox.Show("Record saved succesfully,.....Printing", "Success")
            cmd.Dispose()
            '' cmd = New SqlCommand("delete from Tbl_Appointment_Details where Patient_ID=" & Tb_Patient_ID.Text & "", con)
            '' cmd.ExecuteNonQuery()
            '' Clb_Treatment.Text = ""
            id = Tb_Patient_ID.Text '*********for report
            Clear_Control()
            con.Close()
        Else
            MessageBox.Show("server error")
        End If
    End Sub

    Private Sub Frm_Priscription_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Tb_Patient_ID.Text = Frm_Attend_Patient_Details.Tb_Patient_ID.Text
        Me.Cmb_Doctor_Name.Text = Frm_Attend_Patient_Details.Cmb_Select_Doctor.Text
        Me.Tb_First_Name.Text = Frm_Attend_Patient_Details.Tb_First_Name.Text
        Me.Tb_Last_Name.Text = Frm_Attend_Patient_Details.Tb_Last_Name.Text
        Me.Tb_Consultancy_Fees.Text = Frm_Attend_Patient_Details.Tb_Charges.Text
        Tb_Jaw_Teeth_No.Focus()
    End Sub

    Private Sub Tb_Quantity_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Tb_Quantity.KeyPress, Tb_Charges.KeyPress
        charlock(e)
    End Sub

    Private Sub Tb_Jaw_Teeth_No_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Tb_Jaw_Teeth_No.KeyPress
        charlock(e)
    End Sub

    Private Sub Tb_Medication_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Tb_Medication.KeyPress
        Numlock(e)
    End Sub

    Private Sub Tb_Quantity_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tb_Quantity.TextChanged
        Btn_ADD.Enabled = True
    End Sub

    Private Sub Clb_Treatment_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Clb_Treatment.SelectedIndexChanged

    End Sub

    Private Sub Clb_Treatment_ItemCheck(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ItemCheckEventArgs) Handles Clb_Treatment.ItemCheck

        If Clb_Treatment.SelectedIndex = 0 Then

            If c1 = 0 Then
                price = price + 100
                c1 = 1
            Else
                price = price - 100
                c1 = 0
            End If

        ElseIf Clb_Treatment.SelectedIndex = 1 Then

            If c2 = 0 Then
                price = price + 500
                c2 = 1
            Else
                price = price - 500
                c2 = 0
            End If
        ElseIf Clb_Treatment.SelectedIndex = 2 Then

            If c3 = 0 Then
                price = price + 300
                c3 = 1
            Else
                price = price - 300
                c3 = 0
            End If
        ElseIf Clb_Treatment.SelectedIndex = 3 Then

            If c4 = 0 Then
                price = price + 150
                c4 = 1
            Else
                price = price - 150
                c4 = 0
            End If
        ElseIf Clb_Treatment.SelectedIndex = 4 Then

            If c5 = 0 Then
                price = price + 1000
                c5 = 1
            Else
                price = price - 1000
                c5 = 0
            End If
        ElseIf Clb_Treatment.SelectedIndex = 5 Then

            If c6 = 0 Then
                price = price + 600
                c6 = 1
            Else
                price = price - 600
                c6 = 0
            End If
        End If
        Tb_Charges.Text = price
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        connection()
        Dim dt As New DataTable
        cmd = New SqlCommand("select * from Tbl_Prescription_Details where Patient_ID=" & id & "", con)
        Dim adb = New SqlDataAdapter(cmd)
        adb.Fill(dt)

        Dim dt2 As New DataTable
        cmd = New SqlCommand("select * from Tbl_Medication_Quantity where Patient_ID=" & id & "", con)
        adb = New SqlDataAdapter(cmd)
        adb.Fill(dt2)

        Dim rpt As New priscription_report
        rpt.Database.Tables("Tbl_Prescription_Details").SetDataSource(dt)
        rpt.Database.Tables("Tbl_Medication_Quantity").SetDataSource(dt2)

        frm_Prescription_report.CrystalReportViewer1.ReportSource = Nothing
        frm_Prescription_report.CrystalReportViewer1.ReportSource = rpt
        con.Close()
        frm_Prescription_report.ShowDialog()
    End Sub
End Class