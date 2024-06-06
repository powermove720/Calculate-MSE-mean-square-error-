Function CalculateMSE(ByVal predictedValues As Double(), ByVal actualValues As Double()) As Double
    Dim mse As Double = 0
    Dim n As Integer = predictedValues.Length
    
    If predictedValues.Length <> actualValues.Length Then
        Throw New ArgumentException("The lengths of the predicted and actual values arrays must be equal.")
    End If
    
    For i As Integer = 0 To n - 1
        If Not Double.IsNaN(predictedValues(i)) AndAlso Not Double.IsInfinity(predictedValues(i)) AndAlso Not Double.IsNaN(actualValues(i)) AndAlso Not Double.IsInfinity(actualValues(i)) Then
            mse += Math.Pow((predictedValues(i) - actualValues(i)), 2)
        Else
            Throw New ArgumentException("Both arrays must contain only numeric values.")
        End If
    Next
    
    Return mse / n
End Function
