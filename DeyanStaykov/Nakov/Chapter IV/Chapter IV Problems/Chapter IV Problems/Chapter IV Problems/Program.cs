using System;

namespace Chapter_IV_Problems
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Chapter IV Problem 1
            /*
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
            while(FirstNumberForCheck < SecondNumberForCheck)
            {
                FirstNumberForCheck++;
                if(FirstNumberForCheck % 5 == 0)
                {
                    Console.WriteLine(FirstNumberForCheck);
                }
            }
            Console.WriteLine();
            #endregion

            #region Chapter IV Problem 
            //Create an algorithm that writes out the bigger of two numbers without using conditions
            Console.WriteLine("Enter two numbers: ");
            Console.Write("The first number is: ");
            int FirstCompare = int.Parse(Console.ReadLine());
            Console.Write("The second number is: ");
            int SecondCompare = int.Parse(Console.ReadLine());
            Console.WriteLine("The bigger number is: " + Math.Max(FirstCompare, SecondCompare));
            Console.WriteLine();
            */
            #endregion

            #region Chapter IV Problem 7
            //Create an algorithm that adds up 5 numbers, if a number is invalid, enter a new one
            Console.WriteLine("Enter 5 numbers and the console will add them up.");
            Console.Write("Enter the first Number: ");
            int FirstOf5 = int.Parse(Console.ReadLine());
            Console.Write("Enter the second Number: ");
            int SecondOf5 = int.Parse(Console.ReadLine());
            Console.Write("Enter the third Number: ");
            int ThirdOf5 = int.Parse(Console.ReadLine());
            Console.Write("Enter the fourth Number: ");
            int FourthOf5 = int.Parse(Console.ReadLine());
            Console.Write("Enter the fifth Number: ");
            int FifthOf5 = int.Parse(Console.ReadLine());
            if(FirstOf5 is int)
            {

            }
            #endregion
        }
    }
}
