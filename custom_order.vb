Imports MySql.Data.MySqlClient

Public Class custom_order
    Dim total As Double
    Dim total_lanjut As Double

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
            tb_karyawan_id.Text = rd.Item("id_karyawan")
        End If
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

    Private Sub dgv_custom_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_custom.CellEndEdit
        If e.ColumnIndex = 1 Then
            ' Menghitung total untuk row yang di-edit
            Dim rowIndex As Integer = e.RowIndex
            dgv_custom.Rows(rowIndex).Cells(2).Value = hitung_total_per_baris(rowIndex)
        End If
        hitung_total_lanjutan()
    End Sub

    Function hitung_total_per_baris(rowIndex As Integer) As Double
        Dim metode_bayar As Double
        Dim jenis_figure As Double
        Dim bahan As Double

        If cbb_metode_bayar.SelectedItem = "Tunai" Then
            metode_bayar = 0
        ElseIf cbb_metode_bayar.SelectedItem = "Transfer Bank" Then
            metode_bayar = 5000
        Else
            MessageBox.Show("Metode Bayar Tidak Valid")
            Return 0
        End If

        If cbb_jenis.SelectedItem = "Asbes" Then
            jenis_figure = 700000
        ElseIf cbb_jenis.SelectedItem = "Kursi" Then
            jenis_figure = 800000
        ElseIf cbb_jenis.SelectedItem = "Meja" Then
            jenis_figure = 900000
        ElseIf cbb_jenis.SelectedItem = "Papan Tulis" Then
            jenis_figure = 1000000
        ElseIf cbb_jenis.SelectedItem = "Springbed" Then
            jenis_figure = 1100000
        Else
            MessageBox.Show("Jenis Furniture Tidak Valid")
            Return 0
        End If

        If cbb_bahan.SelectedItem = "Kayu" Then
            bahan = 500000
        ElseIf cbb_bahan.SelectedItem = "Besi" Then
            bahan = 600000
        ElseIf cbb_bahan.SelectedItem = "Baja" Then
            bahan = 700000
        ElseIf cbb_bahan.SelectedItem = "Stainlees" Then
            bahan = 800000
        Else
            MessageBox.Show("Bahan Tidak Valid")
            Return 0
        End If

        total = metode_bayar + jenis_figure + bahan
        Dim quantity As Integer = Integer.Parse(dgv_custom.Rows(rowIndex).Cells(1).Value)
        Return total * quantity
    End Function

    Sub hitung_total_lanjutan()
        total_lanjut = 0
        For Each row As DataGridViewRow In dgv_custom.Rows
            If Not IsDBNull(row.Cells(2).Value) Then
                total_lanjut += Convert.ToDouble(row.Cells(2).Value)
            End If
        Next
        lb_total.Text = total_lanjut.ToString()
    End Sub

    Sub hitung_kembalian()
        Dim kembalian As Double
        kembalian = Convert.ToDouble(tb_bayar.Text) - Convert.ToDouble(lb_total.Text)
        lb_kembali.Text = kembalian.ToString()
        If kembalian < 0 Then
            MessageBox.Show("Uang Anda Kurang!!!!!!!!")
        End If
    End Sub

    Private Sub tb_bayar_Leave(sender As Object, e As EventArgs) Handles tb_bayar.Leave
        hitung_kembalian()
    End Sub

    Private Sub simpan()
        Call koneksi()

        For Each data As DataGridViewRow In dgv_custom.Rows
            If Not data.IsNewRow AndAlso data.Cells(0).Value IsNot Nothing AndAlso data.Cells(1).Value IsNot Nothing AndAlso data.Cells(2).Value IsNot Nothing Then
                Dim sql As String =
                "INSERT INTO tb_custom_order VALUES(
                '" & tb_idcustomorder.Text & "',
                '" & tb_customer_id.Text & "',
                '" & tb_karyawan_id.Text & "',
                '" & dtp_tanggal.Value.ToString("yyyy-MM-dd") & "',
                '" & cbb_jenis.SelectedItem & "',
                '" & cbb_bahan.SelectedItem & "',
                '" & data.Cells(0).Value & "',
                '" & data.Cells(1).Value & "',
                '" & data.Cells(2).Value & "',
                '" & cbb_status.SelectedItem & "')"
                cmd = New MySqlCommand(sql, conn)
                cmd.ExecuteNonQuery()
            End If
        Next
        MessageBox.Show("Data berhasil disimpan!")
    End Sub

    Private Sub btn_simpan_cst_Click(sender As Object, e As EventArgs) Handles btn_simpan_cst.Click
        Call simpan()
    End Sub

    Private Sub custom_order_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        panggil_karyawan()
        panggil_customer()
        tb_karyawan_id.Visible = False
        tb_customer_id.Visible = False
        tb_idcustomorder.Visible = False
        dtp_tanggal.Format = DateTimePickerFormat.Custom
        dtp_tanggal.CustomFormat = "yyyy-MM-dd"
        RemoveHandler btn_simpan_cst.Click, AddressOf btn_simpan_cst_Click
        AddHandler btn_simpan_cst.Click, AddressOf btn_simpan_cst_Click
    End Sub
    Private Sub btn_batal_Click(sender As Object, e As EventArgs) Handles btn_batal.Click
        Me.Close()
    End Sub
End Class
