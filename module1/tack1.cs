using System;

namespace module1
{
    class tack1
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Выберите задание:");
                Console.WriteLine("1. Угадай число");
                Console.WriteLine("2. Среднее арифметическое");
                Console.WriteLine("3. Подстрока");
                Console.WriteLine("4. Сумма элементов массива");
                Console.WriteLine("5. FizzBuzz");
                Console.Write("Задание:");
                int tack = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                switch (tack)
                {
                    case 1://задание 1, поиск заданого числа
                        Task1.randomnumber();
                        break;
                    case 2://задание 2, среднее арифметическое 
                        Task2.arifmetic();
                        break;
                    case 3://задание 3, проверка строк на подстроки
                        Task3.Substring();
                        break;
                    case 4://задание 4, сумма значений массива
                        Task4.SumArray();
                        break;
                    case 5://замена значений при делении
                        Task5.FizzBuzz();
                        break;
                }
            }
        }
    }

    class Task1
    {
        public static void randomnumber()
        { //получение рандомного числа
            Random ran = new Random();
            int n = ran.Next(1, 101);

            Console.WriteLine("Угадай число от 1 до 100.");
            // проверка ввода на соответствие рандомного числа
            while (true)
            {//ввод числа
                Console.Write("Введите догадку: ");
                int t = Convert.ToInt32(Console.ReadLine());
                //если заданное число больше
                if (t < n)
                {
                    Console.WriteLine("Загаданное число больше.");
                }
                //если заданное число меньше
                else if (t > n)
                {
                    Console.WriteLine("Загаданное число меньше.");
                }
                else
                //если число совпало
                {
                    Console.WriteLine("Правильно загаданное число:"+n);
                    break;
                }
            }
        }
    }
}