Imports MySql.Data.MySqlClient

Module Module1
    Public CONN As MySqlConnection
    Public CMD As MySqlCommand
    Public RD As MySqlDataReader
    Public DA As MySqlDataAdapter
    Public DS As DataSet
    Public STR As String
    Sub koneksi()
        Try
            Dim STR As String =
            "server=localhost;userid=root;password=;database=PeminjamanPT5"
            'Ganti nama database sesuaikan dengan nama database kalian
            CONN = New MySqlConnection(STR)
            If CONN.State = ConnectionState.Closed Then
                CONN.Open()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Module

Public Class Form1
    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Me.Close()
        MenuAwal.Show()
    End Sub

    Private Sub BtnNote_Click(sender As Object, e As EventArgs) Handles BtnNote.Click
        Catatan.Show()
    End Sub

    Sub kosong()
        TxtAlamat.Clear()
        TxtNama.Clear()
        TxtKode.Clear()
        TxtNomor.Clear()
        TxtJumlah.Clear()
        DateTimePicker1.Value = DateTime.Now
        PictureBox1.ImageLocation = Nothing
    End Sub

    Function PeriksaKosong()
        If TxtAlamat.Text = "" Then
            MessageBox.Show("Alamat harus diisi", "WARNING",
            MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf TxtNama.Text = "" Then
            MessageBox.Show("Nama harus diisi", "WARNING",
            MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf TxtJumlah.Text = "" Then
            MessageBox.Show("Jumlah harus diisi", "WARNING",
            MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf TxtKode.Text = "" Then
            MessageBox.Show("Kode harus diisi", "WARNING",
            MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf TxtNomor.Text = "" Then
            MessageBox.Show("Nomor harus diisi", "WARNING",
            MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf StatusBox.Text = "" Then
            MessageBox.Show("Status harus diisi", "WARNING",
            MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf PictureBox1.Image Is Nothing Then
            MessageBox.Show("Gambar harus diisi", "WARNING",
            MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Return True
        End If
        Return False
    End Function

    Sub TampilGrid()
        DA = New MySqlDataAdapter("select * from tbPeminjaman", CONN)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "jenis")
        DataGridView1.DataSource = DS.Tables("jenis")
        DataGridView1.Refresh()
    End Sub

    Sub aturGrid()
        If DataGridView1.Columns.Count < 6 Then
            MessageBox.Show("DataGridView harus memiliki setidaknya 6 kolom!")
            Exit Sub
        End If

        DataGridView1.Columns(0).Width = 50
        DataGridView1.Columns(1).Width = 150
        DataGridView1.Columns(2).Width = 150
        DataGridView1.Columns(3).Width = 50
        DataGridView1.Columns(4).Width = 230
        DataGridView1.Columns(5).Width = 100
        DataGridView1.Columns(6).Width = 150
        DataGridView1.Columns(7).Width = 230

        DataGridView1.Columns(0).HeaderText = "Kode"
        DataGridView1.Columns(1).HeaderText = "Status Pembayaran"
        DataGridView1.Columns(2).HeaderText = "Nama"
        DataGridView1.Columns(3).HeaderText = "Jumlah"
        DataGridView1.Columns(4).HeaderText = "Alamat"
        DataGridView1.Columns(5).HeaderText = "Nomor"
        DataGridView1.Columns(6).HeaderText = "Tanggal"
        DataGridView1.Columns(7).HeaderText = "Foto"
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance)
        koneksi()
        kosong()
        TampilGrid()
        aturGrid()
    End Sub

    Private Sub BtnGambar_Click(sender As Object, e As EventArgs) Handles BtnGambar.Click
        SimpanGambar.Filter = "PNG Image|*.png|JPG Image|*.jpg"
        If SimpanGambar.ShowDialog() = DialogResult.OK Then
            PictureBox1.ImageLocation = SimpanGambar.FileName
        End If
    End Sub

    Private Sub BtnSimpan_Click(sender As Object, e As EventArgs) Handles BtnSimpan.Click
        'If PeriksaKosong() = False Then
        '    MsgBox("Data Belum Lengkap")
        '    TxtKode.Focus()
        '    Return
        'End If
        If PeriksaKosong() = False Then
            MsgBox("Data Belum Lengkap")
            TxtKode.Focus()
            Return
        End If
        If TxtKode.Text = Nothing And TxtNama.Text = Nothing And TxtAlamat.Text = Nothing And TxtNomor.Text = Nothing And PictureBox1.Image Is Nothing Then
            MsgBox("Data Belum Lengkap")
            TxtKode.Focus()
        Else
            CMD = New MySqlCommand("Select * from tbPeminjaman where kode = '" &
            TxtKode.Text & "'", CONN)
            RD = CMD.ExecuteReader
            RD.Read()
            If Not RD.HasRows Then
                RD.Close()
                CMD = New MySqlCommand("INSERT INTO tbPeminjaman VALUES (@kode,@status ,@nama, @jumlah, @alamat, @nomor, @tanggal, @foto)", CONN)
                CMD.Parameters.AddWithValue("@kode", TxtKode.Text)
                CMD.Parameters.AddWithValue("@nama", TxtNama.Text)
                CMD.Parameters.AddWithValue("@jumlah", TxtJumlah.Text)
                CMD.Parameters.AddWithValue("@alamat", TxtAlamat.Text)
                CMD.Parameters.AddWithValue("@nomor", TxtNomor.Text)
                CMD.Parameters.AddWithValue("@tanggal", DateTimePicker1.Value)
                CMD.Parameters.AddWithValue("@foto", PictureBox1.ImageLocation)
                CMD.Parameters.AddWithValue("@status", StatusBox.Text)
                CMD.ExecuteNonQuery()
                kosong()
                TampilGrid()
                MsgBox("Simpan Data Sukses!")
            Else
                RD.Close()
                MsgBox("Data Tersebut Sudah Ada")
            End If
        End If
    End Sub
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If DataGridView1.SelectedRows.Count > 0 Then
            Dim row As DataGridViewRow = DataGridView1.SelectedRows(0)
            If row.Index < DataGridView1.RowCount - 1 And row.Index >= 0 Then
                TxtKode.Text = row.Cells(0).Value
                StatusBox.Text = row.Cells(1).Value
                'StatusBox.Text = "Belum Bayar"
                TxtNama.Text = row.Cells(2).Value
                TxtJumlah.Text = row.Cells(3).Value
                TxtAlamat.Text = row.Cells(4).Value
                TxtNomor.Text = row.Cells(5).Value
                DateTimePicker1.Value = row.Cells(6).Value
                PictureBox1.ImageLocation = row.Cells(7).Value
            End If
        End If
    End Sub

    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click
        If TxtKode.Text = Nothing Then
            MsgBox("Kode Pinjaman belum diisi")
            TxtKode.Focus()
        Else
            CMD = New MySqlCommand("delete From tbPeminjaman Where kode = (@kode)", CONN)
            CMD.Parameters.AddWithValue("@kode", TxtKode.Text)
            CMD.ExecuteNonQuery()
            TampilGrid()
            MsgBox("Data berhasil dihapus")
            kosong()
        End If
    End Sub

    Private Sub BtnUbah_Click(sender As Object, e As EventArgs) Handles BtnUbah.Click
        If TxtKode.Text = Nothing Then
            MsgBox("Kode Buku belum diisi")
            TxtKode.Focus()
        Else
            Dim ubah As String = "update tbPeminjaman set kode = (@kode), Nama = (@nama), 
Jumlah = (@jumlah), Alamat = (@alamat), Nomor = (@nomor), Tanggal = (@tanggal), Foto = (@foto), Status = (@status) where kode = (@kode)"
            CMD = New MySqlCommand(ubah, CONN)
            CMD.Parameters.AddWithValue("@kode", TxtKode.Text)
            CMD.Parameters.AddWithValue("@nama", TxtNama.Text)
            CMD.Parameters.AddWithValue("@jumlah", TxtJumlah.Text)
            CMD.Parameters.AddWithValue("@alamat", TxtAlamat.Text)
            CMD.Parameters.AddWithValue("@nomor", TxtNomor.Text)
            CMD.Parameters.AddWithValue("@tanggal", DateTimePicker1.Value)
            CMD.Parameters.AddWithValue("@foto", PictureBox1.ImageLocation)
            CMD.Parameters.AddWithValue("@status", StatusBox.Text)
            CMD.ExecuteNonQuery()
            TampilGrid()
            MsgBox("Data berhasil diubah")
            kosong()
        End If
    End Sub

    Private Sub TxtCari_TextChanged(sender As Object, e As EventArgs) Handles TxtCari.TextChanged
        If TxtCari.Text <> Nothing Then
            Try
                DA = New MySqlDataAdapter("select * from tbPeminjaman where kode like @kode", CONN)
                DA.SelectCommand.Parameters.AddWithValue("@kode", "%" & TxtCari.Text & "%")
                DS = New DataSet
                DS.Clear()
                DA.Fill(DS, "Dapat")
                DataGridView1.DataSource = DS.Tables("Dapat")
                DataGridView1.ReadOnly = True
            Catch ex As Exception
                MessageBox.Show("Data masih kosong")
            End Try
        Else
            TampilGrid()
        End If
    End Sub

    Private Sub BtnBatal_Click(sender As Object, e As EventArgs) Handles BtnBatal.Click
        kosong()
        TampilGrid()
    End Sub

    Private Sub TxtKode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtKode.KeyPress
        TxtKode.MaxLength = 3
        Dim keyascii As Short = Asc(e.KeyChar)
        If (e.KeyChar Like “[0-9]” OrElse keyascii = Keys.Back) Then
            keyascii = 0
        Else
            e.Handled = CBool(keyascii)
        End If
    End Sub

    Private Sub TxtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtNama.KeyPress
        TxtNama.MaxLength = 50
        Dim keyascii As Short = Asc(e.KeyChar)
        If (e.KeyChar Like “[a-z, A-Z]” _
        OrElse keyascii = Keys.Back _
        OrElse keyascii = Keys.Space _
        OrElse keyascii = Keys.Return _
        OrElse keyascii = Keys.Delete) Then
            keyascii = 0
        Else
            e.Handled = CBool(keyascii)
        End If
    End Sub
    Private Sub TxtNomor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtNomor.KeyPress
        TxtNomor.MaxLength = 15
        Dim keyascii As Short = Asc(e.KeyChar)
        If (e.KeyChar Like “[0-9]” OrElse keyascii = Keys.Back) Then
            keyascii = 0
        Else
            e.Handled = CBool(keyascii)
        End If
    End Sub
    Private Sub TxtJumlah_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtJumlah.KeyPress
        Dim keyascii As Short = Asc(e.KeyChar)
        If (e.KeyChar Like “[0-9]” OrElse keyascii = Keys.Back) Then
            keyascii = 0
        Else
            e.Handled = CBool(keyascii)
        End If
    End Sub
    Private Sub TxtAlamat_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtAlamat.KeyPress
        TxtAlamat.MaxLength = 100
        Dim keyascii As Short = Asc(e.KeyChar)
        If (e.KeyChar Like “[a-z, A-Z]” _
        OrElse keyascii = Keys.Back _
        OrElse keyascii = Keys.Space _
        OrElse keyascii = Keys.Return _
        OrElse keyascii = Keys.Delete) Then
            keyascii = 0
        Else
            e.Handled = CBool(keyascii)
        End If
    End Sub
End Class
