<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class form_barang
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_barang))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.tb_id_bar = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tb_nama_bar = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tb_merk_bar = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tb_kar_bar = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tb_harga_bar = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cbb_jenis_bar = New System.Windows.Forms.ComboBox()
        Me.cbb_asal_bar = New System.Windows.Forms.ComboBox()
        Me.cbb_bahan_bar = New System.Windows.Forms.ComboBox()
        Me.cbb_status_bar = New System.Windows.Forms.ComboBox()
        Me.tb_stock_bar = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btn_hapus_bar = New System.Windows.Forms.Button()
        Me.btn_edit_bar = New System.Windows.Forms.Button()
        Me.btn_tambah_bar = New System.Windows.Forms.Button()
        Me.btn_clr_bar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(8, 147)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(598, 168)
        Me.DataGridView1.TabIndex = 0
        '
        'tb_id_bar
        '
        Me.tb_id_bar.Location = New System.Drawing.Point(58, 75)
        Me.tb_id_bar.Margin = New System.Windows.Forms.Padding(2)
        Me.tb_id_bar.Name = "tb_id_bar"
        Me.tb_id_bar.Size = New System.Drawing.Size(127, 20)
        Me.tb_id_bar.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(8, 73)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(20, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "ID"
        '
        'tb_nama_bar
        '
        Me.tb_nama_bar.Location = New System.Drawing.Point(58, 107)
        Me.tb_nama_bar.Margin = New System.Windows.Forms.Padding(2)
        Me.tb_nama_bar.Name = "tb_nama_bar"
        Me.tb_nama_bar.Size = New System.Drawing.Size(127, 20)
        Me.tb_nama_bar.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(8, 107)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Nama"
        '
        'tb_merk_bar
        '
        Me.tb_merk_bar.Location = New System.Drawing.Point(268, 2)
        Me.tb_merk_bar.Margin = New System.Windows.Forms.Padding(2)
        Me.tb_merk_bar.Name = "tb_merk_bar"
        Me.tb_merk_bar.Size = New System.Drawing.Size(127, 20)
        Me.tb_merk_bar.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(218, 6)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Merk"
        '
        'tb_kar_bar
        '
        Me.tb_kar_bar.Location = New System.Drawing.Point(268, 36)
        Me.tb_kar_bar.Margin = New System.Windows.Forms.Padding(2)
        Me.tb_kar_bar.Name = "tb_kar_bar"
        Me.tb_kar_bar.Size = New System.Drawing.Size(127, 20)
        Me.tb_kar_bar.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(209, 40)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Karakter"
        '
        'tb_harga_bar
        '
        Me.tb_harga_bar.Location = New System.Drawing.Point(268, 107)
        Me.tb_harga_bar.Margin = New System.Windows.Forms.Padding(2)
        Me.tb_harga_bar.Name = "tb_harga_bar"
        Me.tb_harga_bar.Size = New System.Drawing.Size(127, 20)
        Me.tb_harga_bar.TabIndex = 18
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(218, 109)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 13)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Harga"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(218, 77)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Bahan"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(430, 40)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(36, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Jenis"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(430, 6)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(31, 13)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Asal"
        '
        'cbb_jenis_bar
        '
        Me.cbb_jenis_bar.FormattingEnabled = True
        Me.cbb_jenis_bar.Items.AddRange(New Object() {"Kursi", "Meja", "Papan Tulis", "Springbed", "Asbes"})
        Me.cbb_jenis_bar.Location = New System.Drawing.Point(480, 40)
        Me.cbb_jenis_bar.Margin = New System.Windows.Forms.Padding(2)
        Me.cbb_jenis_bar.Name = "cbb_jenis_bar"
        Me.cbb_jenis_bar.Size = New System.Drawing.Size(127, 21)
        Me.cbb_jenis_bar.TabIndex = 19
        '
        'cbb_asal_bar
        '
        Me.cbb_asal_bar.FormattingEnabled = True
        Me.cbb_asal_bar.Items.AddRange(New Object() {"Indonesia", "Amerika", "Inggirs", "Kanada"})
        Me.cbb_asal_bar.Location = New System.Drawing.Point(480, 6)
        Me.cbb_asal_bar.Margin = New System.Windows.Forms.Padding(2)
        Me.cbb_asal_bar.Name = "cbb_asal_bar"
        Me.cbb_asal_bar.Size = New System.Drawing.Size(127, 21)
        Me.cbb_asal_bar.TabIndex = 20
        '
        'cbb_bahan_bar
        '
        Me.cbb_bahan_bar.FormattingEnabled = True
        Me.cbb_bahan_bar.Items.AddRange(New Object() {"Kayu", "Stainlees", "Besi", "Baja"})
        Me.cbb_bahan_bar.Location = New System.Drawing.Point(268, 73)
        Me.cbb_bahan_bar.Margin = New System.Windows.Forms.Padding(2)
        Me.cbb_bahan_bar.Name = "cbb_bahan_bar"
        Me.cbb_bahan_bar.Size = New System.Drawing.Size(127, 21)
        Me.cbb_bahan_bar.TabIndex = 21
        '
        'cbb_status_bar
        '
        Me.cbb_status_bar.FormattingEnabled = True
        Me.cbb_status_bar.Items.AddRange(New Object() {"Limited", "Ready Stock", "Sold Out", "On Restock"})
        Me.cbb_status_bar.Location = New System.Drawing.Point(480, 104)
        Me.cbb_status_bar.Margin = New System.Windows.Forms.Padding(2)
        Me.cbb_status_bar.Name = "cbb_status_bar"
        Me.cbb_status_bar.Size = New System.Drawing.Size(127, 21)
        Me.cbb_status_bar.TabIndex = 25
        '
        'tb_stock_bar
        '
        Me.tb_stock_bar.Location = New System.Drawing.Point(480, 74)
        Me.tb_stock_bar.Margin = New System.Windows.Forms.Padding(2)
        Me.tb_stock_bar.Name = "tb_stock_bar"
        Me.tb_stock_bar.Size = New System.Drawing.Size(127, 20)
        Me.tb_stock_bar.TabIndex = 24
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(430, 76)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(40, 13)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "Stock"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(430, 108)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(43, 13)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "Status"
        '
        'btn_hapus_bar
        '
        Me.btn_hapus_bar.BackColor = System.Drawing.Color.DimGray
        Me.btn_hapus_bar.ForeColor = System.Drawing.Color.White
        Me.btn_hapus_bar.Location = New System.Drawing.Point(453, 325)
        Me.btn_hapus_bar.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_hapus_bar.Name = "btn_hapus_bar"
        Me.btn_hapus_bar.Size = New System.Drawing.Size(69, 26)
        Me.btn_hapus_bar.TabIndex = 29
        Me.btn_hapus_bar.Text = "Hapus"
        Me.btn_hapus_bar.UseVisualStyleBackColor = False
        '
        'btn_edit_bar
        '
        Me.btn_edit_bar.BackColor = System.Drawing.Color.DimGray
        Me.btn_edit_bar.ForeColor = System.Drawing.Color.White
        Me.btn_edit_bar.Location = New System.Drawing.Point(333, 325)
        Me.btn_edit_bar.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_edit_bar.Name = "btn_edit_bar"
        Me.btn_edit_bar.Size = New System.Drawing.Size(69, 26)
        Me.btn_edit_bar.TabIndex = 28
        Me.btn_edit_bar.Text = "Edit"
        Me.btn_edit_bar.UseVisualStyleBackColor = False
        '
        'btn_tambah_bar
        '
        Me.btn_tambah_bar.BackColor = System.Drawing.Color.DimGray
        Me.btn_tambah_bar.ForeColor = System.Drawing.Color.White
        Me.btn_tambah_bar.Location = New System.Drawing.Point(212, 325)
        Me.btn_tambah_bar.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_tambah_bar.Name = "btn_tambah_bar"
        Me.btn_tambah_bar.Size = New System.Drawing.Size(69, 26)
        Me.btn_tambah_bar.TabIndex = 27
        Me.btn_tambah_bar.Text = "Tambah"
        Me.btn_tambah_bar.UseVisualStyleBackColor = False
        '
        'btn_clr_bar
        '
        Me.btn_clr_bar.BackColor = System.Drawing.Color.DimGray
        Me.btn_clr_bar.ForeColor = System.Drawing.Color.White
        Me.btn_clr_bar.Location = New System.Drawing.Point(91, 325)
        Me.btn_clr_bar.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_clr_bar.Name = "btn_clr_bar"
        Me.btn_clr_bar.Size = New System.Drawing.Size(69, 26)
        Me.btn_clr_bar.TabIndex = 26
        Me.btn_clr_bar.Text = "Clear"
        Me.btn_clr_bar.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(8, 8)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(183, 60)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 30
        Me.PictureBox1.TabStop = False
        '
        'form_barang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGray
        Me.ClientSize = New System.Drawing.Size(614, 366)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btn_hapus_bar)
        Me.Controls.Add(Me.btn_edit_bar)
        Me.Controls.Add(Me.btn_tambah_bar)
        Me.Controls.Add(Me.btn_clr_bar)
        Me.Controls.Add(Me.cbb_status_bar)
        Me.Controls.Add(Me.tb_stock_bar)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.cbb_bahan_bar)
        Me.Controls.Add(Me.cbb_asal_bar)
        Me.Controls.Add(Me.cbb_jenis_bar)
        Me.Controls.Add(Me.tb_harga_bar)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.tb_kar_bar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tb_merk_bar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tb_nama_bar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tb_id_bar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "form_barang"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "form_barang"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents tb_id_bar As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents tb_nama_bar As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents tb_merk_bar As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents tb_kar_bar As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents tb_harga_bar As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents cbb_jenis_bar As ComboBox
    Friend WithEvents cbb_asal_bar As ComboBox
    Friend WithEvents cbb_bahan_bar As ComboBox
    Friend WithEvents cbb_status_bar As ComboBox
    Friend WithEvents tb_stock_bar As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents btn_hapus_bar As Button
    Friend WithEvents btn_edit_bar As Button
    Friend WithEvents btn_tambah_bar As Button
    Friend WithEvents btn_clr_bar As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
