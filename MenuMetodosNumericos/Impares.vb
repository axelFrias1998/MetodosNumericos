Public Class Impares

    Dim fin As Integer
    Dim k As Integer
    Dim impar As Integer

    Private Sub Calcular_Click(sender As Object, e As EventArgs) Handles Calcular.Click
        fin = Tn.Text
        For k = 1 To fin
            impar = 2 * k - 1
            Salida.Rows.Add(k, impar)
        Next
    End Sub
End Class