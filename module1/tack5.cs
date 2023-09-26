using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module1
{
    class Task5
    {
        public static void FizzBuzz()
        {
            // Задание 5: FizzBuzz
            //вывод чисел от 1 до 100
            for (int i = 1; i <= 100; i++)
            { //если делется на 3 и 5 менять на FizzBuzz
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                //если только на 3 то Fizz
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                //если только на 3 то Buzz
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                //если не делиться то оставлять не тронутым 
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
