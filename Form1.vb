﻿Imports System
Imports System.IO
Public Class Form1

    Dim LabelCheck As Boolean
    Dim CodeAus As String
    Dim Nachnamen(50) As String
    Dim Vornamen(50) As String
    Private Sub CheckBox9_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox9.CheckedChanged
        If LabelCheck = False Then
            LabelCheck = True
            Me.Width = 319
        Else
            LabelCheck = False
            Me.Width = 485
            TxtChgID.Text = Label0.Text
            TxtChgName.Text = Label1.Text
            TxtChgVorname.Text = Label2.Text
            TxtChgAdr.Text = Label3.Text
            TxtChgStd.Text = Label4.Text
            TxtChgTel.Text = Label5.Text
            TxtChgMail.Text = Label6.Text
            TxtChgBeruf.Text = Label7.Text
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LabelCheck = True
        Me.Width = 319


        CheckBox9.Checked = False
            CheckBox1.Checked = True
            CheckBox2.Checked = True
            CheckBox3.Checked = True
            CheckBox4.Checked = True
            CheckBox5.Checked = True
            CheckBox6.Checked = True
            CheckBox7.Checked = True
            CheckBox8.Checked = True


        Nachnamen(1) = "Kackebart"
        Nachnamen(2) = "Powischer"
        Nachnamen(3) = "Scheissner"
        Nachnamen(4) = "Koten"
        Nachnamen(5) = "Haufen"
        Nachnamen(6) = "Piss"
        Nachnamen(7) = "Schwanz"
        Nachnamen(8) = "Kleinfeld"
        Nachnamen(9) = "Lübenschanz"
        Nachnamen(10) = "Schipper"
        Nachnamen(11) = "Gart"
        Nachnamen(12) = "Wright"
        Nachnamen(13) = "Müller"
        Nachnamen(14) = "Maisner"
        Nachnamen(15) = "Merkers"
        Nachnamen(16) = "Meis"
        Nachnamen(17) = "Wolf"
        Nachnamen(18) = "Lupina"
        Nachnamen(19) = "Legohagen"
        Nachnamen(20) = "Logenhode"
        Nachnamen(21) = "Rattenfall"
        Nachnamen(22) = "Deutsche"
        Nachnamen(23) = "Leggermann"
        Nachnamen(24) = "Nimmus"
        Nachnamen(25) = "Obenmann"
        Nachnamen(26) = "Redowinski"
        Nachnamen(27) = "Balabert"
        Nachnamen(28) = "Wolf"
        Nachnamen(29) = "Fokken"
        Nachnamen(30) = "Prahm"
        Nachnamen(31) = "Schuhmacher"
        Nachnamen(32) = "Dodenhof"
        Nachnamen(33) = "Oberschuben"
        Nachnamen(34) = "Kalamoni"
        Nachnamen(35) = "Rezion"
        Nachnamen(36) = "Renz"
        Nachnamen(37) = "Loose"
        Nachnamen(38) = "Schumbertus-Sonnenberg"
        Nachnamen(39) = "Hagenbode-Legohinten"
        Nachnamen(40) = "Radowinski"



    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Label0.Text = TxtChgID.Text
        Label1.Text = TxtChgName.Text
        Label2.Text = TxtChgVorname.Text
        Label3.Text = TxtChgAdr.Text
        Label4.Text = TxtChgStd.Text
        Label5.Text = TxtChgTel.Text
        Label6.Text = TxtChgMail.Text
        Label7.Text = TxtChgBeruf.Text
    End Sub

    Private Sub CheckBox7_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox7.CheckedChanged

    End Sub

    Private Sub CheckBox8_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox8.CheckedChanged

    End Sub

    Private Sub CheckBox6_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox6.CheckedChanged

    End Sub

    Private Sub CheckBox5_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox5.CheckedChanged

    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged

    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged

    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

    End Sub

    Public Sub CheckChecker()

    End Sub
End Class
