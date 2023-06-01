Imports System.Data.OleDb
Public Class TabelBarang
    Dim conn As OleDbConnection
    Dim da As OleDbDataAdapter
    Dim ds As DataSet
    Dim cmd As OleDbCommand
    Dim rd As OleDbDataReader
    Dim str As String
    Sub Koneksi()
        str = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\INBOOK\Documents\Kuliah\ProgramPBO\DbProduksi.mdb"
        conn = New OleDbConnection(str)
        If conn.State = ConnectionState.Closed Then conn.Open()
    End Sub
    Sub Tampilgrid()
        da = New OleDbDataAdapter("select * from TbBarang", conn)
        ds = New DataSet
        da.Fill(ds, "TbBarang")
        DGV.DataSource = ds.Tables("TbBarang")
    End Sub
    Sub Tampildata()
        TbNamaBarang.Text = rd.Item(1)
        TbIdProduksi.Text = rd.Item(2)
        DtpTanggal.Text = rd.Item(3)
        TbIdSuplier.Text = rd.Item(4)
        TbStock.Text = rd.Item(5)
        TbHarga.Text = rd.Item(6)
    End Sub
    Sub TextMati()
        Me.TbIdBarang.Enabled = False
        Me.TbNamaBarang.Enabled = False
        Me.TbIdProduksi.Enabled = False
        Me.DtpTanggal.Enabled = False
        Me.TbIdSuplier.Enabled = False
        Me.TbStock.Enabled = False
        Me.TbHarga.Enabled = False
    End Sub
    Sub TextHidup()
        Me.TbIdBarang.Enabled = True
        Me.TbNamaBarang.Enabled = True
        Me.TbIdProduksi.Enabled = True
        Me.DtpTanggal.Enabled = True
        Me.TbIdSuplier.Enabled = True
        Me.TbStock.Enabled = True
        Me.TbHarga.Enabled = True
    End Sub
    Sub Kosong()
        TbIdBarang.Clear()
        TbNamaBarang.Clear()
        TbIdProduksi.Clear()
        TbIdSuplier.Clear()
        TbStock.Clear()
        TbHarga.Clear()
        TbIdBarang.Focus()
    End Sub
    Private Sub TabelBarang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Koneksi()
        Call Tampilgrid()
        Call TextMati()
        Me.BtnTambah.Enabled = True
        Me.BtnSimpan.Enabled = False
        Me.BtnEdit.Enabled = False
        Me.BtnUpdate.Enabled = False
        Me.BtnBatal.Enabled = False
        Me.BtnHapus.Enabled = False
        Me.BtnKeluar.Enabled = True
    End Sub
    Private Sub BtnKeluar_Click(sender As Object, e As EventArgs) Handles BtnKeluar.Click
        Me.Close()
    End Sub

    Private Sub BtnTambah_Click(sender As Object, e As EventArgs) Handles BtnTambah.Click
        Call Kosong()
        Call TextHidup()
        Me.TbIdBarang.Focus()
        Me.BtnTambah.Enabled = False
        Me.BtnSimpan.Enabled = True
        Me.BtnEdit.Enabled = False
        Me.BtnUpdate.Enabled = False
        Me.BtnBatal.Enabled = True
        Me.BtnHapus.Enabled = False
        Me.BtnKeluar.Enabled = True
    End Sub

    Private Sub BtnSimpan_Click(sender As Object, e As EventArgs) Handles BtnSimpan.Click
        If TbIdBarang.Text = "" Or TbNamaBarang.Text = "" Or TbIdProduksi.Text = "" Then
            MsgBox("Data belum lengkap, Pastikan Semua form terisi")
            Exit Sub
        Else
            Call Koneksi()
            Dim simpan As String = "insert into TbBarang (Id_Barang, Nama_Barang, Id_Produksi, Tgl_Produksi, Id_Suplier, Stock_Barang, Harga_Barang) " & " values ('" & TbIdBarang.Text & "','" & TbNamaBarang.Text & "','" & TbIdProduksi.Text & "','" & DtpTanggal.Text & "','" & TbIdSuplier.Text & "','" & TbStock.Text & "','" & TbHarga.Text & "')"
            cmd = New OleDbCommand(simpan, conn)
            cmd.ExecuteNonQuery()
            MsgBox("Data berhasil di Input", MsgBoxStyle.Information, "Information")
            Me.OleDbConnection1.Close()
            Call Tampilgrid()
            DGV.Refresh()
            Call Koneksi()
            Call Kosong()
            Call TextMati()
            Me.BtnTambah.Enabled = True
            Me.BtnSimpan.Enabled = False
            Me.BtnEdit.Enabled = False
            Me.BtnUpdate.Enabled = False
            Me.BtnBatal.Enabled = False
            Me.BtnHapus.Enabled = False
            Me.BtnKeluar.Enabled = True
        End If
    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        Call TextHidup()
        TbIdBarang.Enabled = False
        BtnTambah.Enabled = False
        BtnSimpan.Enabled = False
        BtnEdit.Enabled = False
        BtnUpdate.Enabled = True
        BtnBatal.Enabled = True
        BtnHapus.Enabled = True
        BtnKeluar.Enabled = True
    End Sub

    Private Sub TbKode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TbIdBarang.KeyPress
        If e.KeyChar = Chr(13) Then TbNamaBarang.Focus()
    End Sub

    Private Sub TbKode_LostFocus(sender As Object, e As EventArgs) Handles TbIdBarang.LostFocus
        str = "SELECT * FROM TbBarang Where Id_Barang = '" & TbIdBarang.Text & "'"
        cmd = New OleDbCommand(str, conn)
        rd = cmd.ExecuteReader
        Try
            While rd.Read
                TbNamaBarang.Text = rd.GetString(1)
                TbIdProduksi.Text = rd.GetString(2)
                DtpTanggal.Text = rd.GetValue(3)
                TbIdSuplier.Text = rd.GetValue(4)
                TbStock.Text = rd.GetValue(5)
                TbHarga.Text = rd.GetValue(6)
                TextMati()
                Me.BtnTambah.Enabled = False
                Me.BtnSimpan.Enabled = False
                Me.BtnEdit.Enabled = True
                Me.BtnUpdate.Enabled = False
                Me.BtnBatal.Enabled = False
                Me.BtnHapus.Enabled = False
                Me.BtnKeluar.Enabled = True
            End While
        Finally
            rd.Close()
        End Try
    End Sub

    Private Sub TbNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TbNamaBarang.KeyPress
        If e.KeyChar = Chr(13) Then TbIdProduksi.Focus()
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        Dim Sql As String
        If MsgBox("Do You Want save again ?", MsgBoxStyle.YesNo, "Message") = vbYes Then
            Sql = "update TbBarang set Nama_Barang='" & TbNamaBarang.Text & "',Id_Produksi='" & TbIdProduksi.Text & "',Tgl_Produksi='" & DtpTanggal.Text & "',Id_Suplier='" & TbIdSuplier.Text & "',Stock_Barang='" & TbStock.Text & "',Harga_Barang='" & TbHarga.Text & "' where Id_Barang='" & TbIdBarang.Text & "'"
            cmd = New OleDbCommand(Sql, conn)
            cmd.ExecuteNonQuery()
            DGV.Refresh()
            Me.OleDbConnection1.Close()
            Call TextMati()
            Call Kosong()
            Me.BtnTambah.Enabled = True
            Me.BtnSimpan.Enabled = False
            Me.BtnEdit.Enabled = False
            Me.BtnUpdate.Enabled = False
            Me.BtnBatal.Enabled = False
            Me.BtnHapus.Enabled = False
            Me.BtnKeluar.Enabled = True
            DGV.Refresh()
            Call Tampilgrid()
        End If
    End Sub

    Private Sub BtnBatal_Click(sender As Object, e As EventArgs) Handles BtnBatal.Click
        Call Kosong()
        Call TextMati()
        Me.BtnTambah.Enabled = True
        Me.BtnSimpan.Enabled = False
        Me.BtnEdit.Enabled = False
        Me.BtnUpdate.Enabled = False
        Me.BtnBatal.Enabled = False
        Me.BtnHapus.Enabled = False
        Me.BtnKeluar.Enabled = True
    End Sub

    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click
        If TbIdBarang.Text = "" Then
            MsgBox("Kode belum diisi")
            TbIdBarang.Focus()
            Exit Sub
        Else
            If MessageBox.Show("Yakin akan dihapus..?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                Dim hapus As String = "Delete * from TbBarang where Id_Barang='" & TbIdBarang.Text & "'"
                cmd = New OleDbCommand(hapus, conn)
                cmd.ExecuteNonQuery()
                Call Tampilgrid()
                Call Kosong()
                Me.BtnTambah.Enabled = True
                Me.BtnSimpan.Enabled = False
                Me.BtnEdit.Enabled = False
                Me.BtnUpdate.Enabled = False
                Me.BtnBatal.Enabled = False
                Me.BtnHapus.Enabled = False
                Me.BtnKeluar.Enabled = True
            Else
                Call TextMati()
            End If
        End If
    End Sub

    Private Sub TbJumlah_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TbIdSuplier.KeyPress
        If e.KeyChar = Chr(13) Then TbStock.Focus()
    End Sub

    Private Sub TbHarga_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TbHarga.KeyPress
        If e.KeyChar = Chr(13) Then BtnSimpan.Focus()
    End Sub

    Private Sub TbStock_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TbStock.KeyPress
        If e.KeyChar = Chr(13) Then TbHarga.Focus()
    End Sub

    Private Sub DtpTanggal_KeyPress(sender As Object, e As KeyPressEventArgs) Handles DtpTanggal.KeyPress
        If e.KeyChar = Chr(13) Then TbIdSuplier.Focus()
    End Sub

    Private Sub TbIdProduksi_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TbIdProduksi.KeyPress
        If e.KeyChar = Chr(13) Then DtpTanggal.Focus()
    End Sub
End Class