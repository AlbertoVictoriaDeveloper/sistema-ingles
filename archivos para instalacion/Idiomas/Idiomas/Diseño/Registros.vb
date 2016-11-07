Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Net
Imports System.IO

Public Class Registros

    Private Sub limpiar()
        txtcontrol.Text = ""
        txtnombre.Text = ""
        txtgrupoca.Text = ""
        cboalumno.Text = ""
        cbocarrera.Text = ""
        cbosexo.Text = ""
        cboturca.Text = ""

    End Sub

    Private Sub cboalumno_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboalumno.SelectedIndexChanged
        If cboalumno.SelectedItem = "EXTERNO" Then
            cbocarrera.Enabled = False
            txtgrupoca.Enabled = False
            cboturca.Enabled = False
        Else
            cbocarrera.Enabled = True
            txtgrupoca.Enabled = True
            cboturca.Enabled = True
        End If
    End Sub

    Private Sub NuevoToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevoToolStripButton.Click
        GroupBox1.Enabled = True
        NuevoToolStripButton.Enabled = False
        btnguardar.Enabled = True
        btndeshacer.Enabled = True
        btnmodificar.Enabled = False
        ToolStripButton1.Enabled = True
    End Sub

    Private Sub SalirToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub Registros_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GroupBox1.Enabled = False
        NuevoToolStripButton.Enabled = True
        btnguardar.Enabled = False
        btndeshacer.Enabled = False
        btnmodificar.Enabled = False
        ToolStripButton1.Enabled = False
        Dim ObjCon As New SqlConnection(SCNN)


        SSEL = "SELECT * FROM NIVEL"
        ObjCon.Open()
        Dim ObjDA2 As New SqlDataAdapter(SSEL, ObjCon)
        Dim ds2 As New DataSet
        ObjDA2.Fill(ds2, "Disk")


        With ComboBox1
            .DataSource = ds2.Tables("Disk")
            .DisplayMember = "NOMBRE"
            .ValueMember = "ID_NIVEL"
            ObjCon.Close()
        End With

        SSEL = "SELECT * FROM PERIODO"
        ObjCon.Open()
        Dim ObjDA3 As New SqlDataAdapter(SSEL, ObjCon)
        Dim ds3 As New DataSet
        ObjDA3.Fill(ds3, "Disk")


        With cboperiodo
            .DataSource = ds3.Tables("Disk")
            .DisplayMember = "PERIODO"
            .ValueMember = "ID_PERIODO"
        End With

    End Sub


    Private Sub btndeshacer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        GroupBox1.Enabled = False
        NuevoToolStripButton.Enabled = True
        btnguardar.Enabled = False
        btndeshacer.Enabled = False
        limpiar()
    End Sub

    Private Sub btnsalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub btnguardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnguardar.Click
        Dim ObjCon As New SqlConnection(SCNN)
        ObjCon.Open()
        Dim ssql As String = "insert into Alumnos (no_control,nombre,fecha_nac,sexo,tipo_alumno,carrera,gpo_carrera,turno,id_nivel,id_periodo) values (" & txtcontrol.Text & ", '" & txtnombre.Text & "',  '" & DateTimePicker1.Text & "', '" & cbosexo.Text & "', '" & cboalumno.Text & "', '" & cbocarrera.Text & "', '" & txtgrupoca.Text & "', '" & cboturca.Text & "', '" & ComboBox1.SelectedValue & "', '" & cboperiodo.SelectedValue & "')  "
        Dim ObjCom As New SqlCommand(ssql, ObjCon)

        If cboperiodo.SelectedValue = 1 Then
            MsgBox("Este Alumno correspone a la modalidad de 8 niveles", MsgBoxStyle.Information)
        ElseIf cboperiodo.SelectedValue > 2 Then
            MsgBox("Este Alumno correspone a la modalidad de 10 niveles", MsgBoxStyle.Information)
        End If

        Try
            ObjCom.ExecuteNonQuery()
            ObjCon.Close()

            

            MsgBox("EL ALUMNO FUE INSCRITO CORRECTAMENTE", MsgBoxStyle.Exclamation)

            limpiar()
            GroupBox1.Enabled = False
            NuevoToolStripButton.Enabled = True
            btnguardar.Enabled = False

            DialogResult = Windows.Forms.DialogResult.OK

        Catch ex As Exception
            MessageBox.Show("ERROR AL GUARDAR LOS DATOS " & ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
        'End If
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        vPantalla = "Alumnos"
        Dim x As New C_alumnos

        If x.ShowDialog = System.Windows.Forms.DialogResult.OK Then

        End If
        btnguardar.Enabled = False
        btnmodificar.Enabled = True
        ToolStripButton1.Enabled = False
        NuevoToolStripButton.Enabled = False
    End Sub

    Private Sub btnmodificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmodificar.Click
        Dim ObjCon As New SqlConnection(SCNN)
        ObjCon.Open()
        Dim ssql As String = "UPDATE ALUMNOS SET no_control=" & txtcontrol.Text & ",nombre='" & txtnombre.Text & "',fecha_nac= '" & DateTimePicker1.Text & "',sexo='" & cbosexo.Text & "',tipo_alumno='" & cboalumno.Text & "',carrera='" & cbocarrera.Text & "',gpo_carrera='" & txtgrupoca.Text & "',turno='" & cboturca.Text & "',id_nivel=" & ComboBox1.SelectedValue & ",id_periodo=" & cboperiodo.SelectedValue & " where no_control=" & txtcontrol.Text & "  "
        Dim ObjCom As New SqlCommand(ssql, ObjCon)

        Try
            ObjCom.ExecuteNonQuery()
            ObjCon.Close()

          


            MsgBox("DATOS CORREGIDOS CORRECTAMENTE", MsgBoxStyle.Exclamation)

            limpiar()
            GroupBox1.Enabled = False

            DialogResult = Windows.Forms.DialogResult.OK

        Catch ex As Exception
            MessageBox.Show("ERROR AL GUARDAR LOS DATOS " & ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
        limpiar()
        btnguardar.Enabled = True
        NuevoToolStripButton.Enabled = True
        GroupBox1.Enabled = False
    End Sub

    Private Sub btnsalir_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsalir.Click
        Me.Close()
    End Sub

    Private Sub btndeshacer_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndeshacer.Click
        limpiar()
    End Sub
End Class