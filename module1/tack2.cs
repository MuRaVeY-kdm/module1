using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module1
{
    class Task2
    {
        public static void arifmetic()
        {
            // Задание 2: Среднее арифметическое 3-х чисел
            //ввод значений
            Console.Write("Введите первое число: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите второе число: ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите третье число: ");
            double num3 = Convert.ToDouble(Console.ReadLine());
            //нахождение среднего арифметического
            double num = (num1 + num2 + num3) / 3;
            Console.WriteLine("Среднее арифметическое:" + num);
        }
    }
}
