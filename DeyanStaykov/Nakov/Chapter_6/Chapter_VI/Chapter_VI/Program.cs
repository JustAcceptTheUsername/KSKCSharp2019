using System;

class Program
{
    static void Main()
    {
        #region Chapter VI Problem 1
        //Create an algorithm that prints out the numbers between 1 and the user-inputted n
        Console.WriteLine("Enter a number and I will print every number between 1 and it.");
        Console.Write("Your number is: ");
        int userInputNumber = int.Parse(Console.ReadLine());
        for (int i = 1; i < userInputNumber; i++) Console.WriteLine(i);

        Console.WriteLine();
        #endregion

        #region Chapter VI Problem 2
        //Create an algorithm that prints out the numbers between 1 and the user-inputted n which aren't dividable by 3 and 7
        Console.WriteLine("Enter a number and I will print every number between 1 and it.");
        Console.Write("Your number is: ");
        int userInputNumber37 = int.Parse(Console.ReadLine());
        for (int i = 1; i < userInputNumber37; i++)
        {
            if (i % 3 != 0 && i % 7 != 0) Console.WriteLine(i);
        }

        Console.WriteLine();
        #endregion

        #region Chapter VI Problem 3
        //Create an algorithm that takes numbers from user input and prints out the biggest and the smallest
        int min, max, number;
        Console.Write("Please enter a minimum number: ");
        min = int.Parse(Console.ReadLine());
        Console.Write("Please enter a maximum number: ");
        max = int.Parse(Console.ReadLine());
        for (int i = 0; i < 9; i++)
        {
            Console.Write("Please enter a number: ");
            number = int.Parse(Console.ReadLine());
            if (number < min) min = number;
            if (number > max) max = number;
        }
        Console.WriteLine("min = " + min);
        Console.WriteLine("max = " + max);


        Console.WriteLine();
        #endregion

        #region Chapter VI Problem 4
        //Create an algorithm that prints out every card and every symbol from a standart deck of cards /52 cards/
        string symbolName, cardName;
        for (int symbol = 0; symbol < 4; symbol++)
        {
            switch (symbol)
            {
                case 0:
                    symbolName = "Spades";
                    break;
                case 1:
                    symbolName = "Hearts";
                    break;
                case 2:
                    symbolName = "Diamonds";
                    break;
                case 3:
                    symbolName = "Clubs";
                    break;
                default:
                    symbolName = " ";
                    break;
            }
            for (int card = 2; card < 15; card++)
            {
                switch (card)
                {
                    case 11:
                        cardName = "Jack";
                        break;
                    case 12:
                        cardName = "Queen";
                        break;
                    case 13:
                        cardName = "King";
                        break;
                    case 14:
                        cardName = "Ace";
                        break;
                    default:
                        cardName = " ";
                        break;
                }

                Console.WriteLine("symbol = {0}, card = {1}", symbolName, (card <= 10) ? card.ToString() : cardName);
            }
        }

        Console.WriteLine();
        #endregion

        #region Chapter VI Problems 6 - 9
        //Create an algorithm that calculates N!/K!, N!*K!/(N-K)!, (2n!)/((n+1)!n!) and 1 + 1!/x^1 + 2!/x^2 + ... + n!/x^n for 1<K<N
        Console.WriteLine("Enter two numbers N and K and I will calculate " + Environment.NewLine +
                "N! / K! (Problem 6) and N!*K!/(N-K)! (Problem7)" + Environment.NewLine +
                "Cn = (2n!)/((n+1)!n!) (Problem8)." + Environment.NewLine +
                "S = 1 + 1!/x^1 + 2!/x^2 + ... + n!/x^n (Problem9).");
        Console.Write("Enter N: ");
        double N = int.Parse(Console.ReadLine());
        Console.Write("Enter K: ");
        int K = int.Parse(Console.ReadLine());
        Console.Write("Enter X: ");
        double xNine = int.Parse(Console.ReadLine());
        double sevenConstant = N - K, doubleN = 2 * N;
        double S = 1;

        #region Problem 6 Loop
        while (K > N)
        {
            Console.Write("K must be smaller than N. Enter a new value for K: ");
            K = int.Parse(Console.ReadLine());
        }
        #endregion

        int nFactorial = 1, kFactorial = 1, sevenFactorial = 1, doublenFactorial = 1, nPlusOneFactorial = 1, nineFac = 1;

        #region For Cycles
        for (int i = 1; i <= N; i++) nFactorial *= i;
        for (int i = 1; i <= N + 1; i++) nPlusOneFactorial *= i;
        for (int i = 1; i <= K; i++) kFactorial *= i;
        for (int i = 1; i <= sevenConstant; i++) sevenFactorial *= i;
        for (int i = 1; i <= doubleN; i++) doublenFactorial *= i;
        for (int i = 1; i <= N; i++)
        {
            nineFac = 1;
            for (int j = i; j >= 1; j--)
            {
                nineFac *= j;
            }
            S += nineFac / Math.Pow(xNine, i);
        }
        #endregion


        #region Answers
        int dividedFactorial = nFactorial / kFactorial;
        Console.WriteLine("Answer to problem 6: ");
        Console.WriteLine(dividedFactorial);
        double complexFactorial = (N * K) / sevenFactorial;
        Console.WriteLine("Answer to problem 7: ");
        Console.WriteLine(sevenFactorial);
        double catalanNumber = (doublenFactorial) / ((nPlusOneFactorial) * nFactorial);
        Console.WriteLine("Answer to problem 8: ");
        Console.WriteLine(catalanNumber);
        #endregion

        Console.WriteLine("Answer to problem 9: ");
        Console.WriteLine("{0:##.##}", S);

        Console.WriteLine();
        #endregion

        #region Chapter VI Problem 10



        Console.WriteLine();
        #endregion
    }
}
