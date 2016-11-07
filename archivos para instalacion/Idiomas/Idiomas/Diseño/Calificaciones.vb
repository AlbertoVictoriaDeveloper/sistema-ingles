Imports System.Data.SqlClient

Public Class Calificaciones
    Dim valor As Integer
    Dim dt2 As New DataTable("Calificacion")
    Private BindingSource1 As Windows.Forms.BindingSource = New BindingSource

    Private Sub limpiar()
        txtperiodo.Text = ""
        ComboBox1.Text = ""
        DataGridView1.Enabled = False
    End Sub

    Private Sub buscar()
        SSEL = ("  select * from Usuario inner join Profesor on Usuario.id_clave=Profesor.id_clave where NOM_USU= '" & Usuario & "'and password='" & Password & "'")
        MostrarDatos()
        If vEOF = False Then
            Dim Dr As DataRow = DT.Rows(0)
            tipo_usu = Dr("tipo_usuario")
        End If

        If tipo_usu = "ADMINISTRADOR " Then
            SSEL = "SELECT * from V_Asignado "
        Else
            SSEL = "SELECT * from V_Asignado where [Nombre prof]= '" & NomUsu & "'"
        End If
        MostrarDatos()

        'Dim Dr As DataRow = DT.Rows(0)
        'Dim control, alumno, grupo, nivel, periodo, profesor As String

        'control = Dr("no_control").ToString
        'alumno = Dr("nombre").ToString
        'grupo = Dr("grupo").ToString
        'nivel = Dr("nivel").ToString
        'periodo = Dr("periodo").ToString
        'profesor = Dr("Nombre Prof").ToString


        If vEOF = False Then
            Dim Contar As Integer = DT.Rows.Count
            Dim i As Integer
            For i = 0 To Contar - 1
                'dt2.Rows.Add(control, alumno, grupo, nivel, periodo, profesor, 0)

                Dim Dr As DataRow = DT.Rows(i)
                dt2.Rows.Add(Dr(0).ToString, Dr(1).ToString, Dr(2).ToString, Dr(4).ToString, Dr(6).ToString, Dr(5).ToString, 0)



            Next

        End If

        DataGridView1.DataSource = dt2
        BindingSource1.DataSource = dt2
    End Sub

    Private Sub Calificaciones_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GroupBox2.Enabled = False
        NuevoToolStripButton.Enabled = True
        ToolStripButton1.Enabled = False
        btndeshacer.Enabled = False
        Button1.Enabled = False
        DataGridView1.Enabled = False
        Dim ObjCon As New SqlConnection(SCNN)


        SSEL = "SELECT * FROM Grupos"
        ObjCon.Open()
        Dim ObjDA2 As New SqlDataAdapter(SSEL, ObjCon)
        Dim ds2 As New DataSet
        ObjDA2.Fill(ds2, "Disk")


        With ComboBox1
            .DataSource = ds2.Tables("Disk")
            .DisplayMember = "NOMBRE"
            .ValueMember = "id_grupo"

        End With

        Dim dc1 As New DataColumn("N° Control")
        dc1.ReadOnly = True
        dt2.Columns.Add(dc1)

        Dim dc2 As New DataColumn("Alumno")
        dc2.ReadOnly = True
        dt2.Columns.Add(dc2)

        Dim dc3 As New DataColumn("Grupo")
        dc3.ReadOnly = True
        dt2.Columns.Add(dc3)

        Dim dc4 As New DataColumn("Nivel")
        dc4.ReadOnly = True
        dt2.Columns.Add(dc4)

        Dim dc5 As New DataColumn("Periodo")
        dc5.ReadOnly = True
        dt2.Columns.Add(dc5)

        Dim dc6 As New DataColumn("Profesor")
        dc6.ReadOnly = True
        dt2.Columns.Add(dc6)

        Dim dc7 As New DataColumn("Primer_Parcial")
        dc7.DataType = System.Type.GetType("System.Decimal")
        dt2.Columns.Add(dc7)

        Dim dc8 As New DataColumn("Segundo_Parcial")
        dc8.DataType = System.Type.GetType("System.Decimal")
        dt2.Columns.Add(dc8)

        Dim dc9 As New DataColumn("Calificacion_Final")
        'dc9.ReadOnly = True
        dc9.DataType = System.Type.GetType("System.Decimal")
        dt2.Columns.Add(dc9)


        dt2.AcceptChanges()
        BindingSource1.DataSource = dt2
        BindingSource1.AllowNew = True
        DataGridView1.DataSource = Me.BindingSource1.DataSource
        DataGridView1.DataSource = Nothing

        limpiar()
    End Sub

    Private Sub NuevoToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevoToolStripButton.Click
        GroupBox2.Enabled = True
        Button1.Enabled = True
        ToolStripButton1.Enabled = True
        NuevoToolStripButton.Enabled = False
        btndeshacer.Enabled = True
        DataGridView1.Enabled = True
        buscar()

        'Dim btn As New DataGridViewButtonColumn()

        'DataGridView1.Columns.Add(btn)

        'btn.HeaderText = "      "

        'btn.Name = "btn"

        'btn.UseColumnTextForButtonValue = True

    End Sub

    Private Sub SalirToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub btnsalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub btndeshacer_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndeshacer.Click
        limpiar()
        GroupBox2.Enabled = False
        NuevoToolStripButton.Enabled = True
        ToolStripButton1.Enabled = False
        DataGridView1.Enabled = False
        'Me.DataGridView1.DataSource = ""
    End Sub

    Private Sub btnsalir_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsalir.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim ObjCon As New SqlConnection(SCNN)
        ObjCon.Open()
        Dim ssql As String = "insert into calificacion values (@no_control, @id_grupo, @calificacion, @parcial1, @parcial2)"
        Dim ObjCom As New SqlCommand(ssql, ObjCon)
        Dim fila As DataGridViewRow = New DataGridViewRow()

        Try
            For Each fila In DataGridView1.Rows
                ObjCom.Parameters.Clear()

                ObjCom.Parameters.AddWithValue("@no_control", Convert.ToString(fila.Cells("N° Control").Value))
                ObjCom.Parameters.AddWithValue("@id_grupo", (ComboBox1.SelectedValue))
                ObjCom.Parameters.AddWithValue("@calificacion", fila.Cells("Calificacion_Final").Value)
                ObjCom.Parameters.AddWithValue("@parcial1", fila.Cells("Primer_Parcial").Value)
                ObjCom.Parameters.AddWithValue("@parcial2", fila.Cells("Segundo_Parcial").Value)

                ObjCom.ExecuteNonQuery()
            Next


            ObjCon.Close()


            MsgBox("CALIFICACIONES ASIGNADAS CORRECTAMENTE", MsgBoxStyle.Exclamation)

            limpiar()
            GroupBox2.Enabled = False

            DialogResult = Windows.Forms.DialogResult.OK

        Catch ex As Exception
            MessageBox.Show("ERROR AL GUARDAR LOS DATOS " & ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Private Sub BuscarToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BuscarToolStripButton.Click
        Dim con As Integer
        Dim sel As String
        con = 0
        If ComboBox1.Text <> "" Then
            If con = 0 Then
                sel = ("where Grupo like '%" & ComboBox1.Text & "%'")
                con = 1
            Else
                sel = sel & ("and Grupo like '%" & ComboBox1.Text & "%'")
            End If
        End If

        If txtperiodo.Text <> "" Then
            If con = 0 Then
                sel = ("where Periodo like '%" & txtperiodo.Text & "%'")
                con = 1
            Else
                sel = sel & ("and Periodo like '%" & txtperiodo.Text & "%'")
            End If
        End If

        dt2.Rows.Clear()

        If NomUsu = "ADMINISTRADOR" Then
            SSEL = "SELECT * from V_Asignado " & sel
        Else
            SSEL = "SELECT * from V_Asignado " & sel & " and [Nombre prof]= '" & NomUsu & "'"
        End If
        MostrarDatos()

        If vEOF = False Then
            Dim Contar As Integer = DT.Rows.Count
            Dim i As Integer

            For i = 0 To Contar - 1

                Dim Dr As DataRow = DT.Rows(i)
                dt2.Rows.Add(Dr(0).ToString, Dr(1).ToString, Dr(2).ToString, Dr(4).ToString, Dr(6).ToString, Dr(5).ToString, 0)
            Next

        End If

  
        DataGridView1.DataSource = dt2
        BindingSource1.DataSource = dt2

    End Sub

    Private Sub DataGridView1_CellPainting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellPaintingEventArgs) Handles DataGridView1.CellPainting
        If e.ColumnIndex >= 0 AndAlso DataGridView1.Columns(e.ColumnIndex).Name = "btn" AndAlso e.RowIndex >= 0 Then

            e.Paint(e.CellBounds, DataGridViewPaintParts.All)

            Dim celBoton As DataGridViewButtonCell = TryCast(DataGridView1.Rows(e.RowIndex).Cells("btn"), DataGridViewButtonCell)

            Dim icoAtomico As New Icon(Environment.CurrentDirectory + "\apply.ico")

            e.Graphics.DrawIcon(icoAtomico, e.CellBounds.Left + 3, e.CellBounds.Top + 3)



            DataGridView1.Rows(e.RowIndex).Height = icoAtomico.Height + 10

            DataGridView1.Columns(e.ColumnIndex).Width = icoAtomico.Width + 10

            e.Handled = True

        End If
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Try
            Dim debe As Double
            Dim haber As Double


            For Each row As DataGridViewRow In Me.DataGridView1.Rows
                debe = Convert.ToDouble(row.Cells(6).Value)
                haber = Convert.ToDouble(row.Cells(7).Value)

                Dim resultado As Double = (debe + haber) / 2
                row.Cells(8).Value = resultado
                'Exit For

            Next

            'For Each row As DataGridViewRow In Me.DataGridView1.Rows
            '    Dim resultado As Double = (debe + haber) / 2
            '    row.Cells(8).Value = resultado
            '    Exit For

            'Next
            'DataGridView1.SelectedCells.Item(8).Value = resultado

        Catch ex As Exception
            MessageBox.Show("ERROR AL GUARDAR LOS DATOS " & ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        DataGridView1.Enabled = False
    End Sub
End Class