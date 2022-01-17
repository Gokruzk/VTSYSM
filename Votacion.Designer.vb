<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Votacion
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Votacion))
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.LB_INST = New Guna.UI.WinForms.GunaLabel()
        Me.BT_LISTB = New Guna.UI.WinForms.GunaButton()
        Me.BT_LISTC = New Guna.UI.WinForms.GunaButton()
        Me.BT_NULL = New Guna.UI.WinForms.GunaButton()
        Me.BT_BLANCO = New Guna.UI.WinForms.GunaButton()
        Me.BT_LISTA = New Guna.UI.WinForms.GunaButton()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox3
        '
        Me.PictureBox3.Location = New System.Drawing.Point(383, 157)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(112, 127)
        Me.PictureBox3.TabIndex = 122
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Location = New System.Drawing.Point(265, 157)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(112, 127)
        Me.PictureBox2.TabIndex = 121
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(147, 157)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(112, 127)
        Me.PictureBox1.TabIndex = 120
        Me.PictureBox1.TabStop = False
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Me.GunaLabel1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.GunaLabel1.Location = New System.Drawing.Point(286, 19)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(243, 25)
        Me.GunaLabel1.TabIndex = 123
        Me.GunaLabel1.Text = "SISTEMA DE VOTACIONES"
        '
        'LB_INST
        '
        Me.LB_INST.AutoSize = True
        Me.LB_INST.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Me.LB_INST.Location = New System.Drawing.Point(286, 52)
        Me.LB_INST.Name = "LB_INST"
        Me.LB_INST.Size = New System.Drawing.Size(133, 25)
        Me.LB_INST.TabIndex = 124
        Me.LB_INST.Text = "INSTITUCION"
        '
        'BT_LISTB
        '
        Me.BT_LISTB.AnimationHoverSpeed = 0.07!
        Me.BT_LISTB.AnimationSpeed = 0.03!
        Me.BT_LISTB.BaseColor = System.Drawing.Color.Maroon
        Me.BT_LISTB.BorderColor = System.Drawing.Color.Black
        Me.BT_LISTB.FocusedColor = System.Drawing.Color.Empty
        Me.BT_LISTB.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT_LISTB.ForeColor = System.Drawing.Color.White
        Me.BT_LISTB.Image = Nothing
        Me.BT_LISTB.ImageSize = New System.Drawing.Size(20, 20)
        Me.BT_LISTB.Location = New System.Drawing.Point(276, 301)
        Me.BT_LISTB.Name = "BT_LISTB"
        Me.BT_LISTB.OnHoverBaseColor = System.Drawing.Color.Green
        Me.BT_LISTB.OnHoverBorderColor = System.Drawing.Color.Black
        Me.BT_LISTB.OnHoverForeColor = System.Drawing.Color.White
        Me.BT_LISTB.OnHoverImage = Nothing
        Me.BT_LISTB.OnPressedColor = System.Drawing.Color.Black
        Me.BT_LISTB.Size = New System.Drawing.Size(91, 53)
        Me.BT_LISTB.TabIndex = 126
        Me.BT_LISTB.Text = "LISTA B"
        Me.BT_LISTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BT_LISTC
        '
        Me.BT_LISTC.AnimationHoverSpeed = 0.07!
        Me.BT_LISTC.AnimationSpeed = 0.03!
        Me.BT_LISTC.BaseColor = System.Drawing.Color.Maroon
        Me.BT_LISTC.BorderColor = System.Drawing.Color.Black
        Me.BT_LISTC.FocusedColor = System.Drawing.Color.Empty
        Me.BT_LISTC.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT_LISTC.ForeColor = System.Drawing.Color.White
        Me.BT_LISTC.Image = Nothing
        Me.BT_LISTC.ImageSize = New System.Drawing.Size(20, 20)
        Me.BT_LISTC.Location = New System.Drawing.Point(394, 301)
        Me.BT_LISTC.Name = "BT_LISTC"
        Me.BT_LISTC.OnHoverBaseColor = System.Drawing.Color.Green
        Me.BT_LISTC.OnHoverBorderColor = System.Drawing.Color.Black
        Me.BT_LISTC.OnHoverForeColor = System.Drawing.Color.White
        Me.BT_LISTC.OnHoverImage = Nothing
        Me.BT_LISTC.OnPressedColor = System.Drawing.Color.Black
        Me.BT_LISTC.Size = New System.Drawing.Size(91, 53)
        Me.BT_LISTC.TabIndex = 127
        Me.BT_LISTC.Text = "LISTA C"
        Me.BT_LISTC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BT_NULL
        '
        Me.BT_NULL.AnimationHoverSpeed = 0.07!
        Me.BT_NULL.AnimationSpeed = 0.03!
        Me.BT_NULL.BaseColor = System.Drawing.Color.Maroon
        Me.BT_NULL.BorderColor = System.Drawing.Color.Black
        Me.BT_NULL.FocusedColor = System.Drawing.Color.Empty
        Me.BT_NULL.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT_NULL.ForeColor = System.Drawing.Color.White
        Me.BT_NULL.Image = Nothing
        Me.BT_NULL.ImageSize = New System.Drawing.Size(20, 20)
        Me.BT_NULL.Location = New System.Drawing.Point(517, 162)
        Me.BT_NULL.Name = "BT_NULL"
        Me.BT_NULL.OnHoverBaseColor = System.Drawing.Color.Green
        Me.BT_NULL.OnHoverBorderColor = System.Drawing.Color.Black
        Me.BT_NULL.OnHoverForeColor = System.Drawing.Color.White
        Me.BT_NULL.OnHoverImage = Nothing
        Me.BT_NULL.OnPressedColor = System.Drawing.Color.Black
        Me.BT_NULL.Size = New System.Drawing.Size(111, 53)
        Me.BT_NULL.TabIndex = 128
        Me.BT_NULL.Text = "NULO"
        Me.BT_NULL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BT_BLANCO
        '
        Me.BT_BLANCO.AnimationHoverSpeed = 0.07!
        Me.BT_BLANCO.AnimationSpeed = 0.03!
        Me.BT_BLANCO.BaseColor = System.Drawing.Color.Maroon
        Me.BT_BLANCO.BorderColor = System.Drawing.Color.Black
        Me.BT_BLANCO.FocusedColor = System.Drawing.Color.Empty
        Me.BT_BLANCO.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT_BLANCO.ForeColor = System.Drawing.Color.White
        Me.BT_BLANCO.Image = Nothing
        Me.BT_BLANCO.ImageSize = New System.Drawing.Size(20, 20)
        Me.BT_BLANCO.Location = New System.Drawing.Point(517, 221)
        Me.BT_BLANCO.Name = "BT_BLANCO"
        Me.BT_BLANCO.OnHoverBaseColor = System.Drawing.Color.Green
        Me.BT_BLANCO.OnHoverBorderColor = System.Drawing.Color.Black
        Me.BT_BLANCO.OnHoverForeColor = System.Drawing.Color.White
        Me.BT_BLANCO.OnHoverImage = Nothing
        Me.BT_BLANCO.OnPressedColor = System.Drawing.Color.Black
        Me.BT_BLANCO.Size = New System.Drawing.Size(111, 53)
        Me.BT_BLANCO.TabIndex = 129
        Me.BT_BLANCO.Text = "BLANCO"
        Me.BT_BLANCO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BT_LISTA
        '
        Me.BT_LISTA.AnimationHoverSpeed = 0.07!
        Me.BT_LISTA.AnimationSpeed = 0.03!
        Me.BT_LISTA.BaseColor = System.Drawing.Color.Maroon
        Me.BT_LISTA.BorderColor = System.Drawing.Color.Black
        Me.BT_LISTA.FocusedColor = System.Drawing.Color.Empty
        Me.BT_LISTA.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT_LISTA.ForeColor = System.Drawing.Color.White
        Me.BT_LISTA.Image = Nothing
        Me.BT_LISTA.ImageSize = New System.Drawing.Size(20, 20)
        Me.BT_LISTA.Location = New System.Drawing.Point(157, 301)
        Me.BT_LISTA.Name = "BT_LISTA"
        Me.BT_LISTA.OnHoverBaseColor = System.Drawing.Color.Green
        Me.BT_LISTA.OnHoverBorderColor = System.Drawing.Color.Black
        Me.BT_LISTA.OnHoverForeColor = System.Drawing.Color.White
        Me.BT_LISTA.OnHoverImage = Nothing
        Me.BT_LISTA.OnPressedColor = System.Drawing.Color.Black
        Me.BT_LISTA.Size = New System.Drawing.Size(92, 53)
        Me.BT_LISTA.TabIndex = 125
        Me.BT_LISTA.Text = "LISTA A"
        Me.BT_LISTA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Votacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(774, 385)
        Me.Controls.Add(Me.BT_BLANCO)
        Me.Controls.Add(Me.BT_NULL)
        Me.Controls.Add(Me.BT_LISTC)
        Me.Controls.Add(Me.BT_LISTB)
        Me.Controls.Add(Me.BT_LISTA)
        Me.Controls.Add(Me.LB_INST)
        Me.Controls.Add(Me.GunaLabel1)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Votacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Votacion"
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents LB_INST As Guna.UI.WinForms.GunaLabel
    Friend WithEvents BT_LISTB As Guna.UI.WinForms.GunaButton
    Friend WithEvents BT_LISTC As Guna.UI.WinForms.GunaButton
    Friend WithEvents BT_NULL As Guna.UI.WinForms.GunaButton
    Friend WithEvents BT_BLANCO As Guna.UI.WinForms.GunaButton
    Friend WithEvents BT_LISTA As Guna.UI.WinForms.GunaButton
End Class
