Imports System.Data.SqlClient

Public Class Reinscripcion

    Private Sub limpiar()
        txtcontrol.Text = ""
        txtcalificacion.Text = ""
        txtnombre.Text = ""
        cbonivel.Text = ""
        ComboBox1.Text = ""
    End Sub
    Private Sub NuevoToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevoToolStripButton.Click
        GroupBox1.Enabled = True
        btnguardar.Enabled = True
        btndeshacer.Enabled = True
        NuevoToolStripButton.Enabled = False
    End Sub

    Private Sub Reinscripcion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GroupBox1.Enabled = False
        btnguardar.Enabled = False
        btndeshacer.Enabled = False
        NuevoToolStripButton.Enabled = True
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

        End With
    End Sub

    Private Sub btnbuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbuscar.Click
        Dim x As New C_Calificacion

        If x.ShowDialog = System.Windows.Forms.DialogResult.OK Then



        End If
        'If txtcalificacion.Text < 70 Then
        '    MsgBox("Este Alumno se Reinscribira al mismo nivel", MsgBoxStyle.Critical)
        'End If
    End Sub


    Private Sub btnguardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnguardar.Click
        If txtcalificacion.Text > 70 Then
            Dim ObjCon As New SqlConnection(SCNN)
            ObjCon.Open()
            Dim ssql As String = "update Alumnos set id_nivel=" & ComboBox1.SelectedValue & "   where no_control= " & txtcontrol.Text & ""
            Dim ObjCom As New SqlCommand(ssql, ObjCon)

            Try
                ObjCom.ExecuteNonQuery()
                ObjCon.Close()


                MsgBox("EL ALUMNO FUE REINSCRITO AL SIGUIENTE NIVEL", MsgBoxStyle.Exclamation)

                limpiar()
                GroupBox1.Enabled = False

                DialogResult = Windows.Forms.DialogResult.OK

            Catch ex As Exception
                MessageBox.Show("ERROR AL GUARDAR LOS DATOS " & ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End Try
        Else : MsgBox("EL ALUMNO SE VA A INSCRIBIR AL MISMO NIVEL", MsgBoxStyle.Critical)
            Dim ObjCon As New SqlConnection(SCNN)
            ObjCon.Open()
            Dim ssql As String = "update Alumnos set id_nivel=" & ComboBox1.SelectedValue & "   where no_control= " & txtcontrol.Text & ""
            Dim ObjCom As New SqlCommand(ssql, ObjCon)

            Try
                ObjCom.ExecuteNonQuery()
                ObjCon.Close()


                MsgBox("EL ALUMNO FUE REINSCRITO AL SIGUIENTE NIVEL", MsgBoxStyle.Exclamation)

                limpiar()
                GroupBox1.Enabled = False

                DialogResult = Windows.Forms.DialogResult.OK

            Catch ex As Exception
                MessageBox.Show("ERROR AL GUARDAR LOS DATOS " & ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End Try
        End If
        GroupBox1.Enabled = False
        limpiar()
        NuevoToolStripButton.Enabled = True
        btnguardar.Enabled = False
        btndeshacer.Enabled = False
    End Sub

    Private Sub btndeshacer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndeshacer.Click
        GroupBox1.Enabled = False
        limpiar()
        NuevoToolStripButton.Enabled = True
        btnguardar.Enabled = False
        btndeshacer.Enabled = False
    End Sub

    Private Sub btnsalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsalir.Click
        Me.Close()
    End Sub
End Class