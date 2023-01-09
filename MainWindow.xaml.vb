Imports System.Data

Class MainWindow
    Private Sub OnNumberClicked(sender As Button, e As RoutedEventArgs) Handles btnNumber0.Click, btnNumber1.Click, btnNumber2.Click, btnNumber3.Click,
    btnNumber4.Click, btnNumber5.Click, btnNumber6.Click, btnNumber7.Click, btnNumber8.Click, btnNumber9.Click
        If txtResult.Text = "0" Then
            txtResult.Text = sender.Content
        Else
            txtResult.Text += sender.Content
        End If
        txtResult.Text = txtResult.Text

    End Sub

    Private Sub OnDelClicked(sender As Button, e As RoutedEventArgs) Handles btnDelete.Click
        txtResult.Text = txtResult.Text.Substring(0, txtResult.Text.Length - 1)
        If txtResult.Text = "" Then
            txtResult.Text = "0"
        End If
        txtResult.Text = txtResult.Text
    End Sub

    Private Sub OnCEClicked(sender As Button, e As RoutedEventArgs) Handles btnClearEverything.Click
        txtResult.Text = "0"
        txtFullEquation.Text = ""
        txtResult.Text = txtResult.Text
    End Sub

    Private Sub OnOperatorClicked(sender As Button, e As RoutedEventArgs) Handles btnOperationDiv.Click, btnOperationMul.Click, btnOperationSub.Click,
    btnOperationSum.Click
        Dim operation = sender.Content
        txtFullEquation.Text += txtResult.Text + " " + operation + " "
        txtResult.Text = 0

    End Sub

    Private Sub OnEqualsClicked(sender As Button, e As RoutedEventArgs) Handles btnEquals.Click
        If txtFullEquation.Text = "0" Then
            Exit Sub
        End If

        txtFullEquation.Text += txtResult.Text
        Dim result As String = New DataTable().Compute(txtFullEquation.Text, Nothing).ToString()
        txtResult.Text = result
        txtFullEquation.Text = ""
    End Sub
End Class
