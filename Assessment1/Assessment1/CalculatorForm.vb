Public Class CalculatorForm

    Private decOperand1 As Decimal = 0
    Private decOperand2 As Decimal = 0
    Private decOperand3 As Decimal = 0
    Private decTemp As Decimal = 0
    Private decTotal As Decimal = 0
    Private decMaxValue As Decimal = 9999999999999999
    Private strOperator As String = String.Empty
    Private boolNewNumber As Boolean = True

    Private Sub AddDisplay(ByVal strNum As String)
        If lblDisplay.Text = 0 Then
            lblDisplay.Text = String.Empty
        End If

        If boolNewNumber = True Then
            boolNewNumber = False
            lblDisplay.Text = String.Empty
        End If

        lblDisplay.Text = lblDisplay.Text & strNum
    End Sub

    Private Sub Calculate(ByVal strOp As String)
        decOperand2 = lblDisplay.Text

        If decTotal = decOperand2 Then
            decTemp = decTotal
            Select Case strOp
                Case "+"
                    decTotal += decOperand3
                Case "-"
                    decTotal -= decOperand3
                Case "*"
                    decTotal *= decOperand3
                Case "/"
                    decTotal /= decOperand3
            End Select
        Else
            Select Case strOp
                Case "+"
                    decTotal = decOperand1 + decOperand2
                Case "-"
                    decTotal = decOperand1 - decOperand2
                Case "*"
                    decTotal = decOperand1 * decOperand2
                Case "/"
                    decTotal = decOperand1 / decOperand2
            End Select
        End If

        strOperator = strOp
        decOperand1 = decOperand2
        If decTemp <> decOperand2 Then
            decOperand3 = decOperand1
        End If
    End Sub

    Private Sub BtnNum7_Click(sender As Object, e As EventArgs) Handles BtnNum7.Click
        AddDisplay(7)
    End Sub

    Private Sub BtnNum8_Click(sender As Object, e As EventArgs) Handles BtnNum8.Click
        AddDisplay(8)
    End Sub

    Private Sub BtnNum9_Click(sender As Object, e As EventArgs) Handles BtnNum9.Click
        AddDisplay(9)
    End Sub

    Private Sub BtnNum4_Click(sender As Object, e As EventArgs) Handles BtnNum4.Click
        AddDisplay(4)
    End Sub

    Private Sub BtnNum5_Click(sender As Object, e As EventArgs) Handles BtnNum5.Click
        AddDisplay(5)
    End Sub

    Private Sub BtnNum6_Click(sender As Object, e As EventArgs) Handles BtnNum6.Click
        AddDisplay(6)
    End Sub

    Private Sub BtnNum1_Click(sender As Object, e As EventArgs) Handles BtnNum1.Click
        AddDisplay(1)
    End Sub

    Private Sub BtnNum2_Click(sender As Object, e As EventArgs) Handles BtnNum2.Click
        AddDisplay(2)
    End Sub

    Private Sub BtnNum3_Click(sender As Object, e As EventArgs) Handles BtnNum3.Click
        AddDisplay(3)
    End Sub

    Private Sub BtnNum0_Click(sender As Object, e As EventArgs) Handles BtnNum0.Click
        AddDisplay(0)
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        decOperand1 = 0
        decOperand2 = 0
        strOperator = String.Empty
        decTotal = 0
        lblDisplay.Text = 0
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        boolNewNumber = True
        Calculate("+")
    End Sub

    Private Sub BtnSubtract_Click(sender As Object, e As EventArgs) Handles BtnSubtract.Click
        boolNewNumber = True
        Calculate("-")
    End Sub

    Private Sub BtnMultiplicate_Click(sender As Object, e As EventArgs) Handles BtnMultiplicate.Click
        boolNewNumber = True
        Calculate("*")
    End Sub

    Private Sub BtnDivide_Click(sender As Object, e As EventArgs) Handles BtnDivide.Click
        boolNewNumber = True
        Calculate("/")
    End Sub

    Private Sub BtnEqual_Click(sender As Object, e As EventArgs) Handles BtnEqual.Click
        Calculate(strOperator)
        lblDisplay.Text = decTotal
        If decTotal > decMaxValue Then
            MessageBox.Show(Me, "Value exceeds maximum value", "Error", MessageBoxButtons.OK)
        End If
    End Sub
End Class
