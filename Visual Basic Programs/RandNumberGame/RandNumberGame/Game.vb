Module Game

    Sub Main()
        Console.WriteLine("Welcome to the Random Number Guessing Game")
        Dim Difficulty As Boolean = True
        While (Difficulty)
            Difficulty = DifficultyDescription()
        End While

    End Sub

    'Explains to the player the difficulty levels and asks the player to select a difficulty by typing the difficulty into the console
    Function DifficultyDescription() As Boolean
        Console.WriteLine("Please type what level of difficulty you want by typing the number into the window.")
        Console.WriteLine("1: Easy - Guess a random number between 1 and 10")
        Console.WriteLine("2: Medium - Guess a random number between 1 and 100")
        Console.WriteLine("3: Hard - Guess a random number between 1 and 1000")
        Console.WriteLine("4: Custom - Feature under construction")
        Console.WriteLine("5. Exit the Game")

        Dim result As String = Console.ReadLine()

        If result = "1" Then
            Return Easy()

        ElseIf result = "2" Then
            Return Medium()

        ElseIf result = "3" Then
            Return Hard()

        ElseIf result = "4" Then
            Return Custom()
        Else
            Return False
        End If
    End Function

    Function Easy() As Boolean
        Console.Clear()
        Console.WriteLine("Type your guess between 1 and 10 into the window.")
        Dim random As New Random
        Dim randomNumber As Integer = random.Next(1, 11)
        Dim guesses As Integer = 0
        Dim incorrect As Boolean = True

        Do While incorrect = True
            Dim result As String = Console.ReadLine()
            guesses += 1
            If result = randomNumber.ToString() Then
                incorrect = False
            Else
                Console.WriteLine("Wrong!")
            End If
        Loop

        Console.WriteLine("Congratulations, it took you {0} guesses.", guesses)
        Console.WriteLine("Please press enter to go back to the main menu")
        Console.ReadLine()
        Return True

    End Function

    Function Medium() As Boolean
        Console.Clear()
        Console.WriteLine("Type your guess between 1 and 100 into the window.")
        Dim random As New Random
        Dim randomNumber As Integer = random.Next(1, 101)
        Dim guesses As Integer = 0
        Dim incorrect As Boolean = True

        Do While incorrect = True
            Dim result As String = Console.ReadLine()
            guesses += 1
            If result = randomNumber.ToString() Then
                incorrect = False
            Else
                Console.WriteLine("Wrong!")
            End If
        Loop

        Console.WriteLine("Congratulations, it took you {0} guesses.", guesses)
        Console.WriteLine("Please press enter to go back to the main menu")
        Console.ReadLine()
        Return True
    End Function

    Function Hard() As Boolean
        Console.Clear()
        Console.WriteLine("Type your guess between 1 and 1000 into the window.")
        Dim random As New Random
        Dim randomNumber As Integer = random.Next(1, 1001)
        Dim guesses As Integer = 0
        Dim incorrect As Boolean = True

        Do While incorrect = True
            Dim result As String = Console.ReadLine()
            guesses += 1
            If result = randomNumber.ToString() Then
                incorrect = False
            Else
                Console.WriteLine("Wrong!")
            End If
        Loop

        Console.WriteLine("Congratulations, it took you {0} guesses.", guesses)
        Console.WriteLine("Please press enter to go back to the main menu")
        Console.ReadLine()
        Return True
    End Function

    Function Custom() As Boolean
        Console.Clear()
        Console.WriteLine("In this mode, you get to define the difficulty. Please type the starting and ending number to determine the range of numbers to guess.")
        Console.WriteLine("For example, to guess a number between 1 and 10, you would enter ( 1 ) and ( 10 ) as the second number")
        Console.Write("Please enter the lowest number for the range: ")
        Dim lowRange As Integer = CInt(Console.ReadLine())
        Console.Write("Please enter the highest number for the range: ")
        Dim highRange As Integer = CInt(Console.ReadLine())
        Console.WriteLine("Type your guess between {0} and {1} into the window.", lowRange, highRange)
        Dim random As New Random
        Dim randomNumber As Integer = random.Next(lowRange, highRange + 1)
        Dim guesses As Integer = 0
        Dim incorrect As Boolean = True

        Do While incorrect = True
            Dim result As String = Console.ReadLine()
            guesses += 1
            If result = randomNumber.ToString() Then
                incorrect = False
            Else
                Console.WriteLine("Wrong!")
            End If
        Loop

        Console.WriteLine("Congratulations, it took you {0} guesses.", guesses)
        Console.WriteLine("Please press enter to go back to the main menu")
        Console.ReadLine()
        Return True
    End Function

End Module
