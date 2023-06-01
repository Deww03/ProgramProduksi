<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TabelProduksi
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
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
        Me.DtpTanggal = New System.Windows.Forms.DateTimePicker()
        Me.TbHarga = New System.Windows.Forms.TextBox()
        Me.TbStock = New System.Windows.Forms.TextBox()
        Me.TbIdKaryawan = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TbIdBarang = New System.Windows.Forms.TextBox()
        Me.TbIdSuplier = New System.Windows.Forms.TextBox()
        Me.TbINamaBarang = New System.Windows.Forms.TextBox()
        Me.TbIdProduksi = New System.Windows.Forms.TextBox()
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
        Me.DGV.Location = New System.Drawing.Point(41, 510)
        Me.DGV.Name = "DGV"
        Me.DGV.RowHeadersWidth = 51
        Me.DGV.RowTemplate.Height = 24
        Me.DGV.Size = New System.Drawing.Size(749, 173)
        Me.DGV.TabIndex = 8
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.LightPink
        Me.GroupBox2.Controls.Add(Me.BtnKeluar)
        Me.GroupBox2.Controls.Add(Me.BtnHapus)
        Me.GroupBox2.Controls.Add(Me.BtnEdit)
        Me.GroupBox2.Controls.Add(Me.BtnUpdate)
        Me.GroupBox2.Controls.Add(Me.BtnSimpan)
        Me.GroupBox2.Controls.Add(Me.BtnBatal)
        Me.GroupBox2.Controls.Add(Me.BtnTambah)
        Me.GroupBox2.Location = New System.Drawing.Point(538, 72)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(252, 294)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Tool Bar"
        '
        'BtnKeluar
        '
        Me.BtnKeluar.BackColor = System.Drawing.Color.Violet
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
        Me.BtnHapus.BackColor = System.Drawing.Color.Violet
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
        Me.BtnEdit.BackColor = System.Drawing.Color.Violet
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
        Me.BtnUpdate.BackColor = System.Drawing.Color.Violet
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
        Me.BtnSimpan.BackColor = System.Drawing.Color.Violet
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
        Me.BtnBatal.BackColor = System.Drawing.Color.Violet
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
        Me.BtnTambah.BackColor = System.Drawing.Color.Violet
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
        Me.GroupBox1.BackColor = System.Drawing.Color.LightSkyBlue
        Me.GroupBox1.Controls.Add(Me.DtpTanggal)
        Me.GroupBox1.Controls.Add(Me.TbHarga)
        Me.GroupBox1.Controls.Add(Me.TbStock)
        Me.GroupBox1.Controls.Add(Me.TbIdKaryawan)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.TbIdBarang)
        Me.GroupBox1.Controls.Add(Me.TbIdSuplier)
        Me.GroupBox1.Controls.Add(Me.TbINamaBarang)
        Me.GroupBox1.Controls.Add(Me.TbIdProduksi)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(41, 72)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(462, 426)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Data Produksi"
        '
        'DtpTanggal
        '
        Me.DtpTanggal.Location = New System.Drawing.Point(227, 84)
        Me.DtpTanggal.Name = "DtpTanggal"
        Me.DtpTanggal.Size = New System.Drawing.Size(217, 22)
        Me.DtpTanggal.TabIndex = 10
        '
        'TbHarga
        '
        Me.TbHarga.Location = New System.Drawing.Point(227, 385)
        Me.TbHarga.Name = "TbHarga"
        Me.TbHarga.Size = New System.Drawing.Size(180, 22)
        Me.TbHarga.TabIndex = 16
        '
        'TbStock
        '
        Me.TbStock.Location = New System.Drawing.Point(227, 337)
        Me.TbStock.Name = "TbStock"
        Me.TbStock.Size = New System.Drawing.Size(96, 22)
        Me.TbStock.TabIndex = 15
        '
        'TbIdKaryawan
        '
        Me.TbIdKaryawan.Location = New System.Drawing.Point(227, 286)
        Me.TbIdKaryawan.Name = "TbIdKaryawan"
        Me.TbIdKaryawan.Size = New System.Drawing.Size(142, 22)
        Me.TbIdKaryawan.TabIndex = 14
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(6, 382)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(133, 25)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Harga Barang"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(6, 334)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(130, 25)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Stock Barang"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(6, 283)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(121, 25)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Id Karyawan"
        '
        'TbIdBarang
        '
        Me.TbIdBarang.Location = New System.Drawing.Point(227, 135)
        Me.TbIdBarang.Name = "TbIdBarang"
        Me.TbIdBarang.Size = New System.Drawing.Size(142, 22)
        Me.TbIdBarang.TabIndex = 11
        '
        'TbIdSuplier
        '
        Me.TbIdSuplier.Location = New System.Drawing.Point(227, 241)
        Me.TbIdSuplier.Name = "TbIdSuplier"
        Me.TbIdSuplier.Size = New System.Drawing.Size(142, 22)
        Me.TbIdSuplier.TabIndex = 10
        '
        'TbINamaBarang
        '
        Me.TbINamaBarang.Location = New System.Drawing.Point(227, 188)
        Me.TbINamaBarang.Name = "TbINamaBarang"
        Me.TbINamaBarang.Size = New System.Drawing.Size(217, 22)
        Me.TbINamaBarang.TabIndex = 9
        '
        'TbIdProduksi
        '
        Me.TbIdProduksi.Location = New System.Drawing.Point(227, 34)
        Me.TbIdProduksi.Name = "TbIdProduksi"
        Me.TbIdProduksi.Size = New System.Drawing.Size(142, 22)
        Me.TbIdProduksi.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(6, 237)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(94, 25)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Id Suplier"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 31)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(109, 25)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Id Produksi"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 81)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(165, 25)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Tanggal Produksi"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(7, 184)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(132, 25)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Nama Barang"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 132)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 25)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Id Barang"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(261, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(316, 38)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "TABEL PRODUKSI"
        '
        'OleDbConnection1
        '
        Me.OleDbConnection1.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\INBOOK\Documents\Kuliah\Pr" &
    "ogramPBO\DbProduksi.mdb"
        '
        'TabelProduksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PeachPuff
        Me.ClientSize = New System.Drawing.Size(842, 695)
        Me.Controls.Add(Me.DGV)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "TabelProduksi"
        Me.Text = "Form1"
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
    Friend WithEvents TbIdSuplier As TextBox
    Friend WithEvents TbINamaBarang As TextBox
    Friend WithEvents TbIdProduksi As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents OleDbCommand1 As OleDb.OleDbCommand
    Friend WithEvents OleDbConnection1 As OleDb.OleDbConnection
    Friend WithEvents TbIdBarang As TextBox
    Friend WithEvents TbHarga As TextBox
    Friend WithEvents TbStock As TextBox
    Friend WithEvents TbIdKaryawan As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents DtpTanggal As DateTimePicker
End Class
