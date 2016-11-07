Imports System.Data.SqlClient

Public Class C_Asignado

    Private Sub actualizar()

        DataGridView1.DataSource = Nothing
        DataGridView1.Rows.Clear()
        DataGridView1.Columns.Clear()

        If NomUsu = "ADMINISTRADOR" Then
            SSEL = ("SELECT * FROM V_Asignado ")
        Else
            SSEL = ("SELECT * FROM V_asignado where [Nombre Prof]='" & NomUsu & "'")
        End If

        MostrarDatos()

        DataGridView1.DataSource = DT

    End Sub


    Private Sub C_Grupos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        actualizar()
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView1_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        Select Case vPantalla
            Case "Calificacion"
                Calificaciones.ComboBox1.Text = DataGridView1.SelectedCells.Item(2).Value
                Calificaciones.txtperiodo.Text = DataGridView1.SelectedCells.Item(6).Value
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

        If txtprofesor.Text <> "" Then
            If con = 0 Then
                sel = ("where [nombre prof] like '%" & txtprofesor.Text & "%'")
                con = 1
            Else
                sel = sel & ("and [nombre prof] like '%" & txtprofesor.Text & "%'")
            End If
        End If
        If txtalumno.Text <> "" Then
            If con = 0 Then
                sel = ("where nombre like '%" & txtalumno.Text & "%'")
                con = 1
            Else
                sel = sel & ("and nombre like '%" & txtalumno.Text & "%'")
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
        If txtperiodo.Text <> "" Then
            If con = 0 Then
                sel = ("where periodo like '%" & txtperiodo.Text & "%'")
                con = 1
            Else
                sel = sel & ("and periodo like '%" & txtperiodo.Text & "%'")
            End If
        End If
        DataGridView1.DataSource = Nothing
        DataGridView1.Rows.Clear()
        DataGridView1.Columns.Clear()


        SSEL = "Select * FROM V_Asignado " & sel
        MostrarDatos()

        DataGridView1.DataSource = DT
    End Sub
End Class