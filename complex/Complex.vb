' 複素数を構造体として定義

Public Structure Complex : Implements IFormattable
    ' 内部データは直交形式
    Public Real As Double
    Public Imaginary As Double

    ' 極形式で取得または代入ができる

#Region "Polar"
    ' 絶対値
    Public Property Absolute As Double
        Get
            Return Math.Sqrt(Real * Real + Imaginary * Imaginary)
        End Get
        Set(ByVal value As Double)
            Dim Theta = Me.Argument
            Real = value * Math.Cos(Theta)
            Imaginary = value * Math.Sin(Theta)
        End Set
    End Property
    ' 偏角
    Public Property Argument As Double
        Get
            If Real <> 0 Then
                Return Math.Atan2(Imaginary, Real)
            ElseIf Imaginary > 0 Then
                Return Math.PI / 2
            ElseIf Imaginary < 0 Then
                Return (-Math.PI) / 2
            Else
                Return 0
            End If
        End Get
        Set(ByVal value As Double)
            Dim R = Me.Absolute
            Real = R * Math.Cos(value)
            Imaginary = R * Math.Sin(value)
        End Set
    End Property
#End Region

    ' 共軛複素数を返す
    Public Function Conjugate() As Complex
        Return Me.Real - i * Me.Imaginary
    End Function

    ' 文字列への変換
#Region "ToString"
    Public Overrides Function ToString() As String
        Return Me.ToString("G", CultureInfo.CurrentCulture)
    End Function

    Public Overloads Function ToString(ByVal format As String) As String
        Return Me.ToString(format, CultureInfo.CurrentCulture)
    End Function

    Public Overloads Function ToString(ByVal format As String, ByVal formatProvider As IFormatProvider) _
        As String Implements IFormattable.ToString

        If (Me.Real <> 0) And (Me.Imaginary <> 0) Then
            Dim LinkString As String = ""
            Dim tmpstr = Me.Imaginary.ToString(format, formatProvider)
            If (Left(tmpstr, 1) <> "+") And (Me.Imaginary > 0) Then
                LinkString = "+"
            ElseIf (Left(tmpstr, 1) <> "-") And (Me.Imaginary < 0) Then
                LinkString = "-"
            End If
            Return Me.Real.ToString(format, formatProvider) & LinkString & tmpstr & "i"
        ElseIf (Me.Imaginary <> 0) Then
            ' 純虚数の場合
            Return Me.Imaginary.ToString(format, formatProvider) & "i"
        Else
            ' 実数の場合
            Return Me.Real.ToString(format, formatProvider)
        End If
    End Function
#End Region

    ' 演算子を定義

