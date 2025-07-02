<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UbahPassword
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
        Me.tb_password_baru = New System.Windows.Forms.TextBox()
        Me.btn_simpan = New System.Windows.Forms.Button()
        Me.tb_password_sekarang = New System.Windows.Forms.TextBox()
        Me.tb_username_sekarang = New System.Windows.Forms.TextBox()
        Me.tb_konfirmasi_password_baru = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'tb_password_baru
        '
        Me.tb_password_baru.Location = New System.Drawing.Point(167, 217)
        Me.tb_password_baru.Name = "tb_password_baru"
        Me.tb_password_baru.Size = New System.Drawing.Size(226, 26)
        Me.tb_password_baru.TabIndex = 7
        '
        'btn_simpan
        '
        Me.btn_simpan.BackColor = System.Drawing.Color.DimGray
        Me.btn_simpan.FlatAppearance.BorderSize = 0
        Me.btn_simpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_simpan.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_simpan.ForeColor = System.Drawing.Color.White
        Me.btn_simpan.Location = New System.Drawing.Point(235, 344)
        Me.btn_simpan.Name = "btn_simpan"
        Me.btn_simpan.Size = New System.Drawing.Size(90, 40)
        Me.btn_simpan.TabIndex = 6
        Me.btn_simpan.Text = "Save"
        Me.btn_simpan.UseVisualStyleBackColor = False
        '
        'tb_password_sekarang
        '
        Me.tb_password_sekarang.Location = New System.Drawing.Point(167, 159)
        Me.tb_password_sekarang.Name = "tb_password_sekarang"
        Me.tb_password_sekarang.Size = New System.Drawing.Size(226, 26)
        Me.tb_password_sekarang.TabIndex = 5
        '
        'tb_username_sekarang
        '
        Me.tb_username_sekarang.Location = New System.Drawing.Point(167, 101)
        Me.tb_username_sekarang.Name = "tb_username_sekarang"
        Me.tb_username_sekarang.Size = New System.Drawing.Size(226, 26)
        Me.tb_username_sekarang.TabIndex = 4
        '
        'tb_konfirmasi_password_baru
        '
        Me.tb_konfirmasi_password_baru.Location = New System.Drawing.Point(167, 275)
        Me.tb_konfirmasi_password_baru.Name = "tb_konfirmasi_password_baru"
        Me.tb_konfirmasi_password_baru.Size = New System.Drawing.Size(226, 26)
        Me.tb_konfirmasi_password_baru.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(163, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(235, 29)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "UBAH PASSWORD"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(164, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 20)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Username"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(163, 136)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(122, 20)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Password Lama"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(164, 194)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(116, 20)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Password Baru"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(164, 252)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(194, 20)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Konfirmasi Password Baru"
        '
        'UbahPassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGray
        Me.ClientSize = New System.Drawing.Size(560, 450)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tb_konfirmasi_password_baru)
        Me.Controls.Add(Me.tb_password_baru)
        Me.Controls.Add(Me.btn_simpan)
        Me.Controls.Add(Me.tb_password_sekarang)
        Me.Controls.Add(Me.tb_username_sekarang)
        Me.Name = "UbahPassword"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "UbahPassword"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tb_password_baru As TextBox
    Friend WithEvents btn_simpan As Button
    Friend WithEvents tb_password_sekarang As TextBox
    Friend WithEvents tb_username_sekarang As TextBox
    Friend WithEvents tb_konfirmasi_password_baru As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class
