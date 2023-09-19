Public Class Form1
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub btndoc_Click(sender As Object, e As EventArgs) Handles btndoc.Click
        Dim tenfile As String
        tenfile = txttenfile.Text
        Dim sr As System.IO.StreamReader
        sr = New System.IO.StreamReader("D:\\" & tenfile)
        txtnoidung.Text = sr.ReadToEnd()
        sr.Close()
    End Sub
End Class
