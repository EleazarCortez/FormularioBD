Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnEntrarR_Click(sender As Object, e As EventArgs) Handles btnEntrarR.Click
        Hide()
        Dim a As Entrada_y_salida = New Entrada_y_salida()
        a.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Hide()
        Dim a As Form11 = New Form11()
        a.Show()
    End Sub
End Class
