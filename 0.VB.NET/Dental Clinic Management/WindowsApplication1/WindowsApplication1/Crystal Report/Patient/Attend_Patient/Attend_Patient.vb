Imports System.Data.SqlClient

Public Class frm_Attend_Patient_rpt
    Dim con As New SqlConnection("Data Source=.\sqlexpress;Initial Catalog=Dental_Clinic_Management_System_db;Integrated Security=True")
    Dim cmd As New SqlCommand
    Dim dr As SqlDataReader
    Function connection()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Return 0
    End Function
    Private Sub Btn_SEARCH_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_SEARCH.Click
        If dtp_from.Value < dtp_to.Value Then
            connection()
            cmd = New SqlCommand("select * from Tbl_Attend_Patient_Details where Appointment_Date between '" & dtp_from.Text & "' and '" & dtp_to.Text & "'", con)
            Dim da As New SqlDataAdapter(cmd)
            Dim dt As New DataTable()
            da.Fill(dt)

            con.Close()
            Dim rpt As New CrystalReportlistpatient
            rpt.Database.Tables("Tbl_Attend_Patient_Details").SetDataSource(dt)

            Attend_Patient_rpt.ReportSource = rpt
            cmd.Dispose()
            con.Close()
        Else
            MsgBox("Please Select correct date.....", MsgBoxStyle.OkOnly)
        End If
    End Sub
End Class