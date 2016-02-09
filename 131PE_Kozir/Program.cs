using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            int n;
            int i = 0;
            int[] t;
            Console.WriteLine("Введите кол-во дней от 5 до 7, нажмите Enter");
            n = Convert.ToInt32(Console.ReadLine());
            if (n >= 5 && n <= 7)
            {
                Console.WriteLine("Введите заработок за каждый день, после вводе напишите end");
            }
            else
            {

                Console.WriteLine("ошибка!");
                Console.ReadKey();
                return;
            }


            int[] array = new int[n];
            string a;
            while ((a = Console.ReadLine()) != "end") //Получаем строку и проверяем ее содержание
                array[i++] = Convert.ToInt32(a); //в стркое нет "конца" - значит конвертим и пишем в массив

            for (int k = 0; k < i; k++) //вывод заполненных ячеек массива
            { }
            t = Array(array);
            //for (i = 0; i < t.Length; i++ )                //для вывода полученного массива!
            //{
            //    Console.Write(t[i]);
            //    Console.Write(' ');
            //}
            Console.WriteLine("Заработок за {0} дней равен: {1} ", n, t.Sum());

            Console.ReadKey();
        }


    }
}