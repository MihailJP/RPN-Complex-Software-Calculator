' スタック操作命令

Public Class CalcStack

    Const StackSize As Byte = 4
    Const MantissaDigits As Byte = 10
    Friend ValueStack(StackSize) As Complex

    ' コンストラクタ
    Public Sub New()
        For StackID As Byte = 0 To StackSize - 1 Step 1
            ValueStack(StackID) = New Complex
        Next
    End Sub

    Public Sub ClearAll()
        For StackID As Byte = 0 To StackSize - 1 Step 1
            ValueStack(StackID) = 0
        Next
    End Sub

    Public Sub Push(ByVal Value As Complex)
        For StackID As SByte = StackSize - 2 To 0 Step -1
            ValueStack(StackID + 1) = ValueStack(StackID)
        Next
        ValueStack(0) = Value
    End Sub

    Public Function Pop() As Complex
        Dim StackTop As Complex = ValueStack(0)
        For StackID As Byte = 0 To StackSize - 2 Step 1
            ValueStack(StackID) = ValueStack(StackID + 1)
        Next
        Return StackTop
    End Function

    Public Sub Swap()
        Dim X = ValueStack(0)
        ValueStack(0) = ValueStack(1)
        ValueStack(1) = X
    End Sub

    Public Sub Rotate()
        Dim X = Pop()
        ValueStack(StackSize - 1) = X
    End Sub

    Public Function GetRealExponent(Optional ByVal StackID As Byte = 0) As Int16
        Dim Answer As Int16 = 0
        Try
            Answer = Math.Floor(Calculator.FailproofLog10(ValueStack(StackID).Real))
        Catch ex As OverflowException
            Answer = 0
        End Try
        Return Answer
    End Function

    Public Function GetRealMantissa(Optional ByVal StackID As Byte = 0) As Double
        Return ValueStack(StackID).Real / Math.Pow(10, GetRealExponent(StackID))
    End Function

    Public Function GetImaginaryExponent(Optional ByVal StackID As Byte = 0) As Int16
        Dim Answer As Int16 = 0
        Try
            Answer = Math.Floor(Calculator.FailproofLog10(ValueStack(StackID).Imaginary))
        Catch ex As OverflowException
            Answer = 0
        End Try
        Return Answer
    End Function

    Public Function GetImaginaryMantissa(Optional ByVal StackID As Byte = 0) As Double
        Return ValueStack(StackID).Imaginary / Math.Pow(10, GetImaginaryExponent(StackID))
    End Function

    Public Function GetAbsoluteExponent(Optional ByVal StackID As Byte = 0) As Int16
        Dim Answer As Int16 = 0
        Try
            Answer = Math.Floor(Calculator.FailproofLog10(ValueStack(StackID).Absolute))
        Catch ex As OverflowException
            Answer = 0
        End Try
        Return Answer
    End Function

    Public Function GetAbsoluteMantissa(Optional ByVal StackID As Byte = 0) As Double
        Return ValueStack(StackID).Absolute / Math.Pow(10, GetAbsoluteExponent(StackID))
    End Function

    Public Function GetArgument(Optional ByVal StackID As Byte = 0) As Double
        Return ValueStack(StackID).Argument
    End Function
End Class
