<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Grupos
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
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.NuevoToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnsalir = New System.Windows.Forms.Button()
        Me.btndeshacer = New System.Windows.Forms.Button()
        Me.btnguardar = New System.Windows.Forms.Button()
        Me.cboprofesor = New System.Windows.Forms.ComboBox()
        Me.cboperiodo = New System.Windows.Forms.ComboBox()
        Me.cbonivel = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboturno = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtgrupo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoToolStripButton})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(429, 25)
        Me.ToolStrip1.TabIndex = 3
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
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnsalir)
        Me.GroupBox1.Controls.Add(Me.btndeshacer)
        Me.GroupBox1.Controls.Add(Me.btnguardar)
        Me.GroupBox1.Controls.Add(Me.cboprofesor)
        Me.GroupBox1.Controls.Add(Me.cboperiodo)
        Me.GroupBox1.Controls.Add(Me.cbonivel)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.cboturno)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtgrupo)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Enabled = False
        Me.GroupBox1.Location = New System.Drawing.Point(13, 29)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(404, 200)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Alta de Grupos"
        '
        'btnsalir
        '
        Me.btnsalir.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnsalir.Image = Global.Idiomas.My.Resources.Resources.cancel
        Me.btnsalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnsalir.Location = New System.Drawing.Point(323, 155)
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
        Me.btndeshacer.Location = New System.Drawing.Point(242, 155)
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
        Me.btnguardar.Location = New System.Drawing.Point(161, 155)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(75, 39)
        Me.btnguardar.TabIndex = 38
        Me.btnguardar.Text = "Guardar "
        Me.btnguardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnguardar.UseVisualStyleBackColor = False
        '
        'cboprofesor
        '
        Me.cboprofesor.FormattingEnabled = True
        Me.cboprofesor.Location = New System.Drawing.Point(55, 85)
        Me.cboprofesor.Name = "cboprofesor"
        Me.cboprofesor.Size = New System.Drawing.Size(343, 21)
        Me.cboprofesor.TabIndex = 11
        '
        'cboperiodo
        '
        Me.cboperiodo.FormattingEnabled = True
        Me.cboperiodo.Location = New System.Drawing.Point(252, 59)
        Me.cboperiodo.Name = "cboperiodo"
        Me.cboperiodo.Size = New System.Drawing.Size(146, 21)
        Me.cboperiodo.TabIndex = 7
        '
        'cbonivel
        '
        Me.cbonivel.FormattingEnabled = True
        Me.cbonivel.Location = New System.Drawing.Point(55, 58)
        Me.cbonivel.Name = "cbonivel"
        Me.cbonivel.Size = New System.Drawing.Size(142, 21)
        Me.cbonivel.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(203, 62)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Periodo"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 88)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Profesor"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Nivel"
        '
        'cboturno
        '
        Me.cboturno.FormattingEnabled = True
        Me.cboturno.Items.AddRange(New Object() {"MATUTINO", "VESPERTINO", "SABATINO"})
        Me.cboturno.Location = New System.Drawing.Point(222, 32)
        Me.cboturno.Name = "cboturno"
        Me.cboturno.Size = New System.Drawing.Size(176, 21)
        Me.cboturno.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(181, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Turno"
        '
        'txtgrupo
        '
        Me.txtgrupo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtgrupo.Location = New System.Drawing.Point(55, 32)
        Me.txtgrupo.Name = "txtgrupo"
        Me.txtgrupo.Size = New System.Drawing.Size(120, 20)
        Me.txtgrupo.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Grupo"
        '
        'Grupos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(429, 241)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "Grupos"
        Me.Text = "Grupos"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents NuevoToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cboturno As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtgrupo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboperiodo As System.Windows.Forms.ComboBox
    Friend WithEvents cbonivel As System.Windows.Forms.ComboBox
    Friend WithEvents cboprofesor As System.Windows.Forms.ComboBox
    Friend WithEvents btnsalir As System.Windows.Forms.Button
    Friend WithEvents btndeshacer As System.Windows.Forms.Button
    Friend WithEvents btnguardar As System.Windows.Forms.Button
End Class
