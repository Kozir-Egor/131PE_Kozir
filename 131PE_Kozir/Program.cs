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

            int i = 0;
            int[] r;
            Sot[] array = new Sot[3];
            Console.WriteLine("Введите название файла");
            string name = Console.ReadLine();
            Console.WriteLine("Введите фамилию сотрудника");
            string FIO = Console.ReadLine();
            using (StreamReader reader = new StreamReader(name, Encoding.Default))
            {
                for (i = 0; i < 3; i++)
                {
                    array[i] = new Sot(reader.ReadLine().Split('|'));
                    string[] mas = File.ReadAllText(name).Split(new char[] { ' ' });
                }
            }
            if (!Sot.CheckFIO(FIO, array))
            {
                Console.WriteLine("не найдено");
            }
            else
                foreach (Sot s in array)
                    if (s.FIO == FIO)
                        
                        s.Show();

            //string[] mas = File.ReadAllText(name).Split(new char[]{' '});
            // int[] array = new int[mas.Length];
            // for(i = 0; i < mas.Length; i++)
            // {
            //   array[i] = Int32.Parse(mas[i]);
            // }
            // t = Array(array);
            //for (i = 0; i < t.Length; i++ )                //для вывода полученного массива!
            // {
            //     Console.Write(t[i]);
            //      Console.Write(' ');
            // }
            //Console.WriteLine("Заработок равен: {1} ", r.Sum());

            Console.ReadKey();
        }
        struct Sot
        {
            public string FIO;
            public string rur;

            public Sot(string[] args)
            {
                FIO = args[0];
                rur = args[1];
            }


            static public bool CheckFIO(string FIO, Sot[] array)
            {
                bool temp = false;
                foreach (Sot s in array)
                    if (s.FIO == FIO)
                        temp = true;
                return temp;
            }
            public void Show()
            {
                int i = 0;
                //Console.WriteLine("\nФИО: {0} и заработок {1}", FIO, rur);
                string[] mas = rur.Split(new char[] { ' ' });
                int[] array = new int[mas.Length];
                for (i = 0; i < mas.Length; i++)
                {
                    array[i] = Int32.Parse(mas[i]);
                    //Console.WriteLine(mas[i]);
                }
                int[] t;
                t = Array(array);
                //for (i = 0; i < t.Length; i++)
                //{
                //    Console.Write(t[i]);
                //    Console.Write(' ');
                //}
                int sum = t.Sum();
                Console.WriteLine("Сумма заработка сотрудника {0}: {1} ", FIO, sum);
            }
        }
    }
}