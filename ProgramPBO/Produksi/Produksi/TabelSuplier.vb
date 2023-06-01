Imports System.Data.OleDb
Public Class TabelSuplier
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
        da = New OleDbDataAdapter("select * from TbSuplier", conn)
        ds = New DataSet
        da.Fill(ds, "TbSuplier")
        DGV.DataSource = ds.Tables("TbSuplier")
    End Sub
    Sub Tampildata()
        TbNamaSuplier.Text = rd.Item(1)
        TbStock.Text = rd.Item(2)
        TbAlamatSuplier.Text = rd.Item(3)
    End Sub
    Sub TextMati()
        Me.TbIdSuplier.Enabled = False
        Me.TbNamaSuplier.Enabled = False
        Me.TbStock.Enabled = False
        Me.TbAlamatSuplier.Enabled = False
    End Sub
    Sub TextHidup()
        Me.TbIdSuplier.Enabled = True
        Me.TbNamaSuplier.Enabled = True
        Me.TbStock.Enabled = True
        Me.TbAlamatSuplier.Enabled = True
    End Sub
    Sub Kosong()
        TbIdSuplier.Clear()
        TbNamaSuplier.Clear()
        TbStock.Clear()
        TbAlamatSuplier.Clear()
        TbIdSuplier.Focus()
    End Sub
    Private Sub TabelSuplier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        Me.TbIdSuplier.Focus()
        Me.BtnTambah.Enabled = False
        Me.BtnSimpan.Enabled = True
        Me.BtnEdit.Enabled = False
        Me.BtnUpdate.Enabled = False
        Me.BtnBatal.Enabled = True
        Me.BtnHapus.Enabled = False
        Me.BtnKeluar.Enabled = True
    End Sub

    Private Sub BtnSimpan_Click(sender As Object, e As EventArgs) Handles BtnSimpan.Click
        If TbIdSuplier.Text = "" Or TbNamaSuplier.Text = "" Or TbStock.Text = "" Then
            MsgBox("Data belum lengkap, Pastikan Semua form terisi")
            Exit Sub
        Else
            Call Koneksi()
            Dim simpan As String = "insert into TbSuplier (Id_Suplier, Nama_Suplier, Stock_barang, Alamat) " & " values ('" & TbIdSuplier.Text & "','" & TbNamaSuplier.Text & "','" & TbStock.Text & "','" & TbAlamatSuplier.Text & "')"
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
        TbIdSuplier.Enabled = False
        BtnTambah.Enabled = False
        BtnSimpan.Enabled = False
        BtnEdit.Enabled = False
        BtnUpdate.Enabled = True
        BtnBatal.Enabled = True
        BtnHapus.Enabled = True
        BtnKeluar.Enabled = True
    End Sub

    Private Sub TbKode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TbIdSuplier.KeyPress
        If e.KeyChar = Chr(13) Then TbNamaSuplier.Focus()
    End Sub

    Private Sub TbKode_LostFocus(sender As Object, e As EventArgs) Handles TbIdSuplier.LostFocus
        str = "SELECT * FROM TbSuplier Where Id_Suplier = '" & TbIdSuplier.Text & "'"
        cmd = New OleDbCommand(str, conn)
        rd = cmd.ExecuteReader
        Try
            While rd.Read
                TbNamaSuplier.Text = rd.GetString(1)
                TbStock.Text = rd.GetString(2)
                TbAlamatSuplier.Text = rd.GetValue(3)
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

    Private Sub TbNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TbNamaSuplier.KeyPress
        If e.KeyChar = Chr(13) Then TbStock.Focus()
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        Dim Sql As String
        If MsgBox("Do You Want save again ?", MsgBoxStyle.YesNo, "Message") = vbYes Then
            Sql = "update TbSuplier set Nama_Suplier='" & TbNamaSuplier.Text & "',Stock_Barang='" & TbStock.Text & "',Alamat='" & TbAlamatSuplier.Text & "' where Id_Suplier='" & TbIdSuplier.Text & "'"
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
        If TbIdSuplier.Text = "" Then
            MsgBox("Kode belum diisi")
            TbIdSuplier.Focus()
            Exit Sub
        Else
            If MessageBox.Show("Yakin akan dihapus..?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                Dim hapus As String = "Delete * from TbSuplier where Id_Suplier='" & TbIdSuplier.Text & "'"
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

    Private Sub TbJumlah_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TbAlamatSuplier.KeyPress
        If e.KeyChar = Chr(13) Then BtnSimpan.Focus()
    End Sub

    Private Sub TbAlamatSuplier_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TbStock.KeyPress
        If e.KeyChar = Chr(13) Then TbAlamatSuplier.Focus()
    End Sub

End Class