using System;

class Program
{
    static void Main()
    {
        #region Chapter IV Problem 1
        //Create an algorithm that after inputting 3 numbers from the console, it sums them up
        Console.WriteLine("Enter Three Numbers: ");
        Console.Write("First number: ");
        int FirstNumber = int.Parse(Console.ReadLine());
        Console.Write("Second number: ");
        int SecondNumber = int.Parse(Console.ReadLine());
        Console.Write("Third number: ");
        int ThirdNumber = int.Parse(Console.ReadLine());
        int Sum = FirstNumber + SecondNumber + ThirdNumber;
        Console.WriteLine("Their sum is: " + Sum);
        Console.WriteLine();
        #endregion

        #region Chapter IV Problem 2
        //Create an algorithm that calculates the surface area and circumference of a circle
        Console.Write("Enter the radius of the circle: ");
        int Radius = int.Parse(Console.ReadLine());
        double Circumference = 2 * Math.PI * Radius;
        double SurfaceArea = Math.PI * Radius * Radius;
        Console.WriteLine("The circumference of the circle is: " + Circumference);
        Console.WriteLine("The surface area of the circle is: " + SurfaceArea);
        Console.WriteLine();
        #endregion

        #region Chapter IV Problem 3
        //Create an algorithm that reads the input of an enterprise's name, adress, number, fax, website and manager
        Console.WriteLine("Enter the name for your enterprise: ");
        Console.ReadLine();
        Console.WriteLine("Enter its address: ");
        Console.ReadLine();
        Console.WriteLine("Enter its number: ");
        Console.ReadLine();
        Console.WriteLine("Enter its fax: ");
        Console.ReadLine();
        Console.WriteLine("Enter its website: ");
        Console.ReadLine();
        Console.WriteLine("Does it have a manager? (Y/N)");
        Console.WriteLine("WARNING !!!");
        Console.WriteLine("If you press (N) the application will close, for you");
        Console.WriteLine("must have a manager if you want to work with us.");
        if (Console.ReadKey(true).Key == ConsoleKey.N)
        {
            Environment.Exit(0);
        }
        else if (Console.ReadKey(true).Key == ConsoleKey.Y)
        {
            Console.WriteLine();
            Console.WriteLine("Enter his name: ");
            Console.ReadLine();
            Console.WriteLine("Enter his last name: ");
            Console.ReadLine();
            Console.WriteLine("Enter his phone number: ");
            Console.ReadLine();
        }
        Console.WriteLine();
        #endregion

        #region Chapter IV Problem 5
        //Create an algorithm that, after entering 2 numbers, tells you how many numbers between them is an aliquot of 5
        Console.WriteLine("Enter two numbers and check if they are multiples of 5");
        Console.Write("Enter the first number: ");
        int FirstNumberForCheck = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the second number: ");
        int SecondNumberForCheck = int.Parse(Console.ReadLine());
        while (FirstNumberForCheck < SecondNumberForCheck)
        {
            FirstNumberForCheck++;
            if (FirstNumberForCheck % 5 == 0)
            {
                Console.WriteLine(FirstNumberForCheck);
            }
        }
        Console.WriteLine();
        #endregion

        #region Chapter IV Problem 6
        //Create an algorithm that writes out the bigger of two numbers without using conditions
        Console.WriteLine("Enter two numbers: ");
        Console.Write("The first number is: ");
        int FirstCompare = int.Parse(Console.ReadLine());
        Console.Write("The second number is: ");
        int SecondCompare = int.Parse(Console.ReadLine());
        Console.WriteLine("The bigger number is: " + Math.Max(FirstCompare, SecondCompare));
        Console.WriteLine();
        #endregion

        #region Chapter IV Problem 7
        //Create an algorithm that adds up 5 numbers, if a number is invalid, enter a new one
        Console.WriteLine("Enter 5 numbers and the console will add them up.");
        Console.Write("Enter the first Number: ");
        //int FirstOf5 = Console.ReadLine();
        string firstOf5 = Console.ReadLine();
        int FirstOf5;
        bool firstSuccess = int.TryParse(firstOf5, out FirstOf5);
        while (firstSuccess == false)
        {
            Console.Write("Invalid. Enter a new number: ");
            firstOf5 = Console.ReadLine();
            firstSuccess = int.TryParse(firstOf5, out FirstOf5);
        }

        Console.Write("Enter the second Number: ");
        string secondOf5 = Console.ReadLine();
        int SecondOf5;
        bool secondSuccess = int.TryParse(secondOf5, out SecondOf5);
        while (secondSuccess == false)
        {
            Console.Write("Invalid. Enter a new number: ");
            secondOf5 = Console.ReadLine();
            secondSuccess = int.TryParse(secondOf5, out SecondOf5);
        }

        Console.Write("Enter the third Number: ");
        string thirdOf5 = Console.ReadLine();
        int ThirdOf5;
        bool thirdSuccess = int.TryParse(thirdOf5, out ThirdOf5);
        while (thirdSuccess == false)
        {
            Console.Write("Invalid. Enter a new number: ");
            thirdOf5 = Console.ReadLine();
            thirdSuccess = int.TryParse(thirdOf5, out ThirdOf5);
        }

        Console.Write("Enter the fourth Number: ");
        string fourthOf5 = Console.ReadLine();
        int FourthOf5;
        bool fourthSuccess = int.TryParse(fourthOf5, out FourthOf5);
        while (fourthSuccess == false)
        {
            Console.Write("Invalid. Enter a new number: ");
            fourthOf5 = Console.ReadLine();
            fourthSuccess = int.TryParse(fourthOf5, out FourthOf5);
        }

        Console.Write("Enter the fifth Number: ");
        string fifthOf5 = Console.ReadLine();
        int FifthOf5;
        bool fifthSuccess = int.TryParse(fifthOf5, out FifthOf5);
        while (fifthSuccess == false)
        {
            Console.Write("Invalid. Enter a new number: ");
            fifthOf5 = Console.ReadLine();
            fifthSuccess = int.TryParse(fifthOf5, out FifthOf5);
        }

        int fiveSum = FirstOf5 + SecondOf5 + ThirdOf5 + FourthOf5 + FifthOf5;
        Console.WriteLine(fiveSum);

        Console.WriteLine();
        #endregion

        #region Chapter IV Problem 9
        //Create an algorithm that solves quadratic equations
        Console.WriteLine("Enter a quadratic equation and I will solve it!");
        Console.Write("Enter a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter b: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter c: ");
        double c = double.Parse(Console.ReadLine());
        double D = b * b - 4 * a * c;
        Console.WriteLine("D = " + D);
        double x1, x2;
        if (D > 0)
        {
            x1 = (-b + Math.Sqrt(D)) / 2 * a;
            x2 = (-b - Math.Sqrt(D)) / 2 * a;
            Console.WriteLine("x1 = " + x1);
            Console.WriteLine("x2 = " + x2);
        }
        else if (D == 0)
        {
            x1 = x2 = -b / 2 * a;
            Console.WriteLine("x1 = x2 = " + x1);
        }
        else if (D < 0)
        {
            Console.WriteLine("No real answers!");
        }

        Console.WriteLine();
        #endregion

        #region Chapter IV Problem 11
        //Create an algorithm that prints out every number between 1 and the number from user input
        Console.WriteLine("Enter a number and I will print out every number between 1 and it!");
        Console.Write("Enter your number: ");
        for (int EnteredNumber = int.Parse(Console.ReadLine()); EnteredNumber > 0; EnteredNumber--)
        {
            Console.WriteLine(EnteredNumber);
        }

        Console.WriteLine();
        #endregion

        #region Chapter IV Problem 12
        //Create a program that prints out the first 100 numbers of the Fubonacci's number
        int i, Fubonacci = 0, FirstLocal = 0, SecondLocal = 1;
        for (i = 0; i < 20; i++)
        {
            Fubonacci = FirstLocal + SecondLocal;
            FirstLocal = SecondLocal;
            SecondLocal = Fubonacci;
            Console.WriteLine(Fubonacci);
        }

        Console.WriteLine();
        #endregion

        #region Chapter IV Problem 13
        //Create a program that prints out (with the accuracy of 0.001) the sum of 1 + 1/2 + 1/3 ... 
        double FirstAccurate = 1, SecondAccurate = 1, AccurateSum = 0, Divided;
        for (int Accuratei = 0; Accuratei < 10; Accuratei++)
        {
            Divided = FirstAccurate / SecondAccurate;
            AccurateSum = AccurateSum + Divided;
            Console.WriteLine(Math.Round(AccurateSum, 3));
            SecondAccurate++;
        }
        Console.WriteLine();
        #endregion

    }
}

