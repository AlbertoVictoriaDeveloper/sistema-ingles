Public Class C_profesores

    Private Sub limpiar()
        txtclave.Text = ""
        txtnombre.Text = ""
    End Sub
    Private Sub Actualizar()

        DataGridView1.DataSource = Nothing
        DataGridView1.Rows.Clear()
        DataGridView1.Columns.Clear()


        SSEL = ("SELECT id_clave, nombre FROM PROFESOR where estatus='true'")
        MostrarDatos()

        DataGridView1.DataSource = DT

    End Sub
    Private Sub C_profesoresvb_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Actualizar()
    End Sub

    Private Sub DataGridView1_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        Select Case vPantalla
            Case "usuario"
                Usuarios.txtclave.Text = DataGridView1.SelectedCells.Item(0).Value
                Usuarios.txtnombre.Text = DataGridView1.SelectedCells.Item(1).Value
            Case "Profesor"
                Profesores.txtclave.Text = DataGridView1.SelectedCells.Item(0).Value
                Profesores.txtnombre.Text = DataGridView1.SelectedCells.Item(1).Value
        End Select
        Me.Close()

    End Sub


    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        limpiar()
    End Sub


    Private Sub btnbuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbuscar.Click
        Dim con As Integer
        Dim sel As String
        con = 0
        If txtclave.Text <> "" Then
            If con = 0 Then
                sel = ("where id_clave like '%" & txtclave.Text & "%'")
                con = 1
            Else
                sel = sel & ("and id_clave like '%" & txtclave.Text & "%'")
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

        DataGridView1.DataSource = Nothing
        DataGridView1.Rows.Clear()
        DataGridView1.Columns.Clear()


        SSEL = "Select  id_clave, nombre from profesor " & sel
        MostrarDatos()

        DataGridView1.DataSource = DT
    End Sub

    Private Sub btnsalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsalir.Click
        Me.Close()
    End Sub
End Class