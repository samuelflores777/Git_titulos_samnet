Public Class Form2
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Value += 1
        If ProgressBar1.Value <= 10 Then
            Label2.Text = "Iniciando Sistema SAM CRTL"

        ElseIf ProgressBar1.Value <= 30 Then
            Label2.Text = "Cargo código base SAM CTRL"

        ElseIf ProgressBar1.Value <= 50 Then
            Label2.Text = "Integrando Formularios SAM CTRL"

        ElseIf ProgressBar1.Value <= 70 Then
            Label2.Text = "Por favor espere un momento..."

        ElseIf ProgressBar1.Value <= 100 Then
            Label2.Text = "Bienvenido a SAM CTRL"

            If ProgressBar1.Value = 100 Then
                Timer1.Dispose()
                Me.Hide()
                Form1.ShowDialog()
                Me.Close()
            End If
        End If
    End Sub
End Class