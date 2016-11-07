Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.Shared
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.CrystalReports
Imports CrystalDecisions.Windows
Imports CrystalDecisions.Windows.Forms
Imports System.Windows.Forms
Public Class V_asignado

    Private Sub V_asignado_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Me.CrystalReportViewer1.SelectionFormula = " {V_Asignado.Grupo} = " & vr_NControl & " and {H_ORDENCOMPRA.IDPLANTA} = '" & vPlanta & "' AND {H_ORDENCOMPRA.PREFIJO}='" & vPrefijo & "'"
        Me.CrystalReportViewer1.Refresh()
    End Sub
End Class