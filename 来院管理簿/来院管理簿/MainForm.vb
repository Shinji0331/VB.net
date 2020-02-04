﻿Imports System.Runtime.InteropServices
Public Class MainForm

#Region "サイドバーボタンの右パネル反映処理"
    Private Sub AbrirFormEnPanel(Of Miform As {Form, New})()
        Dim Formulario As Form
        Formulario = PanelFormularios.Controls.OfType(Of Miform)().FirstOrDefault()

        If Formulario Is Nothing Then
            Formulario = New Miform()
            Formulario.TopLevel = False
            Formulario.FormBorderStyle = FormBorderStyle.None
            Formulario.Dock = DockStyle.Fill
            PanelFormularios.Controls.Add(Formulario)
            PanelFormularios.Tag = Formulario
            Formulario.Show()
            Formulario.BringToFront()
        Else
            Formulario.BringToFront()
        End If
    End Sub
#End Region

#Region "サイドバーボタン"
    Private Sub serchBtn_Click(sender As Object, e As EventArgs) Handles serchBtn.Click
        AbrirFormEnPanel(Of Form1)()
    End Sub

    Private Sub entryBtn_Click(sender As Object, e As EventArgs) Handles entryBtn.Click
        AbrirFormEnPanel(Of Form2)()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        AbrirFormEnPanel(Of Form3)()
    End Sub
#End Region


End Class
