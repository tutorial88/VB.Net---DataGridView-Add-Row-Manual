Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        AddRow(GRID1)
    End Sub
    Sub AddRow(GRID As DataGridView)
        Dim StringRow As String()

        StringRow = New String() {TextBox1.Text, TextBox2.Text}
        GRID.Rows.Add(StringRow)

        TextBox1.Text = ""
        TextBox2.Text = ""
    End Sub
End Class
