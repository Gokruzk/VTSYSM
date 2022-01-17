
Public Class CONTEO

    Dim total, total1, total2, total3, total4, total5 As Double

    'CONTEO
    Private Sub CONTEO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conlistas()

        If num_listas = 0 Then
            GunaLabel2.Text = "NO HAY LISTAS REGISTRADAS"
            Label1.Visible = False
            LB_BLANCOS.Visible = False
            LB_LISTA.Visible = False
            LB_LISTB.Visible = False
            LB_LISTC.Visible = False
            LB_NULL.Visible = False
            LB_VOT.Visible = False
            Label10.Visible = False
            Label11.Visible = False
            Label12.Visible = False
            Label13.Visible = False
            Label2.Visible = False
            Label3.Visible = False
            Label4.Visible = False
            PictureBox1.Visible = False
            PictureBox2.Visible = False
            PictureBox3.Visible = False
            Button1.Visible = True
        Else
            If num_listas = 1 Then
                GunaLabel2.Text = "1 DE 3 LISTAS REGISTRADAS"
                Label1.Visible = False
                LB_BLANCOS.Visible = False
                LB_LISTA.Visible = False
                LB_LISTB.Visible = False
                LB_LISTC.Visible = False
                LB_NULL.Visible = False
                LB_VOT.Visible = False
                Label10.Visible = False
                Label11.Visible = False
                Label12.Visible = False
                Label13.Visible = False
                Label2.Visible = False
                Label3.Visible = False
                Label4.Visible = False
                PictureBox1.Visible = False
                PictureBox2.Visible = False
                PictureBox3.Visible = False
                Button1.Visible = True
            Else

                If num_listas = 3 Then

                    PictureBox1.Image = Image.FromFile(ruta1)
                    PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
                    PictureBox2.Image = Image.FromFile(ruta2)
                    PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
                    PictureBox3.Image = Image.FromFile(ruta3)
                    PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage

                    cont("num_votos", "listaa")
                    LB_LISTA.Text = num_votos
                    total1 = num_votos
                    cont("num_votos", "listab")
                    LB_LISTB.Text = num_votos
                    total2 = num_votos
                    cont("num_votos", "listac")
                    LB_LISTC.Text = num_votos
                    total3 = num_votos
                    cont("null_votos", "nulos")
                    LB_NULL.Text = num_votos
                    total4 = num_votos
                    cont("blancos_votos", "blancos")
                    LB_BLANCOS.Text = num_votos
                    total5 = num_votos

                    total = total1 + total2 + total3 + total4 + total5

                    LB_VOT.Text = total


                Else

                    If num_listas = 2 Then

                        PictureBox1.Load(ruta1)
                        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
                        PictureBox1.Location = New Point(268, 77)
                        PictureBox2.Load(ruta2)
                        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
                        PictureBox2.Location = New Point(386, 77)

                        LB_LISTA.Location = New Point(312, 207)
                        Label1.Location = New Point(263, 207)
                        LB_LISTB.Location = New Point(444, 207)
                        Label11.Location = New Point(388, 207)

                        Me.Controls.Remove(LB_LISTC)
                        Me.Controls.Remove(Label12)
                        Me.Controls.Remove(PictureBox3)

                        cont("num_votos", "listaa")
                        LB_LISTA.Text = num_votos
                        total1 = num_votos
                        cont("num_votos", "listab")
                        LB_LISTB.Text = num_votos
                        total2 = num_votos
                        cont("null_votos", "nulos")
                        LB_NULL.Text = num_votos
                        total4 = num_votos
                        cont("blancos_votos", "blancos")
                        LB_BLANCOS.Text = num_votos
                        total5 = num_votos

                        total = total1 + total2 + total4 + total5

                        LB_VOT.Text = total

                    End If
                End If
            End If
        End If
    End Sub

    'HOME
    Private Sub BT_HOME_Click_1(sender As Object, e As EventArgs) Handles BT_HOME.Click
        Form1.Show()
        Me.Close()
    End Sub

    'ACERCA DE
    Private Sub GunaButton1_Click_1(sender As Object, e As EventArgs) Handles GunaButton1.Click
        Informacion.Show()


        If GunaPanel1.Width = 157 Then
            Me.GunaPanel1.Width = GunaPanel1.Width - 112
        Else

        End If
    End Sub

    'RESET
    Private Sub RESET_Click(sender As Object, e As EventArgs) Handles RESET.Click
        Reset_datos.Show()
        If GunaPanel1.Width = 157 Then
            Me.GunaPanel1.Width = GunaPanel1.Width - 112
        Else

        End If
    End Sub

    'PADRÓN
    Private Sub PADRON_Click(sender As Object, e As EventArgs) Handles PADRON.Click
        Votantes.Show()
        If GunaPanel1.Width = 157 Then
            Me.GunaPanel1.Width = GunaPanel1.Width - 112
        Else

        End If
    End Sub

    'MENÚ
    Private Sub MENU_Click(sender As Object, e As EventArgs) Handles MENU.Click
        If GunaPanel1.Width <= 45 Then
            Me.GunaPanel1.Width = GunaPanel1.Width + 112
        ElseIf GunaPanel1.Width >= 157 Then
            Me.GunaPanel1.Width = GunaPanel1.Width - 112
        End If
    End Sub

    'CONFIGURACIÓN
    Private Sub SETTING_Click(sender As Object, e As EventArgs) Handles SETTING.Click
        Configuracion.Show()
        If GunaPanel1.Width = 157 Then
            Me.GunaPanel1.Width = GunaPanel1.Width - 112
        Else

        End If
        Form1.Close()
    End Sub

    'LISTAS_INFO
    Private Sub LISTAS_Click(sender As Object, e As EventArgs) Handles LISTAS.Click
        conlistas()
        If num_listas = 0 Then
            MsgBox("NO HAY LISTAS REGISTRADAS", MsgBoxStyle.Exclamation)
        Else
            Datos_listas.Show()
        End If
        If GunaPanel1.Width = 157 Then
            Me.GunaPanel1.Width = GunaPanel1.Width - 112
        Else

        End If
    End Sub

    'AGREGAR LISTA
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Lista.Show()
        If GunaPanel1.Width = 157 Then
            Me.GunaPanel1.Width = GunaPanel1.Width - 112
        Else

        End If
        Me.Close()
    End Sub

    'RESET
    Private Sub RESETEARVOTOSToolStripMenuItem_Click(sender As Object, e As EventArgs)
        reset_votos()
        LB_LISTA.Text = "0"
        LB_LISTB.Text = "0"
        LB_LISTC.Text = "0"
        LB_BLANCOS.Text = "0"
        LB_NULL.Text = "0"
        LB_VOT.Text = "0"
    End Sub

    'RESET_ALL
    Private Sub ELIMINARTODOToolStripMenuItem_Click(sender As Object, e As EventArgs)
        reset_all()
        LB_LISTA.Text = "0"
        LB_LISTB.Text = "0"
        LB_LISTC.Text = "0"
        LB_BLANCOS.Text = "0"
        LB_NULL.Text = "0"
        LB_VOT.Text = "0"
    End Sub

End Class