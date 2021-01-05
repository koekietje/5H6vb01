Public Class Form1
    Private Sub btnSluiten_Click(sender As Object, e As EventArgs) Handles btnSluiten.Click
        End
    End Sub

    Private Sub btnOefenen_Click(sender As Object, e As EventArgs) Handles btnOefenen.Click
        Const aantal As Integer = 5
        Dim getal1, getal2, teller As Integer
        Dim aantalJuist As Integer
        Dim boodschap As String
        Dim vraag As String
        Dim titel As String
        Dim antwoord As String

        lblBoodschap.Text = ""

        'herhaal aantal x
        '           vraag som
        '                 2getallen tot 10
        '                 toon vraag
        '                 vraag antwoord
        '                 vergelijk antwoord (eventueel aantaljuist verhogen met 1)
        'toon aantaljuiste antwoorden
        Try
            For teller = 1 To aantal
                Randomize()
                getal1 = Int(Rnd() * 10) + 1
                getal2 = Int(Rnd() * 10) + 1

                vraag = "Hoeveel is " & getal1 & " + " & getal2
                titel = "rekensom " & teller

                antwoord = InputBox(vraag, titel, "0")

                If CInt(antwoord) = getal1 + getal2 Then
                    aantalJuist += 1 'aantalJuist = aantalJuist + 1
                Else
                    Beep()
                End If
            Next

            lblBoodschap.Text = "U had " & aantalJuist.ToString & " antwoorden juist op " & aantal & " vragen."
        Catch ex As Exception
            MessageBox.Show("Gelieve een getal in te voeren.")
        End Try




    End Sub
End Class
