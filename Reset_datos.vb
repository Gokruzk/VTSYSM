Public Class Reset_datos
    Private Sub BT_CLOSE_Click(sender As Object, e As EventArgs) Handles BT_CLOSE.Click
        Me.Close()
    End Sub

    Private Sub BT_RST_Click(sender As Object, e As EventArgs) Handles BT_RST.Click
        Dim result As Integer = MessageBox.Show("¿ESTÁ SEGURO?", "REINICIO", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.No Then

        ElseIf result = DialogResult.Yes Then
            CONTEO.Close()

            reset_votos()
        End If
    End Sub

    Private Sub BT_ALL_Click(sender As Object, e As EventArgs) Handles BT_ALL.Click
        Dim result As Integer = MessageBox.Show("¿ESTÁ SEGURO?", "REINICIO", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.No Then

        ElseIf result = DialogResult.Yes Then
            CONTEO.Close()

            reset_all()
        End If
    End Sub

End Class