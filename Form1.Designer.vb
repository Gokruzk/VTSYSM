<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.BT_CLOSE = New Guna.UI.WinForms.GunaButton()
        Me.BT_ACEPTAR2 = New Guna.UI.WinForms.GunaButton()
        Me.BT_ACEPTAR = New Guna.UI.WinForms.GunaButton()
        Me.TXT_PASS = New Guna.UI.WinForms.GunaTextBox()
        Me.TXT_COD = New Guna.UI.WinForms.GunaTextBox()
        Me.BT_AD = New Guna.UI.WinForms.GunaButton()
        Me.Label3 = New Guna.UI.WinForms.GunaLabel()
        Me.Label1 = New Guna.UI.WinForms.GunaLabel()
        Me.Label4 = New Guna.UI.WinForms.GunaLabel()
        Me.LB_INST = New Guna.UI.WinForms.GunaLabel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.BT_CLOSE.Location = New System.Drawing.Point(411, 344)
        Me.BT_CLOSE.Name = "BT_CLOSE"
        Me.BT_CLOSE.OnHoverBaseColor = System.Drawing.Color.Red
        Me.BT_CLOSE.OnHoverBorderColor = System.Drawing.Color.Black
        Me.BT_CLOSE.OnHoverForeColor = System.Drawing.Color.White
        Me.BT_CLOSE.OnHoverImage = Nothing
        Me.BT_CLOSE.OnPressedColor = System.Drawing.Color.Black
        Me.BT_CLOSE.Size = New System.Drawing.Size(88, 24)
        Me.BT_CLOSE.TabIndex = 131
        Me.BT_CLOSE.Text = "CERRAR"
        Me.BT_CLOSE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BT_ACEPTAR2
        '
        Me.BT_ACEPTAR2.AnimationHoverSpeed = 0.07!
        Me.BT_ACEPTAR2.AnimationSpeed = 0.03!
        Me.BT_ACEPTAR2.BaseColor = System.Drawing.Color.Maroon
        Me.BT_ACEPTAR2.BorderColor = System.Drawing.Color.Black
        Me.BT_ACEPTAR2.FocusedColor = System.Drawing.Color.Empty
        Me.BT_ACEPTAR2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BT_ACEPTAR2.ForeColor = System.Drawing.Color.White
        Me.BT_ACEPTAR2.Image = Nothing
        Me.BT_ACEPTAR2.ImageSize = New System.Drawing.Size(20, 20)
        Me.BT_ACEPTAR2.Location = New System.Drawing.Point(317, 374)
        Me.BT_ACEPTAR2.Name = "BT_ACEPTAR2"
        Me.BT_ACEPTAR2.OnHoverBaseColor = System.Drawing.Color.Green
        Me.BT_ACEPTAR2.OnHoverBorderColor = System.Drawing.Color.Black
        Me.BT_ACEPTAR2.OnHoverForeColor = System.Drawing.Color.White
        Me.BT_ACEPTAR2.OnHoverImage = Nothing
        Me.BT_ACEPTAR2.OnPressedColor = System.Drawing.Color.Black
        Me.BT_ACEPTAR2.Size = New System.Drawing.Size(88, 24)
        Me.BT_ACEPTAR2.TabIndex = 130
        Me.BT_ACEPTAR2.Text = "ACEPTAR"
        Me.BT_ACEPTAR2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.BT_ACEPTAR2.Visible = False
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
        Me.BT_ACEPTAR.Location = New System.Drawing.Point(317, 344)
        Me.BT_ACEPTAR.Name = "BT_ACEPTAR"
        Me.BT_ACEPTAR.OnHoverBaseColor = System.Drawing.Color.Green
        Me.BT_ACEPTAR.OnHoverBorderColor = System.Drawing.Color.Black
        Me.BT_ACEPTAR.OnHoverForeColor = System.Drawing.Color.White
        Me.BT_ACEPTAR.OnHoverImage = Nothing
        Me.BT_ACEPTAR.OnPressedColor = System.Drawing.Color.Black
        Me.BT_ACEPTAR.Size = New System.Drawing.Size(88, 24)
        Me.BT_ACEPTAR.TabIndex = 129
        Me.BT_ACEPTAR.Text = "ACEPTAR"
        Me.BT_ACEPTAR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TXT_PASS
        '
        Me.TXT_PASS.BaseColor = System.Drawing.Color.White
        Me.TXT_PASS.BorderColor = System.Drawing.Color.Silver
        Me.TXT_PASS.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_PASS.FocusedBaseColor = System.Drawing.Color.White
        Me.TXT_PASS.FocusedBorderColor = System.Drawing.Color.DodgerBlue
        Me.TXT_PASS.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.TXT_PASS.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_PASS.Location = New System.Drawing.Point(327, 338)
        Me.TXT_PASS.MaxLength = 10
        Me.TXT_PASS.Name = "TXT_PASS"
        Me.TXT_PASS.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TXT_PASS.Size = New System.Drawing.Size(160, 30)
        Me.TXT_PASS.TabIndex = 128
        Me.TXT_PASS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TXT_PASS.Visible = False
        '
        'TXT_COD
        '
        Me.TXT_COD.BaseColor = System.Drawing.Color.White
        Me.TXT_COD.BorderColor = System.Drawing.Color.Silver
        Me.TXT_COD.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_COD.FocusedBaseColor = System.Drawing.Color.White
        Me.TXT_COD.FocusedBorderColor = System.Drawing.Color.DodgerBlue
        Me.TXT_COD.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.TXT_COD.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_COD.Location = New System.Drawing.Point(326, 303)
        Me.TXT_COD.MaxLength = 10
        Me.TXT_COD.Name = "TXT_COD"
        Me.TXT_COD.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_COD.Size = New System.Drawing.Size(160, 30)
        Me.TXT_COD.TabIndex = 127
        Me.TXT_COD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BT_AD
        '
        Me.BT_AD.AnimationHoverSpeed = 0.07!
        Me.BT_AD.AnimationSpeed = 0.03!
        Me.BT_AD.BaseColor = System.Drawing.SystemColors.ControlDark
        Me.BT_AD.BorderColor = System.Drawing.Color.Black
        Me.BT_AD.FocusedColor = System.Drawing.Color.Empty
        Me.BT_AD.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BT_AD.ForeColor = System.Drawing.Color.White
        Me.BT_AD.Image = CType(resources.GetObject("BT_AD.Image"), System.Drawing.Image)
        Me.BT_AD.ImageSize = New System.Drawing.Size(20, 20)
        Me.BT_AD.Location = New System.Drawing.Point(505, 309)
        Me.BT_AD.Name = "BT_AD"
        Me.BT_AD.OnHoverBaseColor = System.Drawing.Color.DodgerBlue
        Me.BT_AD.OnHoverBorderColor = System.Drawing.Color.Black
        Me.BT_AD.OnHoverForeColor = System.Drawing.Color.White
        Me.BT_AD.OnHoverImage = Nothing
        Me.BT_AD.OnPressedColor = System.Drawing.Color.Black
        Me.BT_AD.Size = New System.Drawing.Size(122, 42)
        Me.BT_AD.TabIndex = 126
        Me.BT_AD.Text = "ADMINISTRAR"
        Me.BT_AD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(177, 344)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(138, 25)
        Me.Label3.TabIndex = 125
        Me.Label3.Text = "CONTRASEÑA"
        Me.Label3.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(206, 309)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 25)
        Me.Label1.TabIndex = 124
        Me.Label1.Text = "CÉDULA"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(256, 86)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(243, 25)
        Me.Label4.TabIndex = 123
        Me.Label4.Text = "SISTEMA DE VOTACIONES"
        '
        'LB_INST
        '
        Me.LB_INST.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LB_INST.AutoSize = True
        Me.LB_INST.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Me.LB_INST.Location = New System.Drawing.Point(206, 40)
        Me.LB_INST.Name = "LB_INST"
        Me.LB_INST.Size = New System.Drawing.Size(133, 25)
        Me.LB_INST.TabIndex = 122
        Me.LB_INST.Text = "INSTITUCION"
        Me.LB_INST.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(338, 135)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(133, 150)
        Me.PictureBox1.TabIndex = 132
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(765, 385)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.BT_CLOSE)
        Me.Controls.Add(Me.BT_ACEPTAR2)
        Me.Controls.Add(Me.BT_ACEPTAR)
        Me.Controls.Add(Me.TXT_PASS)
        Me.Controls.Add(Me.TXT_COD)
        Me.Controls.Add(Me.BT_AD)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.LB_INST)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "VTSYSM"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BT_CLOSE As Guna.UI.WinForms.GunaButton
    Friend WithEvents BT_ACEPTAR2 As Guna.UI.WinForms.GunaButton
    Friend WithEvents BT_ACEPTAR As Guna.UI.WinForms.GunaButton
    Friend WithEvents TXT_PASS As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents TXT_COD As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents BT_AD As Guna.UI.WinForms.GunaButton
    Friend WithEvents Label3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents Label1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents Label4 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents LB_INST As Guna.UI.WinForms.GunaLabel
    Friend WithEvents PictureBox1 As PictureBox
End Class
