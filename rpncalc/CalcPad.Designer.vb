<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CalcPad
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CalcPad))
        Me.Value1Mantissa = New System.Windows.Forms.Label()
        Me.Value1Exponent = New System.Windows.Forms.Label()
        Me.NumPad7 = New System.Windows.Forms.Button()
        Me.NumPad8 = New System.Windows.Forms.Button()
        Me.NumPad9 = New System.Windows.Forms.Button()
        Me.NumPad6 = New System.Windows.Forms.Button()
        Me.NumPad5 = New System.Windows.Forms.Button()
        Me.NumPad4 = New System.Windows.Forms.Button()
        Me.NumPad3 = New System.Windows.Forms.Button()
        Me.NumPad2 = New System.Windows.Forms.Button()
        Me.NumPad1 = New System.Windows.Forms.Button()
        Me.NumPad0 = New System.Windows.Forms.Button()
        Me.NumPadDecimal = New System.Windows.Forms.Button()
        Me.EnterButton = New System.Windows.Forms.Button()
        Me.Value2Exponent = New System.Windows.Forms.Label()
        Me.Value2Mantissa = New System.Windows.Forms.Label()
        Me.Value3Exponent = New System.Windows.Forms.Label()
        Me.Value3Mantissa = New System.Windows.Forms.Label()
        Me.Value4Exponent = New System.Windows.Forms.Label()
        Me.Value4Mantissa = New System.Windows.Forms.Label()
        Me.AdditionButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SubtractionButton = New System.Windows.Forms.Button()
        Me.MultiplicationButton = New System.Windows.Forms.Button()
        Me.DivisionButton = New System.Windows.Forms.Button()
        Me.NegateSignButton = New System.Windows.Forms.Button()
        Me.RotateButton = New System.Windows.Forms.Button()
        Me.SwapButton = New System.Windows.Forms.Button()
        Me.DeleteButton = New System.Windows.Forms.Button()
        Me.ClearEntryButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.BlinkTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Value4iExponent = New System.Windows.Forms.Label()
        Me.Value4iMantissa = New System.Windows.Forms.Label()
        Me.Value3iExponent = New System.Windows.Forms.Label()
        Me.Value3iMantissa = New System.Windows.Forms.Label()
        Me.Value2iExponent = New System.Windows.Forms.Label()
        Me.Value2iMantissa = New System.Windows.Forms.Label()
        Me.Value1iExponent = New System.Windows.Forms.Label()
        Me.Value1iMantissa = New System.Windows.Forms.Label()
        Me.SwitchComplexCursor = New System.Windows.Forms.Button()
        Me.PolarSwitch = New System.Windows.Forms.CheckBox()
        Me.DegreeSwitch = New System.Windows.Forms.CheckBox()
        Me.NaturalLogarithm = New System.Windows.Forms.Button()
        Me.CommonLogarithm = New System.Windows.Forms.Button()
        Me.SquareButton = New System.Windows.Forms.Button()
        Me.SquareRoot = New System.Windows.Forms.Button()
        Me.ExponentButton = New System.Windows.Forms.Button()
        Me.InvertSwitch = New System.Windows.Forms.CheckBox()
        Me.HyperbolicSwitch = New System.Windows.Forms.CheckBox()
        Me.PiButton = New System.Windows.Forms.Button()
        Me.FactorialButton = New System.Windows.Forms.Button()
        Me.SineButton = New System.Windows.Forms.Button()
        Me.CosineButton = New System.Windows.Forms.Button()
        Me.TangentButton = New System.Windows.Forms.Button()
        Me.InverseNumber = New System.Windows.Forms.Button()
        Me.AbsoluteButton = New System.Windows.Forms.Button()
        Me.ArgumentButton = New System.Windows.Forms.Button()
        Me.ConjugateButton = New System.Windows.Forms.Button()
        Me.FloatSwitch = New System.Windows.Forms.CheckBox()
        Me.PowerSwitch = New System.Windows.Forms.CheckBox()
        Me.SwitchExponentCursor = New System.Windows.Forms.Button()
        Me.LastXButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Value1Mantissa
        '
        Me.Value1Mantissa.BackColor = System.Drawing.Color.Black
        Me.Value1Mantissa.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Value1Mantissa.Font = New System.Drawing.Font("Consolas", 12.0!)
        Me.Value1Mantissa.ForeColor = System.Drawing.Color.GreenYellow
        Me.Value1Mantissa.Location = New System.Drawing.Point(24, 69)
        Me.Value1Mantissa.Margin = New System.Windows.Forms.Padding(0, 0, 0, 3)
        Me.Value1Mantissa.Name = "Value1Mantissa"
        Me.Value1Mantissa.Size = New System.Drawing.Size(128, 22)
        Me.Value1Mantissa.TabIndex = 0
        Me.Value1Mantissa.Text = "-1.234567890"
        Me.Value1Mantissa.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Value1Exponent
        '
        Me.Value1Exponent.BackColor = System.Drawing.Color.Black
        Me.Value1Exponent.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Value1Exponent.Font = New System.Drawing.Font("Consolas", 12.0!)
        Me.Value1Exponent.ForeColor = System.Drawing.Color.GreenYellow
        Me.Value1Exponent.Location = New System.Drawing.Point(152, 69)
        Me.Value1Exponent.Margin = New System.Windows.Forms.Padding(0, 0, 0, 3)
        Me.Value1Exponent.Name = "Value1Exponent"
        Me.Value1Exponent.Size = New System.Drawing.Size(74, 22)
        Me.Value1Exponent.TabIndex = 1
        Me.Value1Exponent.Text = "×10⁻⁹⁹"
        Me.Value1Exponent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'NumPad7
        '
        Me.NumPad7.BackColor = System.Drawing.SystemColors.Control
        Me.NumPad7.Font = New System.Drawing.Font("Calibri", 14.0!)
        Me.NumPad7.ForeColor = System.Drawing.Color.White
        Me.NumPad7.Location = New System.Drawing.Point(221, 173)
        Me.NumPad7.Margin = New System.Windows.Forms.Padding(2, 3, 3, 3)
        Me.NumPad7.Name = "NumPad7"
        Me.NumPad7.Size = New System.Drawing.Size(48, 32)
        Me.NumPad7.TabIndex = 2
        Me.NumPad7.TabStop = False
        Me.NumPad7.Tag = "numeral"
        Me.NumPad7.Text = "7"
        Me.NumPad7.UseVisualStyleBackColor = True
        '
        'NumPad8
        '
        Me.NumPad8.BackColor = System.Drawing.SystemColors.Control
        Me.NumPad8.Font = New System.Drawing.Font("Calibri", 14.0!)
        Me.NumPad8.ForeColor = System.Drawing.Color.White
        Me.NumPad8.Location = New System.Drawing.Point(274, 173)
        Me.NumPad8.Margin = New System.Windows.Forms.Padding(2, 3, 3, 3)
        Me.NumPad8.Name = "NumPad8"
        Me.NumPad8.Size = New System.Drawing.Size(48, 32)
        Me.NumPad8.TabIndex = 3
        Me.NumPad8.TabStop = False
        Me.NumPad8.Tag = "numeral"
        Me.NumPad8.Text = "8"
        Me.NumPad8.UseVisualStyleBackColor = True
        '
        'NumPad9
        '
        Me.NumPad9.BackColor = System.Drawing.SystemColors.Control
        Me.NumPad9.Font = New System.Drawing.Font("Calibri", 14.0!)
        Me.NumPad9.ForeColor = System.Drawing.Color.White
        Me.NumPad9.Location = New System.Drawing.Point(327, 173)
        Me.NumPad9.Margin = New System.Windows.Forms.Padding(2, 3, 3, 3)
        Me.NumPad9.Name = "NumPad9"
        Me.NumPad9.Size = New System.Drawing.Size(48, 32)
        Me.NumPad9.TabIndex = 4
        Me.NumPad9.TabStop = False
        Me.NumPad9.Tag = "numeral"
        Me.NumPad9.Text = "9"
        Me.NumPad9.UseVisualStyleBackColor = True
        '
        'NumPad6
        '
        Me.NumPad6.BackColor = System.Drawing.SystemColors.Control
        Me.NumPad6.Font = New System.Drawing.Font("Calibri", 14.0!)
        Me.NumPad6.ForeColor = System.Drawing.Color.White
        Me.NumPad6.Location = New System.Drawing.Point(327, 211)
        Me.NumPad6.Margin = New System.Windows.Forms.Padding(2, 3, 3, 3)
        Me.NumPad6.Name = "NumPad6"
        Me.NumPad6.Size = New System.Drawing.Size(48, 32)
        Me.NumPad6.TabIndex = 7
        Me.NumPad6.TabStop = False
        Me.NumPad6.Tag = "numeral"
        Me.NumPad6.Text = "6"
        Me.NumPad6.UseVisualStyleBackColor = True
        '
        'NumPad5
        '
        Me.NumPad5.BackColor = System.Drawing.SystemColors.Control
        Me.NumPad5.Font = New System.Drawing.Font("Calibri", 14.0!)
        Me.NumPad5.ForeColor = System.Drawing.Color.White
        Me.NumPad5.Location = New System.Drawing.Point(274, 211)
        Me.NumPad5.Margin = New System.Windows.Forms.Padding(2, 3, 3, 3)
        Me.NumPad5.Name = "NumPad5"
        Me.NumPad5.Size = New System.Drawing.Size(48, 32)
        Me.NumPad5.TabIndex = 6
        Me.NumPad5.TabStop = False
        Me.NumPad5.Tag = "numeral"
        Me.NumPad5.Text = "5"
        Me.NumPad5.UseVisualStyleBackColor = True
        '
        'NumPad4
        '
        Me.NumPad4.BackColor = System.Drawing.SystemColors.Control
        Me.NumPad4.Font = New System.Drawing.Font("Calibri", 14.0!)
        Me.NumPad4.ForeColor = System.Drawing.Color.White
        Me.NumPad4.Location = New System.Drawing.Point(221, 211)
        Me.NumPad4.Margin = New System.Windows.Forms.Padding(2, 3, 3, 3)
        Me.NumPad4.Name = "NumPad4"
        Me.NumPad4.Size = New System.Drawing.Size(48, 32)
        Me.NumPad4.TabIndex = 5
        Me.NumPad4.TabStop = False
        Me.NumPad4.Tag = "numeral"
        Me.NumPad4.Text = "4"
        Me.NumPad4.UseVisualStyleBackColor = True
        '
        'NumPad3
        '
        Me.NumPad3.BackColor = System.Drawing.SystemColors.Control
        Me.NumPad3.Font = New System.Drawing.Font("Calibri", 14.0!)
        Me.NumPad3.ForeColor = System.Drawing.Color.White
        Me.NumPad3.Location = New System.Drawing.Point(327, 249)
        Me.NumPad3.Margin = New System.Windows.Forms.Padding(2, 3, 3, 3)
        Me.NumPad3.Name = "NumPad3"
        Me.NumPad3.Size = New System.Drawing.Size(48, 32)
        Me.NumPad3.TabIndex = 10
        Me.NumPad3.TabStop = False
        Me.NumPad3.Tag = "numeral"
        Me.NumPad3.Text = "3"
        Me.NumPad3.UseVisualStyleBackColor = True
        '
        'NumPad2
        '
        Me.NumPad2.BackColor = System.Drawing.SystemColors.Control
        Me.NumPad2.Font = New System.Drawing.Font("Calibri", 14.0!)
        Me.NumPad2.ForeColor = System.Drawing.Color.White
        Me.NumPad2.Location = New System.Drawing.Point(274, 249)
        Me.NumPad2.Margin = New System.Windows.Forms.Padding(2, 3, 3, 3)
        Me.NumPad2.Name = "NumPad2"
        Me.NumPad2.Size = New System.Drawing.Size(48, 32)
        Me.NumPad2.TabIndex = 9
        Me.NumPad2.TabStop = False
        Me.NumPad2.Tag = "numeral"
        Me.NumPad2.Text = "2"
        Me.NumPad2.UseVisualStyleBackColor = True
        '
        'NumPad1
        '
        Me.NumPad1.BackColor = System.Drawing.SystemColors.Control
        Me.NumPad1.Font = New System.Drawing.Font("Calibri", 14.0!)
        Me.NumPad1.ForeColor = System.Drawing.Color.White
        Me.NumPad1.Location = New System.Drawing.Point(221, 249)
        Me.NumPad1.Margin = New System.Windows.Forms.Padding(2, 3, 3, 3)
        Me.NumPad1.Name = "NumPad1"
        Me.NumPad1.Size = New System.Drawing.Size(48, 32)
        Me.NumPad1.TabIndex = 8
        Me.NumPad1.TabStop = False
        Me.NumPad1.Tag = "numeral"
        Me.NumPad1.Text = "1"
        Me.NumPad1.UseVisualStyleBackColor = True
        '
        'NumPad0
        '
        Me.NumPad0.BackColor = System.Drawing.SystemColors.Control
        Me.NumPad0.Font = New System.Drawing.Font("Calibri", 14.0!)
        Me.NumPad0.ForeColor = System.Drawing.Color.White
        Me.NumPad0.Location = New System.Drawing.Point(221, 287)
        Me.NumPad0.Margin = New System.Windows.Forms.Padding(2, 3, 3, 3)
        Me.NumPad0.Name = "NumPad0"
        Me.NumPad0.Size = New System.Drawing.Size(101, 32)
        Me.NumPad0.TabIndex = 11
        Me.NumPad0.TabStop = False
        Me.NumPad0.Tag = "numeral"
        Me.NumPad0.Text = "0"
        Me.NumPad0.UseVisualStyleBackColor = True
        '
        'NumPadDecimal
        '
        Me.NumPadDecimal.BackColor = System.Drawing.SystemColors.Control
        Me.NumPadDecimal.Font = New System.Drawing.Font("Calibri", 14.0!)
        Me.NumPadDecimal.ForeColor = System.Drawing.Color.White
        Me.NumPadDecimal.Location = New System.Drawing.Point(327, 287)
        Me.NumPadDecimal.Margin = New System.Windows.Forms.Padding(2, 3, 3, 3)
        Me.NumPadDecimal.Name = "NumPadDecimal"
        Me.NumPadDecimal.Size = New System.Drawing.Size(48, 32)
        Me.NumPadDecimal.TabIndex = 12
        Me.NumPadDecimal.TabStop = False
        Me.NumPadDecimal.Tag = "numeral"
        Me.NumPadDecimal.Text = "."
        Me.NumPadDecimal.UseVisualStyleBackColor = True
        '
        'EnterButton
        '
        Me.EnterButton.BackColor = System.Drawing.SystemColors.Control
        Me.EnterButton.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.EnterButton.ForeColor = System.Drawing.Color.White
        Me.EnterButton.Location = New System.Drawing.Point(380, 249)
        Me.EnterButton.Margin = New System.Windows.Forms.Padding(2, 3, 3, 3)
        Me.EnterButton.Name = "EnterButton"
        Me.EnterButton.Size = New System.Drawing.Size(48, 70)
        Me.EnterButton.TabIndex = 13
        Me.EnterButton.TabStop = False
        Me.EnterButton.Tag = "enter"
        Me.EnterButton.Text = "Enter"
        Me.EnterButton.UseVisualStyleBackColor = True
        '
        'Value2Exponent
        '
        Me.Value2Exponent.BackColor = System.Drawing.Color.Black
        Me.Value2Exponent.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Value2Exponent.Font = New System.Drawing.Font("Consolas", 11.0!)
        Me.Value2Exponent.ForeColor = System.Drawing.Color.GreenYellow
        Me.Value2Exponent.Location = New System.Drawing.Point(152, 49)
        Me.Value2Exponent.Margin = New System.Windows.Forms.Padding(0)
        Me.Value2Exponent.Name = "Value2Exponent"
        Me.Value2Exponent.Size = New System.Drawing.Size(74, 20)
        Me.Value2Exponent.TabIndex = 15
        Me.Value2Exponent.Text = "×10⁻⁹⁹"
        Me.Value2Exponent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Value2Mantissa
        '
        Me.Value2Mantissa.BackColor = System.Drawing.Color.Black
        Me.Value2Mantissa.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Value2Mantissa.Font = New System.Drawing.Font("Consolas", 11.0!)
        Me.Value2Mantissa.ForeColor = System.Drawing.Color.GreenYellow
        Me.Value2Mantissa.Location = New System.Drawing.Point(24, 49)
        Me.Value2Mantissa.Margin = New System.Windows.Forms.Padding(0)
        Me.Value2Mantissa.Name = "Value2Mantissa"
        Me.Value2Mantissa.Size = New System.Drawing.Size(128, 20)
        Me.Value2Mantissa.TabIndex = 14
        Me.Value2Mantissa.Text = "-1.234567890"
        Me.Value2Mantissa.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Value3Exponent
        '
        Me.Value3Exponent.BackColor = System.Drawing.Color.Black
        Me.Value3Exponent.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Value3Exponent.Font = New System.Drawing.Font("Consolas", 11.0!)
        Me.Value3Exponent.ForeColor = System.Drawing.Color.GreenYellow
        Me.Value3Exponent.Location = New System.Drawing.Point(152, 29)
        Me.Value3Exponent.Margin = New System.Windows.Forms.Padding(0)
        Me.Value3Exponent.Name = "Value3Exponent"
        Me.Value3Exponent.Size = New System.Drawing.Size(74, 20)
        Me.Value3Exponent.TabIndex = 17
        Me.Value3Exponent.Text = "×10⁻⁹⁹"
        Me.Value3Exponent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Value3Mantissa
        '
        Me.Value3Mantissa.BackColor = System.Drawing.Color.Black
        Me.Value3Mantissa.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Value3Mantissa.Font = New System.Drawing.Font("Consolas", 11.0!)
        Me.Value3Mantissa.ForeColor = System.Drawing.Color.GreenYellow
        Me.Value3Mantissa.Location = New System.Drawing.Point(24, 29)
        Me.Value3Mantissa.Margin = New System.Windows.Forms.Padding(0)
        Me.Value3Mantissa.Name = "Value3Mantissa"
        Me.Value3Mantissa.Size = New System.Drawing.Size(128, 20)
        Me.Value3Mantissa.TabIndex = 16
        Me.Value3Mantissa.Text = "-1.234567890"
        Me.Value3Mantissa.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Value4Exponent
        '
        Me.Value4Exponent.BackColor = System.Drawing.Color.Black
        Me.Value4Exponent.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Value4Exponent.Font = New System.Drawing.Font("Consolas", 11.0!)
        Me.Value4Exponent.ForeColor = System.Drawing.Color.GreenYellow
        Me.Value4Exponent.Location = New System.Drawing.Point(152, 9)
        Me.Value4Exponent.Margin = New System.Windows.Forms.Padding(0)
        Me.Value4Exponent.Name = "Value4Exponent"
        Me.Value4Exponent.Size = New System.Drawing.Size(74, 20)
        Me.Value4Exponent.TabIndex = 19
        Me.Value4Exponent.Text = "×10⁻⁹⁹"
        Me.Value4Exponent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Value4Mantissa
        '
        Me.Value4Mantissa.BackColor = System.Drawing.Color.Black
        Me.Value4Mantissa.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Value4Mantissa.Font = New System.Drawing.Font("Consolas", 11.0!)
        Me.Value4Mantissa.ForeColor = System.Drawing.Color.GreenYellow
        Me.Value4Mantissa.Location = New System.Drawing.Point(24, 9)
        Me.Value4Mantissa.Margin = New System.Windows.Forms.Padding(0)
        Me.Value4Mantissa.Name = "Value4Mantissa"
        Me.Value4Mantissa.Size = New System.Drawing.Size(128, 20)
        Me.Value4Mantissa.TabIndex = 18
        Me.Value4Mantissa.Text = "-1.234567890"
        Me.Value4Mantissa.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'AdditionButton
        '
        Me.AdditionButton.BackColor = System.Drawing.SystemColors.Control
        Me.AdditionButton.Font = New System.Drawing.Font("Calibri", 14.0!)
        Me.AdditionButton.ForeColor = System.Drawing.Color.White
        Me.AdditionButton.Location = New System.Drawing.Point(380, 173)
        Me.AdditionButton.Margin = New System.Windows.Forms.Padding(2, 3, 3, 3)
        Me.AdditionButton.Name = "AdditionButton"
        Me.AdditionButton.Size = New System.Drawing.Size(48, 70)
        Me.AdditionButton.TabIndex = 20
        Me.AdditionButton.TabStop = False
        Me.AdditionButton.Tag = "operator"
        Me.AdditionButton.Text = "+"
        Me.AdditionButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(9, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(15, 20)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "T"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(9, 29)
        Me.Label2.Margin = New System.Windows.Forms.Padding(0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(15, 20)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Z"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(9, 49)
        Me.Label3.Margin = New System.Windows.Forms.Padding(0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(15, 20)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Y"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(9, 69)
        Me.Label4.Margin = New System.Windows.Forms.Padding(0, 0, 0, 3)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(15, 22)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "X"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SubtractionButton
        '
        Me.SubtractionButton.BackColor = System.Drawing.SystemColors.Control
        Me.SubtractionButton.Font = New System.Drawing.Font("Calibri", 14.0!)
        Me.SubtractionButton.ForeColor = System.Drawing.Color.White
        Me.SubtractionButton.Location = New System.Drawing.Point(380, 135)
        Me.SubtractionButton.Margin = New System.Windows.Forms.Padding(2, 3, 3, 3)
        Me.SubtractionButton.Name = "SubtractionButton"
        Me.SubtractionButton.Size = New System.Drawing.Size(48, 32)
        Me.SubtractionButton.TabIndex = 25
        Me.SubtractionButton.TabStop = False
        Me.SubtractionButton.Tag = "operator"
        Me.SubtractionButton.Text = "−"
        Me.SubtractionButton.UseVisualStyleBackColor = True
        '
        'MultiplicationButton
        '
        Me.MultiplicationButton.BackColor = System.Drawing.SystemColors.Control
        Me.MultiplicationButton.Font = New System.Drawing.Font("Calibri", 14.0!)
        Me.MultiplicationButton.ForeColor = System.Drawing.Color.White
        Me.MultiplicationButton.Location = New System.Drawing.Point(327, 135)
        Me.MultiplicationButton.Margin = New System.Windows.Forms.Padding(2, 3, 3, 3)
        Me.MultiplicationButton.Name = "MultiplicationButton"
        Me.MultiplicationButton.Size = New System.Drawing.Size(48, 32)
        Me.MultiplicationButton.TabIndex = 26
        Me.MultiplicationButton.TabStop = False
        Me.MultiplicationButton.Tag = "operator"
        Me.MultiplicationButton.Text = "×"
        Me.MultiplicationButton.UseVisualStyleBackColor = True
        '
        'DivisionButton
        '
        Me.DivisionButton.BackColor = System.Drawing.SystemColors.Control
        Me.DivisionButton.Font = New System.Drawing.Font("Calibri", 14.0!)
        Me.DivisionButton.ForeColor = System.Drawing.Color.White
        Me.DivisionButton.Location = New System.Drawing.Point(274, 135)
        Me.DivisionButton.Margin = New System.Windows.Forms.Padding(2, 3, 3, 3)
        Me.DivisionButton.Name = "DivisionButton"
        Me.DivisionButton.Size = New System.Drawing.Size(48, 32)
        Me.DivisionButton.TabIndex = 27
        Me.DivisionButton.TabStop = False
        Me.DivisionButton.Tag = "operator"
        Me.DivisionButton.Text = "÷"
        Me.DivisionButton.UseVisualStyleBackColor = True
        '
        'NegateSignButton
        '
        Me.NegateSignButton.BackColor = System.Drawing.SystemColors.Control
        Me.NegateSignButton.Font = New System.Drawing.Font("Calibri", 11.25!)
        Me.NegateSignButton.ForeColor = System.Drawing.Color.White
        Me.NegateSignButton.Location = New System.Drawing.Point(221, 135)
        Me.NegateSignButton.Margin = New System.Windows.Forms.Padding(2, 3, 3, 3)
        Me.NegateSignButton.Name = "NegateSignButton"
        Me.NegateSignButton.Size = New System.Drawing.Size(48, 32)
        Me.NegateSignButton.TabIndex = 28
        Me.NegateSignButton.TabStop = False
        Me.NegateSignButton.Tag = "operator"
        Me.NegateSignButton.Text = "+/−"
        Me.NegateSignButton.UseVisualStyleBackColor = True
        '
        'RotateButton
        '
        Me.RotateButton.BackColor = System.Drawing.SystemColors.Control
        Me.RotateButton.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.RotateButton.ForeColor = System.Drawing.Color.White
        Me.RotateButton.Location = New System.Drawing.Point(115, 135)
        Me.RotateButton.Margin = New System.Windows.Forms.Padding(2, 3, 3, 3)
        Me.RotateButton.Name = "RotateButton"
        Me.RotateButton.Size = New System.Drawing.Size(48, 32)
        Me.RotateButton.TabIndex = 32
        Me.RotateButton.TabStop = False
        Me.RotateButton.Tag = "stackedit"
        Me.RotateButton.Text = "R↓"
        Me.RotateButton.UseVisualStyleBackColor = True
        '
        'SwapButton
        '
        Me.SwapButton.BackColor = System.Drawing.SystemColors.Control
        Me.SwapButton.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.SwapButton.ForeColor = System.Drawing.Color.White
        Me.SwapButton.Location = New System.Drawing.Point(168, 135)
        Me.SwapButton.Margin = New System.Windows.Forms.Padding(2, 3, 3, 3)
        Me.SwapButton.Name = "SwapButton"
        Me.SwapButton.Size = New System.Drawing.Size(48, 32)
        Me.SwapButton.TabIndex = 31
        Me.SwapButton.TabStop = False
        Me.SwapButton.Tag = "stackedit"
        Me.SwapButton.Text = "X↔Y"
        Me.SwapButton.UseVisualStyleBackColor = True
        '
        'DeleteButton
        '
        Me.DeleteButton.BackColor = System.Drawing.SystemColors.Control
        Me.DeleteButton.Font = New System.Drawing.Font("Calibri", 11.25!)
        Me.DeleteButton.ForeColor = System.Drawing.Color.White
        Me.DeleteButton.Location = New System.Drawing.Point(274, 97)
        Me.DeleteButton.Margin = New System.Windows.Forms.Padding(2, 3, 3, 3)
        Me.DeleteButton.Name = "DeleteButton"
        Me.DeleteButton.Size = New System.Drawing.Size(48, 32)
        Me.DeleteButton.TabIndex = 30
        Me.DeleteButton.TabStop = False
        Me.DeleteButton.Tag = "del"
        Me.DeleteButton.Text = "Del"
        Me.DeleteButton.UseVisualStyleBackColor = True
        '
        'ClearEntryButton
        '
        Me.ClearEntryButton.BackColor = System.Drawing.SystemColors.Control
        Me.ClearEntryButton.Font = New System.Drawing.Font("Calibri", 11.25!)
        Me.ClearEntryButton.ForeColor = System.Drawing.Color.White
        Me.ClearEntryButton.Location = New System.Drawing.Point(327, 97)
        Me.ClearEntryButton.Margin = New System.Windows.Forms.Padding(2, 3, 3, 3)
        Me.ClearEntryButton.Name = "ClearEntryButton"
        Me.ClearEntryButton.Size = New System.Drawing.Size(48, 32)
        Me.ClearEntryButton.TabIndex = 29
        Me.ClearEntryButton.TabStop = False
        Me.ClearEntryButton.Tag = "clear"
        Me.ClearEntryButton.Text = "CE"
        Me.ClearEntryButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.BackColor = System.Drawing.SystemColors.Control
        Me.ClearButton.Font = New System.Drawing.Font("Calibri", 11.25!)
        Me.ClearButton.ForeColor = System.Drawing.Color.White
        Me.ClearButton.Location = New System.Drawing.Point(380, 97)
        Me.ClearButton.Margin = New System.Windows.Forms.Padding(2, 3, 3, 3)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(48, 32)
        Me.ClearButton.TabIndex = 33
        Me.ClearButton.TabStop = False
        Me.ClearButton.Tag = "clear"
        Me.ClearButton.Text = "C"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'BlinkTimer
        '
        Me.BlinkTimer.Interval = 83
        '
        'Value4iExponent
        '
        Me.Value4iExponent.BackColor = System.Drawing.Color.Black
        Me.Value4iExponent.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Value4iExponent.Font = New System.Drawing.Font("Consolas", 11.0!)
        Me.Value4iExponent.ForeColor = System.Drawing.Color.GreenYellow
        Me.Value4iExponent.Location = New System.Drawing.Point(354, 9)
        Me.Value4iExponent.Margin = New System.Windows.Forms.Padding(0)
        Me.Value4iExponent.Name = "Value4iExponent"
        Me.Value4iExponent.Size = New System.Drawing.Size(74, 20)
        Me.Value4iExponent.TabIndex = 58
        Me.Value4iExponent.Text = "×10⁻⁹⁹i"
        Me.Value4iExponent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Value4iMantissa
        '
        Me.Value4iMantissa.BackColor = System.Drawing.Color.Black
        Me.Value4iMantissa.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Value4iMantissa.Font = New System.Drawing.Font("Consolas", 11.0!)
        Me.Value4iMantissa.ForeColor = System.Drawing.Color.GreenYellow
        Me.Value4iMantissa.Location = New System.Drawing.Point(226, 9)
        Me.Value4iMantissa.Margin = New System.Windows.Forms.Padding(0)
        Me.Value4iMantissa.Name = "Value4iMantissa"
        Me.Value4iMantissa.Size = New System.Drawing.Size(128, 20)
        Me.Value4iMantissa.TabIndex = 57
        Me.Value4iMantissa.Text = "-1.234567890"
        Me.Value4iMantissa.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Value3iExponent
        '
        Me.Value3iExponent.BackColor = System.Drawing.Color.Black
        Me.Value3iExponent.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Value3iExponent.Font = New System.Drawing.Font("Consolas", 11.0!)
        Me.Value3iExponent.ForeColor = System.Drawing.Color.GreenYellow
        Me.Value3iExponent.Location = New System.Drawing.Point(354, 29)
        Me.Value3iExponent.Margin = New System.Windows.Forms.Padding(0)
        Me.Value3iExponent.Name = "Value3iExponent"
        Me.Value3iExponent.Size = New System.Drawing.Size(74, 20)
        Me.Value3iExponent.TabIndex = 56
        Me.Value3iExponent.Text = "×10⁻⁹⁹i"
        Me.Value3iExponent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Value3iMantissa
        '
        Me.Value3iMantissa.BackColor = System.Drawing.Color.Black
        Me.Value3iMantissa.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Value3iMantissa.Font = New System.Drawing.Font("Consolas", 11.0!)
        Me.Value3iMantissa.ForeColor = System.Drawing.Color.GreenYellow
        Me.Value3iMantissa.Location = New System.Drawing.Point(226, 29)
        Me.Value3iMantissa.Margin = New System.Windows.Forms.Padding(0)
        Me.Value3iMantissa.Name = "Value3iMantissa"
        Me.Value3iMantissa.Size = New System.Drawing.Size(128, 20)
        Me.Value3iMantissa.TabIndex = 55
        Me.Value3iMantissa.Text = "-1.234567890"
        Me.Value3iMantissa.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Value2iExponent
        '
        Me.Value2iExponent.BackColor = System.Drawing.Color.Black
        Me.Value2iExponent.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Value2iExponent.Font = New System.Drawing.Font("Consolas", 11.0!)
        Me.Value2iExponent.ForeColor = System.Drawing.Color.GreenYellow
        Me.Value2iExponent.Location = New System.Drawing.Point(354, 49)
        Me.Value2iExponent.Margin = New System.Windows.Forms.Padding(0)
        Me.Value2iExponent.Name = "Value2iExponent"
        Me.Value2iExponent.Size = New System.Drawing.Size(74, 20)
        Me.Value2iExponent.TabIndex = 54
        Me.Value2iExponent.Text = "×10⁻⁹⁹i"
        Me.Value2iExponent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Value2iMantissa
        '
        Me.Value2iMantissa.BackColor = System.Drawing.Color.Black
        Me.Value2iMantissa.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Value2iMantissa.Font = New System.Drawing.Font("Consolas", 11.0!)
        Me.Value2iMantissa.ForeColor = System.Drawing.Color.GreenYellow
        Me.Value2iMantissa.Location = New System.Drawing.Point(226, 49)
        Me.Value2iMantissa.Margin = New System.Windows.Forms.Padding(0)
        Me.Value2iMantissa.Name = "Value2iMantissa"
        Me.Value2iMantissa.Size = New System.Drawing.Size(128, 20)
        Me.Value2iMantissa.TabIndex = 53
        Me.Value2iMantissa.Text = "-1.234567890"
        Me.Value2iMantissa.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Value1iExponent
        '
        Me.Value1iExponent.BackColor = System.Drawing.Color.Black
        Me.Value1iExponent.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Value1iExponent.Font = New System.Drawing.Font("Consolas", 12.0!)
        Me.Value1iExponent.ForeColor = System.Drawing.Color.GreenYellow
        Me.Value1iExponent.Location = New System.Drawing.Point(354, 69)
        Me.Value1iExponent.Margin = New System.Windows.Forms.Padding(0, 0, 0, 3)
        Me.Value1iExponent.Name = "Value1iExponent"
        Me.Value1iExponent.Size = New System.Drawing.Size(74, 22)
        Me.Value1iExponent.TabIndex = 52
        Me.Value1iExponent.Text = "×10⁻⁹⁹i"
        Me.Value1iExponent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Value1iMantissa
        '
        Me.Value1iMantissa.BackColor = System.Drawing.Color.Black
        Me.Value1iMantissa.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Value1iMantissa.Font = New System.Drawing.Font("Consolas", 12.0!)
        Me.Value1iMantissa.ForeColor = System.Drawing.Color.GreenYellow
        Me.Value1iMantissa.Location = New System.Drawing.Point(226, 69)
        Me.Value1iMantissa.Margin = New System.Windows.Forms.Padding(0, 0, 0, 3)
        Me.Value1iMantissa.Name = "Value1iMantissa"
        Me.Value1iMantissa.Size = New System.Drawing.Size(128, 22)
        Me.Value1iMantissa.TabIndex = 51
        Me.Value1iMantissa.Text = "-1.234567890"
        Me.Value1iMantissa.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'SwitchComplexCursor
        '
        Me.SwitchComplexCursor.BackColor = System.Drawing.SystemColors.Control
        Me.SwitchComplexCursor.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.SwitchComplexCursor.ForeColor = System.Drawing.Color.White
        Me.SwitchComplexCursor.Location = New System.Drawing.Point(168, 97)
        Me.SwitchComplexCursor.Margin = New System.Windows.Forms.Padding(2, 3, 3, 3)
        Me.SwitchComplexCursor.Name = "SwitchComplexCursor"
        Me.SwitchComplexCursor.Size = New System.Drawing.Size(48, 32)
        Me.SwitchComplexCursor.TabIndex = 61
        Me.SwitchComplexCursor.TabStop = False
        Me.SwitchComplexCursor.Tag = "operator"
        Me.SwitchComplexCursor.Text = "Re/Im"
        Me.SwitchComplexCursor.UseVisualStyleBackColor = True
        '
        'PolarSwitch
        '
        Me.PolarSwitch.Appearance = System.Windows.Forms.Appearance.Button
        Me.PolarSwitch.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.PolarSwitch.ForeColor = System.Drawing.Color.White
        Me.PolarSwitch.Location = New System.Drawing.Point(62, 97)
        Me.PolarSwitch.Margin = New System.Windows.Forms.Padding(2, 3, 3, 3)
        Me.PolarSwitch.Name = "PolarSwitch"
        Me.PolarSwitch.Size = New System.Drawing.Size(48, 32)
        Me.PolarSwitch.TabIndex = 62
        Me.PolarSwitch.TabStop = False
        Me.PolarSwitch.Tag = "switch"
        Me.PolarSwitch.Text = "Polar"
        Me.PolarSwitch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.PolarSwitch.UseVisualStyleBackColor = True
        '
        'DegreeSwitch
        '
        Me.DegreeSwitch.Appearance = System.Windows.Forms.Appearance.Button
        Me.DegreeSwitch.Font = New System.Drawing.Font("Calibri", 11.25!)
        Me.DegreeSwitch.ForeColor = System.Drawing.Color.White
        Me.DegreeSwitch.Location = New System.Drawing.Point(62, 135)
        Me.DegreeSwitch.Margin = New System.Windows.Forms.Padding(2, 3, 3, 3)
        Me.DegreeSwitch.Name = "DegreeSwitch"
        Me.DegreeSwitch.Size = New System.Drawing.Size(48, 32)
        Me.DegreeSwitch.TabIndex = 63
        Me.DegreeSwitch.TabStop = False
        Me.DegreeSwitch.Tag = "switch"
        Me.DegreeSwitch.Text = "Deg"
        Me.DegreeSwitch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.DegreeSwitch.UseVisualStyleBackColor = True
        '
        'NaturalLogarithm
        '
        Me.NaturalLogarithm.BackColor = System.Drawing.SystemColors.Control
        Me.NaturalLogarithm.Font = New System.Drawing.Font("Calibri", 11.25!)
        Me.NaturalLogarithm.ForeColor = System.Drawing.Color.White
        Me.NaturalLogarithm.Location = New System.Drawing.Point(168, 249)
        Me.NaturalLogarithm.Margin = New System.Windows.Forms.Padding(2, 3, 3, 3)
        Me.NaturalLogarithm.Name = "NaturalLogarithm"
        Me.NaturalLogarithm.Size = New System.Drawing.Size(48, 32)
        Me.NaturalLogarithm.TabIndex = 64
        Me.NaturalLogarithm.TabStop = False
        Me.NaturalLogarithm.Tag = "function"
        Me.NaturalLogarithm.Text = "ln"
        Me.NaturalLogarithm.UseVisualStyleBackColor = True
        '
        'CommonLogarithm
        '
        Me.CommonLogarithm.BackColor = System.Drawing.SystemColors.Control
        Me.CommonLogarithm.Font = New System.Drawing.Font("Calibri", 11.25!)
        Me.CommonLogarithm.ForeColor = System.Drawing.Color.White
        Me.CommonLogarithm.Location = New System.Drawing.Point(168, 211)
        Me.CommonLogarithm.Margin = New System.Windows.Forms.Padding(2, 3, 3, 3)
        Me.CommonLogarithm.Name = "CommonLogarithm"
        Me.CommonLogarithm.Size = New System.Drawing.Size(48, 32)
        Me.CommonLogarithm.TabIndex = 65
        Me.CommonLogarithm.TabStop = False
        Me.CommonLogarithm.Tag = "function"
        Me.CommonLogarithm.Text = "log₁₀"
        Me.CommonLogarithm.UseVisualStyleBackColor = True
        '
        'SquareButton
        '
        Me.SquareButton.BackColor = System.Drawing.SystemColors.Control
        Me.SquareButton.Font = New System.Drawing.Font("Calibri", 11.25!)
        Me.SquareButton.ForeColor = System.Drawing.Color.White
        Me.SquareButton.Location = New System.Drawing.Point(115, 173)
        Me.SquareButton.Margin = New System.Windows.Forms.Padding(2, 3, 3, 3)
        Me.SquareButton.Name = "SquareButton"
        Me.SquareButton.Size = New System.Drawing.Size(48, 32)
        Me.SquareButton.TabIndex = 66
        Me.SquareButton.TabStop = False
        Me.SquareButton.Tag = "function"
        Me.SquareButton.Text = "x²"
        Me.SquareButton.UseVisualStyleBackColor = True
        '
        'SquareRoot
        '
        Me.SquareRoot.BackColor = System.Drawing.SystemColors.Control
        Me.SquareRoot.Font = New System.Drawing.Font("Calibri", 11.25!)
        Me.SquareRoot.ForeColor = System.Drawing.Color.White
        Me.SquareRoot.Location = New System.Drawing.Point(168, 173)
        Me.SquareRoot.Margin = New System.Windows.Forms.Padding(2, 3, 3, 3)
        Me.SquareRoot.Name = "SquareRoot"
        Me.SquareRoot.Size = New System.Drawing.Size(48, 32)
        Me.SquareRoot.TabIndex = 67
        Me.SquareRoot.TabStop = False
        Me.SquareRoot.Tag = "function"
        Me.SquareRoot.Text = "√x"
        Me.SquareRoot.UseVisualStyleBackColor = True
        '
        'ExponentButton
        '
        Me.ExponentButton.BackColor = System.Drawing.SystemColors.Control
        Me.ExponentButton.Font = New System.Drawing.Font("Calibri", 11.25!)
        Me.ExponentButton.ForeColor = System.Drawing.Color.White
        Me.ExponentButton.Location = New System.Drawing.Point(115, 211)
        Me.ExponentButton.Margin = New System.Windows.Forms.Padding(2, 3, 3, 3)
        Me.ExponentButton.Name = "ExponentButton"
        Me.ExponentButton.Size = New System.Drawing.Size(48, 32)
        Me.ExponentButton.TabIndex = 68
        Me.ExponentButton.TabStop = False
        Me.ExponentButton.Tag = "function"
        Me.ExponentButton.Text = "yˣ"
        Me.ExponentButton.UseVisualStyleBackColor = True
        '
        'InvertSwitch
        '
        Me.InvertSwitch.Appearance = System.Windows.Forms.Appearance.Button
        Me.InvertSwitch.Font = New System.Drawing.Font("Calibri", 11.25!)
        Me.InvertSwitch.ForeColor = System.Drawing.Color.White
        Me.InvertSwitch.Location = New System.Drawing.Point(9, 135)
        Me.InvertSwitch.Margin = New System.Windows.Forms.Padding(2, 3, 3, 3)
        Me.InvertSwitch.Name = "InvertSwitch"
        Me.InvertSwitch.Size = New System.Drawing.Size(48, 32)
        Me.InvertSwitch.TabIndex = 69
        Me.InvertSwitch.TabStop = False
        Me.InvertSwitch.Tag = "function"
        Me.InvertSwitch.Text = "Inv"
        Me.InvertSwitch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.InvertSwitch.UseVisualStyleBackColor = True
        '
        'HyperbolicSwitch
        '
        Me.HyperbolicSwitch.Appearance = System.Windows.Forms.Appearance.Button
        Me.HyperbolicSwitch.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.HyperbolicSwitch.ForeColor = System.Drawing.Color.White
        Me.HyperbolicSwitch.Location = New System.Drawing.Point(62, 173)
        Me.HyperbolicSwitch.Margin = New System.Windows.Forms.Padding(2, 3, 3, 3)
        Me.HyperbolicSwitch.Name = "HyperbolicSwitch"
        Me.HyperbolicSwitch.Size = New System.Drawing.Size(48, 32)
        Me.HyperbolicSwitch.TabIndex = 70
        Me.HyperbolicSwitch.TabStop = False
        Me.HyperbolicSwitch.Tag = "function"
        Me.HyperbolicSwitch.Text = "Hyp"
        Me.HyperbolicSwitch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.HyperbolicSwitch.UseVisualStyleBackColor = True
        '
        'PiButton
        '
        Me.PiButton.BackColor = System.Drawing.SystemColors.Control
        Me.PiButton.Font = New System.Drawing.Font("Calibri", 11.25!)
        Me.PiButton.ForeColor = System.Drawing.Color.White
        Me.PiButton.Location = New System.Drawing.Point(115, 287)
        Me.PiButton.Margin = New System.Windows.Forms.Padding(2, 3, 3, 3)
        Me.PiButton.Name = "PiButton"
        Me.PiButton.Size = New System.Drawing.Size(48, 32)
        Me.PiButton.TabIndex = 72
        Me.PiButton.TabStop = False
        Me.PiButton.Tag = "function"
        Me.PiButton.Text = "π"
        Me.PiButton.UseVisualStyleBackColor = True
        '
        'FactorialButton
        '
        Me.FactorialButton.BackColor = System.Drawing.SystemColors.Control
        Me.FactorialButton.Font = New System.Drawing.Font("Calibri", 11.25!)
        Me.FactorialButton.ForeColor = System.Drawing.Color.White
        Me.FactorialButton.Location = New System.Drawing.Point(9, 173)
        Me.FactorialButton.Margin = New System.Windows.Forms.Padding(2, 3, 3, 3)
        Me.FactorialButton.Name = "FactorialButton"
        Me.FactorialButton.Size = New System.Drawing.Size(48, 32)
        Me.FactorialButton.TabIndex = 73
        Me.FactorialButton.TabStop = False
        Me.FactorialButton.Tag = "function"
        Me.FactorialButton.Text = "x!"
        Me.FactorialButton.UseVisualStyleBackColor = True
        '
        'SineButton
        '
        Me.SineButton.BackColor = System.Drawing.SystemColors.Control
        Me.SineButton.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.SineButton.ForeColor = System.Drawing.Color.White
        Me.SineButton.Location = New System.Drawing.Point(62, 211)
        Me.SineButton.Margin = New System.Windows.Forms.Padding(2, 3, 3, 3)
        Me.SineButton.Name = "SineButton"
        Me.SineButton.Size = New System.Drawing.Size(48, 32)
        Me.SineButton.TabIndex = 74
        Me.SineButton.TabStop = False
        Me.SineButton.Tag = "function"
        Me.SineButton.Text = "sin"
        Me.SineButton.UseVisualStyleBackColor = True
        '
        'CosineButton
        '
        Me.CosineButton.BackColor = System.Drawing.SystemColors.Control
        Me.CosineButton.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.CosineButton.ForeColor = System.Drawing.Color.White
        Me.CosineButton.Location = New System.Drawing.Point(62, 249)
        Me.CosineButton.Margin = New System.Windows.Forms.Padding(2, 3, 3, 3)
        Me.CosineButton.Name = "CosineButton"
        Me.CosineButton.Size = New System.Drawing.Size(48, 32)
        Me.CosineButton.TabIndex = 75
        Me.CosineButton.TabStop = False
        Me.CosineButton.Tag = "function"
        Me.CosineButton.Text = "cos"
        Me.CosineButton.UseVisualStyleBackColor = True
        '
        'TangentButton
        '
        Me.TangentButton.BackColor = System.Drawing.SystemColors.Control
        Me.TangentButton.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.TangentButton.ForeColor = System.Drawing.Color.White
        Me.TangentButton.Location = New System.Drawing.Point(62, 287)
        Me.TangentButton.Margin = New System.Windows.Forms.Padding(2, 3, 3, 3)
        Me.TangentButton.Name = "TangentButton"
        Me.TangentButton.Size = New System.Drawing.Size(48, 32)
        Me.TangentButton.TabIndex = 76
        Me.TangentButton.TabStop = False
        Me.TangentButton.Tag = "function"
        Me.TangentButton.Text = "tan"
        Me.TangentButton.UseVisualStyleBackColor = True
        '
        'InverseNumber
        '
        Me.InverseNumber.BackColor = System.Drawing.SystemColors.Control
        Me.InverseNumber.Font = New System.Drawing.Font("Calibri", 11.25!)
        Me.InverseNumber.ForeColor = System.Drawing.Color.White
        Me.InverseNumber.Location = New System.Drawing.Point(115, 249)
        Me.InverseNumber.Margin = New System.Windows.Forms.Padding(2, 3, 3, 3)
        Me.InverseNumber.Name = "InverseNumber"
        Me.InverseNumber.Size = New System.Drawing.Size(48, 32)
        Me.InverseNumber.TabIndex = 77
        Me.InverseNumber.TabStop = False
        Me.InverseNumber.Tag = "function"
        Me.InverseNumber.Text = "1/x"
        Me.InverseNumber.UseVisualStyleBackColor = True
        '
        'AbsoluteButton
        '
        Me.AbsoluteButton.BackColor = System.Drawing.SystemColors.Control
        Me.AbsoluteButton.Font = New System.Drawing.Font("Calibri", 11.25!)
        Me.AbsoluteButton.ForeColor = System.Drawing.Color.White
        Me.AbsoluteButton.Location = New System.Drawing.Point(9, 287)
        Me.AbsoluteButton.Margin = New System.Windows.Forms.Padding(2, 3, 3, 3)
        Me.AbsoluteButton.Name = "AbsoluteButton"
        Me.AbsoluteButton.Size = New System.Drawing.Size(48, 32)
        Me.AbsoluteButton.TabIndex = 78
        Me.AbsoluteButton.TabStop = False
        Me.AbsoluteButton.Tag = "function"
        Me.AbsoluteButton.Text = "|x|"
        Me.AbsoluteButton.UseVisualStyleBackColor = True
        '
        'ArgumentButton
        '
        Me.ArgumentButton.BackColor = System.Drawing.SystemColors.Control
        Me.ArgumentButton.Font = New System.Drawing.Font("Calibri", 11.25!)
        Me.ArgumentButton.ForeColor = System.Drawing.Color.White
        Me.ArgumentButton.Location = New System.Drawing.Point(9, 249)
        Me.ArgumentButton.Margin = New System.Windows.Forms.Padding(2, 3, 3, 3)
        Me.ArgumentButton.Name = "ArgumentButton"
        Me.ArgumentButton.Size = New System.Drawing.Size(48, 32)
        Me.ArgumentButton.TabIndex = 79
        Me.ArgumentButton.TabStop = False
        Me.ArgumentButton.Tag = "function"
        Me.ArgumentButton.Text = "Arg"
        Me.ArgumentButton.UseVisualStyleBackColor = True
        '
        'ConjugateButton
        '
        Me.ConjugateButton.BackColor = System.Drawing.SystemColors.Control
        Me.ConjugateButton.Font = New System.Drawing.Font("Calibri", 11.25!)
        Me.ConjugateButton.ForeColor = System.Drawing.Color.White
        Me.ConjugateButton.Location = New System.Drawing.Point(9, 211)
        Me.ConjugateButton.Margin = New System.Windows.Forms.Padding(2, 3, 3, 3)
        Me.ConjugateButton.Name = "ConjugateButton"
        Me.ConjugateButton.Size = New System.Drawing.Size(48, 32)
        Me.ConjugateButton.TabIndex = 80
        Me.ConjugateButton.TabStop = False
        Me.ConjugateButton.Tag = "function"
        Me.ConjugateButton.Text = "x̅"
        Me.ConjugateButton.UseVisualStyleBackColor = True
        '
        'FloatSwitch
        '
        Me.FloatSwitch.Appearance = System.Windows.Forms.Appearance.Button
        Me.FloatSwitch.Checked = True
        Me.FloatSwitch.CheckState = System.Windows.Forms.CheckState.Checked
        Me.FloatSwitch.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.FloatSwitch.ForeColor = System.Drawing.Color.White
        Me.FloatSwitch.Location = New System.Drawing.Point(115, 97)
        Me.FloatSwitch.Margin = New System.Windows.Forms.Padding(2, 3, 3, 3)
        Me.FloatSwitch.Name = "FloatSwitch"
        Me.FloatSwitch.Size = New System.Drawing.Size(48, 32)
        Me.FloatSwitch.TabIndex = 81
        Me.FloatSwitch.TabStop = False
        Me.FloatSwitch.Tag = "switch"
        Me.FloatSwitch.Text = "Float"
        Me.FloatSwitch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.FloatSwitch.UseVisualStyleBackColor = True
        '
        'PowerSwitch
        '
        Me.PowerSwitch.Appearance = System.Windows.Forms.Appearance.Button
        Me.PowerSwitch.Checked = True
        Me.PowerSwitch.CheckState = System.Windows.Forms.CheckState.Checked
        Me.PowerSwitch.Font = New System.Drawing.Font("Calibri", 8.0!)
        Me.PowerSwitch.ForeColor = System.Drawing.Color.White
        Me.PowerSwitch.Location = New System.Drawing.Point(9, 97)
        Me.PowerSwitch.Margin = New System.Windows.Forms.Padding(2, 3, 3, 3)
        Me.PowerSwitch.Name = "PowerSwitch"
        Me.PowerSwitch.Size = New System.Drawing.Size(48, 32)
        Me.PowerSwitch.TabIndex = 83
        Me.PowerSwitch.TabStop = False
        Me.PowerSwitch.Tag = "clear"
        Me.PowerSwitch.Text = "Power"
        Me.PowerSwitch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.PowerSwitch.UseVisualStyleBackColor = True
        '
        'SwitchExponentCursor
        '
        Me.SwitchExponentCursor.BackColor = System.Drawing.SystemColors.Control
        Me.SwitchExponentCursor.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.SwitchExponentCursor.ForeColor = System.Drawing.Color.White
        Me.SwitchExponentCursor.Location = New System.Drawing.Point(221, 97)
        Me.SwitchExponentCursor.Margin = New System.Windows.Forms.Padding(2, 3, 3, 3)
        Me.SwitchExponentCursor.Name = "SwitchExponentCursor"
        Me.SwitchExponentCursor.Size = New System.Drawing.Size(48, 32)
        Me.SwitchExponentCursor.TabIndex = 84
        Me.SwitchExponentCursor.TabStop = False
        Me.SwitchExponentCursor.Tag = "operator"
        Me.SwitchExponentCursor.Text = "Ma/Ex"
        Me.SwitchExponentCursor.UseVisualStyleBackColor = True
        '
        'LastXButton
        '
        Me.LastXButton.BackColor = System.Drawing.SystemColors.Control
        Me.LastXButton.Font = New System.Drawing.Font("Calibri", 11.25!)
        Me.LastXButton.ForeColor = System.Drawing.Color.White
        Me.LastXButton.Location = New System.Drawing.Point(168, 287)
        Me.LastXButton.Margin = New System.Windows.Forms.Padding(2, 3, 3, 3)
        Me.LastXButton.Name = "LastXButton"
        Me.LastXButton.Size = New System.Drawing.Size(48, 32)
        Me.LastXButton.TabIndex = 85
        Me.LastXButton.TabStop = False
        Me.LastXButton.Tag = "function"
        Me.LastXButton.Text = "LastX"
        Me.LastXButton.UseVisualStyleBackColor = True
        '
        'CalcPad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(440, 331)
        Me.Controls.Add(Me.LastXButton)
        Me.Controls.Add(Me.SwitchExponentCursor)
        Me.Controls.Add(Me.PowerSwitch)
        Me.Controls.Add(Me.FloatSwitch)
        Me.Controls.Add(Me.ConjugateButton)
        Me.Controls.Add(Me.ArgumentButton)
        Me.Controls.Add(Me.AbsoluteButton)
        Me.Controls.Add(Me.InverseNumber)
        Me.Controls.Add(Me.TangentButton)
        Me.Controls.Add(Me.CosineButton)
        Me.Controls.Add(Me.SineButton)
        Me.Controls.Add(Me.FactorialButton)
        Me.Controls.Add(Me.PiButton)
        Me.Controls.Add(Me.HyperbolicSwitch)
        Me.Controls.Add(Me.InvertSwitch)
        Me.Controls.Add(Me.ExponentButton)
        Me.Controls.Add(Me.SquareRoot)
        Me.Controls.Add(Me.SquareButton)
        Me.Controls.Add(Me.CommonLogarithm)
        Me.Controls.Add(Me.NaturalLogarithm)
        Me.Controls.Add(Me.DegreeSwitch)
        Me.Controls.Add(Me.PolarSwitch)
        Me.Controls.Add(Me.SwitchComplexCursor)
        Me.Controls.Add(Me.Value4iExponent)
        Me.Controls.Add(Me.Value4iMantissa)
        Me.Controls.Add(Me.Value3iExponent)
        Me.Controls.Add(Me.Value3iMantissa)
        Me.Controls.Add(Me.Value2iExponent)
        Me.Controls.Add(Me.Value2iMantissa)
        Me.Controls.Add(Me.Value1iExponent)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.RotateButton)
        Me.Controls.Add(Me.SwapButton)
        Me.Controls.Add(Me.DeleteButton)
        Me.Controls.Add(Me.ClearEntryButton)
        Me.Controls.Add(Me.NegateSignButton)
        Me.Controls.Add(Me.DivisionButton)
        Me.Controls.Add(Me.MultiplicationButton)
        Me.Controls.Add(Me.SubtractionButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.AdditionButton)
        Me.Controls.Add(Me.Value4Exponent)
        Me.Controls.Add(Me.Value4Mantissa)
        Me.Controls.Add(Me.Value3Exponent)
        Me.Controls.Add(Me.Value3Mantissa)
        Me.Controls.Add(Me.Value2Exponent)
        Me.Controls.Add(Me.Value2Mantissa)
        Me.Controls.Add(Me.EnterButton)
        Me.Controls.Add(Me.NumPadDecimal)
        Me.Controls.Add(Me.NumPad0)
        Me.Controls.Add(Me.NumPad3)
        Me.Controls.Add(Me.NumPad2)
        Me.Controls.Add(Me.NumPad1)
        Me.Controls.Add(Me.NumPad6)
        Me.Controls.Add(Me.NumPad5)
        Me.Controls.Add(Me.NumPad4)
        Me.Controls.Add(Me.NumPad9)
        Me.Controls.Add(Me.NumPad8)
        Me.Controls.Add(Me.NumPad7)
        Me.Controls.Add(Me.Value1iMantissa)
        Me.Controls.Add(Me.Value1Exponent)
        Me.Controls.Add(Me.Value1Mantissa)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "CalcPad"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Tag = ""
        Me.Text = "RPN Complex Calculator"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Value1Mantissa As System.Windows.Forms.Label
    Friend WithEvents Value1Exponent As System.Windows.Forms.Label
    Friend WithEvents NumPad7 As System.Windows.Forms.Button
    Friend WithEvents NumPad8 As System.Windows.Forms.Button
    Friend WithEvents NumPad9 As System.Windows.Forms.Button
    Friend WithEvents NumPad6 As System.Windows.Forms.Button
    Friend WithEvents NumPad5 As System.Windows.Forms.Button
    Friend WithEvents NumPad4 As System.Windows.Forms.Button
    Friend WithEvents NumPad3 As System.Windows.Forms.Button
    Friend WithEvents NumPad2 As System.Windows.Forms.Button
    Friend WithEvents NumPad1 As System.Windows.Forms.Button
    Friend WithEvents NumPad0 As System.Windows.Forms.Button
    Friend WithEvents NumPadDecimal As System.Windows.Forms.Button
    Friend WithEvents EnterButton As System.Windows.Forms.Button
    Friend WithEvents Value2Exponent As System.Windows.Forms.Label
    Friend WithEvents Value2Mantissa As System.Windows.Forms.Label
    Friend WithEvents Value3Exponent As System.Windows.Forms.Label
    Friend WithEvents Value3Mantissa As System.Windows.Forms.Label
    Friend WithEvents Value4Exponent As System.Windows.Forms.Label
    Friend WithEvents Value4Mantissa As System.Windows.Forms.Label
    Friend WithEvents AdditionButton As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents SubtractionButton As System.Windows.Forms.Button
    Friend WithEvents MultiplicationButton As System.Windows.Forms.Button
    Friend WithEvents DivisionButton As System.Windows.Forms.Button
    Friend WithEvents NegateSignButton As System.Windows.Forms.Button
    Friend WithEvents RotateButton As System.Windows.Forms.Button
    Friend WithEvents SwapButton As System.Windows.Forms.Button
    Friend WithEvents DeleteButton As System.Windows.Forms.Button
    Friend WithEvents ClearEntryButton As System.Windows.Forms.Button
    Friend WithEvents ClearButton As System.Windows.Forms.Button
    Friend WithEvents BlinkTimer As System.Windows.Forms.Timer
    Friend WithEvents Value4iExponent As System.Windows.Forms.Label
    Friend WithEvents Value4iMantissa As System.Windows.Forms.Label
    Friend WithEvents Value3iExponent As System.Windows.Forms.Label
    Friend WithEvents Value3iMantissa As System.Windows.Forms.Label
    Friend WithEvents Value2iExponent As System.Windows.Forms.Label
    Friend WithEvents Value2iMantissa As System.Windows.Forms.Label
    Friend WithEvents Value1iExponent As System.Windows.Forms.Label
    Friend WithEvents Value1iMantissa As System.Windows.Forms.Label
    Friend WithEvents SwitchComplexCursor As System.Windows.Forms.Button
    Friend WithEvents PolarSwitch As System.Windows.Forms.CheckBox
    Friend WithEvents DegreeSwitch As System.Windows.Forms.CheckBox
    Friend WithEvents NaturalLogarithm As System.Windows.Forms.Button
    Friend WithEvents CommonLogarithm As System.Windows.Forms.Button
    Friend WithEvents SquareButton As System.Windows.Forms.Button
    Friend WithEvents SquareRoot As System.Windows.Forms.Button
    Friend WithEvents ExponentButton As System.Windows.Forms.Button
    Friend WithEvents InvertSwitch As System.Windows.Forms.CheckBox
    Friend WithEvents HyperbolicSwitch As System.Windows.Forms.CheckBox
    Friend WithEvents PiButton As System.Windows.Forms.Button
    Friend WithEvents FactorialButton As System.Windows.Forms.Button
    Friend WithEvents SineButton As System.Windows.Forms.Button
    Friend WithEvents CosineButton As System.Windows.Forms.Button
    Friend WithEvents TangentButton As System.Windows.Forms.Button
    Friend WithEvents InverseNumber As System.Windows.Forms.Button
    Friend WithEvents AbsoluteButton As System.Windows.Forms.Button
    Friend WithEvents ArgumentButton As System.Windows.Forms.Button
    Friend WithEvents ConjugateButton As System.Windows.Forms.Button
    Friend WithEvents FloatSwitch As System.Windows.Forms.CheckBox
    Friend WithEvents PowerSwitch As System.Windows.Forms.CheckBox
    Friend WithEvents SwitchExponentCursor As System.Windows.Forms.Button
    Friend WithEvents LastXButton As System.Windows.Forms.Button

End Class
