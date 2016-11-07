<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Usuarios
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnsalir = New System.Windows.Forms.Button()
        Me.btndeshacer = New System.Windows.Forms.Button()
        Me.btnguardar = New System.Windows.Forms.Button()
        Me.txtusuario = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtclave = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.NuevoToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.btnsalir)
        Me.GroupBox1.Controls.Add(Me.btndeshacer)
        Me.GroupBox1.Controls.Add(Me.btnguardar)
        Me.GroupBox1.Controls.Add(Me.txtusuario)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtnombre)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.txtclave)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 28)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(379, 169)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"ADMINISTRADOR ", "PROFESOR"})
        Me.ComboBox1.Location = New System.Drawing.Point(84, 95)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(224, 21)
        Me.ComboBox1.TabIndex = 42
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 13)
        Me.Label3.TabIndex = 41
        Me.Label3.Text = "Tipo Usuario"
        '
        'btnsalir
        '
        Me.btnsalir.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnsalir.Image = Global.Idiomas.My.Resources.Resources.cancel
        Me.btnsalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnsalir.Location = New System.Drawing.Point(298, 124)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(75, 39)
        Me.btnsalir.TabIndex = 40
        Me.btnsalir.Text = "Salir"
        Me.btnsalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnsalir.UseVisualStyleBackColor = False
        '
        'btndeshacer
        '
        Me.btndeshacer.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btndeshacer.Image = Global.Idiomas.My.Resources.Resources.redo
        Me.btndeshacer.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btndeshacer.Location = New System.Drawing.Point(217, 124)
        Me.btndeshacer.Name = "btndeshacer"
        Me.btndeshacer.Size = New System.Drawing.Size(75, 39)
        Me.btndeshacer.TabIndex = 39
        Me.btndeshacer.Text = "Deshacer"
        Me.btndeshacer.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btndeshacer.UseVisualStyleBackColor = False
        '
        'btnguardar
        '
        Me.btnguardar.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnguardar.Image = Global.Idiomas.My.Resources.Resources.filesave
        Me.btnguardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnguardar.Location = New System.Drawing.Point(136, 124)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(75, 39)
        Me.btnguardar.TabIndex = 38
        Me.btnguardar.Text = "Guardar "
        Me.btnguardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnguardar.UseVisualStyleBackColor = False
        '
        'txtusuario
        '
        Me.txtusuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtusuario.Location = New System.Drawing.Point(84, 69)
        Me.txtusuario.Name = "txtusuario"
        Me.txtusuario.Size = New System.Drawing.Size(225, 20)
        Me.txtusuario.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(35, 72)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Usuario"
        '
        'txtnombre
        '
        Me.txtnombre.Location = New System.Drawing.Point(84, 43)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.ReadOnly = True
        Me.txtnombre.Size = New System.Drawing.Size(289, 20)
        Me.txtnombre.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(34, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Nombre"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Button1.Image = Global.Idiomas.My.Resources.Resources.filefind
        Me.Button1.Location = New System.Drawing.Point(190, 15)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(37, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.UseVisualStyleBackColor = False
        '
        'txtclave
        '
        Me.txtclave.Location = New System.Drawing.Point(84, 17)
        Me.txtclave.Name = "txtclave"
        Me.txtclave.ReadOnly = True
        Me.txtclave.Size = New System.Drawing.Size(100, 20)
        Me.txtclave.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(44, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Clave"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoToolStripButton})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(403, 25)
        Me.ToolStrip1.TabIndex = 2
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'NuevoToolStripButton
        '
        Me.NuevoToolStripButton.Image = Global.Idiomas.My.Resources.Resources.filenew1
        Me.NuevoToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.NuevoToolStripButton.Name = "NuevoToolStripButton"
        Me.NuevoToolStripButton.Size = New System.Drawing.Size(105, 22)
        Me.NuevoToolStripButton.Text = "Nuevo Usuario"
        '
        'Usuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(403, 209)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Usuarios"
        Me.Text = "Usuarios"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtusuario As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtnombre As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtclave As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents NuevoToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnsalir As System.Windows.Forms.Button
    Friend WithEvents btndeshacer As System.Windows.Forms.Button
    Friend WithEvents btnguardar As System.Windows.Forms.Button
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
