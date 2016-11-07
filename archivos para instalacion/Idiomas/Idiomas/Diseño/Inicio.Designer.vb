<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inicio
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Inicio))
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.AltasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProfesoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsuariosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.InscripcionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GruposToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AsignacionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProfesorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HorariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistrosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CalificacionesToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReinscripcionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CalificacionesToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.HorariosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.HistorialToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GruposAsignadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AlumnoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GrupoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CalificacionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.C_ProfesoresToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.GruposAsignadosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.WindowsMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.CascadeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TileVerticalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TileHorizontalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AltasToolStripMenuItem, Me.AsignacionesToolStripMenuItem, Me.RegistrosToolStripMenuItem, Me.ReinscripcionesToolStripMenuItem, Me.ReportesToolStripMenuItem, Me.ConsultasToolStripMenuItem, Me.WindowsMenu, Me.SalirToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.MenuStrip.Size = New System.Drawing.Size(720, 24)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip"
        '
        'AltasToolStripMenuItem
        '
        Me.AltasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProfesoresToolStripMenuItem, Me.UsuariosToolStripMenuItem1, Me.InscripcionesToolStripMenuItem, Me.GruposToolStripMenuItem})
        Me.AltasToolStripMenuItem.Image = Global.Idiomas.My.Resources.Resources.newtodo
        Me.AltasToolStripMenuItem.Name = "AltasToolStripMenuItem"
        Me.AltasToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.AltasToolStripMenuItem.Text = "Altas"
        '
        'ProfesoresToolStripMenuItem
        '
        Me.ProfesoresToolStripMenuItem.Image = CType(resources.GetObject("ProfesoresToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ProfesoresToolStripMenuItem.Name = "ProfesoresToolStripMenuItem"
        Me.ProfesoresToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.ProfesoresToolStripMenuItem.Text = "Profesores"
        '
        'UsuariosToolStripMenuItem1
        '
        Me.UsuariosToolStripMenuItem1.Image = Global.Idiomas.My.Resources.Resources.kgpg_identity
        Me.UsuariosToolStripMenuItem1.Name = "UsuariosToolStripMenuItem1"
        Me.UsuariosToolStripMenuItem1.Size = New System.Drawing.Size(143, 22)
        Me.UsuariosToolStripMenuItem1.Text = "Usuarios"
        '
        'InscripcionesToolStripMenuItem
        '
        Me.InscripcionesToolStripMenuItem.Image = Global.Idiomas.My.Resources.Resources.contents
        Me.InscripcionesToolStripMenuItem.Name = "InscripcionesToolStripMenuItem"
        Me.InscripcionesToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.InscripcionesToolStripMenuItem.Text = "Inscripciones"
        '
        'GruposToolStripMenuItem
        '
        Me.GruposToolStripMenuItem.Image = Global.Idiomas.My.Resources.Resources.Clientes
        Me.GruposToolStripMenuItem.Name = "GruposToolStripMenuItem"
        Me.GruposToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.GruposToolStripMenuItem.Text = "Grupos"
        '
        'AsignacionesToolStripMenuItem
        '
        Me.AsignacionesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProfesorToolStripMenuItem, Me.HorariosToolStripMenuItem})
        Me.AsignacionesToolStripMenuItem.Image = Global.Idiomas.My.Resources.Resources.apply
        Me.AsignacionesToolStripMenuItem.Name = "AsignacionesToolStripMenuItem"
        Me.AsignacionesToolStripMenuItem.Size = New System.Drawing.Size(105, 20)
        Me.AsignacionesToolStripMenuItem.Text = "Asignaciones"
        '
        'ProfesorToolStripMenuItem
        '
        Me.ProfesorToolStripMenuItem.Image = Global.Idiomas.My.Resources.Resources.config_users
        Me.ProfesorToolStripMenuItem.Name = "ProfesorToolStripMenuItem"
        Me.ProfesorToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.ProfesorToolStripMenuItem.Text = "Grupo-Alumno"
        '
        'HorariosToolStripMenuItem
        '
        Me.HorariosToolStripMenuItem.Image = Global.Idiomas.My.Resources.Resources._5days
        Me.HorariosToolStripMenuItem.Name = "HorariosToolStripMenuItem"
        Me.HorariosToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.HorariosToolStripMenuItem.Text = "Horarios"
        '
        'RegistrosToolStripMenuItem
        '
        Me.RegistrosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CalificacionesToolStripMenuItem1})
        Me.RegistrosToolStripMenuItem.Image = Global.Idiomas.My.Resources.Resources.filenew
        Me.RegistrosToolStripMenuItem.Name = "RegistrosToolStripMenuItem"
        Me.RegistrosToolStripMenuItem.Size = New System.Drawing.Size(83, 20)
        Me.RegistrosToolStripMenuItem.Text = "Registros"
        '
        'CalificacionesToolStripMenuItem1
        '
        Me.CalificacionesToolStripMenuItem1.Image = Global.Idiomas.My.Resources.Resources.attach
        Me.CalificacionesToolStripMenuItem1.Name = "CalificacionesToolStripMenuItem1"
        Me.CalificacionesToolStripMenuItem1.Size = New System.Drawing.Size(147, 22)
        Me.CalificacionesToolStripMenuItem1.Text = "Calificaciones"
        '
        'ReinscripcionesToolStripMenuItem
        '
        Me.ReinscripcionesToolStripMenuItem.Image = Global.Idiomas.My.Resources.Resources.edit1
        Me.ReinscripcionesToolStripMenuItem.Name = "ReinscripcionesToolStripMenuItem"
        Me.ReinscripcionesToolStripMenuItem.Size = New System.Drawing.Size(117, 20)
        Me.ReinscripcionesToolStripMenuItem.Text = "Reinscripciones"
        '
        'ReportesToolStripMenuItem
        '
        Me.ReportesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CalificacionesToolStripMenuItem2, Me.HorariosToolStripMenuItem1, Me.HistorialToolStripMenuItem, Me.GruposAsignadosToolStripMenuItem})
        Me.ReportesToolStripMenuItem.Image = Global.Idiomas.My.Resources.Resources.list
        Me.ReportesToolStripMenuItem.Name = "ReportesToolStripMenuItem"
        Me.ReportesToolStripMenuItem.Size = New System.Drawing.Size(81, 20)
        Me.ReportesToolStripMenuItem.Text = "Reportes"
        '
        'CalificacionesToolStripMenuItem2
        '
        Me.CalificacionesToolStripMenuItem2.Name = "CalificacionesToolStripMenuItem2"
        Me.CalificacionesToolStripMenuItem2.Size = New System.Drawing.Size(204, 22)
        Me.CalificacionesToolStripMenuItem2.Text = "Calificaciones por Grupo"
        '
        'HorariosToolStripMenuItem1
        '
        Me.HorariosToolStripMenuItem1.Name = "HorariosToolStripMenuItem1"
        Me.HorariosToolStripMenuItem1.Size = New System.Drawing.Size(204, 22)
        Me.HorariosToolStripMenuItem1.Text = "Horarios"
        '
        'HistorialToolStripMenuItem
        '
        Me.HistorialToolStripMenuItem.Name = "HistorialToolStripMenuItem"
        Me.HistorialToolStripMenuItem.Size = New System.Drawing.Size(204, 22)
        Me.HistorialToolStripMenuItem.Text = "Historial"
        '
        'GruposAsignadosToolStripMenuItem
        '
        Me.GruposAsignadosToolStripMenuItem.Name = "GruposAsignadosToolStripMenuItem"
        Me.GruposAsignadosToolStripMenuItem.Size = New System.Drawing.Size(204, 22)
        Me.GruposAsignadosToolStripMenuItem.Text = "Grupos asignados"
        '
        'ConsultasToolStripMenuItem
        '
        Me.ConsultasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AlumnoToolStripMenuItem, Me.GrupoToolStripMenuItem, Me.CalificacionesToolStripMenuItem, Me.C_ProfesoresToolStripMenuItem1, Me.GruposAsignadosToolStripMenuItem1})
        Me.ConsultasToolStripMenuItem.Image = Global.Idiomas.My.Resources.Resources.filefind
        Me.ConsultasToolStripMenuItem.Name = "ConsultasToolStripMenuItem"
        Me.ConsultasToolStripMenuItem.Size = New System.Drawing.Size(87, 20)
        Me.ConsultasToolStripMenuItem.Text = "Consultas"
        '
        'AlumnoToolStripMenuItem
        '
        Me.AlumnoToolStripMenuItem.Name = "AlumnoToolStripMenuItem"
        Me.AlumnoToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.AlumnoToolStripMenuItem.Text = "Alumnos"
        '
        'GrupoToolStripMenuItem
        '
        Me.GrupoToolStripMenuItem.Name = "GrupoToolStripMenuItem"
        Me.GrupoToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.GrupoToolStripMenuItem.Text = "Grupos"
        '
        'CalificacionesToolStripMenuItem
        '
        Me.CalificacionesToolStripMenuItem.Name = "CalificacionesToolStripMenuItem"
        Me.CalificacionesToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.CalificacionesToolStripMenuItem.Text = "Calificaciones"
        '
        'C_ProfesoresToolStripMenuItem1
        '
        Me.C_ProfesoresToolStripMenuItem1.Name = "C_ProfesoresToolStripMenuItem1"
        Me.C_ProfesoresToolStripMenuItem1.Size = New System.Drawing.Size(170, 22)
        Me.C_ProfesoresToolStripMenuItem1.Text = "Profesores"
        '
        'GruposAsignadosToolStripMenuItem1
        '
        Me.GruposAsignadosToolStripMenuItem1.Name = "GruposAsignadosToolStripMenuItem1"
        Me.GruposAsignadosToolStripMenuItem1.Size = New System.Drawing.Size(170, 22)
        Me.GruposAsignadosToolStripMenuItem1.Text = "Grupos Asignados"
        '
        'WindowsMenu
        '
        Me.WindowsMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CascadeToolStripMenuItem, Me.TileVerticalToolStripMenuItem, Me.TileHorizontalToolStripMenuItem, Me.CloseAllToolStripMenuItem})
        Me.WindowsMenu.Image = Global.Idiomas.My.Resources.Resources.view_remove
        Me.WindowsMenu.Name = "WindowsMenu"
        Me.WindowsMenu.Size = New System.Drawing.Size(65, 20)
        Me.WindowsMenu.Text = "Vistas"
        '
        'CascadeToolStripMenuItem
        '
        Me.CascadeToolStripMenuItem.Name = "CascadeToolStripMenuItem"
        Me.CascadeToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.CascadeToolStripMenuItem.Text = "&Cascada"
        '
        'TileVerticalToolStripMenuItem
        '
        Me.TileVerticalToolStripMenuItem.Name = "TileVerticalToolStripMenuItem"
        Me.TileVerticalToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.TileVerticalToolStripMenuItem.Text = "Mosaico &vertical"
        '
        'TileHorizontalToolStripMenuItem
        '
        Me.TileHorizontalToolStripMenuItem.Name = "TileHorizontalToolStripMenuItem"
        Me.TileHorizontalToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.TileHorizontalToolStripMenuItem.Text = "Mosaico &horizontal"
        '
        'CloseAllToolStripMenuItem
        '
        Me.CloseAllToolStripMenuItem.Name = "CloseAllToolStripMenuItem"
        Me.CloseAllToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.CloseAllToolStripMenuItem.Text = "C&errar todo"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Image = Global.Idiomas.My.Resources.Resources.button_cancel
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 431)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.StatusStrip.Size = New System.Drawing.Size(720, 22)
        Me.StatusStrip.TabIndex = 7
        Me.StatusStrip.Text = "StatusStrip"
        '
        'ToolStripStatusLabel
        '
        Me.ToolStripStatusLabel.Name = "ToolStripStatusLabel"
        Me.ToolStripStatusLabel.Size = New System.Drawing.Size(0, 17)
        '
        'Inicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Idiomas.My.Resources.Resources.membrete_horizontal_TNM
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(720, 453)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.StatusStrip)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "Inicio"
        Me.Text = "Inicio"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents ToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents RegistrosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsultasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CalificacionesToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AlumnoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GrupoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CalificacionesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AsignacionesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProfesorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HorariosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CalificacionesToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HorariosToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents C_ProfesoresToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AltasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProfesoresToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UsuariosToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HistorialToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InscripcionesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReinscripcionesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GruposToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GruposAsignadosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GruposAsignadosToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WindowsMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CascadeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TileVerticalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TileHorizontalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseAllToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
