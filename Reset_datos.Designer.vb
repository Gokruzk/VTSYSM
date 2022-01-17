<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reset_datos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Reset_datos))
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.BT_RST = New Guna.UI.WinForms.GunaButton()
        Me.BT_ALL = New Guna.UI.WinForms.GunaButton()
        Me.BT_CLOSE = New Guna.UI.WinForms.GunaButton()
        Me.SuspendLayout()
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.Location = New System.Drawing.Point(89, 9)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(218, 30)
        Me.GunaLabel1.TabIndex = 195
        Me.GunaLabel1.Text = "CONTROL DE DATOS"
        '
        'BT_RST
        '
        Me.BT_RST.AnimationHoverSpeed = 0.07!
        Me.BT_RST.AnimationSpeed = 0.03!
        Me.BT_RST.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BT_RST.BaseColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BT_RST.BorderColor = System.Drawing.Color.Black
        Me.BT_RST.FocusedColor = System.Drawing.Color.Empty
        Me.BT_RST.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BT_RST.ForeColor = System.Drawing.Color.Black
        Me.BT_RST.Image = CType(resources.GetObject("BT_RST.Image"), System.Drawing.Image)
        Me.BT_RST.ImageSize = New System.Drawing.Size(25, 25)
        Me.BT_RST.Location = New System.Drawing.Point(12, 59)
        Me.BT_RST.Name = "BT_RST"
        Me.BT_RST.OnHoverBaseColor = System.Drawing.Color.Green
        Me.BT_RST.OnHoverBorderColor = System.Drawing.SystemColors.MenuHighlight
        Me.BT_RST.OnHoverForeColor = System.Drawing.Color.White
        Me.BT_RST.OnHoverImage = Nothing
        Me.BT_RST.OnPressedColor = System.Drawing.Color.Black
        Me.BT_RST.Size = New System.Drawing.Size(159, 42)
        Me.BT_RST.TabIndex = 198
        Me.BT_RST.Text = "REINICIAR CONTEO"
        Me.BT_RST.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'BT_ALL
        '
        Me.BT_ALL.AnimationHoverSpeed = 0.07!
        Me.BT_ALL.AnimationSpeed = 0.03!
        Me.BT_ALL.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BT_ALL.BaseColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BT_ALL.BorderColor = System.Drawing.Color.Black
        Me.BT_ALL.FocusedColor = System.Drawing.Color.Empty
        Me.BT_ALL.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BT_ALL.ForeColor = System.Drawing.Color.Black
        Me.BT_ALL.Image = CType(resources.GetObject("BT_ALL.Image"), System.Drawing.Image)
        Me.BT_ALL.ImageSize = New System.Drawing.Size(25, 25)
        Me.BT_ALL.Location = New System.Drawing.Point(180, 59)
        Me.BT_ALL.Name = "BT_ALL"
        Me.BT_ALL.OnHoverBaseColor = System.Drawing.Color.Green
        Me.BT_ALL.OnHoverBorderColor = System.Drawing.SystemColors.MenuHighlight
        Me.BT_ALL.OnHoverForeColor = System.Drawing.Color.White
        Me.BT_ALL.OnHoverImage = Nothing
        Me.BT_ALL.OnPressedColor = System.Drawing.Color.Black
        Me.BT_ALL.Size = New System.Drawing.Size(205, 42)
        Me.BT_ALL.TabIndex = 199
        Me.BT_ALL.Text = "REINICIAR CONFIGURACIÓN"
        Me.BT_ALL.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'BT_CLOSE
        '
        Me.BT_CLOSE.AnimationHoverSpeed = 0.07!
        Me.BT_CLOSE.AnimationSpeed = 0.03!
        Me.BT_CLOSE.BaseColor = System.Drawing.Color.Maroon
        Me.BT_CLOSE.BorderColor = System.Drawing.Color.Black
        Me.BT_CLOSE.FocusedColor = System.Drawing.Color.Empty
        Me.BT_CLOSE.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BT_CLOSE.ForeColor = System.Drawing.Color.White
        Me.BT_CLOSE.Image = Nothing
        Me.BT_CLOSE.ImageSize = New System.Drawing.Size(20, 20)
        Me.BT_CLOSE.Location = New System.Drawing.Point(149, 124)
        Me.BT_CLOSE.Name = "BT_CLOSE"
        Me.BT_CLOSE.OnHoverBaseColor = System.Drawing.Color.Red
        Me.BT_CLOSE.OnHoverBorderColor = System.Drawing.Color.Black
        Me.BT_CLOSE.OnHoverForeColor = System.Drawing.Color.White
        Me.BT_CLOSE.OnHoverImage = Nothing
        Me.BT_CLOSE.OnPressedColor = System.Drawing.Color.Black
        Me.BT_CLOSE.Size = New System.Drawing.Size(96, 24)
        Me.BT_CLOSE.TabIndex = 200
        Me.BT_CLOSE.Text = "CERRAR"
        Me.BT_CLOSE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Reset_datos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(397, 160)
        Me.Controls.Add(Me.BT_CLOSE)
        Me.Controls.Add(Me.BT_ALL)
        Me.Controls.Add(Me.BT_RST)
        Me.Controls.Add(Me.GunaLabel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Reset_datos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Resetear Datos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents BT_RST As Guna.UI.WinForms.GunaButton
    Friend WithEvents BT_ALL As Guna.UI.WinForms.GunaButton
    Friend WithEvents BT_CLOSE As Guna.UI.WinForms.GunaButton
End Class
