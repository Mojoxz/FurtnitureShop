<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_supplyer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_supplyer))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.tb_email_sup = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tb_nama_sup = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tb_id_sup = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tb_alamat_sup = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btn_hps_sup = New System.Windows.Forms.Button()
        Me.btn_edit_sup = New System.Windows.Forms.Button()
        Me.btn_tambah_sup = New System.Windows.Forms.Button()
        Me.btn_clr_sup = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 158)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(897, 318)
        Me.DataGridView1.TabIndex = 0
        '
        'tb_email_sup
        '
        Me.tb_email_sup.Location = New System.Drawing.Point(720, 18)
        Me.tb_email_sup.Name = "tb_email_sup"
        Me.tb_email_sup.Size = New System.Drawing.Size(189, 26)
        Me.tb_email_sup.TabIndex = 16
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(645, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 20)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Email"
        '
        'tb_nama_sup
        '
        Me.tb_nama_sup.Location = New System.Drawing.Point(413, 76)
        Me.tb_nama_sup.Name = "tb_nama_sup"
        Me.tb_nama_sup.Size = New System.Drawing.Size(189, 26)
        Me.tb_nama_sup.TabIndex = 14
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(338, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 20)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Nama"
        '
        'tb_id_sup
        '
        Me.tb_id_sup.Location = New System.Drawing.Point(413, 18)
        Me.tb_id_sup.Name = "tb_id_sup"
        Me.tb_id_sup.Size = New System.Drawing.Size(189, 26)
        Me.tb_id_sup.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(338, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 20)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "ID"
        '
        'tb_alamat_sup
        '
        Me.tb_alamat_sup.Location = New System.Drawing.Point(720, 76)
        Me.tb_alamat_sup.Name = "tb_alamat_sup"
        Me.tb_alamat_sup.Size = New System.Drawing.Size(189, 26)
        Me.tb_alamat_sup.TabIndex = 18
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(645, 76)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 20)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Alamat"
        '
        'btn_hps_sup
        '
        Me.btn_hps_sup.BackColor = System.Drawing.Color.DimGray
        Me.btn_hps_sup.ForeColor = System.Drawing.Color.White
        Me.btn_hps_sup.Location = New System.Drawing.Point(680, 495)
        Me.btn_hps_sup.Name = "btn_hps_sup"
        Me.btn_hps_sup.Size = New System.Drawing.Size(103, 40)
        Me.btn_hps_sup.TabIndex = 33
        Me.btn_hps_sup.Text = "Hapus"
        Me.btn_hps_sup.UseVisualStyleBackColor = False
        '
        'btn_edit_sup
        '
        Me.btn_edit_sup.BackColor = System.Drawing.Color.DimGray
        Me.btn_edit_sup.ForeColor = System.Drawing.Color.White
        Me.btn_edit_sup.Location = New System.Drawing.Point(499, 495)
        Me.btn_edit_sup.Name = "btn_edit_sup"
        Me.btn_edit_sup.Size = New System.Drawing.Size(103, 40)
        Me.btn_edit_sup.TabIndex = 32
        Me.btn_edit_sup.Text = "Edit"
        Me.btn_edit_sup.UseVisualStyleBackColor = False
        '
        'btn_tambah_sup
        '
        Me.btn_tambah_sup.BackColor = System.Drawing.Color.DimGray
        Me.btn_tambah_sup.ForeColor = System.Drawing.Color.White
        Me.btn_tambah_sup.Location = New System.Drawing.Point(318, 495)
        Me.btn_tambah_sup.Name = "btn_tambah_sup"
        Me.btn_tambah_sup.Size = New System.Drawing.Size(103, 40)
        Me.btn_tambah_sup.TabIndex = 31
        Me.btn_tambah_sup.Text = "Tambah"
        Me.btn_tambah_sup.UseVisualStyleBackColor = False
        '
        'btn_clr_sup
        '
        Me.btn_clr_sup.BackColor = System.Drawing.Color.DimGray
        Me.btn_clr_sup.ForeColor = System.Drawing.Color.White
        Me.btn_clr_sup.Location = New System.Drawing.Point(137, 495)
        Me.btn_clr_sup.Name = "btn_clr_sup"
        Me.btn_clr_sup.Size = New System.Drawing.Size(103, 40)
        Me.btn_clr_sup.TabIndex = 30
        Me.btn_clr_sup.Text = "Clear"
        Me.btn_clr_sup.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(26, 24)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(275, 92)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 34
        Me.PictureBox1.TabStop = False
        '
        'form_supplyer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGray
        Me.ClientSize = New System.Drawing.Size(921, 563)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btn_hps_sup)
        Me.Controls.Add(Me.btn_edit_sup)
        Me.Controls.Add(Me.btn_tambah_sup)
        Me.Controls.Add(Me.btn_clr_sup)
        Me.Controls.Add(Me.tb_alamat_sup)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tb_email_sup)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tb_nama_sup)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tb_id_sup)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "form_supplyer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "form_supplyer"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents tb_email_sup As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents tb_nama_sup As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents tb_id_sup As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents tb_alamat_sup As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btn_hps_sup As Button
    Friend WithEvents btn_edit_sup As Button
    Friend WithEvents btn_tambah_sup As Button
    Friend WithEvents btn_clr_sup As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
