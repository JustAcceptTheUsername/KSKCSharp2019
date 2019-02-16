using System;

namespace Chapter_III_Problems
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Chapter III Problem 1
            //Create an algorithm that checks if a number is odd or even
            Console.WriteLine("Check if a number is odd or even");
            int Number = int.Parse(Console.ReadLine());
            if(Number%2 == 0)
            {
                Console.WriteLine("It is even");
            }
            else
            {
                Console.WriteLine("It is odd");
            }
            Console.WriteLine();
            #endregion

            #region Chapter III Problem 2
            //Create an algorithm that checks if a number can be divided by either 5 or 7
            bool Divider;
            Console.WriteLine("Enter a number to check if it's devidable by either 5 or 7 ");
            int Number1 = int.Parse(Console.ReadLine());
            if (Number1 % 5 == 0 || Number1 % 7 == 0)
            {
                Divider = true;
                Console.WriteLine(Divider);
            }
            else
            {
                Divider = false;
                Console.WriteLine(Divider);
            }
            Console.WriteLine();
            #endregion

            #region Chapter III Problem 3
            //Create an algorithm that chekcs if the third digit of a number (Right to left) is 7
            Console.WriteLine("Enter a number between 100 and 999");
            int Number2 = int.Parse(Console.ReadLine());
            int Number3 = Number2 / 100;
            Number3 = Number3 % 10;
            Console.WriteLine(Number3);
            if (Number3 == 7) Console.WriteLine("It does");
            else Console.WriteLine("Nah");
            Console.WriteLine();
            #endregion

            #region Chapter III Problem 5
            //Create an algorithm that calculates the surface area of a trapeze [tra-,trəˈpēz]
            Console.WriteLine("Calculate the surface area of a Trapeze");
            Console.Write("A = ");
            double A = double.Parse(Console.ReadLine());
            Console.Write("B = ");
            double B = double.Parse(Console.ReadLine());
            Console.Write("H = ");
            double H = double.Parse(Console.ReadLine());
            Console.Write("The surface area of the trapeze, S, is: ");
            double S = ((A + B) * H) / 2;
            Console.WriteLine(S);
            Console.WriteLine();
            #endregion

            #region Chapter III Problem 6
            //Create an algorithm that calculates the perimeter and surface area of a rectangle
            Console.WriteLine("Calculate the Perimeter and the Surface area of a rectangle");
            Console.Write("A = ");
            int RectangleA = int.Parse(Console.ReadLine());
            Console.Write("B = ");
            int RectangleB = int.Parse(Console.ReadLine());
            int RectangleP = (RectangleA + RectangleB) * 2;
            Console.WriteLine("The Perimeter of the rectangle is: " + RectangleP);
            int RectangleS = RectangleA * RectangleB;
            Console.WriteLine("The Surface are of the rectangle is: " + RectangleS);
            Console.WriteLine();
            #endregion

            #region Chapter III Problem 7
            //Calculate one's gravity on the Moon /Moon gravity is 17% as strong as Earth's/
            Console.Write("Enter your weight: ");
            double Weight = int.Parse(Console.ReadLine());
            Console.WriteLine("Your weight on the Moon would be: " + Weight * 0.17);
            Console.WriteLine();
            #endregion

            #region Chapter III Problem 8
            //Create an alogrithm that checks if a point is inside a circle with R = 5
            Console.WriteLine("Enter the parameters of the point (X, Y)");
            Console.Write("X = ");
            int X = int.Parse(Console.ReadLine());
            Console.Write("Y = ");
            int Y = int.Parse(Console.ReadLine());
            if (X > -5 && X < 5 && Y > -5 && Y < 5) Console.WriteLine("The point O(" + X + ',' + ' ' + Y + ")is in the circle");
            else Console.WriteLine("The point O is not in the circle");
            Console.WriteLine();
            #endregion

            #region Chapter III Problem 9
            //Create an alogrithm that checks if a point is inside a circle with R = 5 and outside a rectangle with edges (-1, 1) and (5, 5)
            Console.WriteLine("Enter the parameters of the point (X, Y)");
            Console.Write("X = ");
            int SecondX = int.Parse(Console.ReadLine());
            Console.Write("Y = ");
            int SecondY = int.Parse(Console.ReadLine());
            if (X > -5 && X < -1 && Y > -5 && Y < 1) Console.WriteLine("The point O(" + X + ',' + ' ' + Y + ")is in the circle and outside the rectangle");
            else Console.WriteLine("The conditions have not been met");
            Console.WriteLine();
            #endregion

        }
    }
}
