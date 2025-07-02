Imports MySql.Data.MySqlClient
Public Class laporan_pembelian
    Public Property total_pembelian_figure As Double
    Sub tampil_lap_pembelian()
        Call koneksi()
        str = "SELECT tb_beli.id_beli,
                      tb_supplyer.nama_supplyer,
                      tb_beli.tanggal_beli,
                      tb_barang.nama_barang,
                      tb_detail_beli.harga_beli,
                      tb_detail_beli.jumlah_barang,
                      tb_beli.total,
                      tb_karyawan.nama_karyawan
                      FROM tb_detail_beli
                      INNER JOIN tb_beli ON tb_beli.id_beli = tb_detail_beli.id_beli
                      INNER JOIN tb_barang ON tb_barang.id_barang = tb_detail_beli.id_barang
                      INNER JOIN tb_supplyer ON tb_supplyer.id_supplyer = tb_beli.id_supplyer
                      INNER JOIN tb_karyawan ON tb_karyawan.id_karyawan = tb_beli.id_karyawan"
        da = New MySqlDataAdapter(str, conn)
        ds = New DataSet
        da.Fill(ds, "lap_pembelian")
        DataGridView1.DataSource = ds.Tables("lap_pembelian")
    End Sub
    Sub set_dgv()
        DataGridView1.Columns(0).HeaderText = "Id Pembelian"
        DataGridView1.Columns(1).HeaderText = "Nama Supplyer"
        DataGridView1.Columns(2).HeaderText = "Tanggal Pembelian"
        DataGridView1.Columns(3).HeaderText = "Nama Barang"
        DataGridView1.Columns(4).HeaderText = "Harga Barang"
        DataGridView1.Columns(5).HeaderText = "Jumlah Barang"
        DataGridView1.Columns(6).HeaderText = "Total Harga"
        DataGridView1.Columns(7).HeaderText = "Nama Karyawan"

        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub
    Private Sub laporan_pembelian_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampil_lap_pembelian()
        set_dgv()
        hitung_total()
    End Sub
    Sub hitung_total()
        Dim total As Double
        For Each row As DataGridViewRow In DataGridView1.Rows
            total = total + row.Cells(6).Value
        Next
        lb_total_pembelian.Text = total
        total_pembelian_figure = total
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Pastikan dataset sudah diisi
        If ds IsNot Nothing AndAlso ds.Tables.Contains("lap_pembelian") Then
            Dim printForm As New print_laporan_pembelian
            printForm.ReportData = ds ' Kirim dataset ke form print_laporan_penjualan
            printForm.ShowDialog() ' Tampilkan form sebagai dialog
        Else
            MessageBox.Show("Data belum siap untuk dicetak.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
End Class