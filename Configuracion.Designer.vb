<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Configuracion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Configuracion))
        Me.Label4 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.TXT_NOMB = New Guna.UI.WinForms.GunaTextBox()
        Me.BT_CLOSE = New Guna.UI.WinForms.GunaButton()
        Me.Button1 = New Guna.UI.WinForms.GunaButton()
        Me.GunaButton1 = New Guna.UI.WinForms.GunaButton()
        Me.GunaButton2 = New Guna.UI.WinForms.GunaButton()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(177, 27)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(189, 30)
        Me.Label4.TabIndex = 124
        Me.Label4.Text = "CONFIGURACIÓN"
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.Location = New System.Drawing.Point(74, 89)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(182, 21)
        Me.GunaLabel1.TabIndex = 125
        Me.GunaLabel1.Text = "Nombre de Institución"
        '
        'TXT_NOMB
        '
        Me.TXT_NOMB.BaseColor = System.Drawing.Color.White
        Me.TXT_NOMB.BorderColor = System.Drawing.Color.Silver
        Me.TXT_NOMB.BorderSize = 2
        Me.TXT_NOMB.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_NOMB.FocusedBaseColor = System.Drawing.Color.White
        Me.TXT_NOMB.FocusedBorderColor = System.Drawing.Color.DodgerBlue
        Me.TXT_NOMB.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.TXT_NOMB.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_NOMB.Location = New System.Drawing.Point(12, 113)
        Me.TXT_NOMB.MaxLength = 100
        Me.TXT_NOMB.Name = "TXT_NOMB"
        Me.TXT_NOMB.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_NOMB.Size = New System.Drawing.Size(306, 30)
        Me.TXT_NOMB.TabIndex = 128
        Me.TXT_NOMB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        Me.BT_CLOSE.Location = New System.Drawing.Point(221, 214)
        Me.BT_CLOSE.Name = "BT_CLOSE"
        Me.BT_CLOSE.OnHoverBaseColor = System.Drawing.Color.Red
        Me.BT_CLOSE.OnHoverBorderColor = System.Drawing.Color.Black
        Me.BT_CLOSE.OnHoverForeColor = System.Drawing.Color.White
        Me.BT_CLOSE.OnHoverImage = Nothing
        Me.BT_CLOSE.OnPressedColor = System.Drawing.Color.Black
        Me.BT_CLOSE.Size = New System.Drawing.Size(96, 24)
        Me.BT_CLOSE.TabIndex = 133
        Me.BT_CLOSE.Text = "CERRAR"
        Me.BT_CLOSE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button1
        '
        Me.Button1.AnimationHoverSpeed = 0.07!
        Me.Button1.AnimationSpeed = 0.03!
        Me.Button1.BaseColor = System.Drawing.Color.Maroon
        Me.Button1.BorderColor = System.Drawing.Color.Black
        Me.Button1.FocusedColor = System.Drawing.Color.Empty
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Image = Nothing
        Me.Button1.ImageSize = New System.Drawing.Size(20, 20)
        Me.Button1.Location = New System.Drawing.Point(125, 149)
        Me.Button1.Name = "Button1"
        Me.Button1.OnHoverBaseColor = System.Drawing.Color.Green
        Me.Button1.OnHoverBorderColor = System.Drawing.Color.Black
        Me.Button1.OnHoverForeColor = System.Drawing.Color.White
        Me.Button1.OnHoverImage = Nothing
        Me.Button1.OnPressedColor = System.Drawing.Color.Black
        Me.Button1.Size = New System.Drawing.Size(96, 24)
        Me.Button1.TabIndex = 132
        Me.Button1.Text = "GUARDAR"
        Me.Button1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaButton1
        '
        Me.GunaButton1.AnimationHoverSpeed = 0.07!
        Me.GunaButton1.AnimationSpeed = 0.03!
        Me.GunaButton1.BaseColor = System.Drawing.Color.Maroon
        Me.GunaButton1.BorderColor = System.Drawing.Color.Black
        Me.GunaButton1.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButton1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaButton1.ForeColor = System.Drawing.Color.White
        Me.GunaButton1.Image = Nothing
        Me.GunaButton1.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaButton1.Location = New System.Drawing.Point(383, 98)
        Me.GunaButton1.Name = "GunaButton1"
        Me.GunaButton1.OnHoverBaseColor = System.Drawing.Color.DodgerBlue
        Me.GunaButton1.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaButton1.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButton1.OnHoverImage = Nothing
        Me.GunaButton1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButton1.Size = New System.Drawing.Size(126, 23)
        Me.GunaButton1.TabIndex = 134
        Me.GunaButton1.Text = "AGREGAR LISTA"
        Me.GunaButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaButton2
        '
        Me.GunaButton2.AnimationHoverSpeed = 0.07!
        Me.GunaButton2.AnimationSpeed = 0.03!
        Me.GunaButton2.BaseColor = System.Drawing.Color.Maroon
        Me.GunaButton2.BorderColor = System.Drawing.Color.Black
        Me.GunaButton2.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButton2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaButton2.ForeColor = System.Drawing.Color.White
        Me.GunaButton2.Image = Nothing
        Me.GunaButton2.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaButton2.Location = New System.Drawing.Point(383, 131)
        Me.GunaButton2.Name = "GunaButton2"
        Me.GunaButton2.OnHoverBaseColor = System.Drawing.Color.DodgerBlue
        Me.GunaButton2.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaButton2.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButton2.OnHoverImage = Nothing
        Me.GunaButton2.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButton2.Size = New System.Drawing.Size(126, 23)
        Me.GunaButton2.TabIndex = 135
        Me.GunaButton2.Text = "CAMBIAR SELLOS"
        Me.GunaButton2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Configuracion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(523, 250)
        Me.Controls.Add(Me.GunaButton2)
        Me.Controls.Add(Me.GunaButton1)
        Me.Controls.Add(Me.BT_CLOSE)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TXT_NOMB)
        Me.Controls.Add(Me.GunaLabel1)
        Me.Controls.Add(Me.Label4)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Configuracion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Configuracion"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label4 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents TXT_NOMB As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents BT_CLOSE As Guna.UI.WinForms.GunaButton
    Friend WithEvents Button1 As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaButton1 As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaButton2 As Guna.UI.WinForms.GunaButton
End Class
