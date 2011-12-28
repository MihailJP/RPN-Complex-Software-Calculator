' 電卓の処理部分

Module Calculator

    Public Function FailproofLog10(ByVal Value As Double) As Double
        If Value = 0 Then
            Return 0
        Else
            Return Math.Log10(Math.Abs(Value))
        End If
    End Function

    Private Sub CancelVal(ByRef ValueStack As CalcStack)
        Dim dummy As Complex = ValueStack.Pop
        ValueStack.Push(0)
    End Sub

    Public Sub Add(ByRef ValueStack As CalcStack)
        Dim Addend As Complex = ValueStack.Pop
        Dim Augend As Complex = ValueStack.Pop

        ValueStack.Push(Augend + Addend)
    End Sub

    Public Sub Subtract(ByRef ValueStack As CalcStack)
        Dim Subtrahend As Complex = ValueStack.Pop
        Dim Minuend As Complex = ValueStack.Pop
        ValueStack.Push(Minuend - Subtrahend)
    End Sub

    Public Sub Multiply(ByRef ValueStack As CalcStack)
        Dim Multiplier As Complex = ValueStack.Pop
        Dim Multiplicand As Complex = ValueStack.Pop
        ValueStack.Push(Multiplicand * Multiplier)
    End Sub

    Public Sub Divide(ByRef ValueStack As CalcStack)
        Dim Divisor As Complex = ValueStack.Pop
        Dim Dividend As Complex = ValueStack.Pop
        ValueStack.Push(Dividend / Divisor)
    End Sub

    Public Sub Log(ByRef ValueStack As CalcStack)
        Dim Antilogarithm As Complex = ValueStack.Pop
        ValueStack.Push(Complex.Log(Antilogarithm))
    End Sub

    Public Sub Exp(ByRef ValueStack As CalcStack)
        Dim Exponent As Complex = ValueStack.Pop
        ValueStack.Push(Complex.Exp(Exponent))
    End Sub

    Public Sub Log10(ByRef ValueStack As CalcStack)
        Dim Antilogarithm As Complex = ValueStack.Pop
        ValueStack.Push(Complex.Log10(Antilogarithm))
    End Sub

    Public Sub Exp10(ByRef ValueStack As CalcStack)
        Dim Exponent As Complex = ValueStack.Pop
        ValueStack.Push(Complex.Pow(10, Exponent))
    End Sub

    Public Sub Square(ByRef ValueStack As CalcStack)
        Dim Base As Complex = ValueStack.Pop
        ValueStack.Push(Complex.Pow(Base, 2))
    End Sub

    Public Sub Sqrt(ByRef ValueStack As CalcStack)
        Dim Base As Complex = ValueStack.Pop
        ValueStack.Push(Complex.Sqrt(Base))
    End Sub

    Public Sub Pow(ByRef ValueStack As CalcStack)
        Dim Exponent As Complex = ValueStack.Pop
        Dim Base As Complex = ValueStack.Pop
        ValueStack.Push(Complex.Pow(Base, Exponent))
    End Sub

    Public Sub Invert(ByRef ValueStack As CalcStack)
        Dim value As Complex = ValueStack.Pop
        ValueStack.Push(1 / value)
    End Sub

    Private Sub RoundVal(ByRef ValueStack As CalcStack)
        ' 三角関数とかだと誤差が出るので計算機イプシロン未満の値だったら0とみなす
        Dim value As Complex = ValueStack.Pop
        If Math.Abs(value.Real) < 0.0000000000000002 Then value.Real = 0
        'value.Real = Math.Round(value.Real * 1000000000000.0) / 1000000000000.0
        ValueStack.Push(value)
    End Sub

    Public Sub Sin(ByRef ValueStack As CalcStack)
        Dim Angle As Complex = ValueStack.Pop
        ValueStack.Push(Complex.Sin(Angle))
        RoundVal(ValueStack)
    End Sub

    Public Sub Cos(ByRef ValueStack As CalcStack)
        Dim Angle As Complex = ValueStack.Pop
        ValueStack.Push(Complex.Cos(Angle))
        RoundVal(ValueStack)
    End Sub

    Public Sub Tan(ByRef ValueStack As CalcStack)
        Dim Angle As Complex = ValueStack.Pop
        ValueStack.Push(Complex.Tan(Angle))
        RoundVal(ValueStack)
    End Sub

    Public Sub Arcsin(ByRef ValueStack As CalcStack)
        Dim value As Complex = ValueStack.Pop
        ValueStack.Push(Complex.Asin(value))
        'End If
    End Sub

    Public Sub Arccos(ByRef ValueStack As CalcStack)
        Dim value As Complex = ValueStack.Pop
        ValueStack.Push(Complex.Acos(value))
        RoundVal(ValueStack)
    End Sub

    Public Sub Arctan(ByRef ValueStack As CalcStack)
        Dim value As Complex = ValueStack.Pop
        ValueStack.Push(Complex.Atan(value))
        RoundVal(ValueStack)
    End Sub

    Public Sub Sinh(ByRef ValueStack As CalcStack)
        Dim Area As Complex = ValueStack.Pop
        ValueStack.Push(Complex.Sinh(Area))
        RoundVal(ValueStack)
    End Sub

    Public Sub Cosh(ByRef ValueStack As CalcStack)
        Dim Area As Complex = ValueStack.Pop
        ValueStack.Push(Complex.Cosh(Area))
        RoundVal(ValueStack)
    End Sub

    Public Sub Tanh(ByRef ValueStack As CalcStack)
        Dim Area As Complex = ValueStack.Pop
        ValueStack.Push(Complex.Tanh(Area))
        RoundVal(ValueStack)
    End Sub

    Public Sub Arsinh(ByRef ValueStack As CalcStack)
        Dim value As Complex = ValueStack.Pop
        ValueStack.Push(Complex.Asinh(value))
        RoundVal(ValueStack)
    End Sub

    Public Sub Arcosh(ByRef ValueStack As CalcStack)
        Dim value As Complex = ValueStack.Pop
        ValueStack.Push(Complex.Acosh(value))
        RoundVal(ValueStack)
    End Sub

    Public Sub Artanh(ByRef ValueStack As CalcStack)
        Dim value As Complex = ValueStack.Pop
        ValueStack.Push(Complex.Atanh(value))
        RoundVal(ValueStack)
    End Sub

    Public Sub Factorial(ByRef ValueStack As CalcStack)
        Dim value As Complex = ValueStack.Pop
        ValueStack.Push(Complex.Gamma(value + 1))
    End Sub

    Public Sub Absolute(ByRef ValueStack As CalcStack)
        Dim value As Complex = ValueStack.Pop
        ValueStack.Push(value.Absolute)
    End Sub

    Public Sub Argument(ByRef ValueStack As CalcStack)
        Dim value As Complex = ValueStack.Pop
        ValueStack.Push(value.Argument)
    End Sub

    Public Sub Conjugate(ByRef ValueStack As CalcStack)
        Dim value As Complex = ValueStack.Pop
        ValueStack.Push(value.Conjugate)
    End Sub
End Module
