Imports Microsoft.Reporting.WinForms

Public Class print_laporan_custom
    Public Property ReportData As DataSet ' Properti untuk menerima dataset

    Private Sub print_laporan_custom_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Pastikan ReportData sudah diisi
        If ReportData IsNot Nothing AndAlso ReportData.Tables.Contains("lap_custom") Then
            Dim rds As New ReportDataSource("DataSet1", ReportData.Tables("lap_custom"))
            With ReportViewer1.LocalReport
                .DataSources.Clear()
                .DataSources.Add(rds)
                .ReportPath = "D:\KULIAH SEMSTER 3\pemvis\TubesPemvis\Point_Of_Sales_Apps_VB.Net-master\Point_Of_Sales_Apps_VB.Net-master\202301043_uas\Report3.rdlc" ' Path report Anda
            End With
            ReportViewer1.RefreshReport()
        Else
            MessageBox.Show("Data tidak tersedia untuk ditampilkan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class