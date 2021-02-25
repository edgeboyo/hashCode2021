using System;

namespace hashCode2021
{
    class Program
    {
        static void Main(string[] args)
        {
            Reader r = new Reader();

            Info a = r.ReadInfo("in/a.txt");
            Console.WriteLine("A loaded...");
            Info b = r.ReadInfo("in/b.txt");
            Console.WriteLine("B loaded...");
            Info c = r.ReadInfo("in/c.txt");
            Console.WriteLine("C loaded...");
            Info d = r.ReadInfo("in/d.txt");
            Console.WriteLine("D loaded...");
            Info e = r.ReadInfo("in/e.txt");
            Console.WriteLine("E loaded...");
            Info f = r.ReadInfo("in/f.txt");
            Console.WriteLine("F loaded...");

            Brute1 b1 = new Brute1(a);
            //b1.Do();

            Console.WriteLine("Going to compute...");

            Brute2 b2 = new Brute2();
            
            Writer.WriteResult(b2.compute(a), "out/a.txt");
            Writer.WriteResult(b2.compute(b), "out/b.txt");
            Writer.WriteResult(b2.compute(c), "out/c.txt");
            Writer.WriteResult(b2.compute(d), "out/d.txt");
            Writer.WriteResult(b2.compute(e), "out/e.txt");
            Writer.WriteResult(b2.compute(f), "out/f.txt");
        }
    }
}
