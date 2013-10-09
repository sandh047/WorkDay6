Option Strict On

Public Class Form1

    Private Sub btnPopulation_Click(sender As System.Object, e As System.EventArgs) Handles btnPopulation.Click

        Dim pop As Double = 7000000000
        Dim year As Integer = 2012

        While pop > 6000000

            year -= 1
            pop = (pop - (pop * 0.013979))      'Takes yearly subtractions based on 1.013979 to the power of 50 years (doubling the Population)

        End While

        MessageBox.Show("It was approximately around " & year & " when there were less than 6 million people on the Earth")

    End Sub
End Class
