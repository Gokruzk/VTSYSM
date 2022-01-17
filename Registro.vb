Imports System.Data.OleDb
Public Class REGISTRO

    Private Sub REGISTRO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn()
    End Sub

    Private Sub BT_ACEPTAR_Click(sender As Object, e As EventArgs) Handles BT_ACEPTAR.Click
        Dim nombres, apellidos, cedula As String
        nombres = TXT_NOMB.Text
        apellidos = TXT_AP.Text
        cedula = TXT_CED.Text

        insert_votante(cedula, nombres, apellidos)

        TXT_CED.Text = ""
        TXT_NOMB.Text = ""
        TXT_AP.Text = ""

        Dim result As Integer = MessageBox.Show("¿DESEA AGREGAR OTRO VOTANTE?", "caption", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.No Then
            Me.Close()
            Votantes.Show()
        ElseIf result = DialogResult.Yes Then
            Me.Show()
        End If

    End Sub

    Private Sub BT_CLOSE_Click(sender As Object, e As EventArgs) Handles BT_CLOSE.Click
        Me.Close()
    End Sub
End Class