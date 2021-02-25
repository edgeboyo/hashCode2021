using System;

namespace hashCode2021
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Reader r = new Reader();

            Info a = r.ReadInfo("in/a.txt");
            Info b = r.ReadInfo("in/b.txt");
            Info c = r.ReadInfo("in/c.txt");
            Info d = r.ReadInfo("in/d.txt");
            Info e = r.ReadInfo("in/e.txt");
            Info f = r.ReadInfo("in/f.txt");

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
