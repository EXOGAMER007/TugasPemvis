<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        TxtKode = New TextBox()
        TxtNama = New TextBox()
        TxtNomor = New TextBox()
        TxtAlamat = New TextBox()
        BtnSimpan = New Button()
        BtnHapus = New Button()
        BtnUbah = New Button()
        BtnBatal = New Button()
        Label6 = New Label()
        DataGridView1 = New DataGridView()
        PictureBox1 = New PictureBox()
        SimpanGambar = New SaveFileDialog()
        BtnGambar = New Button()
        DateTimePicker1 = New DateTimePicker()
        Label7 = New Label()
        BtnExit = New Button()
        BtnNote = New Button()
        Label8 = New Label()
        TxtJumlah = New TextBox()
        Label10 = New Label()
        TxtCari = New TextBox()
        Label9 = New Label()
        StatusBox = New ComboBox()
        Label11 = New Label()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(0, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(0, 20)
        Label1.TabIndex = 0
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(11, 47)
        Label2.Name = "Label2"
        Label2.Size = New Size(109, 20)
        Label2.TabIndex = 1
        Label2.Text = "Kode Pinjaman"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(11, 78)
        Label3.Name = "Label3"
        Label3.Size = New Size(118, 20)
        Label3.TabIndex = 2
        Label3.Text = "Nama Peminjam"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(11, 111)
        Label4.Name = "Label4"
        Label4.Size = New Size(79, 20)
        Label4.TabIndex = 3
        Label4.Text = "Nomor HP"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(11, 144)
        Label5.Name = "Label5"
        Label5.Size = New Size(126, 20)
        Label5.TabIndex = 4
        Label5.Text = "Alamat Peminjam"
        ' 
        ' TxtKode
        ' 
        TxtKode.Location = New Point(141, 44)
        TxtKode.Name = "TxtKode"
        TxtKode.Size = New Size(250, 27)
        TxtKode.TabIndex = 5
        ' 
        ' TxtNama
        ' 
        TxtNama.Location = New Point(141, 78)
        TxtNama.Name = "TxtNama"
        TxtNama.Size = New Size(250, 27)
        TxtNama.TabIndex = 6
        ' 
        ' TxtNomor
        ' 
        TxtNomor.Location = New Point(141, 111)
        TxtNomor.Name = "TxtNomor"
        TxtNomor.Size = New Size(250, 27)
        TxtNomor.TabIndex = 7
        ' 
        ' TxtAlamat
        ' 
        TxtAlamat.Location = New Point(141, 144)
        TxtAlamat.Name = "TxtAlamat"
        TxtAlamat.Size = New Size(250, 27)
        TxtAlamat.TabIndex = 8
        ' 
        ' BtnSimpan
        ' 
        BtnSimpan.Location = New Point(10, 258)
        BtnSimpan.Name = "BtnSimpan"
        BtnSimpan.Size = New Size(94, 29)
        BtnSimpan.TabIndex = 9
        BtnSimpan.Text = "Simpan"
        BtnSimpan.UseVisualStyleBackColor = True
        ' 
        ' BtnHapus
        ' 
        BtnHapus.Location = New Point(126, 258)
        BtnHapus.Name = "BtnHapus"
        BtnHapus.Size = New Size(94, 29)
        BtnHapus.TabIndex = 10
        BtnHapus.Text = "Hapus"
        BtnHapus.UseVisualStyleBackColor = True
        ' 
        ' BtnUbah
        ' 
        BtnUbah.Location = New Point(246, 258)
        BtnUbah.Name = "BtnUbah"
        BtnUbah.Size = New Size(94, 29)
        BtnUbah.TabIndex = 11
        BtnUbah.Text = "Ubah"
        BtnUbah.UseVisualStyleBackColor = True
        ' 
        ' BtnBatal
        ' 
        BtnBatal.Location = New Point(374, 258)
        BtnBatal.Name = "BtnBatal"
        BtnBatal.Size = New Size(94, 29)
        BtnBatal.TabIndex = 12
        BtnBatal.Text = "Batal"
        BtnBatal.UseVisualStyleBackColor = True
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("ROG Fonts", 16F)
        Label6.Location = New Point(107, 9)
        Label6.Name = "Label6"
        Label6.Size = New Size(539, 32)
        Label6.TabIndex = 13
        Label6.Text = "Yayasan Peminjam SihCepat"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(12, 293)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(918, 188)
        DataGridView1.TabIndex = 14
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = My.Resources.Resources.l60Hf
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.BorderStyle = BorderStyle.FixedSingle
        PictureBox1.Location = New Point(600, 44)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(296, 186)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 15
        PictureBox1.TabStop = False
        ' 
        ' BtnGambar
        ' 
        BtnGambar.Location = New Point(706, 236)
        BtnGambar.Name = "BtnGambar"
        BtnGambar.Size = New Size(94, 29)
        BtnGambar.TabIndex = 16
        BtnGambar.Text = "Masukan"
        BtnGambar.UseVisualStyleBackColor = True
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(141, 210)
        DateTimePicker1.MinDate = New Date(2025, 4, 17, 0, 0, 0, 0)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(250, 27)
        DateTimePicker1.TabIndex = 17
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(11, 210)
        Label7.Name = "Label7"
        Label7.Size = New Size(102, 20)
        Label7.TabIndex = 18
        Label7.Text = "Tanggal Bayar"
        ' 
        ' BtnExit
        ' 
        BtnExit.Location = New Point(836, 9)
        BtnExit.Name = "BtnExit"
        BtnExit.Size = New Size(94, 29)
        BtnExit.TabIndex = 19
        BtnExit.Text = "Exit"
        BtnExit.UseVisualStyleBackColor = True
        ' 
        ' BtnNote
        ' 
        BtnNote.Location = New Point(451, 87)
        BtnNote.Name = "BtnNote"
        BtnNote.Size = New Size(94, 29)
        BtnNote.TabIndex = 21
        BtnNote.Text = "Catatan"
        BtnNote.UseVisualStyleBackColor = True
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(411, 44)
        Label8.Name = "Label8"
        Label8.Size = New Size(172, 40)
        Label8.TabIndex = 22
        Label8.Text = "Jika ingin meninggalkan " & vbCrLf & "catatan penting"
        ' 
        ' TxtJumlah
        ' 
        TxtJumlah.Location = New Point(141, 177)
        TxtJumlah.Name = "TxtJumlah"
        TxtJumlah.Size = New Size(250, 27)
        TxtJumlah.TabIndex = 24
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(11, 177)
        Label10.Name = "Label10"
        Label10.Size = New Size(134, 20)
        Label10.TabIndex = 23
        Label10.Text = "Jumlah Pinjam(RP.)"
        ' 
        ' TxtCari
        ' 
        TxtCari.Location = New Point(411, 212)
        TxtCari.Name = "TxtCari"
        TxtCari.Size = New Size(133, 27)
        TxtCari.TabIndex = 25
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(411, 180)
        Label9.Name = "Label9"
        Label9.Size = New Size(126, 20)
        Label9.TabIndex = 26
        Label9.Text = "Cari dengan kode"
        ' 
        ' StatusBox
        ' 
        StatusBox.DropDownStyle = ComboBoxStyle.DropDownList
        StatusBox.FormattingEnabled = True
        StatusBox.Items.AddRange(New Object() {"Belum Bayar", "Sudah Bayar"})
        StatusBox.Location = New Point(411, 143)
        StatusBox.Name = "StatusBox"
        StatusBox.Size = New Size(151, 28)
        StatusBox.TabIndex = 27
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(411, 120)
        Label11.Name = "Label11"
        Label11.Size = New Size(134, 20)
        Label11.TabIndex = 28
        Label11.Text = "Status Peminjaman"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(942, 493)
        Controls.Add(Label11)
        Controls.Add(StatusBox)
        Controls.Add(Label9)
        Controls.Add(TxtCari)
        Controls.Add(TxtJumlah)
        Controls.Add(Label10)
        Controls.Add(Label8)
        Controls.Add(BtnNote)
        Controls.Add(BtnExit)
        Controls.Add(Label7)
        Controls.Add(DateTimePicker1)
        Controls.Add(BtnGambar)
        Controls.Add(PictureBox1)
        Controls.Add(DataGridView1)
        Controls.Add(Label6)
        Controls.Add(BtnBatal)
        Controls.Add(BtnUbah)
        Controls.Add(BtnHapus)
        Controls.Add(BtnSimpan)
        Controls.Add(TxtAlamat)
        Controls.Add(TxtNomor)
        Controls.Add(TxtNama)
        Controls.Add(TxtKode)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.FixedDialog
        Name = "Form1"
        Text = "Manajemen Peminjaman"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtKode As TextBox
    Friend WithEvents TxtNama As TextBox
    Friend WithEvents TxtNomor As TextBox
    Friend WithEvents TxtAlamat As TextBox
    Friend WithEvents BtnSimpan As Button
    Friend WithEvents BtnHapus As Button
    Friend WithEvents BtnUbah As Button
    Friend WithEvents BtnBatal As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents SimpanGambar As SaveFileDialog
    Friend WithEvents BtnGambar As Button
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents BtnExit As Button
    Friend WithEvents BtnNote As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents TxtJumlah As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TxtCari As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents StatusBox As ComboBox
    Friend WithEvents Label11 As Label

End Class
