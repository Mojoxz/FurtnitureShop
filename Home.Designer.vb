<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Home
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Home))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MasterDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataUseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataBarangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataSupplyerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataCustomerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransaksiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DetaiPenjualanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DetailPembelianToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomOrderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanPenjualanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanPembelianToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanCustomOrderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanLabaRugiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UbahNamaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lb_datang = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.White
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MasterDataToolStripMenuItem, Me.TransaksiToolStripMenuItem, Me.LaporanToolStripMenuItem, Me.SettingToolStripMenuItem, Me.LogOutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(4, 1, 0, 1)
        Me.MenuStrip1.Size = New System.Drawing.Size(917, 25)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MasterDataToolStripMenuItem
        '
        Me.MasterDataToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DataUseToolStripMenuItem, Me.DataBarangToolStripMenuItem, Me.DataSupplyerToolStripMenuItem, Me.DataCustomerToolStripMenuItem})
        Me.MasterDataToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.MasterDataToolStripMenuItem.Name = "MasterDataToolStripMenuItem"
        Me.MasterDataToolStripMenuItem.Size = New System.Drawing.Size(97, 23)
        Me.MasterDataToolStripMenuItem.Text = "Master Data"
        '
        'DataUseToolStripMenuItem
        '
        Me.DataUseToolStripMenuItem.BackColor = System.Drawing.Color.Transparent
        Me.DataUseToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.DataUseToolStripMenuItem.Name = "DataUseToolStripMenuItem"
        Me.DataUseToolStripMenuItem.Size = New System.Drawing.Size(180, 24)
        Me.DataUseToolStripMenuItem.Text = "Data Karyawan"
        '
        'DataBarangToolStripMenuItem
        '
        Me.DataBarangToolStripMenuItem.BackColor = System.Drawing.Color.Transparent
        Me.DataBarangToolStripMenuItem.Name = "DataBarangToolStripMenuItem"
        Me.DataBarangToolStripMenuItem.Size = New System.Drawing.Size(180, 24)
        Me.DataBarangToolStripMenuItem.Text = "Data Barang"
        '
        'DataSupplyerToolStripMenuItem
        '
        Me.DataSupplyerToolStripMenuItem.BackColor = System.Drawing.Color.Transparent
        Me.DataSupplyerToolStripMenuItem.Name = "DataSupplyerToolStripMenuItem"
        Me.DataSupplyerToolStripMenuItem.Size = New System.Drawing.Size(180, 24)
        Me.DataSupplyerToolStripMenuItem.Text = "Data Supplyer"
        '
        'DataCustomerToolStripMenuItem
        '
        Me.DataCustomerToolStripMenuItem.BackColor = System.Drawing.Color.Transparent
        Me.DataCustomerToolStripMenuItem.Name = "DataCustomerToolStripMenuItem"
        Me.DataCustomerToolStripMenuItem.Size = New System.Drawing.Size(180, 24)
        Me.DataCustomerToolStripMenuItem.Text = "Data Customer"
        '
        'TransaksiToolStripMenuItem
        '
        Me.TransaksiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DetaiPenjualanToolStripMenuItem, Me.DetailPembelianToolStripMenuItem, Me.CustomOrderToolStripMenuItem})
        Me.TransaksiToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.TransaksiToolStripMenuItem.Name = "TransaksiToolStripMenuItem"
        Me.TransaksiToolStripMenuItem.Size = New System.Drawing.Size(76, 23)
        Me.TransaksiToolStripMenuItem.Text = "Transaksi"
        '
        'DetaiPenjualanToolStripMenuItem
        '
        Me.DetaiPenjualanToolStripMenuItem.Name = "DetaiPenjualanToolStripMenuItem"
        Me.DetaiPenjualanToolStripMenuItem.Size = New System.Drawing.Size(179, 24)
        Me.DetaiPenjualanToolStripMenuItem.Text = "Detail Penjualan"
        '
        'DetailPembelianToolStripMenuItem
        '
        Me.DetailPembelianToolStripMenuItem.Name = "DetailPembelianToolStripMenuItem"
        Me.DetailPembelianToolStripMenuItem.Size = New System.Drawing.Size(179, 24)
        Me.DetailPembelianToolStripMenuItem.Text = "Detail Pembelian"
        '
        'CustomOrderToolStripMenuItem
        '
        Me.CustomOrderToolStripMenuItem.Name = "CustomOrderToolStripMenuItem"
        Me.CustomOrderToolStripMenuItem.Size = New System.Drawing.Size(179, 24)
        Me.CustomOrderToolStripMenuItem.Text = "Custom Order"
        '
        'LaporanToolStripMenuItem
        '
        Me.LaporanToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LaporanPenjualanToolStripMenuItem, Me.LaporanPembelianToolStripMenuItem, Me.LaporanCustomOrderToolStripMenuItem, Me.LaporanLabaRugiToolStripMenuItem})
        Me.LaporanToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.LaporanToolStripMenuItem.Name = "LaporanToolStripMenuItem"
        Me.LaporanToolStripMenuItem.Size = New System.Drawing.Size(71, 23)
        Me.LaporanToolStripMenuItem.Text = "Laporan"
        '
        'LaporanPenjualanToolStripMenuItem
        '
        Me.LaporanPenjualanToolStripMenuItem.Name = "LaporanPenjualanToolStripMenuItem"
        Me.LaporanPenjualanToolStripMenuItem.Size = New System.Drawing.Size(220, 24)
        Me.LaporanPenjualanToolStripMenuItem.Text = "Laporan Penjualan"
        '
        'LaporanPembelianToolStripMenuItem
        '
        Me.LaporanPembelianToolStripMenuItem.Name = "LaporanPembelianToolStripMenuItem"
        Me.LaporanPembelianToolStripMenuItem.Size = New System.Drawing.Size(220, 24)
        Me.LaporanPembelianToolStripMenuItem.Text = "Laporan Pembelian"
        '
        'LaporanCustomOrderToolStripMenuItem
        '
        Me.LaporanCustomOrderToolStripMenuItem.Name = "LaporanCustomOrderToolStripMenuItem"
        Me.LaporanCustomOrderToolStripMenuItem.Size = New System.Drawing.Size(220, 24)
        Me.LaporanCustomOrderToolStripMenuItem.Text = "Laporan Custom Order"
        '
        'LaporanLabaRugiToolStripMenuItem
        '
        Me.LaporanLabaRugiToolStripMenuItem.Name = "LaporanLabaRugiToolStripMenuItem"
        Me.LaporanLabaRugiToolStripMenuItem.Size = New System.Drawing.Size(220, 24)
        Me.LaporanLabaRugiToolStripMenuItem.Text = "Laporan Laba/Rugi"
        '
        'SettingToolStripMenuItem
        '
        Me.SettingToolStripMenuItem.BackColor = System.Drawing.Color.Transparent
        Me.SettingToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UbahNamaToolStripMenuItem})
        Me.SettingToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.SettingToolStripMenuItem.Name = "SettingToolStripMenuItem"
        Me.SettingToolStripMenuItem.Size = New System.Drawing.Size(64, 23)
        Me.SettingToolStripMenuItem.Text = "Setting"
        '
        'UbahNamaToolStripMenuItem
        '
        Me.UbahNamaToolStripMenuItem.Name = "UbahNamaToolStripMenuItem"
        Me.UbahNamaToolStripMenuItem.Size = New System.Drawing.Size(109, 24)
        Me.UbahNamaToolStripMenuItem.Text = "Profil"
        '
        'LogOutToolStripMenuItem
        '
        Me.LogOutToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.LogOutToolStripMenuItem.Name = "LogOutToolStripMenuItem"
        Me.LogOutToolStripMenuItem.Size = New System.Drawing.Size(72, 23)
        Me.LogOutToolStripMenuItem.Text = "Log Out"
        '
        'lb_datang
        '
        Me.lb_datang.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lb_datang.AutoSize = True
        Me.lb_datang.BackColor = System.Drawing.Color.Transparent
        Me.lb_datang.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_datang.ForeColor = System.Drawing.Color.White
        Me.lb_datang.Location = New System.Drawing.Point(844, 65)
        Me.lb_datang.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lb_datang.Name = "lb_datang"
        Me.lb_datang.Size = New System.Drawing.Size(0, 39)
        Me.lb_datang.TabIndex = 1
        '
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(917, 546)
        Me.Controls.Add(Me.lb_datang)
        Me.Controls.Add(Me.MenuStrip1)
        Me.DoubleBuffered = True
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Home"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " "
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MasterDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataUseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataBarangToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataSupplyerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataCustomerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TransaksiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DetaiPenjualanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DetailPembelianToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CustomOrderToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LaporanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SettingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UbahNamaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LaporanPenjualanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LaporanPembelianToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LaporanCustomOrderToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lb_datang As Label
    Friend WithEvents LogOutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LaporanLabaRugiToolStripMenuItem As ToolStripMenuItem
End Class