#Region "Operators"
    ' 加法
    Public Shared Operator +(ByVal Augend As Complex, ByVal Addend As Complex) As Complex
        Dim Answer = New Complex
        Answer.Real = Augend.Real + Addend.Real
        Answer.Imaginary = Augend.Imaginary + Addend.Imaginary
        Return Answer
    End Operator

    ' 減法
    Public Shared Operator -(ByVal Minuend As Complex, ByVal Subtrahend As Complex) As Complex
        Dim Answer = New Complex
        Answer.Real = Minuend.Real - Subtrahend.Real
        Answer.Imaginary = Minuend.Imaginary - Subtrahend.Imaginary
        Return Answer
    End Operator

    ' 乗法
    Public Shared Operator *(ByVal Multiplicand As Complex, ByVal Multiplier As Complex) As Complex
        Dim Answer = New Complex
        Answer.Real = Multiplicand.Real * Multiplier.Real - Multiplicand.Imaginary * Multiplier.Imaginary
        Answer.Imaginary = Multiplicand.Imaginary * Multiplier.Real + Multiplicand.Real * Multiplier.Imaginary
        Return Answer
    End Operator

    ' 除法
    Public Shared Operator /(ByVal Dividend As Complex, ByVal Divisor As Complex) As Complex
        Dim Answer = New Complex
        If (Divisor.Real = 0) And (Divisor.Imaginary = 0) Then
            ' 0で除算してた場合の処理
            Select Case Dividend.Real
                Case Is > 0 : Answer.Real = Double.PositiveInfinity '実部が正
                Case Is < 0 : Answer.Real = Double.NegativeInfinity '実部が負
                Case Else : Answer.Real = Double.NaN '実部が0
            End Select
            Select Case Dividend.Imaginary
                Case Is > 0 : Answer.Imaginary = Double.PositiveInfinity '虚部が正
                Case Is < 0 : Answer.Imaginary = Double.NegativeInfinity '虚部が負
                Case Else : Answer.Imaginary = Double.NaN '虚部が0
            End Select
        Else
            Answer.Real = (Dividend.Real * Divisor.Real + Dividend.Imaginary * Divisor.Imaginary) /
                (Divisor.Real * Divisor.Real + Divisor.Imaginary * Divisor.Imaginary)
            Answer.Imaginary = (Dividend.Imaginary * Divisor.Real - Dividend.Real * Divisor.Imaginary) /
                (Divisor.Real * Divisor.Real + Divisor.Imaginary * Divisor.Imaginary)
        End If
        Return Answer
    End Operator

    ' 単項プラス
    Public Shared Operator +(ByVal value As Complex) As Complex
        Return value
    End Operator

    ' 単項マイナス
    Public Shared Operator -(ByVal value As Complex) As Complex
        Dim Answer = New Complex
        Answer.Real = -value.Real
        Answer.Imaginary = -value.Imaginary
        Return Answer
    End Operator

    ' 一致
    Public Shared Operator =(ByVal LeftSide As Complex, ByVal RightSide As Complex) As Boolean
        Return (LeftSide.Real = RightSide.Real) And (LeftSide.Imaginary = RightSide.Imaginary)
    End Operator

    ' 不一致
    Public Shared Operator <>(ByVal LeftSide As Complex, ByVal RightSide As Complex) As Boolean
        Return (LeftSide.Real <> RightSide.Real) Or (LeftSide.Imaginary <> RightSide.Imaginary)
    End Operator
#End Region

    ' 定数を定義
    Public Shared ReadOnly I As New Complex With {.Real = 0, .Imaginary = 1} ' 虚数単位
    Public Shared ReadOnly PI As New Complex With {.Real = Math.PI, .Imaginary = 0} ' π

    ' 型の変換を定義
#Region "Cast"
    ' 実数から複素数への変換
#Region "UpCast"
    Public Shared Widening Operator CType(ByVal RealNum As Double) As Complex
        Dim Answer As Complex
        Answer.Real = RealNum : Answer.Imaginary = 0
        Return Answer.MemberwiseClone
    End Operator
    Public Shared Widening Operator CType(ByVal RealNum As Single) As Complex
        Return CType(CDbl(RealNum), Complex)
    End Operator
    Public Shared Widening Operator CType(ByVal RealNum As Decimal) As Complex
        Return CType(CDbl(RealNum), Complex)
    End Operator
    Public Shared Widening Operator CType(ByVal RealNum As Long) As Complex
        Return CType(CDbl(RealNum), Complex)
    End Operator
    Public Shared Widening Operator CType(ByVal RealNum As ULong) As Complex
        Return CType(CDbl(RealNum), Complex)
    End Operator
    Public Shared Widening Operator CType(ByVal RealNum As Integer) As Complex
        Return CType(CDbl(RealNum), Complex)
    End Operator
    Public Shared Widening Operator CType(ByVal RealNum As UInteger) As Complex
        Return CType(CDbl(RealNum), Complex)
    End Operator
    Public Shared Widening Operator CType(ByVal RealNum As Short) As Complex
        Return CType(CDbl(RealNum), Complex)
    End Operator
    Public Shared Widening Operator CType(ByVal RealNum As UShort) As Complex
        Return CType(CDbl(RealNum), Complex)
    End Operator
    Public Shared Widening Operator CType(ByVal RealNum As SByte) As Complex
        Return CType(CDbl(RealNum), Complex)
    End Operator
    Public Shared Widening Operator CType(ByVal RealNum As Byte) As Complex
        Return CType(CDbl(RealNum), Complex)
    End Operator
