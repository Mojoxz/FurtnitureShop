Imports MySql.Data.MySqlClient
Module modul_koneksi
    Public conn As MySqlConnection
    Public cmd As MySqlCommand
    Public rd As MySqlDataReader
    Public da As MySqlDataAdapter
    Public ds As DataSet
    Public str As String
    Sub koneksi()
        Try
            str = "Server=localhost;user id=root;password=;database=uasproject"
            conn = New MySqlConnection(str)
            If conn.State = ConnectionState.Closed Then
                conn.Open()
                'MessageBox.Show("Koneksi Berhasil")
            End If
        Catch ex As Exception
            'MessageBox.Show("Koneksi gagal")
        Finally
            'conn.Close()
        End Try
    End Sub

End Module
