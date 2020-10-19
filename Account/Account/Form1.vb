Public Class Form1

    Private Sub txtSearch_MouseEnter(sender As Object, e As EventArgs) Handles txtSearch.MouseEnter
        If txtSearch.Text = "search data by PR or Description" Then
            txtSearch.Text = ""
            txtSearch.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtSearch_MouseLeave(sender As Object, e As EventArgs) Handles txtSearch.MouseLeave
        If txtSearch.Text = "" Then
            txtSearch.Text = "search data by PR or Description"
            txtSearch.ForeColor = Color.Blue
        End If
    End Sub
End Class