#End Region

    ' 複素数型に実数が格納されているときに実数型に直す
    Public Shared Narrowing Operator CType(ByVal RealAsComplex As Complex) As Double
        If RealAsComplex.Imaginary Then
            Return Double.NaN ' 虚数だったらNaNを返す
        Else
            Return RealAsComplex.Real
        End If
    End Operator
#End Region

    ' 関数を定義

#Region "Functions"

    ' 指数と対数
#Region "Logarithm"
    ' 自然対数(主値)
    Public Overloads Shared Function Log(ByVal Antilogarithm As Complex) As Complex
        Dim Answer = New Complex
        If (Antilogarithm.Real <= 0) And (Antilogarithm.Imaginary = 0) Then
            ' 負の実数か0だった場合の処理
            If Antilogarithm.Real = 0 Then
                Return Double.NegativeInfinity
            Else
                Return Double.NaN
            End If
        Else
            Dim Arg = Antilogarithm.Argument
            If Arg > Math.PI Then
                ' ±πの範囲に直す
                Arg -= 2 * Math.PI
            End If
            Answer.Real = Math.Log(Antilogarithm.Absolute)
            Answer.Imaginary = Arg
            Return Answer
        End If
    End Function

    ' 任意の底による対数(オーバーロード)
    Public Overloads Shared Function Log(ByVal Antilogarithm As Complex, ByVal Base As Complex) As Complex
        Return Log(Antilogarithm) / Log(Base)
    End Function

    ' 常用対数(主値)
    Public Shared Function Log10(ByVal Antilogarithm As Complex) As Complex
        Dim Answer = New Complex
        If Antilogarithm.Imaginary Then
            ' 実数でない場合は底の変換公式で計算する
            ' log_x (y) = log_a (y) / log_a (y)
            Answer = Log(Antilogarithm, 10)
            Return Answer
        Else
            ' 正の実数だったら普通のライブラリ関数を使う
            Answer.Real = Math.Log10(Antilogarithm.Real)
            Answer.Imaginary = 0
            Return Answer
        End If
    End Function

    ' 指数関数
    Public Shared Function Exp(ByVal Exponent As Complex) As Complex
        Dim Answer = New Complex
        If Exponent.Imaginary Then
            ' 実数でない場合は公式を使う
            ' exp (x + iy) = exp x(cos y + i sin y) = exp x cos y + i exp x sin y
            Answer.Real = Math.Exp(Exponent.Real) * Math.Cos(Exponent.Imaginary)
            Answer.Imaginary = Math.Exp(Exponent.Real) * Math.Sin(Exponent.Imaginary)
            Return Answer
        Else
            ' 実数だったら普通のライブラリ関数を使う
            Answer.Real = Math.Exp(Exponent.Real)
            Answer.Imaginary = 0
            Return Answer
        End If
    End Function

    ' 指数関数(任意の底、全て主値を使用する)
    Public Shared Function Pow(ByVal Base As Complex, ByVal Exponent As Complex) As Complex
        Dim Answer = New Complex
        If Exponent.Imaginary Then
            ' 実数乗でない場合は公式を使う
            ' a ^ z = e ^ (z ln a)
            Answer = Exp(Exponent * Log(Base))
        ElseIf (Base.Real < 0) And (Base.Imaginary = 0) And
            ((Exponent.Real * 2) = Math.Floor(Exponent.Real * 2)) Then
            ' 負の実数の半整数乗
            Select Case CType(Math.Floor(Exponent.Real * 2) Mod 4, Byte)
                Case 0 ' 2n     乗 …… 実軸正方向
                    Answer.Real = Math.Pow(-Base.Real, Exponent.Real)
                    Answer.Imaginary = 0
                Case 1 ' 2n+ .5 乗 …… 虚軸正方向
                    Answer.Real = 0
                    Answer.Imaginary = Math.Pow(-Base.Real, Exponent.Real)
                Case 2 ' 2n+1   乗 …… 実軸負方向
                    Answer.Real = -Math.Pow(-Base.Real, Exponent.Real)
                    Answer.Imaginary = 0
                Case 3 ' 2n+1.5 乗 …… 虚軸負方向
                    Answer.Real = 0
                    Answer.Imaginary = -Math.Pow(-Base.Real, Exponent.Real)
            End Select
        ElseIf (Base.Imaginary <> 0) And (Base.Real = 0) And
            (Exponent.Real = Math.Floor(Exponent.Real)) Then
            ' 純虚数の整数乗
            Select Case CType(Math.Floor(Exponent.Real) Mod 4, Byte)
                Case 0 ' 4n   乗 …… 実軸正方向
                    Answer.Real = Math.Pow(Base.Imaginary, Exponent.Real)
                    Answer.Imaginary = 0
                Case 1 ' 4n+1 乗 …… 虚軸正方向
                    Answer.Real = 0
                    Answer.Imaginary = Math.Pow(Base.Imaginary, Exponent.Real)
                Case 2 ' 4n+2 乗 …… 実軸負方向
                    Answer.Real = -Math.Pow(Base.Imaginary, Exponent.Real)
                    Answer.Imaginary = 0
                Case 3 ' 4n+3 乗 …… 虚軸負方向
                    Answer.Real = 0
                    Answer.Imaginary = -Math.Pow(Base.Imaginary, Exponent.Real)
            End Select
        ElseIf Base.Argument Then
            ' 底が正の実数でない場合
            ' 絶対値がn乗、偏角がn倍
            Answer.Absolute = Math.Pow(Base.Absolute, Exponent.Real)
            Answer.Argument = Base.Argument * Exponent.Real
        Else
            ' 普通のライブラリ関数が使える場合
            Answer.Real = Math.Pow(Base.Real, Exponent.Real)
            Answer.Imaginary = 0
        End If
        Return Answer
    End Function

    ' 平方根
    Public Shared Function Sqrt(ByVal Base As Complex) As Complex
        Return Pow(Base, 0.5)
    End Function
