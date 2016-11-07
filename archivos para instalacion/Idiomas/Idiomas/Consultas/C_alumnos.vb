Public Class C_alumnos
    Private Sub Actualizar()

        DataGridView1.DataSource = Nothing
        DataGridView1.Rows.Clear()
        DataGridView1.Columns.Clear()


        SSEL = ("SELECT * FROM V_ALUMNO")
        MostrarDatos()

        DataGridView1.DataSource = DT

    End Sub

    Private Sub C_alumnos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Actualizar()
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView1_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick

        Select Case vPantalla
            Case "Asignacion"
                Asig_Grupo.txtcontrol.Text = DataGridView1.SelectedCells.Item(0).Value
                Asig_Grupo.txtnombre.Text = DataGridView1.SelectedCells.Item(1).Value

            Case "Reinscripcion"

                Reinscripcion.txtcontrol.Text = DataGridView1.SelectedCells.Item(0).Value
                Reinscripcion.txtnombre.Text = DataGridView1.SelectedCells.Item(1).Value
                Reinscripcion.cbonivel.Text = DataGridView1.SelectedCells.Item(11).Value

            Case "Alumnos"
                Registros.txtcontrol.Text = DataGridView1.SelectedCells.Item(0).Value
                Registros.txtnombre.Text = DataGridView1.SelectedCells.Item(1).Value
                Registros.DateTimePicker1.Text = DataGridView1.SelectedCells.Item(2).Value
                Registros.cbosexo.Text = DataGridView1.SelectedCells.Item(3).Value
                Registros.cboalumno.Text = DataGridView1.SelectedCells.Item(4).Value
                Registros.cbocarrera.Text = DataGridView1.SelectedCells.Item(5).Value
                Registros.txtgrupoca.Text = DataGridView1.SelectedCells.Item(6).Value
                Registros.cboturca.Text = DataGridView1.SelectedCells.Item(7).Value

        End Select

        
       
        Me.Close()

    End Sub

    Private Sub btnbuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbuscar.Click
        Dim con As Integer
        Dim sel As String
        con = 0
        If txtcontrol.Text <> "" Then
            If con = 0 Then
                sel = ("where no_control like '%" & txtcontrol.Text & "%'")
                con = 1
            Else
                sel = sel & ("and no_control like '%" & txtcontrol.Text & "%'")
            End If
        End If

        If txtnombre.Text <> "" Then
            If con = 0 Then
                sel = ("where nombre like '%" & txtnombre.Text & "%'")
                con = 1
            Else
                sel = sel & ("and nombre like '%" & txtnombre.Text & "%'")
            End If
        End If
        If txtcarrera.Text <> "" Then
            If con = 0 Then
                sel = ("where carrera like '%" & txtcarrera.Text & "%'")
                con = 1
            Else
                sel = sel & ("and carrera like '%" & txtcarrera.Text & "%'")
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
        If TextBox1.Text <> "" Then
            If con = 0 Then
                sel = ("where tipo_alumno like '%" & TextBox1.Text & "%'")
                con = 1
            Else
                sel = sel & ("and tipo_alumno like '%" & TextBox1.Text & "%'")
            End If
        End If

        DataGridView1.DataSource = Nothing
        DataGridView1.Rows.Clear()
        DataGridView1.Columns.Clear()


        SSEL = "Select * from V_Alumno " & sel
        MostrarDatos()

        DataGridView1.DataSource = DT
    End Sub

    Private Sub btnsalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsalir.Click
        Me.Close()
    End Sub
End Class