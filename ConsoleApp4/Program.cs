using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            string stringNumber = "256";
            int numberFromString = Convert.ToInt32(stringNumber);
            int square = numberFromString * numberFromString;
            Console.WriteLine("Квадрат введенного числа равен " + square);
        }
    }
}
