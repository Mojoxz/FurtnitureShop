<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class penjualan
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(penjualan))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tb_karyawan_nama = New System.Windows.Forms.TextBox()
        Me.tb_karyawan_id = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tb_customer_id = New System.Windows.Forms.TextBox()
        Me.tb_customer_nama = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtp_tanggal = New System.Windows.Forms.DateTimePicker()
        Me.dgv_jual = New System.Windows.Forms.DataGridView()
        Me.btn_simpan = New System.Windows.Forms.Button()
        Me.btn_batal = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lb_total = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lb_kembali = New System.Windows.Forms.Label()
        Me.tb_bayar = New System.Windows.Forms.TextBox()
        Me.cbb_metode_bayar = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tb_idjual = New System.Windows.Forms.TextBox()
        Me.tb_id_detail_jual = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.id_barang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nama_barang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.harga = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.jumlah = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgv_jual, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(319, 11)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Karyawan"
        '
        'tb_karyawan_nama
        '
        Me.tb_karyawan_nama.Location = New System.Drawing.Point(377, 11)
        Me.tb_karyawan_nama.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tb_karyawan_nama.Name = "tb_karyawan_nama"
        Me.tb_karyawan_nama.Size = New System.Drawing.Size(133, 20)
        Me.tb_karyawan_nama.TabIndex = 1
        '
        'tb_karyawan_id
        '
        Me.tb_karyawan_id.Location = New System.Drawing.Point(753, 261)
        Me.tb_karyawan_id.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tb_karyawan_id.Name = "tb_karyawan_id"
        Me.tb_karyawan_id.Size = New System.Drawing.Size(26, 20)
        Me.tb_karyawan_id.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(319, 45)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Customer"
        '
        'tb_customer_id
        '
        Me.tb_customer_id.Location = New System.Drawing.Point(753, 282)
        Me.tb_customer_id.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tb_customer_id.Name = "tb_customer_id"
        Me.tb_customer_id.Size = New System.Drawing.Size(26, 20)
        Me.tb_customer_id.TabIndex = 5
        '
        'tb_customer_nama
        '
        Me.tb_customer_nama.Location = New System.Drawing.Point(377, 41)
        Me.tb_customer_nama.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tb_customer_nama.Name = "tb_customer_nama"
        Me.tb_customer_nama.Size = New System.Drawing.Size(133, 20)
        Me.tb_customer_nama.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(588, 25)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Tanggal"
        '
        'dtp_tanggal
        '
        Me.dtp_tanggal.CustomFormat = "yyyy-MM-dd"
        Me.dtp_tanggal.Location = New System.Drawing.Point(644, 23)
        Me.dtp_tanggal.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dtp_tanggal.Name = "dtp_tanggal"
        Me.dtp_tanggal.Size = New System.Drawing.Size(135, 20)
        Me.dtp_tanggal.TabIndex = 7
        '
        'dgv_jual
        '
        Me.dgv_jual.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.dgv_jual.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_jual.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_barang, Me.nama_barang, Me.harga, Me.jumlah, Me.total})
        Me.dgv_jual.Location = New System.Drawing.Point(11, 96)
        Me.dgv_jual.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dgv_jual.Name = "dgv_jual"
        Me.dgv_jual.RowHeadersWidth = 62
        Me.dgv_jual.RowTemplate.Height = 28
        Me.dgv_jual.Size = New System.Drawing.Size(766, 162)
        Me.dgv_jual.TabIndex = 8
        '
        'btn_simpan
        '
        Me.btn_simpan.BackColor = System.Drawing.Color.DimGray
        Me.btn_simpan.ForeColor = System.Drawing.Color.White
        Me.btn_simpan.Location = New System.Drawing.Point(83, 280)
        Me.btn_simpan.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btn_simpan.Name = "btn_simpan"
        Me.btn_simpan.Size = New System.Drawing.Size(71, 30)
        Me.btn_simpan.TabIndex = 9
        Me.btn_simpan.Text = "Simpan"
        Me.btn_simpan.UseVisualStyleBackColor = False
        '
        'btn_batal
        '
        Me.btn_batal.BackColor = System.Drawing.Color.DimGray
        Me.btn_batal.ForeColor = System.Drawing.Color.White
        Me.btn_batal.Location = New System.Drawing.Point(167, 280)
        Me.btn_batal.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btn_batal.Name = "btn_batal"
        Me.btn_batal.Size = New System.Drawing.Size(71, 30)
        Me.btn_batal.TabIndex = 10
        Me.btn_batal.Text = "Batal"
        Me.btn_batal.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(594, 284)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 20)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Total : Rp. "
        '
        'lb_total
        '
        Me.lb_total.AutoSize = True
        Me.lb_total.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_total.ForeColor = System.Drawing.Color.Black
        Me.lb_total.Location = New System.Drawing.Point(673, 284)
        Me.lb_total.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lb_total.Name = "lb_total"
        Me.lb_total.Size = New System.Drawing.Size(18, 20)
        Me.lb_total.TabIndex = 12
        Me.lb_total.Text = "0"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(405, 275)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Bayar :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(384, 306)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(97, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Kembalian : Rp."
        '
        'lb_kembali
        '
        Me.lb_kembali.AutoSize = True
        Me.lb_kembali.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_kembali.ForeColor = System.Drawing.Color.Black
        Me.lb_kembali.Location = New System.Drawing.Point(468, 306)
        Me.lb_kembali.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lb_kembali.Name = "lb_kembali"
        Me.lb_kembali.Size = New System.Drawing.Size(14, 13)
        Me.lb_kembali.TabIndex = 15
        Me.lb_kembali.Text = "0"
        '
        'tb_bayar
        '
        Me.tb_bayar.Location = New System.Drawing.Point(448, 271)
        Me.tb_bayar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tb_bayar.Name = "tb_bayar"
        Me.tb_bayar.Size = New System.Drawing.Size(95, 20)
        Me.tb_bayar.TabIndex = 16
        '
        'cbb_metode_bayar
        '
        Me.cbb_metode_bayar.FormattingEnabled = True
        Me.cbb_metode_bayar.Items.AddRange(New Object() {"Tunai", "Transfer Bank"})
        Me.cbb_metode_bayar.Location = New System.Drawing.Point(644, 54)
        Me.cbb_metode_bayar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cbb_metode_bayar.Name = "cbb_metode_bayar"
        Me.cbb_metode_bayar.Size = New System.Drawing.Size(135, 21)
        Me.cbb_metode_bayar.TabIndex = 17
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(528, 56)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(122, 13)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Metode Pembayaran"
        '
        'tb_idjual
        '
        Me.tb_idjual.Location = New System.Drawing.Point(377, 68)
        Me.tb_idjual.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tb_idjual.Name = "tb_idjual"
        Me.tb_idjual.Size = New System.Drawing.Size(133, 20)
        Me.tb_idjual.TabIndex = 19
        '
        'tb_id_detail_jual
        '
        Me.tb_id_detail_jual.Location = New System.Drawing.Point(753, 306)
        Me.tb_id_detail_jual.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tb_id_detail_jual.Name = "tb_id_detail_jual"
        Me.tb_id_detail_jual.Size = New System.Drawing.Size(26, 20)
        Me.tb_id_detail_jual.TabIndex = 20
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(332, 71)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(45, 13)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Id Jual"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(54, 16)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(183, 60)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 22
        Me.PictureBox1.TabStop = False
        '
        'id_barang
        '
        Me.id_barang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.id_barang.HeaderText = "ID Barang"
        Me.id_barang.MinimumWidth = 8
        Me.id_barang.Name = "id_barang"
        '
        'nama_barang
        '
        Me.nama_barang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.nama_barang.HeaderText = "Nama Barang"
        Me.nama_barang.MinimumWidth = 8
        Me.nama_barang.Name = "nama_barang"
        '
        'harga
        '
        Me.harga.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.harga.HeaderText = "Harga"
        Me.harga.MinimumWidth = 8
        Me.harga.Name = "harga"
        '
        'jumlah
        '
        Me.jumlah.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.jumlah.HeaderText = "Jumlah"
        Me.jumlah.MinimumWidth = 8
        Me.jumlah.Name = "jumlah"
        '
        'total
        '
        Me.total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.total.HeaderText = "Sub Total"
        Me.total.MinimumWidth = 8
        Me.total.Name = "total"
        '
        'penjualan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGray
        Me.ClientSize = New System.Drawing.Size(785, 328)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.tb_id_detail_jual)
        Me.Controls.Add(Me.tb_idjual)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cbb_metode_bayar)
        Me.Controls.Add(Me.tb_bayar)
        Me.Controls.Add(Me.lb_kembali)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lb_total)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btn_batal)
        Me.Controls.Add(Me.btn_simpan)
        Me.Controls.Add(Me.dgv_jual)
        Me.Controls.Add(Me.dtp_tanggal)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tb_customer_id)
        Me.Controls.Add(Me.tb_customer_nama)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tb_karyawan_id)
        Me.Controls.Add(Me.tb_karyawan_nama)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "penjualan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "penjualan"
        CType(Me.dgv_jual, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents tb_karyawan_nama As TextBox
    Friend WithEvents tb_karyawan_id As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents tb_customer_id As TextBox
    Friend WithEvents tb_customer_nama As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents dtp_tanggal As DateTimePicker
    Friend WithEvents dgv_jual As DataGridView
    Friend WithEvents btn_simpan As Button
    Friend WithEvents btn_batal As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents lb_total As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lb_kembali As Label
    Friend WithEvents tb_bayar As TextBox
    Friend WithEvents cbb_metode_bayar As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents tb_idjual As TextBox
    Friend WithEvents tb_id_detail_jual As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents id_barang As DataGridViewTextBoxColumn
    Friend WithEvents nama_barang As DataGridViewTextBoxColumn
    Friend WithEvents harga As DataGridViewTextBoxColumn
    Friend WithEvents jumlah As DataGridViewTextBoxColumn
    Friend WithEvents total As DataGridViewTextBoxColumn
End Class
