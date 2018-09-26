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
            floatOparation(10.45f, 25.98f);
            ByteOparation(15, 25);

            Console.ReadKey();
        }

        public static void floatOparation(float a, float b)
        {
            float c = a + b;
            float k = a - b;
            float d = a * b;

            Console.WriteLine("a+b=" + c);
            Console.WriteLine("a-b=" + k);
            Console.WriteLine("a*b=" + d);

            if (b != 0)
            {
                float f = a / b;
                Console.WriteLine("a/b=" + f);
            }
            else
            {
                Console.WriteLine("You  cant devide by 0");
            }
        }


        public static void ByteOparation(byte a, byte b)
        {
            byte c = (byte)(a + b);
            byte k = (byte)(a - b);
            byte d =(byte) (a * b);

            Console.WriteLine("a+b=" + c);
            Console.WriteLine("a-b=" + k);
            Console.WriteLine("a*b=" + d);

            if (b != 0)
            {
                byte f =(byte)( a / b);
                Console.WriteLine("a/b=" + f);
            }
            else
            {
                Console.WriteLine("You  cant devide by 0");
            }
        }

       
    }
}
