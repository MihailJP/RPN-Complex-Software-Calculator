Public Class CalcPad

    ' クラス内変数の定義

#Region "Declaration"
    ' 数値計算用のスタックを用意
    Private ValueStack As New CalcStack
    Dim LastXBuffer = New Complex With {.Real = 0, .Imaginary = 0}

    ' 以下は入力のために一時的に使う
    Private Structure InputStatus
        Shared IsInputting As Boolean = False
        Shared InputCursorIm As Boolean = False
        Shared InputCursorEx As Boolean = False
        Shared ErrorFlag As Boolean = False
        Shared DisplayBlinkStat As Byte = 0
        Shared ShowingAnswer As Boolean = False
    End Structure
    Private Structure InputBuffer
        Const Rectangular As Byte = 0
        Const PolarRadian As Byte = 1
        Const PolarDegree As Byte = 2
        Shared ValueType As Byte = 0
        Shared InputReal As Int64 = 0
        Shared DecimalPoint As Boolean = False
        Shared DecimalDigits As Byte = 0
        Shared DecimalExp As SByte = 0
        Shared InputImaginary As Int64 = 0
        Shared DecimalPointI As Boolean = False
        Shared DecimalDigitsI As Byte = 0
        Shared DecimalExpI As SByte = 0
    End Structure

    ' 演算子コード
    Private Structure Oper
        Const Add As Byte = 0
        Const Subtract As Byte = 1
        Const Multiply As Byte = 2
        Const Divide As Byte = 3
        Const Log As Byte = 4
        Const Exp As Byte = 5
        Const Log10 As Byte = 6
        Const Exp10 As Byte = 7
        Const Square As Byte = 8
        Const Sqrt As Byte = 9
        Const Pow As Byte = 10
        Const Invert As Byte = 11
        Const Sin As Byte = 12
        Const Cos As Byte = 13
        Const Tan As Byte = 14
        Const Arcsin As Byte = 15
        Const Arccos As Byte = 16
        Const Arctan As Byte = 17
        Const Sinh As Byte = 18
        Const Cosh As Byte = 19
        Const Tanh As Byte = 20
        Const Arsinh As Byte = 21
        Const Arcosh As Byte = 22
        Const Artanh As Byte = 23
        Const Factorial As Byte = 24
        Const Absolute As Byte = 25
        Const Argument As Byte = 26
        Const Conjugate As Byte = 27
    End Structure

    ' ボタンの色
    Private Structure ButtonPalette
        Shared ReadOnly ColorAlpha = 100 ' ボタン背景のアルファチャンネル
        Shared ReadOnly ColorOfNumeric As System.Drawing.Color = Color.FromArgb(ColorAlpha, Color.Black)
        Shared ReadOnly ColorOfEnter As System.Drawing.Color = Color.FromArgb(ColorAlpha, Color.SteelBlue)
        Shared ReadOnly ColorOfOperator As System.Drawing.Color = Color.FromArgb(ColorAlpha, Color.SeaGreen)
        Shared ReadOnly ColorOfClear As System.Drawing.Color = Color.FromArgb(ColorAlpha, Color.DarkRed)
        Shared ReadOnly ColorOfStackOp As System.Drawing.Color = Color.FromArgb(ColorAlpha, Color.Olive)
        Shared ReadOnly ColorOfFunction As System.Drawing.Color = Color.FromArgb(ColorAlpha, Color.DimGray)
        Shared ReadOnly ColorOfSwitch As System.Drawing.Color = Color.FromArgb(ColorAlpha, Color.Purple)
    End Structure

    Private SineButtonBaseFontSize As Single

    ' 文字列定数
    Protected Structure TextLabel
        Public Const NaN = "NaN"
        Public Const PositiveOverflow = "Overflow"
        Public Const NegativeOverflow = "-Overflow"
        Public Const Log = "ln"
        Public Const Exp = "eˣ"
        Public Const Log10 = "log₁₀"
        Public Const Exp10 = "10ˣ"
        Public Const Sin = "sin"
        Public Const Cos = "cos"
        Public Const Tan = "tan"
        Public Const Asin = "Arcsin"
        Public Const Acos = "Arccos"
        Public Const Atan = "Arctan"
        Public Const Sinh = "sinh"
        Public Const Cosh = "cosh"
        Public Const Tanh = "tanh"
        Public Const Asinh = "Arsinh"
        Public Const Acosh = "Arcosh"
        Public Const Atanh = "Artanh"
    End Structure

    ' 設定を格納
    Public Class ConfigClass
        Public FloatFlag As Boolean = True
        Public DegreeFlag As Boolean = False
        Public PosX As Integer = 0
        Public PosY As Integer = 0
    End Class

#End Region

    ' 初期化処理