#End Region

    ' 三角関数
#Region "Trigonometric"
    ' 正弦
    Public Shared Function Sin(ByVal Angle As Complex) As Complex
        Dim Answer As Complex = 0
        If Angle.Imaginary Then
            ' 実数でない場合は公式を使う
            ' sin (x + iy) = sin x cosh y + i cos x sinh y
            Answer.Real = Math.Sin(Angle.Real) * Math.Cosh(Angle.Imaginary)
            Answer.Imaginary = Math.Cos(Angle.Real) * Math.Sinh(Angle.Imaginary)
            Return Answer
        Else
            ' 実数だったら普通のライブラリ関数を使う
            Answer.Real = (Math.Sin(Angle.Real))
            Answer.Imaginary = 0
            Return Answer
        End If
    End Function

    ' 余弦
    Public Shared Function Cos(ByVal Angle As Complex) As Complex
        Dim Answer As Complex = 0
        If Angle.Imaginary Then
            ' 実数でない場合は公式を使う
            ' cos (x + iy) = cos x cosh y - i sin x sinh y
            Answer.Real = Math.Cos(Angle.Real) * Math.Cosh(Angle.Imaginary)
            Answer.Imaginary = -Math.Sin(Angle.Real) * Math.Sinh(Angle.Imaginary)
            Return Answer
        Else
            ' 実数だったら普通のライブラリ関数を使う
            Answer.Real = Math.Cos(Angle.Real)
            Answer.Imaginary = 0
            Return Answer
        End If
    End Function

    ' 正接
    Public Shared Function Tan(ByVal Angle As Complex) As Complex
        Dim Answer As Complex = 0
        If Angle.Imaginary Then
            ' 実数でない場合は公式を使う
            ' tan θ = sin θ / cos θ
            Answer = Sin(Angle) / Cos(Angle)
            Return Answer
        Else
            ' 実数だったら普通のライブラリ関数を使う
            Answer.Real = Math.Tan(Angle.Real)
            Answer.Imaginary = 0
            Return Answer
        End If
    End Function

    ' 逆正弦
    Public Shared Function Asin(ByVal value As Complex) As Complex
        Dim Answer = New Complex
        If value.Imaginary Or (value.Real > 1) Or (value.Real < -1) Then
            ' 実数でない場合か [-1,1] の範囲外だったら公式を使う
            ' arcsin z = -i log (iz + sqrt(1 - z ^ 2))
            Answer = -I * Log(I * value + Sqrt(1 - Pow(value, 2)))
            Return Answer
        Else
            ' 実数だったら普通のライブラリ関数を使う
            Answer.Real = Math.Asin(value.Real)
            Answer.Imaginary = 0
            Return Answer
        End If
    End Function

    ' 逆余弦
    Public Shared Function Acos(ByVal value As Complex) As Complex
        Dim Answer As Complex = 0
        If value.Imaginary Or (value.Real > 1) Or (value.Real < -1) Then
            ' 実数でない場合か [-1,1] の範囲外だったら公式を使う
            ' arccos z = pi/2 - arcsin z
            Answer = PI / 2 - Asin(value)
            Return Answer
        Else
            ' 実数だったら普通のライブラリ関数を使う
            Answer.Real = Math.Acos(value.Real)
            Answer.Imaginary = 0
            Return Answer
        End If
    End Function

    ' 逆正接
    Public Shared Function Atan(ByVal value As Complex) As Complex
        Dim Answer As Complex = 0
        If value.Imaginary Then
            ' 実数でない場合は公式を使う
            ' arctan z = 0.5i log ((1 - iz) / (1 + iz))
            Answer = 0.5 * I * Log((1 - I * value) / (1 + I * value))
            Return Answer
        Else
            ' 実数だったら普通のライブラリ関数を使う
            Answer.Real = Math.Atan(value.Real)
            Answer.Imaginary = 0
            Return Answer
        End If
    End Function
