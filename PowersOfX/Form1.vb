Public Class Form1
    Private Sub CalcButton_Click(sender As Object, e As EventArgs) Handles CalcButton.Click
        Dim result As String = ""
        Dim x, pow, i, origX As Integer
        x = CInt(xBox.Value)
        origX = x
        pow = CInt(powerBox.Value)
        i = 2 ' we start with squaring!
        Do While i <= pow
            x = x * origX
            result &= CStr(x)
            result &= ", "
            i = i + 1
        Loop
        ResultBox.Text = result
    End Sub

    Private Sub AltCalc_Click(sender As Object, e As EventArgs) Handles AltCalc.Click
        Dim result As String = ""
        Dim x, pow, i, origX As Integer
        x = CInt(xBox.Value)
        origX = x
        pow = powerBox.Value
        Dim powers(pow - 2) As Integer
        i = 0 'first array element to fill
        Do While (i + 2) <= pow
            x = x * origX
            powers(i) = x
            i = i + 1
        Loop

        For Each num As Integer In powers
            result &= CStr(num)
            result &= ", "
        Next num
        ResultBox.Text = result
    End Sub
End Class
