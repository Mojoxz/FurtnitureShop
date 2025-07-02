Imports MySql.Data.MySqlClient
Public Class penjualan
    Sub panggil_karyawan()
        Call koneksi()
        Dim str As String
        Dim adaptor As New MySqlDataAdapter
        Dim dt = New DataTable

        str = "SELECT * FROM tb_karyawan"
        cmd = New MySqlCommand(str, conn)
        adaptor = New MySqlDataAdapter(cmd)
        dt = New DataTable()
        adaptor.Fill(dt)
        Dim col As New AutoCompleteStringCollection
        For i As Integer = 0 To dt.Rows.Count - 1
            col.Add(dt.Rows(i)("nama_karyawan"))
        Next
        tb_karyawan_nama.AutoCompleteSource = AutoCompleteSource.CustomSource
        tb_karyawan_nama.AutoCompleteCustomSource = col
        tb_karyawan_nama.AutoCompleteMode = AutoCompleteMode.Suggest
    End Sub

    Sub get_id_karyawan()
        Call koneksi()
        Dim str As String
        str = "SELECT id_karyawan FROM tb_karyawan WHERE nama_karyawan='" & tb_karyawan_nama.Text & "'"
        cmd = New MySqlCommand(str, conn)
        rd = cmd.ExecuteReader
        If rd.HasRows Then
            rd.Read()
            tb_karyawan_id.Text = rd.Item("Id_karyawan")
        End If
    End Sub

    Private Sub penjualan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        panggil_karyawan()
        panggil_customer()
        tb_karyawan_id.Visible = False
        tb_customer_id.Visible = False
        dtp_tanggal.Format = DateTimePickerFormat.Custom
        dtp_tanggal.CustomFormat = "yyyy-MM-dd"
        tb_id_detail_jual.Visible = False
    End Sub

    Private Sub tb_karyawan_nama_Leave(sender As Object, e As EventArgs) Handles tb_karyawan_nama.Leave
        get_id_karyawan()
    End Sub

    Sub panggil_customer()
        Call koneksi()
        Dim str As String
        Dim adaptor As New MySqlDataAdapter
        Dim dt = New DataTable

        str = "SELECT * FROM tb_customer"
        cmd = New MySqlCommand(str, conn)
        adaptor = New MySqlDataAdapter(cmd)
        dt = New DataTable()
        adaptor.Fill(dt)
        Dim col As New AutoCompleteStringCollection
        For i As Integer = 0 To dt.Rows.Count - 1
            col.Add(dt.Rows(i)("nama_customer"))
        Next
        tb_customer_nama.AutoCompleteSource = AutoCompleteSource.CustomSource
        tb_customer_nama.AutoCompleteCustomSource = col
        tb_customer_nama.AutoCompleteMode = AutoCompleteMode.Suggest
    End Sub

    Sub get_id_customer()
        Call koneksi()
        Dim str As String
        str = "SELECT id_customer FROM tb_customer WHERE nama_customer='" & tb_customer_nama.Text & "'"
        cmd = New MySqlCommand(str, conn)
        rd = cmd.ExecuteReader
        If rd.HasRows Then
            rd.Read()
            tb_customer_id.Text = rd.Item("Id_customer")
        End If
    End Sub

    Private Sub tb_customer_nama_Leave(sender As Object, e As EventArgs) Handles tb_customer_nama.Leave
        get_id_customer()
    End Sub

    Private Sub dgv_jual_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_jual.CellEndEdit
        If e.ColumnIndex = 0 Then
            Call koneksi()
            str = "SELECT * FROM tb_barang WHERE id_barang ='" & dgv_jual.Rows(e.RowIndex).Cells(0).Value & "'"
            cmd = New MySqlCommand(str, conn)
            rd = cmd.ExecuteReader
            If rd.HasRows Then
                rd.Read()
                dgv_jual.Rows(e.RowIndex).Cells(1).Value = rd.Item("nama_barang")
                dgv_jual.Rows(e.RowIndex).Cells(2).Value = rd.Item("harga")
                dgv_jual.Rows(e.RowIndex).Cells(3).Value = "1"
            Else
                MessageBox.Show("Kode barang tidak ditemukan")
            End If
        ElseIf e.ColumnIndex = 3 Then
            dgv_jual.Rows(e.RowIndex).Cells(4).Value = dgv_jual.Rows(e.RowIndex).Cells(2).Value * dgv_jual.Rows(e.RowIndex).Cells(3).Value
            hitung_total()
        End If
    End Sub

    Sub hitung_total()
        Dim total As Double
        Dim metode_bayar As Double

        If cbb_metode_bayar.SelectedItem = "Tunai" Then
            metode_bayar = 0
        ElseIf cbb_metode_bayar.SelectedItem = "Transfer Bank" Then
            metode_bayar = 5000
        Else
            MessageBox.Show("Metode Bayar Tidak Valid")
        End If

        For Each row As DataGridViewRow In dgv_jual.Rows
            total = total + row.Cells(4).Value
        Next
        lb_total.Text = total + metode_bayar
    End Sub
    Sub hitung_kembalian()
        Dim kembalian As Double
        kembalian = tb_bayar.Text - lb_total.Text
        lb_kembali.Text = kembalian
        If kembalian < 0 Then
            MessageBox.Show("Uang Anda Kurang!!!!!!!!")
        End If
    End Sub

    Private Sub tb_bayar_Leave(sender As Object, e As EventArgs) Handles tb_bayar.Leave
        hitung_kembalian()
    End Sub

    Private Sub simpan()
        koneksi()
        Dim sql_header As String =
                "INSERT INTO tb_jual VALUES(
                '" & tb_idjual.Text & "',
                '" & tb_customer_id.Text & "',
                '" & tb_karyawan_id.Text & "',
                '" & dtp_tanggal.Value.ToString("yyyy-MM-dd") & "',
                '" & lb_total.Text & "',
                '" & tb_bayar.Text & "',
                '" & lb_kembali.Text & "',
                '" & cbb_metode_bayar.SelectedItem & "')"
        cmd = New MySqlCommand(sql_header, conn)
        cmd.ExecuteNonQuery()
        For Each data As DataGridViewRow In dgv_jual.Rows
            If Not data.IsNewRow Then
                tb_id_detail_jual.Text = GenerateUniqueID()
                Dim sql As String =
                "INSERT INTO tb_detail_jual VALUES(
                '" & tb_id_detail_jual.Text & "',
                '" & tb_idjual.Text & "',
                '" & data.Cells(0).Value & "',
                '" & data.Cells(2).Value & "',
                '" & data.Cells(3).Value & "',
                '" & data.Cells(4).Value & "')"
                cmd = New MySqlCommand(sql, conn)
                cmd.ExecuteNonQuery()

                Dim sql_update As String =
                    "UPDATE tb_barang SET
                stock=stock-'" & data.Cells(3).Value & "'
                WHERE id_barang='" & data.Cells(0).Value & "'"
                cmd = New MySqlCommand(sql_update, conn)
                cmd.ExecuteNonQuery()
            End If
        Next
        MessageBox.Show("data berhasil disimpan!")
    End Sub
    Private Function GenerateUniqueID() As String
        Return Guid.NewGuid().ToString("N")
    End Function
    Private Sub bt_simpan_Click(sender As Object, e As EventArgs) Handles btn_simpan.Click
        Call simpan()
    End Sub

    Private Sub btn_batal_Click(sender As Object, e As EventArgs) Handles btn_batal.Click
        Me.Close()
    End Sub


End Class