Public Class Calculadora
    Public Function Somar(a As Integer, b As Integer) As Double
        Dim soma As Integer = a + b
        Dim resultado As Double = AdicionaPorcentagem(soma)
        Return resultado
    End Function

    Public Function AdicionaPorcentagem(a As Integer) As Double
        Return a * 1.1
    End Function
End Class
