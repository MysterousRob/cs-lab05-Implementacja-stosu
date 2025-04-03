using System;

namespace Stos
{
    class Program
    {
        static void Main(string[] args)
        {
            StosWTablicy<string> s = new StosWTablicy<string>(2);
            s.Push("km");
            s.Push("aa");
            s.Push("xx");
            foreach (var x in s.ToArray())
                Console.WriteLine(x);

            Console.WriteLine();
        }
        static void swap(ref int x, ref int y) {
            var temp = x;
            x= y;
            y = temp;
        }
    }
}
