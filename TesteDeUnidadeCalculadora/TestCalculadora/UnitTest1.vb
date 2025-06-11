Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports TesteDeUnidadeCalculadora

<TestClass()> Public Class TestCalculadora

    <TestMethod()> Public Sub TestSomar()
        Dim calc As New Calculadora()
        Dim resultado As Double = calc.Somar(2, 3)
        Assert.AreEqual(5.5, resultado)
    End Sub

End Class