<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class form_karyawan
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_karyawan))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tb_id_kar = New System.Windows.Forms.TextBox()
        Me.tb_nama_kar = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tb_email_kar = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tb_alamat_kar = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tb_no_kar = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tb_usname_kar = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tb_pass_kar = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btn_clr = New System.Windows.Forms.Button()
        Me.btn_tambah = New System.Windows.Forms.Button()
        Me.btn_edit = New System.Windows.Forms.Button()
        Me.btn_hps = New System.Windows.Forms.Button()
        Me.cbb_gender_kar = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.Location = New System.Drawing.Point(8, 113)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridView1.Name = "DataGridView1"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(598, 192)
        Me.DataGridView1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(7, 53)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(20, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ID"
        '
        'tb_id_kar
        '
        Me.tb_id_kar.Location = New System.Drawing.Point(47, 53)
        Me.tb_id_kar.Margin = New System.Windows.Forms.Padding(2)
        Me.tb_id_kar.Name = "tb_id_kar"
        Me.tb_id_kar.Size = New System.Drawing.Size(127, 20)
        Me.tb_id_kar.TabIndex = 2
        '
        'tb_nama_kar
        '
        Me.tb_nama_kar.Location = New System.Drawing.Point(47, 79)
        Me.tb_nama_kar.Margin = New System.Windows.Forms.Padding(2)
        Me.tb_nama_kar.Name = "tb_nama_kar"
        Me.tb_nama_kar.Size = New System.Drawing.Size(127, 20)
        Me.tb_nama_kar.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(7, 79)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Nama"
        '
        'tb_email_kar
        '
        Me.tb_email_kar.Location = New System.Drawing.Point(271, 46)
        Me.tb_email_kar.Margin = New System.Windows.Forms.Padding(2)
        Me.tb_email_kar.Name = "tb_email_kar"
        Me.tb_email_kar.Size = New System.Drawing.Size(127, 20)
        Me.tb_email_kar.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(198, 49)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Email"
        '
        'tb_alamat_kar
        '
        Me.tb_alamat_kar.Location = New System.Drawing.Point(480, 14)
        Me.tb_alamat_kar.Margin = New System.Windows.Forms.Padding(2)
        Me.tb_alamat_kar.Name = "tb_alamat_kar"
        Me.tb_alamat_kar.Size = New System.Drawing.Size(127, 20)
        Me.tb_alamat_kar.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(433, 14)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Alamat"
        '
        'tb_no_kar
        '
        Me.tb_no_kar.Location = New System.Drawing.Point(271, 14)
        Me.tb_no_kar.Margin = New System.Windows.Forms.Padding(2)
        Me.tb_no_kar.Name = "tb_no_kar"
        Me.tb_no_kar.Size = New System.Drawing.Size(127, 20)
        Me.tb_no_kar.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(198, 17)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "No. Telp"
        '
        'tb_usname_kar
        '
        Me.tb_usname_kar.Location = New System.Drawing.Point(480, 47)
        Me.tb_usname_kar.Margin = New System.Windows.Forms.Padding(2)
        Me.tb_usname_kar.Name = "tb_usname_kar"
        Me.tb_usname_kar.Size = New System.Drawing.Size(127, 20)
        Me.tb_usname_kar.TabIndex = 14
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(413, 46)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "User Name"
        '
        'tb_pass_kar
        '
        Me.tb_pass_kar.Location = New System.Drawing.Point(480, 79)
        Me.tb_pass_kar.Margin = New System.Windows.Forms.Padding(2)
        Me.tb_pass_kar.Name = "tb_pass_kar"
        Me.tb_pass_kar.Size = New System.Drawing.Size(127, 20)
        Me.tb_pass_kar.TabIndex = 16
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(417, 83)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Password"
        '
        'btn_clr
        '
        Me.btn_clr.BackColor = System.Drawing.Color.DimGray
        Me.btn_clr.ForeColor = System.Drawing.Color.White
        Me.btn_clr.Location = New System.Drawing.Point(91, 323)
        Me.btn_clr.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_clr.Name = "btn_clr"
        Me.btn_clr.Size = New System.Drawing.Size(69, 26)
        Me.btn_clr.TabIndex = 17
        Me.btn_clr.Text = "Clear"
        Me.btn_clr.UseVisualStyleBackColor = False
        '
        'btn_tambah
        '
        Me.btn_tambah.BackColor = System.Drawing.Color.DimGray
        Me.btn_tambah.ForeColor = System.Drawing.Color.White
        Me.btn_tambah.Location = New System.Drawing.Point(212, 323)
        Me.btn_tambah.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_tambah.Name = "btn_tambah"
        Me.btn_tambah.Size = New System.Drawing.Size(69, 26)
        Me.btn_tambah.TabIndex = 18
        Me.btn_tambah.Text = "Tambah"
        Me.btn_tambah.UseVisualStyleBackColor = False
        '
        'btn_edit
        '
        Me.btn_edit.BackColor = System.Drawing.Color.DimGray
        Me.btn_edit.ForeColor = System.Drawing.Color.White
        Me.btn_edit.Location = New System.Drawing.Point(333, 323)
        Me.btn_edit.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(69, 26)
        Me.btn_edit.TabIndex = 19
        Me.btn_edit.Text = "Edit"
        Me.btn_edit.UseVisualStyleBackColor = False
        '
        'btn_hps
        '
        Me.btn_hps.BackColor = System.Drawing.Color.DimGray
        Me.btn_hps.ForeColor = System.Drawing.Color.White
        Me.btn_hps.Location = New System.Drawing.Point(453, 323)
        Me.btn_hps.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_hps.Name = "btn_hps"
        Me.btn_hps.Size = New System.Drawing.Size(69, 26)
        Me.btn_hps.TabIndex = 20
        Me.btn_hps.Text = "Hapus"
        Me.btn_hps.UseVisualStyleBackColor = False
        '
        'cbb_gender_kar
        '
        Me.cbb_gender_kar.FormattingEnabled = True
        Me.cbb_gender_kar.Items.AddRange(New Object() {"Laki-Laki", "Perempuan"})
        Me.cbb_gender_kar.Location = New System.Drawing.Point(291, 79)
        Me.cbb_gender_kar.Margin = New System.Windows.Forms.Padding(2)
        Me.cbb_gender_kar.Name = "cbb_gender_kar"
        Me.cbb_gender_kar.Size = New System.Drawing.Size(107, 21)
        Me.cbb_gender_kar.TabIndex = 21
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(197, 83)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(84, 13)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "Jenis Kelamin"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(8, 7)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(139, 42)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 23
        Me.PictureBox1.TabStop = False
        '
        'form_karyawan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGray
        Me.ClientSize = New System.Drawing.Size(614, 366)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cbb_gender_kar)
        Me.Controls.Add(Me.btn_hps)
        Me.Controls.Add(Me.btn_edit)
        Me.Controls.Add(Me.btn_tambah)
        Me.Controls.Add(Me.btn_clr)
        Me.Controls.Add(Me.tb_pass_kar)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.tb_usname_kar)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.tb_no_kar)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tb_alamat_kar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tb_email_kar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tb_nama_kar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tb_id_kar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "form_karyawan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "form_karyawan"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents tb_id_kar As TextBox
    Friend WithEvents tb_nama_kar As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents tb_email_kar As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents tb_alamat_kar As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents tb_no_kar As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents tb_usname_kar As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents tb_pass_kar As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents btn_clr As Button
    Friend WithEvents btn_tambah As Button
    Friend WithEvents btn_edit As Button
    Friend WithEvents btn_hps As Button
    Friend WithEvents cbb_gender_kar As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents PictureBox1 As PictureBox

   
End Class
