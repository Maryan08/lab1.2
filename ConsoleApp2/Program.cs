using System;

namespace ConsoleApp2
{
    public class Program
    {
        static public int Example(int d)
        {

            string d1 = Convert.ToString(d);

            char[] x = d1.ToCharArray();

            char x0 = x[0];
            char x2 = x[2];
            x[0] = x2;
            x[2] = x0;

            string str = new string(x);
            d = int.Parse(str);
            Console.WriteLine("d = {0}", d);
            return d;
        }
        static void Main(string[] args)
        {
            Console.Write("d = ");
            int d = int.Parse(Console.ReadLine());
            Example(d);




        }
    }
}
