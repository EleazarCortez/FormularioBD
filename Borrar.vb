Public Class Borrar
    Private Sub Borrar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub btnSalirB_Click(sender As Object, e As EventArgs) Handles btnSalirB.Click
        Hide()
        Dim a As Form3 = New Form3()
        a.Show()
    End Sub
End Class