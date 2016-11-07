Public Class Acceso

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Verificacion()
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub Acceso_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Verificacion()

        Valores.Password = Me.PasswordTextBox.Text
        Valores.Usuario = Me.UsernameTextBox.Text


        Dim Buscar As Busqueda = New Busqueda
        Buscar.BAcceso("1", "PM_Con")
        If vEOF = False Then
            If Me.PasswordTextBox.Text = "" Then
                Dim VRES As String = InputBox("GENERA UNA NUEVA CONTRASEÑA", "ADMINISTRADOR", 1)
                SSEL = "UPDATE Usuario SET password='" & VRES & "' WHERE ID_USUARIO='" & Buscar.IDUSU & "' "
                MostrarDatos()
                MsgBox("CONTRASEÑA AGREGADA CORRECTAMENTE")
            Else
          


                Dim menu As Inicio = New Inicio
                menu.Show()

                Me.Hide()

            End If
        Else

            MsgBox("EL USUARIO O LA CONTRASEÑA NO SON CORRECTOS", MsgBoxStyle.Critical)
        End If
    End Sub
End Class
