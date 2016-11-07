Public Class Busqueda

    Public IDUSU As Integer


    Public Sub BAcceso(ByVal vMod As String, ByVal vTipo As String)
        SSEL = ("  select * from Usuario inner join Profesor on Usuario.id_clave=Profesor.id_clave where NOM_USU= '" & Usuario & "'and password='" & Password & "'")
        MostrarDatos()
        If vEOF = False Then
            Dim Dr As DataRow = DT.Rows(0)
            Me.IDUSU = Dr("id_usuario").ToString
            NomUsu = Dr("nombre")
        End If
    End Sub

    'Public Sub BCalificacion(ByVal vMod As String, ByVal vTipo As String)
    '    SSEL = ("  select * from Usuario inner join Profesor on Usuario.id_clave=Profesor.id_clave where NOM_USU= '" & Usuario & "'and password='" & Password & "'")
    '    MostrarDatos()
    '    If vEOF = False Then
    '        Dim Dr As DataRow = DT.Rows(0)
    '        Me.IDUSU = Dr("id_usuario").ToString
    '        NomUsu = Dr("nombre")
    '    End If
    'End Sub
End Class
