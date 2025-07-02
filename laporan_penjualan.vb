Imports MySql.Data.MySqlClient
Imports Microsoft.Reporting.WinForms
Public Class laporan_penjualan
    Public Property total_penjualan_figure As Double
    Sub tampil_lap_penjualan()
        Call koneksi()
        str = "SELECT tb_jual.id_jual,
                      tb_customer.nama_customer,
                      tb_jual.tanggal_jual,
                      tb_barang.nama_barang,
                      tb_detail_jual.harga_jual,
                      tb_detail_jual.jumlah_barang,
                      tb_jual.total,
                      tb_karyawan.nama_karyawan
                      FROM tb_detail_jual
                      INNER JOIN tb_jual ON tb_jual.id_jual = tb_detail_jual.id_jual
                      INNER JOIN tb_barang ON tb_barang.id_barang = tb_detail_jual.id_barang
                      INNER JOIN tb_customer ON tb_customer.id_customer = tb_jual.id_customer
                      INNER JOIN tb_karyawan ON tb_karyawan.id_karyawan = tb_jual.id_karyawan"
        da = New MySqlDataAdapter(str, conn)
        ds = New DataSet
        da.Fill(ds, "lap_penjualan")
        DataGridView1.DataSource = ds.Tables("lap_penjualan")
    End Sub
    Sub set_dgv()
        DataGridView1.Columns(0).HeaderText = "Id Penjualan"
        DataGridView1.Columns(1).HeaderText = "Nama Customer"
        DataGridView1.Columns(2).HeaderText = "Tanggal Penjualan"
        DataGridView1.Columns(3).HeaderText = "Nama Barang"
        DataGridView1.Columns(4).HeaderText = "Harga Barang"
        DataGridView1.Columns(5).HeaderText = "Jumlah Barang"
        DataGridView1.Columns(6).HeaderText = "Total Harga"
        DataGridView1.Columns(7).HeaderText = "Nama Karyawan"

        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub
    Private Sub laporan_penjualan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampil_lap_penjualan()
        set_dgv()
        hitung_total()
    End Sub
    Sub hitung_total()
        Dim total As Double
        For Each row As DataGridViewRow In DataGridView1.Rows
            total = total + row.Cells(6).Value
        Next
        lb_total_penjualan.Text = total
        total_penjualan_figure = total
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Pastikan dataset sudah diisi
        If ds IsNot Nothing AndAlso ds.Tables.Contains("lap_penjualan") Then
            Dim printForm As New print_laporan_penjualan
            printForm.ReportData = ds ' Kirim dataset ke form print_laporan_penjualan
            printForm.ShowDialog() ' Tampilkan form sebagai dialog
        Else
            MessageBox.Show("Data belum siap untuk dicetak.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
End Class