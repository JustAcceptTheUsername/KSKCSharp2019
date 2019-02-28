using System;

class Program
{
    static void Main(string[] args)
    {
        #region Chapter VII Problem 1
        //Create an algorithm that prints out 20 array numbers, which are equal to their index multiplied by 5
        //Console.WriteLine("How many numbers do you want your array to hold?");
        //Console.Write("The number of elements I want my array to hold is: ");
        //int arrayItems = int.Parse(Console.ReadLine());
        //int[] firstArray = new int[arrayItems];
        //for (int i = 0; i < firstArray.Length; i++)
        //{
        //    firstArray[i] = int.Parse(Console.ReadLine());
        //}
        //for (int i = 0; i < firstArray.Length; i++)
        //{
        //    Console.Write(firstArray[i] * 5 + " ");
        //}
        #endregion

        //Create an algorithm that checks if the elements from one array are the same from another
        Console.WriteLine("Enter elements for a second array and" + Environment.NewLine
            + "check if the first array has the exact same elements.");
        Console.Write("I want the number of elements for the second array to be: ");
        int secondarrayItems = int.Parse(Console.ReadLine());
        int arrayItems = secondarrayItems;
        if (secondarrayItems == arrayItems)
        {
            int[] secondArray = new int[secondarrayItems];
            for (int i = 0; i < secondArray.Length; i++)
            {
                secondArray[i] = int.Parse(Console.ReadLine()); //This is far from done
            }
            for (int i = 0; i < secondArray.Length; i++)
            {
                secondArray[i] = int.Parse(Console.ReadLine());
            }
            
        }
        else Console.WriteLine("The arrays have the same elements.");
    }
}

