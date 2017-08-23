using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pengamatan2
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int a = 0, b = 5; ((a <= 5) && (b >= 0)); b--, a++)
            {
                Console.WriteLine("{0} {1} {2}\t", a, (a > b ? '>' : '<'), b);
                if(a==4)
                {
                    Console.WriteLine("Perbandingan Selesai");
                    b--;
                }
                else
                {
                    Console.WriteLine("perbandingan lanjut");
                }
            }
            Console.ReadKey();
        }
    }
}
