using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    // Задача А6.
    // Кол-во стингеров: ⅓🔹
    //
    // Написать функцию OddNumbers, которая получает на вход список целых чисел arr и целое число n и
    // возвращает список, состоящий из n последних вхождений нечетных чисел списка arr в том же порядке
    //
    // Пример:
    // ([1, 2, 3, 4, 5, 6, 7, 8, 9], 3) => [5, 7, 9]
    public static class TaskA6
    {
        public static List<int> OddNumbers(List<int> arr, int n)
        {
            int x;
            int count = 0;
            int length = arr.Count();
            List<int> otvet = new List<int>();
            arr.Sort();
            arr.Reverse();

            
            
            for (int i = 0; i < length; i++)
            {
                if (count == n)
                    break;
                x = arr[i] % 2;
                if (x == 0)
                {
                    x = arr[i];
                    otvet.Add(x);
                    count++;
                }

            }
            

            return otvet;
        }
    }
}
