Public Class Home
    Public Property NamaKaryawan As String
    Public Property ProfilUser As String
    Public Property ProfilPass As String

    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lb_datang.Text = "Selamat Datang " & NamaKaryawan
    End Sub


    Private Sub DataUseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataUseToolStripMenuItem.Click
        form_karyawan.ShowDialog()
    End Sub

    Private Sub DataBarangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataBarangToolStripMenuItem.Click
        form_barang.ShowDialog()
    End Sub

    Private Sub DataSupplyerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataSupplyerToolStripMenuItem.Click
        form_supplyer.ShowDialog()
    End Sub

    Private Sub DataCustomerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataCustomerToolStripMenuItem.Click
        form_customer.ShowDialog()
    End Sub

    Private Sub DetaiPenjualanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DetaiPenjualanToolStripMenuItem.Click
        penjualan.ShowDialog()
    End Sub

    Private Sub DetailPembelianToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DetailPembelianToolStripMenuItem.Click
        pembelian.ShowDialog()
    End Sub

    Private Sub CustomOrderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CustomOrderToolStripMenuItem.Click
        custom_order.ShowDialog()
    End Sub

    Private Sub LaporanPenjualanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LaporanPenjualanToolStripMenuItem.Click
        laporan_penjualan.ShowDialog()
    End Sub

    Private Sub LaporanPembelianToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LaporanPembelianToolStripMenuItem.Click
        laporan_pembelian.ShowDialog()
    End Sub

    Private Sub LaporanCustomOrderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LaporanCustomOrderToolStripMenuItem.Click
        laporan_custom_order.ShowDialog()
    End Sub

    Private Sub LogOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogOutToolStripMenuItem.Click
        login.Show()
        Me.Close()
    End Sub

    Private Sub UbahNamaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UbahNamaToolStripMenuItem.Click
        Dim profilForm As New profil()
        profilForm.NamaUser = ProfilUser
        profilForm.passkar = ProfilPass
        profilForm.ShowDialog()
    End Sub

    Private Sub LaporanLabaRugiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LaporanLabaRugiToolStripMenuItem.Click
        laporan_laba_rugi.ShowDialog()
    End Sub

    Private Sub MasterDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MasterDataToolStripMenuItem.Click

    End Sub
End Class
