using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    // Задача А2.
    // Кол-во стингеров: ⅓🔹
    //
    // Написать функцию VeryEven(number), которая определяет является ли число "очень четным".
    // Однозначное число "очень четное", если оно четное. Числа больше 10 "очень четные",
    // если сумма их цифр - "очень четное" число.
    //
    // Примеры:
    // VeryEven(88) => false -> 8 + 8 = 16 -> 1 + 6 = 7 => 7 - нечетное;
    // VeryEven(222) => true -> 2 + 2 + 2 = 8 => 8 - четное.
    public static class TaskA2
    {
        public static bool VeryEven(int number)
        {
            int sum = 0;
            int delitel = 10;
            int length = 1;
            int x;
            if (number < 10)
            {
                x = number % 2;
                if (x == 0)
                    return true;
                else
                    return false;
            }
                
            else
            {
                while (number > 10)
                {
                    number /= 10;
                    length++;

                }

                for (int i = 0; i < length; i++)
                {
                    sum = sum + (number % delitel);
                    delitel *= 10;
                }
                x = sum % 2;
                if (x == 0)
                    return true;
                else
                    return false;
            }

            
        }
    }
}
