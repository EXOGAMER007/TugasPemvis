<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Catatan
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
        BtnKembali = New Button()
        Label1 = New Label()
        TxtCatatan = New TextBox()
        SuspendLayout()
        ' 
        ' BtnKembali
        ' 
        BtnKembali.Location = New Point(12, 12)
        BtnKembali.Name = "BtnKembali"
        BtnKembali.Size = New Size(175, 29)
        BtnKembali.TabIndex = 0
        BtnKembali.Text = "Kembali dan Simpan"
        BtnKembali.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 44)
        Label1.Name = "Label1"
        Label1.Size = New Size(340, 20)
        Label1.TabIndex = 1
        Label1.Text = "Silakan tulisan catatan yang ingin anda tinggalkan" & vbCrLf
        ' 
        ' TxtCatatan
        ' 
        TxtCatatan.Location = New Point(12, 67)
        TxtCatatan.Multiline = True
        TxtCatatan.Name = "TxtCatatan"
        TxtCatatan.Size = New Size(438, 650)
        TxtCatatan.TabIndex = 2
        TxtCatatan.Text = "sih peminjam nomor 3 sering menunggak. dia sudah telat bayar 2x selama peminjam"
        ' 
        ' Catatan
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(462, 807)
        Controls.Add(TxtCatatan)
        Controls.Add(Label1)
        Controls.Add(BtnKembali)
        FormBorderStyle = FormBorderStyle.FixedDialog
        Name = "Catatan"
        Text = "Note"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents BtnKembali As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtCatatan As TextBox
End Class
