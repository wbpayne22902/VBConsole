Imports System

Module Program
    Sub Main(args As String())
        Console.Clear()
        Console.BackgroundColor = ConsoleColor.Blue
        Console.WriteLine("Hello World!")
        For x = 1 To 15
            Console.WriteLine($"Hello {x}")
        Next
        Console.BackgroundColor = ConsoleColor.Black
        Console.WriteLine("Done!")
    End Sub
End Module
