<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TxtName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtVName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtAdr = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtStd = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtTel = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtMail = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtBrf = New System.Windows.Forms.TextBox()
        Me.ChkNach = New System.Windows.Forms.CheckBox()
        Me.ChkVor = New System.Windows.Forms.CheckBox()
        Me.ChkAdr = New System.Windows.Forms.CheckBox()
        Me.ChkStd = New System.Windows.Forms.CheckBox()
        Me.ChkTel = New System.Windows.Forms.CheckBox()
        Me.ChkMail = New System.Windows.Forms.CheckBox()
        Me.ChkBeruf = New System.Windows.Forms.CheckBox()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.CheckBox9 = New System.Windows.Forms.CheckBox()
        Me.ChkID = New System.Windows.Forms.CheckBox()
        Me.Label0 = New System.Windows.Forms.Label()
        Me.TxtID = New System.Windows.Forms.TextBox()
        Me.TxtChgID = New System.Windows.Forms.TextBox()
        Me.TxtChgBeruf = New System.Windows.Forms.TextBox()
        Me.TxtChgTel = New System.Windows.Forms.TextBox()
        Me.TxtChgMail = New System.Windows.Forms.TextBox()
        Me.TxtChgAdr = New System.Windows.Forms.TextBox()
        Me.TxtChgStd = New System.Windows.Forms.TextBox()
        Me.TxtChgVorname = New System.Windows.Forms.TextBox()
        Me.TxtChgName = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(37, 506)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(329, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Kontakt generieren"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TxtName
        '
        Me.TxtName.Location = New System.Drawing.Point(122, 46)
        Me.TxtName.Name = "TxtName"
        Me.TxtName.ReadOnly = True
        Me.TxtName.Size = New System.Drawing.Size(244, 20)
        Me.TxtName.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(34, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(34, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Vorname"
        '
        'TxtVName
        '
        Me.TxtVName.Location = New System.Drawing.Point(122, 72)
        Me.TxtVName.Name = "TxtVName"
        Me.TxtVName.ReadOnly = True
        Me.TxtVName.Size = New System.Drawing.Size(244, 20)
        Me.TxtVName.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(34, 101)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Adresse"
        '
        'TxtAdr
        '
        Me.TxtAdr.Location = New System.Drawing.Point(122, 98)
        Me.TxtAdr.Name = "TxtAdr"
        Me.TxtAdr.ReadOnly = True
        Me.TxtAdr.Size = New System.Drawing.Size(244, 20)
        Me.TxtAdr.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(34, 127)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Stadt"
        '
        'TxtStd
        '
        Me.TxtStd.Location = New System.Drawing.Point(122, 124)
        Me.TxtStd.Name = "TxtStd"
        Me.TxtStd.ReadOnly = True
        Me.TxtStd.Size = New System.Drawing.Size(244, 20)
        Me.TxtStd.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(34, 153)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Telefonnummer"
        '
        'TxtTel
        '
        Me.TxtTel.Location = New System.Drawing.Point(122, 150)
        Me.TxtTel.Name = "TxtTel"
        Me.TxtTel.ReadOnly = True
        Me.TxtTel.Size = New System.Drawing.Size(244, 20)
        Me.TxtTel.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(34, 179)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(36, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "E-Mail"
        '
        'TxtMail
        '
        Me.TxtMail.Location = New System.Drawing.Point(122, 176)
        Me.TxtMail.Name = "TxtMail"
        Me.TxtMail.ReadOnly = True
        Me.TxtMail.Size = New System.Drawing.Size(244, 20)
        Me.TxtMail.TabIndex = 9
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(34, 205)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(32, 13)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Beruf"
        '
        'TxtBrf
        '
        Me.TxtBrf.Location = New System.Drawing.Point(122, 202)
        Me.TxtBrf.Name = "TxtBrf"
        Me.TxtBrf.ReadOnly = True
        Me.TxtBrf.Size = New System.Drawing.Size(244, 20)
        Me.TxtBrf.TabIndex = 15
        '
        'ChkNach
        '
        Me.ChkNach.AutoSize = True
        Me.ChkNach.Location = New System.Drawing.Point(384, 52)
        Me.ChkNach.Name = "ChkNach"
        Me.ChkNach.Size = New System.Drawing.Size(15, 14)
        Me.ChkNach.TabIndex = 17
        Me.ChkNach.UseVisualStyleBackColor = True
        '
        'ChkVor
        '
        Me.ChkVor.AutoSize = True
        Me.ChkVor.Location = New System.Drawing.Point(384, 78)
        Me.ChkVor.Name = "ChkVor"
        Me.ChkVor.Size = New System.Drawing.Size(15, 14)
        Me.ChkVor.TabIndex = 18
        Me.ChkVor.UseVisualStyleBackColor = True
        '
        'ChkAdr
        '
        Me.ChkAdr.AutoSize = True
        Me.ChkAdr.Location = New System.Drawing.Point(384, 104)
        Me.ChkAdr.Name = "ChkAdr"
        Me.ChkAdr.Size = New System.Drawing.Size(15, 14)
        Me.ChkAdr.TabIndex = 19
        Me.ChkAdr.UseVisualStyleBackColor = True
        '
        'ChkStd
        '
        Me.ChkStd.AutoSize = True
        Me.ChkStd.Location = New System.Drawing.Point(384, 130)
        Me.ChkStd.Name = "ChkStd"
        Me.ChkStd.Size = New System.Drawing.Size(15, 14)
        Me.ChkStd.TabIndex = 20
        Me.ChkStd.UseVisualStyleBackColor = True
        '
        'ChkTel
        '
        Me.ChkTel.AutoSize = True
        Me.ChkTel.Location = New System.Drawing.Point(384, 156)
        Me.ChkTel.Name = "ChkTel"
        Me.ChkTel.Size = New System.Drawing.Size(15, 14)
        Me.ChkTel.TabIndex = 21
        Me.ChkTel.UseVisualStyleBackColor = True
        '
        'ChkMail
        '
        Me.ChkMail.AutoSize = True
        Me.ChkMail.Location = New System.Drawing.Point(384, 181)
        Me.ChkMail.Name = "ChkMail"
        Me.ChkMail.Size = New System.Drawing.Size(15, 14)
        Me.ChkMail.TabIndex = 22
        Me.ChkMail.UseVisualStyleBackColor = True
        '
        'ChkBeruf
        '
        Me.ChkBeruf.AutoSize = True
        Me.ChkBeruf.Location = New System.Drawing.Point(384, 207)
        Me.ChkBeruf.Name = "ChkBeruf"
        Me.ChkBeruf.Size = New System.Drawing.Size(15, 14)
        Me.ChkBeruf.TabIndex = 23
        Me.ChkBeruf.UseVisualStyleBackColor = True
        '
        'TextBox9
        '
        Me.TextBox9.Location = New System.Drawing.Point(37, 349)
        Me.TextBox9.Multiline = True
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(329, 115)
        Me.TextBox9.TabIndex = 25
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(38, 470)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(328, 30)
        Me.ProgressBar1.TabIndex = 26
        '
        'TextBox10
        '
        Me.TextBox10.Location = New System.Drawing.Point(37, 274)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(329, 20)
        Me.TextBox10.TabIndex = 27
        '
        'CheckBox9
        '
        Me.CheckBox9.AutoSize = True
        Me.CheckBox9.Location = New System.Drawing.Point(37, 227)
        Me.CheckBox9.Name = "CheckBox9"
        Me.CheckBox9.Size = New System.Drawing.Size(122, 17)
        Me.CheckBox9.TabIndex = 28
        Me.CheckBox9.Text = "Labels umbenennen"
        Me.CheckBox9.UseVisualStyleBackColor = True
        '
        'ChkID
        '
        Me.ChkID.AutoSize = True
        Me.ChkID.Location = New System.Drawing.Point(384, 21)
        Me.ChkID.Name = "ChkID"
        Me.ChkID.Size = New System.Drawing.Size(15, 14)
        Me.ChkID.TabIndex = 40
        Me.ChkID.UseVisualStyleBackColor = True
        '
        'Label0
        '
        Me.Label0.AutoSize = True
        Me.Label0.Location = New System.Drawing.Point(34, 18)
        Me.Label0.Name = "Label0"
        Me.Label0.Size = New System.Drawing.Size(18, 13)
        Me.Label0.TabIndex = 39
        Me.Label0.Text = "ID"
        '
        'TxtID
        '
        Me.TxtID.Location = New System.Drawing.Point(122, 15)
        Me.TxtID.Name = "TxtID"
        Me.TxtID.ReadOnly = True
        Me.TxtID.Size = New System.Drawing.Size(244, 20)
        Me.TxtID.TabIndex = 38
        '
        'TxtChgID
        '
        Me.TxtChgID.Location = New System.Drawing.Point(417, 15)
        Me.TxtChgID.Name = "TxtChgID"
        Me.TxtChgID.Size = New System.Drawing.Size(100, 20)
        Me.TxtChgID.TabIndex = 48
        '
        'TxtChgBeruf
        '
        Me.TxtChgBeruf.Location = New System.Drawing.Point(417, 202)
        Me.TxtChgBeruf.Name = "TxtChgBeruf"
        Me.TxtChgBeruf.Size = New System.Drawing.Size(100, 20)
        Me.TxtChgBeruf.TabIndex = 47
        '
        'TxtChgTel
        '
        Me.TxtChgTel.Location = New System.Drawing.Point(417, 150)
        Me.TxtChgTel.Name = "TxtChgTel"
        Me.TxtChgTel.Size = New System.Drawing.Size(100, 20)
        Me.TxtChgTel.TabIndex = 46
        '
        'TxtChgMail
        '
        Me.TxtChgMail.Location = New System.Drawing.Point(417, 176)
        Me.TxtChgMail.Name = "TxtChgMail"
        Me.TxtChgMail.Size = New System.Drawing.Size(100, 20)
        Me.TxtChgMail.TabIndex = 45
        '
        'TxtChgAdr
        '
        Me.TxtChgAdr.Location = New System.Drawing.Point(417, 98)
        Me.TxtChgAdr.Name = "TxtChgAdr"
        Me.TxtChgAdr.Size = New System.Drawing.Size(100, 20)
        Me.TxtChgAdr.TabIndex = 44
        '
        'TxtChgStd
        '
        Me.TxtChgStd.Location = New System.Drawing.Point(417, 124)
        Me.TxtChgStd.Name = "TxtChgStd"
        Me.TxtChgStd.Size = New System.Drawing.Size(100, 20)
        Me.TxtChgStd.TabIndex = 43
        '
        'TxtChgVorname
        '
        Me.TxtChgVorname.Location = New System.Drawing.Point(417, 72)
        Me.TxtChgVorname.Name = "TxtChgVorname"
        Me.TxtChgVorname.Size = New System.Drawing.Size(100, 20)
        Me.TxtChgVorname.TabIndex = 42
        '
        'TxtChgName
        '
        Me.TxtChgName.Location = New System.Drawing.Point(417, 46)
        Me.TxtChgName.Name = "TxtChgName"
        Me.TxtChgName.Size = New System.Drawing.Size(100, 20)
        Me.TxtChgName.TabIndex = 41
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(417, 248)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(99, 22)
        Me.Button2.TabIndex = 49
        Me.Button2.Text = "Labers ändern"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(37, 323)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(329, 20)
        Me.TextBox1.TabIndex = 50
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(35, 258)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(66, 13)
        Me.Label8.TabIndex = 51
        Me.Label8.Text = "Durchgänge"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(35, 307)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(130, 13)
        Me.Label9.TabIndex = 52
        Me.Label9.Text = "Kontakte pro Durchgänge"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(566, 569)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.TxtChgID)
        Me.Controls.Add(Me.TxtChgBeruf)
        Me.Controls.Add(Me.TxtChgTel)
        Me.Controls.Add(Me.TxtChgMail)
        Me.Controls.Add(Me.TxtChgAdr)
        Me.Controls.Add(Me.TxtChgStd)
        Me.Controls.Add(Me.TxtChgVorname)
        Me.Controls.Add(Me.TxtChgName)
        Me.Controls.Add(Me.ChkID)
        Me.Controls.Add(Me.Label0)
        Me.Controls.Add(Me.TxtID)
        Me.Controls.Add(Me.CheckBox9)
        Me.Controls.Add(Me.TextBox10)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.TextBox9)
        Me.Controls.Add(Me.ChkBeruf)
        Me.Controls.Add(Me.ChkMail)
        Me.Controls.Add(Me.ChkTel)
        Me.Controls.Add(Me.ChkStd)
        Me.Controls.Add(Me.ChkAdr)
        Me.Controls.Add(Me.ChkVor)
        Me.Controls.Add(Me.ChkNach)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TxtBrf)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TxtTel)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TxtMail)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtAdr)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtStd)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtVName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtName)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Kontaktgenerator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents TxtName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtVName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtAdr As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtStd As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtTel As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtMail As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtBrf As TextBox
    Friend WithEvents ChkNach As CheckBox
    Friend WithEvents ChkVor As CheckBox
    Friend WithEvents ChkAdr As CheckBox
    Friend WithEvents ChkStd As CheckBox
    Friend WithEvents ChkTel As CheckBox
    Friend WithEvents ChkMail As CheckBox
    Friend WithEvents ChkBeruf As CheckBox
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents TextBox10 As TextBox
    Friend WithEvents CheckBox9 As CheckBox
    Friend WithEvents ChkID As CheckBox
    Friend WithEvents Label0 As Label
    Friend WithEvents TxtID As TextBox
    Friend WithEvents TxtChgID As TextBox
    Friend WithEvents TxtChgBeruf As TextBox
    Friend WithEvents TxtChgTel As TextBox
    Friend WithEvents TxtChgMail As TextBox
    Friend WithEvents TxtChgAdr As TextBox
    Friend WithEvents TxtChgStd As TextBox
    Friend WithEvents TxtChgVorname As TextBox
    Friend WithEvents TxtChgName As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
End Class
