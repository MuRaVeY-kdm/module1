using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module1
{
    class Task3
    {
        public static void Substring()
        {
            // Задание 3: Проверка наличии 2-ой строки в 1-ой строке (подстроки)
            //ввод строк
            Console.Write("Введите первую строку: ");
            string str1 = Console.ReadLine();
            Console.Write("Введите вторую строку: ");
            string str2 = Console.ReadLine();
            //проверка явл. ли 2-я строка, подстрокой 1-ой
            //да
            if (str1.Contains(str2))
            {
                Console.WriteLine("Вторая строка является подстрокой первой строки.");
            }
            //нет
            else
            {
                Console.WriteLine("Вторая строка не является подстрокой первой строки.");
            }
        }
    }
}
