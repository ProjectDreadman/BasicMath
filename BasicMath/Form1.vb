Public Class Form1
    Dim num1 As Decimal
    Dim num2 As Decimal
    Dim Answer As Decimal
    Private Sub extBnt_Click(sender As Object, e As EventArgs) Handles extBnt.Click
        Application.Exit()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnAdding_Click(sender As Object, e As EventArgs) Handles BtnAdding.Click
        num1 = txt1.Text
        num2 = txt2.Text
        Answer = num1 + num2
        txtAnswer.Text = Answer
    End Sub

    Private Sub btnSubtract_Click(sender As Object, e As EventArgs) Handles btnSubtract.Click
        num1 = txt1.Text
        num2 = txt2.Text
        Answer = num1 - num2
        txtAnswer.Text = Answer
    End Sub

    Private Sub btnMutiplcation_Click(sender As Object, e As EventArgs) Handles btnMutiplcation.Click
        num1 = txt1.Text
        num2 = txt2.Text
        Answer = num1 * num2
        txtAnswer.Text = Answer
    End Sub

    Private Sub btnDivide_Click(sender As Object, e As EventArgs) Handles btnDivide.Click
        num1 = txt1.Text
        num2 = txt2.Text
        Answer = num1 / num2
        txtAnswer.Text = Answer
    End Sub

    Private Sub txt1_TextChanged(sender As Object, e As EventArgs) Handles txt1.TextChanged

    End Sub

    Private Sub txt2_TextChanged(sender As Object, e As EventArgs) Handles txt2.TextChanged

    End Sub

    Private Sub txtAnswer_TextChanged(sender As Object, e As EventArgs) Handles txtAnswer.TextChanged

    End Sub
End Class