Public Class MicMacMoe
    Dim Turn As Char = "X"
    Dim Turns As Integer = 0
    Dim RandPos As Integer = Rand(1, 9)
    Dim XWin As Integer = 0
    Dim OWin As Integer = 0
    Dim GamesPlayed As Integer = 0

    Public Function Rand(ByVal Low As Long, ByVal High As Long) As Long
        Try
            Randomize()
        Catch ex As StackOverflowException
            Return ""
        End Try
        Rand = Int((High - Low + 1) * Rnd()) + Low
    End Function

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Randomize()
        GBDifficulty.Enabled = False
        GBPlayers.Enabled = False
    End Sub

    Private Sub ClickEvent(button As Button)
        button.Text = "O"
        button.Enabled = False
        Turns += 1
        CheckPosition()
        Turn = "X"
    End Sub

    Private Sub CPUChooseEasy()
        Randomize()
        RandPos = Rand(1, 9)
        If Turn = "O" Then
            If RandPos = 1 Then
                CheckPosition()
                If BTN1.Text = "" Then
                    BTN1.Text = "O"
                    BTN1.Enabled = False
                    Turns += 1
                    CheckPosition()
                Else
                    CPUChooseEasy()
                End If
            ElseIf RandPos = 2 Then
                CheckPosition()
                If BTN2.Text = "" Then
                    BTN2.Text = "O"
                    BTN2.Enabled = False
                    Turns += 1
                    CheckPosition()
                Else
                    CPUChooseEasy()
                End If
            ElseIf RandPos = 3 Then
                CheckPosition()
                If BTN3.Text = "" Then
                    BTN3.Text = "O"
                    BTN3.Enabled = False
                    Turns += 1
                    CheckPosition()
                Else
                    CPUChooseEasy()
                End If
            ElseIf RandPos = 4 Then
                CheckPosition()
                If BTN4.Text = "" Then
                    BTN4.Text = "O"
                    BTN4.Enabled = False
                    Turns += 1
                    CheckPosition()
                Else
                    CPUChooseEasy()
                End If
            ElseIf RandPos = 5 Then
                CheckPosition()
                If BTN5.Text = "" Then
                    BTN5.Text = "O"
                    BTN5.Enabled = False
                    Turns += 1
                    CheckPosition()
                Else
                    CPUChooseEasy()
                End If
            ElseIf RandPos = 6 Then
                CheckPosition()
                If BTN6.Text = "" Then
                    BTN6.Text = "O"
                    BTN6.Enabled = False
                    Turns += 1
                    CheckPosition()
                Else
                    CPUChooseEasy()
                End If
            ElseIf RandPos = 7 Then
                CheckPosition()
                If BTN7.Text = "" Then
                    BTN7.Text = "O"
                    BTN7.Enabled = False
                    Turns += 1
                    CheckPosition()
                Else
                    CPUChooseEasy()
                End If
            ElseIf RandPos = 8 Then
                CheckPosition()
                If BTN8.Text = "" Then
                    BTN8.Text = "O"
                    BTN8.Enabled = False
                    Turns += 1
                    CheckPosition()
                Else
                    CPUChooseEasy()
                End If
            ElseIf RandPos = 9 Then
                CheckPosition()
                If BTN9.Text = "" Then
                    BTN9.Text = "O"
                    BTN9.Enabled = False
                    Turns += 1
                    CheckPosition()
                Else
                    CPUChooseEasy()
                End If
            End If
            Turn = "X"
        End If
    End Sub

    Private Sub CPUChooseImpossible()
        RandPos = Rand(1, 4)
        If Turn = "O" Then
            'win code'---------------------------------------------------
            'first side'
            If BTN1.Text = "O" And BTN2.Text = "O" And BTN3.Text = "" Then
                ClickEvent(BTN3)
            ElseIf BTN4.Text = "O" And BTN5.Text = "O" And BTN6.Text = "" Then
                ClickEvent(BTN6)
            ElseIf BTN7.Text = "O" And BTN8.Text = "O" And BTN9.Text = "" Then
                ClickEvent(BTN9)
            ElseIf BTN1.Text = "O" And BTN4.Text = "O" And BTN7.Text = "" Then
                ClickEvent(BTN7)
            ElseIf BTN2.Text = "O" And BTN5.Text = "O" And BTN8.Text = "" Then
                ClickEvent(BTN8)
            ElseIf BTN3.Text = "O" And BTN6.Text = "O" And BTN9.Text = "" Then
                ClickEvent(BTN9)
            ElseIf BTN1.Text = "O" And BTN5.Text = "O" And BTN9.Text = "" Then
                ClickEvent(BTN9)
            ElseIf BTN3.Text = "O" And BTN5.Text = "O" And BTN7.Text = "" Then
                ClickEvent(BTN7)
                'opposite side'
            ElseIf BTN2.Text = "O" And BTN3.Text = "O" And BTN1.Text = "" Then
                ClickEvent(BTN1)
            ElseIf BTN5.Text = "O" And BTN6.Text = "O" And BTN4.Text = "" Then
                ClickEvent(BTN4)
            ElseIf BTN8.Text = "O" And BTN9.Text = "O" And BTN7.Text = "" Then
                ClickEvent(BTN7)
            ElseIf BTN4.Text = "O" And BTN7.Text = "O" And BTN1.Text = "" Then
                ClickEvent(BTN1)
            ElseIf BTN5.Text = "O" And BTN8.Text = "O" And BTN2.Text = "" Then
                ClickEvent(BTN2)
            ElseIf BTN6.Text = "O" And BTN9.Text = "O" And BTN3.Text = "" Then
                ClickEvent(BTN3)
            ElseIf BTN5.Text = "O" And BTN9.Text = "O" And BTN1.Text = "" Then
                ClickEvent(BTN1)
            ElseIf BTN5.Text = "O" And BTN7.Text = "O" And BTN3.Text = "" Then
                ClickEvent(BTN3)
                'inside'
            ElseIf BTN1.Text = "O" And BTN3.Text = "O" And BTN2.Text = "" Then
                ClickEvent(BTN2)
            ElseIf BTN4.Text = "O" And BTN6.Text = "O" And BTN5.Text = "" Then
                ClickEvent(BTN5)
            ElseIf BTN7.Text = "O" And BTN9.Text = "O" And BTN8.Text = "" Then
                ClickEvent(BTN8)
            ElseIf BTN1.Text = "O" And BTN7.Text = "O" And BTN4.Text = "" Then
                ClickEvent(BTN4)
            ElseIf BTN2.Text = "O" And BTN8.Text = "O" And BTN5.Text = "" Then
                ClickEvent(BTN5)
            ElseIf BTN3.Text = "O" And BTN9.Text = "O" And BTN6.Text = "" Then
                ClickEvent(BTN6)
            ElseIf BTN1.Text = "O" And BTN9.Text = "O" And BTN5.Text = "" Then
                ClickEvent(BTN5)
            ElseIf BTN3.Text = "O" And BTN7.Text = "O" And BTN5.Text = "" Then
                ClickEvent(BTN2)
                'block code'-------------------------------------------------
                'first side'
            ElseIf BTN1.Text = "X" And BTN4.Text = "X" And BTN7.Text = "" Then
                ClickEvent(BTN7)
            ElseIf BTN2.Text = "X" And BTN5.Text = "X" And BTN8.Text = "" Then
                ClickEvent(BTN8)
            ElseIf BTN3.Text = "X" And BTN6.Text = "X" And BTN9.Text = "" Then
                ClickEvent(BTN9)
            ElseIf BTN1.Text = "X" And BTN2.Text = "X" And BTN3.Text = "" Then
                ClickEvent(BTN3)
            ElseIf BTN4.Text = "X" And BTN5.Text = "X" And BTN6.Text = "" Then
                ClickEvent(BTN6)
            ElseIf BTN7.Text = "X" And BTN8.Text = "X" And BTN9.Text = "" Then
                ClickEvent(BTN9)
            ElseIf BTN1.Text = "X" And BTN5.Text = "X" And BTN9.Text = "" Then
                ClickEvent(BTN9)
            ElseIf BTN3.Text = "X" And BTN5.Text = "X" And BTN7.Text = "" Then
                ClickEvent(BTN7)
                'oposite side'
            ElseIf BTN4.Text = "X" And BTN7.Text = "X" And BTN1.Text = "" Then
                ClickEvent(BTN1)
            ElseIf BTN5.Text = "X" And BTN8.Text = "X" And BTN2.Text = "" Then
                ClickEvent(BTN2)
            ElseIf BTN6.Text = "X" And BTN9.Text = "X" And BTN3.Text = "" Then
                ClickEvent(BTN3)
            ElseIf BTN2.Text = "X" And BTN3.Text = "X" And BTN1.Text = "" Then
                ClickEvent(BTN1)
            ElseIf BTN5.Text = "X" And BTN6.Text = "X" And BTN4.Text = "" Then
                ClickEvent(BTN4)
            ElseIf BTN8.Text = "X" And BTN9.Text = "X" And BTN7.Text = "" Then
                ClickEvent(BTN7)
            ElseIf BTN5.Text = "X" And BTN9.Text = "X" And BTN1.Text = "" Then
                ClickEvent(BTN1)
            ElseIf BTN5.Text = "X" And BTN7.Text = "X" And BTN3.Text = "" Then
                ClickEvent(BTN3)
                'inside'
            ElseIf BTN1.Text = "X" And BTN3.Text = "X" And BTN2.Text = "" Then
                ClickEvent(BTN2)
            ElseIf BTN4.Text = "X" And BTN6.Text = "X" And BTN5.Text = "" Then
                ClickEvent(BTN5)
            ElseIf BTN7.Text = "X" And BTN9.Text = "X" And BTN8.Text = "" Then
                ClickEvent(BTN8)
            ElseIf BTN1.Text = "X" And BTN7.Text = "X" And BTN4.Text = "" Then
                ClickEvent(BTN4)
            ElseIf BTN2.Text = "X" And BTN8.Text = "X" And BTN5.Text = "" Then
                ClickEvent(BTN5)
            ElseIf BTN3.Text = "X" And BTN9.Text = "X" And BTN6.Text = "" Then
                ClickEvent(BTN6)
            ElseIf BTN1.Text = "X" And BTN9.Text = "X" And BTN5.Text = "" Then
                ClickEvent(BTN5)
            ElseIf BTN3.Text = "X" And BTN7.Text = "X" And BTN5.Text = "" Then
                ClickEvent(BTN2)
                'top left corner and bottom middle-------------
            ElseIf BTN1.Text = "X" And BTN8.Text = "X" And BTN7.Text = "" Then
                ClickEvent(BTN7)
            ElseIf BTN3.Text = "X" And BTN4.Text = "X" And BTN1.Text = "" Then
                ClickEvent(BTN1)
            ElseIf BTN9.Text = "X" And BTN2.Text = "X" And BTN3.Text = "" Then
                ClickEvent(BTN3)
            ElseIf BTN7.Text = "X" And BTN6.Text = "X" And BTN9.Text = "" Then
                ClickEvent(BTN9)
                'reversed
            ElseIf BTN1.Text = "X" And BTN6.Text = "X" And BTN3.Text = "" Then
                ClickEvent(BTN3)
            ElseIf BTN3.Text = "X" And BTN8.Text = "X" And BTN9.Text = "" Then
                ClickEvent(BTN9)
            ElseIf BTN9.Text = "X" And BTN4.Text = "X" And BTN7.Text = "" Then
                ClickEvent(BTN7)
            ElseIf BTN7.Text = "X" And BTN2.Text = "X" And BTN1.Text = "" Then
                ClickEvent(BTN1)
                'Double corner code----------------------------
            ElseIf BTN1.Text = "X" And BTN9.Text = "X" Then
                If RandPos = 1 And BTN2.Text = "" Then
                    ClickEvent(BTN2)
                ElseIf RandPos = 2 And BTN4.Text = "" Then
                    ClickEvent(BTN4)
                ElseIf RandPos = 3 And BTN6.Text = "" Then
                    ClickEvent(BTN6)
                ElseIf RandPos = 4 And BTN8.Text = "" Then
                    ClickEvent(BTN8)
                End If
            ElseIf BTN3.Text = "X" And BTN7.Text = "X" Then
                If RandPos = 1 And BTN2.Text = "" Then
                    ClickEvent(BTN2)
                ElseIf RandPos = 2 And BTN4.Text = "" Then
                    ClickEvent(BTN4)
                ElseIf RandPos = 3 And BTN6.Text = "" Then
                    ClickEvent(BTN6)
                ElseIf RandPos = 4 And BTN8.Text = "" Then
                    ClickEvent(BTN8)
                End If
                'center code'---------------------------------
            ElseIf BTN5.Text = "" Then
                ClickEvent(BTN5)
                'corner code'------------------------------------------------------------------------------------------------------------------------------------------------------------------
            ElseIf BTN1.Text = "" And BTN2.Text = "" And BTN3.Text = "" And BTN4.Text = "" And BTN5.Text = "X" And BTN6.Text = "" And BTN7.Text = "" And BTN8.Text = "" And BTN9.Text = "" Then
                If RandPos = 1 Then
                    ClickEvent(BTN1)
                ElseIf RandPos = 2 Then
                    ClickEvent(BTN3)
                ElseIf RandPos = 3 Then
                    ClickEvent(BTN7)
                ElseIf RandPos = 4 Then
                    ClickEvent(BTN9)
                End If
                'Double corner code'
            ElseIf BTN2.Text = "X" And BTN4.Text = "X" And BTN1.Text = "" Then
                ClickEvent(BTN1)
            ElseIf BTN2.Text = "X" And BTN6.Text = "X" And BTN3.Text = "" Then
                ClickEvent(BTN3)
            ElseIf BTN4.Text = "X" And BTN8.Text = "X" And BTN7.Text = "" Then
                ClickEvent(BTN7)
            ElseIf BTN8.Text = "X" And BTN6.Text = "X" And BTN9.Text = "" Then
                ClickEvent(BTN9)
                'Random place code'
            ElseIf RandPos = 1 And BTN1.Text = "" Then
                ClickEvent(BTN1)
            ElseIf RandPos = 2 And BTN3.Text = "" Then
                ClickEvent(BTN3)
            ElseIf RandPos = 3 And BTN7.Text = "" Then
                ClickEvent(BTN7)
            ElseIf RandPos = 4 And BTN9.Text = "" Then
                ClickEvent(BTN9)
            Else
                CPUChooseImpossible()
            End If
        End If
    End Sub

    Private Sub RBSingle_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RBSingle.CheckedChanged
        GBDifficulty.Enabled = True
        LBLOWins.Text = "O won 0 time(s)."
        LBLXWins.Text = "X won 0 time(s)."
        LBLGamesPlayed.Text = "0"
    End Sub

    Private Sub RBTwo_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RBTwo.CheckedChanged
        GBDifficulty.Enabled = False
        LBLOWins.Text = "O won 0 time(s)."
        LBLXWins.Text = "X won 0 time(s)."
        LBLGamesPlayed.Text = "0"
    End Sub

    Private Sub BTNPlay_Click(sender As System.Object, e As System.EventArgs) Handles BTNPlay.Click
        If BTNPlay.Text = "Play" Then
            LBLGamesPlayed.Text = "Games played: " & GamesPlayed
            BTN1.Enabled = True
            BTN2.Enabled = True
            BTN3.Enabled = True
            BTN4.Enabled = True
            BTN5.Enabled = True
            BTN6.Enabled = True
            BTN7.Enabled = True
            BTN8.Enabled = True
            BTN9.Enabled = True
            LBLGamesPlayed.Visible = True
            GBDifficulty.Enabled = True
            GBPlayers.Enabled = True
            BTNPlay.Visible = False
            BTNPlay.Text = "Play Again!"
            BTN1.Text = ""
            BTN2.Text = ""
            BTN3.Text = ""
            BTN4.Text = ""
            BTN5.Text = ""
            BTN6.Text = ""
            BTN7.Text = ""
            BTN8.Text = ""
            BTN9.Text = ""
        End If
        If BTNPlay.Text = "Play Again!" Then
            GamesPlayed += 1
            LBLGamesPlayed.Text = "Games played: " & GamesPlayed
            BTN1.Text = ""
            BTN2.Text = ""
            BTN3.Text = ""
            BTN4.Text = ""
            BTN5.Text = ""
            BTN6.Text = ""
            BTN7.Text = ""
            BTN8.Text = ""
            BTN9.Text = ""
            BTN1.Enabled = True
            BTN2.Enabled = True
            BTN3.Enabled = True
            BTN4.Enabled = True
            BTN5.Enabled = True
            BTN6.Enabled = True
            BTN7.Enabled = True
            BTN8.Enabled = True
            BTN9.Enabled = True
            LBLGamesPlayed.Visible = True
            GBPlayers.Enabled = True
            If RBSingle.Checked Then
                GBDifficulty.Enabled = True
            End If
            BTNPlay.Visible = False
            LBLAnswer.Visible = False
            Turns = 0
        End If
    End Sub

    Private Sub Reset()
        BTN1.Enabled = False
        BTN2.Enabled = False
        BTN3.Enabled = False
        BTN4.Enabled = False
        BTN5.Enabled = False
        BTN6.Enabled = False
        BTN7.Enabled = False
        BTN8.Enabled = False
        BTN9.Enabled = False
        GBDifficulty.Enabled = False
        GBPlayers.Enabled = False
        BTNPlay.Visible = True
        Turn = "X"
        Turns = 0
    End Sub

    Private Function CheckPosition() As String
        If BTN1.Text = "X" And BTN2.Text = "X" And BTN3.Text = "X" Then
            Reset()
            XWin += 1
            LBLXWins.Text = "X won: " & XWin & " time(s)."
            LBLXWins.Visible = True
            Return "X Won!"
        End If
        If BTN4.Text = "X" And BTN5.Text = "X" And BTN6.Text = "X" Then
            Reset()
            XWin += 1
            LBLXWins.Text = "X won: " & XWin & " time(s)."
            LBLXWins.Visible = True
            Return "X Won!"
        End If
        If BTN7.Text = "X" And BTN8.Text = "X" And BTN9.Text = "X" Then
            Reset()
            XWin += 1
            LBLXWins.Text = "X won: " & XWin & " time(s)."
            LBLXWins.Visible = True
            Return "X Won!"
        End If
        If BTN1.Text = "X" And BTN4.Text = "X" And BTN7.Text = "X" Then
            Reset()
            XWin += 1
            LBLXWins.Text = "X won: " & XWin & " time(s)."
            LBLXWins.Visible = True
            LBLXWins.Visible = True
            Return "X Won!"
        End If
        If BTN2.Text = "X" And BTN5.Text = "X" And BTN8.Text = "X" Then
            Reset()
            XWin += 1
            LBLXWins.Text = "X won: " & XWin & " time(s)."
            LBLXWins.Visible = True
            Return "X Won!"
        End If
        If BTN3.Text = "X" And BTN6.Text = "X" And BTN9.Text = "X" Then
            Reset()
            XWin += 1
            LBLXWins.Text = "X won: " & XWin & " time(s)."
            LBLXWins.Visible = True
            Return "X Won!"
        End If
        If BTN1.Text = "X" And BTN5.Text = "X" And BTN9.Text = "X" Then
            Reset()
            XWin += 1
            LBLXWins.Text = "X won: " & XWin & " time(s)."
            LBLXWins.Visible = True
            Return "X Won!"
        End If
        If BTN3.Text = "X" And BTN5.Text = "X" And BTN7.Text = "X" Then
            Reset()
            XWin += 1
            LBLXWins.Text = "X won: " & XWin & " time(s)."
            LBLXWins.Visible = True
            Return "X Won!"
        End If
        If BTN1.Text = "O" And BTN2.Text = "O" And BTN3.Text = "O" Then
            Reset()
            OWin += 1
            LBLOWins.Text = "O won: " & OWin & " time(s)."
            LBLOWins.Visible = True
            Return "O Won!"
        End If
        If BTN4.Text = "O" And BTN5.Text = "O" And BTN6.Text = "O" Then
            Reset()
            OWin += 1
            LBLOWins.Text = "O won: " & OWin & " time(s)."
            LBLOWins.Visible = True
            Return "O Won!"
        End If
        If BTN7.Text = "O" And BTN8.Text = "O" And BTN9.Text = "O" Then
            Reset()
            OWin += 1
            LBLOWins.Text = "O won: " & OWin & " time(s)."
            LBLOWins.Visible = True
            Return "O Won!"
        End If
        If BTN1.Text = "O" And BTN4.Text = "O" And BTN7.Text = "O" Then
            Reset()
            OWin += 1
            LBLOWins.Text = "O won: " & OWin & " time(s)."
            LBLOWins.Visible = True
            Return "O Won!"
        End If
        If BTN2.Text = "O" And BTN5.Text = "O" And BTN8.Text = "O" Then
            Reset()
            OWin += 1
            LBLOWins.Text = "O won: " & OWin & " time(s)."
            LBLOWins.Visible = True
            Return "O Won!"
        End If
        If BTN3.Text = "O" And BTN6.Text = "O" And BTN9.Text = "O" Then
            Reset()
            OWin += 1
            LBLOWins.Text = "O won: " & OWin & " time(s)."
            LBLOWins.Visible = True
            Return "O Won!"
        End If
        If BTN1.Text = "O" And BTN5.Text = "O" And BTN9.Text = "O" Then
            Reset()
            OWin += 1
            LBLOWins.Text = "O won: " & OWin & " time(s)."
            LBLOWins.Visible = True
            Return "O Won!"
        End If
        If BTN3.Text = "O" And BTN5.Text = "O" And BTN7.Text = "O" Then
            Reset()
            OWin += 1
            LBLOWins.Text = "O won: " & OWin & " time(s)."
            LBLOWins.Visible = True
            Return "O Won!"
        End If
        If Turns >= 9 Then
            Reset()
            'place the reset()
            'NOT WORKING FOR SINGLEPLAYER!' doesnt count the turns somehow...
            Return "ERMAHGERD! TIE!"
        End If
        Return ""
    End Function

    Private Sub BTN1_Click(sender As System.Object, e As System.EventArgs) Handles BTN1.Click
        GBPlayers.Enabled = False
        GBDifficulty.Enabled = False
        Turns += 1
        If RBTwo.Checked Then
            BTN1.Enabled = False
            If Turn = "X" Then
                BTN1.Text = "X"
                Turn = "O"
                LBLAnswer.Text = CheckPosition()
                LBLAnswer.Visible = True
            ElseIf Turn = "O" Then
                BTN1.Text = "O"
                Turn = "X"
                LBLAnswer.Text = CheckPosition()
                LBLAnswer.Visible = True
            End If
        End If
        If RBSingle.Checked Then
            If RBEasy.Checked Then
                BTN1.Text = "X"
                BTN1.Enabled = False
                Turn = "O"
                LBLAnswer.Text = CheckPosition()
                LBLAnswer.Visible = True
                CPUChooseEasy()
            ElseIf RBImpossible.Checked Then
                BTN1.Text = "X"
                BTN1.Enabled = False
                Turn = "O"
                LBLAnswer.Text = CheckPosition()
                LBLAnswer.Visible = True
                CPUChooseImpossible()
            End If
        End If
    End Sub

    Private Sub BTN2_Click(sender As System.Object, e As System.EventArgs) Handles BTN2.Click
        GBPlayers.Enabled = False
        GBDifficulty.Enabled = False
        Turns += 1
        If RBTwo.Checked Then
            BTN2.Enabled = False
            If Turn = "X" Then
                BTN2.Text = "X"
                Turn = "O"
                LBLAnswer.Text = CheckPosition()
                LBLAnswer.Visible = True
            ElseIf Turn = "O" Then
                BTN2.Text = "O"
                Turn = "X"
                LBLAnswer.Text = CheckPosition()
                LBLAnswer.Visible = True
            End If
        End If
        If RBSingle.Checked Then
            If RBEasy.Checked Then
                BTN2.Text = "X"
                BTN2.Enabled = False
                Turn = "O"
                LBLAnswer.Text = CheckPosition()
                LBLAnswer.Visible = True
                CPUChooseEasy()
            ElseIf RBImpossible.Checked Then
                BTN2.Text = "X"
                BTN2.Enabled = False
                Turn = "O"
                LBLAnswer.Text = CheckPosition()
                LBLAnswer.Visible = True
                CPUChooseImpossible()
            End If
        End If
    End Sub

    Private Sub BTN3_Click(sender As System.Object, e As System.EventArgs) Handles BTN3.Click
        GBPlayers.Enabled = False
        GBDifficulty.Enabled = False
        Turns += 1
        If RBTwo.Checked Then
            BTN3.Enabled = False
            If Turn = "X" Then
                BTN3.Text = "X"
                Turn = "O"
                LBLAnswer.Text = CheckPosition()
                LBLAnswer.Visible = True
            ElseIf Turn = "O" Then
                BTN3.Text = "O"
                Turn = "X"
                LBLAnswer.Text = CheckPosition()
                LBLAnswer.Visible = True
            End If
        End If
        If RBSingle.Checked Then
            If RBEasy.Checked Then
                BTN3.Text = "X"
                BTN3.Enabled = False
                Turn = "O"
                LBLAnswer.Text = CheckPosition()
                LBLAnswer.Visible = True
                CPUChooseEasy()
            ElseIf RBImpossible.Checked Then
                BTN3.Text = "X"
                BTN3.Enabled = False
                Turn = "O"
                LBLAnswer.Text = CheckPosition()
                LBLAnswer.Visible = True
                CPUChooseImpossible()
            End If
        End If
    End Sub

    Private Sub BTN4_Click(sender As System.Object, e As System.EventArgs) Handles BTN4.Click
        GBPlayers.Enabled = False
        GBDifficulty.Enabled = False
        Turns += 1
        If RBTwo.Checked Then
            BTN4.Enabled = False
            If Turn = "X" Then
                BTN4.Text = "X"
                Turn = "O"
                LBLAnswer.Text = CheckPosition()
                LBLAnswer.Visible = True
            ElseIf Turn = "O" Then
                BTN4.Text = "O"
                Turn = "X"
                LBLAnswer.Text = CheckPosition()
                LBLAnswer.Visible = True
            End If
        End If
        If RBSingle.Checked Then
            If RBEasy.Checked Then
                BTN4.Text = "X"
                BTN4.Enabled = False
                Turn = "O"
                LBLAnswer.Text = CheckPosition()
                LBLAnswer.Visible = True
                CPUChooseEasy()
            ElseIf RBImpossible.Checked Then
                BTN4.Text = "X"
                BTN4.Enabled = False
                Turn = "O"
                LBLAnswer.Text = CheckPosition()
                LBLAnswer.Visible = True
                CPUChooseImpossible()
            End If
        End If
    End Sub

    Private Sub BTN5_Click(sender As System.Object, e As System.EventArgs) Handles BTN5.Click
        GBPlayers.Enabled = False
        GBDifficulty.Enabled = False
        Turns += 1
        If RBTwo.Checked Then
            BTN5.Enabled = False
            If Turn = "X" Then
                BTN5.Text = "X"
                Turn = "O"
                LBLAnswer.Text = CheckPosition()
                LBLAnswer.Visible = True
            ElseIf Turn = "O" Then
                BTN5.Text = "O"
                Turn = "X"
                LBLAnswer.Text = CheckPosition()
                LBLAnswer.Visible = True
            End If
        End If
        If RBSingle.Checked Then
            If RBEasy.Checked Then
                BTN5.Text = "X"
                BTN5.Enabled = False
                Turn = "O"
                LBLAnswer.Text = CheckPosition()
                LBLAnswer.Visible = True
                CPUChooseEasy()
            ElseIf RBImpossible.Checked Then
                BTN5.Text = "X"
                BTN5.Enabled = False
                Turn = "O"
                LBLAnswer.Text = CheckPosition()
                LBLAnswer.Visible = True
                CPUChooseImpossible()
            End If
        End If
    End Sub

    Private Sub BTN6_Click(sender As System.Object, e As System.EventArgs) Handles BTN6.Click
        GBPlayers.Enabled = False
        GBDifficulty.Enabled = False
        Turns += 1
        If RBTwo.Checked Then
            BTN6.Enabled = False
            If Turn = "X" Then
                BTN6.Text = "X"
                Turn = "O"
                LBLAnswer.Text = CheckPosition()
                LBLAnswer.Visible = True
            ElseIf Turn = "O" Then
                BTN6.Text = "O"
                Turn = "X"
                LBLAnswer.Text = CheckPosition()
                LBLAnswer.Visible = True
            End If
        End If
        If RBSingle.Checked Then
            If RBEasy.Checked Then
                BTN6.Text = "X"
                BTN6.Enabled = False
                Turn = "O"
                LBLAnswer.Text = CheckPosition()
                LBLAnswer.Visible = True
                CPUChooseEasy()
            ElseIf RBImpossible.Checked Then
                BTN6.Text = "X"
                BTN6.Enabled = False
                Turn = "O"
                LBLAnswer.Text = CheckPosition()
                LBLAnswer.Visible = True
                CPUChooseImpossible()
            End If
        End If
    End Sub

    Private Sub BTN7_Click(sender As System.Object, e As System.EventArgs) Handles BTN7.Click
        GBPlayers.Enabled = False
        GBDifficulty.Enabled = False
        Turns += 1
        If RBTwo.Checked Then
            BTN7.Enabled = False
            If Turn = "X" Then
                BTN7.Text = "X"
                Turn = "O"
                LBLAnswer.Text = CheckPosition()
                LBLAnswer.Visible = True
            ElseIf Turn = "O" Then
                BTN7.Text = "O"
                Turn = "X"
                LBLAnswer.Text = CheckPosition()
                LBLAnswer.Visible = True
            End If
        End If
        If RBSingle.Checked Then
            If RBEasy.Checked Then
                BTN7.Text = "X"
                BTN7.Enabled = False
                Turn = "O"
                LBLAnswer.Text = CheckPosition()
                LBLAnswer.Visible = True
                CPUChooseEasy()
            ElseIf RBImpossible.Checked Then
                BTN7.Text = "X"
                BTN7.Enabled = False
                Turn = "O"
                LBLAnswer.Text = CheckPosition()
                LBLAnswer.Visible = True
                CPUChooseImpossible()
            End If
        End If
    End Sub

    Private Sub BTN8_Click(sender As System.Object, e As System.EventArgs) Handles BTN8.Click
        GBPlayers.Enabled = False
        GBDifficulty.Enabled = False
        Turns += 1
        If RBTwo.Checked Then
            BTN8.Enabled = False
            If Turn = "X" Then
                BTN8.Text = "X"
                Turn = "O"
                LBLAnswer.Text = CheckPosition()
                LBLAnswer.Visible = True
            ElseIf Turn = "O" Then
                BTN8.Text = "O"
                Turn = "X"
                LBLAnswer.Text = CheckPosition()
                LBLAnswer.Visible = True
            End If
        End If
        If RBSingle.Checked Then
            If RBEasy.Checked Then
                BTN8.Text = "X"
                BTN8.Enabled = False
                Turn = "O"
                LBLAnswer.Text = CheckPosition()
                LBLAnswer.Visible = True
                CPUChooseEasy()
            ElseIf RBImpossible.Checked Then
                BTN8.Text = "X"
                BTN8.Enabled = False
                Turn = "O"
                LBLAnswer.Text = CheckPosition()
                LBLAnswer.Visible = True
                CPUChooseImpossible()
            End If
        End If
    End Sub

    Private Sub BTN9_Click(sender As System.Object, e As System.EventArgs) Handles BTN9.Click
        GBPlayers.Enabled = False
        GBDifficulty.Enabled = False
        Turns += 1
        If RBTwo.Checked Then
            BTN9.Enabled = False
            If Turn = "X" Then
                BTN9.Text = "X"
                Turn = "O"
                LBLAnswer.Text = CheckPosition()
                LBLAnswer.Visible = True
            ElseIf Turn = "O" Then
                BTN9.Text = "O"
                Turn = "X"
                LBLAnswer.Text = CheckPosition()
                LBLAnswer.Visible = True
            End If
        End If
        If RBSingle.Checked Then
            If RBEasy.Checked Then
                BTN9.Text = "X"
                BTN9.Enabled = False
                Turn = "O"
                LBLAnswer.Text = CheckPosition()
                LBLAnswer.Visible = True
                CPUChooseEasy()
            ElseIf RBImpossible.Checked Then
                BTN9.Text = "X"
                BTN9.Enabled = False
                Turn = "O"
                LBLAnswer.Text = CheckPosition()
                LBLAnswer.Visible = True
                CPUChooseImpossible()
            End If
        End If
    End Sub
End Class
