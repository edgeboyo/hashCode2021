using System;

namespace hashCode2021
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Reader r = new Reader();

            Info inf = r.ReadInfo("in/a.txt");

            Brute1 b1 = new Brute1(inf);
            b1.Do();
        }
    }
}
