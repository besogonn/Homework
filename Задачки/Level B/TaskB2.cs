using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    // Задача B2.
    // Кол-во стингеров: 🔹
    //
    // Написать функцию OrderWeight(List<int> list), которая сортирует список положительных чисел.
    // Критерий сортировки - возрастание веса числа (сумма всех цифр числа).
    // Если два числа имеют одинаковый вес, сортировать их так, словно они строки.
    //
    // Пример:
    // [56, 65, 74, 100, 99, 68, 86, 180, 90] ==>
    // [100, 180, 90, 56, 65, 74, 68, 86, 99]
    public static class TaskB2
    {
        public static List<int> OrderWeight(List<int> list)
        {
            List<int> otvet = new List<int>();
            List<int> finalotvet = new List<int>();
            int LengthOfList = list.Count;
            int LengthOfNum = 1;
            int LengthOfNum2 = 1;
            int min;
            int delitel = 10;
            int sum = 0;
            int sum2 = 0;
            int temp;

            for (int i = 0; i < LengthOfList; i++)
            {
                while (list[i] > 10)
                {
                    list[i] /= 10;
                    LengthOfNum++;

                }
                sum = 0;
                for (int j = 0; j < LengthOfNum; j++)
                {
                    sum += (list[i] % delitel);
                    delitel *= 10;
                }
                otvet.Add(sum);
            }
            for (int i = 0; i < LengthOfList; i++)
            {
                min = otvet[i];
                for (int j = 0; j < LengthOfList; j++)
                {
                    if (min < otvet[j])
                        min = otvet[j];
                }
                for (int j = 0; j < LengthOfList; j++)// везде используется LengthOfList потому что все три списка имеют одинаковую длину
                {
                    if (min == otvet[j])
                    {
                        finalotvet.Add(list[j]);
                        list.Remove(list[j]);// это нужно, чтобы сохранить связь двух списков по индесам
                        otvet.Remove(otvet[j]);
                        break;
                    }
                        
                }
            }
            for (int i = 0; i < LengthOfList - 1; i++)// последний этап сортировкию, если некоторые суммы цифр совпадут
            {
                LengthOfNum = 1;//сброс временных переменных, чтобы получисля адекватный ответ
                delitel = 10;
                sum = 0;
                while (finalotvet[i] > 10)
                {
                    finalotvet[i] /= 10;
                    LengthOfNum++;

                }
                for (int j = 0; j < LengthOfNum; j++)
                {
                    sum += (finalotvet[i] % delitel);
                    delitel *= 10;
                }
                
                for (int l = 1; l < LengthOfList; l++)
                {
                    
                    delitel = 10;
                    while (finalotvet[l] > 10)
                    {
                        finalotvet[l] /= 10;
                        LengthOfNum2++;

                    }
                    for (int j = 0; j < LengthOfNum; j++)
                    {
                        sum2 += (finalotvet[l] % delitel);
                        delitel *= 10;
                    }

                    if (sum == sum2)
                    {
                        if (LengthOfNum < LengthOfNum2)
                        {
                            temp = finalotvet[i];
                            finalotvet[i] = finalotvet[l];
                            finalotvet[l] = temp;

                        }
                    }
                }
                
            }

                return finalotvet;
        }
    }
}
