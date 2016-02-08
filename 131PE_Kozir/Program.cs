using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _131PE_Kozir
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            int y;
            Console.WriteLine("Введите сумму дневной выручки");
            x = Convert.ToInt32(Console.ReadLine());
            if (x > 10000)
            {
                y = (x - 10000) / 100 * 10 + 500;
            }
            else
            {
                y = (x / 100) * 5;
            }
            Console.WriteLine("Ваш дневной заработок составляет {0}", y);
            Console.ReadKey();
        }
    }
}
