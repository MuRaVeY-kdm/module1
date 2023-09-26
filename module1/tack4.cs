using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module1
{
    class Task4
    {
        public static void SumArray()
        {
            // Задание 4: Сумма элементов массива
            //создание массива из 10 значений
            int[] numbers = new int[10];
            int sum = 0;
            Random rnd = new Random();
            //заполнение массива из 1- элементов случайными значениями, суммирование значений
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rnd.Next(1, 101);
                sum += numbers[i];
            }
            //вывод массива
            Console.WriteLine("Массив случайных чисел:");
            foreach (int num in numbers)
            {
                Console.Write(num + " ");
            }
            //вывод суммы элементов
            Console.WriteLine("Сумма элементов массива: " + sum);
        }
    }
}
