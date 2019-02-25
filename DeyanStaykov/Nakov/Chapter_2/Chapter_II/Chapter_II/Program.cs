using System;

class Program
{
    static void Main()
    {
        #region Chapter II Problem 3
        //Create a program that calculates with the accuracy of 0.000001
        decimal FirstNumber = 1;
        decimal SecondNumber = 123;
        decimal ThirdNumber = FirstNumber / SecondNumber;
        ThirdNumber = Math.Round(ThirdNumber, 6);
        Console.WriteLine(ThirdNumber);
        #endregion

        #region Chapter II Problem 10
        //Create a heart with "o"s
        Console.WriteLine(" o   o ");
        Console.WriteLine("o  o  o");
        Console.WriteLine(" o   o");
        Console.WriteLine("   o");
        #endregion

        #region Chapter II Problem 13
        //Create a program that swaps two numbers' places
        int Number1 = 5;
        int Number2 = 10;
        int Number3;
        Number3 = Number1;
        Number1 = Number2;
        Number2 = Number3;
        Console.WriteLine(Number1);
        Console.WriteLine(Number2);
        #endregion
    }
}

