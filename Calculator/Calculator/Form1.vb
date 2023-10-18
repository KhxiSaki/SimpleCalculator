Public Class Form1
    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles lblShowResult.Click

    End Sub

    Private Sub TXOperand2_TextChanged(sender As Object, e As EventArgs) Handles txtOperand2.TextChanged

    End Sub

    Private Sub btnAddition_Click(sender As Object, e As EventArgs) Handles btnAddition.Click
        Dim Operand1 As Double
        Dim Operand2 As Double
        Dim Result As Double

        Operand1 = CDbl(txtOperand1.Text)
        Operand2 = CDbl(txtOperand2.Text)
        Result = Operand1 + Operand2

        lblShowOperator.Text = "+'"
        lblShowResult.Text = Result.ToString("N")

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles lblOperand1.Click

    End Sub

    Private Sub btnSubstraction_Click(sender As Object, e As EventArgs) Handles btnSubstraction.Click
        Dim Operand1 As Double
        Dim Operand2 As Double
        Dim Result2 As Double

        Operand1 = CDbl(txtOperand1.Text)
        Operand2 = CDbl(txtOperand2.Text)
        Result2 = Operand1 - Operand2

        lblShowOperator.Text = "-'"
        lblShowResult.Text = Result2.ToString("N")

    End Sub

    Private Sub btnMultiplication_Click(sender As Object, e As EventArgs) Handles btnMultiplication.Click
        Dim Operand1 As Double
        Dim Operand2 As Double
        Dim Result2 As Double

        Operand1 = CDbl(txtOperand1.Text)
        Operand2 = CDbl(txtOperand2.Text)
        Result2 = Operand1 * Operand2

        lblShowOperator.Text = "*"
        lblShowResult.Text = Result2.ToString("N")
    End Sub

    Private Sub btnIntegerDivision_Click(sender As Object, e As EventArgs) Handles btnIntegerDivision.Click
        Dim Operand1 As Double
        Dim Operand2 As Double
        Dim Result2 As Double

        Operand1 = CDbl(txtOperand1.Text)
        Operand2 = CDbl(txtOperand2.Text)
        Result2 = Operand1 \ Operand2

        lblShowOperator.Text = "\"
        lblShowResult.Text = Result2.ToString("N")
    End Sub

    Private Sub btnFloatingPoint_Click(sender As Object, e As EventArgs) Handles btnFloatingPoint.Click
        Dim Operand1 As Double
        Dim Operand2 As Double
        Dim Result2 As Double

        Operand1 = CDbl(txtOperand1.Text)
        Operand2 = CDbl(txtOperand2.Text)
        Result2 = Operand1 / Operand2

        lblShowOperator.Text = "/"
        lblShowResult.Text = Result2.ToString("N")
    End Sub

    Private Sub btnExponentiation_Click(sender As Object, e As EventArgs) Handles btnExponentiation.Click
        Dim Operand1 As Double
        Dim Operand2 As Double
        Dim Result2 As Double

        Operand1 = CDbl(txtOperand1.Text)
        Operand2 = CDbl(txtOperand2.Text)
        Result2 = Operand1 ^ Operand2

        lblShowOperator.Text = "^"
        lblShowResult.Text = Result2.ToString("N")
    End Sub

    Private Sub btnModulus_Click(sender As Object, e As EventArgs) Handles btnModulus.Click
        Dim Operand1 As Double
        Dim Operand2 As Double
        Dim Result2 As Double

        Operand1 = CDbl(txtOperand1.Text)
        Operand2 = CDbl(txtOperand2.Text)
        Result2 = Operand1 Mod Operand2

        lblShowOperator.Text = "MOD"
        lblShowResult.Text = Result2.ToString("N")
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtOperand1.Clear()
        txtOperand2.Clear()
        lblShowResult.Text = ""

        txtOperand1.Focus()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub
End Class
