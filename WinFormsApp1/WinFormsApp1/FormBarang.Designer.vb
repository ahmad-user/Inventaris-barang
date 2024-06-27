<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormBarang
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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        DGV1 = New DataGridView()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        TextBox6 = New TextBox()
        Label8 = New Label()
        DTP1 = New DateTimePicker()
        TextBox5 = New TextBox()
        CType(DGV1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(259, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(161, 32)
        Label1.TabIndex = 0
        Label1.Text = "Form Barang"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(12, 60)
        Label2.Name = "Label2"
        Label2.Size = New Size(74, 15)
        Label2.TabIndex = 1
        Label2.Text = "Kode Barang"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(12, 98)
        Label3.Name = "Label3"
        Label3.Size = New Size(79, 15)
        Label3.TabIndex = 2
        Label3.Text = "Nama Barang"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(12, 133)
        Label4.Name = "Label4"
        Label4.Size = New Size(79, 15)
        Label4.TabIndex = 3
        Label4.Text = "Harga Barang"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(12, 167)
        Label5.Name = "Label5"
        Label5.Size = New Size(85, 15)
        Label5.TabIndex = 4
        Label5.Text = "Jumlah Barang"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(12, 201)
        Label6.Name = "Label6"
        Label6.Size = New Size(86, 15)
        Label6.TabIndex = 5
        Label6.Text = "Expired Barang"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(12, 239)
        Label7.Name = "Label7"
        Label7.Size = New Size(63, 15)
        Label7.TabIndex = 6
        Label7.Text = "Gudang ID"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(12, 283)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 12
        Button1.Text = "INPUT"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(105, 283)
        Button2.Name = "Button2"
        Button2.Size = New Size(75, 23)
        Button2.TabIndex = 13
        Button2.Text = "EDIT"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(198, 283)
        Button3.Name = "Button3"
        Button3.Size = New Size(75, 23)
        Button3.TabIndex = 14
        Button3.Text = "HAPUS"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(289, 283)
        Button4.Name = "Button4"
        Button4.Size = New Size(75, 23)
        Button4.TabIndex = 15
        Button4.Text = "KELUAR"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' DGV1
        ' 
        DGV1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DGV1.Location = New Point(12, 341)
        DGV1.Name = "DGV1"
        DGV1.Size = New Size(633, 132)
        DGV1.TabIndex = 16
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(133, 60)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(176, 23)
        TextBox1.TabIndex = 21
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(133, 98)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(176, 23)
        TextBox2.TabIndex = 22
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(133, 133)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(176, 23)
        TextBox3.TabIndex = 23
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(133, 167)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(176, 23)
        TextBox4.TabIndex = 24
        ' 
        ' TextBox6
        ' 
        TextBox6.Location = New Point(133, 239)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(176, 23)
        TextBox6.TabIndex = 26
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(325, 312)
        Label8.Name = "Label8"
        Label8.Size = New Size(114, 15)
        Label8.TabIndex = 27
        Label8.Text = "Cari Tanggal Expired"
        ' 
        ' DTP1
        ' 
        DTP1.Format = DateTimePickerFormat.Custom
        DTP1.Location = New Point(133, 201)
        DTP1.Name = "DTP1"
        DTP1.Size = New Size(176, 23)
        DTP1.TabIndex = 28
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(445, 309)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(200, 23)
        TextBox5.TabIndex = 29
        ' 
        ' FormBarang
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(660, 485)
        Controls.Add(TextBox5)
        Controls.Add(DTP1)
        Controls.Add(Label8)
        Controls.Add(TextBox6)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(DGV1)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "FormBarang"
        StartPosition = FormStartPosition.CenterScreen
        Text = "FormBarang"
        CType(DGV1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents DGV1 As DataGridView
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents DTP1 As DateTimePicker
    Friend WithEvents TextBox5 As TextBox
End Class
