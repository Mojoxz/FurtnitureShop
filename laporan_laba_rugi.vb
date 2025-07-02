Public Class laporan_laba_rugi
    Private laporanPenjualan As laporan_penjualan
    Private laporanPembelian As laporan_pembelian
    Private laporanCustomOrder As laporan_custom_order

    Private Sub laporan_laba_rugi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        laporanPenjualan = New laporan_penjualan()
        laporanPembelian = New laporan_pembelian()
        laporanCustomOrder = New laporan_custom_order()


        laporanPenjualan.tampil_lap_penjualan()
        laporanPenjualan.hitung_total()

        laporanPembelian.tampil_lap_pembelian()
        laporanPembelian.hitung_total()

        laporanCustomOrder.tampil_lap_custom()
        laporanCustomOrder.hitung_total()

        hitung_pendapatan_pengeluaran()
    End Sub
    Sub hitung_pendapatan_pengeluaran()
        Dim total_penjualan As Double = laporanPenjualan.total_penjualan_figure
        Dim total_pembelian As Double = laporanPembelian.total_pembelian_figure
        Dim total_custom As Double = laporanCustomOrder.total_custom_figure
        Dim total_pendapatan As Double = total_penjualan + total_custom
        Dim keuntungan_rugi As Double = total_pendapatan - total_pembelian

        lb_total_penjualan.Text = total_pendapatan
        lb_total_pembelian.Text = total_pembelian
        lb_keuntungan_rugi.Text = keuntungan_rugi

        If total_pendapatan < 0 Then
            lb_total_penjualan.ForeColor = Color.Red
        Else
            lb_total_penjualan.ForeColor = Color.Green
        End If

        If total_pembelian < 0 Then
            lb_total_pembelian.ForeColor = Color.Green
        Else
            lb_total_pembelian.ForeColor = Color.Red
        End If

        If keuntungan_rugi < 0 Then
            lb_keuntungan_rugi.ForeColor = Color.Red
        Else
            lb_keuntungan_rugi.ForeColor = Color.Green
        End If
    End Sub
End Class