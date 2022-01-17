<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class REGISTRO
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(REGISTRO))
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel3 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel4 = New Guna.UI.WinForms.GunaLabel()
        Me.TXT_CED = New Guna.UI.WinForms.GunaTextBox()
        Me.TXT_NOMB = New Guna.UI.WinForms.GunaTextBox()
        Me.TXT_AP = New Guna.UI.WinForms.GunaTextBox()
        Me.BT_CLOSE = New Guna.UI.WinForms.GunaButton()
        Me.BT_ACEPTAR = New Guna.UI.WinForms.GunaButton()
        Me.SuspendLayout()
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.GunaLabel1.Location = New System.Drawing.Point(93, 18)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(114, 30)
        Me.GunaLabel1.TabIndex = 197
        Me.GunaLabel1.Text = "REGISTRO"
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.GunaLabel2.Location = New System.Drawing.Point(18, 70)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(72, 21)
        Me.GunaLabel2.TabIndex = 198
        Me.GunaLabel2.Text = "CÉDULA"
        '
        'GunaLabel3
        '
        Me.GunaLabel3.AutoSize = True
        Me.GunaLabel3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel3.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.GunaLabel3.Location = New System.Drawing.Point(18, 106)
        Me.GunaLabel3.Name = "GunaLabel3"
        Me.GunaLabel3.Size = New System.Drawing.Size(88, 21)
        Me.GunaLabel3.TabIndex = 199
        Me.GunaLabel3.Text = "NOMBRES"
        '
        'GunaLabel4
        '
        Me.GunaLabel4.AutoSize = True
        Me.GunaLabel4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel4.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.GunaLabel4.Location = New System.Drawing.Point(18, 142)
        Me.GunaLabel4.Name = "GunaLabel4"
        Me.GunaLabel4.Size = New System.Drawing.Size(94, 21)
        Me.GunaLabel4.TabIndex = 200
        Me.GunaLabel4.Text = "APELLIDOS"
        '
        'TXT_CED
        '
        Me.TXT_CED.BaseColor = System.Drawing.Color.White
        Me.TXT_CED.BorderColor = System.Drawing.Color.Silver
        Me.TXT_CED.BorderSize = 2
        Me.TXT_CED.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_CED.FocusedBaseColor = System.Drawing.Color.White
        Me.TXT_CED.FocusedBorderColor = System.Drawing.Color.DeepSkyBlue
        Me.TXT_CED.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.TXT_CED.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_CED.Location = New System.Drawing.Point(118, 66)
        Me.TXT_CED.MaxLength = 10
        Me.TXT_CED.Name = "TXT_CED"
        Me.TXT_CED.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_CED.Size = New System.Drawing.Size(160, 30)
        Me.TXT_CED.TabIndex = 201
        Me.TXT_CED.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TXT_NOMB
        '
        Me.TXT_NOMB.BaseColor = System.Drawing.Color.White
        Me.TXT_NOMB.BorderColor = System.Drawing.Color.Silver
        Me.TXT_NOMB.BorderSize = 2
        Me.TXT_NOMB.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_NOMB.FocusedBaseColor = System.Drawing.Color.White
        Me.TXT_NOMB.FocusedBorderColor = System.Drawing.Color.DeepSkyBlue
        Me.TXT_NOMB.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.TXT_NOMB.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_NOMB.Location = New System.Drawing.Point(118, 102)
        Me.TXT_NOMB.MaxLength = 30
        Me.TXT_NOMB.Name = "TXT_NOMB"
        Me.TXT_NOMB.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_NOMB.Size = New System.Drawing.Size(160, 30)
        Me.TXT_NOMB.TabIndex = 202
        Me.TXT_NOMB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TXT_AP
        '
        Me.TXT_AP.BaseColor = System.Drawing.Color.White
        Me.TXT_AP.BorderColor = System.Drawing.Color.Silver
        Me.TXT_AP.BorderSize = 2
        Me.TXT_AP.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_AP.FocusedBaseColor = System.Drawing.Color.White
        Me.TXT_AP.FocusedBorderColor = System.Drawing.Color.DeepSkyBlue
        Me.TXT_AP.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.TXT_AP.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_AP.Location = New System.Drawing.Point(118, 138)
        Me.TXT_AP.MaxLength = 30
        Me.TXT_AP.Name = "TXT_AP"
        Me.TXT_AP.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_AP.Size = New System.Drawing.Size(160, 30)
        Me.TXT_AP.TabIndex = 203
        Me.TXT_AP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        Me.BT_CLOSE.Location = New System.Drawing.Point(104, 226)
        Me.BT_CLOSE.Name = "BT_CLOSE"
        Me.BT_CLOSE.OnHoverBaseColor = System.Drawing.Color.Red
        Me.BT_CLOSE.OnHoverBorderColor = System.Drawing.Color.Black
        Me.BT_CLOSE.OnHoverForeColor = System.Drawing.Color.White
        Me.BT_CLOSE.OnHoverImage = Nothing
        Me.BT_CLOSE.OnPressedColor = System.Drawing.Color.Black
        Me.BT_CLOSE.Size = New System.Drawing.Size(88, 24)
        Me.BT_CLOSE.TabIndex = 205
        Me.BT_CLOSE.Text = "CERRAR"
        Me.BT_CLOSE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BT_ACEPTAR
        '
        Me.BT_ACEPTAR.AnimationHoverSpeed = 0.07!
        Me.BT_ACEPTAR.AnimationSpeed = 0.03!
        Me.BT_ACEPTAR.BaseColor = System.Drawing.Color.Maroon
        Me.BT_ACEPTAR.BorderColor = System.Drawing.Color.Black
        Me.BT_ACEPTAR.FocusedColor = System.Drawing.Color.Empty
        Me.BT_ACEPTAR.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BT_ACEPTAR.ForeColor = System.Drawing.Color.White
        Me.BT_ACEPTAR.Image = Nothing
        Me.BT_ACEPTAR.ImageSize = New System.Drawing.Size(20, 20)
        Me.BT_ACEPTAR.Location = New System.Drawing.Point(104, 196)
        Me.BT_ACEPTAR.Name = "BT_ACEPTAR"
        Me.BT_ACEPTAR.OnHoverBaseColor = System.Drawing.Color.Green
        Me.BT_ACEPTAR.OnHoverBorderColor = System.Drawing.Color.Black
        Me.BT_ACEPTAR.OnHoverForeColor = System.Drawing.Color.White
        Me.BT_ACEPTAR.OnHoverImage = Nothing
        Me.BT_ACEPTAR.OnPressedColor = System.Drawing.Color.Black
        Me.BT_ACEPTAR.Size = New System.Drawing.Size(88, 24)
        Me.BT_ACEPTAR.TabIndex = 204
        Me.BT_ACEPTAR.Text = "REGISTRAR"
        Me.BT_ACEPTAR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REGISTRO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(294, 262)
        Me.Controls.Add(Me.BT_CLOSE)
        Me.Controls.Add(Me.BT_ACEPTAR)
        Me.Controls.Add(Me.TXT_AP)
        Me.Controls.Add(Me.TXT_NOMB)
        Me.Controls.Add(Me.TXT_CED)
        Me.Controls.Add(Me.GunaLabel4)
        Me.Controls.Add(Me.GunaLabel3)
        Me.Controls.Add(Me.GunaLabel2)
        Me.Controls.Add(Me.GunaLabel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "REGISTRO"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registro"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel4 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents TXT_CED As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents TXT_NOMB As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents TXT_AP As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents BT_CLOSE As Guna.UI.WinForms.GunaButton
    Friend WithEvents BT_ACEPTAR As Guna.UI.WinForms.GunaButton
End Class
