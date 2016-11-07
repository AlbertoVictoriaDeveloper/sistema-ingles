Public Class Inicio

    Public TIPUSU As Integer
    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        End
    End Sub

    Private Sub AlumnoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AlumnoToolStripMenuItem.Click
        C_alumnos.MdiParent = Me
        C_alumnos.Show()
    End Sub

    Private Sub Inicio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        SSEL = ("  select * from Usuario inner join Profesor on Usuario.id_clave=Profesor.id_clave where NOM_USU= '" & Usuario & "'and password='" & Password & "'")
        MostrarDatos()
        If vEOF = False Then
            Dim Dr As DataRow = DT.Rows(0)
            Me.TIPUSU = Dr("id_usuario").ToString
            tipo_usu = Dr("tipo_usuario")
        End If

        If tipo_usu <> "ADMINISTRADOR " Then
            AltasToolStripMenuItem.Visible = False
            GruposToolStripMenuItem.Visible = False
            AsignacionesToolStripMenuItem.Visible = False
            ReinscripcionesToolStripMenuItem.Visible = False
            ReportesToolStripMenuItem.Visible = False
            C_ProfesoresToolStripMenuItem1.Visible = False
            AlumnoToolStripMenuItem.Visible = False
            GrupoToolStripMenuItem.Visible = False
            GruposAsignadosToolStripMenuItem1.Visible = True
        End If
        ToolStripStatusLabel.Text = NomUsu
    End Sub

    Private Sub CalificacionesToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CalificacionesToolStripMenuItem1.Click
        Calificaciones.MdiParent = Me
        Calificaciones.Show()
    End Sub


    Private Sub GruposToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Grupos.MdiParent = Me
        Grupos.Show()
    End Sub

    Private Sub ProfesoresToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProfesoresToolStripMenuItem.Click
        Profesores.MdiParent = Me
        Profesores.Show()
    End Sub

    Private Sub UsuariosToolStripMenuItem1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UsuariosToolStripMenuItem1.Click
        Usuarios.MdiParent = Me
        Usuarios.Show()
    End Sub

    Private Sub C_ProfesoresToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C_ProfesoresToolStripMenuItem1.Click
        C_profesores.MdiParent = Me
        C_profesores.Show()
    End Sub

    Private Sub ProfesorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProfesorToolStripMenuItem.Click
        Asig_Grupo.MdiParent = Me
        Asig_Grupo.Show()
    End Sub

    Private Sub HorariosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HorariosToolStripMenuItem.Click
        Horarios.MdiParent = Me
        Horarios.Show()
    End Sub

    Private Sub InscripcionesToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InscripcionesToolStripMenuItem.Click
        Registros.MdiParent = Me
        Registros.Show()
    End Sub

    Private Sub ReinscripcionesToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReinscripcionesToolStripMenuItem.Click
        Reinscripcion.MdiParent = Me
        Reinscripcion.Show()
    End Sub

    Private Sub GruposToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GruposToolStripMenuItem.Click
        Grupos.MdiParent = Me
        Grupos.Show()
    End Sub

    Private Sub CalificacionesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CalificacionesToolStripMenuItem.Click
        C_Calificacion.MdiParent = Me
        C_Calificacion.Show()
    End Sub

    Private Sub HorariosToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HorariosToolStripMenuItem1.Click
        V_Horarios.MdiParent = Me
        V_Horarios.Show()
    End Sub

    Private Sub HistorialToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HistorialToolStripMenuItem.Click
        V_Historial.MdiParent = Me
        V_Historial.Show()
    End Sub

    Private Sub CalificacionesToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CalificacionesToolStripMenuItem2.Click
        vPantalla = "Inicio_calificacion"
        V_Calificacion.MdiParent = Me
        V_Calificacion.Show()
    End Sub

    Private Sub GrupoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GrupoToolStripMenuItem.Click
        C_det_grupos.MdiParent = Me
        C_det_grupos.Show()
    End Sub

    Private Sub GruposAsignadosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GruposAsignadosToolStripMenuItem.Click
        V_asignado.MdiParent = Me
        V_asignado.Show()
    End Sub

    Private Sub GruposAsignadosToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GruposAsignadosToolStripMenuItem1.Click
        C_Asignado.MdiParent = Me
        C_Asignado.Show()
    End Sub

    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CascadeToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.Cascade)

    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TileVerticalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileVertical)

    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TileHorizontalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)

    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseAllToolStripMenuItem.Click
        ' Cierre todos los formularios secundarios del principal.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub
End Class
