Imports MySql.Data.MySqlClient

Public Class UbahPassword
    Public Property NamaUserSekarang As String
    Public Property PasswordSekarang As String
    Public Event PasswordDiubah(ByVal usernameBaru As String)

    Private Sub UbahPassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tb_username_sekarang.Text = NamaUserSekarang
        tb_username_sekarang.ReadOnly = True
        tb_password_sekarang.UseSystemPasswordChar = False
        tb_password_baru.UseSystemPasswordChar = False
        tb_konfirmasi_password_baru.UseSystemPasswordChar = False
    End Sub

    Private Sub btn_simpan_Click(sender As Object, e As EventArgs) Handles btn_simpan.Click
        If tb_password_sekarang.Text = PasswordSekarang Then
            If tb_password_baru.Text = tb_konfirmasi_password_baru.Text Then
                Try
                    Call koneksi()
                    str = "UPDATE tb_karyawan SET password_karyawan='" & tb_password_baru.Text & "' WHERE username_karyawan='" & NamaUserSekarang & "'"
                    cmd = New MySqlCommand(str, conn)
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Password berhasil diubah")
                    RaiseEvent PasswordDiubah(tb_password_baru.Text)
                    Me.Close()
                Catch ex As Exception
                    MessageBox.Show("Terjadi kesalahan saat mengubah password: " & ex.Message)
                End Try
            Else
                MessageBox.Show("Konfirmasi password baru tidak cocok")
            End If
        Else
            MessageBox.Show("Password lama salah")
        End If
    End Sub


End Class