#Region "Init"
    ' ボタンに着色
    Private Sub PaintButton()
        For Each CurrentObj In Me.Controls
            If (CurrentObj.GetType Is GetType(Button)) Or
                (CurrentObj.GetType Is GetType(CheckBox)) Then
                Select Case CurrentObj.Tag
                    Case "numeral" : CurrentObj.BackColor = ButtonPalette.ColorOfNumeric
                    Case "enter" : CurrentObj.BackColor = ButtonPalette.ColorOfEnter
                    Case "operator" : CurrentObj.BackColor = ButtonPalette.ColorOfOperator
                    Case "stackedit" : CurrentObj.BackColor = ButtonPalette.ColorOfStackOp
                    Case "del" : CurrentObj.BackColor = ButtonPalette.ColorOfClear
                    Case "clear" : CurrentObj.BackColor = ButtonPalette.ColorOfClear
                    Case "function" : CurrentObj.BackColor = ButtonPalette.ColorOfFunction
                    Case "switch" : CurrentObj.BackColor = ButtonPalette.ColorOfSwitch
                End Select
            End If
        Next
    End Sub

    ' 設定を読み込む
    Private Sub LoadSetting()
        Dim Serializer As New System.Xml.Serialization.XmlSerializer(GetType(ConfigClass))
        Dim Configuration As ConfigClass
        Try
            Dim FileStream As New System.IO.FileStream("Config.xml", System.IO.FileMode.Open)
            Configuration = CType(Serializer.Deserialize(FileStream), ConfigClass)
            FileStream.Close()
        Catch ex As System.IO.FileNotFoundException
            Configuration = New ConfigClass
        Catch ex As System.InvalidOperationException
            Configuration = New ConfigClass
        End Try
        SetDesktopLocation(Configuration.PosX, Configuration.PosY)
        FloatSwitch.Checked = Configuration.FloatFlag
        DegreeSwitch.Checked = Configuration.DegreeFlag
    End Sub

    ' 起動時に呼び出されるイベント
    Private Sub CalcPad_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' 全ボタンにハンドラを割り当て
        For Each CurrentObj In Me.Controls
            If CurrentObj.GetType Is GetType(Button) Then
                AddHandler CType(CurrentObj, Button).Click, AddressOf ButtonClick
            End If
        Next
        ' 小数点の形状を地域の設定に合わせる
        NumPadDecimal.Text = CultureInfo.CurrentUICulture.NumberFormat.NumberDecimalSeparator
        ' sinボタンのフォントサイズ
        SineButtonBaseFontSize = SineButton.Font.Size
        ' 設定を読み込み
        LoadSetting()
        ' 画面の準備
        SwitchFuncSet()
        ShowStack() : PaintButton()
    End Sub
#End Region

    ' 表示部分の処理

