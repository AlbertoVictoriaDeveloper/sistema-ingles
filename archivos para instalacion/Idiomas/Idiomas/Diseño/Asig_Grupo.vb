Imports System.Data.SqlClient

Public Class Asig_Grupo
    Dim total As Integer
    Private Sub limpiar()
        txtcontrol.Text = ""
        txtgrupo.Text = ""
        txtidgrupo.Text = ""
        txtnombre.Text = ""
    End Sub

    Private Sub Asig_Grupo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        concluirToolStripButton1.Enabled = False
        GroupBox1.Enabled = False
        btnguardar.Enabled = False
        btndeshacer.Enabled = False
    End Sub

    Private Sub NuevoToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevoToolStripButton.Click
        concluirToolStripButton1.Enabled = True
        GroupBox1.Enabled = True
        btnguardar.Enabled = True
        btndeshacer.Enabled = True
        NuevoToolStripButton.Enabled = False
    End Sub

    Private Sub btnguardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnguardar.Click

        Dim ObjCon As New SqlConnection(SCNN)
        ObjCon.Open()

        SSEL = "select count(*) from Asignaciones where id_grupo=" & txtidgrupo.Text & ""
        MostrarDatos()
        Dim objcom0 As New SqlCommand(SSEL, ObjCon)

        Dim contadores As Integer = Convert.ToInt32(objcom0.ExecuteScalar())
        If contadores > total Then
            MsgBox("No se pueden agregar mas alumnos a este grupo", MsgBoxStyle.Information)
        Else

            Dim ssql As String = "insert into Asignaciones (id_grupo,no_control) values ('" & txtidgrupo.Text & "', '" & txtcontrol.Text & "')  "
            Dim ObjCom As New SqlCommand(ssql, ObjCon)

            SSEL = "select count(*) from Asignaciones where no_control=" & txtcontrol.Text & "  and id_grupo=" & txtidgrupo.Text & ""
            MostrarDatos()


            Dim objcom1 As New SqlCommand(SSEL, ObjCon)

            Dim contador As Integer = Convert.ToInt32(objcom1.ExecuteScalar())

            If contador > 0 Then
                MsgBox("Este alumno ya tiene asignado ese grupo", MsgBoxStyle.Exclamation)
            Else
                Try
                    ObjCom.ExecuteNonQuery()
                    ObjCon.Close()


                    MsgBox("ALUMNO ASIGNADO CORRECTAMENTE", MsgBoxStyle.Exclamation)

                    DialogResult = Windows.Forms.DialogResult.OK

                Catch ex As Exception
                    MessageBox.Show("ERROR AL GUARDAR LOS DATOS " & ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error)

                End Try
            End If
        End If
        txtcontrol.Text = ""
        txtnombre.Text = ""
    End Sub

    Private Sub btnsalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsalir.Click
        Me.Close()
    End Sub

    Private Sub btndeshacer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndeshacer.Click
        limpiar()
        GroupBox1.Enabled = False
        btnguardar.Enabled = False
        btndeshacer.Enabled = True
        NuevoToolStripButton.Enabled = True
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        vPantalla = "Grupo"
        Dim x As New C_det_grupos

        If x.ShowDialog = System.Windows.Forms.DialogResult.OK Then

        End If
        total = InputBox("Establezca el numero maximo de alumnos de este grupo")
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        vPantalla = "Asignacion"
        Dim x As New C_alumnos

        If x.ShowDialog = System.Windows.Forms.DialogResult.OK Then


        End If
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub

    Private Sub ToolStripButton1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles concluirToolStripButton1.Click
        limpiar()
        concluirToolStripButton1.Enabled = False
        GroupBox1.Enabled = False
        btnguardar.Enabled = False
        btndeshacer.Enabled = False
        NuevoToolStripButton.Enabled = True
    End Sub
End Class