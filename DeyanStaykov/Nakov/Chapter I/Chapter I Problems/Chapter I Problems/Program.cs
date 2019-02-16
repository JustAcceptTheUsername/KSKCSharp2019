using System;

namespace Chapter_I_Problems
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Chapter I Problem 5
            //"Modify the algorithm so it says something different(i.e "Greetings")
            Console.WriteLine("Hello There");
            #endregion

            #region Chapter I Problem 6
            //Create an algorithm that writes out your Name
            Console.WriteLine("General Kenobi");
            #endregion

            #region Chapter I Problem 7
            //Create an algorithm that writes out the numbers "1 101 1001" each on new line 
            Console.WriteLine(1);
            Console.WriteLine(101);
            Console.WriteLine(1001);
            #endregion

            #region Chapter I Problem 8
            //Create an algorithm that writes out the current time
            Console.WriteLine(DateTime.Now);
            #endregion

            #region Chapter I Problem 9
            //Create an algorithm that calculates the root of 12345
            Console.WriteLine(Math.Sqrt(12345));
            #endregion

            #region Chapter I Problem 10
            //Create an algorithm that completes the first 100 charecters of this array 2, -3, 4, -5... 
            int ArrayNumber = 2;
            while (ArrayNumber > -100 && ArrayNumber < 100)
            {
                if (ArrayNumber > 0)
                {
                    ArrayNumber++;
                    ArrayNumber = -ArrayNumber;
                }
                else
                {
                    ArrayNumber--;

                    ArrayNumber = -ArrayNumber;
                }
                Console.WriteLine(ArrayNumber + ", ");
            }
            #endregion

            #region Chapter I Problem 11
            //Create an algorithm that takes the user input age and adds 10 to it 
            Console.WriteLine("What is your age?");
            int Age = int.Parse(Console.ReadLine());
            Age = Age + 10;
            Console.WriteLine("Your age in 10 years will be " + Age);
            #endregion

        }
    }
}
