<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class C_det_grupos
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
        Me.btnsalir = New System.Windows.Forms.Button()
        Me.btnbuscar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtprofesor = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtnivel = New System.Windows.Forms.TextBox()
        Me.txtperiodo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtturno = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtgrupo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnsalir
        '
        Me.btnsalir.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnsalir.Image = Global.Idiomas.My.Resources.Resources.cancel
        Me.btnsalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnsalir.Location = New System.Drawing.Point(646, 49)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(63, 39)
        Me.btnsalir.TabIndex = 49
        Me.btnsalir.Text = "Salir"
        Me.btnsalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnsalir.UseVisualStyleBackColor = False
        '
        'btnbuscar
        '
        Me.btnbuscar.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnbuscar.Image = Global.Idiomas.My.Resources.Resources.filefind
        Me.btnbuscar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnbuscar.Location = New System.Drawing.Point(565, 49)
        Me.btnbuscar.Name = "btnbuscar"
        Me.btnbuscar.Size = New System.Drawing.Size(63, 39)
        Me.btnbuscar.TabIndex = 48
        Me.btnbuscar.Text = "Buscar"
        Me.btnbuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnbuscar.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtprofesor)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtnivel)
        Me.GroupBox1.Controls.Add(Me.txtperiodo)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtturno)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtgrupo)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(542, 103)
        Me.GroupBox1.TabIndex = 47
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Busqueda "
        '
        'txtprofesor
        '
        Me.txtprofesor.Location = New System.Drawing.Point(229, 60)
        Me.txtprofesor.Name = "txtprofesor"
        Me.txtprofesor.Size = New System.Drawing.Size(307, 20)
        Me.txtprofesor.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(177, 63)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Profesor"
        '
        'txtnivel
        '
        Me.txtnivel.Location = New System.Drawing.Point(413, 34)
        Me.txtnivel.Name = "txtnivel"
        Me.txtnivel.Size = New System.Drawing.Size(123, 20)
        Me.txtnivel.TabIndex = 10
        '
        'txtperiodo
        '
        Me.txtperiodo.Location = New System.Drawing.Point(48, 60)
        Me.txtperiodo.Name = "txtperiodo"
        Me.txtperiodo.Size = New System.Drawing.Size(123, 20)
        Me.txtperiodo.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 63)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Periodo"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(371, 37)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Nivel"
        '
        'txtturno
        '
        Me.txtturno.Location = New System.Drawing.Point(218, 34)
        Me.txtturno.Name = "txtturno"
        Me.txtturno.Size = New System.Drawing.Size(144, 20)
        Me.txtturno.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(177, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Turno"
        '
        'txtgrupo
        '
        Me.txtgrupo.Location = New System.Drawing.Point(48, 34)
        Me.txtgrupo.Name = "txtgrupo"
        Me.txtgrupo.Size = New System.Drawing.Size(123, 20)
        Me.txtgrupo.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Grupo"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 136)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(760, 306)
        Me.DataGridView1.TabIndex = 46
        '
        'C_det_grupos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 454)
        Me.Controls.Add(Me.btnsalir)
        Me.Controls.Add(Me.btnbuscar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "C_det_grupos"
        Me.Text = "Grupos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnsalir As System.Windows.Forms.Button
    Friend WithEvents btnbuscar As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtturno As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtgrupo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents txtprofesor As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtnivel As System.Windows.Forms.TextBox
    Friend WithEvents txtperiodo As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
