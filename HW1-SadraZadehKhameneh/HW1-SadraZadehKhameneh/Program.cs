using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1_SadraZadehKhameneh
{
    class Program
    {
        static void Main(string[] args)
        {
            Int32[] Number = new Int32[10];
            for(int i=0;i<=9;i++)
            {
                Number[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine(Class.Sort_10_number.FindMaxInTenNumber(Number));
            Console.ReadKey();
        }
    }
}
