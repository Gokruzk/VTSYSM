Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn()
        coninst()
        LB_INST.Text = nom_inst
        'LB_INST.Location = New Point(180, 20)
        PictureBox1.Load(ruta4)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
    End Sub

    'ACEPTAR
    Private Sub BT_ACEPTAR_Click(sender As Object, e As EventArgs) Handles BT_ACEPTAR.Click
        'Dim ced As String
        'ced = TXT_COD.Text
        'TXT_COD.Text = ced

        constatus(TXT_COD.Text, "estado", "votantes", "cedula")
        'ced = ""
        If (status = "sin votar") Then
            Try
                up_estado(TXT_COD.Text)
                Me.Hide()
                Votacion.Show()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MsgBox("          POSIBLES ERRORES:" & vbNewLine & "           -USTED YA VOTÓ" & vbNewLine & "      -NO ESTÁ REGISTRADO", MsgBoxStyle.Critical, "VTSYSM")
        End If
        TXT_COD.Text = ""

    End Sub

    'ADMINISTRAR
    Private Sub BT_ACEPTAR2_Click(sender As Object, e As EventArgs) Handles BT_ACEPTAR2.Click
        If TXT_COD.Text = "admin" And TXT_PASS.Text = "admin123" Then
            CONTEO.Show
            Me.Close()
        Else
            MsgBox("DATOS ERRÓNEOS", MsgBoxStyle.Critical)
        End If
        TXT_COD.Text = ""
        TXT_PASS.Text = ""
    End Sub

    Private Sub BT_AD_Click(sender As Object, e As EventArgs) Handles BT_AD.Click
        Me.Size = New Size(781, 445)
        Label1.Text = "USUARIO"
        BT_CLOSE.Location = New Point(411, 374)
        Label3.Visible = True
        TXT_PASS.Visible = True
        BT_ACEPTAR.Visible = False
        BT_ACEPTAR2.Visible = True
    End Sub

    'CERRAR
    Private Sub BT_CLOSE_Click(sender As Object, e As EventArgs) Handles BT_CLOSE.Click
        Me.Close()
    End Sub

End Class
