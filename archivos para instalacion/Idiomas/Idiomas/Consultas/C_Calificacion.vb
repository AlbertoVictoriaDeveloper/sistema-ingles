Public Class C_Calificacion
    Private Sub Actualizar()

        DataGridView1.DataSource = Nothing
        DataGridView1.Rows.Clear()
        DataGridView1.Columns.Clear()


        SSEL = ("SELECT * FROM V_Calificaciones")
        MostrarDatos()

        DataGridView1.DataSource = DT


    End Sub
    Private Sub C_Calificacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Actualizar()
    End Sub

    Private Sub DataGridView1_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        Reinscripcion.txtcontrol.Text = DataGridView1.SelectedCells.Item(0).Value

        Reinscripcion.txtnombre.Text = DataGridView1.SelectedCells.Item(1).Value
        Reinscripcion.cbonivel.Text = DataGridView1.SelectedCells.Item(3).Value
        Reinscripcion.ComboBox1.Text = DataGridView1.SelectedCells.Item(3).Value
        Reinscripcion.txtcalificacion.Text = DataGridView1.SelectedCells.Item(4).Value
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
        If txtgrupo.Text <> "" Then
            If con = 0 Then
                sel = ("where grupo like '%" & txtgrupo.Text & "%'")
                con = 1
            Else
                sel = sel & ("and grupo like '%" & txtgrupo.Text & "%'")
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

        DataGridView1.DataSource = Nothing
        DataGridView1.Rows.Clear()
        DataGridView1.Columns.Clear()


        SSEL = "Select  * from v_calificaciones " & sel
        MostrarDatos()

        DataGridView1.DataSource = DT
    End Sub

    Private Sub btnsalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsalir.Click
        Me.Close()
    End Sub
End Class