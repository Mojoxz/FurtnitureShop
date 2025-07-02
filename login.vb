Imports MySql.Data.MySqlClient

Public Class login
    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Me.Close()
    End Sub
    Private Sub btn_login_Click_1(sender As Object, e As EventArgs) Handles btn_login.Click
        Try
            Call koneksi()
            str = "SELECT * FROM tb_karyawan WHERE username_karyawan='" & tb_usname.Text & "' AND password_karyawan='" & tb_pass.Text & "'"
            cmd = New MySqlCommand(str, conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows Then
                Dim nama = rd.Item("nama_karyawan").ToString()
                Dim usname = rd.Item("username_karyawan").ToString()
                Dim pass = rd.Item("password_karyawan").ToString()
                MessageBox.Show("Login berhasil, Selamat Datang " & nama)

                Dim homeForm As New Home()
                homeForm.NamaKaryawan = nama

                homeForm.ProfilUser = usname
                homeForm.ProfilPass = pass
                homeForm.Show()
                Me.Hide()
            Else
                MessageBox.Show("Login gagal")
            End If
        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan koneksi" & ex.Message)
        End Try
    End Sub
    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tb_pass.UseSystemPasswordChar = True
    End Sub
End Class
