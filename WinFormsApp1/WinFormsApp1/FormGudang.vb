Imports System.Data.Odbc
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class FormGudang
    Private Sub FormGudang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call kondisiawal()
    End Sub
    Sub kondisiawal()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""

        TextBox1.Enabled = False
        TextBox2.Enabled = False
        TextBox3.Enabled = False

        Button1.Enabled = True
        Button2.Enabled = True
        Button3.Enabled = True
        Button4.Enabled = True


        Button1.Text = "INPUT"
        Button2.Text = "EDIT"
        Button3.Text = "HAPUS"
        Button4.Text = "KELUAR"

        Call koneksi()
        da = New OdbcDataAdapter("select * from tbl_gudang", conn)
        ds = New DataSet
        da.Fill(ds, "tbl_gudang")
        DGV.DataSource = ds.Tables("tbl_gudang")
        DGV.ReadOnly = True
    End Sub
    Sub isi()
        TextBox1.Enabled = True
        TextBox2.Enabled = True
        TextBox3.Enabled = True
    End Sub

    Sub filterGrid()
        ds.Tables("tbl_gudang").DefaultView.RowFilter = "nama_gudang LIKE '%" & tCari.Text.Replace("'", "") & "%' "
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Button1.Text = "INPUT" Then
            Button1.Text = "SIMPAN"
            Button2.Enabled = False
            Button3.Enabled = False
            Button4.Text = "CANCEL"
            Call isi()
        Else
            If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Then
                MsgBox("Silahkan isi semua fild")
            Else
                Call koneksi()
                Dim InputData As String = "insert into tbl_gudang value('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "')"
                cmd = New OdbcCommand(InputData, conn)
                cmd.ExecuteNonQuery()
                MsgBox("Input data berhasil")
                Call kondisiawal()
            End If
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Button2.Text = "EDIT" Then
            Button2.Text = "SIMPAN"
            Button1.Enabled = False
            Button3.Enabled = False
            Button4.Text = "CANCEL"
            Call isi()
        Else
            If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Then
                MsgBox("Silahkan isi semua fild")
            Else
                Call koneksi()
                Dim Updatedata As String = "UPDATE tbl_gudang SET nama_gudang='" & TextBox2.Text & "', alamat='" & TextBox3.Text & "' WHERE kode_gudang='" & TextBox1.Text & "'"
                cmd = New OdbcCommand(Updatedata, conn)
                cmd.ExecuteNonQuery()
                MsgBox("Update data berhasil")
                Call kondisiawal()
            End If
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If Button3.Text = "HAPUS" Then
            Button3.Text = "DELETE"
            Button1.Enabled = False
            Button2.Enabled = False
            Button4.Text = "CANCEL"
            Call isi()
        Else
            If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Then
                MsgBox("Silahkan isi semua fild")
            Else
                Call koneksi()
                Dim Hapusdata As String = "DELETE from tbl_gudang where kode_gudang='" & TextBox1.Text & "'"
                cmd = New OdbcCommand(Hapusdata, conn)
                cmd.ExecuteNonQuery()
                MsgBox("Delete data berhasil")
                Call kondisiawal()
            End If
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If Button4.Text = "KELUAR" Then
            Me.Close()
        Else
            Call kondisiawal()
        End If
    End Sub

    Private Sub tCari_TextChanged(sender As Object, e As EventArgs) Handles tCari.TextChanged
        Call filterGrid()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Call koneksi()
        cmd = New OdbcCommand("select * from tbl_gudang where kode_gudang =?", conn)
        cmd.Parameters.AddWithValue("kode_gudang", TextBox1.Text)
        Dim dr As OdbcDataReader
        dr = cmd.ExecuteReader

        If dr.Read Then
            TextBox2.Text = dr("nama_gudang").ToString
            TextBox3.Text = dr("alamat").ToString
        Else
            TextBox2.Text = ""
            TextBox3.Text = ""
        End If
    End Sub

End Class