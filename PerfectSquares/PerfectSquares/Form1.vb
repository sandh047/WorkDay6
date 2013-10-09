Public Class Form1

    Private Sub btnDisplay_Click(sender As System.Object, e As System.EventArgs) Handles btnDisplay.Click

        lstResult.Items.Clear()

        Dim square As Integer = 0
        Dim count As Integer = 1

        While count < 11

            square = Math.Pow(count, 2)
            lstResult.Items.Add(CStr((count) & ") " & count & " squared = " & square))
            count += 1

        End While

    End Sub
End Class
