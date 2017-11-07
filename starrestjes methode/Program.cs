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

        }

        static void TekenSterretjes(int count)
        {
            for (var i = 0; i < count; i++)
            {
                Console.Write('*');
            }
            Console.WriteLine();
        }
    }
}
