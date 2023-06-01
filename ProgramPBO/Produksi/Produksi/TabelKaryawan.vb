Imports System.Data.OleDb
Public Class TabelKaryawan
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
        da = New OleDbDataAdapter("select * from TbKaryawan", conn)
        ds = New DataSet
        da.Fill(ds, "TbKaryawan")
        DGV.DataSource = ds.Tables("TbKaryawan")
    End Sub
    Sub Tampildata()
        TbNamaKaryawan.Text = rd.Item(1)
        TbAlamatKaryawan.Text = rd.Item(2)
        TbIdProduksi.Text = rd.Item(3)
        DtpTanggal.Text = rd.Item(4)
    End Sub
    Sub TextMati()
        Me.TbIdKaryawan.Enabled = False
        Me.TbNamaKaryawan.Enabled = False
        Me.TbAlamatKaryawan.Enabled = False
        Me.TbIdProduksi.Enabled = False
        Me.DtpTanggal.Enabled = False
    End Sub
    Sub TextHidup()
        Me.TbIdKaryawan.Enabled = True
        Me.TbNamaKaryawan.Enabled = True
        Me.TbAlamatKaryawan.Enabled = True
        Me.TbIdProduksi.Enabled = True
        Me.DtpTanggal.Enabled = True
    End Sub
    Sub Kosong()
        TbIdKaryawan.Clear()
        TbNamaKaryawan.Clear()
        TbAlamatKaryawan.Clear()
        TbIdProduksi.Clear()
        TbIdKaryawan.Focus()
    End Sub
    Private Sub TabelKaryawan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        Me.TbIdKaryawan.Focus()
        Me.BtnTambah.Enabled = False
        Me.BtnSimpan.Enabled = True
        Me.BtnEdit.Enabled = False
        Me.BtnUpdate.Enabled = False
        Me.BtnBatal.Enabled = True
        Me.BtnHapus.Enabled = False
        Me.BtnKeluar.Enabled = True
    End Sub

    Private Sub BtnSimpan_Click(sender As Object, e As EventArgs) Handles BtnSimpan.Click
        If TbIdKaryawan.Text = "" Or TbNamaKaryawan.Text = "" Or TbAlamatKaryawan.Text = "" Then
            MsgBox("Data belum lengkap, Pastikan Semua form terisi")
            Exit Sub
        Else
            Call Koneksi()
            Dim simpan As String = "insert into TbKaryawan (Id_Karyawan, Nama_Karyawan, Alamat, Id_Produksi, Tgl_Produksi) " & " values ('" & TbIdKaryawan.Text & "','" & TbNamaKaryawan.Text & "','" & TbAlamatKaryawan.Text & "','" & TbIdProduksi.Text & "','" & DtpTanggal.Text & "')"
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
        TbIdKaryawan.Enabled = False
        BtnTambah.Enabled = False
        BtnSimpan.Enabled = False
        BtnEdit.Enabled = False
        BtnUpdate.Enabled = True
        BtnBatal.Enabled = True
        BtnHapus.Enabled = True
        BtnKeluar.Enabled = True
    End Sub

    Private Sub TbKode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TbIdKaryawan.KeyPress
        If e.KeyChar = Chr(13) Then TbNamaKaryawan.Focus()
    End Sub

    Private Sub TbKode_LostFocus(sender As Object, e As EventArgs) Handles TbIdKaryawan.LostFocus
        str = "SELECT * FROM TbKaryawan Where Id_Karyawan = '" & TbIdKaryawan.Text & "'"
        cmd = New OleDbCommand(str, conn)
        rd = cmd.ExecuteReader
        Try
            While rd.Read
                TbNamaKaryawan.Text = rd.GetString(1)
                TbAlamatKaryawan.Text = rd.GetString(2)
                TbIdProduksi.Text = rd.GetValue(3)
                DtpTanggal.Text = rd.GetValue(4)
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

    Private Sub TbNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TbNamaKaryawan.KeyPress
        If e.KeyChar = Chr(13) Then TbAlamatKaryawan.Focus()
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        Dim Sql As String
        If MsgBox("Do You Want save again ?", MsgBoxStyle.YesNo, "Message") = vbYes Then
            Sql = "update TbKaryawan set Nama_Karyawan='" & TbNamaKaryawan.Text & "',Alamat='" & TbAlamatKaryawan.Text & "',Id_Produksi='" & TbIdProduksi.Text & "',Tgl_Produksi='" & DtpTanggal.Text & "' where Id_Karyawan='" & TbIdKaryawan.Text & "'"
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
        If TbIdKaryawan.Text = "" Then
            MsgBox("Kode belum diisi")
            TbIdKaryawan.Focus()
            Exit Sub
        Else
            If MessageBox.Show("Yakin akan dihapus..?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                Dim hapus As String = "Delete * from TbKaryawan where Id_Karyawan='" & TbIdKaryawan.Text & "'"
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

    Private Sub TbJumlah_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TbIdProduksi.KeyPress
        If e.KeyChar = Chr(13) Then DtpTanggal.Focus()
    End Sub

    Private Sub TbHarga_KeyPress(sender As Object, e As KeyPressEventArgs)
        If e.KeyChar = Chr(13) Then BtnSimpan.Focus()
    End Sub

    Private Sub TbAlamatKaryawan_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TbAlamatKaryawan.KeyPress
        If e.KeyChar = Chr(13) Then TbIdProduksi.Focus()
    End Sub
End Class