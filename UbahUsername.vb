Imports MySql.Data.MySqlClient

Public Class UbahUsername
    Public Property NamaUserSekarang As String
    Public Property PasswordSekarang As String

    Public Event UsernameDiubah(ByVal usernameBaru As String)

    Private Sub UbahUsername_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tb_username_sekarang.Text = NamaUserSekarang
        tb_username_sekarang.ReadOnly = True
        tb_password_sekarang.UseSystemPasswordChar = True
    End Sub

    Private Sub btn_simpan_Click(sender As Object, e As EventArgs) Handles btn_simpan.Click
        If tb_password_sekarang.Text = PasswordSekarang Then
            Try
                Call koneksi()
                str = "UPDATE tb_karyawan SET username_karyawan='" & tb_username_baru.Text & "' WHERE username_karyawan='" & NamaUserSekarang & "'"
                cmd = New MySqlCommand(str, conn)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Username berhasil diubah")
                RaiseEvent UsernameDiubah(tb_username_baru.Text)
                Me.Close()
            Catch ex As Exception
                MessageBox.Show("Terjadi kesalahan saat mengubah username: " & ex.Message)
            End Try
        Else
            MessageBox.Show("Password lama salah")
        End If
    End Sub
End Class
