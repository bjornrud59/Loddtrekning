
Public Class Form1
    Inherits System.Windows.Forms.Form
    Dim LoddBlokkerFarge(6) As String
    Dim LoddBlokkerSerie(6) As String
    Dim LoddBlokkerFraNr(6) As Integer
    Dim LoddBlokkerTilNr(6) As Integer
    Dim MengdeLoddFarge(600) As String
    Dim MengdeLoddSerie(600) As String
    Dim MengdeLoddNummer(600) As Integer
    Dim MengdeFraNr As Integer
    Dim MengdeTilNr As Integer
    Dim wCurBlokkNr As Integer
    Dim wCurLoddTrukket As Integer
    Dim trukketLodd(16) As Integer
    Friend WithEvents TextTrukket12 As System.Windows.Forms.TextBox
    Friend WithEvents TextTrukket11 As System.Windows.Forms.TextBox
    Friend WithEvents TextTrukket10 As System.Windows.Forms.TextBox
    Friend WithEvents TextTrukket9 As System.Windows.Forms.TextBox
    Friend WithEvents TextTrukket8 As System.Windows.Forms.TextBox
    Friend WithEvents TextTrukket7 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents InnstillingerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TrekkemetodeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HjelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OmLoddtrekningToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Dim wforsinkelse As Integer
    Friend WithEvents TextTrukket13 As System.Windows.Forms.TextBox
    Friend WithEvents TextTrukket14 As System.Windows.Forms.TextBox
    Friend WithEvents TextTrukket15 As System.Windows.Forms.TextBox
    Friend WithEvents TextTrukket16 As System.Windows.Forms.TextBox
    Dim wForsinkelseFaktor As Decimal


