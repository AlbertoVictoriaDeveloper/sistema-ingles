Imports System.Data.SqlClient

Public Class Grupos

    Private Sub limpiar()
        cboprofesor.Text = ""
        txtgrupo.Text = ""
        cbonivel.Text = ""
        cboperiodo.Text = ""
        cboturno.Text = ""
    End Sub

    Private Sub NuevoToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevoToolStripButton.Click
        GroupBox1.Enabled = True

    End Sub



    Private Sub Grupos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GroupBox1.Enabled = False

        Dim ObjCon As New SqlConnection(SCNN)
        SSEL = "SELECT * FROM NIVEL"
        ObjCon.Open()
        Dim ObjDA2 As New SqlDataAdapter(SSEL, ObjCon)
        Dim ds2 As New DataSet
        ObjDA2.Fill(ds2, "Disk")


        With cbonivel
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
            ObjCon.Close()
        End With

        SSEL = "SELECT * FROM PROFESOR where estatus='true'"
        ObjCon.Open()
        Dim ObjDA4 As New SqlDataAdapter(SSEL, ObjCon)
        Dim ds4 As New DataSet
        ObjDA4.Fill(ds4, "Disk")

        With cboprofesor
            .DataSource = ds4.Tables("Disk")
            .DisplayMember = "nombre"
            .ValueMember = "id_clave"

        End With


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim x As New C_profesores

        If x.ShowDialog = System.Windows.Forms.DialogResult.OK Then

        End If
    End Sub

    Private Sub btnguardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnguardar.Click
        Dim ObjCon As New SqlConnection(SCNN)
        ObjCon.Open()
        Dim ssql As String = "insert into Grupos (nombre,turno,id_nivel,id_clave,id_periodo) values ('" & txtgrupo.Text & "', '" & cboturno.Text & "', '" & cbonivel.SelectedValue & "', '" & cboprofesor.SelectedValue & "', '" & cboperiodo.SelectedValue & "')  "
        Dim ObjCom As New SqlCommand(ssql, ObjCon)

        Try
            ObjCom.ExecuteNonQuery()
            ObjCon.Close()


            MsgBox("GRUPO CREADO CORRECTAMENTE", MsgBoxStyle.Exclamation)




            DialogResult = Windows.Forms.DialogResult.OK

        Catch ex As Exception
            MessageBox.Show("ERROR AL GUARDAR LOS DATOS " & ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
        limpiar()
        GroupBox1.Enabled = False
        NuevoToolStripButton.Enabled = True
    End Sub

    Private Sub btndeshacer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndeshacer.Click
        limpiar()
        NuevoToolStripButton.Enabled = True
    End Sub

    Private Sub btnsalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsalir.Click
        Me.Close()
    End Sub
End Class