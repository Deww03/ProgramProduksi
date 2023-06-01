Imports System.Data.OleDb
Public Class TabelProduksi
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
        da = New OleDbDataAdapter("select * from TbProduksi", conn)
        ds = New DataSet
        da.Fill(ds, "TbProduksi")
        DGV.DataSource = ds.Tables("TbProduksi")
    End Sub
    Sub Tampildata()
        DtpTanggal.Text = rd.Item(1)
        TbIdBarang.Text = rd.Item(2)
        TbINamaBarang.Text = rd.Item(3)
        TbIdSuplier.Text = rd.Item(4)
        TbIdKaryawan.Text = rd.Item(5)
        TbStock.Text = rd.Item(6)
        TbHarga.Text = rd.Item(7)
    End Sub
    Sub TextMati()
        Me.TbIdProduksi.Enabled = False
        Me.DtpTanggal.Enabled = False
        Me.TbIdBarang.Enabled = False
        Me.TbINamaBarang.Enabled = False
        Me.TbIdSuplier.Enabled = False
        Me.TbIdKaryawan.Enabled = False
        Me.TbStock.Enabled = False
        Me.TbHarga.Enabled = False
    End Sub
    Sub TextHidup()
        Me.TbIdProduksi.Enabled = True
        Me.DtpTanggal.Enabled = True
        Me.TbIdBarang.Enabled = True
        Me.TbINamaBarang.Enabled = True
        Me.TbIdSuplier.Enabled = True
        Me.TbIdKaryawan.Enabled = True
        Me.TbStock.Enabled = True
        Me.TbHarga.Enabled = True
    End Sub
    Sub Kosong()
        TbIdProduksi.Clear()
        TbIdBarang.Clear()
        TbINamaBarang.Clear()
        TbIdSuplier.Clear()
        TbIdKaryawan.Clear()
        TbStock.Clear()
        TbHarga.Clear()
        TbIdProduksi.Focus()
    End Sub
    Private Sub TabelProduksi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    Private Sub BtnTambah_Click(sender As Object, e As EventArgs) Handles BtnTambah.Click
        Call Kosong()
        Call TextHidup()
        Me.TbIdProduksi.Focus()
        Me.BtnTambah.Enabled = False
        Me.BtnSimpan.Enabled = True
        Me.BtnEdit.Enabled = False
        Me.BtnUpdate.Enabled = False
        Me.BtnBatal.Enabled = True
        Me.BtnHapus.Enabled = False
        Me.BtnKeluar.Enabled = True
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

    Private Sub BtnKeluar_Click(sender As Object, e As EventArgs) Handles BtnKeluar.Click
        Me.Close()
    End Sub

    Private Sub BtnSimpan_Click(sender As Object, e As EventArgs) Handles BtnSimpan.Click
        If TbIdProduksi.Text = "" Or DtpTanggal.Text = "" Or TbIdBarang.Text = "" Then
            MsgBox("Data belum lengkap, Pastikan Semua form terisi")
            Exit Sub
        Else
            Call Koneksi()
            Dim simpan As String = "insert into TbProduksi (Id_Produksi, Tgl_Produksi, Id_Barang, Nama_Barang, Id_Suplier, Id_Karyawan, Stock_Barang, Harga_Barang) " & " values ('" & TbIdProduksi.Text & "','" & DtpTanggal.Text & "','" & TbIdBarang.Text & "','" & TbINamaBarang.Text & "','" & TbIdSuplier.Text & "','" & TbIdKaryawan.Text & "','" & TbStock.Text & "','" & TbHarga.Text & "')"
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
        TbIdProduksi.Enabled = False
        BtnTambah.Enabled = False
        BtnSimpan.Enabled = False
        BtnEdit.Enabled = False
        BtnUpdate.Enabled = True
        BtnBatal.Enabled = True
        BtnHapus.Enabled = True
        BtnKeluar.Enabled = True
    End Sub

    Private Sub TbKode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TbIdProduksi.KeyPress
        If e.KeyChar = Chr(13) Then DtpTanggal.Focus()
    End Sub

    Private Sub TbKode_LostFocus(sender As Object, e As EventArgs) Handles TbIdProduksi.LostFocus
        str = "SELECT * FROM TbProduksi Where Id_Produksi = '" & TbIdProduksi.Text & "'"
        cmd = New OleDbCommand(str, conn)
        rd = cmd.ExecuteReader
        Try
            While rd.Read
                DtpTanggal.Text = rd.GetString(1)
                TbIdBarang.Text = rd.GetString(2)
                TbINamaBarang.Text = rd.GetValue(3)
                TbIdSuplier.Text = rd.GetValue(4)
                TbIdKaryawan.Text = rd.GetValue(5)
                TbStock.Text = rd.GetValue(6)
                TbHarga.Text = rd.GetValue(7)
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

    Private Sub DtpTanggal_KeyPress(sender As Object, e As KeyPressEventArgs) Handles DtpTanggal.KeyPress
        If e.KeyChar = Chr(13) Then TbIdBarang.Focus()
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        Dim Sql As String
        If MsgBox("Do You Want save again ?", MsgBoxStyle.YesNo, "Message") = vbYes Then
            Sql = "update TbProduksi set Tgl_Produksi='" & DtpTanggal.Text & "',Id_Barang='" & TbIdBarang.Text & "',Nama_Barang='" & TbINamaBarang.Text & "',Id_Suplier='" & TbIdSuplier.Text & "',Id_Karyawan='" & TbIdKaryawan.Text & "',Stock_Barang='" & TbStock.Text & "',Harga_Barang='" & TbHarga.Text & "' where Id_Produksi='" & TbIdProduksi.Text & "'"
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

    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click
        If TbIdProduksi.Text = "" Then
            MsgBox("Kode belum diisi")
            TbIdProduksi.Focus()
            Exit Sub
        Else
            If MessageBox.Show("Yakin akan dihapus..?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                Dim hapus As String = "Delete * from TbProduksi where Id_Produksi='" & TbIdProduksi.Text & "'"
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

    Private Sub TbNamaBarang_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TbINamaBarang.KeyPress
        If e.KeyChar = Chr(13) Then TbIdSuplier.Focus()
    End Sub

    Private Sub TbIdSuplier_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TbIdSuplier.KeyPress
        If e.KeyChar = Chr(13) Then TbIdKaryawan.Focus()
    End Sub

    Private Sub TbHarga_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TbHarga.KeyPress
        If e.KeyChar = Chr(13) Then BtnSimpan.Focus()
    End Sub

    Private Sub TbIdBarang_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TbIdBarang.KeyPress
        If e.KeyChar = Chr(13) Then TbINamaBarang.Focus()
    End Sub

    Private Sub TbIdKaryawan_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TbIdKaryawan.KeyPress
        If e.KeyChar = Chr(13) Then TbStock.Focus()
    End Sub

    Private Sub TbStock_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TbStock.KeyPress
        If e.KeyChar = Chr(13) Then TbHarga.Focus()
    End Sub
End Class
