<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UbahUsername
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
        Me.tb_username_sekarang = New System.Windows.Forms.TextBox()
        Me.tb_password_sekarang = New System.Windows.Forms.TextBox()
        Me.btn_simpan = New System.Windows.Forms.Button()
        Me.tb_username_baru = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'tb_username_sekarang
        '
        Me.tb_username_sekarang.Location = New System.Drawing.Point(174, 127)
        Me.tb_username_sekarang.Name = "tb_username_sekarang"
        Me.tb_username_sekarang.Size = New System.Drawing.Size(226, 26)
        Me.tb_username_sekarang.TabIndex = 0
        '
        'tb_password_sekarang
        '
        Me.tb_password_sekarang.Location = New System.Drawing.Point(174, 210)
        Me.tb_password_sekarang.Name = "tb_password_sekarang"
        Me.tb_password_sekarang.Size = New System.Drawing.Size(226, 26)
        Me.tb_password_sekarang.TabIndex = 1
        '
        'btn_simpan
        '
        Me.btn_simpan.BackColor = System.Drawing.Color.DimGray
        Me.btn_simpan.FlatAppearance.BorderSize = 0
        Me.btn_simpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_simpan.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_simpan.ForeColor = System.Drawing.Color.White
        Me.btn_simpan.Location = New System.Drawing.Point(244, 380)
        Me.btn_simpan.Name = "btn_simpan"
        Me.btn_simpan.Size = New System.Drawing.Size(86, 36)
        Me.btn_simpan.TabIndex = 2
        Me.btn_simpan.Text = "Save"
        Me.btn_simpan.UseVisualStyleBackColor = False
        '
        'tb_username_baru
        '
        Me.tb_username_baru.Location = New System.Drawing.Point(174, 282)
        Me.tb_username_baru.Name = "tb_username_baru"
        Me.tb_username_baru.Size = New System.Drawing.Size(226, 26)
        Me.tb_username_baru.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(171, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(232, 29)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "UBAH USERNAME"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(174, 102)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 20)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Username"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(174, 185)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 20)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Password"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(174, 258)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(121, 20)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Username Baru"
        '
        'UbahUsername
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGray
        Me.ClientSize = New System.Drawing.Size(575, 527)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tb_username_baru)
        Me.Controls.Add(Me.btn_simpan)
        Me.Controls.Add(Me.tb_password_sekarang)
        Me.Controls.Add(Me.tb_username_sekarang)
        Me.Name = "UbahUsername"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "UbahUsername"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tb_username_sekarang As TextBox
    Friend WithEvents tb_password_sekarang As TextBox
    Friend WithEvents btn_simpan As Button
    Friend WithEvents tb_username_baru As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
