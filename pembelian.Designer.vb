<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class pembelian
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(pembelian))
        Me.tb_supplyer_id = New System.Windows.Forms.TextBox()
        Me.tb_supplyer_nama = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tb_karyawan_id = New System.Windows.Forms.TextBox()
        Me.tb_karyawan_nama = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtp_tanggal = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dgv_beli = New System.Windows.Forms.DataGridView()
        Me.btn_batal = New System.Windows.Forms.Button()
        Me.btn_simpan = New System.Windows.Forms.Button()
        Me.lb_total = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tb_idbeli = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tb_id_detail_beli = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.id_barang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nama_barang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.harga = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.jumlah = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sub_total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgv_beli, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tb_supplyer_id
        '
        Me.tb_supplyer_id.Location = New System.Drawing.Point(222, 287)
        Me.tb_supplyer_id.Margin = New System.Windows.Forms.Padding(2)
        Me.tb_supplyer_id.Name = "tb_supplyer_id"
        Me.tb_supplyer_id.Size = New System.Drawing.Size(133, 20)
        Me.tb_supplyer_id.TabIndex = 11
        '
        'tb_supplyer_nama
        '
        Me.tb_supplyer_nama.Location = New System.Drawing.Point(376, 46)
        Me.tb_supplyer_nama.Margin = New System.Windows.Forms.Padding(2)
        Me.tb_supplyer_nama.Name = "tb_supplyer_nama"
        Me.tb_supplyer_nama.Size = New System.Drawing.Size(133, 20)
        Me.tb_supplyer_nama.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(318, 49)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Supplyer"
        '
        'tb_karyawan_id
        '
        Me.tb_karyawan_id.Location = New System.Drawing.Point(222, 255)
        Me.tb_karyawan_id.Margin = New System.Windows.Forms.Padding(2)
        Me.tb_karyawan_id.Name = "tb_karyawan_id"
        Me.tb_karyawan_id.Size = New System.Drawing.Size(133, 20)
        Me.tb_karyawan_id.TabIndex = 8
        '
        'tb_karyawan_nama
        '
        Me.tb_karyawan_nama.Location = New System.Drawing.Point(376, 13)
        Me.tb_karyawan_nama.Margin = New System.Windows.Forms.Padding(2)
        Me.tb_karyawan_nama.Name = "tb_karyawan_nama"
        Me.tb_karyawan_nama.Size = New System.Drawing.Size(133, 20)
        Me.tb_karyawan_nama.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(318, 13)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Karyawan"
        '
        'dtp_tanggal
        '
        Me.dtp_tanggal.CustomFormat = "yyyy-MM-dd"
        Me.dtp_tanggal.Location = New System.Drawing.Point(634, 11)
        Me.dtp_tanggal.Margin = New System.Windows.Forms.Padding(2)
        Me.dtp_tanggal.Name = "dtp_tanggal"
        Me.dtp_tanggal.Size = New System.Drawing.Size(135, 20)
        Me.dtp_tanggal.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(578, 13)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Tanggal"
        '
        'dgv_beli
        '
        Me.dgv_beli.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.dgv_beli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_beli.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_barang, Me.nama_barang, Me.harga, Me.jumlah, Me.sub_total})
        Me.dgv_beli.Location = New System.Drawing.Point(10, 83)
        Me.dgv_beli.Margin = New System.Windows.Forms.Padding(2)
        Me.dgv_beli.Name = "dgv_beli"
        Me.dgv_beli.RowHeadersWidth = 62
        Me.dgv_beli.RowTemplate.Height = 28
        Me.dgv_beli.Size = New System.Drawing.Size(766, 162)
        Me.dgv_beli.TabIndex = 14
        '
        'btn_batal
        '
        Me.btn_batal.BackColor = System.Drawing.Color.DimGray
        Me.btn_batal.ForeColor = System.Drawing.Color.White
        Me.btn_batal.Location = New System.Drawing.Point(95, 274)
        Me.btn_batal.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_batal.Name = "btn_batal"
        Me.btn_batal.Size = New System.Drawing.Size(71, 30)
        Me.btn_batal.TabIndex = 16
        Me.btn_batal.Text = "Batal"
        Me.btn_batal.UseVisualStyleBackColor = False
        '
        'btn_simpan
        '
        Me.btn_simpan.BackColor = System.Drawing.Color.DimGray
        Me.btn_simpan.ForeColor = System.Drawing.Color.White
        Me.btn_simpan.Location = New System.Drawing.Point(11, 274)
        Me.btn_simpan.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_simpan.Name = "btn_simpan"
        Me.btn_simpan.Size = New System.Drawing.Size(71, 30)
        Me.btn_simpan.TabIndex = 15
        Me.btn_simpan.Text = "Simpan"
        Me.btn_simpan.UseVisualStyleBackColor = False
        '
        'lb_total
        '
        Me.lb_total.AutoSize = True
        Me.lb_total.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_total.ForeColor = System.Drawing.Color.Black
        Me.lb_total.Location = New System.Drawing.Point(531, 274)
        Me.lb_total.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lb_total.Name = "lb_total"
        Me.lb_total.Size = New System.Drawing.Size(19, 20)
        Me.lb_total.TabIndex = 18
        Me.lb_total.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(452, 274)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 20)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Total : Rp. "
        '
        'tb_idbeli
        '
        Me.tb_idbeli.Location = New System.Drawing.Point(634, 49)
        Me.tb_idbeli.Margin = New System.Windows.Forms.Padding(2)
        Me.tb_idbeli.Name = "tb_idbeli"
        Me.tb_idbeli.Size = New System.Drawing.Size(65, 20)
        Me.tb_idbeli.TabIndex = 19
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(583, 51)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 13)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Id Beli"
        '
        'tb_id_detail_beli
        '
        Me.tb_id_detail_beli.Location = New System.Drawing.Point(713, 249)
        Me.tb_id_detail_beli.Margin = New System.Windows.Forms.Padding(2)
        Me.tb_id_detail_beli.Name = "tb_id_detail_beli"
        Me.tb_id_detail_beli.Size = New System.Drawing.Size(65, 20)
        Me.tb_id_detail_beli.TabIndex = 21
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(66, 13)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(183, 60)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 23
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
        'sub_total
        '
        Me.sub_total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.sub_total.HeaderText = "Sub Total"
        Me.sub_total.MinimumWidth = 8
        Me.sub_total.Name = "sub_total"
        '
        'pembelian
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGray
        Me.ClientSize = New System.Drawing.Size(785, 328)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.tb_id_detail_beli)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tb_idbeli)
        Me.Controls.Add(Me.lb_total)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btn_batal)
        Me.Controls.Add(Me.btn_simpan)
        Me.Controls.Add(Me.dgv_beli)
        Me.Controls.Add(Me.dtp_tanggal)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tb_supplyer_id)
        Me.Controls.Add(Me.tb_supplyer_nama)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tb_karyawan_id)
        Me.Controls.Add(Me.tb_karyawan_nama)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "pembelian"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "pembelian"
        CType(Me.dgv_beli, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tb_supplyer_id As TextBox
    Friend WithEvents tb_supplyer_nama As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents tb_karyawan_id As TextBox
    Friend WithEvents tb_karyawan_nama As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents dtp_tanggal As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents dgv_beli As DataGridView
    Friend WithEvents btn_batal As Button
    Friend WithEvents btn_simpan As Button
    Friend WithEvents lb_total As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents tb_idbeli As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents tb_id_detail_beli As TextBox
    Friend WithEvents PictureBox1 As PictureBox

    Private Sub pembelian_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Friend WithEvents id_barang As DataGridViewTextBoxColumn
    Friend WithEvents nama_barang As DataGridViewTextBoxColumn
    Friend WithEvents harga As DataGridViewTextBoxColumn
    Friend WithEvents jumlah As DataGridViewTextBoxColumn
    Friend WithEvents sub_total As DataGridViewTextBoxColumn
End Class
