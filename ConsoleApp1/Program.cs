using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("x=");
            //int x = int.Parse(Console.ReadLine());
            //Console.Write("y=");
            //int y = int.Parse(Console.ReadLine());
            //Console.WriteLine($"{x}+{y}={x+y}");


            //Console.Write("x=");
            //int x = int.Parse(Console.ReadLine());
            //Console.Write("y=");
            //int y = int.Parse(Console.ReadLine());
            //Console.Write("z=");
            //int z = int.Parse(Console.ReadLine());
            //Console.WriteLine($"{x}+{y}+{z}={x + y + z}");


            //Console.Write("Номинал купюры = ");
            //int x = int.Parse(Console.ReadLine());
            //Console.Write("Кол-во купюр = ");
            //int y = int.Parse(Console.ReadLine());
            //Console.Write($"Сумма денег = {x*y:f2}");



            Console.Write("x = ");
            int x = int.Parse(Console.ReadLine());
            int d = x/10;
            Console.WriteLine($"Число десятков = {d}");
            int e = x%10;
            Console.WriteLine($"Число единиц =  {e}");
            Console.WriteLine($"{x}={d}{e}");
            Console.ReadLine();


        }
    }
}
