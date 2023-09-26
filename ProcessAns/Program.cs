// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main(string[] args)
    {
        int maxTurns = 12;
        int currentTurn = 1;
        string[] userInput = new string[4];
        string[] correctAns = new string[4]; 

        while (currentTurn <= maxTurns)
        {
            Console.WriteLine("Turn " + currentTurn + ": Enter your guess (4 colors):");
            for (int i = 0; i < 4; i++)
            {
                userInput[i] = Console.ReadLine();
            }

            if (userInput.Length != 4)
            {
                Console.WriteLine("Please enter exactly 4 colors.");
            }
            else
            {
                int whitePegsCount = 0;
                int redPegsCount = 0;

                for (int i = 0; i < 4; i++)
                {
                    if (userInput[i] == correctAns[i])
                    {
                        whitePegsCount++;
                    }
                    else if (Array.Exists(correctAns, element => element == userInput[i]))
                    {
                        redPegsCount++;
                    }
                }

                Console.WriteLine("White Pegs: " + whitePegsCount);
                Console.WriteLine("Red Pegs: " + redPegsCount);

                if (whitePegsCount == 4)
                {
                    Console.WriteLine("Congratulations!");
                    break;
                }
                else
                {
                    currentTurn++;
                }
            }
        }

        if (currentTurn > maxTurns)
        {
            Console.WriteLine("Out of turns. The correct code was: " + string.Join(" ", correctAns));
        }

        Console.WriteLine("Game over. Thanks for playing!");
    }
}

