<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TabelBarang
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
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BtnKeluar = New System.Windows.Forms.Button()
        Me.BtnHapus = New System.Windows.Forms.Button()
        Me.BtnEdit = New System.Windows.Forms.Button()
        Me.BtnUpdate = New System.Windows.Forms.Button()
        Me.BtnSimpan = New System.Windows.Forms.Button()
        Me.BtnBatal = New System.Windows.Forms.Button()
        Me.BtnTambah = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TbHarga = New System.Windows.Forms.TextBox()
        Me.TbStock = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DtpTanggal = New System.Windows.Forms.DateTimePicker()
        Me.TbIdProduksi = New System.Windows.Forms.TextBox()
        Me.TbIdSuplier = New System.Windows.Forms.TextBox()
        Me.TbNamaBarang = New System.Windows.Forms.TextBox()
        Me.TbIdBarang = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.OleDbCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbConnection1 = New System.Data.OleDb.OleDbConnection()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DGV
        '
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Location = New System.Drawing.Point(22, 468)
        Me.DGV.Name = "DGV"
        Me.DGV.RowHeadersWidth = 51
        Me.DGV.RowTemplate.Height = 24
        Me.DGV.Size = New System.Drawing.Size(749, 173)
        Me.DGV.TabIndex = 12
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Aquamarine
        Me.GroupBox2.Controls.Add(Me.BtnKeluar)
        Me.GroupBox2.Controls.Add(Me.BtnHapus)
        Me.GroupBox2.Controls.Add(Me.BtnEdit)
        Me.GroupBox2.Controls.Add(Me.BtnUpdate)
        Me.GroupBox2.Controls.Add(Me.BtnSimpan)
        Me.GroupBox2.Controls.Add(Me.BtnBatal)
        Me.GroupBox2.Controls.Add(Me.BtnTambah)
        Me.GroupBox2.Location = New System.Drawing.Point(519, 88)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(252, 294)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Tool Bar"
        '
        'BtnKeluar
        '
        Me.BtnKeluar.BackColor = System.Drawing.Color.Azure
        Me.BtnKeluar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnKeluar.Location = New System.Drawing.Point(17, 223)
        Me.BtnKeluar.Name = "BtnKeluar"
        Me.BtnKeluar.Size = New System.Drawing.Size(219, 39)
        Me.BtnKeluar.TabIndex = 6
        Me.BtnKeluar.Text = "Keluar"
        Me.BtnKeluar.UseVisualStyleBackColor = False
        '
        'BtnHapus
        '
        Me.BtnHapus.BackColor = System.Drawing.Color.Azure
        Me.BtnHapus.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnHapus.Location = New System.Drawing.Point(136, 160)
        Me.BtnHapus.Name = "BtnHapus"
        Me.BtnHapus.Size = New System.Drawing.Size(100, 39)
        Me.BtnHapus.TabIndex = 5
        Me.BtnHapus.Text = "Hapus"
        Me.BtnHapus.UseVisualStyleBackColor = False
        '
        'BtnEdit
        '
        Me.BtnEdit.BackColor = System.Drawing.Color.Azure
        Me.BtnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnEdit.Location = New System.Drawing.Point(17, 160)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(100, 39)
        Me.BtnEdit.TabIndex = 4
        Me.BtnEdit.Text = "Edit"
        Me.BtnEdit.UseVisualStyleBackColor = False
        '
        'BtnUpdate
        '
        Me.BtnUpdate.BackColor = System.Drawing.Color.Azure
        Me.BtnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnUpdate.Location = New System.Drawing.Point(136, 98)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(100, 39)
        Me.BtnUpdate.TabIndex = 3
        Me.BtnUpdate.Text = "Update"
        Me.BtnUpdate.UseVisualStyleBackColor = False
        '
        'BtnSimpan
        '
        Me.BtnSimpan.BackColor = System.Drawing.Color.Azure
        Me.BtnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnSimpan.Location = New System.Drawing.Point(17, 98)
        Me.BtnSimpan.Name = "BtnSimpan"
        Me.BtnSimpan.Size = New System.Drawing.Size(100, 39)
        Me.BtnSimpan.TabIndex = 2
        Me.BtnSimpan.Text = "Simpan"
        Me.BtnSimpan.UseVisualStyleBackColor = False
        '
        'BtnBatal
        '
        Me.BtnBatal.BackColor = System.Drawing.Color.Azure
        Me.BtnBatal.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnBatal.Location = New System.Drawing.Point(136, 34)
        Me.BtnBatal.Name = "BtnBatal"
        Me.BtnBatal.Size = New System.Drawing.Size(100, 39)
        Me.BtnBatal.TabIndex = 1
        Me.BtnBatal.Text = "Batal"
        Me.BtnBatal.UseVisualStyleBackColor = False
        '
        'BtnTambah
        '
        Me.BtnTambah.BackColor = System.Drawing.Color.Azure
        Me.BtnTambah.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnTambah.Location = New System.Drawing.Point(17, 34)
        Me.BtnTambah.Name = "BtnTambah"
        Me.BtnTambah.Size = New System.Drawing.Size(100, 39)
        Me.BtnTambah.TabIndex = 0
        Me.BtnTambah.Text = "Tambah"
        Me.BtnTambah.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Silver
        Me.GroupBox1.Controls.Add(Me.TbHarga)
        Me.GroupBox1.Controls.Add(Me.TbStock)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.DtpTanggal)
        Me.GroupBox1.Controls.Add(Me.TbIdProduksi)
        Me.GroupBox1.Controls.Add(Me.TbIdSuplier)
        Me.GroupBox1.Controls.Add(Me.TbNamaBarang)
        Me.GroupBox1.Controls.Add(Me.TbIdBarang)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(22, 88)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(462, 359)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Data Karyawan"
        '
        'TbHarga
        '
        Me.TbHarga.Location = New System.Drawing.Point(227, 325)
        Me.TbHarga.Name = "TbHarga"
        Me.TbHarga.Size = New System.Drawing.Size(142, 22)
        Me.TbHarga.TabIndex = 16
        '
        'TbStock
        '
        Me.TbStock.Location = New System.Drawing.Point(227, 284)
        Me.TbStock.Name = "TbStock"
        Me.TbStock.Size = New System.Drawing.Size(90, 22)
        Me.TbStock.TabIndex = 15
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(8, 321)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(133, 25)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Harga Barang"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(6, 280)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(130, 25)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Stock Barang"
        '
        'DtpTanggal
        '
        Me.DtpTanggal.Location = New System.Drawing.Point(227, 191)
        Me.DtpTanggal.Name = "DtpTanggal"
        Me.DtpTanggal.Size = New System.Drawing.Size(217, 22)
        Me.DtpTanggal.TabIndex = 12
        '
        'TbIdProduksi
        '
        Me.TbIdProduksi.Location = New System.Drawing.Point(227, 134)
        Me.TbIdProduksi.Name = "TbIdProduksi"
        Me.TbIdProduksi.Size = New System.Drawing.Size(142, 22)
        Me.TbIdProduksi.TabIndex = 11
        '
        'TbIdSuplier
        '
        Me.TbIdSuplier.Location = New System.Drawing.Point(227, 240)
        Me.TbIdSuplier.Name = "TbIdSuplier"
        Me.TbIdSuplier.Size = New System.Drawing.Size(142, 22)
        Me.TbIdSuplier.TabIndex = 9
        '
        'TbNamaBarang
        '
        Me.TbNamaBarang.Location = New System.Drawing.Point(227, 84)
        Me.TbNamaBarang.Name = "TbNamaBarang"
        Me.TbNamaBarang.Size = New System.Drawing.Size(217, 22)
        Me.TbNamaBarang.TabIndex = 8
        '
        'TbIdBarang
        '
        Me.TbIdBarang.Location = New System.Drawing.Point(227, 34)
        Me.TbIdBarang.Name = "TbIdBarang"
        Me.TbIdBarang.Size = New System.Drawing.Size(142, 22)
        Me.TbIdBarang.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(6, 188)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(165, 25)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Tanggal Produksi"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 134)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(109, 25)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Id Produksi"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 237)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 25)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Id Suplier"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(132, 25)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Nama Barang"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 25)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Id Barang"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(271, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(282, 38)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "TABEL BARANG"
        '
        'OleDbConnection1
        '
        Me.OleDbConnection1.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\INBOOK\Documents\Kuliah\Pr" &
    "ogramPBO\DbProduksi.mdb"
        '
        'TabelBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.GhostWhite
        Me.ClientSize = New System.Drawing.Size(793, 653)
        Me.Controls.Add(Me.DGV)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "TabelBarang"
        Me.Text = "TabelBarang"
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DGV As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents BtnKeluar As Button
    Friend WithEvents BtnHapus As Button
    Friend WithEvents BtnEdit As Button
    Friend WithEvents BtnUpdate As Button
    Friend WithEvents BtnSimpan As Button
    Friend WithEvents BtnBatal As Button
    Friend WithEvents BtnTambah As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DtpTanggal As DateTimePicker
    Friend WithEvents TbIdProduksi As TextBox
    Friend WithEvents TbIdSuplier As TextBox
    Friend WithEvents TbNamaBarang As TextBox
    Friend WithEvents TbIdBarang As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents OleDbCommand1 As OleDb.OleDbCommand
    Friend WithEvents OleDbConnection1 As OleDb.OleDbConnection
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TbHarga As TextBox
    Friend WithEvents TbStock As TextBox
End Class
