﻿namespace Task4
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            /*Напишете програма, която отпечатва три числа в три виртуални колони на конзолата.Всяка колона трябва да е с широчина 10 символа, а числата трябва да са ляво подравнени.
            Първото число трябва да е цяло число в шестнадесетична бройна система, второто да е дробно положи­телно, а третото – да е дробно отрицателно.
            Последните две числа да се закръглят до втория знак след десетичната запетая.*/

            Console.Write("Write a full number:");
            int fn = int.Parse(Console.ReadLine());
            Console.Write("Write a fractional number:");
            double fran = double.Parse(Console.ReadLine());
            Console.Write("Write a negative fractional number:");
            double nfran = double.Parse(Console.ReadLine());

            Console.WriteLine("{0,-10:X}{1,-10:F2}{2,-10:F2}", fn, fran, nfran);

        }
    }
}
