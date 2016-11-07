Imports System.Data.SqlClient

Public Class Horarios

    Private Sub limpiar()
        txtid.Text = ""
        txtgrupo.Text = ""
        txtsalon.Text = ""
        DataGridView1.Rows.Clear()
    End Sub


    Private Sub btnbuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbuscar.Click
        vPantalla = "Horario"
        Dim x As New C_det_grupos

        If x.ShowDialog = System.Windows.Forms.DialogResult.OK Then

        End If
    End Sub

    Private Sub Horarios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GroupBox1.Enabled = False
        GroupBox2.Enabled = False

    End Sub

    Private Sub NuevoToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevoToolStripButton.Click
        GroupBox1.Enabled = True
    End Sub

    Private Sub btnguardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnguardar.Click
        Dim ObjCon As New SqlConnection(SCNN)
        ObjCon.Open()
        Dim ssql As String = "insert into det_grupos values (@id_grupo, @salon, @dia, @hora_entrada, @hora_salida)  "
        Dim ObjCom As New SqlCommand(ssql, ObjCon)
        Dim fila As DataGridViewRow = New DataGridViewRow()

        Try
            For Each fila In DataGridView1.Rows
                ObjCom.Parameters.Clear()

                ObjCom.Parameters.AddWithValue("@id_grupo", Convert.ToString(fila.Cells("Column1").Value))
                ObjCom.Parameters.AddWithValue("@salon", Convert.ToString(fila.Cells("Column2").Value))
                ObjCom.Parameters.AddWithValue("@dia", Convert.ToString(fila.Cells("Column3").Value))
                ObjCom.Parameters.AddWithValue("@hora_entrada", Convert.ToString(fila.Cells("Column4").Value))
                ObjCom.Parameters.AddWithValue("@hora_salida", Convert.ToString(fila.Cells("Column5").Value))

                ObjCom.ExecuteNonQuery()
            Next


            ObjCon.Close()


            MsgBox("HORARIO CREADO CORRECTAMENTE", MsgBoxStyle.Exclamation)

            limpiar()
            GroupBox1.Enabled = False
            GroupBox2.Enabled = False

            DialogResult = Windows.Forms.DialogResult.OK

        Catch ex As Exception
            MessageBox.Show("ERROR AL GUARDAR LOS DATOS " & ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        V_Horarios.Show()
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        DataGridView1.Rows.Add(txtid.Text, txtsalon.Text, cbodia.Text, DateTimePicker1.Text, DateTimePicker2.Text)
    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click
        limpiar()
    End Sub

    Private Sub btndeshacer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndeshacer.Click
        GroupBox1.Enabled = False
        GroupBox2.Enabled = False
        limpiar()
    End Sub
End Class