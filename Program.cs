using System;
using TPZ.Repositories;

namespace TPZ
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("1. Integers to Roman numerals");
            Console.WriteLine("\nChoose the case: ");
            int input = int.Parse(Console.ReadLine());

            switch (input)
            {
                case 1:
                    var intToRoman = new ConverterIntToRoman();
                    Console.WriteLine("Enter a number: ");
                    var result = intToRoman.Convert(int.Parse(Console.ReadLine()));
                    Console.WriteLine(result); 
                    break;
                
                default: 
                    Console.WriteLine("Invalid input");
                    break;
            }
        }
    }
}