Imports MySql.Data.MySqlClient
Public Class form_supplyer
    Sub tampil_user()
        Call koneksi()
        da = New MySqlDataAdapter("SELECT * FROM tb_supplyer", conn)
        ds = New DataSet
        da.Fill(ds, "supplyer")
        DataGridView1.DataSource = ds.Tables("supplyer")
    End Sub
    Sub set_dgv()
        DataGridView1.Columns(0).HeaderText = "Id Supplyer"
        DataGridView1.Columns(1).HeaderText = "Nama Supplyer"
        DataGridView1.Columns(2).HeaderText = "Email Supplyer"
        DataGridView1.Columns(3).HeaderText = "Alamat Supplyer"

        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub
    Sub tambah()
        Try
            Call koneksi()
            str = "INSERT INTO tb_supplyer VALUES ('" & tb_id_sup.Text & "','" & tb_nama_sup.Text & "','" & tb_email_sup.Text & "','" & tb_alamat_sup.Text & "')"
            cmd = New MySqlCommand(str, conn)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Data Berhasil ditambahkan")
        Catch ex As Exception
            MessageBox.Show("Data gagal ditambahkan")
        End Try
    End Sub
    Private Sub btn_tambah_Click(sender As Object, e As EventArgs) Handles btn_tambah_sup.Click
        Call tambah()
        Call tampil_user()
    End Sub

    Private Sub DataGridView1_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseDoubleClick
        tb_id_sup.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value
        tb_nama_sup.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value
        tb_email_sup.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value
        tb_alamat_sup.Text = DataGridView1.Rows(e.RowIndex).Cells(3).Value
    End Sub
    Sub edit()
        Try
            Call koneksi()
            str = "UPDATE tb_supplyer set id_supplyer='" & tb_id_sup.Text & "',
                                    nama_supplyer='" & tb_nama_sup.Text & "',
                                    email_supplyer='" & tb_email_sup.Text & "',
                                    alamat_supplyer='" & tb_alamat_sup.Text & "'
                                    WHERE id_supplyer= '" & tb_id_sup.Text & "'"
            cmd = New MySqlCommand(str, conn)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Data Berhasil diubah")
        Catch ex As Exception
            MessageBox.Show("Data gagal diubah" & ex.Message)
        End Try
    End Sub
    Sub hapus()
        Try
            Call koneksi()
            str = "DELETE FROM tb_supplyer WHERE id_supplyer='" & tb_id_sup.Text & "'"
            cmd = New MySqlCommand(str, conn)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Data Berhasil dihapus")
        Catch ex As Exception
            MessageBox.Show("Data gagal dihapus")
        End Try
    End Sub
    Sub clear()
        tb_id_sup.Text = ""
        tb_nama_sup.Text = ""
        tb_email_sup.Text = ""
        tb_alamat_sup.Text = ""
    End Sub
    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit_sup.Click
        Call edit()
        Call tampil_user()
    End Sub
    Private Sub btn_hps_Click(sender As Object, e As EventArgs) Handles btn_hps_sup.Click
        Call hapus()
        Call tampil_user()
    End Sub
    Private Sub btn_clr_Click(sender As Object, e As EventArgs) Handles btn_clr_sup.Click
        Call clear()
        Call tampil_user()
    End Sub
    Private Sub form_supplyer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call tampil_user()
        Call set_dgv()
    End Sub
End Class