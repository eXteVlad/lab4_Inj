using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Laboratory;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            MyInt a = new MyInt(20);
            MyInt b = new MyInt(20);

            a = a.Multiply(b);
            Console.WriteLine(a.Value);

            MyInt dde = new MyInt(462);
            MyInt tte = new MyInt(1071);
            MyInt ans = new MyInt(21);
            dde = dde.Gcd(tte);

            Console.WriteLine(dde.Value);
            Console.WriteLine(dde.longValue());

            Console.WriteLine("Нажмите любую клавишу");
            Console.ReadKey();            
        }
    }
}
