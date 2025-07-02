<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class laporan_laba_rugi
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lb_total_penjualan = New System.Windows.Forms.Label()
        Me.lb_total_pembelian = New System.Windows.Forms.Label()
        Me.lb_keuntungan_rugi = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(167, 100)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(174, 30)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "PENJUALAN"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(848, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(168, 30)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "PEMBELIAN"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(510, 320)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(158, 30)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "LABA/RUGI"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(140, 140)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Rp."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(822, 136)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(34, 20)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Rp."
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(481, 361)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(34, 20)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Rp."
        '
        'lb_total_penjualan
        '
        Me.lb_total_penjualan.AutoSize = True
        Me.lb_total_penjualan.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_total_penjualan.ForeColor = System.Drawing.Color.Green
        Me.lb_total_penjualan.Location = New System.Drawing.Point(193, 140)
        Me.lb_total_penjualan.Name = "lb_total_penjualan"
        Me.lb_total_penjualan.Size = New System.Drawing.Size(43, 46)
        Me.lb_total_penjualan.TabIndex = 6
        Me.lb_total_penjualan.Text = "0"
        '
        'lb_total_pembelian
        '
        Me.lb_total_pembelian.AutoSize = True
        Me.lb_total_pembelian.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_total_pembelian.ForeColor = System.Drawing.Color.Red
        Me.lb_total_pembelian.Location = New System.Drawing.Point(872, 140)
        Me.lb_total_pembelian.Name = "lb_total_pembelian"
        Me.lb_total_pembelian.Size = New System.Drawing.Size(43, 46)
        Me.lb_total_pembelian.TabIndex = 7
        Me.lb_total_pembelian.Text = "0"
        '
        'lb_keuntungan_rugi
        '
        Me.lb_keuntungan_rugi.AutoSize = True
        Me.lb_keuntungan_rugi.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_keuntungan_rugi.ForeColor = System.Drawing.Color.Black
        Me.lb_keuntungan_rugi.Location = New System.Drawing.Point(538, 373)
        Me.lb_keuntungan_rugi.Name = "lb_keuntungan_rugi"
        Me.lb_keuntungan_rugi.Size = New System.Drawing.Size(43, 46)
        Me.lb_keuntungan_rugi.TabIndex = 8
        Me.lb_keuntungan_rugi.Text = "0"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(441, 23)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(296, 30)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "LAPORAN LABA/RUGI"
        '
        'laporan_laba_rugi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGray
        Me.ClientSize = New System.Drawing.Size(1178, 505)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lb_keuntungan_rugi)
        Me.Controls.Add(Me.lb_total_pembelian)
        Me.Controls.Add(Me.lb_total_penjualan)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "laporan_laba_rugi"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "laporan_laba_rugi"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lb_total_penjualan As Label
    Friend WithEvents lb_total_pembelian As Label
    Friend WithEvents lb_keuntungan_rugi As Label
    Friend WithEvents Label7 As Label
End Class
