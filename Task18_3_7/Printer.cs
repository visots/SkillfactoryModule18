using System;

namespace Task18_3_7
{
    internal class Printer
    {
        public void Start(int size, string material)
        {
            if (size < 10)
                Print("M", "small");
            else if (size < 90)
                Print("L", "medium");
            else
                Print("XL", "large");
        }

        static void PrintInfo(string material)
        {
            Console.WriteLine($"Awesome Print on {material}!");
        }

        private static void Print(string sizeCode,string sizeName)
        {
            Console.WriteLine($"Size {sizeCode}");
            Console.WriteLine($"printing on {sizeName} canvas");
        }
    }
}