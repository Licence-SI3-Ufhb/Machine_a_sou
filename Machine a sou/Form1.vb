Public Class main
    Dim i As Integer = 0
    Dim alea(5) As Double
    Dim locat(2) As Point
    Private Sub main_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'initialisation des éléments composants
        Me.TXT_fond.Text = "2500"
        Me.LBL_win.Visible = False : Me.LBL_lose.Visible = False
        Me.BT_roul.Enabled = False
        'recueillement des positions gagnantes
        For j As Integer = 0 To 2
            locat(j) = New Point(0, 0)
        Next
        locat(0) = Me.PB_11.Location : locat(1) = Me.PB_21.Location : locat(2) = Me.PB_a31.Location


    End Sub
#Region "gestion de la roue"

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Dim pos As Point = New Point(0, 0)
        If (i < alea(0)) Then
            pos = Me.PB_11.Location
            Me.PB_11.Location = Me.PB_a32.Location
            Me.PB_a32.Location = Me.PB_22.Location
            Me.PB_22.Location = pos

            i += 1
        Else
            Timer1.Stop()
            If (Timer1.Enabled = False And Timer2.Enabled = False And Timer3.Enabled = False) Then
                Decide()
            End If
            i = 0
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick

        Dim pos As Point = New Point(0, 0)
        If (i < alea(1)) Then
            pos = Me.PB_21.Location
            Me.PB_21.Location = Me.PB_a33.Location
            Me.PB_a33.Location = Me.PB_12.Location
            Me.PB_12.Location = pos

            i += 1
        Else
            Timer2.Stop()
            If (Timer1.Enabled = False And Timer2.Enabled = False And Timer3.Enabled = False) Then
                Decide()
            End If
            i = 0
        End If
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick

        Dim pos As Point = New Point(0, 0)
        If (i < alea(2)) Then
            pos = Me.PB_a31.Location
            Me.PB_a31.Location = Me.PB_13.Location
            Me.PB_13.Location = Me.PB_23.Location
            Me.PB_23.Location = pos

            i += 1
        Else
            Timer3.Stop()
            If (Timer1.Enabled = False And Timer2.Enabled = False And Timer3.Enabled = False) Then
                Decide()
            End If
            i = 0
        End If
    End Sub

#End Region


    Private Sub BT_roul_Click(sender As Object, e As EventArgs) Handles BT_roul.Click

        If (Me.TXT_mise.Text = "") Then
            MsgBox("Veillez indiquer votre mise", 0, "Miser")
        Else
            If (CDbl(Me.TXT_mise.Text) <= CDbl(Me.TXT_fond.Text)) Then
                Dim nbr(2) As Double
                For a As Integer = 0 To 2
                    nbr(a) = Rnd(1) * 20 + 20
                    alea(a) = nbr(a)
                Next
                Timer1.Start()
                Timer2.Start()
                Timer3.Start()
                Me.LB_modeDeJeu.Enabled = False
                Me.TXT_mise.ReadOnly = True : Me.LBL_win.Visible = False : Me.LBL_lose.Visible = False
                Me.LBL_pasDeSou.Visible = False
            Else
                Me.LBL_pasDeSou.Visible = True
            End If
        End If
    End Sub

    Sub Decide()

        Dim som As Double
        If ((locat(0) = Me.PB_11.Location And locat(1) = Me.PB_12.Location And locat(2) = Me.PB_13.Location) Or (locat(0) = Me.PB_22.Location And locat(1) = Me.PB_21.Location And locat(2) = Me.PB_23.Location) Or (locat(0) = Me.PB_a32.Location And locat(1) = Me.PB_a33.Location And locat(2) = Me.PB_a31.Location)) Then
            Me.LBL_win.Visible = True
            Me.LBL_lose.Visible = False
            som = CDbl(Me.TXT_fond.Text)
            som += CDbl(Me.LBL_gain.Text)
            Me.TXT_fond.Text = som
        Else
            Me.LBL_win.Visible = False
            Me.LBL_lose.Visible = True
            som = CDbl(Me.TXT_fond.Text)
            som -= CDbl(Me.TXT_mise.Text)
            Me.TXT_fond.Text = som
        End If

    End Sub

    Sub ComptGain()
        Dim M1Coef, M2Coef, M3Coef, M4Coef, M5Coef, min(5) As Double
        M1Coef = 2 : M2Coef = 4 : M3Coef = 6 : M4Coef = 8 : M5Coef = 10
        min(0) = 500 : min(1) = 2000 : min(2) = 4500 : min(3) = 7000 : min(4) = 9000

        If (Me.LB_modeDeJeu.SelectedIndex = 0) Then
            Me.LBL_mode.Text = "Méfiance"
            Me.LBL_coef.Text = M1Coef
            Me.LBL_gain.Text = M1Coef * CDbl(Me.TXT_mise.Text)
            If (CDbl(Me.TXT_mise.Text) < min(0)) Then
                Me.LBL_infoBul.Text = "Dans le Mode 'Méfiance', vous devez miser plus de" & min(0) & "VAL"
                Me.LBL_infoBul.Visible = True
                Me.BT_roul.Enabled = False
            Else
                Me.LBL_infoBul.Visible = False
                Me.BT_roul.Enabled = True
            End If
        ElseIf (Me.LB_modeDeJeu.SelectedIndex = 1) Then
            Me.LBL_mode.Text = "Espoir"
            Me.LBL_coef.Text = M2Coef
            Me.LBL_gain.Text = M2Coef * CDbl(Me.TXT_mise.Text)
        ElseIf (Me.LB_modeDeJeu.SelectedIndex = 2) Then
            Me.LBL_mode.Text = "Acceptation"
            Me.LBL_coef.Text = M3Coef
            Me.LBL_gain.Text = M3Coef * CDbl(Me.TXT_mise.Text)
        ElseIf (Me.LB_modeDeJeu.SelectedIndex = 3) Then
            Me.LBL_mode.Text = "Confiance"
            Me.LBL_coef.Text = M4Coef
            Me.LBL_gain.Text = M4Coef * CDbl(Me.TXT_mise.Text)
        ElseIf (Me.LB_modeDeJeu.SelectedIndex = 4) Then
            Me.LBL_mode.Text = "Intégrité"
            Me.LBL_coef.Text = M5Coef
            Me.LBL_gain.Text = M5Coef * CDbl(Me.TXT_mise.Text)
        End If
    End Sub



   

#Region "parametre de jeu"
    Private Sub TXT_mise_TextChanged(sender As Object, e As EventArgs) Handles TXT_mise.TextChanged
        
        If (Me.TXT_mise.Text = "") Then
            Me.BT_roul.Enabled = False
        Else
            If (Not IsNumeric(Me.TXT_mise.Text.Last())) Then
                Me.TXT_mise.Text = Me.TXT_mise.Text.Remove(Me.TXT_mise.Text.Length - 1)
                Me.BT_roul.Enabled = True


            End If
            ComptGain()
            'Me.BT_roul.Enabled = True
            Me.LBL_mise.Text = Me.TXT_mise.Text
        End If

    End Sub
#End Region

    Private Sub LB_modeDeJeu_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LB_modeDeJeu.SelectedIndexChanged

        ComptGain()
    End Sub

    Private Sub BT_replay_Click(sender As Object, e As EventArgs) Handles BT_replay.Click
        Me.TXT_mise.ReadOnly = False
        Me.LB_modeDeJeu.Enabled = True
    End Sub

    Private Sub BT_exit_Click(sender As Object, e As EventArgs) Handles BT_exit.Click
        End
    End Sub
End Class
