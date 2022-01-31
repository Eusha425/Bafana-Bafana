Module Module1

    Sub Main()
        Dim n, p, k, t, d As Integer
        Dim i As Integer = 1
        Dim x As Integer = 0
        t = Console.ReadLine


        While i <= t
            i += 1
            x += 1
            n = Console.ReadLine
            k = Console.ReadLine
            p = Console.ReadLine

            d = k + p
            While d > n
                d = d - n

            End While

            Console.WriteLine("Case {0} : {1}", x, d)
            n = 0
            k = 0
            p = 0

        End While


        Console.ReadKey()

    End Sub

End Module
