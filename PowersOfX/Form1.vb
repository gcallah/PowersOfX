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
End Class
