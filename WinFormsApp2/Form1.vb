Public Class Form1
    Public numberOfMoves As Integer = 0
    Private Sub startBtn_Click(sender As Object, e As EventArgs) Handles startBtn.Click
        Randomize()
        Dim temp As Integer
        Dim tempIndex(8) As Image
        Dim counter = 0
        btn3.Image = My.Resources.image_part_003_4_11zon


        While counter < 8
            temp = Rnd() * 7
            If IsNothing(tempIndex(temp)) Then
                tempIndex(temp) = pictures(counter)
                counter += 1
            End If
        End While

        For i = 0 To 7
            containers(i).Image = tempIndex(i)
        Next

        For i = 0 To 7
            containers(i).Enabled = True
        Next
        btn3.Enabled = True
        temporary.Enabled = True

        Moves.Text = "Number of Moves: " & numberOfMoves
        startBtn.Enabled = False


    End Sub


    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        moveImageWith2Moves(btn1, btn2, btn4)
    End Sub
    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        moveImageWith3Moves(btn2, btn1, btn3, btn5)
    End Sub
    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        moveImageWith3Moves(btn3, temporary, btn2, btn6)
    End Sub
    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        moveImageWith3Moves(btn4, btn1, btn5, btn7)
    End Sub
    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        moveImageWith4Moves(btn5, btn2, btn4, btn6, btn8)

    End Sub
    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        moveImageWith3Moves(btn6, btn3, btn5, btn9)
    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        moveImageWith2Moves(btn7, btn4, btn8)
    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        moveImageWith3Moves(btn8, btn7, btn5, btn9)
    End Sub

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        moveImageWith2Moves(btn9, btn6, btn8)
    End Sub

    Function moveImageWith2Moves(currentBtn As Button, mov1 As Button, mov2 As Button)
        If IsNothing(mov1.Image) Then
            mov1.Image = currentBtn.Image
            currentBtn.Image = Nothing
            numberOfMoves += 1
        ElseIf IsNothing(mov2.Image) Then
            mov2.Image = currentBtn.Image
            currentBtn.Image = Nothing
            numberOfMoves += 1
        End If
        wincheck()
        Moves.Text = "Number of Moves: " & numberOfMoves
    End Function

    Function moveImageWith3Moves(currentBtn As Button, mov1 As Button, mov2 As Button, mov3 As Button)
        If IsNothing(mov1.Image) Then
            mov1.Image = currentBtn.Image
            currentBtn.Image = Nothing
            numberOfMoves += 1
        ElseIf IsNothing(mov2.Image) Then
            mov2.Image = currentBtn.Image
            currentBtn.Image = Nothing
            numberOfMoves += 1
        ElseIf IsNothing(mov3.Image) Then
            mov3.Image = currentBtn.Image
            currentBtn.Image = Nothing
            numberOfMoves += 1
        End If
        wincheck()
        Moves.Text = "Number of Moves: " & numberOfMoves
    End Function


    Function moveImageWith4Moves(currentBtn As Button, mov1 As Button, mov2 As Button, mov3 As Button, mov4 As Button)
        If IsNothing(mov1.Image) Then
            mov1.Image = currentBtn.Image
            currentBtn.Image = Nothing
            numberOfMoves += 1
        ElseIf IsNothing(mov2.Image) Then
            mov2.Image = currentBtn.Image
            currentBtn.Image = Nothing
            numberOfMoves += 1
        ElseIf IsNothing(mov3.Image) Then
            mov3.Image = currentBtn.Image
            currentBtn.Image = Nothing
            numberOfMoves += 1
        ElseIf IsNothing(mov4.Image) Then
            mov4.Image = currentBtn.Image
            currentBtn.Image = Nothing
            numberOfMoves += 1
        End If
        wincheck()
        Moves.Text = "Number of Moves: " & numberOfMoves
    End Function

    Private Sub temporary_Click(sender As Object, e As EventArgs) Handles temporary.Click
        If IsNothing(btn3.Image) Then
            btn3.Image = temporary.Image
            temporary.Image = Nothing
            numberOfMoves += 1
        End If
        wincheck()
        Moves.Text = "Number of Moves: " & numberOfMoves
    End Sub

    Function wincheck()
        If pictures(0).Equals(containers(0).Image) And pictures(1).Equals(containers(1).Image) And pictures(3).Equals(containers(3).Image) And pictures(4).Equals(containers(4).Image) And pictures(5).Equals(containers(5).Image) And pictures(6).Equals(containers(6).Image) And pictures(7).Equals(containers(7).Image) and isnothing(temporary.Image)Then
            MsgBox("Congrats! You've completed the Puzzle with only " & numberOfMoves & " Moves!")
            startBtn.Text = "Play Again?"
            startBtn.Enabled = True
            numberOfMoves = 0
        End If
    End Function

    Private Sub Cheat_Click(sender As Object, e As EventArgs) Handles Cheat.Click
        For i = 0 To 7
            containers(i).Image = pictures(i)
        Next
        btn3.Image = Nothing
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For i = 0 To 7
            containers(i).Enabled = False
        Next
        btn3.Enabled = False
        temporary.Enabled = False

    End Sub
End Class
