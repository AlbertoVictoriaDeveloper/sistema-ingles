<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Registros
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
        Me.cboperiodo = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cboturca = New System.Windows.Forms.ComboBox()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cbocarrera = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtgrupoca = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cboalumno = New System.Windows.Forms.ComboBox()
        Me.cbosexo = New System.Windows.Forms.ComboBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.txtcontrol = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.NuevoToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.btnsalir = New System.Windows.Forms.Button()
        Me.btndeshacer = New System.Windows.Forms.Button()
        Me.btnguardar = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnmodificar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cboperiodo)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.cboturca)
        Me.GroupBox1.Controls.Add(Me.txtnombre)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.cbocarrera)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtgrupoca)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.cboalumno)
        Me.GroupBox1.Controls.Add(Me.cbosexo)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.txtcontrol)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Enabled = False
        Me.GroupBox1.Location = New System.Drawing.Point(12, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(571, 181)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Alta de Alumnos"
        '
        'cboperiodo
        '
        Me.cboperiodo.FormattingEnabled = True
        Me.cboperiodo.Location = New System.Drawing.Point(391, 121)
        Me.cboperiodo.Name = "cboperiodo"
        Me.cboperiodo.Size = New System.Drawing.Size(174, 21)
        Me.cboperiodo.TabIndex = 24
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(274, 124)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 13)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Periodo de inscripción"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Matutitno", "Vespertino"})
        Me.ComboBox1.Location = New System.Drawing.Point(43, 148)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(227, 21)
        Me.ComboBox1.TabIndex = 22
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 151)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(31, 13)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "Nivel"
        '
        'cboturca
        '
        Me.cboturca.FormattingEnabled = True
        Me.cboturca.Items.AddRange(New Object() {"MATUTINO", "VESPERTINO"})
        Me.cboturca.Location = New System.Drawing.Point(84, 121)
        Me.cboturca.Name = "cboturca"
        Me.cboturca.Size = New System.Drawing.Size(186, 21)
        Me.cboturca.TabIndex = 11
        '
        'txtnombre
        '
        Me.txtnombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtnombre.Location = New System.Drawing.Point(111, 44)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(454, 20)
        Me.txtnombre.TabIndex = 5
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 47)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(99, 13)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "Nombre del Alumno"
        '
        'cbocarrera
        '
        Me.cbocarrera.FormattingEnabled = True
        Me.cbocarrera.Items.AddRange(New Object() {"ING. INDUSTRIAL", "ING. SISTEMAS COMP", "ING. INFORMATICA", "CONTABILIDAD", "GESTION EMPRESARIAL", "ING. LOGISTICA", "ING. EN TICS", "ING. ELECTRONICA"})
        Me.cbocarrera.Location = New System.Drawing.Point(53, 96)
        Me.cbocarrera.Name = "cbocarrera"
        Me.cbocarrera.Size = New System.Drawing.Size(288, 21)
        Me.cbocarrera.TabIndex = 9
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 124)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 13)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Turno Carrera"
        '
        'txtgrupoca
        '
        Me.txtgrupoca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtgrupoca.Location = New System.Drawing.Point(433, 95)
        Me.txtgrupoca.Name = "txtgrupoca"
        Me.txtgrupoca.Size = New System.Drawing.Size(132, 20)
        Me.txtgrupoca.TabIndex = 10
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(354, 98)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(73, 13)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Grupo Carrera"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 98)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(41, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Carrera"
        '
        'cboalumno
        '
        Me.cboalumno.FormattingEnabled = True
        Me.cboalumno.Items.AddRange(New Object() {"INTERNO", "EXTERNO"})
        Me.cboalumno.Location = New System.Drawing.Point(433, 70)
        Me.cboalumno.Name = "cboalumno"
        Me.cboalumno.Size = New System.Drawing.Size(132, 21)
        Me.cboalumno.TabIndex = 8
        '
        'cbosexo
        '
        Me.cbosexo.FormattingEnabled = True
        Me.cbosexo.Items.AddRange(New Object() {"MASCULINO", "FEMENINO"})
        Me.cbosexo.Location = New System.Drawing.Point(213, 70)
        Me.cbosexo.Name = "cbosexo"
        Me.cbosexo.Size = New System.Drawing.Size(128, 21)
        Me.cbosexo.TabIndex = 7
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(67, 70)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(104, 20)
        Me.DateTimePicker1.TabIndex = 6
        '
        'txtcontrol
        '
        Me.txtcontrol.Location = New System.Drawing.Point(67, 19)
        Me.txtcontrol.Name = "txtcontrol"
        Me.txtcontrol.Size = New System.Drawing.Size(104, 20)
        Me.txtcontrol.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(347, 73)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Tipo de alumno"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(177, 73)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Sexo"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 73)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Fecha Nac"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nº Control"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoToolStripButton, Me.ToolStripButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(595, 25)
        Me.ToolStrip1.TabIndex = 2
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'NuevoToolStripButton
        '
        Me.NuevoToolStripButton.Image = Global.Idiomas.My.Resources.Resources.filenew
        Me.NuevoToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.NuevoToolStripButton.Name = "NuevoToolStripButton"
        Me.NuevoToolStripButton.Size = New System.Drawing.Size(108, 22)
        Me.NuevoToolStripButton.Text = "Nuevo Registro"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Image = Global.Idiomas.My.Resources.Resources.filefind
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(62, 22)
        Me.ToolStripButton1.Text = "Buscar"
        '
        'btnsalir
        '
        Me.btnsalir.Image = Global.Idiomas.My.Resources.Resources.cancel
        Me.btnsalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnsalir.Location = New System.Drawing.Point(248, 9)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(75, 39)
        Me.btnsalir.TabIndex = 31
        Me.btnsalir.Text = "Salir"
        Me.btnsalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnsalir.UseVisualStyleBackColor = True
        '
        'btndeshacer
        '
        Me.btndeshacer.Image = Global.Idiomas.My.Resources.Resources.redo
        Me.btndeshacer.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btndeshacer.Location = New System.Drawing.Point(168, 9)
        Me.btndeshacer.Name = "btndeshacer"
        Me.btndeshacer.Size = New System.Drawing.Size(75, 39)
        Me.btndeshacer.TabIndex = 30
        Me.btndeshacer.Text = "Deshacer"
        Me.btndeshacer.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btndeshacer.UseVisualStyleBackColor = True
        '
        'btnguardar
        '
        Me.btnguardar.Image = Global.Idiomas.My.Resources.Resources.filesave
        Me.btnguardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnguardar.Location = New System.Drawing.Point(6, 9)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(75, 39)
        Me.btnguardar.TabIndex = 29
        Me.btnguardar.Text = "Guardar "
        Me.btnguardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnguardar.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnmodificar)
        Me.GroupBox2.Controls.Add(Me.btnguardar)
        Me.GroupBox2.Controls.Add(Me.btnsalir)
        Me.GroupBox2.Controls.Add(Me.btndeshacer)
        Me.GroupBox2.Location = New System.Drawing.Point(247, 214)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(336, 54)
        Me.GroupBox2.TabIndex = 32
        Me.GroupBox2.TabStop = False
        '
        'btnmodificar
        '
        Me.btnmodificar.Image = Global.Idiomas.My.Resources.Resources.edit1
        Me.btnmodificar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnmodificar.Location = New System.Drawing.Point(87, 9)
        Me.btnmodificar.Name = "btnmodificar"
        Me.btnmodificar.Size = New System.Drawing.Size(75, 39)
        Me.btnmodificar.TabIndex = 32
        Me.btnmodificar.Text = "Modificar"
        Me.btnmodificar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnmodificar.UseVisualStyleBackColor = True
        '
        'Registros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(595, 280)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Registros"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Inscripcion"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtgrupoca As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cboalumno As System.Windows.Forms.ComboBox
    Friend WithEvents cbosexo As System.Windows.Forms.ComboBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtcontrol As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cboturca As System.Windows.Forms.ComboBox
    Friend WithEvents txtnombre As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cbocarrera As System.Windows.Forms.ComboBox
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents NuevoToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents btnsalir As System.Windows.Forms.Button
    Friend WithEvents btndeshacer As System.Windows.Forms.Button
    Friend WithEvents btnguardar As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnmodificar As System.Windows.Forms.Button
    Friend WithEvents cboperiodo As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
