Imports info.lundin.math

Public Class IntegracionPorSimpson
    Dim k, c, n, redon, i As Integer
    Dim ec, suma, integra(2000), erro(2000), a, b, h, j, m, a1, b1, m1 As Single
    Dim g As Graphics

    Function f(x As Single) As Single
        'Librería para aceptar una función
        Dim parser As ExpressionParser
        parser = New ExpressionParser
        parser.Values.Clear()
        parser.Values.Add("x", x)
        parser.Values.Add("e", 2.7182)
        parser.Values.Add("pi", 3.1416)
        Return parser.Parse(tf.Text)
    End Function

    Private Sub Calcular_Click(sender As Object, e As EventArgs) Handles Calcular.Click
        a = ta.Text
        b = tb.Text
        c = tc.Text
        a1 = ta1.Text
        b1 = tb1.Text
        n = 4
        ec = 0.5 * 10 ^ (-c)
        redon = c + 2
        erro(i) = 1
        'h = (b - a) / n
        h = (b - a) / (2 * n)
        suma = 0
        'Cambia en posición inicial
        For k = 1 To n
            'suma = suma + (h / 2) * f(a + k * h)
            'suma = suma + f(a + k * h)
            suma = suma + ((2 * f(a + (((2 * k) - 1) * h))) + f(a + (2 * k * h)))
        Next
        'suma = (h / 2) * (f(a) + f(b) + (2 * suma))
        suma = (h / 3) * (f(a) - f(b) + (2 * suma))
        integra(i) = suma
        'imprime en renglones         
        salida.Rows.Add(n, Math.Round(integra(i), redon), Math.Round(erro(i), redon))
        Do While erro(i) > ec
            n = n + 4
            i = i + 1
            'h = (b - a) / n
            h = (b - a) / (2 * n)
            suma = 0
            For k = 1 To n
                'suma = suma + (h / 2) * f(a + k * h)
                'suma = suma + f(a + k * h)
                suma = suma + ((2 * f(a + (((2 * k) - 1) * h))) + f(a + (2 * k * h)))
            Next
            'suma = (h / 2) * (f(a) + f(b) + (2 * suma))
            suma = (h / 3) * (f(a) - f(b) + (2 * suma))
            integra(i) = suma
            erro(i) = Math.Abs((integra(i) - integra(i - 1)) / integra(i))

            salida.Rows.Add(n, Math.Round(integra(i), redon), Math.Round(erro(i), redon))
        Loop
    End Sub

    Private Sub Graficar_Click(sender As Object, e As EventArgs) Handles Graficar.Click
        'gráfica de la función         
        g = Graf.CreateGraphics()
        j = a1
        Do While j <= b1
            Graf.Series(0).Points.AddXY(Math.Round(j, 1), f(j))
            j = j + 0.1
        Loop
        m = a
        'gráfica de el área sombreada         
        Do While m <= b
            Graf.Series(1).Points.AddXY(Math.Round(m, 1), f(m))
            m = m + 0.1
        Loop
    End Sub

    Private Sub Limpiar_Click(sender As Object, e As EventArgs) Handles Limpiar.Click
        'limpia cajas de textos y demás         
        ta.Clear() : tb.Clear() : tc.Clear() : ta1.Clear() : tb1.Clear() : tc.Clear() : Graf.Series(0).Points.Clear() : Graf.Series(1).Points.Clear() : salida.Rows.Clear() : tf.Clear()
    End Sub

    Private Sub Salir_Click(sender As Object, e As EventArgs) Handles Salir.Click

    End Sub
End Class