<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTrMetode
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label
        Me.rb_TrMetode_Direkte = New System.Windows.Forms.RadioButton
        Me.rb_TrMetode_Lykkehjul_Treig = New System.Windows.Forms.RadioButton
        Me.rb_TrMetode_Lykkehjul_Normal = New System.Windows.Forms.RadioButton
        Me.rb_TrMetode_Lykkehjul_Kjapp = New System.Windows.Forms.RadioButton
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(212, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Velg metode for visualisering av trekningen:"
        '
        'rb_TrMetode_Direkte
        '
        Me.rb_TrMetode_Direkte.AutoSize = True
        Me.rb_TrMetode_Direkte.Location = New System.Drawing.Point(15, 25)
        Me.rb_TrMetode_Direkte.Name = "rb_TrMetode_Direkte"
        Me.rb_TrMetode_Direkte.Size = New System.Drawing.Size(59, 17)
        Me.rb_TrMetode_Direkte.TabIndex = 2
        Me.rb_TrMetode_Direkte.Text = "Direkte"
        Me.rb_TrMetode_Direkte.UseVisualStyleBackColor = True
        '
        'rb_TrMetode_Lykkehjul_Treig
        '
        Me.rb_TrMetode_Lykkehjul_Treig.AutoSize = True
        Me.rb_TrMetode_Lykkehjul_Treig.Location = New System.Drawing.Point(15, 79)
        Me.rb_TrMetode_Lykkehjul_Treig.Name = "rb_TrMetode_Lykkehjul_Treig"
        Me.rb_TrMetode_Lykkehjul_Treig.Size = New System.Drawing.Size(98, 17)
        Me.rb_TrMetode_Lykkehjul_Treig.TabIndex = 4
        Me.rb_TrMetode_Lykkehjul_Treig.Text = "Lykkehjul_Treg"
        Me.rb_TrMetode_Lykkehjul_Treig.UseVisualStyleBackColor = True
        '
        'rb_TrMetode_Lykkehjul_Normal
        '
        Me.rb_TrMetode_Lykkehjul_Normal.AutoSize = True
        Me.rb_TrMetode_Lykkehjul_Normal.Location = New System.Drawing.Point(15, 61)
        Me.rb_TrMetode_Lykkehjul_Normal.Name = "rb_TrMetode_Lykkehjul_Normal"
        Me.rb_TrMetode_Lykkehjul_Normal.Size = New System.Drawing.Size(109, 17)
        Me.rb_TrMetode_Lykkehjul_Normal.TabIndex = 5
        Me.rb_TrMetode_Lykkehjul_Normal.Text = "Lykkehjul_Normal"
        Me.rb_TrMetode_Lykkehjul_Normal.UseVisualStyleBackColor = True
        '
        'rb_TrMetode_Lykkehjul_Kjapp
        '
        Me.rb_TrMetode_Lykkehjul_Kjapp.AutoSize = True
        Me.rb_TrMetode_Lykkehjul_Kjapp.Checked = True
        Me.rb_TrMetode_Lykkehjul_Kjapp.Location = New System.Drawing.Point(15, 43)
        Me.rb_TrMetode_Lykkehjul_Kjapp.Name = "rb_TrMetode_Lykkehjul_Kjapp"
        Me.rb_TrMetode_Lykkehjul_Kjapp.Size = New System.Drawing.Size(100, 17)
        Me.rb_TrMetode_Lykkehjul_Kjapp.TabIndex = 6
        Me.rb_TrMetode_Lykkehjul_Kjapp.TabStop = True
        Me.rb_TrMetode_Lykkehjul_Kjapp.Text = "Lykkehjul-Kjapp"
        Me.rb_TrMetode_Lykkehjul_Kjapp.UseVisualStyleBackColor = True
        '
        'frmTrMetode
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(339, 140)
        Me.Controls.Add(Me.rb_TrMetode_Lykkehjul_Kjapp)
        Me.Controls.Add(Me.rb_TrMetode_Lykkehjul_Normal)
        Me.Controls.Add(Me.rb_TrMetode_Lykkehjul_Treig)
        Me.Controls.Add(Me.rb_TrMetode_Direkte)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmTrMetode"
        Me.Text = "LoddTrekning - Valg av trekkemetode"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents rb_TrMetode_Direkte As System.Windows.Forms.RadioButton
    Friend WithEvents rb_TrMetode_Lykkehjul_Treig As System.Windows.Forms.RadioButton
    Friend WithEvents rb_TrMetode_Lykkehjul_Normal As System.Windows.Forms.RadioButton
    Friend WithEvents rb_TrMetode_Lykkehjul_Kjapp As System.Windows.Forms.RadioButton
End Class
