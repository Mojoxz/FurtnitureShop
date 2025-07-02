<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_customer
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_customer))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cbb_gender_cust = New System.Windows.Forms.ComboBox()
        Me.tb_no_cust = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tb_alamat_cust = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tb_email_cust = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tb_nama_cust = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tb_id_cust = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_hps_cus = New System.Windows.Forms.Button()
        Me.btn_edit_cus = New System.Windows.Forms.Button()
        Me.btn_tambah_cus = New System.Windows.Forms.Button()
        Me.btn_clr_cus = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(13, 187)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(997, 277)
        Me.DataGridView1.TabIndex = 0
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.DarkGray
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(690, 129)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(119, 20)
        Me.Label8.TabIndex = 34
        Me.Label8.Text = "Jenis Kelamin"
        '
        'cbb_gender_cust
        '
        Me.cbb_gender_cust.FormattingEnabled = True
        Me.cbb_gender_cust.Items.AddRange(New Object() {"Laki - Laki", "Perempuan"})
        Me.cbb_gender_cust.Location = New System.Drawing.Point(822, 127)
        Me.cbb_gender_cust.Name = "cbb_gender_cust"
        Me.cbb_gender_cust.Size = New System.Drawing.Size(152, 28)
        Me.cbb_gender_cust.TabIndex = 33
        '
        'tb_no_cust
        '
        Me.tb_no_cust.Location = New System.Drawing.Point(768, 77)
        Me.tb_no_cust.Name = "tb_no_cust"
        Me.tb_no_cust.Size = New System.Drawing.Size(210, 26)
        Me.tb_no_cust.TabIndex = 32
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.DarkGray
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(690, 77)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 20)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "No. Telp"
        '
        'tb_alamat_cust
        '
        Me.tb_alamat_cust.Location = New System.Drawing.Point(768, 20)
        Me.tb_alamat_cust.Name = "tb_alamat_cust"
        Me.tb_alamat_cust.Size = New System.Drawing.Size(210, 26)
        Me.tb_alamat_cust.TabIndex = 30
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.DarkGray
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(690, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 20)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "Alamat"
        '
        'tb_email_cust
        '
        Me.tb_email_cust.Location = New System.Drawing.Point(414, 129)
        Me.tb_email_cust.Name = "tb_email_cust"
        Me.tb_email_cust.Size = New System.Drawing.Size(210, 26)
        Me.tb_email_cust.TabIndex = 28
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.DarkGray
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(349, 129)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 20)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Email"
        '
        'tb_nama_cust
        '
        Me.tb_nama_cust.Location = New System.Drawing.Point(414, 77)
        Me.tb_nama_cust.Name = "tb_nama_cust"
        Me.tb_nama_cust.Size = New System.Drawing.Size(210, 26)
        Me.tb_nama_cust.TabIndex = 26
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.DarkGray
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(349, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 20)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Nama"
        '
        'tb_id_cust
        '
        Me.tb_id_cust.Location = New System.Drawing.Point(414, 20)
        Me.tb_id_cust.Name = "tb_id_cust"
        Me.tb_id_cust.Size = New System.Drawing.Size(210, 26)
        Me.tb_id_cust.TabIndex = 24
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.DarkGray
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(349, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 20)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "ID"
        '
        'btn_hps_cus
        '
        Me.btn_hps_cus.BackColor = System.Drawing.Color.DimGray
        Me.btn_hps_cus.ForeColor = System.Drawing.Color.White
        Me.btn_hps_cus.Location = New System.Drawing.Point(756, 490)
        Me.btn_hps_cus.Name = "btn_hps_cus"
        Me.btn_hps_cus.Size = New System.Drawing.Size(114, 40)
        Me.btn_hps_cus.TabIndex = 38
        Me.btn_hps_cus.Text = "Hapus"
        Me.btn_hps_cus.UseVisualStyleBackColor = False
        '
        'btn_edit_cus
        '
        Me.btn_edit_cus.BackColor = System.Drawing.Color.DimGray
        Me.btn_edit_cus.ForeColor = System.Drawing.Color.White
        Me.btn_edit_cus.Location = New System.Drawing.Point(554, 490)
        Me.btn_edit_cus.Name = "btn_edit_cus"
        Me.btn_edit_cus.Size = New System.Drawing.Size(114, 40)
        Me.btn_edit_cus.TabIndex = 37
        Me.btn_edit_cus.Text = "Edit"
        Me.btn_edit_cus.UseVisualStyleBackColor = False
        '
        'btn_tambah_cus
        '
        Me.btn_tambah_cus.BackColor = System.Drawing.Color.DimGray
        Me.btn_tambah_cus.ForeColor = System.Drawing.Color.White
        Me.btn_tambah_cus.Location = New System.Drawing.Point(353, 490)
        Me.btn_tambah_cus.Name = "btn_tambah_cus"
        Me.btn_tambah_cus.Size = New System.Drawing.Size(114, 40)
        Me.btn_tambah_cus.TabIndex = 36
        Me.btn_tambah_cus.Text = "Tambah"
        Me.btn_tambah_cus.UseVisualStyleBackColor = False
        '
        'btn_clr_cus
        '
        Me.btn_clr_cus.BackColor = System.Drawing.Color.DimGray
        Me.btn_clr_cus.ForeColor = System.Drawing.Color.White
        Me.btn_clr_cus.Location = New System.Drawing.Point(152, 490)
        Me.btn_clr_cus.Name = "btn_clr_cus"
        Me.btn_clr_cus.Size = New System.Drawing.Size(114, 40)
        Me.btn_clr_cus.TabIndex = 35
        Me.btn_clr_cus.Text = "Clear"
        Me.btn_clr_cus.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(13, 57)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(306, 92)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 39
        Me.PictureBox1.TabStop = False
        '
        'form_customer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGray
        Me.ClientSize = New System.Drawing.Size(1023, 563)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btn_hps_cus)
        Me.Controls.Add(Me.btn_edit_cus)
        Me.Controls.Add(Me.btn_tambah_cus)
        Me.Controls.Add(Me.btn_clr_cus)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cbb_gender_cust)
        Me.Controls.Add(Me.tb_no_cust)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tb_alamat_cust)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tb_email_cust)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tb_nama_cust)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tb_id_cust)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.Name = "form_customer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "form_customer"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label8 As Label
    Friend WithEvents cbb_gender_cust As ComboBox
    Friend WithEvents tb_no_cust As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents tb_alamat_cust As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents tb_email_cust As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents tb_nama_cust As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents tb_id_cust As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_hps_cus As Button
    Friend WithEvents btn_edit_cus As Button
    Friend WithEvents btn_tambah_cus As Button
    Friend WithEvents btn_clr_cus As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