#Region "Display"
    ' 点滅状態の更新
    Private Sub BlinkStatUpdate(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BlinkTimer.Tick
        InputStatus.DisplayBlinkStat += 1
        If InputStatus.DisplayBlinkStat >= 3 Then
            InputStatus.DisplayBlinkStat = 0
        End If
        ShowStack()
    End Sub

    ' 指数をUnicodeの上付き文字に直す
    Private Function Superscript(ByVal Value As Integer) As String
        Dim ValStr As String = Value.ToString
        Dim SuperStr As String = ""
        For i As UInt16 = 1 To ValStr.Length
            Select Case Mid(ValStr, i, 1)
                Case "0" : SuperStr += "⁰"
                Case "1" : SuperStr += "¹"
                Case "2" : SuperStr += "²"
                Case "3" : SuperStr += "³"
                Case "4" : SuperStr += "⁴"
                Case "5" : SuperStr += "⁵"
                Case "6" : SuperStr += "⁶"
                Case "7" : SuperStr += "⁷"
                Case "8" : SuperStr += "⁸"
                Case "9" : SuperStr += "⁹"
                Case "-" : SuperStr += "⁻"
            End Select
        Next
        Return SuperStr
    End Function

    ' スタックの中身を文字列に直す
    Private Sub StackValToStr(ByRef Mantissa As String, ByRef Exponent As String,
                              Optional ByVal StackID As Byte = 0,
                              Optional ByVal ImaginaryFlag As Boolean = False)
        Dim DisplayMantissa, DisplayExponent As Double
        ' まず、指数部と仮数部に分ける
        If ImaginaryFlag Then
            ' 虚部または偏角
            If InputStatus.IsInputting And (StackID = 0) Then
                ' 入力中
                DisplayMantissa = InputBuffer.InputImaginary / Math.Pow(10, InputBuffer.DecimalDigitsI)
                DisplayExponent = InputBuffer.DecimalExpI
            Else
                If PolarSwitch.Checked Then
                    ' 偏角
                    If DegreeSwitch.Checked Then
                        DisplayMantissa = ValueStack.GetArgument(StackID) * 180 / Math.PI
                        DisplayExponent = Math.Floor(Calculator.FailproofLog10(DisplayMantissa))
                        DisplayMantissa /= Math.Pow(10, DisplayExponent)
                    Else
                        DisplayMantissa = ValueStack.GetArgument(StackID)
                        DisplayExponent = 0
                    End If
                Else
                    ' 虚部
                    DisplayMantissa = ValueStack.GetImaginaryMantissa(StackID)
                    DisplayExponent = ValueStack.GetImaginaryExponent(StackID)
                End If
            End If
        Else
            ' 実部または絶対値
            If InputStatus.IsInputting And (StackID = 0) Then
                ' 入力中
                DisplayMantissa = InputBuffer.InputReal / Math.Pow(10, InputBuffer.DecimalDigits)
                DisplayExponent = InputBuffer.DecimalExp
            Else
                If PolarSwitch.Checked Then
                    ' 絶対値
                    DisplayMantissa = ValueStack.GetAbsoluteMantissa(StackID)
                    DisplayExponent = ValueStack.GetAbsoluteExponent(StackID)
                Else
                    ' 実部
                    DisplayMantissa = ValueStack.GetRealMantissa(StackID)
                    DisplayExponent = ValueStack.GetRealExponent(StackID)
                End If
            End If
        End If
        ' 文字列に変換する
        If Double.IsNaN(DisplayMantissa) Then
            ' NaNだったら
            Mantissa = TextLabel.NaN
            Exponent = ""
        ElseIf Double.IsPositiveInfinity(DisplayMantissa) Or ((DisplayMantissa > 0) And (DisplayExponent >= 100)) Then
            ' 正方向にオーバーフロー
            Mantissa = TextLabel.PositiveOverflow
            Exponent = ""
        ElseIf Double.IsNegativeInfinity(DisplayMantissa) Or ((DisplayMantissa < 0) And (DisplayExponent >= 100)) Then
            ' 負方向にオーバーフロー
            Mantissa = TextLabel.NegativeOverflow
            Exponent = ""
        ElseIf (DisplayExponent <= -100) And ((Not InputStatus.IsInputting) Or (StackID > 0)) Then
            ' 算術アンダーフロー
            If ImaginaryFlag Then Mantissa = "+0" Else Mantissa = "0"
            If ImaginaryFlag Then Exponent = "i" Else Exponent = ""
        Else
            ' 正常に表示可能
            Dim ValFormat As String = "0.#########"
            Dim ExyType = True
            If FloatSwitch.Checked And
                ((DisplayExponent > -3) And (DisplayExponent < 10)) Or (InputStatus.IsInputting And (StackID = 0)) Then
                ' 浮動小数点形式での表示
                If (InputStatus.IsInputting And (StackID = 0)) Then
                    Dim Digits
                    If ImaginaryFlag Then Digits = InputBuffer.DecimalDigitsI Else Digits = InputBuffer.DecimalDigits
                    Select Case Digits
                        Case 9 : ValFormat = "0.000000000"
                        Case 8 : ValFormat = "#0.00000000"
                        Case 7 : ValFormat = "##0.0000000"
                        Case 6 : ValFormat = "###0.000000"
                        Case 5 : ValFormat = "####0.00000"
                        Case 4 : ValFormat = "#####0.0000"
                        Case 3 : ValFormat = "######0.000"
                        Case 2 : ValFormat = "#######0.00"
                        Case 1 : ValFormat = "########0.0"
                        Case 0 : ValFormat = "#########0"
                    End Select
                Else
                    Select Case DisplayExponent
                        Case 1 : ValFormat = "#0.########"
                        Case 2 : ValFormat = "##0.#######"
                        Case 3 : ValFormat = "###0.######"
                        Case 4 : ValFormat = "####0.#####"
                        Case 5 : ValFormat = "#####0.####"
                        Case 6 : ValFormat = "######0.###"
                        Case 7 : ValFormat = "#######0.##"
                        Case 8 : ValFormat = "########0.#"
                        Case 9 : ValFormat = "#########0"
                    End Select
                End If
                If ImaginaryFlag And Not PolarSwitch.Checked Then
                    ValFormat = "+" + ValFormat + ";" + "-" + ValFormat
                End If
                If InputStatus.IsInputting And (StackID = 0) Then
                    Mantissa = (DisplayMantissa).ToString(ValFormat, CultureInfo.CurrentUICulture)
                Else
                    Mantissa = (DisplayMantissa * Math.Pow(10, DisplayExponent)).ToString(ValFormat, CultureInfo.CurrentUICulture)
                End If
                ExyType = False
            Else
                ' 指数形式での表示
                If ImaginaryFlag And Not PolarSwitch.Checked Then
                    ValFormat = "+" + ValFormat + ";" + "-" + ValFormat
                End If
                Mantissa = DisplayMantissa.ToString(ValFormat, CultureInfo.CurrentUICulture)
            End If
            If InputStatus.IsInputting And (Not ImaginaryFlag) And (StackID = 0) And
                InputBuffer.DecimalPoint And (InputBuffer.DecimalDigits = 0) Then
                Mantissa += CultureInfo.CurrentUICulture.NumberFormat.NumberDecimalSeparator
            End If
            If InputStatus.IsInputting And ImaginaryFlag And (StackID = 0) And
                InputBuffer.DecimalPointI And (InputBuffer.DecimalDigitsI = 0) Then
                Mantissa += CultureInfo.CurrentUICulture.NumberFormat.NumberDecimalSeparator
            End If
            If (ExyType Or (InputStatus.IsInputting And (StackID = 0))) And
                ((DisplayExponent <> 0) Or
                 (InputStatus.InputCursorEx) And (ImaginaryFlag = InputStatus.InputCursorIm)) Then
                Exponent = "×10" + Superscript(DisplayExponent)
            Else
                Exponent = ""
            End If
            ' 虚数単位または偏角の単位
            If ImaginaryFlag Then
                If PolarSwitch.Checked Then
                    If DegreeSwitch.Checked Then Exponent += "°"
                Else
                    Exponent += "i"
                End If
            End If
        End If
    End Sub

    ' スタックの中身を表示する
    Private Sub ShowStack()
        Dim DisplayMantissa As String = ""
        Dim DisplayExponent As String = ""
        BlinkTimer.Enabled = InputStatus.IsInputting
        If InputStatus.ShowingAnswer Then
            Value1Mantissa.ForeColor = Color.GreenYellow
        Else
            Value1Mantissa.ForeColor = Color.Gold
        End If
        Value1Exponent.ForeColor = Value1Mantissa.ForeColor
        Value1iMantissa.ForeColor = Value1Mantissa.ForeColor
        Value1iExponent.ForeColor = Value1Mantissa.ForeColor
        StackValToStr(DisplayMantissa, DisplayExponent, 0, False)
        Value1Mantissa.Text = DisplayMantissa : Value1Exponent.Text = DisplayExponent
        StackValToStr(DisplayMantissa, DisplayExponent, 0, True)
        Value1iMantissa.Text = DisplayMantissa : Value1iExponent.Text = DisplayExponent
        ' テキストを点滅させる
        If (InputStatus.IsInputting = True) And (InputStatus.DisplayBlinkStat = 0) Then
            If InputStatus.InputCursorIm Then
                If InputStatus.InputCursorEx Then
                    Value1iExponent.Text = ""
                Else
                    Value1iMantissa.Text = ""
                End If
            Else
                If InputStatus.InputCursorEx Then
                    Value1Exponent.Text = ""
                Else
                    Value1Mantissa.Text = ""
                End If
            End If
        End If
        ' オーバーフローを起こしてたら一旦停止させる
        If Value1Mantissa.Text = TextLabel.NaN Or
            Value1Mantissa.Text = TextLabel.PositiveOverflow Or
            Value1Mantissa.Text = TextLabel.NegativeOverflow Then
            Value1Mantissa.ForeColor = Color.Red : Value1Exponent.ForeColor = Color.Red
            InputStatus.ErrorFlag = True : EnableButtons(False)
        End If
        If Value1iMantissa.Text = TextLabel.NaN Or
            Value1iMantissa.Text = TextLabel.PositiveOverflow Or
            Value1iMantissa.Text = TextLabel.NegativeOverflow Then
            Value1iMantissa.ForeColor = Color.Red : Value1iExponent.ForeColor = Color.Red
            InputStatus.ErrorFlag = True : EnableButtons(False)
        End If
        ' スタックの奥の値を表示
        StackValToStr(DisplayMantissa, DisplayExponent, 1, False)
        Value2Mantissa.Text = DisplayMantissa : Value2Exponent.Text = DisplayExponent
        StackValToStr(DisplayMantissa, DisplayExponent, 1, True)
        Value2iMantissa.Text = DisplayMantissa : Value2iExponent.Text = DisplayExponent
        StackValToStr(DisplayMantissa, DisplayExponent, 2, False)
        Value3Mantissa.Text = DisplayMantissa : Value3Exponent.Text = DisplayExponent
        StackValToStr(DisplayMantissa, DisplayExponent, 2, True)
        Value3iMantissa.Text = DisplayMantissa : Value3iExponent.Text = DisplayExponent
        StackValToStr(DisplayMantissa, DisplayExponent, 3, False)
        Value4Mantissa.Text = DisplayMantissa : Value4Exponent.Text = DisplayExponent
        StackValToStr(DisplayMantissa, DisplayExponent, 3, True)
        Value4iMantissa.Text = DisplayMantissa : Value4iExponent.Text = DisplayExponent
    End Sub
#End Region

    ' 入力イベント

#Region "Input"
    ' キーボード入力
    Private Sub CalcPad_KeyEvent(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Select Case e.KeyCode
            Case Keys.Delete : ValueClear()
            Case Keys.Escape : AllClear()
        End Select
        If Not InputStatus.ErrorFlag Then ' エラー時は以下の入力を受け付けないようにする
            Select Case e.KeyCode
                Case Keys.NumPad0 : NumberInput(0)
                Case Keys.NumPad1 : NumberInput(1)
                Case Keys.NumPad2 : NumberInput(2)
                Case Keys.NumPad3 : NumberInput(3)
                Case Keys.NumPad4 : NumberInput(4)
                Case Keys.NumPad5 : NumberInput(5)
                Case Keys.NumPad6 : NumberInput(6)
                Case Keys.NumPad7 : NumberInput(7)
                Case Keys.NumPad8 : NumberInput(8)
                Case Keys.NumPad9 : NumberInput(9)
                Case Keys.Decimal : NumberPointInput()
                Case Keys.Enter : ValueEnter()
                Case Keys.Back : ValueDel()
                Case Keys.Add : CalcFunc(Oper.Add)
                Case Keys.Subtract : CalcFunc(Oper.Subtract)
                Case Keys.Multiply : CalcFunc(Oper.Multiply)
                Case Keys.Divide : CalcFunc(Oper.Divide)
                Case Keys.F9 : OperatorNegate()
                Case Keys.Insert : StackSwap()
                Case Keys.PageDown : StackRotate()
                Case Keys.Tab
                    SwitchExCursor()
                    If Not InputStatus.InputCursorEx Then SwitchImCursor()
                Case Keys.I : SwitchImCursor()
                Case Keys.E : SwitchExCursor()
                Case Keys.P : InputPi()
                Case Keys.X : RecallLastX()
                Case Keys.N : If InvertSwitch.Checked Then CalcFunc(Oper.Exp) Else CalcFunc(Oper.Log)
                Case Keys.L : If InvertSwitch.Checked Then CalcFunc(Oper.Exp10) Else CalcFunc(Oper.Log10)
                Case Keys.Q : CalcFunc(Oper.Square)
                Case Keys.R : CalcFunc(Oper.Sqrt)
                Case Keys.W : CalcFunc(Oper.Pow)
                Case Keys.K : CalcFunc(Oper.Invert)
                Case Keys.S
                    If HyperbolicSwitch.Checked Then
                        If InvertSwitch.Checked Then CalcFunc(Oper.Arsinh) Else CalcFunc(Oper.Sinh)
                    Else
                        If InvertSwitch.Checked Then CalcFunc(Oper.Arcsin) Else CalcFunc(Oper.Sin)
                    End If
                Case Keys.C
                    If HyperbolicSwitch.Checked Then
                        If InvertSwitch.Checked Then CalcFunc(Oper.Arcosh) Else CalcFunc(Oper.Cosh)
                    Else
                        If InvertSwitch.Checked Then CalcFunc(Oper.Arccos) Else CalcFunc(Oper.Cos)
                    End If
                Case Keys.T
                    If HyperbolicSwitch.Checked Then
                        If InvertSwitch.Checked Then CalcFunc(Oper.Artanh) Else CalcFunc(Oper.Tanh)
                    Else
                        If InvertSwitch.Checked Then CalcFunc(Oper.Arctan) Else CalcFunc(Oper.Tan)
                    End If
                Case Keys.G : CalcFunc(Oper.Factorial)
                Case Keys.M : CalcFunc(Oper.Absolute)
                Case Keys.A : CalcFunc(Oper.Argument)
                Case Keys.J : CalcFunc(Oper.Conjugate)
                Case Keys.D : DegreeSwitch.Checked = Not DegreeSwitch.Checked
                Case Keys.O : PolarSwitch.Checked = Not PolarSwitch.Checked
                Case Keys.V : InvertSwitch.Checked = Not InvertSwitch.Checked
                Case Keys.H : HyperbolicSwitch.Checked = Not HyperbolicSwitch.Checked
                Case Keys.F : FloatSwitch.Checked = Not FloatSwitch.Checked
            End Select
        End If
    End Sub

    ' ボタン入力
    Private Sub ButtonClick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Select Case sender.text
            Case NumPad0.Text : NumberInput(0)
            Case NumPad1.Text : NumberInput(1)
            Case NumPad2.Text : NumberInput(2)
            Case NumPad3.Text : NumberInput(3)
            Case NumPad4.Text : NumberInput(4)
            Case NumPad5.Text : NumberInput(5)
            Case NumPad6.Text : NumberInput(6)
            Case NumPad7.Text : NumberInput(7)
            Case NumPad8.Text : NumberInput(8)
            Case NumPad9.Text : NumberInput(9)
            Case CultureInfo.CurrentUICulture.NumberFormat.NumberDecimalSeparator : NumberPointInput()
            Case EnterButton.Text : ValueEnter()
            Case DeleteButton.Text : ValueDel()
            Case ClearEntryButton.Text : ValueClear()
            Case ClearButton.Text : AllClear()
            Case AdditionButton.Text : CalcFunc(Oper.Add)
            Case SubtractionButton.Text : CalcFunc(Oper.Subtract)
            Case MultiplicationButton.Text : CalcFunc(Oper.Multiply)
            Case DivisionButton.Text : CalcFunc(Oper.Divide)
            Case NegateSignButton.Text : OperatorNegate()
            Case SwapButton.Text : StackSwap()
            Case RotateButton.Text : StackRotate()
            Case SwitchComplexCursor.Text : SwitchImCursor()
            Case SwitchExponentCursor.Text : SwitchExCursor()
            Case PiButton.Text : InputPi()
            Case LastXButton.Text : RecallLastX()
            Case TextLabel.Log : CalcFunc(Oper.Log)
            Case TextLabel.Exp : CalcFunc(Oper.Exp)
            Case TextLabel.Log10 : CalcFunc(Oper.Log10)
            Case TextLabel.Exp10 : CalcFunc(Oper.Exp10)
            Case SquareButton.Text : CalcFunc(Oper.Square)
            Case SquareRoot.Text : CalcFunc(Oper.Sqrt)
            Case ExponentButton.Text : CalcFunc(Oper.Pow)
            Case InverseNumber.Text : CalcFunc(Oper.Invert)
            Case TextLabel.Sin : CalcFunc(Oper.Sin)
            Case TextLabel.Cos : CalcFunc(Oper.Cos)
            Case TextLabel.Tan : CalcFunc(Oper.Tan)
            Case TextLabel.Asin : CalcFunc(Oper.Arcsin)
            Case TextLabel.Acos : CalcFunc(Oper.Arccos)
            Case TextLabel.Atan : CalcFunc(Oper.Arctan)
            Case TextLabel.Sinh : CalcFunc(Oper.Sinh)
            Case TextLabel.Cosh : CalcFunc(Oper.Cosh)
            Case TextLabel.Tanh : CalcFunc(Oper.Tanh)
            Case TextLabel.Asinh : CalcFunc(Oper.Arsinh)
            Case TextLabel.Acosh : CalcFunc(Oper.Arcosh)
            Case TextLabel.Atanh : CalcFunc(Oper.Artanh)
            Case FactorialButton.Text : CalcFunc(Oper.Factorial)
            Case AbsoluteButton.Text : CalcFunc(Oper.Absolute)
            Case ArgumentButton.Text : CalcFunc(Oper.Argument)
            Case ConjugateButton.Text : CalcFunc(Oper.Conjugate)
        End Select
    End Sub
#End Region

    ' ボタンが押されたときの処理

#Region "Button"
    ' ボタン用サブルーチン
#Region "ButtonSub"
    ' ボタンにフォーカスが移った場合はフォーカスを外す
    Private Sub FocusCancellation(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.LostFocus
        Me.Focus()
    End Sub

    ' ボタンの有効化/無効化 (エラーが起きたらクリアキー以外無効にする)
    Private Sub EnableButtons(ByVal EnableFlag As Boolean)
        For Each CurrentObj In Me.Controls
            If ((CurrentObj.GetType Is GetType(Button)) Or
                (CurrentObj.GetType Is GetType(CheckBox))) And
            (CurrentObj.tag <> "clear") Then
                CurrentObj.enabled = EnableFlag
            End If
        Next
    End Sub
#End Region
    ' 入力用サブルーチン
#Region "InputSub"
    ' 未入力状態に戻す
    Private Sub ClearInput()
        InputStatus.ShowingAnswer = False : InputStatus.InputCursorIm = False : InputStatus.InputCursorEx = False
        InputBuffer.InputReal = 0 : InputBuffer.DecimalDigits = 0 : InputBuffer.DecimalExp = 0 : InputBuffer.DecimalPoint = False
        InputBuffer.InputImaginary = 0 : InputBuffer.DecimalDigitsI = 0 : InputBuffer.DecimalExpI = 0 : InputBuffer.DecimalPointI = False
        InputStatus.IsInputting = False
    End Sub

    ' 未確定の入力があったら確定する
    Private Sub DoEnter()
        If InputStatus.IsInputting Then
            Dim dummy = ValueStack.Pop()
            If Not PolarSwitch.Checked Then
                ValueStack.Push(CType(CType(InputBuffer.InputReal, Double) / Math.Pow(10, InputBuffer.DecimalDigits - InputBuffer.DecimalExp), Complex) +
                                Complex.I * CType(CType(InputBuffer.InputImaginary, Double) / Math.Pow(10, InputBuffer.DecimalDigitsI - InputBuffer.DecimalExpI), Complex))
            ElseIf Not DegreeSwitch.Checked Then
                ValueStack.Push(New Complex With {.Absolute = InputBuffer.InputReal / Math.Pow(10, InputBuffer.DecimalDigits - InputBuffer.DecimalExp),
                                                  .Argument = InputBuffer.InputImaginary / Math.Pow(10, InputBuffer.DecimalDigitsI - InputBuffer.DecimalExpI)})
            Else
                ValueStack.Push(New Complex With {.Absolute = InputBuffer.InputReal / Math.Pow(10, InputBuffer.DecimalDigits - InputBuffer.DecimalExp),
                                                  .Argument = CType(InputBuffer.InputImaginary, Double) * Math.PI /
                                                  Math.Pow(10, InputBuffer.DecimalDigitsI) / 180.0})
            End If
        End If
    End Sub

    ' 数値をスタックに積む
    Private Sub ValueEnter()
        DoEnter()
        Dim EnteringVal = ValueStack.Pop()
        ValueStack.Push(EnteringVal) : ValueStack.Push(EnteringVal)
        ClearInput() : ShowStack()
    End Sub

    ' 度をラジアンに直す
    Private Sub DegToRad()
        If DegreeSwitch.Checked Then
            Dim Degree = ValueStack.Pop
            ValueStack.Push(Degree * (Math.PI / 180))
        End If
    End Sub

    ' ラジアンを度に直す
    Private Sub RadToDeg()
        If DegreeSwitch.Checked Then
            Dim Degree = ValueStack.Pop
            ValueStack.Push(Degree * (180 / Math.PI))
        End If
    End Sub
#End Region
    ' 入力ボタンの処理
#Region "Input"
    ' 数字を入力
    Private Sub NumberInput(ByVal Digit As Byte)
        If InputStatus.ShowingAnswer And (Not InputStatus.IsInputting) Then
            ValueStack.Push(0) : InputStatus.ShowingAnswer = False
        End If
        InputStatus.IsInputting = True
        If InputStatus.InputCursorEx Then
            If InputStatus.InputCursorIm Then
                If Math.Abs(InputBuffer.DecimalExpI) < 10 Then
                    InputBuffer.DecimalExpI *= 10 : InputBuffer.DecimalExpI += Digit * (Math.Sign(InputBuffer.DecimalExpI) Or 1)
                End If
            Else
                If Math.Abs(InputBuffer.DecimalExp) < 10 Then
                    InputBuffer.DecimalExp *= 10 : InputBuffer.DecimalExp += Digit * (Math.Sign(InputBuffer.DecimalExp) Or 1)
                End If
            End If
        Else
            If InputStatus.InputCursorIm Then
                If (Calculator.FailproofLog10(InputBuffer.InputImaginary) < 9) And (InputBuffer.DecimalDigitsI < 9) Then
                    InputBuffer.InputImaginary *= 10 : InputBuffer.InputImaginary += Digit * (Math.Sign(InputBuffer.InputImaginary) Or 1)
                    If InputBuffer.DecimalPointI Then
                        InputBuffer.DecimalDigitsI += 1
                    End If
                End If
            Else
                If (Calculator.FailproofLog10(InputBuffer.InputReal) < 9) And (InputBuffer.DecimalDigits < 9) Then
                    InputBuffer.InputReal *= 10 : InputBuffer.InputReal += Digit * (Math.Sign(InputBuffer.InputReal) Or 1)
                    If InputBuffer.DecimalPoint Then
                        InputBuffer.DecimalDigits += 1
                    End If
                End If
            End If
        End If
        ShowStack()
    End Sub

    ' 小数点を入力
    Private Sub NumberPointInput()
        If Not InputStatus.InputCursorEx Then
            If InputStatus.ShowingAnswer And (Not InputStatus.IsInputting) Then
                ValueStack.Push(0) : InputStatus.ShowingAnswer = False
            End If
            If InputStatus.InputCursorIm Then
                If Not InputBuffer.DecimalPointI Then
                    InputStatus.IsInputting = True : InputBuffer.DecimalPointI = True
                    ShowStack()
                End If
            Else
                If Not InputBuffer.DecimalPoint Then
                    InputStatus.IsInputting = True : InputBuffer.DecimalPoint = True
                    ShowStack()
                End If
            End If
        End If
    End Sub

    ' 一文字削除
    Private Sub ValueDel()
        If InputStatus.IsInputting Then
            If InputStatus.InputCursorEx Then
                If InputStatus.InputCursorIm Then
                    InputBuffer.DecimalExpI = Math.Truncate(InputBuffer.DecimalExpI / 10)
                Else
                    InputBuffer.DecimalExp = Math.Truncate(InputBuffer.DecimalExp / 10)
                End If
            Else
                If InputStatus.InputCursorIm Then
                    If InputBuffer.DecimalPointI And (InputBuffer.DecimalDigitsI = 0) Then
                        InputBuffer.DecimalPointI = False
                    Else
                        InputBuffer.InputImaginary = Math.Truncate(InputBuffer.InputImaginary / 10)
                        If (InputBuffer.DecimalDigitsI > 0) Then
                            InputBuffer.DecimalDigitsI -= 1
                        End If
                    End If
                Else
                    If InputBuffer.DecimalPoint And (InputBuffer.DecimalDigits = 0) Then
                        InputBuffer.DecimalPoint = False
                    Else
                        InputBuffer.InputReal = Math.Truncate(InputBuffer.InputReal / 10)
                        If (InputBuffer.DecimalDigits > 0) Then
                            InputBuffer.DecimalDigits -= 1
                        End If
                    End If
                End If
            End If
        End If
        ShowStack()
    End Sub

    ' スタックの先頭を削除
    Private Sub ValueClear()
        ClearInput()
        InputStatus.IsInputting = False
        InputStatus.ErrorFlag = False : EnableButtons(True)
        Dim dummy = ValueStack.Pop()
        ValueStack.Push(0)
        ShowStack()
    End Sub

    ' スタックをリセット
    Private Sub AllClear()
        LastXBuffer = New Complex With {.Real = 0, .Imaginary = 0}
        ClearInput()
        InputStatus.IsInputting = False
        InputStatus.ErrorFlag = False : EnableButtons(True)
        ValueStack.ClearAll()
        ShowStack()
    End Sub
#End Region
    ' 入力補助ボタンの処理
#Region "InputAux"
    ' 符号を反転
    Private Sub OperatorNegate()
        If PolarSwitch.Checked And Not InputStatus.InputCursorIm Then Return
        If InputStatus.IsInputting Then
            If InputStatus.InputCursorEx Then
                If InputStatus.InputCursorIm Then
                    InputBuffer.DecimalExpI *= -1
                Else
                    InputBuffer.DecimalExp *= -1
                End If
            Else
                If InputStatus.InputCursorIm Then
                    InputBuffer.InputImaginary *= -1
                Else
                    InputBuffer.InputReal *= -1
                End If
            End If
        Else
            Dim StackX = ValueStack.Pop
            ValueStack.Push(-StackX)
            InputStatus.ShowingAnswer = True
        End If
        ShowStack()
    End Sub

    ' スタックのXとYを入れ替え
    Private Sub StackSwap()
        DoEnter()
        ValueStack.Swap()
        ClearInput() : InputStatus.ShowingAnswer = True : ShowStack()
    End Sub

    ' スタックを回転
    Private Sub StackRotate()
        DoEnter()
        ValueStack.Rotate()
        ClearInput() : InputStatus.ShowingAnswer = True : ShowStack()
    End Sub

    ' LastXを入力
    Private Sub RecallLastX()
        InputConstant(LastXBuffer)
    End Sub

    ' 実部・虚部入力モード切替
    Private Sub SwitchImCursor()
        If InputStatus.ShowingAnswer And (Not InputStatus.IsInputting) Then
            ValueStack.Push(0) : InputStatus.ShowingAnswer = False
        End If
        InputStatus.IsInputting = True : InputStatus.InputCursorIm = Not InputStatus.InputCursorIm
        InputStatus.InputCursorEx = False
        ShowStack()
    End Sub

    ' 仮数部・指数部入力モード切替
    Private Sub SwitchExCursor()
        If InputStatus.ShowingAnswer And (Not InputStatus.IsInputting) Then
            ValueStack.Push(0) : InputStatus.ShowingAnswer = False
        End If
        InputStatus.IsInputting = True : InputStatus.InputCursorEx = Not InputStatus.InputCursorEx
        ShowStack()
    End Sub
#End Region
    ' 定数ボタンの処理
#Region "Constant"
    ' 入力処理
    Private Sub InputConstant(ByVal value As Complex)
        If InputStatus.IsInputting Or InputStatus.ShowingAnswer Then DoEnter() Else Dim dummy = ValueStack.Pop
        ValueStack.Push(value)
        ClearInput() : InputStatus.ShowingAnswer = True : ShowStack()
    End Sub
    ' 円周率
    Private Sub InputPi()
        InputConstant(Math.PI)
    End Sub
#End Region
    ' 演算子と函数ボタンの処理
    Private Sub CalcFunc(ByVal OperatorCode As Byte)
        DoEnter() : InvertSwitch.Checked = False : HyperbolicSwitch.Checked = False
        LastXBuffer = ValueStack.Pop : ValueStack.Push(LastXBuffer)
        Select Case OperatorCode
            Case Oper.Add : Calculator.Add(ValueStack)
            Case Oper.Subtract : Calculator.Subtract(ValueStack)
            Case Oper.Multiply : Calculator.Multiply(ValueStack)
            Case Oper.Divide : Calculator.Divide(ValueStack)
            Case Oper.Log : Calculator.Log(ValueStack)
            Case Oper.Exp : Calculator.Exp(ValueStack)
            Case Oper.Log10 : Calculator.Log10(ValueStack)
            Case Oper.Exp10 : Calculator.Exp10(ValueStack)
            Case Oper.Square : Calculator.Square(ValueStack)
            Case Oper.Sqrt : Calculator.Sqrt(ValueStack)
            Case Oper.Pow : Calculator.Pow(ValueStack)
            Case Oper.Invert : Calculator.Invert(ValueStack)
            Case Oper.Sin : DegToRad() : Calculator.Sin(ValueStack)
            Case Oper.Cos : DegToRad() : Calculator.Cos(ValueStack)
            Case Oper.Tan : DegToRad() : Calculator.Tan(ValueStack)
            Case Oper.Arcsin : Calculator.Arcsin(ValueStack) : RadToDeg()
            Case Oper.Arccos : Calculator.Arccos(ValueStack) : RadToDeg()
            Case Oper.Arctan : Calculator.Arctan(ValueStack) : RadToDeg()
            Case Oper.Sinh : Calculator.Sinh(ValueStack)
            Case Oper.Cosh : Calculator.Cosh(ValueStack)
            Case Oper.Tanh : Calculator.Tanh(ValueStack)
            Case Oper.Arsinh : Calculator.Arsinh(ValueStack)
            Case Oper.Arcosh : Calculator.Arcosh(ValueStack)
            Case Oper.Artanh : Calculator.Artanh(ValueStack)
            Case Oper.Factorial : Calculator.Factorial(ValueStack)
            Case Oper.Absolute : Calculator.Absolute(ValueStack)
            Case Oper.Argument : Calculator.Argument(ValueStack)
            Case Oper.Conjugate : Calculator.Conjugate(ValueStack)
        End Select
        ClearInput() : InputStatus.ShowingAnswer = True : ShowStack()
    End Sub
#End Region

    ' スイッチのON/OFFイベントここから

#Region "SwitchEvent"

    ' イベントのハンドラ
    Private Sub PolarSwitch_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PolarSwitch.CheckedChanged
        InputBuffer.InputReal = Math.Abs(InputBuffer.InputReal)
        ShowStack()
    End Sub

    Private Sub DegreeSwitch_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DegreeSwitch.CheckedChanged
        ShowStack()
    End Sub

    Private Sub FloatSwitch_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FloatSwitch.CheckedChanged
        ShowStack()
    End Sub

    Private Sub PowerOff(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PowerSwitch.CheckedChanged
        If PowerSwitch.Checked = False Then End
    End Sub

    ' 逆函数スイッチ
    Private Sub SwitchFuncSet_Ev(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InvertSwitch.CheckedChanged,
        HyperbolicSwitch.CheckedChanged

        SwitchFuncSet()
    End Sub
    Private Sub SwitchFuncSet()

        If InvertSwitch.Checked Then
            NaturalLogarithm.Text = TextLabel.Exp
            CommonLogarithm.Text = TextLabel.Exp10
            For Each CurrentButton As Button In {SineButton, CosineButton, TangentButton}
                CurrentButton.Font = New Font(CurrentButton.Font.FontFamily,
                                              SineButtonBaseFontSize * 0.7,
                                              CurrentButton.Font.Style,
                                              CurrentButton.Font.Unit)
            Next
            If HyperbolicSwitch.Checked Then
                SineButton.Text = TextLabel.Asinh
                CosineButton.Text = TextLabel.Acosh
                TangentButton.Text = TextLabel.Atanh
            Else
                SineButton.Text = TextLabel.Asin
                CosineButton.Text = TextLabel.Acos
                TangentButton.Text = TextLabel.Atan
            End If
        Else
            NaturalLogarithm.Text = TextLabel.Log
            CommonLogarithm.Text = TextLabel.Log10
            For Each CurrentButton As Button In {SineButton, CosineButton, TangentButton}
                CurrentButton.Font = New Font(CurrentButton.Font.FontFamily,
                                              SineButtonBaseFontSize,
                                              CurrentButton.Font.Style,
                                              CurrentButton.Font.Unit)
            Next
            If HyperbolicSwitch.Checked Then
                SineButton.Text = TextLabel.Sinh
                CosineButton.Text = TextLabel.Cosh
                TangentButton.Text = TextLabel.Tanh
            Else
                SineButton.Text = TextLabel.Sin
                CosineButton.Text = TextLabel.Cos
                TangentButton.Text = TextLabel.Tan
            End If
        End If
    End Sub

#End Region

    ' 閉じる前に設定を保存する処理
    Private Sub CalcPad_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Dim Configuration As New ConfigClass
        Configuration.PosX = DesktopLocation.X
        Configuration.PosY = DesktopLocation.Y
        Configuration.DegreeFlag = DegreeSwitch.Checked
        Configuration.FloatFlag = FloatSwitch.Checked
        Dim Serializer As New System.Xml.Serialization.XmlSerializer(GetType(ConfigClass))
        Dim FileStream As New System.IO.FileStream("Config.xml", System.IO.FileMode.Create)
        Serializer.Serialize(FileStream, Configuration)
        FileStream.Close()
    End Sub
End Class
