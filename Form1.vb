Public Class Form1
    Dim A As Double
    Dim B As Double
    Dim op As String
    Private Sub Button_Click(sender As Object, e As EventArgs) Handles Button1.Click, Button2.Click, Button3.Click, Button4.Click, Button5.Click, Button6.Click, Button7.Click, Button8.Click, Button9.Click, Button11.Click, Button10.Click
        TextBox1.Text &= DirectCast(sender, Button).Text
    End Sub
    Private Sub Operation_Click(sender As Object, e As EventArgs) Handles Button13.Click, Button14.Click, Button15.Click, Button16.Click
        A = Double.Parse(TextBox1.Text)
        op = DirectCast(sender, Button).Text
        TextBox1.Clear()
    End Sub
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        B = Double.Parse(TextBox1.Text)
        Dim result As Double

        Select Case op
            Case "+"
                result = A + B
            Case "-"
                result = A - B
            Case "*"
                result = A * B
            Case "/"
                If B <> 0 Then
                    result = A / B
                Else
                    MessageBox.Show("Division par zéro non autorisée.")
                    Exit Sub
                End If
        End Select

        TextBox1.Text = result.ToString()
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        TextBox1.Clear()
        A = 0
        B = 0
        op = ""
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        Me.Close()
    End Sub
End Class
