﻿Public Class frmListadoPrecios

    Private Sub frmListadoPrecios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'db_sistemaDataSet.Precios' Puede moverla o quitarla según sea necesario.
        Me.PreciosTableAdapter.FillPrecios(Me.db_sistemaDataSet.Precios)

        Me.ReportViewer1.RefreshReport()

    End Sub

    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) Handles ReportViewer1.Load

    End Sub
End Class