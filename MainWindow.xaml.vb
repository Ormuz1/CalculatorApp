Class MainWindow
    Dim resultBuffer As String = "0"
    Dim fullEquation As String = ""
    Dim result As Integer = 0
    Private Sub OnNumberClicked(sender As Button, e As RoutedEventArgs) Handles btnNumber0.Click, btnNumber1.Click, btnNumber2.Click, btnNumber3.Click,
    btnNumber4.Click, btnNumber5.Click, btnNumber6.Click, btnNumber7.Click, btnNumber8.Click, btnNumber9.Click
        If resultBuffer = "0" Then
            resultBuffer = sender.Content
        Else
            resultBuffer += sender.Content
        End If
        txtResult.Text = resultBuffer

    End Sub

    Private Sub OnDelClicked(sender As Button, e As RoutedEventArgs) Handles btnDelete.Click
        resultBuffer = resultBuffer.Substring(0, resultBuffer.Length - 1)
        If resultBuffer = "" Then
            resultBuffer = "0"
        End If
        txtResult.Text = resultBuffer
    End Sub

    Private Sub OnCEClicked(sender As Button, e As RoutedEventArgs) Handles btnClearEverything.Click
        resultBuffer = "0"
        fullEquation = ""
        txtResult.Text = resultBuffer
    End Sub

    Private Sub OnOperatorClicked(sender As Button, e As RoutedEventArgs) Handles btnOperationDiv.Click, btnOperationMul.Click, btnOperationSub.Click,
    btnOperationSum.Click
        Dim operation = sender.Content
        fullEquation += resultBuffer + " " + operation + " "
        Select Case operation
            Case "+"
                MsgBox("Add")
            Case "-"
                MsgBox("Subtract")
            Case "*"
                MsgBox("Multiply")
            Case "/"
                MsgBox("Divide")
        End Select
    End Sub
End Class
