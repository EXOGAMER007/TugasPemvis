Imports MySql.Data.MySqlClient

Public Class Catatan
    Private Sub BtnKembali_Click(sender As Object, e As EventArgs) Handles BtnKembali.Click

        Dim ubah As String = "update tbnote set Note = (@note) where id = @id"
        CMD = New MySqlCommand(ubah, CONN)
        CMD.Parameters.AddWithValue("@id", "1")
        CMD.Parameters.AddWithValue("@note", TxtCatatan.Text)
        CMD.ExecuteNonQuery()
        Me.Close()
    End Sub

    Private Sub Catatan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CMD = New MySqlCommand("select Note from tbnote where id = @id", CONN)
        CMD.Parameters.AddWithValue("@id", "1")
        TxtCatatan.Text = ""
        Dim result As Object = CMD.ExecuteScalar()
        TxtCatatan.Text = result
    End Sub
End Class