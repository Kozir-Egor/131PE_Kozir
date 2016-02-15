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
        static int[] Array(int[] mas)
        {

            int[] p = new int[mas.Length];

            for (int i = 0; i < mas.Length; i++)
            {
                if (i > 4)
                {
                    if (mas[i] <= 100000)
                    {
                        p[i] = mas[i] / 100 * 15;
                    }
                    if (mas[i] > 10000)
                    {
                        p[i] = ((mas[i] - 10000) / 100 * 10 + 500) * 2;
                    }
                    else
                    {
                        p[i] = (mas[i] / 100) * 5;
                    }

                }
                else
                {
                    if (mas[i] > 10000)
                    {
                        p[i] = (mas[i] - 10000) / 100 * 10 + 500;
                    }
                    else
                    {
                        p[i] = (mas[i] / 100) * 5;
                    }

                }

            }
            return p;


        }


        static void Main(string[] args)
        {

            int[] r;
            List<Week> weeks = new List<Week>();
            Console.WriteLine("Введите название файла");
            string name = Console.ReadLine();
            //Console.WriteLine("Введите фамилию сотрудника");

            using (StreamReader reader = new StreamReader(name, Encoding.Default))
            {
                while(! reader.EndOfStream)
                {
                    string[] parseLine = reader.ReadLine().Split(';');

                    weeks.Add(new Week(
                        DateTime.Parse(parseLine[0]), 
                        parseLine.Skip(1).Select(a => Int32.Parse(a)).ToArray())
                    );
                }
            }

            for (int i = 0; i < weeks.Count; i++)
            {
                weeks[i].Show();
            }

            //if (!Sot.CheckFIO(FIO, array))
            //{
            //    Console.WriteLine("Сотрудник не найден");
            //}
            //else
            //    foreach (Sot s in array)
            //        if (s.FIO == FIO)
            //            s.Show();
            Console.ReadKey();
        }

        public class Week
        {
            public DateTime Date { get; set; }
            public int[] Results { get; set; }

            public Week(DateTime dt, int[] results)
            {
                Date = dt;
                Results = results;
            }
            //static public bool CheckFIO(string FIO, Sot[] array)
            //{
            //    bool temp = false;
            //    foreach (Sot s in array)
            //        if (s.FIO == FIO)
            //            temp = true;
            //    return temp;
            //}
            public void Show()
            {
                int sum = Array(Results).Sum();
                Console.WriteLine("Сумма заработка сотрудника {0}: {1} ", Date, sum);
            }
        }
    }
}