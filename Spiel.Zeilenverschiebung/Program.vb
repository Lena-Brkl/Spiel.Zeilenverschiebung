
Imports System
Imports System.Threading

Module Program

    Dim Spalte(80) As Char
    Sub Erzeuge_Zeile()
        Dim x, y, z As Single
        Dim s, G, A, P, j As Integer

        'Vektor mit Leerzeichen
        For s = 0 To 79
            Spalte(s) = " "
        Next



        'Anzahl der Hindernisblocks
        Randomize()
        x = VBMath.Rnd()
        A = 4 * x + 2

        'Größe der Hindernisblocks
        For s = 1 To A
            Randomize()
            y = VBMath.Rnd
            G = 5 * y + 1

            'Position der Hindernisblocks
            Randomize()
            z = VBMath.Rnd
            P = 79 * z

            'Bedingung (Hindernisblock passt in Zeile)
            For j = 1 To G
                If (P + j - 1) <= 79 Then
                    Spalte(P + j - 1) = "X"
                End If

            Next
        Next

        'Ausgabe des Vektorelements
        'For s = 0 To 79
        '    Console.Write(Spalte(s))

        'Next
        'Console.WriteLine()

    End Sub

    Sub Zeilen_verschieben()
        Dim Leben, g As Integer
        Dim s As Integer
        Dim z As Integer
        Dim matrix(24, 80)

        Leben = 5
        Do
            Call Erzeuge_Zeile()
            g = 23
            'Zeile wird heruntergeschoben

            For z = 1 To 23

                For s = 0 To 79
                    matrix(g, s) = matrix(g - 1, s)
                Next
                g = g - 1
            Next

            'Eintragen neuer Zeile in oberste Zeile der Matrix
            For m As Integer = 0 To 79
                matrix(0, m) = Spalte(m)
            Next
            Console.SetCursorPosition(0, 0)

            'Ausgabe
            For z = 0 To 24
                For s = 0 To 79
                    Console.Write(matrix(z, s))
                Next
                Console.WriteLine()
            Next



            Thread.Sleep(600)

        Loop Until Leben = 0
    End Sub

    Sub Main()


        Call Erzeuge_Zeile()

            Call Zeilen_verschieben()

        Console.ReadLine()

    End Sub
End Module

