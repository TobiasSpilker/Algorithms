//Tobias Spilker - Utrecht University
using System;

public class Collatz
{
    //Main method:
    public static void Main()
    {
        //Reads the console input and extracts the number (amount of input):
        string ConsoleInputAmount = Console.ReadLine();
        string[] SplicedConsoleInputAmount = ConsoleInputAmount.Split(' ');
        int Amount = int.Parse(SplicedConsoleInputAmount[0]);

        int[] NumberArray = new int[Amount];

        //Reads the numbers and stores it in an int[] variable:
        for (int i = 0; i < NumberArray.Length; i++)
        {
            string ConsoleInput = Console.ReadLine();
            string[] SplicedConsoleInput = ConsoleInput.Split(' ');
            int Number = int.Parse(SplicedConsoleInput[0]);

            NumberArray[i] = Number;
        }

        //Takes the numbers through the algorithm:
        for (int i = 0; i < NumberArray.Length; i++)
        {
            long CollatzNumber = NumberArray[i];
            int CollatzLength = 0;

            while(CollatzNumber != 1)
            {
                //Checks if number is even: Devide by 2
                if (CollatzNumber % 2 == 0)
                {
                    CollatzNumber = CollatzNumber / 2;
                }

                //Checks if number is uneven: Times 3 plus 1
                else
                {
                    CollatzNumber = (CollatzNumber * 3) + 1;
                }

                CollatzLength += 1;
            }

            Console.WriteLine(CollatzLength);
        }

    }
}




