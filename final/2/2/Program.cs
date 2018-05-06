using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 2; i++)
            {
                FileInfo fi = new FileInfo(@"C:\Users\Асер\Desktop\final\test\" + i + ".txt");
                fi.OpenText();
            }

            Console.ReadKey();
        }
    }
}
