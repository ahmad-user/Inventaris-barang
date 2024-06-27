Imports System.Data.Odbc
Imports System.Drawing.Printing

Public Class FormMenuUtama
    Dim WithEvents PD As New PrintDocument
    Dim WithEvents PD1 As New PrintDocument
    Dim PPD As New PrintPreviewDialog

    Private Sub DataGudangToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DataGudangToolStripMenuItem1.Click
        FormGudang.MdiParent = Me
        FormGudang.Show()
    End Sub

    Private Sub DataBarangToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles DataBarangToolStripMenuItem2.Click
        FormBarang.MdiParent = Me
        FormBarang.Show()
    End Sub

    Private Sub FormMenuUtama_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call terkunci()
        sbtanggal.Text = "[" & Format(Now, "dddd") & " " & Format(Now, "dd MMM yyyy") & "]"
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub LoginToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoginToolStripMenuItem.Click
        FormLogin.MdiParent = Me
        FormLogin.Show()
    End Sub

    Sub terkunci()
        LoginToolStripMenuItem.Enabled = True
        LogoutToolStripMenuItem.Enabled = False
        DataGudangToolStripMenuItem1.Enabled = False
        DataBarangToolStripMenuItem2.Enabled = False

    End Sub

    Private Sub LaporanGudangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LaporanGudangToolStripMenuItem.Click
        PPD.Document = PD
        PPD.ShowDialog()
    End Sub

    Private Sub PD_BeginPrint(sender As Object, e As PrintEventArgs) Handles PD.BeginPrint
        Dim pagesetup As New PageSettings
        pagesetup.PaperSize = New PaperSize("Custom", 800, 1000)
        PD.DefaultPageSettings = pagesetup
    End Sub

    Private Sub PD_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PD.PrintPage
        koneksi()
        Dim f10 As New Font("Times New Roman", 10, FontStyle.Regular)
        Dim f10b As New Font("Times Roman Now", 10, FontStyle.Bold)
        Dim f14 As New Font("Times Roman Now", 14, FontStyle.Bold)

        Dim leftmargin As Integer = 100
        Dim centermargin As Integer = 400
        Dim rightmargin As Integer = 680

        Dim kiri As New StringFormat
        Dim tengah As New StringFormat
        Dim kanan As New StringFormat

        kiri.Alignment = StringAlignment.Center
        tengah.Alignment = StringAlignment.Center
        kanan.Alignment = StringAlignment.Center

        Dim garis As String
        garis = "-----------------------------------------------------------------------------------------------------------"

        e.Graphics.DrawString("Data Gudang", f14, Brushes.Black, centermargin, 30, tengah)

        Dim yPosition As Integer = 130

        e.Graphics.DrawString("Kode Gudang", f14, Brushes.Black, leftmargin, 100, kiri)
        e.Graphics.DrawString("Nama Gudang", f14, Brushes.Black, centermargin, 100, tengah)
        e.Graphics.DrawString("Alamat Gudang", f14, Brushes.Black, rightmargin, 100, kanan)

        Dim query As String = "SELECT * from tbl_gudang"
        cmd = New OdbcCommand(query, conn)

        Try
            rd = cmd.ExecuteReader()


            While rd.Read()
                Dim column1 As String = rd("kode_gudang").ToString()
                Dim column2 As String = rd("nama_gudang").ToString()
                Dim column3 As String = rd("alamat").ToString()

                e.Graphics.DrawString(column1, f10, Brushes.Black, leftmargin, yPosition, kiri)
                e.Graphics.DrawString(column2, f10, Brushes.Black, centermargin, yPosition, tengah)
                e.Graphics.DrawString(column3, f10, Brushes.Black, rightmargin, yPosition, kanan)

                yPosition += 20
                e.Graphics.DrawString(garis, f14, Brushes.Black, 20, 75)
            End While
        Finally
            rd.Close()
            conn.Close()
        End Try
    End Sub

    Private Sub LaporanBarangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LaporanBarangToolStripMenuItem.Click
        PPD.Document = PD1
        PPD.ShowDialog()
    End Sub
    Private Sub PrintDocument1_BeginPrint(sender As Object, e As PrintEventArgs) Handles PrintDocument1.BeginPrint
        Dim pagesetup As New PageSettings
        pagesetup.PaperSize = New PaperSize("Custom", 800, 1000)
        PD1.DefaultPageSettings = pagesetup
    End Sub

    Private Sub PD1_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PD1.PrintPage
        koneksi()
        Dim f10 As New Font("Times New Roman", 10, FontStyle.Regular)
        Dim f10b As New Font("Times New Roman", 10, FontStyle.Bold)
        Dim f14 As New Font("Times New Roman", 14, FontStyle.Bold)

        Dim baris1 As Integer = 70
        Dim baris2 As Integer = 200
        Dim baris3 As Integer = 340
        Dim baris4 As Integer = 480
        Dim baris5 As Integer = 640
        Dim baris6 As Integer = 770

        Dim satu As New StringFormat
        Dim dua As New StringFormat
        Dim tiga As New StringFormat
        Dim empat As New StringFormat
        Dim lima As New StringFormat
        Dim enam As New StringFormat

        satu.Alignment = StringAlignment.Center
        dua.Alignment = StringAlignment.Center
        tiga.Alignment = StringAlignment.Center
        empat.Alignment = StringAlignment.Center
        lima.Alignment = StringAlignment.Center
        enam.Alignment = StringAlignment.Center

        Dim garis As String
        garis = "----------------------------------------------------------------------------------------------------------------------------"

        e.Graphics.DrawString("Data Barang", f14, Brushes.Black, baris3 + 70, 30, empat)

        Dim yPosition As Integer = 130

        e.Graphics.DrawString("Kode Barang", f14, Brushes.Black, baris1, 100, satu)
        e.Graphics.DrawString("Nama Barang", f14, Brushes.Black, baris2, 100, dua)
        e.Graphics.DrawString("Harga Barang", f14, Brushes.Black, baris3, 100, tiga)
        e.Graphics.DrawString("Jumlah Barang", f14, Brushes.Black, baris4, 100, empat)
        e.Graphics.DrawString("Expired Barang", f14, Brushes.Black, baris5, 100, lima)
        e.Graphics.DrawString("ID Gudang", f14, Brushes.Black, baris6, 100, enam)

        Dim query As String = "SELECT * from tbl_barang"
        cmd = New OdbcCommand(query, conn)

        Try
            rd = cmd.ExecuteReader()


            While rd.Read()
                Dim column1 As String = rd("kode_barang").ToString()
                Dim column2 As String = rd("nama_barang").ToString()
                Dim column3 As String = rd("harga_barang").ToString()
                Dim column4 As String = rd("jumlah_barang").ToString()
                Dim column5 As String = rd("expired_barang").ToString()
                Dim column6 As String = rd("gudang_id").ToString()

                e.Graphics.DrawString(column1, f10, Brushes.Black, baris1, yPosition, satu)
                e.Graphics.DrawString(column2, f10, Brushes.Black, baris2, yPosition, dua)
                e.Graphics.DrawString(column3, f10, Brushes.Black, baris3, yPosition, tiga)
                e.Graphics.DrawString(column4, f10, Brushes.Black, baris4, yPosition, empat)
                e.Graphics.DrawString(column5, f10, Brushes.Black, baris5, yPosition, lima)
                e.Graphics.DrawString(column6, f10, Brushes.Black, baris6, yPosition, enam)

                yPosition += 20
                e.Graphics.DrawString(garis, f14, Brushes.Black, 0, 75)
            End While
        Finally
            rd.Close()
            conn.Close()
        End Try
    End Sub


End Class