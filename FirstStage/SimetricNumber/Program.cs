using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimetricNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int k = number;
            int rev = 0;
            while(k>0)
            {
                int s = k % 10;
                rev = rev * 10 + s;
                k = k / 10;
            }
            if (number==rev)
            {
                Console.WriteLine("Number  is  simetric");
            }
            else
            {
                Console.WriteLine("Number  is not  simetric");
            }

            
        }
    }
}
