using System;

class Program
{
    static void Main()
    {
        //This is the tester that thou shalt use

        #region
        //Console.Write("Enter a number and see its square: ");
        //string str = Console.ReadLine(); //initializing
        //int intValue; //initializing
        //bool ParseSuccess = int.TryParse(str, out intValue);
        //while (ParseSuccess == false)
        //{
        //    Console.Write(ParseSuccess ? "The Square of the number is: " //Checks if true or false
        //    + intValue * intValue //If bool ParseSuccess is true
        //    + "." : "Invalid Number! Enter a new number: "); //If bool ParseSuccess is false
        //    str = Console.ReadLine();
        //    ParseSuccess = int.TryParse(str, out intValue);
        //}
        //if (ParseSuccess == true)
        //{
        //    Console.Write(ParseSuccess ? "The Square of the number is: " //Checks if true or false
        //    + intValue * intValue //If bool ParseSuccess is true
        //    + "." : "Invalid Number! Enter a new number: "); //If bool ParseSuccess is false
        //    Console.WriteLine();
        //}
        #endregion

        #region

        //Create an algorithm that adds up 5 numbers, if a number is invalid, enter a new one
        //Console.WriteLine("Enter 5 numbers and the console will add them up.");
        //Console.Write("Enter the first Number: ");
        //string firstOf5 = Console.ReadLine();
        //int FirstOf5;
        //bool firstSuccess = int.TryParse(firstOf5, out FirstOf5);
        //while (firstSuccess == false)
        //{
        //    Console.Write("Invalid. Enter a new number: ");
        //    firstOf5 = Console.ReadLine();
        //    firstSuccess = int.TryParse(firstOf5, out FirstOf5);
        //}

        //Console.Write("Enter the second Number: ");
        //string secondOf5 = Console.ReadLine();
        //int SecondOf5;
        //bool secondSuccess = int.TryParse(secondOf5, out SecondOf5);
        //while (secondSuccess == false)
        //{
        //    Console.Write("Invalid. Enter a new number: ");
        //    secondOf5 = Console.ReadLine();
        //    secondSuccess = int.TryParse(secondOf5, out SecondOf5);
        //}

        //Console.Write("Enter the third Number: ");
        //string thirdOf5 = Console.ReadLine();
        //int ThirdOf5;
        //bool thirdSuccess = int.TryParse(thirdOf5, out ThirdOf5);
        //while (thirdSuccess == false)
        //{
        //    Console.Write("Invalid. Enter a new number: ");
        //    thirdOf5 = Console.ReadLine();
        //    thirdSuccess = int.TryParse(thirdOf5, out ThirdOf5);
        //}

        //Console.Write("Enter the fourth Number: ");
        //string fourthOf5 = Console.ReadLine();
        //int FourthOf5;
        //bool fourthSuccess = int.TryParse(fourthOf5, out FourthOf5);
        //while (fourthSuccess == false)
        //{
        //    Console.Write("Invalid. Enter a new number: ");
        //    fourthOf5 = Console.ReadLine();
        //    fourthSuccess = int.TryParse(fourthOf5, out FourthOf5);
        //}

        //Console.Write("Enter the fifth Number: ");
        //string fifthOf5 = Console.ReadLine();
        //int FifthOf5;
        //bool fifthSuccess = int.TryParse(fifthOf5, out FifthOf5);
        //while (fifthSuccess == false)
        //{
        //    Console.Write("Invalid. Enter a new number: ");
        //    fifthOf5 = Console.ReadLine();
        //    fifthSuccess = int.TryParse(fifthOf5, out FifthOf5);
        //}

        //int fiveSum = FirstOf5 + SecondOf5 + ThirdOf5 + FourthOf5 + FifthOf5;
        //Console.WriteLine(fiveSum);

        //Console.WriteLine();
        #endregion

        #region
        //Console.WriteLine("Enter a number between 0 and 9 and I will write it out.");
        //Console.Write("Your number is: ");
        //int writeNumberOut = int.Parse(Console.ReadLine());
        //while (writeNumberOut < 0 || writeNumberOut > 9)
        //{
        //    Console.Write("Invalid. Enter a new number: ");
        //    writeNumberOut = int.Parse(Console.ReadLine());
        //}
        //switch (writeNumberOut)
        //{
        //    case 1:
        //        Console.WriteLine("One");
        //        break;
        //    case 2:
        //        Console.WriteLine("Two");
        //        break;
        //    case 3:
        //        Console.WriteLine("Three");
        //        break;
        //    case 4:
        //        Console.WriteLine("Four");
        //        break;
        //    case 5:
        //        Console.WriteLine("Five");
        //        break;
        //    case 6:
        //        Console.WriteLine("Six");
        //        break;
        //    case 7:
        //        Console.WriteLine("Seven");
        //        break;
        //    case 8:
        //        Console.WriteLine("Eight");
        //        break;
        //    case 9:
        //        Console.WriteLine("Nine");
        //        break;
        //}

        #endregion

        #region
        //Create an algorithm that reads the user input. If the input is either int or double, the number++, if string, add '*' to it. 
        //Console.Write("Enter something and see what happens! ");

        //string complexPicker = Console.ReadLine();
        //int addInt;
        //double addDouble;
        //bool complexInt = int.TryParse(complexPicker, out addInt);
        //bool complexDouble = double.TryParse(complexPicker, out addDouble);

        //if (complexInt == true)
        //{
        //    addInt = int.Parse(complexPicker);
        //    addInt++;
        //    Console.WriteLine("The text is of type integer, thus I shall increase its value by 1.");
        //    Console.WriteLine("The new value of the text is now: " + ' ' + addInt);
        //}
        //else if (complexDouble == true)
        //{
        //    addDouble = double.Parse(complexPicker);
        //    addDouble++;
        //    Console.WriteLine("The text is of type double, thus I shall increase its value by 1.");
        //    Console.WriteLine("The new value of the text is now: " + ' ' + addDouble);
        //}
        //else
        //{
        //    Console.WriteLine("The text is of type string, thus I shall add an asterisk to it.");
        //    Console.WriteLine(complexPicker + "*");
        //}

        //Console.WriteLine();
        #endregion

        #region
        //Create an algorithm that prints out every card and every symbol from a standart deck of cards /52 cards/
        //string symbolName, cardname;
        //for (int symbol = 0; symbol < 4; symbol++)
        //{
        //    switch (symbol)
        //    {
        //        case 0:
        //            symbolName = "Spades";
        //            break;
        //        case 1:
        //            symbolName = "Hearts";
        //            break;
        //        case 2:
        //            symbolName = "Diamonds";
        //            break;
        //        case 3:
        //            symbolName = "Clubs";
        //            break;
        //        default:
        //            symbolName = " ";
        //            break;
        //    }
        //    for (int card = 2; card < 15; card++)
        //    {
        //        switch (card)
        //        {
        //            case 11:
        //                cardname = "Jack";
        //                break;
        //            case 12:
        //                cardname = "Queen";
        //                break;
        //            case 13:
        //                cardname = "King";
        //                break;
        //            case 14:
        //                cardname = "Ace";
        //                break;
        //            default:
        //                cardname = " ";
        //                break;
        //        }

        //        Console.WriteLine("symbol = {0}, card = {1}", symbolName, (card <= 10) ? card.ToString() : cardname);
        //    }
        //}
        #endregion

        #region
        //Console.WriteLine("Enter two numbers N and K and I will calculate " + Environment.NewLine +
        //    "N! / K! (Problem 6) and N!*K!/(N-K)! (Problem7)" + Environment.NewLine +
        //    "Cn = (2n!)/(n+1)!n! (Problem8)." + Environment.NewLine +
        //    "S = 1 + 1!/x^1 + 2!/x^2 + ... + n!/x^n (Problem9).");
        //Console.Write("Enter N: ");
        //double N = int.Parse(Console.ReadLine());
        //Console.Write("Enter K: ");
        //int K = int.Parse(Console.ReadLine());
        //Console.Write("Enter X: ");
        //double xNine = int.Parse(Console.ReadLine());
        //double sevenConstant = N - K, doubleN = 2 * N;
        //double S = 1;

        //#region Problem 6 Loop
        //while (K > N)
        //{
        //    Console.Write("K must be smaller than N. Enter a new value for K: ");
        //    K = int.Parse(Console.ReadLine());
        //}
        //#endregion

        //int nFactorial = 1, kFactorial = 1, sevenFactorial = 1, doublenFactorial = 1, nPlusOneFactorial = 1, nineFac = 1;

        //#region For Cycles
        //for (int i = 1; i <= N; i++) nFactorial *= i;
        //for (int i = 1; i <= N + 1; i++) nPlusOneFactorial *= i;
        //for (int i = 1; i <= K; i++) kFactorial *= i;
        //for (int i = 1; i <= sevenConstant; i++) sevenFactorial *= i;
        //for (int i = 1; i <= doubleN; i++) doublenFactorial *= i;
        //for (int i = 1; i <= N; i++)
        //{
        //    nineFac = 1;
        //    for (int j = i; j >= 1; j--)
        //    {
        //        nineFac *= j;
        //    }
        //    S += nineFac / Math.Pow(xNine, i);
        //}
        //#endregion


        //#region Answers
        //int dividedFactorial = nFactorial / kFactorial;
        //Console.WriteLine("Answer to problem 6: ");
        //Console.WriteLine(dividedFactorial);
        //double complexFactorial = (N * K) / sevenFactorial;
        //Console.WriteLine("Answer to problem 7: ");
        //Console.WriteLine(sevenFactorial);
        //double catalanNumber = (doublenFactorial) / ((nPlusOneFactorial) * nFactorial);
        //Console.WriteLine("Answer to problem 8: ");
        //Console.WriteLine(catalanNumber);
        //#endregion

        //Console.WriteLine("Answer to problem 9: ");
        //Console.WriteLine("{0:##.##}", S);

        //Console.WriteLine();
        #endregion

        #region
        //Create an algorithm that prints out a square matrix for N > 0 && N < 20 (i. e. for N = 2 print out 1, 2, 3
        //                                                                                                   2, 3, 4       
        //                                                                                                   3, 4, 5

        //Console.WriteLine("Enter a number between 0 and 20 and I will print create a matrix out of it.");
        //Console.Write("Your number is: ");
        //int nMatrix = int.Parse(Console.ReadLine());
        //while (nMatrix < 0 || nMatrix > 20)
        //{
        //    Console.Write("The number must be between 0 and 20, enter a new number: ");
        //    nMatrix = int.Parse(Console.ReadLine());
        //}
        #endregion

        #region PROBLEM 11 SOLVED, TRANSFER SOLUTION
        //Create an algorithm that calculates finds prints out how many zeroes a given factorial has
        //Console.Write("Enter N: ");
        //double elevenN = int.Parse(Console.ReadLine());
        //long elevenFactorial = 1;
        //for (int i = 1; i <= elevenN; i++) elevenFactorial *= i;
        //int zeroCounter = 0;
        //while(elevenFactorial % 10 == 0)
        //{
        //    elevenFactorial /= 10;
        //    zeroCounter++;
        //}
        //Console.WriteLine(elevenFactorial);
        //Console.WriteLine(zeroCounter);

        //Console.WriteLine();
        #endregion

        #region PROBLEM 16 SOLVED, TRANSFER SOLUTION

        //Create an algorithm that prints out randomly the numbers between 1 and the user-generated N
        //Console.Write("Enter a number and I will print " + Environment.NewLine +
        //    "randomly the numbers between 1 and your number.");
        //int userNumber = int.Parse(Console.ReadLine());
        //int[] oneToN = new int[userNumber];
        //int firstSwap, secondSwap, host;
        //Random firstRandom = new Random();
        //firstSwap = firstRandom.Next(1, userNumber);
        //secondSwap = firstRandom.Next(1, userNumber);
        //for (int i = 0; i < oneToN.Length; i++)
        //{
        //    oneToN[i] = int.Parse(Console.ReadLine());
        //}
        //for (int i = 0; i < userNumber; i++)
        //{
        //    host = oneToN[firstSwap];
        //    oneToN[firstSwap] = oneToN[secondSwap];
        //    oneToN[secondSwap] = host;
        //    firstSwap = firstRandom.Next(1, userNumber);
        //    secondSwap = firstRandom.Next(1, userNumber);
        //}
        //foreach (int item in oneToN)
        //{
        //    Console.Write(item + " ");
        //}
        //Console.WriteLine();


        #endregion

        #region School Problem Solution
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            if (i == 0)
            {
                Console.WriteLine(new string('*', n));
            }
            else if (i == n - 1)
            {
                Console.Write(new string('*', n));
            }
            else Console.WriteLine('*' + "".PadRight(n - 2) + '*');
        }
        Console.WriteLine();
        #endregion

    }
}