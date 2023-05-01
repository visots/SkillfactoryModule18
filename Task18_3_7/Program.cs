using System.Reflection;

namespace Task18_3_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var printer = new Printer();
            printer.Start(15, "Canvas");
        }
    }
}