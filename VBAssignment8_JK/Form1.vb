Imports System.Drawing.Text

Public Class Form1
    Dim arrRainfall(11) As Double
    Dim arrMonths = New String() {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"}
    Dim X = -1
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If Validation(txtRainfall.Text) = False Then
            MessageBox.Show("Please input a number greater than 0")
            Exit Sub
        End If

        Call Record()

        Call End_Check()
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim dblTotalRainfall
        Dim dblAverageRainfall
        Dim strMostRainfall
        Dim strLeastRainfall

        Call Total_and_Average_Rainfall(dblTotalRainfall, dblAverageRainfall)

        Call Most_Rainfall(strMostRainfall)

        Call Least_Rainfall(strLeastRainfall)

        Call Display(dblTotalRainfall, strMostRainfall, strLeastRainfall, dblAverageRainfall)

    End Sub

    Private Function Validation(ByVal strInput)
        If IsNumeric(strInput) = True Then
            If strInput > 0 Then
                Return True
            Else
                Return False
            End If
        Else
            Return False
        End If
    End Function

    Private Sub Record()
        X += 1
        arrRainfall(X) = txtRainfall.Text
        lstRainfall.Items.Add(arrMonths(X) & " - " & arrRainfall(X) & " inches")
    End Sub

    Private Sub End_Check()
        If X = 11 Then
            X = -1
            btnSubmit.Enabled = False
            btnCalculate.Enabled = True
        End If
    End Sub

    Private Sub Total_and_Average_Rainfall(ByRef dblTotalRainfall, ByRef dblAverageRainfall)
        For Each intNum In arrRainfall
            X += 1
            dblTotalRainfall += arrRainfall(X)
            dblAverageRainfall = dblTotalRainfall / 12
        Next
    End Sub

    Private Sub Most_Rainfall(ByRef strMostRainfall)
        If arrRainfall(0) > arrRainfall(1) And arrRainfall(0) > arrRainfall(2) And arrRainfall(0) > arrRainfall(3) And arrRainfall(0) > arrRainfall(4) And arrRainfall(0) > arrRainfall(5) And arrRainfall(0) > arrRainfall(6) And arrRainfall(0) > arrRainfall(7) And arrRainfall(0) > arrRainfall(8) And arrRainfall(0) > arrRainfall(9) And arrRainfall(0) > arrRainfall(10) And arrRainfall(0) > arrRainfall(11) Then
            strMostRainfall = arrMonths(0)
        ElseIf arrRainfall(1) > arrRainfall(0) And arrRainfall(1) > arrRainfall(2) And arrRainfall(1) > arrRainfall(3) And arrRainfall(1) > arrRainfall(4) And arrRainfall(1) > arrRainfall(5) And arrRainfall(1) > arrRainfall(6) And arrRainfall(1) > arrRainfall(7) And arrRainfall(1) > arrRainfall(8) And arrRainfall(1) > arrRainfall(9) And arrRainfall(1) > arrRainfall(10) And arrRainfall(1) > arrRainfall(11) Then
            strMostRainfall = arrMonths(1)
        ElseIf arrRainfall(2) > arrRainfall(1) And arrRainfall(2) > arrRainfall(0) And arrRainfall(2) > arrRainfall(3) And arrRainfall(2) > arrRainfall(4) And arrRainfall(2) > arrRainfall(5) And arrRainfall(2) > arrRainfall(6) And arrRainfall(2) > arrRainfall(7) And arrRainfall(2) > arrRainfall(8) And arrRainfall(2) > arrRainfall(9) And arrRainfall(2) > arrRainfall(10) And arrRainfall(2) > arrRainfall(11) Then
            strMostRainfall = arrMonths(2)
        ElseIf arrRainfall(3) > arrRainfall(1) And arrRainfall(3) > arrRainfall(2) And arrRainfall(3) > arrRainfall(0) And arrRainfall(3) > arrRainfall(4) And arrRainfall(3) > arrRainfall(5) And arrRainfall(3) > arrRainfall(6) And arrRainfall(3) > arrRainfall(7) And arrRainfall(3) > arrRainfall(8) And arrRainfall(3) > arrRainfall(9) And arrRainfall(3) > arrRainfall(10) And arrRainfall(3) > arrRainfall(11) Then
            strMostRainfall = arrMonths(3)
        ElseIf arrRainfall(4) > arrRainfall(1) And arrRainfall(4) > arrRainfall(2) And arrRainfall(4) > arrRainfall(3) And arrRainfall(4) > arrRainfall(0) And arrRainfall(4) > arrRainfall(5) And arrRainfall(4) > arrRainfall(6) And arrRainfall(4) > arrRainfall(7) And arrRainfall(4) > arrRainfall(8) And arrRainfall(4) > arrRainfall(9) And arrRainfall(4) > arrRainfall(10) And arrRainfall(4) > arrRainfall(11) Then
            strMostRainfall = arrMonths(4)
        ElseIf arrRainfall(5) > arrRainfall(1) And arrRainfall(5) > arrRainfall(2) And arrRainfall(5) > arrRainfall(3) And arrRainfall(5) > arrRainfall(4) And arrRainfall(5) > arrRainfall(0) And arrRainfall(5) > arrRainfall(6) And arrRainfall(5) > arrRainfall(7) And arrRainfall(5) > arrRainfall(8) And arrRainfall(5) > arrRainfall(9) And arrRainfall(5) > arrRainfall(10) And arrRainfall(5) > arrRainfall(11) Then
            strMostRainfall = arrMonths(5)
        ElseIf arrRainfall(6) > arrRainfall(1) And arrRainfall(6) > arrRainfall(2) And arrRainfall(6) > arrRainfall(3) And arrRainfall(6) > arrRainfall(4) And arrRainfall(6) > arrRainfall(5) And arrRainfall(6) > arrRainfall(0) And arrRainfall(6) > arrRainfall(7) And arrRainfall(6) > arrRainfall(8) And arrRainfall(6) > arrRainfall(9) And arrRainfall(6) > arrRainfall(10) And arrRainfall(6) > arrRainfall(11) Then
            strMostRainfall = arrMonths(6)
        ElseIf arrRainfall(7) > arrRainfall(1) And arrRainfall(7) > arrRainfall(2) And arrRainfall(7) > arrRainfall(3) And arrRainfall(7) > arrRainfall(4) And arrRainfall(7) > arrRainfall(5) And arrRainfall(7) > arrRainfall(6) And arrRainfall(7) > arrRainfall(0) And arrRainfall(7) > arrRainfall(8) And arrRainfall(7) > arrRainfall(9) And arrRainfall(7) > arrRainfall(10) And arrRainfall(7) > arrRainfall(11) Then
            strMostRainfall = arrMonths(7)
        ElseIf arrRainfall(8) > arrRainfall(1) And arrRainfall(8) > arrRainfall(2) And arrRainfall(8) > arrRainfall(3) And arrRainfall(8) > arrRainfall(4) And arrRainfall(8) > arrRainfall(5) And arrRainfall(8) > arrRainfall(6) And arrRainfall(8) > arrRainfall(7) And arrRainfall(8) > arrRainfall(0) And arrRainfall(8) > arrRainfall(9) And arrRainfall(8) > arrRainfall(10) And arrRainfall(8) > arrRainfall(11) Then
            strMostRainfall = arrMonths(8)
        ElseIf arrRainfall(9) > arrRainfall(1) And arrRainfall(9) > arrRainfall(2) And arrRainfall(9) > arrRainfall(3) And arrRainfall(9) > arrRainfall(4) And arrRainfall(9) > arrRainfall(5) And arrRainfall(9) > arrRainfall(6) And arrRainfall(9) > arrRainfall(7) And arrRainfall(9) > arrRainfall(8) And arrRainfall(9) > arrRainfall(0) And arrRainfall(9) > arrRainfall(10) And arrRainfall(9) > arrRainfall(11) Then
            strMostRainfall = arrMonths(9)
        ElseIf arrRainfall(10) > arrRainfall(1) And arrRainfall(10) > arrRainfall(2) And arrRainfall(10) > arrRainfall(3) And arrRainfall(10) > arrRainfall(4) And arrRainfall(10) > arrRainfall(5) And arrRainfall(10) > arrRainfall(6) And arrRainfall(10) > arrRainfall(7) And arrRainfall(10) > arrRainfall(8) And arrRainfall(10) > arrRainfall(9) And arrRainfall(10) > arrRainfall(0) And arrRainfall(10) > arrRainfall(11) Then
            strMostRainfall = arrMonths(10)
        ElseIf arrRainfall(11) > arrRainfall(1) And arrRainfall(11) > arrRainfall(2) And arrRainfall(11) > arrRainfall(3) And arrRainfall(11) > arrRainfall(4) And arrRainfall(11) > arrRainfall(5) And arrRainfall(11) > arrRainfall(6) And arrRainfall(11) > arrRainfall(7) And arrRainfall(11) > arrRainfall(8) And arrRainfall(11) > arrRainfall(9) And arrRainfall(11) > arrRainfall(10) And arrRainfall(11) > arrRainfall(0) Then
            strMostRainfall = arrMonths(11)
        End If
    End Sub

    Private Sub Least_Rainfall(ByRef strLeastRainfall)
        If arrRainfall(0) < arrRainfall(1) And arrRainfall(0) < arrRainfall(2) And arrRainfall(0) < arrRainfall(3) And arrRainfall(0) < arrRainfall(4) And arrRainfall(0) < arrRainfall(5) And arrRainfall(0) < arrRainfall(6) And arrRainfall(0) < arrRainfall(7) And arrRainfall(0) < arrRainfall(8) And arrRainfall(0) < arrRainfall(9) And arrRainfall(0) < arrRainfall(10) And arrRainfall(0) < arrRainfall(11) Then
            strLeastRainfall = arrMonths(0)
        ElseIf arrRainfall(1) < arrRainfall(0) And arrRainfall(1) < arrRainfall(2) And arrRainfall(1) < arrRainfall(3) And arrRainfall(1) < arrRainfall(4) And arrRainfall(1) < arrRainfall(5) And arrRainfall(1) < arrRainfall(6) And arrRainfall(1) < arrRainfall(7) And arrRainfall(1) < arrRainfall(8) And arrRainfall(1) < arrRainfall(9) And arrRainfall(1) < arrRainfall(10) And arrRainfall(1) < arrRainfall(11) Then
            strLeastRainfall = arrMonths(1)
        ElseIf arrRainfall(2) < arrRainfall(1) And arrRainfall(2) < arrRainfall(0) And arrRainfall(2) < arrRainfall(3) And arrRainfall(2) < arrRainfall(4) And arrRainfall(2) < arrRainfall(5) And arrRainfall(2) < arrRainfall(6) And arrRainfall(2) < arrRainfall(7) And arrRainfall(2) < arrRainfall(8) And arrRainfall(2) < arrRainfall(9) And arrRainfall(2) < arrRainfall(10) And arrRainfall(2) < arrRainfall(11) Then
            strLeastRainfall = arrMonths(2)
        ElseIf arrRainfall(3) < arrRainfall(1) And arrRainfall(3) < arrRainfall(2) And arrRainfall(3) < arrRainfall(0) And arrRainfall(3) < arrRainfall(4) And arrRainfall(3) < arrRainfall(5) And arrRainfall(3) < arrRainfall(6) And arrRainfall(3) < arrRainfall(7) And arrRainfall(3) < arrRainfall(8) And arrRainfall(3) < arrRainfall(9) And arrRainfall(3) < arrRainfall(10) And arrRainfall(3) < arrRainfall(11) Then
            strLeastRainfall = arrMonths(3)
        ElseIf arrRainfall(4) < arrRainfall(1) And arrRainfall(4) < arrRainfall(2) And arrRainfall(4) < arrRainfall(3) And arrRainfall(4) < arrRainfall(0) And arrRainfall(4) < arrRainfall(5) And arrRainfall(4) < arrRainfall(6) And arrRainfall(4) < arrRainfall(7) And arrRainfall(4) < arrRainfall(8) And arrRainfall(4) < arrRainfall(9) And arrRainfall(4) < arrRainfall(10) And arrRainfall(4) < arrRainfall(11) Then
            strLeastRainfall = arrMonths(4)
        ElseIf arrRainfall(5) < arrRainfall(1) And arrRainfall(5) < arrRainfall(2) And arrRainfall(5) < arrRainfall(3) And arrRainfall(5) < arrRainfall(4) And arrRainfall(5) < arrRainfall(0) And arrRainfall(5) < arrRainfall(6) And arrRainfall(5) < arrRainfall(7) And arrRainfall(5) < arrRainfall(8) And arrRainfall(5) < arrRainfall(9) And arrRainfall(5) < arrRainfall(10) And arrRainfall(5) < arrRainfall(11) Then
            strLeastRainfall = arrMonths(5)
        ElseIf arrRainfall(6) < arrRainfall(1) And arrRainfall(6) < arrRainfall(2) And arrRainfall(6) < arrRainfall(3) And arrRainfall(6) < arrRainfall(4) And arrRainfall(6) < arrRainfall(5) And arrRainfall(6) < arrRainfall(0) And arrRainfall(6) < arrRainfall(7) And arrRainfall(6) < arrRainfall(8) And arrRainfall(6) < arrRainfall(9) And arrRainfall(6) < arrRainfall(10) And arrRainfall(6) < arrRainfall(11) Then
            strLeastRainfall = arrMonths(6)
        ElseIf arrRainfall(7) < arrRainfall(1) And arrRainfall(7) < arrRainfall(2) And arrRainfall(7) < arrRainfall(3) And arrRainfall(7) < arrRainfall(4) And arrRainfall(7) < arrRainfall(5) And arrRainfall(7) < arrRainfall(6) And arrRainfall(7) < arrRainfall(0) And arrRainfall(7) < arrRainfall(8) And arrRainfall(7) < arrRainfall(9) And arrRainfall(7) < arrRainfall(10) And arrRainfall(7) < arrRainfall(11) Then
            strLeastRainfall = arrMonths(7)
        ElseIf arrRainfall(8) < arrRainfall(1) And arrRainfall(8) < arrRainfall(2) And arrRainfall(8) < arrRainfall(3) And arrRainfall(8) < arrRainfall(4) And arrRainfall(8) < arrRainfall(5) And arrRainfall(8) < arrRainfall(6) And arrRainfall(8) < arrRainfall(7) And arrRainfall(8) < arrRainfall(0) And arrRainfall(8) < arrRainfall(9) And arrRainfall(8) < arrRainfall(10) And arrRainfall(8) < arrRainfall(11) Then
            strLeastRainfall = arrMonths(8)
        ElseIf arrRainfall(9) < arrRainfall(1) And arrRainfall(9) < arrRainfall(2) And arrRainfall(9) < arrRainfall(3) And arrRainfall(9) < arrRainfall(4) And arrRainfall(9) < arrRainfall(5) And arrRainfall(9) < arrRainfall(6) And arrRainfall(9) < arrRainfall(7) And arrRainfall(9) < arrRainfall(8) And arrRainfall(9) < arrRainfall(0) And arrRainfall(9) < arrRainfall(10) And arrRainfall(9) < arrRainfall(11) Then
            strLeastRainfall = arrMonths(9)
        ElseIf arrRainfall(10) < arrRainfall(1) And arrRainfall(10) < arrRainfall(2) And arrRainfall(10) < arrRainfall(3) And arrRainfall(10) < arrRainfall(4) And arrRainfall(10) < arrRainfall(5) And arrRainfall(10) < arrRainfall(6) And arrRainfall(10) < arrRainfall(7) And arrRainfall(10) < arrRainfall(8) And arrRainfall(10) < arrRainfall(9) And arrRainfall(10) < arrRainfall(0) And arrRainfall(10) < arrRainfall(11) Then
            strLeastRainfall = arrMonths(10)
        ElseIf arrRainfall(11) < arrRainfall(1) And arrRainfall(11) < arrRainfall(2) And arrRainfall(11) < arrRainfall(3) And arrRainfall(11) < arrRainfall(4) And arrRainfall(11) < arrRainfall(5) And arrRainfall(11) < arrRainfall(6) And arrRainfall(11) < arrRainfall(7) And arrRainfall(11) < arrRainfall(8) And arrRainfall(11) < arrRainfall(9) And arrRainfall(11) < arrRainfall(10) And arrRainfall(11) < arrRainfall(0) Then
            strLeastRainfall = arrMonths(11)
        End If
    End Sub

    Private Sub Display(ByRef dblTotalRainfall, ByRef strMostRainfall, ByRef strLeastRainfall, ByRef dblAverageRainfall)
        lstStatistics.Items.Add("Total Rainfall: " & dblTotalRainfall)
        lstStatistics.Items.Add("Month with Most Rainfall: " & strMostRainfall)
        lstStatistics.Items.Add("Month with Least Rainfall: " & strLeastRainfall)
        lstStatistics.Items.Add("Average Monthly Rainfall: " & dblAverageRainfall)
    End Sub
End Class
