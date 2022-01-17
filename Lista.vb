Public Class Lista

    Dim lista, nom_presi, ced_presi, apell_presi, nom_vice, ced_vice, apell_vice, letra As String

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        conlistas()

        If num_listas = 0 Then
            MsgBox("NO HAY LISTAS REGISTRADAS", MsgBoxStyle.Exclamation)
        Else
            Datos_listas.Show()
        End If
    End Sub

    'CONTEO DE LISTAS
    Private Sub LISTA_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conlistas()
        If (num_listas = 3) Then
            MsgBox("YA TIENE 3 LISTAS REGISTRADAS", MsgBoxStyle.Exclamation)
            'Me.Close()
        End If
    End Sub

    'REGISTRO
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        lista = TXT_LET.Text
        ced_presi = TXT_CED_PRES.Text
            nom_presi = TXT_NOM_PRES.Text
            apell_presi = TXT_APELL_PRES.Text
            ced_vice = TXT_CED_VICE.Text
            nom_vice = TXT_NOM_VICE.Text
            apell_vice = TXT_APELL_VICE.Text
            letra = TXT_LET.Text
            If num_listas < 3 Then

                'listas(lista, nom_presi, nom_vice, letra, ced_presi, ced_vice)
                'insert_presi_vice(lista, ced_presi, nom_presi, apell_presi, ced_vice, nom_vice, apell_vice, letra)
                listas(nom_presi, nom_vice, letra, ced_presi, ced_vice, apell_presi, apell_vice)
                TXT_LET.Text = ""
                TXT_CED_PRES.Text = ""
                TXT_NOM_PRES.Text = ""
                TXT_APELL_PRES.Text = ""
                TXT_APELL_VICE.Text = ""
                TXT_NOM_VICE.Text = ""
                TXT_CED_VICE.Text = ""

        Else

                MsgBox("MÁXIMO DE LISTAS EXCEDIDO", MsgBoxStyle.Critical)
                TXT_LET.Text = ""
                TXT_CED_PRES.Text = ""
                TXT_NOM_PRES.Text = ""
                TXT_APELL_PRES.Text = ""
                TXT_APELL_VICE.Text = ""
                TXT_NOM_VICE.Text = ""
            TXT_CED_VICE.Text = ""

        End If

    End Sub

    'CERRAR
    Private Sub BT_CLOSE_Click(sender As Object, e As EventArgs) Handles BT_CLOSE.Click
        CONTEO.Show()
        Me.Close()
    End Sub


End Class