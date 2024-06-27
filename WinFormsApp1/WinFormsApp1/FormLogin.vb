Imports System.Data.Odbc

Public Class FormLogin
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txt1.Text = "" And txt2.Text = "" Then
            MsgBox("Maaf Username dan password blm diisi")
        Else
            Call koneksi()
            cmd = New OdbcCommand("select * from tbl_user where username='" & txt1.Text &
            "' and password= '" & txt2.Text & "'", conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows Then
                MsgBox("Login Sukses")
                Me.Hide()
                Call terbuka
                FormMenuUtama.Show()
            Else
                MsgBox("Maaf, username atau password yang anda masukan salah")
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Sub terbuka()
        FormMenuUtama.LoginToolStripMenuItem.Enabled = False
        FormMenuUtama.LogoutToolStripMenuItem.Enabled = True
        FormMenuUtama.DataGudangToolStripMenuItem1.Enabled = True
        FormMenuUtama.DataBarangToolStripMenuItem2.Enabled = True
    End Sub
End Class
