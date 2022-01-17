Public Class Datos_listas
    Private Sub BT_CLOSE_Click(sender As Object, e As EventArgs) Handles BT_CLOSE.Click
        Me.Close()
    End Sub

    Private Sub Datos_listas2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'conn()
        conlistas()

        'dat_vice("a")
        'dat_vice("b")

        If num_listas = 1 Then
            dat_presi("a")
            cedp_a.Text = cedulap
            nomp_a.Text = nombresp
            apep_a.Text = apellidosp
            dat_vice("a")
            cedv_a.Text = cedulav
            nomv_a.Text = nombresv
            apev_a.Text = apellidosv
            GunaLabel3.Visible = True
            Label4.Visible = False
            PictureBox1.Load(ruta1)
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
            Me.Controls.Remove(PictureBox2)
            Me.Controls.Remove(PictureBox3)
            Me.Controls.Remove(Panel2)
            Me.Controls.Remove(GunaLabel1)
            Size = New Size(360, 310)
            BT_CLOSE.Location = New Point(125, 235)
            GunaLabel4.Location = New Point(92, 9)

        Else

            If num_listas = 3 Then
                dat_presi("a")
                cedp_a.Text = cedulap
                nomp_a.Text = nombresp
                apep_a.Text = apellidosp
                dat_vice("a")
                cedv_a.Text = cedulav
                nomv_a.Text = nombresv
                apev_a.Text = apellidosv

                dat_presi("b")
                cedp_b.Text = cedulap
                nomp_b.Text = nombresp
                apep_b.Text = apellidosp
                dat_vice("b")
                cedv_b.Text = cedulav
                nomv_b.Text = nombresv
                apev_b.Text = apellidosv

                dat_presi("c")
                cedp_c.Text = cedulap
                nomp_c.Text = nombresp
                apep_c.Text = apellidosp
                dat_vice("c")
                cedv_c.Text = cedulav
                nomv_c.Text = nombresv
                apev_c.Text = apellidosv

                PictureBox1.Image = Image.FromFile(ruta1)
                PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
                PictureBox2.Image = Image.FromFile(ruta2)
                PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
                PictureBox3.Image = Image.FromFile(ruta3)
                PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage

            Else

                If num_listas = 2 Then

                    dat_presi("a")
                    cedp_a.Text = cedulap
                    nomp_a.Text = nombresp
                    apep_a.Text = apellidosp
                    dat_vice("a")
                    cedv_a.Text = cedulav
                    nomv_a.Text = nombresv
                    apev_a.Text = apellidosv

                    dat_presi("b")
                    cedp_b.Text = cedulap
                    nomp_b.Text = nombresp
                    apep_b.Text = apellidosp
                    dat_vice("b")
                    cedv_b.Text = cedulav
                    nomv_b.Text = nombresv
                    apev_b.Text = apellidosv

                    PictureBox1.Load(ruta1)
                    PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
                    PictureBox2.Load(ruta2)
                    PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage

                    Size = New Size(673, 312)
                    BT_CLOSE.Location = New Point(279, 240)
                    Me.Controls.Remove(PictureBox3)
                    Me.Controls.Remove(Panel2)
                    Me.Controls.Remove(GunaLabel1)

                End If
            End If
        End If

    End Sub

End Class