#End Region

    ' 双曲函数
#Region "Hyperbolic"
    ' 双曲正弦
    Public Shared Function Sinh(ByVal Area As Complex) As Complex
        Dim Answer As Complex = 0
        If Area.Imaginary Then
            ' 実数でない場合は定義より計算
            ' sinh x = (e ^ x - e ^ (-x)) / 2
            Answer = (Exp(Area) - Exp(-Area)) / 2
            Return Answer
        Else
            ' 実数だったら普通のライブラリ関数を使う
            Answer.Real = Math.Sinh(Area.Real)
            Answer.Imaginary = 0
            Return Answer
        End If
    End Function

    ' 双曲余弦
    Public Shared Function Cosh(ByVal Area As Complex) As Complex
        Dim Answer As Complex = 0
        If Area.Imaginary Then
            ' 実数でない場合は定義より計算
            ' sinh x = (e ^ x + e ^ (-x)) / 2
            Answer = (Exp(Area) + Exp(-Area)) / 2
            Return Answer
        Else
            ' 実数だったら普通のライブラリ関数を使う
            Answer.Real = Math.Cosh(Area.Real)
            Answer.Imaginary = 0
            Return Answer
        End If
    End Function

    ' 双曲正接
    Public Shared Function Tanh(ByVal Area As Complex) As Complex
        Dim Answer As Complex = 0
        If Area.Imaginary Then
            ' 実数でない場合は公式を使う
            ' tanh θ = sinh θ / cosh θ
            Answer = Sinh(Area) / Cosh(Area)
            Return Answer
        Else
            ' 実数だったら普通のライブラリ関数を使う
            Answer.Real = Math.Tanh(Area.Real)
            Answer.Imaginary = 0
            Return Answer
        End If
    End Function

    ' 双曲逆正弦
    Public Shared Function Asinh(ByVal value As Complex) As Complex
        ' arsinh x = ln (x + sqrt(x ^ 2 + 1))
        Return Log(value + Sqrt(Pow(value, 1) + 1))
    End Function

    ' 双曲逆余弦
    Public Shared Function Acosh(ByVal value As Complex) As Complex
        ' arsinh x = ln (x + sqrt(x ^ 2 - 1)); x>= 1
        Return Log(value + Sqrt(Pow(value, 2) - 1))
    End Function

    ' 双曲逆正接
    Public Shared Function Atanh(ByVal value As Complex) As Complex
        ' arctanh x = 0.5 ln ((1 + x) / (1 - x)); |x| < 1
        Return 0.5 * Log((1 + value) / (1 - value))
    End Function
