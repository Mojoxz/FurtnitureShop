Imports MySql.Data.MySqlClient
Public Class profil
    Public Property NamaUser As String
    Public Property passkar As String
    Public Property Password As String



    Private Sub profil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tb_username_profil.Text = NamaUser
        tb_username_profil.ReadOnly = True
        tb_pasword_profil.UseSystemPasswordChar = True
        tb_pasword_profil.Text = passkar
        tb_pasword_profil.ReadOnly = True
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim formUbahUsername As New UbahUsername()
        formUbahUsername.NamaUserSekarang = NamaUser
        formUbahUsername.PasswordSekarang = passkar
        AddHandler formUbahUsername.UsernameDiubah, AddressOf OnUsernameDiubah
        formUbahUsername.ShowDialog()
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Dim formUbahPassword As New UbahPassword()
        formUbahPassword.NamaUserSekarang = NamaUser
        formUbahPassword.PasswordSekarang = passkar
        AddHandler formUbahPassword.PasswordDiubah, AddressOf OnPasswordDiubah
        formUbahPassword.ShowDialog()
    End Sub

    Sub OnUsernameDiubah(ByVal usernameBaru As String)
        NamaUser = usernameBaru
        tb_username_profil.Text = usernameBaru
    End Sub
    Sub OnPasswordDiubah(ByVal passwordBaru As String)
        Password = passwordBaru
        tb_username_profil.Text = passwordBaru
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class