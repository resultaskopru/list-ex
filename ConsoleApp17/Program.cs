using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ConsoleApp17
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> gs1 = new List<int>();
            Random r = new Random();
            for (int i = 0; i < 10; i++)
            {
                gs1.Add(r.Next(100));
            }
            foreach (int item in gs1)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("////////////////////////");
            for (int i = 0; i < 5; i++)
            {
                int gd = gs1[i];
                gs1[i] = gs1[gs1.Count - 1 - i];
                gs1[gs1.Count - 1 - i] = gd;
            }
            foreach (var item in gs1)
            {
                Console.WriteLine(item);
            }
        }
    }
}
