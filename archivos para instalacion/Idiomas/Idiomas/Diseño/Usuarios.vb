Imports System.Data.SqlClient

Public Class Usuarios

    Private Sub limpiar()
        txtclave.Text = ""
        txtnombre.Text = ""
        txtusuario.Text = ""
        ComboBox1.Text = ""
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        vPantalla = "usuario"
        Dim x As New C_profesores

        If x.ShowDialog = System.Windows.Forms.DialogResult.OK Then

        End If

    End Sub

    Private Sub Usuarios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GroupBox1.Enabled = False
        btnguardar.Enabled = False
        btndeshacer.Enabled = False
        NuevoToolStripButton.Enabled = True
    End Sub

    Private Sub NuevoToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevoToolStripButton.Click
        GroupBox1.Enabled = True
        btnguardar.Enabled = True
        NuevoToolStripButton.Enabled = False
        btndeshacer.Enabled = True
    End Sub

    Private Sub btnguardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnguardar.Click
        Dim ObjCon As New SqlConnection(SCNN)
        ObjCon.Open()
        Dim ssql As String = "insert into Usuario(nom_usu,password,id_clave,tipo_usuario) values ( '" & txtusuario.Text & "', ' ', '" & txtclave.Text & "', '" & ComboBox1.Text & "')"
        Dim ObjCom As New SqlCommand(ssql, ObjCon)

        Try
            ObjCom.ExecuteNonQuery()
            ObjCon.Close()


            MsgBox("USUARIO AGREGADO CORRECTAMENTE", MsgBoxStyle.Exclamation)

            limpiar()
            GroupBox1.Enabled = False
            NuevoToolStripButton.Enabled = True
            btnguardar.Enabled = False
            btndeshacer.Enabled = False

            DialogResult = Windows.Forms.DialogResult.OK

        Catch ex As Exception
            MessageBox.Show("ERROR AL GUARDAR LOS DATOS " & ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Private Sub btndeshacer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndeshacer.Click
        GroupBox1.Enabled = False
        NuevoToolStripButton.Enabled = True
        btnguardar.Enabled = False
        btndeshacer.Enabled = False
        limpiar()
    End Sub

    Private Sub btnsalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsalir.Click
        Me.Close()
    End Sub
End Class