#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TextBlokk3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBlokk4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBlokk5 As System.Windows.Forms.TextBox
    Friend WithEvents TextBlokk6 As System.Windows.Forms.TextBox
    Friend WithEvents TextBlokk2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBlokk1 As System.Windows.Forms.TextBox
    Friend WithEvents ButtonLeggTil As System.Windows.Forms.Button
    Friend WithEvents TextTilNr As System.Windows.Forms.TextBox
    Friend WithEvents TextFraNr As System.Windows.Forms.TextBox
    Friend WithEvents ComboSerie As System.Windows.Forms.ComboBox
    Friend WithEvents ComboFarge As System.Windows.Forms.ComboBox
    Friend WithEvents ButtonSlett1 As System.Windows.Forms.Button
    Friend WithEvents ButtonSlett2 As System.Windows.Forms.Button
    Friend WithEvents ButtonSlett3 As System.Windows.Forms.Button
    Friend WithEvents ButtonSlett4 As System.Windows.Forms.Button
    Friend WithEvents ButtonSlett5 As System.Windows.Forms.Button
    Friend WithEvents ButtonSlett6 As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents TextTrekning As System.Windows.Forms.TextBox
    Friend WithEvents ButtonTrekkLodd As System.Windows.Forms.Button
    Friend WithEvents TextTrukket1 As System.Windows.Forms.TextBox
    Friend WithEvents TextTrukket2 As System.Windows.Forms.TextBox
    Friend WithEvents TextTrukket3 As System.Windows.Forms.TextBox
    Friend WithEvents TextTrukket4 As System.Windows.Forms.TextBox
    Friend WithEvents TextTrukket5 As System.Windows.Forms.TextBox
    Friend WithEvents TextTrukket6 As System.Windows.Forms.TextBox
    Friend WithEvents ButtonNyTrekning As System.Windows.Forms.Button
    Friend WithEvents LabelTrekning As System.Windows.Forms.Label
    Friend WithEvents TxtHeading As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label2 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.ButtonSlett6 = New System.Windows.Forms.Button
        Me.ButtonSlett5 = New System.Windows.Forms.Button
        Me.ButtonSlett4 = New System.Windows.Forms.Button
        Me.ButtonSlett3 = New System.Windows.Forms.Button
        Me.ButtonSlett2 = New System.Windows.Forms.Button
        Me.ButtonSlett1 = New System.Windows.Forms.Button
        Me.TextBlokk3 = New System.Windows.Forms.TextBox
        Me.TextBlokk4 = New System.Windows.Forms.TextBox
        Me.TextBlokk5 = New System.Windows.Forms.TextBox
        Me.TextBlokk6 = New System.Windows.Forms.TextBox
        Me.TextBlokk2 = New System.Windows.Forms.TextBox
        Me.TextBlokk1 = New System.Windows.Forms.TextBox
        Me.ButtonLeggTil = New System.Windows.Forms.Button
        Me.TextTilNr = New System.Windows.Forms.TextBox
        Me.TextFraNr = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.ComboSerie = New System.Windows.Forms.ComboBox
        Me.ComboFarge = New System.Windows.Forms.ComboBox
        Me.TxtHeading = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Label3 = New System.Windows.Forms.Label
        Me.TextTrukket12 = New System.Windows.Forms.TextBox
        Me.TextTrukket11 = New System.Windows.Forms.TextBox
        Me.TextTrukket10 = New System.Windows.Forms.TextBox
        Me.TextTrukket9 = New System.Windows.Forms.TextBox
        Me.TextTrukket8 = New System.Windows.Forms.TextBox
        Me.TextTrukket7 = New System.Windows.Forms.TextBox
        Me.TextTrukket6 = New System.Windows.Forms.TextBox
        Me.TextTrukket5 = New System.Windows.Forms.TextBox
        Me.TextTrukket4 = New System.Windows.Forms.TextBox
        Me.TextTrukket3 = New System.Windows.Forms.TextBox
        Me.TextTrukket2 = New System.Windows.Forms.TextBox
        Me.TextTrukket1 = New System.Windows.Forms.TextBox
        Me.ButtonTrekkLodd = New System.Windows.Forms.Button
        Me.TextTrekning = New System.Windows.Forms.TextBox
        Me.ButtonNyTrekning = New System.Windows.Forms.Button
        Me.LabelTrekning = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.InnstillingerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TrekkemetodeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.HjelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.OmLoddtrekningToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TextTrukket13 = New System.Windows.Forms.TextBox
        Me.TextTrukket14 = New System.Windows.Forms.TextBox
        Me.TextTrukket15 = New System.Windows.Forms.TextBox
        Me.TextTrukket16 = New System.Windows.Forms.TextBox
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(24, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(488, 23)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Velg loddb�ker og nummer som skal v�re med i trekningen:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel1.Controls.Add(Me.ButtonSlett6)
        Me.Panel1.Controls.Add(Me.ButtonSlett5)
        Me.Panel1.Controls.Add(Me.ButtonSlett4)
        Me.Panel1.Controls.Add(Me.ButtonSlett3)
        Me.Panel1.Controls.Add(Me.ButtonSlett2)
        Me.Panel1.Controls.Add(Me.ButtonSlett1)
        Me.Panel1.Controls.Add(Me.TextBlokk3)
        Me.Panel1.Controls.Add(Me.TextBlokk4)
        Me.Panel1.Controls.Add(Me.TextBlokk5)
        Me.Panel1.Controls.Add(Me.TextBlokk6)
        Me.Panel1.Controls.Add(Me.TextBlokk2)
        Me.Panel1.Controls.Add(Me.TextBlokk1)
        Me.Panel1.Controls.Add(Me.ButtonLeggTil)
        Me.Panel1.Controls.Add(Me.TextTilNr)
        Me.Panel1.Controls.Add(Me.TextFraNr)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.ComboSerie)
        Me.Panel1.Controls.Add(Me.ComboFarge)
        Me.Panel1.Location = New System.Drawing.Point(24, 104)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(456, 272)
        Me.Panel1.TabIndex = 25
        '
        'ButtonSlett6
        '
        Me.ButtonSlett6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ButtonSlett6.Location = New System.Drawing.Point(376, 176)
        Me.ButtonSlett6.Name = "ButtonSlett6"
        Me.ButtonSlett6.Size = New System.Drawing.Size(64, 24)
        Me.ButtonSlett6.TabIndex = 45
        Me.ButtonSlett6.Text = "Slett"
        Me.ButtonSlett6.UseVisualStyleBackColor = False
        '
        'ButtonSlett5
        '
        Me.ButtonSlett5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ButtonSlett5.Location = New System.Drawing.Point(304, 176)
        Me.ButtonSlett5.Name = "ButtonSlett5"
        Me.ButtonSlett5.Size = New System.Drawing.Size(64, 24)
        Me.ButtonSlett5.TabIndex = 44
        Me.ButtonSlett5.Text = "Slett"
        Me.ButtonSlett5.UseVisualStyleBackColor = False
        '
        'ButtonSlett4
        '
        Me.ButtonSlett4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ButtonSlett4.Location = New System.Drawing.Point(232, 176)
        Me.ButtonSlett4.Name = "ButtonSlett4"
        Me.ButtonSlett4.Size = New System.Drawing.Size(64, 24)
        Me.ButtonSlett4.TabIndex = 43
        Me.ButtonSlett4.Text = "Slett"
        Me.ButtonSlett4.UseVisualStyleBackColor = False
        '
        'ButtonSlett3
        '
        Me.ButtonSlett3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ButtonSlett3.Location = New System.Drawing.Point(160, 176)
        Me.ButtonSlett3.Name = "ButtonSlett3"
        Me.ButtonSlett3.Size = New System.Drawing.Size(64, 24)
        Me.ButtonSlett3.TabIndex = 42
        Me.ButtonSlett3.Text = "Slett"
        Me.ButtonSlett3.UseVisualStyleBackColor = False
        '
        'ButtonSlett2
        '
        Me.ButtonSlett2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ButtonSlett2.Location = New System.Drawing.Point(88, 176)
        Me.ButtonSlett2.Name = "ButtonSlett2"
        Me.ButtonSlett2.Size = New System.Drawing.Size(64, 24)
        Me.ButtonSlett2.TabIndex = 41
        Me.ButtonSlett2.Text = "Slett"
        Me.ButtonSlett2.UseVisualStyleBackColor = False
        '
        'ButtonSlett1
        '
        Me.ButtonSlett1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ButtonSlett1.Location = New System.Drawing.Point(16, 176)
        Me.ButtonSlett1.Name = "ButtonSlett1"
        Me.ButtonSlett1.Size = New System.Drawing.Size(64, 24)
        Me.ButtonSlett1.TabIndex = 40
        Me.ButtonSlett1.Text = "Slett"
        Me.ButtonSlett1.UseVisualStyleBackColor = False
        '
        'TextBlokk3
        '
        Me.TextBlokk3.Location = New System.Drawing.Point(152, 80)
        Me.TextBlokk3.Multiline = True
        Me.TextBlokk3.Name = "TextBlokk3"
        Me.TextBlokk3.Size = New System.Drawing.Size(72, 88)
        Me.TextBlokk3.TabIndex = 39
        Me.TextBlokk3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBlokk4
        '
        Me.TextBlokk4.Location = New System.Drawing.Point(224, 80)
        Me.TextBlokk4.Multiline = True
        Me.TextBlokk4.Name = "TextBlokk4"
        Me.TextBlokk4.Size = New System.Drawing.Size(72, 88)
        Me.TextBlokk4.TabIndex = 38
        Me.TextBlokk4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBlokk5
        '
        Me.TextBlokk5.Location = New System.Drawing.Point(296, 80)
        Me.TextBlokk5.Multiline = True
        Me.TextBlokk5.Name = "TextBlokk5"
        Me.TextBlokk5.Size = New System.Drawing.Size(72, 88)
        Me.TextBlokk5.TabIndex = 37
        Me.TextBlokk5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBlokk6
        '
        Me.TextBlokk6.Location = New System.Drawing.Point(368, 80)
        Me.TextBlokk6.Multiline = True
        Me.TextBlokk6.Name = "TextBlokk6"
        Me.TextBlokk6.Size = New System.Drawing.Size(72, 88)
        Me.TextBlokk6.TabIndex = 36
        Me.TextBlokk6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBlokk2
        '
        Me.TextBlokk2.Location = New System.Drawing.Point(80, 80)
        Me.TextBlokk2.Multiline = True
        Me.TextBlokk2.Name = "TextBlokk2"
        Me.TextBlokk2.Size = New System.Drawing.Size(72, 88)
        Me.TextBlokk2.TabIndex = 35
        Me.TextBlokk2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBlokk1
        '
        Me.TextBlokk1.BackColor = System.Drawing.Color.White
        Me.TextBlokk1.Location = New System.Drawing.Point(8, 80)
        Me.TextBlokk1.Multiline = True
        Me.TextBlokk1.Name = "TextBlokk1"
        Me.TextBlokk1.Size = New System.Drawing.Size(72, 88)
        Me.TextBlokk1.TabIndex = 34
        Me.TextBlokk1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ButtonLeggTil
        '
        Me.ButtonLeggTil.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ButtonLeggTil.Location = New System.Drawing.Point(368, 32)
        Me.ButtonLeggTil.Name = "ButtonLeggTil"
        Me.ButtonLeggTil.Size = New System.Drawing.Size(80, 24)
        Me.ButtonLeggTil.TabIndex = 33
        Me.ButtonLeggTil.Text = "Legg til"
        Me.ButtonLeggTil.UseVisualStyleBackColor = False
        '
        'TextTilNr
        '
        Me.TextTilNr.Location = New System.Drawing.Point(304, 32)
        Me.TextTilNr.MaxLength = 3
        Me.TextTilNr.Name = "TextTilNr"
        Me.TextTilNr.Size = New System.Drawing.Size(56, 26)
        Me.TextTilNr.TabIndex = 32
        Me.TextTilNr.Text = "100"
        '
        'TextFraNr
        '
        Me.TextFraNr.Location = New System.Drawing.Point(240, 32)
        Me.TextFraNr.MaxLength = 3
        Me.TextFraNr.Name = "TextFraNr"
        Me.TextFraNr.Size = New System.Drawing.Size(56, 26)
        Me.TextFraNr.TabIndex = 31
        Me.TextFraNr.Text = "1"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(304, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 16)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Til nr:"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(240, 8)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 16)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = "Fra nr:"
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Location = New System.Drawing.Point(128, 8)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 16)
        Me.Label8.TabIndex = 28
        Me.Label8.Text = "Serie:"
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(8, 8)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 16)
        Me.Label9.TabIndex = 27
        Me.Label9.Text = "Farge:"
        '
        'ComboSerie
        '
        Me.ComboSerie.Items.AddRange(New Object() {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "�", "�", "�"})
        Me.ComboSerie.Location = New System.Drawing.Point(128, 32)
        Me.ComboSerie.Name = "ComboSerie"
        Me.ComboSerie.Size = New System.Drawing.Size(104, 27)
        Me.ComboSerie.TabIndex = 26
        '
        'ComboFarge
        '
        Me.ComboFarge.Items.AddRange(New Object() {"R�d", "Rosa", "Gr�nn", "Bl�", "Hvit", "Gul"})
        Me.ComboFarge.Location = New System.Drawing.Point(8, 32)
        Me.ComboFarge.Name = "ComboFarge"
        Me.ComboFarge.Size = New System.Drawing.Size(112, 27)
        Me.ComboFarge.TabIndex = 25
        '
        'TxtHeading
        '
        Me.TxtHeading.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtHeading.ForeColor = System.Drawing.Color.Blue
        Me.TxtHeading.Location = New System.Drawing.Point(200, 27)
        Me.TxtHeading.Name = "TxtHeading"
        Me.TxtHeading.Size = New System.Drawing.Size(472, 30)
        Me.TxtHeading.TabIndex = 26
        Me.TxtHeading.Text = "LODDTREKNING"
        Me.TxtHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel2.Controls.Add(Me.TextTrukket14)
        Me.Panel2.Controls.Add(Me.TextTrukket15)
        Me.Panel2.Controls.Add(Me.TextTrukket16)
        Me.Panel2.Controls.Add(Me.TextTrukket13)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.TextTrukket12)
        Me.Panel2.Controls.Add(Me.TextTrukket11)
        Me.Panel2.Controls.Add(Me.TextTrukket10)
        Me.Panel2.Controls.Add(Me.TextTrukket9)
        Me.Panel2.Controls.Add(Me.TextTrukket8)
        Me.Panel2.Controls.Add(Me.TextTrukket7)
        Me.Panel2.Controls.Add(Me.TextTrukket6)
        Me.Panel2.Controls.Add(Me.TextTrukket5)
        Me.Panel2.Controls.Add(Me.TextTrukket4)
        Me.Panel2.Controls.Add(Me.TextTrukket3)
        Me.Panel2.Controls.Add(Me.TextTrukket2)
        Me.Panel2.Controls.Add(Me.TextTrukket1)
        Me.Panel2.Controls.Add(Me.ButtonTrekkLodd)
        Me.Panel2.Controls.Add(Me.TextTrekning)
        Me.Panel2.Controls.Add(Me.ButtonNyTrekning)
        Me.Panel2.Location = New System.Drawing.Point(499, 104)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(360, 337)
        Me.Panel2.TabIndex = 27
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(13, 176)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(167, 16)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "Resultat av trekning:"
        '
        'TextTrukket12
        '
        Me.TextTrukket12.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextTrukket12.Location = New System.Drawing.Point(128, 245)
        Me.TextTrukket12.Multiline = True
        Me.TextTrukket12.Name = "TextTrukket12"
        Me.TextTrukket12.ReadOnly = True
        Me.TextTrukket12.Size = New System.Drawing.Size(41, 48)
        Me.TextTrukket12.TabIndex = 14
        '
        'TextTrukket11
        '
        Me.TextTrukket11.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextTrukket11.Location = New System.Drawing.Point(88, 245)
        Me.TextTrukket11.Multiline = True
        Me.TextTrukket11.Name = "TextTrukket11"
        Me.TextTrukket11.ReadOnly = True
        Me.TextTrukket11.Size = New System.Drawing.Size(40, 48)
        Me.TextTrukket11.TabIndex = 13
        '
        'TextTrukket10
        '
        Me.TextTrukket10.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextTrukket10.Location = New System.Drawing.Point(48, 245)
        Me.TextTrukket10.Multiline = True
        Me.TextTrukket10.Name = "TextTrukket10"
        Me.TextTrukket10.ReadOnly = True
        Me.TextTrukket10.Size = New System.Drawing.Size(40, 48)
        Me.TextTrukket10.TabIndex = 12
        '
        'TextTrukket9
        '
        Me.TextTrukket9.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextTrukket9.Location = New System.Drawing.Point(8, 245)
        Me.TextTrukket9.Multiline = True
        Me.TextTrukket9.Name = "TextTrukket9"
        Me.TextTrukket9.ReadOnly = True
        Me.TextTrukket9.Size = New System.Drawing.Size(40, 48)
        Me.TextTrukket9.TabIndex = 11
        '
        'TextTrukket8
        '
        Me.TextTrukket8.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextTrukket8.Location = New System.Drawing.Point(293, 195)
        Me.TextTrukket8.Multiline = True
        Me.TextTrukket8.Name = "TextTrukket8"
        Me.TextTrukket8.ReadOnly = True
        Me.TextTrukket8.Size = New System.Drawing.Size(40, 48)
        Me.TextTrukket8.TabIndex = 10
        '
        'TextTrukket7
        '
        Me.TextTrukket7.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextTrukket7.Location = New System.Drawing.Point(253, 195)
        Me.TextTrukket7.Multiline = True
        Me.TextTrukket7.Name = "TextTrukket7"
        Me.TextTrukket7.ReadOnly = True
        Me.TextTrukket7.Size = New System.Drawing.Size(40, 48)
        Me.TextTrukket7.TabIndex = 9
        '
        'TextTrukket6
        '
        Me.TextTrukket6.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextTrukket6.Location = New System.Drawing.Point(209, 195)
        Me.TextTrukket6.Multiline = True
        Me.TextTrukket6.Name = "TextTrukket6"
        Me.TextTrukket6.ReadOnly = True
        Me.TextTrukket6.Size = New System.Drawing.Size(44, 48)
        Me.TextTrukket6.TabIndex = 7
        '
        'TextTrukket5
        '
        Me.TextTrukket5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextTrukket5.Location = New System.Drawing.Point(169, 195)
        Me.TextTrukket5.Multiline = True
        Me.TextTrukket5.Name = "TextTrukket5"
        Me.TextTrukket5.ReadOnly = True
        Me.TextTrukket5.Size = New System.Drawing.Size(40, 48)
        Me.TextTrukket5.TabIndex = 6
        '
        'TextTrukket4
        '
        Me.TextTrukket4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextTrukket4.Location = New System.Drawing.Point(129, 195)
        Me.TextTrukket4.Multiline = True
        Me.TextTrukket4.Name = "TextTrukket4"
        Me.TextTrukket4.ReadOnly = True
        Me.TextTrukket4.Size = New System.Drawing.Size(40, 48)
        Me.TextTrukket4.TabIndex = 5
        '
        'TextTrukket3
        '
        Me.TextTrukket3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextTrukket3.Location = New System.Drawing.Point(89, 195)
        Me.TextTrukket3.Multiline = True
        Me.TextTrukket3.Name = "TextTrukket3"
        Me.TextTrukket3.ReadOnly = True
        Me.TextTrukket3.Size = New System.Drawing.Size(40, 48)
        Me.TextTrukket3.TabIndex = 4
        '
        'TextTrukket2
        '
        Me.TextTrukket2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextTrukket2.Location = New System.Drawing.Point(49, 195)
        Me.TextTrukket2.Multiline = True
        Me.TextTrukket2.Name = "TextTrukket2"
        Me.TextTrukket2.ReadOnly = True
        Me.TextTrukket2.Size = New System.Drawing.Size(40, 48)
        Me.TextTrukket2.TabIndex = 3
        '
        'TextTrukket1
        '
        Me.TextTrukket1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextTrukket1.Location = New System.Drawing.Point(9, 195)
        Me.TextTrukket1.Multiline = True
        Me.TextTrukket1.Name = "TextTrukket1"
        Me.TextTrukket1.ReadOnly = True
        Me.TextTrukket1.Size = New System.Drawing.Size(40, 48)
        Me.TextTrukket1.TabIndex = 2
        '
        'ButtonTrekkLodd
        '
        Me.ButtonTrekkLodd.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ButtonTrekkLodd.Location = New System.Drawing.Point(122, 8)
        Me.ButtonTrekkLodd.Name = "ButtonTrekkLodd"
        Me.ButtonTrekkLodd.Size = New System.Drawing.Size(120, 24)
        Me.ButtonTrekkLodd.TabIndex = 1
        Me.ButtonTrekkLodd.Text = "Trekk Lodd"
        Me.ButtonTrekkLodd.UseVisualStyleBackColor = False
        '
        'TextTrekning
        '
        Me.TextTrekning.Font = New System.Drawing.Font("Arial", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextTrekning.Location = New System.Drawing.Point(126, 40)
        Me.TextTrekning.Multiline = True
        Me.TextTrekning.Name = "TextTrekning"
        Me.TextTrekning.ReadOnly = True
        Me.TextTrekning.Size = New System.Drawing.Size(112, 136)
        Me.TextTrekning.TabIndex = 0
        Me.TextTrekning.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ButtonNyTrekning
        '
        Me.ButtonNyTrekning.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ButtonNyTrekning.Location = New System.Drawing.Point(94, 304)
        Me.ButtonNyTrekning.Name = "ButtonNyTrekning"
        Me.ButtonNyTrekning.Size = New System.Drawing.Size(200, 24)
        Me.ButtonNyTrekning.TabIndex = 8
        Me.ButtonNyTrekning.Text = "Start ny trekning"
        Me.ButtonNyTrekning.UseVisualStyleBackColor = False
        '
        'LabelTrekning
        '
        Me.LabelTrekning.Location = New System.Drawing.Point(616, 72)
        Me.LabelTrekning.Name = "LabelTrekning"
        Me.LabelTrekning.Size = New System.Drawing.Size(104, 23)
        Me.LabelTrekning.TabIndex = 28
        Me.LabelTrekning.Text = "Trekning:"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(755, 447)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(104, 24)
        Me.Button1.TabIndex = 29
        Me.Button1.Text = "Avslutt"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AccessibleDescription = "http://www.bjornrud.com"
        Me.LinkLabel1.AccessibleName = "http://www.bjornrud.com"
        Me.LinkLabel1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.Location = New System.Drawing.Point(32, 392)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(136, 16)
        Me.LinkLabel1.TabIndex = 30
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "www.bjornrud.com"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InnstillingerToolStripMenuItem, Me.HjelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(871, 24)
        Me.MenuStrip1.TabIndex = 31
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'InnstillingerToolStripMenuItem
        '
        Me.InnstillingerToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TrekkemetodeToolStripMenuItem})
        Me.InnstillingerToolStripMenuItem.Name = "InnstillingerToolStripMenuItem"
        Me.InnstillingerToolStripMenuItem.Size = New System.Drawing.Size(74, 20)
        Me.InnstillingerToolStripMenuItem.Text = "Innstillinger"
        '
        'TrekkemetodeToolStripMenuItem
        '
        Me.TrekkemetodeToolStripMenuItem.Name = "TrekkemetodeToolStripMenuItem"
        Me.TrekkemetodeToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.TrekkemetodeToolStripMenuItem.Text = "Trekkemetode"
        '
        'HjelpToolStripMenuItem
        '
        Me.HjelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OmLoddtrekningToolStripMenuItem})
        Me.HjelpToolStripMenuItem.Name = "HjelpToolStripMenuItem"
        Me.HjelpToolStripMenuItem.Size = New System.Drawing.Size(43, 20)
        Me.HjelpToolStripMenuItem.Text = "Hjelp"
        '
        'OmLoddtrekningToolStripMenuItem
        '
        Me.OmLoddtrekningToolStripMenuItem.Name = "OmLoddtrekningToolStripMenuItem"
        Me.OmLoddtrekningToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.OmLoddtrekningToolStripMenuItem.Text = "Om Loddtrekning"
        '
        'TextTrukket13
        '
        Me.TextTrukket13.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextTrukket13.Location = New System.Drawing.Point(169, 245)
        Me.TextTrukket13.Multiline = True
        Me.TextTrukket13.Name = "TextTrukket13"
        Me.TextTrukket13.ReadOnly = True
        Me.TextTrukket13.Size = New System.Drawing.Size(40, 48)
        Me.TextTrukket13.TabIndex = 32
        '
        'TextTrukket14
        '
        Me.TextTrukket14.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextTrukket14.Location = New System.Drawing.Point(209, 245)
        Me.TextTrukket14.Multiline = True
        Me.TextTrukket14.Name = "TextTrukket14"
        Me.TextTrukket14.ReadOnly = True
        Me.TextTrukket14.Size = New System.Drawing.Size(44, 48)
        Me.TextTrukket14.TabIndex = 33
        '
        'TextTrukket15
        '
        Me.TextTrukket15.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextTrukket15.Location = New System.Drawing.Point(253, 245)
        Me.TextTrukket15.Multiline = True
        Me.TextTrukket15.Name = "TextTrukket15"
        Me.TextTrukket15.ReadOnly = True
        Me.TextTrukket15.Size = New System.Drawing.Size(40, 48)
        Me.TextTrukket15.TabIndex = 34
        '
        'TextTrukket16
        '
        Me.TextTrukket16.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextTrukket16.Location = New System.Drawing.Point(293, 245)
        Me.TextTrukket16.Multiline = True
        Me.TextTrukket16.Name = "TextTrukket16"
        Me.TextTrukket16.ReadOnly = True
        Me.TextTrukket16.Size = New System.Drawing.Size(40, 48)
        Me.TextTrukket16.TabIndex = 35
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(8, 19)
        Me.ClientSize = New System.Drawing.Size(871, 483)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.LabelTrekning)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.TxtHeading)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Loddtrekning v.2.1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        wTrekkeMetode = "LykkeKjapp"
        wCurBlokkNr = 1
        ComboFarge.SelectedIndex() = 0
        ComboSerie.SelectedIndex() = 0
        ButtonSlett1.Enabled = False
        ButtonSlett2.Enabled = False
        ButtonSlett3.Enabled = False
        ButtonSlett4.Enabled = False
        ButtonSlett5.Enabled = False
        ButtonSlett6.Enabled = False
        ButtonNyTrekning.Enabled = False
        ButtonTrekkLodd.Enabled = False
        ComboFarge.Focus()
        TxtHeading.Enabled = False
        TextBlokk1.Enabled = False
        TextBlokk2.Enabled = False
        TextBlokk3.Enabled = False
        TextBlokk4.Enabled = False
        TextBlokk5.Enabled = False
        TextBlokk6.Enabled = False
        wCurLoddTrukket = 0

        MengdeFraNr = 0
        MengdeTilNr = 0

        VisValgteBlokker()

        Randomize()

    End Sub

    Private Sub ButtonLeggTil_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonLeggTil.Click
        If wCurBlokkNr = 7 Then
            MsgBox("Kan ikke legge til flere.....")
            Return
        End If

        If CInt(TextFraNr.Text) > 100 Or CInt(TextFraNr.Text) > CInt(TextTilNr.Text) Then
            MsgBox("Ugyldig verdi i Fra nr!")
            TextFraNr.Focus()
            Return
        End If
        If CInt(TextTilNr.Text) > 100 Or CInt(TextTilNr.Text) < CInt(TextFraNr.Text) Then
            MsgBox("Ugyldig verdi i Til nr!")
            TextTilNr.Focus()
            Return
        End If


        If ComboFarge.SelectedItem = "" Or ComboSerie.SelectedItem = "" Then
            MsgBox("Velg farge og serie")
            Return

        Else
            'enhver endring skal forhindre at man f�r trukket lodd f�r man har lagt det nye utvalget i "hatten"
            MengdeFraNr = 0
            MengdeTilNr = 0
            ButtonNyTrekning.Enabled = True

            LoddBlokkerFarge(wCurBlokkNr) = ComboFarge.SelectedItem()
            LoddBlokkerSerie(wCurBlokkNr) = ComboSerie.SelectedItem()
            LoddBlokkerFraNr(wCurBlokkNr) = CInt(TextFraNr.Text)
            LoddBlokkerTilNr(wCurBlokkNr) = CInt(TextTilNr.Text)

            VisValgteBlokker()

            wCurBlokkNr = wCurBlokkNr + 1
        End If
    End Sub

    Private Sub TextBlokk1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBlokk1.TextChanged

    End Sub
    Private Sub VisValgteBlokker()
        Dim wi As Integer
        Dim waktuell As Integer

        waktuell = 1
        TextBlokk1.Visible = False
        TextBlokk2.Visible = False
        TextBlokk3.Visible = False
        TextBlokk4.Visible = False
        TextBlokk5.Visible = False
        TextBlokk6.Visible = False
        TextBlokk1.Clear()
        TextBlokk2.Clear()
        TextBlokk3.Clear()
        TextBlokk4.Clear()
        TextBlokk5.Clear()
        TextBlokk6.Clear()
        TextBlokk1.BackColor = System.Drawing.Color.Empty
        TextBlokk2.BackColor = System.Drawing.Color.Empty
        TextBlokk3.BackColor = System.Drawing.Color.Empty
        TextBlokk4.BackColor = System.Drawing.Color.Empty
        TextBlokk5.BackColor = System.Drawing.Color.Empty
        TextBlokk6.BackColor = System.Drawing.Color.Empty
        ButtonSlett1.Enabled = False
        ButtonSlett1.Visible = False
        ButtonSlett2.Enabled = False
        ButtonSlett2.Visible = False
        ButtonSlett3.Enabled = False
        ButtonSlett3.Visible = False
        ButtonSlett4.Enabled = False
        ButtonSlett4.Visible = False
        ButtonSlett5.Enabled = False
        ButtonSlett5.Visible = False
        ButtonSlett6.Enabled = False
        ButtonSlett6.Visible = False
        For wi = 1 To 6
            If LoddBlokkerFarge(wi) <> "" Then
                If waktuell = 1 Then
                    TextBlokk1.Visible = True
                    TextBlokk1.AppendText(LoddBlokkerSerie(wi) & vbCrLf & LoddBlokkerFraNr(wi) & "-" & LoddBlokkerTilNr(wi))
                    If LoddBlokkerFarge(wi) = "R�d" Then
                        TextBlokk1.BackColor = System.Drawing.Color.Red
                    ElseIf LoddBlokkerFarge(wi) = "Rosa" Then
                        TextBlokk1.BackColor = System.Drawing.Color.Pink
                    ElseIf LoddBlokkerFarge(wi) = "Gr�nn" Then
                        TextBlokk1.BackColor = System.Drawing.Color.LightGreen
                    ElseIf LoddBlokkerFarge(wi) = "Bl�" Then
                        TextBlokk1.BackColor = System.Drawing.Color.LightBlue
                    ElseIf LoddBlokkerFarge(wi) = "Hvit" Then
                        TextBlokk1.BackColor = System.Drawing.Color.White
                    ElseIf LoddBlokkerFarge(wi) = "Gul" Then
                        TextBlokk1.BackColor = System.Drawing.Color.Yellow
                    Else
                        TextBlokk1.BackColor = System.Drawing.Color.White
                    End If
                    ButtonSlett1.Visible = True
                    ButtonSlett1.Enabled = True
                    waktuell = 2
                ElseIf waktuell = 2 Then
                    TextBlokk2.Visible = True
                    TextBlokk2.AppendText(LoddBlokkerSerie(wi) & vbCrLf & LoddBlokkerFraNr(wi) & "-" & LoddBlokkerTilNr(wi))
                    If LoddBlokkerFarge(wi) = "R�d" Then
                        TextBlokk2.BackColor = System.Drawing.Color.Red
                    ElseIf LoddBlokkerFarge(wi) = "Rosa" Then
                        TextBlokk2.BackColor = System.Drawing.Color.Pink
                    ElseIf LoddBlokkerFarge(wi) = "Gr�nn" Then
                        TextBlokk2.BackColor = System.Drawing.Color.LightGreen
                    ElseIf LoddBlokkerFarge(wi) = "Bl�" Then
                        TextBlokk2.BackColor = System.Drawing.Color.LightBlue
                    ElseIf LoddBlokkerFarge(wi) = "Hvit" Then
                        TextBlokk2.BackColor = System.Drawing.Color.White
                    ElseIf LoddBlokkerFarge(wi) = "Gul" Then
                        TextBlokk2.BackColor = System.Drawing.Color.Yellow
                    Else
                        TextBlokk2.BackColor = System.Drawing.Color.White
                    End If
                    ButtonSlett2.Visible = True
                    ButtonSlett2.Enabled = True
                    waktuell = 3

                ElseIf waktuell = 3 Then
                    TextBlokk3.Visible = True
                    TextBlokk3.AppendText(LoddBlokkerSerie(wi) & vbCrLf & LoddBlokkerFraNr(wi) & "-" & LoddBlokkerTilNr(wi))
                    If LoddBlokkerFarge(wi) = "R�d" Then
                        TextBlokk3.BackColor = System.Drawing.Color.Red
                    ElseIf LoddBlokkerFarge(wi) = "Rosa" Then
                        TextBlokk3.BackColor = System.Drawing.Color.Pink
                    ElseIf LoddBlokkerFarge(wi) = "Gr�nn" Then
                        TextBlokk3.BackColor = System.Drawing.Color.LightGreen
                    ElseIf LoddBlokkerFarge(wi) = "Bl�" Then
                        TextBlokk3.BackColor = System.Drawing.Color.LightBlue
                    ElseIf LoddBlokkerFarge(wi) = "Hvit" Then
                        TextBlokk3.BackColor = System.Drawing.Color.White
                    ElseIf LoddBlokkerFarge(wi) = "Gul" Then
                        TextBlokk3.BackColor = System.Drawing.Color.Yellow
                    Else
                        TextBlokk3.BackColor = System.Drawing.Color.White
                    End If
                    ButtonSlett3.Visible = True
                    ButtonSlett3.Enabled = True
                    waktuell = 4

                ElseIf waktuell = 4 Then
                    TextBlokk4.Visible = True
                    TextBlokk4.AppendText(LoddBlokkerSerie(wi) & vbCrLf & LoddBlokkerFraNr(wi) & "-" & LoddBlokkerTilNr(wi))
                    If LoddBlokkerFarge(wi) = "R�d" Then
                        TextBlokk4.BackColor = System.Drawing.Color.Red
                    ElseIf LoddBlokkerFarge(wi) = "Rosa" Then
                        TextBlokk4.BackColor = System.Drawing.Color.Pink
                    ElseIf LoddBlokkerFarge(wi) = "Gr�nn" Then
                        TextBlokk4.BackColor = System.Drawing.Color.LightGreen
                    ElseIf LoddBlokkerFarge(wi) = "Bl�" Then
                        TextBlokk4.BackColor = System.Drawing.Color.LightBlue
                    ElseIf LoddBlokkerFarge(wi) = "Hvit" Then
                        TextBlokk4.BackColor = System.Drawing.Color.White
                    ElseIf LoddBlokkerFarge(wi) = "Gul" Then
                        TextBlokk4.BackColor = System.Drawing.Color.Yellow
                    Else
                        TextBlokk4.BackColor = System.Drawing.Color.White
                    End If
                    ButtonSlett4.Visible = True
                    ButtonSlett4.Enabled = True
                    waktuell = 5

                ElseIf waktuell = 5 Then
                    TextBlokk5.Visible = True
                    TextBlokk5.AppendText(LoddBlokkerSerie(wi) & vbCrLf & LoddBlokkerFraNr(wi) & "-" & LoddBlokkerTilNr(wi))
                    If LoddBlokkerFarge(wi) = "R�d" Then
                        TextBlokk5.BackColor = System.Drawing.Color.Red
                    ElseIf LoddBlokkerFarge(wi) = "Rosa" Then
                        TextBlokk5.BackColor = System.Drawing.Color.Pink
                    ElseIf LoddBlokkerFarge(wi) = "Gr�nn" Then
                        TextBlokk5.BackColor = System.Drawing.Color.LightGreen
                    ElseIf LoddBlokkerFarge(wi) = "Bl�" Then
                        TextBlokk5.BackColor = System.Drawing.Color.LightBlue
                    ElseIf LoddBlokkerFarge(wi) = "Hvit" Then
                        TextBlokk5.BackColor = System.Drawing.Color.White
                    ElseIf LoddBlokkerFarge(wi) = "Gul" Then
                        TextBlokk5.BackColor = System.Drawing.Color.Yellow
                    Else
                        TextBlokk5.BackColor = System.Drawing.Color.White
                    End If
                    ButtonSlett5.Visible = True
                    ButtonSlett5.Enabled = True
                    waktuell = 6

                ElseIf waktuell = 6 Then
                    TextBlokk6.Visible = True
                    TextBlokk6.AppendText(LoddBlokkerSerie(wi) & vbCrLf & LoddBlokkerFraNr(wi) & "-" & LoddBlokkerTilNr(wi))
                    If LoddBlokkerFarge(wi) = "R�d" Then
                        TextBlokk6.BackColor = System.Drawing.Color.Red
                    ElseIf LoddBlokkerFarge(wi) = "Rosa" Then
                        TextBlokk6.BackColor = System.Drawing.Color.Pink
                    ElseIf LoddBlokkerFarge(wi) = "Gr�nn" Then
                        TextBlokk6.BackColor = System.Drawing.Color.LightGreen
                    ElseIf LoddBlokkerFarge(wi) = "Bl�" Then
                        TextBlokk6.BackColor = System.Drawing.Color.LightBlue
                    ElseIf LoddBlokkerFarge(wi) = "Hvit" Then
                        TextBlokk6.BackColor = System.Drawing.Color.White
                    ElseIf LoddBlokkerFarge(wi) = "Gul" Then
                        TextBlokk6.BackColor = System.Drawing.Color.Yellow
                    Else
                        TextBlokk6.BackColor = System.Drawing.Color.White
                    End If
                    ButtonSlett6.Visible = True
                    ButtonSlett6.Enabled = True
                    waktuell = 9999
                End If

            End If
        Next
        AlleLodderTilHatten()
    End Sub

    Private Sub TextTilNr_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextTilNr.TextChanged

    End Sub

    Private Sub TextFraNr_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextFraNr.TextChanged
    End Sub

    Private Sub ButtonSlett1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSlett1.Click
        SlettLoddBlokk(1)
    End Sub
    Private Sub SlettLoddBlokk(ByVal wBlokkNr As Integer)
        Dim wi As Integer
        'enhver endring skal forhindre at man f�r trukket lodd f�r man har lagt det nye utvalget i "hatten"
        MengdeFraNr = 0
        MengdeTilNr = 0
        ButtonNyTrekning.Enabled = True
        If wBlokkNr = 6 Then
            LoddBlokkerFarge(6) = ""
            LoddBlokkerSerie(6) = ""
            LoddBlokkerFraNr(6) = 0
            LoddBlokkerTilNr(6) = 0

        Else
            For wi = wBlokkNr To 5
                LoddBlokkerFarge(wi) = LoddBlokkerFarge(wi + 1)
                LoddBlokkerSerie(wi) = LoddBlokkerSerie(wi + 1)
                LoddBlokkerFraNr(wi) = LoddBlokkerFraNr(wi + 1)
                LoddBlokkerTilNr(wi) = LoddBlokkerTilNr(wi + 1)
                LoddBlokkerFarge(wi + 1) = ""
                LoddBlokkerSerie(wi + 1) = ""
                LoddBlokkerFraNr(wi + 1) = 0
                LoddBlokkerTilNr(wi + 1) = 0
            Next wi
        End If
        wCurBlokkNr = wCurBlokkNr - 1

        VisValgteBlokker()
    End Sub

    Private Sub ButtonSlett2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSlett2.Click
        SlettLoddBlokk(2)

    End Sub

    Private Sub ButtonSlett3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSlett3.Click
        SlettLoddBlokk(3)

    End Sub

    Private Sub ButtonSlett4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSlett4.Click
        SlettLoddBlokk(4)

    End Sub

    Private Sub ButtonSlett5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSlett5.Click
        SlettLoddBlokk(5)

    End Sub

    Private Sub ButtonSlett6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSlett6.Click
        SlettLoddBlokk(6)

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub ButtonTrekkLodd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonTrekkLodd.Click
        Dim wTrukketTall As Integer
        Dim wi As Integer
        Dim wy As Integer
        Dim wx As Integer
        Dim wGyldigtall As Boolean
        'fjern gammelt lodd
        TextTrekning.BackColor = System.Drawing.Color.Empty
        TextTrekning.Clear()
        If MengdeFraNr = 0 Then
            MsgBox("Legg f�rst loddene i 'hatten'!")
            Return
        End If

        If wCurLoddTrukket = 16 Then
            MsgBox("Du kan ikke foreta flere trekninger fra denne 'hatten'!")
            Return
        End If
        If wCurLoddTrukket = MengdeTilNr Then
            MsgBox("Det er ikke flere lodd igjen i 'hatten'!")
            Return
        End If
        Panel1.Enabled = False
        ButtonNyTrekning.Enabled = False
        ButtonTrekkLodd.Enabled = False
        Button1.Enabled = False
        TextTrekning.Enabled = True
        TxtHeading.Focus()
        'trekk et lodd:
        wCurLoddTrukket = wCurLoddTrukket + 1

        wGyldigtall = False
        Do While wGyldigtall = False
            's�rger for at ikke samme tall trekkes to ganger:
            wTrukketTall = Int((MengdeTilNr - MengdeFraNr + 1) * Rnd() + MengdeFraNr)
            If wTrukketTall <> trukketLodd(1) And _
               wTrukketTall <> trukketLodd(2) And _
               wTrukketTall <> trukketLodd(3) And _
               wTrukketTall <> trukketLodd(4) And _
               wTrukketTall <> trukketLodd(5) And _
               wTrukketTall <> trukketLodd(6) And _
               wTrukketTall <> trukketLodd(7) And _
               wTrukketTall <> trukketLodd(8) And _
               wTrukketTall <> trukketLodd(9) And _
               wTrukketTall <> trukketLodd(10) And _
               wTrukketTall <> trukketLodd(11) And _
               wTrukketTall <> trukketLodd(12) And _
               wTrukketTall <> trukketLodd(13) And _
               wTrukketTall <> trukketLodd(14) And _
               wTrukketTall <> trukketLodd(15) And _
               wTrukketTall <> trukketLodd(16) Then
                wGyldigtall = True
            End If
        Loop
        trukketLodd(wCurLoddTrukket) = wTrukketTall

        TextTrekning.Clear()
        TextTrekning.BackColor = System.Drawing.Color.Empty

        If wTrekkeMetode = "LykkeNormal" Or _
           wTrekkeMetode = "LykkeKjapp" Or _
           wTrekkeMetode = "LykkeTreig" Then _
        'vis alle loddene i hatten fortl�pende (lykkehjul) og end opp med vinnerloddet:
            For wi = 1 To (MengdeTilNr + wTrukketTall)
                If wi > MengdeTilNr Then
                    wy = wi - MengdeTilNr
                Else
                    wy = wi
                End If
                Select Case MengdeLoddFarge(wy)
                    Case "R�d"
                        TextTrekning.BackColor = System.Drawing.Color.Red
                    Case "Rosa"
                        TextTrekning.BackColor = System.Drawing.Color.Pink
                    Case "Gr�nn"
                        TextTrekning.BackColor = System.Drawing.Color.LightGreen
                    Case "R�d"
                        TextTrekning.BackColor = System.Drawing.Color.Red
                    Case "Bl�"
                        TextTrekning.BackColor = System.Drawing.Color.LightBlue
                    Case "Hvit"
                        TextTrekning.BackColor = System.Drawing.Color.White
                    Case "Gul"
                        TextTrekning.BackColor = System.Drawing.Color.Yellow
                End Select
                TextTrekning.Clear()
                'Viser et lodd:
                TextTrekning.AppendText(MengdeLoddSerie(wy))
                TextTrekning.AppendText(vbCrLf)
                TextTrekning.AppendText(MengdeLoddNummer(wy))
                TextTrekning.AppendText(vbCrLf)
                'beregner forsinkelsen mellom hvert lodd som vises:
                'Liten forsinkelse mellom de f�rste loddene, gradvis st�rre forsinkelse n�r
                'man n�rmer seg vinnerloddet:
                If wi < ((MengdeTilNr + wTrukketTall) - ((MengdeTilNr + wTrukketTall) / 2)) Then
                    wforsinkelse = 2000000
                ElseIf wi < ((MengdeTilNr + wTrukketTall) - ((MengdeTilNr + wTrukketTall) / 4)) Then
                    wforsinkelse = 30000000
                ElseIf wi < ((MengdeTilNr + wTrukketTall) - ((MengdeTilNr + wTrukketTall) / 8)) Then
                    wforsinkelse = 60000000
                ElseIf wi < ((MengdeTilNr + wTrukketTall) - ((MengdeTilNr + wTrukketTall) / 16)) Then
                    wforsinkelse = 120000000
                ElseIf wi < ((MengdeTilNr + wTrukketTall) - ((MengdeTilNr + wTrukketTall) / 50)) Then
                    wforsinkelse = 200000000
                Else
                    wforsinkelse = 300000000
                End If


                If wTrekkeMetode = "LykkeNormal" Then
                    wForsinkelseFaktor = 0
                ElseIf wTrekkeMetode = "LykkeTreig" Then
                    wForsinkelseFaktor = -0.5
                ElseIf wTrekkeMetode = "LykkeKjapp" Then
                    wForsinkelseFaktor = 0.5
                End If

                'Forsinkelse etter dette loddet:

                For wx = 1 To (wforsinkelse - (wforsinkelse * wForsinkelseFaktor))
                Next wx

            Next wi
        ElseIf wTrekkeMetode = "Direkte" Then

        End If

        'vis frem vinnerloddet
        TextTrekning.Clear()
        TextTrekning.Enabled = False

        Select Case MengdeLoddFarge(wTrukketTall)
            Case "R�d"
                TextTrekning.BackColor = System.Drawing.Color.Red
            Case "Rosa"
                TextTrekning.BackColor = System.Drawing.Color.Pink
            Case "Gr�nn"
                TextTrekning.BackColor = System.Drawing.Color.LightGreen
            Case "R�d"
                TextTrekning.BackColor = System.Drawing.Color.Red
            Case "Bl�"
                TextTrekning.BackColor = System.Drawing.Color.LightBlue
            Case "Hvit"
                TextTrekning.BackColor = System.Drawing.Color.White
            Case "Gul"
                TextTrekning.BackColor = System.Drawing.Color.Yellow
        End Select
        TextTrekning.AppendText(MengdeLoddSerie(wTrukketTall))
        TextTrekning.AppendText(vbCrLf)
        TextTrekning.AppendText(MengdeLoddNummer(wTrukketTall))
        'legg loddet ut av hatten:
        Select Case wCurLoddTrukket
            Case 1
                TextTrukket1.AppendText(MengdeLoddSerie(wTrukketTall) & vbCrLf & MengdeLoddNummer(wTrukketTall))
                Select Case MengdeLoddFarge(wTrukketTall)
                    Case "R�d"
                        TextTrukket1.BackColor = System.Drawing.Color.Red
                    Case "Rosa"
                        TextTrukket1.BackColor = System.Drawing.Color.Pink
                    Case "Gr�nn"
                        TextTrukket1.BackColor = System.Drawing.Color.LightGreen
                    Case "R�d"
                        TextTrukket1.BackColor = System.Drawing.Color.Red
                    Case "Bl�"
                        TextTrukket1.BackColor = System.Drawing.Color.LightBlue
                    Case "Hvit"
                        TextTrukket1.BackColor = System.Drawing.Color.White
                    Case "Gul"
                        TextTrukket1.BackColor = System.Drawing.Color.Yellow
                End Select
            Case 2
                TextTrukket2.AppendText(MengdeLoddSerie(wTrukketTall) & vbCrLf & MengdeLoddNummer(wTrukketTall))
                Select Case MengdeLoddFarge(wTrukketTall)
                    Case "R�d"
                        TextTrukket2.BackColor = System.Drawing.Color.Red
                    Case "Rosa"
                        TextTrukket2.BackColor = System.Drawing.Color.Pink
                    Case "Gr�nn"
                        TextTrukket2.BackColor = System.Drawing.Color.LightGreen
                    Case "R�d"
                        TextTrukket2.BackColor = System.Drawing.Color.Red
                    Case "Bl�"
                        TextTrukket2.BackColor = System.Drawing.Color.LightBlue
                    Case "Hvit"
                        TextTrukket2.BackColor = System.Drawing.Color.White
                    Case "Gul"
                        TextTrukket2.BackColor = System.Drawing.Color.Yellow
                End Select
            Case 3
                TextTrukket3.AppendText(MengdeLoddSerie(wTrukketTall) & vbCrLf & MengdeLoddNummer(wTrukketTall))
                Select Case MengdeLoddFarge(wTrukketTall)
                    Case "R�d"
                        TextTrukket3.BackColor = System.Drawing.Color.Red
                    Case "Rosa"
                        TextTrukket3.BackColor = System.Drawing.Color.Pink
                    Case "Gr�nn"
                        TextTrukket3.BackColor = System.Drawing.Color.LightGreen
                    Case "R�d"
                        TextTrukket3.BackColor = System.Drawing.Color.Red
                    Case "Bl�"
                        TextTrukket3.BackColor = System.Drawing.Color.LightBlue
                    Case "Hvit"
                        TextTrukket3.BackColor = System.Drawing.Color.White
                    Case "Gul"
                        TextTrukket3.BackColor = System.Drawing.Color.Yellow
                End Select
            Case 4
                TextTrukket4.AppendText(MengdeLoddSerie(wTrukketTall) & vbCrLf & MengdeLoddNummer(wTrukketTall))
                Select Case MengdeLoddFarge(wTrukketTall)
                    Case "R�d"
                        TextTrukket4.BackColor = System.Drawing.Color.Red
                    Case "Rosa"
                        TextTrukket4.BackColor = System.Drawing.Color.Pink
                    Case "Gr�nn"
                        TextTrukket4.BackColor = System.Drawing.Color.LightGreen
                    Case "R�d"
                        TextTrukket4.BackColor = System.Drawing.Color.Red
                    Case "Bl�"
                        TextTrukket4.BackColor = System.Drawing.Color.LightBlue
                    Case "Hvit"
                        TextTrukket4.BackColor = System.Drawing.Color.White
                    Case "Gul"
                        TextTrukket4.BackColor = System.Drawing.Color.Yellow
                End Select
            Case 5
                TextTrukket5.AppendText(MengdeLoddSerie(wTrukketTall) & vbCrLf & MengdeLoddNummer(wTrukketTall))
                Select Case MengdeLoddFarge(wTrukketTall)
                    Case "R�d"
                        TextTrukket5.BackColor = System.Drawing.Color.Red
                    Case "Rosa"
                        TextTrukket5.BackColor = System.Drawing.Color.Pink
                    Case "Gr�nn"
                        TextTrukket5.BackColor = System.Drawing.Color.LightGreen
                    Case "R�d"
                        TextTrukket5.BackColor = System.Drawing.Color.Red
                    Case "Bl�"
                        TextTrukket5.BackColor = System.Drawing.Color.LightBlue
                    Case "Hvit"
                        TextTrukket5.BackColor = System.Drawing.Color.White
                    Case "Gul"
                        TextTrukket5.BackColor = System.Drawing.Color.Yellow
                End Select
            Case 6
                TextTrukket6.AppendText(MengdeLoddSerie(wTrukketTall) & vbCrLf & MengdeLoddNummer(wTrukketTall))
                Select Case MengdeLoddFarge(wTrukketTall)
                    Case "R�d"
                        TextTrukket6.BackColor = System.Drawing.Color.Red
                    Case "Rosa"
                        TextTrukket6.BackColor = System.Drawing.Color.Pink
                    Case "Gr�nn"
                        TextTrukket6.BackColor = System.Drawing.Color.LightGreen
                    Case "R�d"
                        TextTrukket6.BackColor = System.Drawing.Color.Red
                    Case "Bl�"
                        TextTrukket6.BackColor = System.Drawing.Color.LightBlue
                    Case "Hvit"
                        TextTrukket6.BackColor = System.Drawing.Color.White
                    Case "Gul"
                        TextTrukket6.BackColor = System.Drawing.Color.Yellow
                End Select
            Case 7
                TextTrukket7.AppendText(MengdeLoddSerie(wTrukketTall) & vbCrLf & MengdeLoddNummer(wTrukketTall))
                Select Case MengdeLoddFarge(wTrukketTall)
                    Case "R�d"
                        TextTrukket7.BackColor = System.Drawing.Color.Red
                    Case "Rosa"
                        TextTrukket7.BackColor = System.Drawing.Color.Pink
                    Case "Gr�nn"
                        TextTrukket7.BackColor = System.Drawing.Color.LightGreen
                    Case "R�d"
                        TextTrukket7.BackColor = System.Drawing.Color.Red
                    Case "Bl�"
                        TextTrukket7.BackColor = System.Drawing.Color.LightBlue
                    Case "Hvit"
                        TextTrukket7.BackColor = System.Drawing.Color.White
                    Case "Gul"
                        TextTrukket7.BackColor = System.Drawing.Color.Yellow
                End Select
            Case 8
                TextTrukket8.AppendText(MengdeLoddSerie(wTrukketTall) & vbCrLf & MengdeLoddNummer(wTrukketTall))
                Select Case MengdeLoddFarge(wTrukketTall)
                    Case "R�d"
                        TextTrukket8.BackColor = System.Drawing.Color.Red
                    Case "Rosa"
                        TextTrukket8.BackColor = System.Drawing.Color.Pink
                    Case "Gr�nn"
                        TextTrukket8.BackColor = System.Drawing.Color.LightGreen
                    Case "R�d"
                        TextTrukket8.BackColor = System.Drawing.Color.Red
                    Case "Bl�"
                        TextTrukket8.BackColor = System.Drawing.Color.LightBlue
                    Case "Hvit"
                        TextTrukket8.BackColor = System.Drawing.Color.White
                    Case "Gul"
                        TextTrukket8.BackColor = System.Drawing.Color.Yellow
                End Select
            Case 9
                TextTrukket9.AppendText(MengdeLoddSerie(wTrukketTall) & vbCrLf & MengdeLoddNummer(wTrukketTall))
                Select Case MengdeLoddFarge(wTrukketTall)
                    Case "R�d"
                        TextTrukket9.BackColor = System.Drawing.Color.Red
                    Case "Rosa"
                        TextTrukket9.BackColor = System.Drawing.Color.Pink
                    Case "Gr�nn"
                        TextTrukket9.BackColor = System.Drawing.Color.LightGreen
                    Case "R�d"
                        TextTrukket9.BackColor = System.Drawing.Color.Red
                    Case "Bl�"
                        TextTrukket9.BackColor = System.Drawing.Color.LightBlue
                    Case "Hvit"
                        TextTrukket9.BackColor = System.Drawing.Color.White
                    Case "Gul"
                        TextTrukket9.BackColor = System.Drawing.Color.Yellow
                End Select
            Case 10
                TextTrukket10.AppendText(MengdeLoddSerie(wTrukketTall) & vbCrLf & MengdeLoddNummer(wTrukketTall))
                Select Case MengdeLoddFarge(wTrukketTall)
                    Case "R�d"
                        TextTrukket10.BackColor = System.Drawing.Color.Red
                    Case "Rosa"
                        TextTrukket10.BackColor = System.Drawing.Color.Pink
                    Case "Gr�nn"
                        TextTrukket10.BackColor = System.Drawing.Color.LightGreen
                    Case "R�d"
                        TextTrukket10.BackColor = System.Drawing.Color.Red
                    Case "Bl�"
                        TextTrukket10.BackColor = System.Drawing.Color.LightBlue
                    Case "Hvit"
                        TextTrukket10.BackColor = System.Drawing.Color.White
                    Case "Gul"
                        TextTrukket10.BackColor = System.Drawing.Color.Yellow
                End Select
            Case 11
                TextTrukket11.AppendText(MengdeLoddSerie(wTrukketTall) & vbCrLf & MengdeLoddNummer(wTrukketTall))
                Select Case MengdeLoddFarge(wTrukketTall)
                    Case "R�d"
                        TextTrukket11.BackColor = System.Drawing.Color.Red
                    Case "Rosa"
                        TextTrukket11.BackColor = System.Drawing.Color.Pink
                    Case "Gr�nn"
                        TextTrukket11.BackColor = System.Drawing.Color.LightGreen
                    Case "R�d"
                        TextTrukket11.BackColor = System.Drawing.Color.Red
                    Case "Bl�"
                        TextTrukket11.BackColor = System.Drawing.Color.LightBlue
                    Case "Hvit"
                        TextTrukket11.BackColor = System.Drawing.Color.White
                    Case "Gul"
                        TextTrukket11.BackColor = System.Drawing.Color.Yellow
                End Select
            Case 12
                TextTrukket12.AppendText(MengdeLoddSerie(wTrukketTall) & vbCrLf & MengdeLoddNummer(wTrukketTall))
                Select Case MengdeLoddFarge(wTrukketTall)
                    Case "R�d"
                        TextTrukket12.BackColor = System.Drawing.Color.Red
                    Case "Rosa"
                        TextTrukket12.BackColor = System.Drawing.Color.Pink
                    Case "Gr�nn"
                        TextTrukket12.BackColor = System.Drawing.Color.LightGreen
                    Case "R�d"
                        TextTrukket12.BackColor = System.Drawing.Color.Red
                    Case "Bl�"
                        TextTrukket12.BackColor = System.Drawing.Color.LightBlue
                    Case "Hvit"
                        TextTrukket12.BackColor = System.Drawing.Color.White
                    Case "Gul"
                        TextTrukket12.BackColor = System.Drawing.Color.Yellow
                End Select
            Case 13
                TextTrukket13.AppendText(MengdeLoddSerie(wTrukketTall) & vbCrLf & MengdeLoddNummer(wTrukketTall))
                Select Case MengdeLoddFarge(wTrukketTall)
                    Case "R�d"
                        TextTrukket13.BackColor = System.Drawing.Color.Red
                    Case "Rosa"
                        TextTrukket13.BackColor = System.Drawing.Color.Pink
                    Case "Gr�nn"
                        TextTrukket13.BackColor = System.Drawing.Color.LightGreen
                    Case "R�d"
                        TextTrukket13.BackColor = System.Drawing.Color.Red
                    Case "Bl�"
                        TextTrukket13.BackColor = System.Drawing.Color.LightBlue
                    Case "Hvit"
                        TextTrukket13.BackColor = System.Drawing.Color.White
                    Case "Gul"
                        TextTrukket13.BackColor = System.Drawing.Color.Yellow
                End Select
            Case 14
                TextTrukket14.AppendText(MengdeLoddSerie(wTrukketTall) & vbCrLf & MengdeLoddNummer(wTrukketTall))
                Select Case MengdeLoddFarge(wTrukketTall)
                    Case "R�d"
                        TextTrukket14.BackColor = System.Drawing.Color.Red
                    Case "Rosa"
                        TextTrukket14.BackColor = System.Drawing.Color.Pink
                    Case "Gr�nn"
                        TextTrukket14.BackColor = System.Drawing.Color.LightGreen
                    Case "R�d"
                        TextTrukket14.BackColor = System.Drawing.Color.Red
                    Case "Bl�"
                        TextTrukket14.BackColor = System.Drawing.Color.LightBlue
                    Case "Hvit"
                        TextTrukket14.BackColor = System.Drawing.Color.White
                    Case "Gul"
                        TextTrukket14.BackColor = System.Drawing.Color.Yellow
                End Select
            Case 15
                TextTrukket15.AppendText(MengdeLoddSerie(wTrukketTall) & vbCrLf & MengdeLoddNummer(wTrukketTall))
                Select Case MengdeLoddFarge(wTrukketTall)
                    Case "R�d"
                        TextTrukket15.BackColor = System.Drawing.Color.Red
                    Case "Rosa"
                        TextTrukket15.BackColor = System.Drawing.Color.Pink
                    Case "Gr�nn"
                        TextTrukket15.BackColor = System.Drawing.Color.LightGreen
                    Case "R�d"
                        TextTrukket15.BackColor = System.Drawing.Color.Red
                    Case "Bl�"
                        TextTrukket15.BackColor = System.Drawing.Color.LightBlue
                    Case "Hvit"
                        TextTrukket15.BackColor = System.Drawing.Color.White
                    Case "Gul"
                        TextTrukket15.BackColor = System.Drawing.Color.Yellow
                End Select
            Case 16
                TextTrukket16.AppendText(MengdeLoddSerie(wTrukketTall) & vbCrLf & MengdeLoddNummer(wTrukketTall))
                Select Case MengdeLoddFarge(wTrukketTall)
                    Case "R�d"
                        TextTrukket16.BackColor = System.Drawing.Color.Red
                    Case "Rosa"
                        TextTrukket16.BackColor = System.Drawing.Color.Pink
                    Case "Gr�nn"
                        TextTrukket16.BackColor = System.Drawing.Color.LightGreen
                    Case "R�d"
                        TextTrukket16.BackColor = System.Drawing.Color.Red
                    Case "Bl�"
                        TextTrukket16.BackColor = System.Drawing.Color.LightBlue
                    Case "Hvit"
                        TextTrukket16.BackColor = System.Drawing.Color.White
                    Case "Gul"
                        TextTrukket16.BackColor = System.Drawing.Color.Yellow
                End Select
        End Select
        ButtonNyTrekning.Enabled = True
        ButtonTrekkLodd.Enabled = True
        Button1.Enabled = True

    End Sub

    Private Sub ButtonNyTrekning_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonNyTrekning.Click
        Panel1.Enabled = True
        'fjern gammelt lodd
        TextTrekning.BackColor = System.Drawing.Color.Empty
        TextTrekning.Clear()
        'Fjern tidligere trukne lodd fra skjermen:
        TextTrukket1.Clear()
        TextTrukket1.BackColor = System.Drawing.Color.Empty
        TextTrukket2.Clear()
        TextTrukket2.BackColor = System.Drawing.Color.Empty
        TextTrukket3.Clear()
        TextTrukket3.BackColor = System.Drawing.Color.Empty
        TextTrukket4.Clear()
        TextTrukket4.BackColor = System.Drawing.Color.Empty
        TextTrukket5.Clear()
        TextTrukket5.BackColor = System.Drawing.Color.Empty
        TextTrukket6.Clear()
        TextTrukket6.BackColor = System.Drawing.Color.Empty
        TextTrukket7.Clear()
        TextTrukket7.BackColor = System.Drawing.Color.Empty
        TextTrukket8.Clear()
        TextTrukket8.BackColor = System.Drawing.Color.Empty
        TextTrukket9.Clear()
        TextTrukket9.BackColor = System.Drawing.Color.Empty
        TextTrukket10.Clear()
        TextTrukket10.BackColor = System.Drawing.Color.Empty
        TextTrukket11.Clear()
        TextTrukket11.BackColor = System.Drawing.Color.Empty
        TextTrukket12.Clear()
        TextTrukket12.BackColor = System.Drawing.Color.Empty
        TextTrukket13.Clear()
        TextTrukket13.BackColor = System.Drawing.Color.Empty
        TextTrukket14.Clear()
        TextTrukket14.BackColor = System.Drawing.Color.Empty
        TextTrukket15.Clear()
        TextTrukket15.BackColor = System.Drawing.Color.Empty
        TextTrukket16.Clear()
        TextTrukket16.BackColor = System.Drawing.Color.Empty

        wCurLoddTrukket = 0
        'legg alle loddene i "hatten":
        AlleLodderTilHatten()
        trukketLodd(1) = 0
        trukketLodd(2) = 0
        trukketLodd(3) = 0
        trukketLodd(4) = 0
        trukketLodd(5) = 0
        trukketLodd(6) = 0
        trukketLodd(7) = 0
        trukketLodd(8) = 0
        trukketLodd(9) = 0
        trukketLodd(10) = 0
        trukketLodd(11) = 0
        trukketLodd(12) = 0
        trukketLodd(13) = 0
        trukketLodd(14) = 0
        trukketLodd(15) = 0
        trukketLodd(16) = 0
    End Sub

    Private Sub TxtHeading_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtHeading.Click

    End Sub

    Private Sub AlleLodderTilHatten()
        'legger alle loddene i "hatten":
        Dim wBlokk As Integer
        Dim wLoddNr As Integer
        Dim wMengdeNr As Integer

        'legg loddene i "hatten":

        MengdeFraNr = 0
        MengdeTilNr = 0

        wMengdeNr = 0
        For wBlokk = 1 To 6
            If LoddBlokkerFarge(wBlokk) <> "" Then
                For wLoddNr = LoddBlokkerFraNr(wBlokk) To LoddBlokkerTilNr(wBlokk)
                    wMengdeNr = wMengdeNr + 1
                    MengdeLoddFarge(wMengdeNr) = LoddBlokkerFarge(wBlokk)
                    MengdeLoddSerie(wMengdeNr) = LoddBlokkerSerie(wBlokk)
                    MengdeLoddNummer(wMengdeNr) = wLoddNr
                Next
            End If
        Next wBlokk
        If wMengdeNr > 0 Then
            MengdeFraNr = 1
            MengdeTilNr = wMengdeNr
            ButtonTrekkLodd.Enabled = True
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        End
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub

    Private Sub LabelTrekning_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LabelTrekning.Click

    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked

    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub TrekkemetodeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrekkemetodeToolStripMenuItem.Click
        frmTrMetode.Show()
    End Sub
End Class
