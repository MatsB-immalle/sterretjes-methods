using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace starrestjes_methode
{
    class Program
    {
        static void Main(string[] args)
        {
            TekenSterretjes(100);
            
            TekenSterretjes(200);
            string sterretjes1 = MaakSterretjes(300);
            string sterretjes2 = MaakSterretjes(400);
            Console.WriteLine(sterretjes1);
            Console.WriteLine(sterretjes2);

        }

        static void TekenSterretjes(int count)
        {
            for (var i = 0; i < count; i++)
            {
                Console.Write('*');
            }
            Console.WriteLine();
        }

        static string MaakSterretjes(int count)
        {
            return "";

        }
    }
}
