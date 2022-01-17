
Public Class Votacion

    Private Sub Votacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conlistas()

        If num_listas = 3 Then

            PictureBox1.Image = Image.FromFile(ruta1)
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
            PictureBox2.Image = Image.FromFile(ruta2)
            PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
            PictureBox3.Image = Image.FromFile(ruta3)
            PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        Else
            If (num_listas = 2) Then

                Me.Controls.Remove(BT_LISTC)
                Me.Controls.Remove(PictureBox3)

                PictureBox1.Image = Image.FromFile(ruta1)

                PictureBox2.Image = Image.FromFile(ruta2)

                PictureBox1.Location = New Point(262, 155)
                PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
                BT_LISTA.Location = New Point(272, 298)
                PictureBox2.Location = New Point(380, 155)
                PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
                BT_LISTB.Location = New Point(390, 298)
            End If

        End If
        coninst()
        LB_INST.Text = nom_inst
        LB_INST.Location = New Point(186, 50)

    End Sub

    Private Sub BT_LISTA_Click_1(sender As Object, e As EventArgs) Handles BT_LISTA.Click
        votar("listaa", "num_votos")
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub BT_LISTB_Click_1(sender As Object, e As EventArgs) Handles BT_LISTB.Click
        votar("listab", "num_votos")
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub BT_LISTC_Click_1(sender As Object, e As EventArgs) Handles BT_LISTC.Click
        votar("listac", "num_votos")
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub BT_NULL_Click_1(sender As Object, e As EventArgs) Handles BT_NULL.Click
        votar("nulos", "null_votos")
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub BT_BLANCO_Click_1(sender As Object, e As EventArgs) Handles BT_BLANCO.Click
        votar("blancos", "blancos_votos")
        Me.Hide()
        Form1.Show()
    End Sub
End Class