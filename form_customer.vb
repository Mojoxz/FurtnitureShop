Imports MySql.Data.MySqlClient
Public Class form_customer
    Sub tampil_user()
        Call koneksi()
        da = New MySqlDataAdapter("SELECT * FROM tb_customer", conn)
        ds = New DataSet
        da.Fill(ds, "customer")
        DataGridView1.DataSource = ds.Tables("customer")
    End Sub
    Sub set_dgv()
        DataGridView1.Columns(0).HeaderText = "Id customer"
        DataGridView1.Columns(1).HeaderText = "Nama customer"
        DataGridView1.Columns(2).HeaderText = "Email customer"
        DataGridView1.Columns(3).HeaderText = "Alamat customer"
        DataGridView1.Columns(4).HeaderText = "Gender customer"
        DataGridView1.Columns(5).HeaderText = "No Telefon"

        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub
    Sub tambah()
        Try
            Call koneksi()
            str = "INSERT INTO tb_customer VALUES ('" & tb_id_cust.Text & "','" & tb_nama_cust.Text & "','" & tb_email_cust.Text & "','" & tb_alamat_cust.Text & "','" & cbb_gender_cust.SelectedItem & "','" & tb_no_cust.Text & "')"
            cmd = New MySqlCommand(str, conn)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Data Berhasil ditambahkan")
        Catch ex As Exception
            MessageBox.Show("Data gagal ditambahkan")
        End Try
    End Sub
    Private Sub btn_tambah_Click(sender As Object, e As EventArgs) Handles btn_tambah_cus.Click
        Call tambah()
        Call tampil_user()
    End Sub

    Private Sub DataGridView1_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseDoubleClick
        tb_id_cust.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value
        tb_nama_cust.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value
        tb_email_cust.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value
        tb_alamat_cust.Text = DataGridView1.Rows(e.RowIndex).Cells(3).Value
        cbb_gender_cust.SelectedItem = DataGridView1.Rows(e.RowIndex).Cells(4).Value
        tb_no_cust.Text = DataGridView1.Rows(e.RowIndex).Cells(5).Value

    End Sub
    Sub edit()
        Try
            Call koneksi()
            str = "UPDATE tb_customer set id_customer='" & tb_id_cust.Text & "',
                                    nama_customer='" & tb_nama_cust.Text & "',
                                    email_customer='" & tb_email_cust.Text & "',
                                    alamat_customer='" & tb_alamat_cust.Text & "',
                                    jenis_kelamin_customer='" & cbb_gender_cust.SelectedItem & "',
                                    no_telefon_customer='" & tb_no_cust.Text & "'
                                    WHERE id_customer= '" & tb_id_cust.Text & "'"
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
            str = "DELETE FROM tb_customer WHERE id_customer='" & tb_id_cust.Text & "'"
            cmd = New MySqlCommand(str, conn)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Data Berhasil dihapus")
        Catch ex As Exception
            MessageBox.Show("Data gagal dihapus")
        End Try
    End Sub
    Sub clear()
        tb_id_cust.Text = ""
        tb_nama_cust.Text = ""
        tb_email_cust.Text = ""
        tb_alamat_cust.Text = ""
        cbb_gender_cust.SelectedItem = Nothing
        tb_no_cust.Text = ""
    End Sub
    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit_cus.Click
        Call edit()
        Call tampil_user()
    End Sub
    Private Sub btn_hps_Click(sender As Object, e As EventArgs) Handles btn_hps_cus.Click
        Call hapus()
        Call tampil_user()
    End Sub
    Private Sub btn_clr_Click(sender As Object, e As EventArgs) Handles btn_clr_cus.Click
        Call clear()
        Call tampil_user()
    End Sub
    Private Sub form_customer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call tampil_user()
        Call set_dgv()
    End Sub
End Class
