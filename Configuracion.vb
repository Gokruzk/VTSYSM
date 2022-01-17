Public Class Configuracion
    Private Sub BT_CLOSE_Click(sender As Object, e As EventArgs) Handles BT_CLOSE.Click
        CONTEO.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim nombre As String
        nombre = TXT_NOMB.Text
        nom_institucion(nombre)
        TXT_NOMB.Text = ""
    End Sub

    Private Sub GunaButton1_Click(sender As Object, e As EventArgs) Handles GunaButton1.Click
        If (num_listas = 3) Then
            MsgBox("YA TIENE 3 LISTAS REGISTRADAS", MsgBoxStyle.Exclamation)
        Else
            Me.Close()
            Lista.Show()
            CONTEO.Close()
        End If
    End Sub

    Private Sub Configuracion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conlistas()
    End Sub
End Class