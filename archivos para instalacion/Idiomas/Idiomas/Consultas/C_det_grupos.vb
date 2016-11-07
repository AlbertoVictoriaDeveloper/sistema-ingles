Public Class C_det_grupos


    Private Sub Actualizar()

        DataGridView1.DataSource = Nothing
        DataGridView1.Rows.Clear()
        DataGridView1.Columns.Clear()

        SSEL = ("  select * from Usuario inner join Profesor on Usuario.id_clave=Profesor.id_clave where NOM_USU= '" & Usuario & "'and password='" & Password & "'")
        MostrarDatos()
        If vEOF = False Then
            Dim Dr As DataRow = DT.Rows(0)
            tipo_usu = Dr("tipo_usuario")
        End If

        If tipo_usu = "ADMINISTRADOR " Then
            SSEL = ("SELECT * FROM V_Grupos")
        Else
            SSEL = ("SELECT * FROM V_Grupos where Profesor=" & NomUsu & "")
        End If

        MostrarDatos()

        DataGridView1.DataSource = DT

    End Sub
    Private Sub C_det_grupos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Actualizar()
    End Sub

    Private Sub DataGridView1_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick

        Select Case vPantalla

            Case "Grupo"
                Asig_Grupo.txtidgrupo.Text = DataGridView1.SelectedCells.Item(0).Value
                Asig_Grupo.txtgrupo.Text = DataGridView1.SelectedCells.Item(1).Value
            Case "Horario"
                Horarios.txtid.Text = DataGridView1.SelectedCells.Item(0).Value
                Horarios.txtgrupo.Text = DataGridView1.SelectedCells.Item(1).Value
                Horarios.GroupBox2.Enabled = True
       
        End Select
       
        Me.Close()
    End Sub

    Private Sub btnbuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbuscar.Click
        Dim con As Integer
        Dim sel As String
        con = 0
        If txtgrupo.Text <> "" Then
            If con = 0 Then
                sel = ("where nombre like '%" & txtgrupo.Text & "%'")
                con = 1
            Else
                sel = sel & ("and nombre like '%" & txtgrupo.Text & "%'")
            End If
        End If

        If txtturno.Text <> "" Then
            If con = 0 Then
                sel = ("where turno like '%" & txtturno.Text & "%'")
                con = 1
            Else
                sel = sel & ("and turno like '%" & txtturno.Text & "%'")
            End If
        End If
        If txtnivel.Text <> "" Then
            If con = 0 Then
                sel = ("where nivel like '%" & txtnivel.Text & "%'")
                con = 1
            Else
                sel = sel & ("and nivel like '%" & txtnivel.Text & "%'")
            End If
        End If

        If txtperiodo.Text <> "" Then
            If con = 0 Then
                sel = ("where periodo like '%" & txtperiodo.Text & "%'")
                con = 1
            Else
                sel = sel & ("and periodo like '%" & txtperiodo.Text & "%'")
            End If
        End If
        If txtprofesor.Text <> "" Then
            If con = 0 Then
                sel = ("where profesor like '%" & txtprofesor.Text & "%'")
                con = 1
            Else
                sel = sel & ("and profesor like '%" & txtprofesor.Text & "%'")
            End If
        End If
        DataGridView1.DataSource = Nothing
        DataGridView1.Rows.Clear()
        DataGridView1.Columns.Clear()


        SSEL = "Select * from V_grupos " & sel
        MostrarDatos()

        DataGridView1.DataSource = DT
    End Sub
End Class