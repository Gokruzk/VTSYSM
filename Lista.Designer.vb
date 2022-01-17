<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Lista
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Lista))
        Me.Label4 = New Guna.UI.WinForms.GunaLabel()
        Me.TXT_LET = New Guna.UI.WinForms.GunaTextBox()
        Me.TXT_CED_PRES = New Guna.UI.WinForms.GunaTextBox()
        Me.TXT_NOM_PRES = New Guna.UI.WinForms.GunaTextBox()
        Me.TXT_APELL_PRES = New Guna.UI.WinForms.GunaTextBox()
        Me.TXT_CED_VICE = New Guna.UI.WinForms.GunaTextBox()
        Me.TXT_NOM_VICE = New Guna.UI.WinForms.GunaTextBox()
        Me.TXT_APELL_VICE = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel3 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel4 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel6 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel8 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel10 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel5 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel7 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel9 = New Guna.UI.WinForms.GunaLabel()
        Me.BT_CLOSE = New Guna.UI.WinForms.GunaButton()
        Me.Button1 = New Guna.UI.WinForms.GunaButton()
        Me.Button2 = New Guna.UI.WinForms.GunaButton()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(244, 14)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(207, 30)
        Me.Label4.TabIndex = 125
        Me.Label4.Text = "DATOS DE LA LISTA"
        '
        'TXT_LET
        '
        Me.TXT_LET.BaseColor = System.Drawing.Color.White
        Me.TXT_LET.BorderColor = System.Drawing.Color.Silver
        Me.TXT_LET.BorderSize = 2
        Me.TXT_LET.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_LET.FocusedBaseColor = System.Drawing.Color.White
        Me.TXT_LET.FocusedBorderColor = System.Drawing.Color.DodgerBlue
        Me.TXT_LET.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.TXT_LET.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_LET.Location = New System.Drawing.Point(156, 64)
        Me.TXT_LET.MaxLength = 10
        Me.TXT_LET.Name = "TXT_LET"
        Me.TXT_LET.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_LET.Size = New System.Drawing.Size(107, 30)
        Me.TXT_LET.TabIndex = 129
        Me.TXT_LET.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TXT_CED_PRES
        '
        Me.TXT_CED_PRES.BaseColor = System.Drawing.Color.White
        Me.TXT_CED_PRES.BorderColor = System.Drawing.Color.Silver
        Me.TXT_CED_PRES.BorderSize = 2
        Me.TXT_CED_PRES.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_CED_PRES.FocusedBaseColor = System.Drawing.Color.White
        Me.TXT_CED_PRES.FocusedBorderColor = System.Drawing.Color.DodgerBlue
        Me.TXT_CED_PRES.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.TXT_CED_PRES.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_CED_PRES.Location = New System.Drawing.Point(156, 141)
        Me.TXT_CED_PRES.MaxLength = 10
        Me.TXT_CED_PRES.Name = "TXT_CED_PRES"
        Me.TXT_CED_PRES.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_CED_PRES.Size = New System.Drawing.Size(198, 30)
        Me.TXT_CED_PRES.TabIndex = 130
        Me.TXT_CED_PRES.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TXT_NOM_PRES
        '
        Me.TXT_NOM_PRES.BaseColor = System.Drawing.Color.White
        Me.TXT_NOM_PRES.BorderColor = System.Drawing.Color.Silver
        Me.TXT_NOM_PRES.BorderSize = 2
        Me.TXT_NOM_PRES.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_NOM_PRES.FocusedBaseColor = System.Drawing.Color.White
        Me.TXT_NOM_PRES.FocusedBorderColor = System.Drawing.Color.DodgerBlue
        Me.TXT_NOM_PRES.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.TXT_NOM_PRES.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_NOM_PRES.Location = New System.Drawing.Point(156, 177)
        Me.TXT_NOM_PRES.MaxLength = 30
        Me.TXT_NOM_PRES.Name = "TXT_NOM_PRES"
        Me.TXT_NOM_PRES.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_NOM_PRES.Size = New System.Drawing.Size(198, 30)
        Me.TXT_NOM_PRES.TabIndex = 131
        Me.TXT_NOM_PRES.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TXT_APELL_PRES
        '
        Me.TXT_APELL_PRES.BaseColor = System.Drawing.Color.White
        Me.TXT_APELL_PRES.BorderColor = System.Drawing.Color.Silver
        Me.TXT_APELL_PRES.BorderSize = 2
        Me.TXT_APELL_PRES.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_APELL_PRES.FocusedBaseColor = System.Drawing.Color.White
        Me.TXT_APELL_PRES.FocusedBorderColor = System.Drawing.Color.DodgerBlue
        Me.TXT_APELL_PRES.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.TXT_APELL_PRES.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_APELL_PRES.Location = New System.Drawing.Point(156, 217)
        Me.TXT_APELL_PRES.MaxLength = 30
        Me.TXT_APELL_PRES.Name = "TXT_APELL_PRES"
        Me.TXT_APELL_PRES.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_APELL_PRES.Size = New System.Drawing.Size(198, 30)
        Me.TXT_APELL_PRES.TabIndex = 132
        Me.TXT_APELL_PRES.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TXT_CED_VICE
        '
        Me.TXT_CED_VICE.BaseColor = System.Drawing.Color.White
        Me.TXT_CED_VICE.BorderColor = System.Drawing.Color.Silver
        Me.TXT_CED_VICE.BorderSize = 2
        Me.TXT_CED_VICE.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_CED_VICE.FocusedBaseColor = System.Drawing.Color.White
        Me.TXT_CED_VICE.FocusedBorderColor = System.Drawing.Color.DodgerBlue
        Me.TXT_CED_VICE.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.TXT_CED_VICE.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_CED_VICE.Location = New System.Drawing.Point(156, 298)
        Me.TXT_CED_VICE.MaxLength = 10
        Me.TXT_CED_VICE.Name = "TXT_CED_VICE"
        Me.TXT_CED_VICE.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_CED_VICE.Size = New System.Drawing.Size(198, 30)
        Me.TXT_CED_VICE.TabIndex = 133
        Me.TXT_CED_VICE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TXT_NOM_VICE
        '
        Me.TXT_NOM_VICE.BaseColor = System.Drawing.Color.White
        Me.TXT_NOM_VICE.BorderColor = System.Drawing.Color.Silver
        Me.TXT_NOM_VICE.BorderSize = 2
        Me.TXT_NOM_VICE.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_NOM_VICE.FocusedBaseColor = System.Drawing.Color.White
        Me.TXT_NOM_VICE.FocusedBorderColor = System.Drawing.Color.DodgerBlue
        Me.TXT_NOM_VICE.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.TXT_NOM_VICE.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_NOM_VICE.Location = New System.Drawing.Point(156, 336)
        Me.TXT_NOM_VICE.MaxLength = 30
        Me.TXT_NOM_VICE.Name = "TXT_NOM_VICE"
        Me.TXT_NOM_VICE.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_NOM_VICE.Size = New System.Drawing.Size(198, 30)
        Me.TXT_NOM_VICE.TabIndex = 134
        Me.TXT_NOM_VICE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TXT_APELL_VICE
        '
        Me.TXT_APELL_VICE.BaseColor = System.Drawing.Color.White
        Me.TXT_APELL_VICE.BorderColor = System.Drawing.Color.Silver
        Me.TXT_APELL_VICE.BorderSize = 2
        Me.TXT_APELL_VICE.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_APELL_VICE.FocusedBaseColor = System.Drawing.Color.White
        Me.TXT_APELL_VICE.FocusedBorderColor = System.Drawing.Color.DodgerBlue
        Me.TXT_APELL_VICE.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.TXT_APELL_VICE.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_APELL_VICE.Location = New System.Drawing.Point(156, 374)
        Me.TXT_APELL_VICE.MaxLength = 30
        Me.TXT_APELL_VICE.Name = "TXT_APELL_VICE"
        Me.TXT_APELL_VICE.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_APELL_VICE.Size = New System.Drawing.Size(198, 30)
        Me.TXT_APELL_VICE.TabIndex = 135
        Me.TXT_APELL_VICE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.Location = New System.Drawing.Point(50, 64)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(48, 21)
        Me.GunaLabel1.TabIndex = 136
        Me.GunaLabel1.Text = "Letra"
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel2.Location = New System.Drawing.Point(48, 177)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(80, 21)
        Me.GunaLabel2.TabIndex = 137
        Me.GunaLabel2.Text = "Nombres"
        '
        'GunaLabel3
        '
        Me.GunaLabel3.AutoSize = True
        Me.GunaLabel3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel3.Location = New System.Drawing.Point(48, 139)
        Me.GunaLabel3.Name = "GunaLabel3"
        Me.GunaLabel3.Size = New System.Drawing.Size(63, 21)
        Me.GunaLabel3.TabIndex = 138
        Me.GunaLabel3.Text = "Cédula"
        '
        'GunaLabel4
        '
        Me.GunaLabel4.AutoSize = True
        Me.GunaLabel4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel4.Location = New System.Drawing.Point(253, 103)
        Me.GunaLabel4.Name = "GunaLabel4"
        Me.GunaLabel4.Size = New System.Drawing.Size(155, 21)
        Me.GunaLabel4.TabIndex = 139
        Me.GunaLabel4.Text = "Datos Presidente/a"
        '
        'GunaLabel6
        '
        Me.GunaLabel6.AutoSize = True
        Me.GunaLabel6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel6.Location = New System.Drawing.Point(241, 267)
        Me.GunaLabel6.Name = "GunaLabel6"
        Me.GunaLabel6.Size = New System.Drawing.Size(188, 21)
        Me.GunaLabel6.TabIndex = 141
        Me.GunaLabel6.Text = "Datos Vicepresidente/a"
        '
        'GunaLabel8
        '
        Me.GunaLabel8.AutoSize = True
        Me.GunaLabel8.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel8.Location = New System.Drawing.Point(48, 217)
        Me.GunaLabel8.Name = "GunaLabel8"
        Me.GunaLabel8.Size = New System.Drawing.Size(82, 21)
        Me.GunaLabel8.TabIndex = 143
        Me.GunaLabel8.Text = "Apellidos"
        '
        'GunaLabel10
        '
        Me.GunaLabel10.AutoSize = True
        Me.GunaLabel10.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel10.Location = New System.Drawing.Point(473, 407)
        Me.GunaLabel10.Name = "GunaLabel10"
        Me.GunaLabel10.Size = New System.Drawing.Size(175, 21)
        Me.GunaLabel10.TabIndex = 145
        Me.GunaLabel10.Text = "Nota: Máximo 3 listas"
        '
        'GunaLabel5
        '
        Me.GunaLabel5.AutoSize = True
        Me.GunaLabel5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel5.Location = New System.Drawing.Point(48, 374)
        Me.GunaLabel5.Name = "GunaLabel5"
        Me.GunaLabel5.Size = New System.Drawing.Size(82, 21)
        Me.GunaLabel5.TabIndex = 148
        Me.GunaLabel5.Text = "Apellidos"
        '
        'GunaLabel7
        '
        Me.GunaLabel7.AutoSize = True
        Me.GunaLabel7.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel7.Location = New System.Drawing.Point(48, 296)
        Me.GunaLabel7.Name = "GunaLabel7"
        Me.GunaLabel7.Size = New System.Drawing.Size(63, 21)
        Me.GunaLabel7.TabIndex = 147
        Me.GunaLabel7.Text = "Cédula"
        '
        'GunaLabel9
        '
        Me.GunaLabel9.AutoSize = True
        Me.GunaLabel9.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel9.Location = New System.Drawing.Point(48, 334)
        Me.GunaLabel9.Name = "GunaLabel9"
        Me.GunaLabel9.Size = New System.Drawing.Size(80, 21)
        Me.GunaLabel9.TabIndex = 146
        Me.GunaLabel9.Text = "Nombres"
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
        Me.BT_CLOSE.Location = New System.Drawing.Point(353, 465)
        Me.BT_CLOSE.Name = "BT_CLOSE"
        Me.BT_CLOSE.OnHoverBaseColor = System.Drawing.Color.Red
        Me.BT_CLOSE.OnHoverBorderColor = System.Drawing.Color.Black
        Me.BT_CLOSE.OnHoverForeColor = System.Drawing.Color.White
        Me.BT_CLOSE.OnHoverImage = Nothing
        Me.BT_CLOSE.OnPressedColor = System.Drawing.Color.Black
        Me.BT_CLOSE.Size = New System.Drawing.Size(96, 24)
        Me.BT_CLOSE.TabIndex = 150
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
        Me.Button1.Location = New System.Drawing.Point(251, 465)
        Me.Button1.Name = "Button1"
        Me.Button1.OnHoverBaseColor = System.Drawing.Color.Green
        Me.Button1.OnHoverBorderColor = System.Drawing.Color.Black
        Me.Button1.OnHoverForeColor = System.Drawing.Color.White
        Me.Button1.OnHoverImage = Nothing
        Me.Button1.OnPressedColor = System.Drawing.Color.Black
        Me.Button1.Size = New System.Drawing.Size(96, 24)
        Me.Button1.TabIndex = 149
        Me.Button1.Text = "GUARDAR"
        Me.Button1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button2
        '
        Me.Button2.AnimationHoverSpeed = 0.07!
        Me.Button2.AnimationSpeed = 0.03!
        Me.Button2.BaseColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button2.BorderColor = System.Drawing.Color.Black
        Me.Button2.FocusedColor = System.Drawing.Color.Empty
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageSize = New System.Drawing.Size(30, 30)
        Me.Button2.Location = New System.Drawing.Point(452, 208)
        Me.Button2.Name = "Button2"
        Me.Button2.OnHoverBaseColor = System.Drawing.Color.DodgerBlue
        Me.Button2.OnHoverBorderColor = System.Drawing.Color.Black
        Me.Button2.OnHoverForeColor = System.Drawing.Color.White
        Me.Button2.OnHoverImage = Nothing
        Me.Button2.OnPressedColor = System.Drawing.Color.Black
        Me.Button2.Size = New System.Drawing.Size(227, 49)
        Me.Button2.TabIndex = 151
        Me.Button2.Text = "VER LISTAS REGISTRADAS"
        Me.Button2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Lista
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(701, 501)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.BT_CLOSE)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GunaLabel5)
        Me.Controls.Add(Me.GunaLabel7)
        Me.Controls.Add(Me.GunaLabel9)
        Me.Controls.Add(Me.GunaLabel10)
        Me.Controls.Add(Me.GunaLabel8)
        Me.Controls.Add(Me.GunaLabel6)
        Me.Controls.Add(Me.GunaLabel4)
        Me.Controls.Add(Me.GunaLabel3)
        Me.Controls.Add(Me.GunaLabel2)
        Me.Controls.Add(Me.GunaLabel1)
        Me.Controls.Add(Me.TXT_APELL_VICE)
        Me.Controls.Add(Me.TXT_NOM_VICE)
        Me.Controls.Add(Me.TXT_CED_VICE)
        Me.Controls.Add(Me.TXT_APELL_PRES)
        Me.Controls.Add(Me.TXT_NOM_PRES)
        Me.Controls.Add(Me.TXT_CED_PRES)
        Me.Controls.Add(Me.TXT_LET)
        Me.Controls.Add(Me.Label4)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Lista"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lista"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label4 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents TXT_LET As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents TXT_CED_PRES As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents TXT_NOM_PRES As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents TXT_APELL_PRES As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents TXT_CED_VICE As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents TXT_NOM_VICE As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents TXT_APELL_VICE As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel4 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel6 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel8 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel10 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel5 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel7 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel9 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents BT_CLOSE As Guna.UI.WinForms.GunaButton
    Friend WithEvents Button1 As Guna.UI.WinForms.GunaButton
    Friend WithEvents Button2 As Guna.UI.WinForms.GunaButton
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
