using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Homework
{
    // Задача А4.
    // Кол-во стингеров: ⅓🔹
    //
    // Написать функцию ListOfSums(List<int> list), которая получает на вход
    // список чисел и возвращает только те, которые равны сумме всех
    // предшествующих элементов этого списка.
    //
    // Пример:
    // ListOfSums([2,3,5,6]) ==> [5] -> 5 = 2 + 3;
    // ListOfSums([10,20,30,60,-120,0]) ==> [30,60,0].
    public static class TaskA4
    {
        public static List<int> ListOfSums(List<int> list)
        {
            int sum = 0;
            int length = list.Count;
            List<int> otvet = new List<int>();
            for (int i = 0; i < length; i++)
            {
                
                if (list[i] == sum)
                {
                    otvet.Add(sum);
                }
                sum = sum + list[i];
            }
            return otvet;
        }
    }
}
