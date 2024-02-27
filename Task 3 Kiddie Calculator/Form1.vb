Public Class Form1
    'Kiddie Calculator Task 2 - Dario Gerald

    Private Sub btnMinus_Click(sender As Object, e As EventArgs) Handles btnMinus.Click
        txtAnswer.Text = Val(txtNumber1.Text) + Val(txtNumber2.Text)
        'This code is a simple code that gets two values (to ensure that it does not take strings) and adds them'
    End Sub

    Private Sub btnMultiply_Click(sender As Object, e As EventArgs) Handles btnMultiply.Click
        txtAnswer.Text = Val(txtNumber1.Text) - Val(txtNumber2.Text)
        'This is a similar process to the adition but it subtracts the integers'
    End Sub

    Private Sub btnDivide_Click(sender As Object, e As EventArgs) Handles btnDivide.Click
        txtAnswer.Text = Val(txtNumber1.Text) * Val(txtNumber2.Text)
        'Again, another similar process but it multiplies the two nubmers'

    End Sub

    Private Sub btnPlus_Click(sender As Object, e As EventArgs) Handles btnPlus.Click
        txtAnswer.Text = Val(txtNumber1.Text) / Val(txtNumber2.Text)
        'Finally, it is the same process but it divides'
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtAnswer.Clear()
        'First of all, I tried to clear just the answer, but that wouldn't be the most accessibly pleasing'
        txtNumber1.Clear()
        'So I then deiced that text box 1 needed to be cleared'
        txtNumber2.Clear()
        'And text box 2. '
    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        End
        'Very simple end function that has been repeatedly been used in other tasks as well.'
        'Quite a straightforward function'
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        'I didn't need any code for the image. '
    End Sub

    Private Sub MsgBox_Click(sender As Object, e As EventArgs) Handles textbox5.Click
        MsgBox("Instruction:" & vbCrLf & "1. Type a number into the first box" & vbCrLf & "2. Type anothe rnumber into the second box" & vbCrLf & "3. Click on the oprtation of your choice" & vbCrLf & "4. Click 'Clear', then go to Step 1, or click 'quit'")
        'This is a function that writes new lines of code in a new window instance when the help button is clicked. The vbCrLf make the text on a new line'
    End Sub

    Private Sub txtAnswer_TextChanged(sender As Object, e As EventArgs) Handles txtAnswer.TextChanged

    End Sub
End Class
