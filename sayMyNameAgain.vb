'David Harmon
'RCET0265
'Fall 2020
'sayMyNameAgain
'https://github.com/harmdavi/sayMyNameAgain.git


Option Strict On
Option Explicit On
Option Compare Text



Module sayMyNameAgain


    Sub Main()
        Dim userInput As String

        Do
            Console.WriteLine("Hello there! What is your name?" & vbNewLine & "If you wish to exit, please press q")
            userInput = Console.ReadLine()
            If userInput = "Emily" Or userInput = "Joe" Then
                Console.WriteLine("Well Hello there " & userInput)
                Console.ReadLine()
            ElseIf userInput = "David" Then
                Console.WriteLine("David? Why are you here and not playing drums?")
                Console.ReadLine()
            ElseIf userInput = "Tim" Then
                Console.WriteLine("Aiglet. Dont forget it.")
                Console.ReadLine()
            ElseIf userInput = "q" Then
                Exit Sub
            Else
                Console.WriteLine("Im sorry. I am not programmed to greet you.")
            End If


        Loop


    End Sub

End Module
