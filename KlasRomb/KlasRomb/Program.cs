using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ClassRomb
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1
            Romb obj1 = new Romb(6, 3);
            Console.WriteLine($"S={obj1.Lice():f2}");
            Console.WriteLine($"P={obj1.Perimetur():f2}");
            //Console.WriteLine(obj1.ToString());
            obj1.Izhod();

            //2
            Romb obj2= new Romb(double.Parse(Console.ReadLine()),double.Parse(Console.ReadLine()));
            Console.WriteLine($"S={obj2.Lice():f2}");
            Console.WriteLine($"P={obj2.Perimetur():f2}");

            Console.WriteLine("Count=");
            int count = int.Parse(Console.ReadLine());

            List <Romb> list = new List<Romb>();
            for (int i = 0; i < count; i++)
            {
                var danni = Console.ReadLine().Split(' ');
                Romb r = new Romb(double.Parse(danni[0]), double.Parse(danni[1]));
                list.Add(r);
            }
            foreach (var obj in list)
            {
                Console.WriteLine($"S={obj1.Lice():f2}");
                Console.WriteLine($"P={obj1.Perimetur():f2}");
            }
            //list.ForEach(x=>x.Izhod());

        }
    }
}
