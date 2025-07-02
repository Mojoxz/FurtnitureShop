Imports MySql.Data.MySqlClient
Public Class laporan_custom_order
    Public Property total_custom_figure
    Sub tampil_lap_custom()
        Call koneksi()
        str = "SELECT tb_custom_order.id_custom_order,
                      tb_customer.nama_customer,
                      tb_custom_order.tanggal_order,
                      tb_custom_order.jenis_custom,
                      tb_custom_order.jenis_bahan,
                      tb_custom_order.desain_custom,
                      tb_custom_order.jumlah_order,
                      tb_custom_order.total_harga,
                      tb_custom_order.status_order,
                      tb_karyawan.nama_karyawan
                      FROM tb_custom_order
                      INNER JOIN tb_karyawan ON tb_karyawan.id_karyawan = tb_custom_order.id_karyawan
                      INNER JOIN tb_customer ON tb_customer.id_customer = tb_custom_order.id_customer"
        da = New MySqlDataAdapter(str, conn)
        ds = New DataSet
        da.Fill(ds, "lap_custom")
        DataGridView1.DataSource = ds.Tables("lap_custom")
    End Sub
    Sub set_dgv()
        DataGridView1.Columns(0).HeaderText = "Id Custom Order"
        DataGridView1.Columns(1).HeaderText = "Nama Customer"
        DataGridView1.Columns(2).HeaderText = "Tanggal Order"
        DataGridView1.Columns(3).HeaderText = "Jenis Furniture"
        DataGridView1.Columns(4).HeaderText = "Bahan"
        DataGridView1.Columns(5).HeaderText = "Jenis"
        DataGridView1.Columns(6).HeaderText = "Jumlah Order"
        DataGridView1.Columns(7).HeaderText = "Total Harga"
        DataGridView1.Columns(8).HeaderText = "Status"
        DataGridView1.Columns(9).HeaderText = "Nama Karyawan"

        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub
    Private Sub laporan_pembelian_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampil_lap_custom()
        set_dgv()
        hitung_total()
    End Sub
    Sub hitung_total()
        Dim total As Double
        For Each row As DataGridViewRow In DataGridView1.Rows
            total = total + row.Cells(7).Value
        Next
        lb_total_custom.Text = total
        total_custom_figure = total
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Pastikan dataset sudah diisi
        If ds IsNot Nothing AndAlso ds.Tables.Contains("lap_custom") Then
            Dim printForm As New print_laporan_custom
            printForm.ReportData = ds ' Kirim dataset ke form print_laporan_penjualan
            printForm.ShowDialog() ' Tampilkan form sebagai dialog
        Else
            MessageBox.Show("Data belum siap untuk dicetak.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
End Class