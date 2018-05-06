using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int cnt1 = 0;
            int cnt2 = 0;

            string[] ss = s.Split(' '); 

            for(int i = 0; i<= ss.Length; i++)
            {
                for (int j = 0; j < ss[i].Length/2; j++)
                {
                    if(ss[i][j] != ss[i][ss[i].Length - j - 1])
                    {
                        break;
                    }
                    cnt2++;
                }
            }

            cnt1 = ss.Length;

            Console.WriteLine(cnt1);
            Console.WriteLine(cnt2);

            Console.ReadKey();
        }
    }
}
