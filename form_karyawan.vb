Imports MySql.Data.MySqlClient
Public Class form_karyawan
    Sub tampil_user()
        Call koneksi()
        da = New MySqlDataAdapter("SELECT * FROM tb_karyawan", conn)
        ds = New DataSet
        da.Fill(ds, "karyawan")
        DataGridView1.DataSource = ds.Tables("karyawan")
    End Sub
    Sub set_dgv()
        DataGridView1.Columns(0).HeaderText = "Id Karyawan"
        DataGridView1.Columns(1).HeaderText = "Nama Karyawan"
        DataGridView1.Columns(2).HeaderText = "Email Karyawan"
        DataGridView1.Columns(3).HeaderText = "Alamat Karyawan"
        DataGridView1.Columns(4).HeaderText = "No Telefon"
        DataGridView1.Columns(5).HeaderText = "Gender"
        DataGridView1.Columns(6).HeaderText = "Username"
        DataGridView1.Columns(7).HeaderText = "Password"

        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub
    Sub tambah()
        Try
            Call koneksi()
            str = "INSERT INTO tb_Karyawan VALUES ('" & tb_id_kar.Text & "','" & tb_nama_kar.Text & "','" & tb_email_kar.Text & "','" & tb_alamat_kar.Text & "','" & tb_no_kar.Text & "','" & cbb_gender_kar.SelectedItem & "','" & tb_usname_kar.Text & "','" & tb_pass_kar.Text & "')"
            cmd = New MySqlCommand(str, conn)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Data Berhasil ditambahkan")
        Catch ex As Exception
            MessageBox.Show("Data gagal ditambahkan")
        End Try
    End Sub
    Private Sub btn_tambah_Click(sender As Object, e As EventArgs) Handles btn_tambah.Click
        Call tambah()
        Call tampil_user()
    End Sub

    Private Sub DataGridView1_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseDoubleClick
        tb_id_kar.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value
        tb_nama_kar.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value
        tb_email_kar.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value
        tb_alamat_kar.Text = DataGridView1.Rows(e.RowIndex).Cells(3).Value
        tb_no_kar.Text = DataGridView1.Rows(e.RowIndex).Cells(4).Value
        cbb_gender_kar.SelectedItem = DataGridView1.Rows(e.RowIndex).Cells(5).Value
        tb_usname_kar.Text = DataGridView1.Rows(e.RowIndex).Cells(6).Value
        tb_pass_kar.Text = DataGridView1.Rows(e.RowIndex).Cells(7).Value

    End Sub
    Sub edit()
        Try
            Call koneksi()
            str = "UPDATE tb_karyawan set id_karyawan='" & tb_id_kar.Text & "',
                                    nama_karyawan='" & tb_nama_kar.Text & "',
                                    email_karyawan='" & tb_email_kar.Text & "',
                                    alamat_karyawan='" & tb_alamat_kar.Text & "',
                                    no_telefon_karyawan='" & tb_no_kar.Text & "',
                                    jenis_kelamin_karyawan='" & cbb_gender_kar.SelectedItem & "',
                                    username_karyawan='" & tb_usname_kar.Text & "',
                                    password_karyawan='" & tb_pass_kar.Text & "'
                                    WHERE id_karyawan= '" & tb_id_kar.Text & "'"
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
            str = "DELETE FROM tb_karyawan WHERE id_karyawan='" & tb_id_kar.Text & "'"
            cmd = New MySqlCommand(str, conn)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Data Berhasil dihapus")
        Catch ex As Exception
            MessageBox.Show("Data gagal dihapus")
        End Try
    End Sub
    Sub clear()
        tb_id_kar.Text = ""
        tb_nama_kar.Text = ""
        tb_email_kar.Text = ""
        tb_alamat_kar.Text = ""
        tb_no_kar.Text = ""
        cbb_gender_kar.SelectedItem = Nothing
        tb_usname_kar.Text = ""
        tb_pass_kar.Text = ""
    End Sub
    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        Call edit()
        Call tampil_user()
    End Sub
    Private Sub btn_hps_Click(sender As Object, e As EventArgs) Handles btn_hps.Click
        Call hapus()
        Call tampil_user()
    End Sub
    Private Sub btn_clr_Click(sender As Object, e As EventArgs) Handles btn_clr.Click
        Call clear()
        Call tampil_user()
    End Sub
    Private Sub form_karyawan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call tampil_user()
        Call set_dgv()
    End Sub


End Class
