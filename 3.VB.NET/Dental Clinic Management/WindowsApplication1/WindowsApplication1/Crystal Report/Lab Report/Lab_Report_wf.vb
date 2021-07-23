Imports System.Data.SqlClient

Public Class Lab_Report_wf
    Dim con As New SqlConnection("Data Source=.\sqlexpress;Initial Catalog=Dental_Clinic_Management_System;Integrated Security=True")
    Dim cmd As New SqlCommand
    Dim dr As SqlDataReader
    Function connection()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Return 0
    End Function

    Private Sub cb_Search_Type_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_Search_Type.SelectedIndexChanged
        Connection()
        If cb_Search_Type.SelectedIndex = 0 Then
            cb_Search_Name.Items.Clear()
            cmd = New SqlCommand("select Lab_Name from Tbl_Lab_Details", con)
            dr = Cmd.ExecuteReader()
            While dr.Read()
                cb_Search_Name.Items.Add(dr("Lab_Name"))
            End While
            dr.Close()
            Cmd.Dispose()
            con.Close()
        End If
    End Sub

    Private Sub Btn_SEARCH_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_SEARCH.Click
        If cb_Search_Name.Text <> "" And cb_Search_Type.SelectedIndex <> -1 Then
            connection()
            If cb_Search_Type.SelectedIndex = 0 Then
                ' Dim id As Integer = 0
                cmd = New SqlCommand("select * from Tbl_Lab_Details where Lab_Name = '" & cb_Search_Name.Text & "'", con)
                Dim da As New SqlDataAdapter(cmd)
                Dim dt As New DataTable()
                da.Fill(dt)
                con.Close()
                Dim rpt As New Lab_Report

                rpt.Database.Tables("Tbl_Lab_Details").SetDataSource(dt)

                CrystalReportViewer2.ReportSource = rpt
                cmd.Dispose()
                dr.Close()

            End If
        End If
    End Sub
End Class