using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_4._2_dop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            int sum1 = 0;
            int sum2 = 0;
            do
            {
                Console.Write("Введите число: ");
                number = Convert.ToInt32(Console.ReadLine());
                if (number > 0) 
                {
                    sum1++; // счетчик положительных чисел
                }
                else if (number < 0)
                {
                    sum2++; // счетчик отрицательных чисел
                }
            }
            while (number != 0); // если ввести 0. то цикл останавливается

            if (sum1 > sum2)
            {
                Console.WriteLine("Количество положительных чисел {0} больше отрицательных {1}", sum1, sum2);
            }

            else
            {
                Console.WriteLine("Количество отрицательных чисел {0} больше положительных {1}", sum2, sum1);
            }
            Console.WriteLine("Для завершения нажмите на любого клавиша");
            Console.ReadKey();
        }

    }
}