#End Region

    ' その他
#Region "Misc"

    ' ガンマ函数
    Public Shared Function Gamma(ByVal value As Complex) As Complex
        If (value.Imaginary = 0) And (value.Real = Math.Floor(value.Real)) Then
            ' 整数の場合
            If value.Real >= 170 Then
                ' オーバーフロー
                Return Double.PositiveInfinity
            ElseIf value.Real > 0 Then
                ' 自然数の場合 Γ(n) = (n + 1)!
                ' 倍精度実数で表現可能なのは170!まで
                Dim Answer As Double = 1
                For k As Byte = 1 To CType(value.Real, Byte) - 1 Step 1
                    Answer *= k
                Next
                Return Answer
            Else
                ' 0か負の整数だったらエラー
                If Math.Floor(value.Real Mod 2) Then
                    Return Double.NegativeInfinity
                Else
                    Return Double.PositiveInfinity
                End If
            End If
        ElseIf (value.Imaginary = 0) And ((value.Real + 0.5) = Math.Floor(value.Real + 0.5)) Then
            ' 半整数の場合
            If (value.Real > 0) And (value.Real < 1) Then
                ' Γ(0.5) = √π
                Return Math.Sqrt(Math.PI)
            ElseIf value.Real >= 170 Then
                ' オーバーフローした場合
                ' 倍精度型では Γ(169.5) が限界
                Throw New OverflowException("Factorial")
                Return New Complex
            ElseIf value.Real > 1 Then
                ' 引数が正
                Dim Answer As Double = Math.Sqrt(Math.PI)
                For k As Byte = 1 To CType(Math.Floor(value.Real), Byte) Step 1
                    Answer *= (CType(k, Double) * 2 - 1) / 2
                Next
                Return Answer
            ElseIf value.Real <= -179 Then
                ' アンダーフローした場合
                ' 倍精度型では Γ(-178.5) が限界
                Return 0
            Else
                ' 引数が負
                Dim Answer As Double = Math.Sqrt(Math.PI)
                For k As Byte = 1 To CType(Math.Floor(-value.Real) + 1, Byte) Step 1
                    Answer *= -2 / (CType(k, Double) * 2 - 1)
                Next
                Return Answer
            End If
        Else
            ' それ以外の実数の場合
            Dim AnsRaw As Complex = 1
            Dim Previous As Complex = 1
            Dim EndFlag As Boolean = False
            Dim LoopCount As UInt32 = 1
            Do Until EndFlag
                Previous = AnsRaw
                AnsRaw *= (Pow(1 + 1 / LoopCount, value) / (1 + value / LoopCount))
                If Double.IsInfinity(AnsRaw.Real) Or Double.IsNaN(AnsRaw.Real) Or
                    Double.IsInfinity(AnsRaw.Imaginary) Or Double.IsNaN(AnsRaw.Imaginary) Or
                    ((AnsRaw - Previous).Absolute < 0.0000000000000002) Or
                    LoopCount > 200000 Then
                    AnsRaw = Previous
                    EndFlag = True
                End If
                LoopCount += 1
            Loop
            Return AnsRaw / value
        End If
    End Function
#End Region
#End Region

End Structure
