﻿Imports System
Imports System.IO.File
Imports System.IO
Public Class Form1

    Dim LabelCheck As Boolean
    Dim CodeAus As String
    Dim Nachnamen(50) As String
    Dim Vornamen(50) As String
    Dim Staedte(50) As String
    Dim Berufe(50) As String
    Dim EMailPvr(50) As String
    
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
        ChkNach.Checked = True
        ChkVor.Checked = True
        ChkAdr.Checked = True
        ChkStd.Checked = True
        ChkTel.Checked = True
        ChkMail.Checked = True
        ChkBeruf.Checked = True
        ChkID.Checked = True
        Dim NachnamenPath As String = "C:\Users\Nico\Documents\GitHub\Kontakt-Generator\Nachnamen.txt"
        Dim VornamenPath As String = "C:\Users\Nico\Documents\GitHub\Kontakt-Generator\Vornamen.txt"
        Dim StaedtePath As String = "C:\Users\Nico\Documents\GitHub\Kontakt-Generator\Staedte.txt"
        Dim BerufePath As String = "C:\Users\Nico\Documents\GitHub\Kontakt-Generator\Berufe.txt"

        Dim NachnamenTemp(50) As String
        Dim VornamenTemp(50) As String
        Dim StaedteTemp(50) As String
        Dim BerufeTemp(50) As String

        'TODO Change to root archive

        ReDim Nachnamen(ReadAllLines(NachnamenPath).Length + 1)
        ReDim Vornamen(ReadAllLines(VornamenPath).Length + 1)
        ReDim Staedte(ReadAllLines(StaedtePath).Length + 1)
        ReDim Berufe(ReadAllLines(BerufePath).Length + 1)

        NachnamenTemp = ReadAllLines(NachnamenPath)
        VornamenTemp = ReadAllLines(VornamenPath)
        StaedteTemp = ReadAllLines(StaedtePath)
        BerufeTemp = ReadAllLines(BerufePath)


        Dim i As Integer
        For i = 1 To NachnamenTemp.Length
            Nachnamen(i) = NachnamenTemp(i - 1)
        Next
        NachnamenTemp = Nothing
        For i = 1 To VornamenTemp.Length
            Vornamen(i) = VornamenTemp(i - 1)
        Next
        VornamenTemp = Nothing
        For i = 1 To StaedteTemp.Length
            Staedte(i) = StaedteTemp(i - 1)
        Next
        StaedteTemp = Nothing
        For i = 1 To BerufeTemp.Length
            Berufe(i) = BerufeTemp(i - 1)
        Next
        BerufeTemp = Nothing



        'Staedte(Staedte.Length - 1) = Staedte(0)
        'Staedte(Staedte.Length) = Staedte(0)
        'Nachnamen(Nachnamen.Length - 1) = Nachnamen(0)
        'Berufe(Berufe.Length - 1) = Berufe(0)
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

    Private Sub ChkID_CheckedChanged(sender As Object, e As EventArgs) Handles ChkID.CheckedChanged
        If ChkID.Checked = False Then
            TxtID.Visible = False
        Else
            TxtID.Visible = True
        End If
    End Sub

    Private Sub ChkBeruf_CheckedChanged(sender As Object, e As EventArgs) Handles ChkBeruf.CheckedChanged
        If ChkBeruf.Checked = False Then
            TxtBrf.Visible = False
        Else
            TxtBrf.Visible = True
        End If
    End Sub

    Private Sub ChkMail_CheckedChanged(sender As Object, e As EventArgs) Handles ChkMail.CheckedChanged
        If ChkMail.Checked = False Then
            TxtMail.Visible = False
        Else
            TxtMail.Visible = True
        End If
    End Sub

    Private Sub ChkTel_CheckedChanged(sender As Object, e As EventArgs) Handles ChkTel.CheckedChanged
        If ChkTel.Checked = False Then
            TxtTel.Visible = False
        Else
            TxtTel.Visible = True
        End If
    End Sub

    Private Sub ChkStd_CheckedChanged(sender As Object, e As EventArgs) Handles ChkStd.CheckedChanged
        If ChkStd.Checked = False Then
            TxtStd.Visible = False
        Else
            TxtStd.Visible = True
        End If
    End Sub

    Private Sub ChkAdr_CheckedChanged(sender As Object, e As EventArgs) Handles ChkAdr.CheckedChanged
        If ChkAdr.Checked = False Then
            TxtAdr.Visible = False
        Else
            TxtAdr.Visible = True
        End If
    End Sub

    Private Sub ChkVor_CheckedChanged(sender As Object, e As EventArgs) Handles ChkVor.CheckedChanged
        If ChkVor.Checked = False Then
            TxtVName.Visible = False
        Else
            TxtVName.Visible = True
        End If
    End Sub

    Private Sub ChkNach_CheckedChanged(sender As Object, e As EventArgs) Handles ChkNach.CheckedChanged
        If ChkNach.Checked = False Then
            TxtName.Visible = False
        Else
            TxtName.Visible = True
        End If
    End Sub
End Class
