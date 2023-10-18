Public Class Form1
    Private Sub btnAddition_Click(sender As Object, e As EventArgs) Handles btnAddition.Click
        Try
            Dim Operand1 As Double
            Dim Operand2 As Double
            Dim Result As Double

            Operand1 = CDbl(txtOperand1.Text)
            Operand2 = CDbl(txtOperand2.Text)
            Result = Operand1 + Operand2

            lblShowOperator.Text = "+'"
            lblShowResult.Text = Result.ToString("N")
        Catch
            lblShowResult.Text = "Error"
        End Try

    End Sub

    Private Sub btnSubstraction_Click(sender As Object, e As EventArgs) Handles btnSubstraction.Click
        Try
            Dim Operand1 As Double
            Dim Operand2 As Double
            Dim Result2 As Double

            Operand1 = CDbl(txtOperand1.Text)
            Operand2 = CDbl(txtOperand2.Text)
            Result2 = Operand1 - Operand2

            lblShowOperator.Text = "-'"
            lblShowResult.Text = Result2.ToString("N")
        Catch
            lblShowResult.Text = "Error"
        End Try

    End Sub

    Private Sub btnMultiplication_Click(sender As Object, e As EventArgs) Handles btnMultiplication.Click
        Try
            Dim Operand1 As Double
            Dim Operand2 As Double
            Dim Result2 As Double

            Operand1 = CDbl(txtOperand1.Text)
            Operand2 = CDbl(txtOperand2.Text)
            Result2 = Operand1 * Operand2

            lblShowOperator.Text = "*"
            lblShowResult.Text = Result2.ToString("N")
        Catch
            lblShowResult.Text = "Error"
        End Try

    End Sub

    Private Sub btnIntegerDivision_Click(sender As Object, e As EventArgs) Handles btnIntegerDivision.Click
        Try
            Dim Operand1 As Double
            Dim Operand2 As Double
            Dim Result2 As Double

            Operand1 = CDbl(txtOperand1.Text)
            Operand2 = CDbl(txtOperand2.Text)
            Result2 = Operand1 \ Operand2

            lblShowOperator.Text = "\"
            lblShowResult.Text = Result2.ToString("N")
        Catch
            lblShowResult.Text = "Error"
        End Try

    End Sub

    Private Sub btnFloatingPoint_Click(sender As Object, e As EventArgs) Handles btnFloatingPoint.Click
        Try
            Dim Operand1 As Double
            Dim Operand2 As Double
            Dim Result2 As Double

            Operand1 = CDbl(txtOperand1.Text)
            Operand2 = CDbl(txtOperand2.Text)
            Result2 = Operand1 / Operand2

            lblShowOperator.Text = "/"
            lblShowResult.Text = Result2.ToString("N")
        Catch
            lblShowResult.Text = "Error"
        End Try

    End Sub

    Private Sub btnExponentiation_Click(sender As Object, e As EventArgs) Handles btnExponentiation.Click
        Try
            Dim Operand1 As Double
            Dim Operand2 As Double
            Dim Result2 As Double

            Operand1 = CDbl(txtOperand1.Text)
            Operand2 = CDbl(txtOperand2.Text)
            Result2 = Operand1 ^ Operand2

            lblShowOperator.Text = "^"
            lblShowResult.Text = Result2.ToString("N")
        Catch
            lblShowResult.Text = "Error"
        End Try

    End Sub

    Private Sub btnModulus_Click(sender As Object, e As EventArgs) Handles btnModulus.Click
        Try
            Dim Operand1 As Double
            Dim Operand2 As Double
            Dim Result2 As Double

            Operand1 = CDbl(txtOperand1.Text)
            Operand2 = CDbl(txtOperand2.Text)
            Result2 = Operand1 Mod Operand2

            lblShowOperator.Text = "MOD"
            lblShowResult.Text = Result2.ToString("N")
        Catch
            lblShowResult.Text = "Error"
        End Try

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtOperand1.Clear()
        txtOperand2.Clear()
        lblShowOperator.Text = ""

        txtOperand1.Focus()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        MessageBox.Show("This is a smple calculator")

    End Sub
End Class
