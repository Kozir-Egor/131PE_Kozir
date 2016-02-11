using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _131PE_Kozir_3
{
    class Program
    {
        static int[] Array(int[] array)
        {

            int[] p = new int[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                if (i > 4)
                {
                    if (array[i] <= 100000)
                    {
                        p[i] = array[i] / 100 * 15;
                    }
                    if (array[i] > 10000)
                    {
                        p[i] = ((array[i] - 10000) / 100 * 10 + 500) * 2;
                    }
                    else
                    {
                        p[i] = (array[i] / 100) * 5;
                    }
                    
                }
                else
                {
                    if (array[i] > 10000)
                    {
                        p[i] = (array[i] - 10000) / 100 * 10 + 500;
                    }
                    else
                    {
                        p[i] = (array[i] / 100) * 5;
                    }

                }

            }
            return p;


        }


        static void Main(string[] args)
        {

            int i = 0;
            int[] t;
            Console.WriteLine("ВВедите название файла");
            string name = Console.ReadLine();
            string[] mas = File.ReadAllText(name).Split(new char[]{' '});
            int[] array = new int[mas.Length];
            for(i = 0; i < mas.Length; i++)
            {
               array[i] = Int32.Parse(mas[i]);
            }
            t = Array(array);
          //for (i = 0; i < t.Length; i++ )                //для вывода полученного массива!
          // {
          //     Console.Write(t[i]);
          //      Console.Write(' ');
          // }
            Console.WriteLine("Заработок равен: {1} ", t.Sum());

            Console.ReadKey();
        }


    }
}