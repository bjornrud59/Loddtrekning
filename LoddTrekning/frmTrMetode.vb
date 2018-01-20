Public Class frmTrMetode

    Private Sub rb_TrMetode_Lykkehjul_Kjapp_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_TrMetode_Lykkehjul_Kjapp.CheckedChanged
        If rb_TrMetode_Lykkehjul_Kjapp.Checked = True Then wTrekkeMetode = "LykkeKjapp"

    End Sub

    Private Sub rb_TrMetode_Direkte_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_TrMetode_Direkte.CheckedChanged
        If rb_TrMetode_Direkte.Checked = True Then wTrekkeMetode = "Direkte"
    End Sub

    Private Sub rb_TrMetode_Lykkehjul_Normal_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_TrMetode_Lykkehjul_Normal.CheckedChanged
        If rb_TrMetode_Lykkehjul_Normal.Checked = True Then wTrekkeMetode = "LykkeNormal"

    End Sub

    Private Sub rb_TrMetode_Lykkehjul_Treig_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_TrMetode_Lykkehjul_Treig.CheckedChanged
        If rb_TrMetode_Lykkehjul_Treig.Checked = True Then wTrekkeMetode = "LykkeTreig"

    End Sub

    Private Sub frmTrMetode_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
 
        If wTrekkeMetode = "Direkte" Then
            rb_TrMetode_Direkte.Checked = True

        ElseIf wTrekkeMetode = "LykkeNormal" Then
            rb_TrMetode_Lykkehjul_Normal.Checked = True

        ElseIf wTrekkeMetode = "LykkeTreig" Then
            rb_TrMetode_Lykkehjul_Treig.Checked = True

        ElseIf wTrekkeMetode = "LykkeKjapp" Then
            rb_TrMetode_Lykkehjul_Kjapp.Checked = True

        End If

    End Sub
End Class