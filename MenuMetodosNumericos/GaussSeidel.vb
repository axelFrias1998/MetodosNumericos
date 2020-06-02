Public Class GaussSeidel
    Dim x(50), y(50), z(50) As Single
    Dim ec, ex(50), ey(50), ez(50) As Single
    Dim i, k, c, redon As Integer

    Private Sub Calcular_Click(sender As Object, e As EventArgs) Handles Calcular.Click
        i = 0
        c = tc.Text
        redon = c + 2
        ec = 0.5 * 10 ^ (-c)
        ex(i) = 1
        ey(i) = 1
        ez(i) = 1
        Salida.Rows.Add(i, Math.Round(x(i), redon), Math.Round(y(i), redon), Math.Round(z(i), redon), "-------------", "-------------", "-------------")

        Do While ex(i) > ec Or ey(i) > ec Or ez(i) > ec
            i = i + 1
            x(i) = (b1.Text - a12.Text * y(i - 1) - a13.Text * z(i - 1)) / a11.Text
            y(i) = (b2.Text - a21.Text * x(i) - a23.Text * z(i - 1)) / a22.Text
            z(i) = (b3.Text - a31.Text * x(i) - a32.Text * y(i)) / a33.Text
            ex(i) = Math.Abs((x(i) - x(i - 1)) / x(i))
            ey(i) = Math.Abs((y(i) - y(i - 1)) / y(i))
            ez(i) = Math.Abs((z(i) - z(i - 1)) / z(i))
            Salida.Rows.Add(i, Math.Round(x(i), redon), Math.Round(y(i), redon), Math.Round(z(i), redon), Math.Round(ex(i), redon), Math.Round(ey(i), redon), Math.Round(ez(i), redon))
        Loop
        b1.Text = Math.Round(x(i), redon)
        b2.Text = Math.Round(y(i), redon)
        b3.Text = Math.Round(z(i), redon)
    End Sub

    Private Sub Limpiar_Click(sender As Object, e As EventArgs) Handles Limpiar.Click
        a11.Clear() : a12.Clear() : a13.Clear() : a21.Clear() : a22.Clear() : a23.Clear()
        a31.Clear() : a32.Clear() : a33.Clear() : b1.Clear() : b2.Clear() : b3.Clear()
        tc.Clear() : Salida.Rows.Clear()
    End Sub
End Class