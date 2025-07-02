Imports MySql.Data.MySqlClient
Public Class form_barang
    Sub tampil_user()
        Call koneksi()
        da = New MySqlDataAdapter("SELECT * FROM tb_barang", conn)
        ds = New DataSet
        da.Fill(ds, "barang")
        DataGridView1.DataSource = ds.Tables("barang")
    End Sub
    Sub set_dgv()
        DataGridView1.Columns(0).HeaderText = "Id Barang"
        DataGridView1.Columns(1).HeaderText = "Nama Barang"
        DataGridView1.Columns(2).HeaderText = "Merk"
        DataGridView1.Columns(3).HeaderText = "Karakter Furniture"
        DataGridView1.Columns(4).HeaderText = "Asal Furniture"
        DataGridView1.Columns(5).HeaderText = "Jenis Furniture"
        DataGridView1.Columns(6).HeaderText = "Bahan Furniture"
        DataGridView1.Columns(7).HeaderText = "Harga"
        DataGridView1.Columns(8).HeaderText = "Stock"
        DataGridView1.Columns(9).HeaderText = "Status Barang"

        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub
    Sub tambah()
        Try
            Call koneksi()
            str = "INSERT INTO tb_barang VALUES ('" & tb_id_bar.Text & "','" & tb_nama_bar.Text & "','" & tb_merk_bar.Text & "','" & tb_kar_bar.Text & "','" & cbb_asal_bar.SelectedItem & "','" & cbb_jenis_bar.SelectedItem & "','" & cbb_bahan_bar.SelectedItem & "','" & tb_harga_bar.Text & "','" & tb_stock_bar.Text & "','" & cbb_status_bar.SelectedItem & "')"
            cmd = New MySqlCommand(str, conn)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Data Berhasil ditambahkan")
        Catch ex As Exception
            MessageBox.Show("Data gagal ditambahkan" & ex.Message)
        End Try
    End Sub
    Private Sub btn_tambah_Click(sender As Object, e As EventArgs) Handles btn_tambah_bar.Click
        Call tambah()
        Call tampil_user()
    End Sub

    Private Sub DataGridView1_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseDoubleClick
        tb_id_bar.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value
        tb_nama_bar.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value
        tb_merk_bar.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value
        tb_kar_bar.Text = DataGridView1.Rows(e.RowIndex).Cells(3).Value
        cbb_asal_bar.SelectedItem = DataGridView1.Rows(e.RowIndex).Cells(4).Value
        cbb_jenis_bar.SelectedItem = DataGridView1.Rows(e.RowIndex).Cells(5).Value
        cbb_bahan_bar.SelectedItem = DataGridView1.Rows(e.RowIndex).Cells(6).Value
        tb_harga_bar.Text = DataGridView1.Rows(e.RowIndex).Cells(7).Value
        tb_stock_bar.Text = DataGridView1.Rows(e.RowIndex).Cells(8).Value
        cbb_status_bar.SelectedItem = DataGridView1.Rows(e.RowIndex).Cells(9).Value

    End Sub
    Sub edit()
        Try
            Call koneksi()
            str = "UPDATE tb_barang set id_barang='" & tb_id_bar.Text & "',
                                    nama_barang='" & tb_nama_bar.Text & "',
                                    merek='" & tb_merk_bar.Text & "',
                                    karakter_furniture='" & tb_kar_bar.Text & "',
                                    asal_furniture='" & cbb_asal_bar.SelectedItem & "',
                                    jenis_furniture='" & cbb_jenis_bar.SelectedItem & "',
                                    bahan_furniture='" & cbb_bahan_bar.SelectedItem & "',
                                    harga='" & tb_harga_bar.Text & "',
                                    stock='" & tb_stock_bar.Text & "',
                                    status_barang='" & cbb_status_bar.SelectedItem & "'
                                    WHERE id_barang= '" & tb_id_bar.Text & "'"
            cmd = New MySqlCommand(str, conn)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Data Berhasil diubah")
        Catch ex As Exception
            MessageBox.Show("Data gagal diubah")
        End Try
    End Sub
    Sub hapus()
        Try
            Call koneksi()
            str = "DELETE FROM tb_barang WHERE id_barang='" & tb_id_bar.Text & "'"
            cmd = New MySqlCommand(str, conn)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Data Berhasil dihapus")
        Catch ex As Exception
            MessageBox.Show("Data gagal dihapus")
        End Try
    End Sub
    Sub clear()
        tb_id_bar.Text = ""
        tb_nama_bar.Text = ""
        tb_merk_bar.Text = ""
        tb_nama_bar.Text = ""
        tb_kar_bar.Text = ""
        cbb_asal_bar.SelectedItem = Nothing
        cbb_jenis_bar.SelectedItem = Nothing
        cbb_bahan_bar.SelectedItem = Nothing
        tb_harga_bar.Text = ""
        tb_stock_bar.Text = ""
        cbb_status_bar.Text = ""
    End Sub
    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit_bar.Click
        Call edit()
        Call tampil_user()
    End Sub
    Private Sub btn_hps_Click(sender As Object, e As EventArgs) Handles btn_hapus_bar.Click
        Call hapus()
        Call tampil_user()
    End Sub
    Private Sub btn_clr_Click(sender As Object, e As EventArgs) Handles btn_clr_bar.Click
        Call clear()
        Call tampil_user()
    End Sub
    Private Sub form_barang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call tampil_user()
        Call set_dgv()
    End Sub
End Class
