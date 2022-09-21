Module Module1
'cerner_2^5_2022
    Sub Main()

        Dim result As Integer = 0
        Dim num1 As Integer = 0
        Dim num2 As Integer = 0
        Dim num3 As Integer = 0

        Console.Write("Enter number1: ")
        num1 = Integer.Parse(Console.ReadLine())

        Console.Write("Enter number2: ")
        num2 = Integer.Parse(Console.ReadLine())

        Console.Write("Enter number3: ")
        num3 = Integer.Parse(Console.ReadLine())

        result = If(
                    (num1 > num2 AndAlso num1 > num3), num1, If((num2 > num1 AndAlso num2 > num3), num2, num3)
                   )
        Console.WriteLine("Largest Number is: {0}", result)

        Console.ReadLine()
    End Sub
End Module