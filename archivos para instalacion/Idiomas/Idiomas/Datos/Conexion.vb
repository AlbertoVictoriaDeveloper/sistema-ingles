Imports System
Imports System.Data
Imports System.Data.SqlClient


Module Conexion

    Public SSEL As String
    Public vEOF As Boolean
    Public DT As DataTable
    Public DG As DataTable
    Public DS As DataSet
    Public SCNN As String = "SERVER=10.253.39.211; DATABASE=Idiomas ; UID= cle; PWD= 12345   " ' " ' '    "
    Public Objcon As SqlConnection


    Public Sub MostrarDatos()
        Dim ObjCon As New SqlConnection(SCNN)
        ObjCon.Open()
        Dim ObjDA As New SqlDataAdapter(SSEL, ObjCon)

        DT = New DataTable
        ObjDA.Fill(DT)

        Dim EOF As Integer = DT.Rows.Count
        If EOF = 0 Then
            vEOF = True
            ObjCon.Close()
            ObjCon = Nothing
            Exit Sub
        Else
            vEOF = False
            ObjCon.Close()
            ObjCon = Nothing

        End If

    End Sub

    'DESARROLLADOR POR ALBERTO VICTORIA LOPEZ
    'OSCAR ULISES FERNANDEZ CRUZ
    'ERIANGEL BAUTISTA RAMIREZ
    'LUIS MANUEL MANRIQUEZ DOMINGUEZ
End Module
