Imports System.Data.SqlClient

Public Class Profesores

    Private Sub limpiar()
        txtclave.Text = ""
        txtnombre.Text = ""

    End Sub

    Private Sub Profesores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GroupBox1.Enabled = False
        NuevoToolStripButton.Enabled = True
        btnguardar.Enabled = False
        btndeshacer.Enabled = False
        ToolStripButton1.Enabled = False
    End Sub

    Private Sub NuevoToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevoToolStripButton.Click
        GroupBox1.Enabled = True
        NuevoToolStripButton.Enabled = False
        btnguardar.Enabled = True
        btndeshacer.Enabled = True
        ToolStripButton1.Enabled = True
    End Sub



    Private Sub btnguardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnguardar.Click
        Dim ObjCon As New SqlConnection(SCNN)
        ObjCon.Open()
        Dim ssql As String = "insert into Profesor (id_clave, nombre,estatus) values (" & txtclave.Text & ",  '" & txtnombre.Text & "',  '" & CheckBox1.Checked & "' )"
        Dim ObjCom As New SqlCommand(ssql, ObjCon)

        Try
            ObjCom.ExecuteNonQuery()
            ObjCon.Close()


            MsgBox("PROFESOR AGREGADO CORRECTAMENTE", MsgBoxStyle.Information)

            limpiar()
            GroupBox1.Enabled = False
            NuevoToolStripButton.Enabled = True
            btnguardar.Enabled = False
            btndeshacer.Enabled = False
            DialogResult = Windows.Forms.DialogResult.OK

        Catch ex As Exception
            MessageBox.Show("ERROR AL GUARDAR LOS DATOS " & ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
        GroupBox1.Enabled = False
        NuevoToolStripButton.Enabled = True
        btnguardar.Enabled = False
        btndeshacer.Enabled = False
        ToolStripButton1.Enabled = False
    End Sub

    Private Sub btndeshacer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndeshacer.Click
        GroupBox1.Enabled = False
        NuevoToolStripButton.Enabled = True
        btnguardar.Enabled = False
        btndeshacer.Enabled = False
        ToolStripButton1.Enabled = False
        limpiar()
    End Sub

    Private Sub btnsalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsalir.Click
        Me.Close()
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        vPantalla = "Profesor"
        Dim x As New C_profesores

        If x.ShowDialog = System.Windows.Forms.DialogResult.OK Then

        End If
       
        btnguardar.Enabled = False

    End Sub

    Private Sub btnmodificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmodificar.Click
        Dim ObjCon As New SqlConnection(SCNN)
        ObjCon.Open()
        Dim ssql As String = "UPDATE profesor SET id_clave=" & txtclave.Text & ", nombre='" & txtnombre.Text & "', estatus='" & CheckBox1.Checked & "'where id_clave=" & txtclave.Text & ""
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
        GroupBox1.Enabled = False
        NuevoToolStripButton.Enabled = True
        limpiar()
    End Sub
End Class