using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    // Задача А5.
    // Кол-во стингеров: ⅓🔹
    //
    // Написать функцию ArrayOfTiers(int number), которая принимает число и возвращает список чисел, 
    // последовательно отсеченных по одному разряду.
    //
    // Пример:
    // ArrayOfTiers(420) ==> [4, 42, 420]
    // ArrayOfTiers(2021) ==> [2, 20, 202, 2021]
    public static class TaskA5
    {
        public static List<int> ArrayOfTiers(int number)
        {
            List<int> otvet = new List<int>();
            int length = 1;
            int delitel = 10;
            int x;
            while (number > 10)
            {
                number = number / 10;
                length++;

            }
            for (int i = 0; i < length; i++)
            {
                delitel *= 10;
            }
            for (int i = 0; i < length; i++)
            {
                x = number / delitel;
                otvet.Add(x);
                delitel /= 10;
            }
            return otvet;
        }
    }
}
