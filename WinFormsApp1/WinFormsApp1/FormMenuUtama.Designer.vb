<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMenuUtama
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMenuUtama))
        Label1 = New Label()
        MenuStrip1 = New MenuStrip()
        FileToolStripMenuItem = New ToolStripMenuItem()
        MasterToolStripMenuItem = New ToolStripMenuItem()
        LaporanToolStripMenuItem = New ToolStripMenuItem()
        ToolStrip1 = New ToolStrip()
        ToolStripSplitButton1 = New ToolStripSplitButton()
        LoginToolStripMenuItem = New ToolStripMenuItem()
        LogoutToolStripMenuItem = New ToolStripMenuItem()
        ToolStripSplitButton2 = New ToolStripSplitButton()
        DataGudangToolStripMenuItem1 = New ToolStripMenuItem()
        DataBarangToolStripMenuItem2 = New ToolStripMenuItem()
        ToolStripDropDownButton1 = New ToolStripDropDownButton()
        LaporanGudangToolStripMenuItem = New ToolStripMenuItem()
        LaporanBarangToolStripMenuItem = New ToolStripMenuItem()
        StatusStrip1 = New StatusStrip()
        ToolStripStatusLabel1 = New ToolStripStatusLabel()
        sbtanggal = New ToolStripStatusLabel()
        PrintDocument1 = New Printing.PrintDocument()
        MenuStrip1.SuspendLayout()
        ToolStrip1.SuspendLayout()
        StatusStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(26, 23)
        Label1.Name = "Label1"
        Label1.Size = New Size(0, 25)
        Label1.TabIndex = 0
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {FileToolStripMenuItem, MasterToolStripMenuItem, LaporanToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(800, 24)
        MenuStrip1.TabIndex = 1
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' FileToolStripMenuItem
        ' 
        FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        FileToolStripMenuItem.Size = New Size(37, 20)
        FileToolStripMenuItem.Text = "File"
        ' 
        ' MasterToolStripMenuItem
        ' 
        MasterToolStripMenuItem.Name = "MasterToolStripMenuItem"
        MasterToolStripMenuItem.Size = New Size(55, 20)
        MasterToolStripMenuItem.Text = "Master"
        ' 
        ' LaporanToolStripMenuItem
        ' 
        LaporanToolStripMenuItem.Name = "LaporanToolStripMenuItem"
        LaporanToolStripMenuItem.Size = New Size(62, 20)
        LaporanToolStripMenuItem.Text = "Laporan"
        ' 
        ' ToolStrip1
        ' 
        ToolStrip1.Items.AddRange(New ToolStripItem() {ToolStripSplitButton1, ToolStripSplitButton2, ToolStripDropDownButton1})
        ToolStrip1.Location = New Point(0, 24)
        ToolStrip1.Name = "ToolStrip1"
        ToolStrip1.Size = New Size(800, 49)
        ToolStrip1.TabIndex = 3
        ToolStrip1.Text = "ToolStrip1"
        ' 
        ' ToolStripSplitButton1
        ' 
        ToolStripSplitButton1.DisplayStyle = ToolStripItemDisplayStyle.Image
        ToolStripSplitButton1.DropDownItems.AddRange(New ToolStripItem() {LoginToolStripMenuItem, LogoutToolStripMenuItem})
        ToolStripSplitButton1.Image = CType(resources.GetObject("ToolStripSplitButton1.Image"), Image)
        ToolStripSplitButton1.ImageScaling = ToolStripItemImageScaling.None
        ToolStripSplitButton1.ImageTransparentColor = Color.Magenta
        ToolStripSplitButton1.Name = "ToolStripSplitButton1"
        ToolStripSplitButton1.Size = New Size(56, 46)
        ToolStripSplitButton1.Text = "ToolStripSplitButton1"
        ' 
        ' LoginToolStripMenuItem
        ' 
        LoginToolStripMenuItem.Image = CType(resources.GetObject("LoginToolStripMenuItem.Image"), Image)
        LoginToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None
        LoginToolStripMenuItem.Name = "LoginToolStripMenuItem"
        LoginToolStripMenuItem.Size = New Size(126, 36)
        LoginToolStripMenuItem.Text = "Login"
        ' 
        ' LogoutToolStripMenuItem
        ' 
        LogoutToolStripMenuItem.Image = CType(resources.GetObject("LogoutToolStripMenuItem.Image"), Image)
        LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        LogoutToolStripMenuItem.Size = New Size(126, 36)
        LogoutToolStripMenuItem.Text = "Logout"
        ' 
        ' ToolStripSplitButton2
        ' 
        ToolStripSplitButton2.DisplayStyle = ToolStripItemDisplayStyle.Image
        ToolStripSplitButton2.DropDownItems.AddRange(New ToolStripItem() {DataGudangToolStripMenuItem1, DataBarangToolStripMenuItem2})
        ToolStripSplitButton2.Image = CType(resources.GetObject("ToolStripSplitButton2.Image"), Image)
        ToolStripSplitButton2.ImageScaling = ToolStripItemImageScaling.None
        ToolStripSplitButton2.ImageTransparentColor = Color.Magenta
        ToolStripSplitButton2.Name = "ToolStripSplitButton2"
        ToolStripSplitButton2.Size = New Size(56, 46)
        ToolStripSplitButton2.Text = "ToolStripSplitButton2"
        ' 
        ' DataGudangToolStripMenuItem1
        ' 
        DataGudangToolStripMenuItem1.Image = CType(resources.GetObject("DataGudangToolStripMenuItem1.Image"), Image)
        DataGudangToolStripMenuItem1.ImageScaling = ToolStripItemImageScaling.None
        DataGudangToolStripMenuItem1.Name = "DataGudangToolStripMenuItem1"
        DataGudangToolStripMenuItem1.Size = New Size(162, 42)
        DataGudangToolStripMenuItem1.Text = "Data Gudang"
        ' 
        ' DataBarangToolStripMenuItem2
        ' 
        DataBarangToolStripMenuItem2.Image = CType(resources.GetObject("DataBarangToolStripMenuItem2.Image"), Image)
        DataBarangToolStripMenuItem2.ImageScaling = ToolStripItemImageScaling.None
        DataBarangToolStripMenuItem2.Name = "DataBarangToolStripMenuItem2"
        DataBarangToolStripMenuItem2.Size = New Size(162, 42)
        DataBarangToolStripMenuItem2.Text = "Data Barang"
        ' 
        ' ToolStripDropDownButton1
        ' 
        ToolStripDropDownButton1.DisplayStyle = ToolStripItemDisplayStyle.Image
        ToolStripDropDownButton1.DropDownItems.AddRange(New ToolStripItem() {LaporanGudangToolStripMenuItem, LaporanBarangToolStripMenuItem})
        ToolStripDropDownButton1.Image = CType(resources.GetObject("ToolStripDropDownButton1.Image"), Image)
        ToolStripDropDownButton1.ImageScaling = ToolStripItemImageScaling.None
        ToolStripDropDownButton1.ImageTransparentColor = Color.Magenta
        ToolStripDropDownButton1.Name = "ToolStripDropDownButton1"
        ToolStripDropDownButton1.Size = New Size(53, 46)
        ToolStripDropDownButton1.Text = "ToolStripDropDownButton1"
        ' 
        ' LaporanGudangToolStripMenuItem
        ' 
        LaporanGudangToolStripMenuItem.Image = CType(resources.GetObject("LaporanGudangToolStripMenuItem.Image"), Image)
        LaporanGudangToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None
        LaporanGudangToolStripMenuItem.Name = "LaporanGudangToolStripMenuItem"
        LaporanGudangToolStripMenuItem.Size = New Size(199, 42)
        LaporanGudangToolStripMenuItem.Text = "Laporan Gudang"
        ' 
        ' LaporanBarangToolStripMenuItem
        ' 
        LaporanBarangToolStripMenuItem.Image = CType(resources.GetObject("LaporanBarangToolStripMenuItem.Image"), Image)
        LaporanBarangToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None
        LaporanBarangToolStripMenuItem.Name = "LaporanBarangToolStripMenuItem"
        LaporanBarangToolStripMenuItem.Size = New Size(199, 42)
        LaporanBarangToolStripMenuItem.Text = "Laporan Barang"
        ' 
        ' StatusStrip1
        ' 
        StatusStrip1.Items.AddRange(New ToolStripItem() {ToolStripStatusLabel1, sbtanggal})
        StatusStrip1.Location = New Point(0, 428)
        StatusStrip1.Name = "StatusStrip1"
        StatusStrip1.Size = New Size(800, 22)
        StatusStrip1.TabIndex = 5
        StatusStrip1.Text = "StatusStrip1"
        ' 
        ' ToolStripStatusLabel1
        ' 
        ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        ToolStripStatusLabel1.Size = New Size(119, 17)
        ToolStripStatusLabel1.Text = "Di buat oleh : M.Fadil"
        ' 
        ' sbtanggal
        ' 
        sbtanggal.Name = "sbtanggal"
        sbtanggal.Size = New Size(10, 17)
        sbtanggal.Text = "I"
        ' 
        ' PrintDocument1
        ' 
        ' 
        ' FormMenuUtama
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(800, 450)
        Controls.Add(StatusStrip1)
        Controls.Add(ToolStrip1)
        Controls.Add(Label1)
        Controls.Add(MenuStrip1)
        IsMdiContainer = True
        MainMenuStrip = MenuStrip1
        Name = "FormMenuUtama"
        Text = "Menu"
        WindowState = FormWindowState.Maximized
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ToolStrip1.ResumeLayout(False)
        ToolStrip1.PerformLayout()
        StatusStrip1.ResumeLayout(False)
        StatusStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MasterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripSplitButton1 As ToolStripSplitButton
    Friend WithEvents LoginToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSplitButton2 As ToolStripSplitButton
    Friend WithEvents DataGudangToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents DataBarangToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents sbtanggal As ToolStripStatusLabel
    Friend WithEvents LaporanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripDropDownButton1 As ToolStripDropDownButton
    Friend WithEvents LaporanGudangToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LaporanBarangToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
End Class
