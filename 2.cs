using System;
using System.Collections.Generic;

namespace Learn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;  // Вспомогательная переменная
            int sum = 0;  // Сумма всех чисел
            Console.Write("Введите число: ");
            string s = Console.ReadLine();
            List<int> array = new List<int>();  // Я хуй знает, как решить эту задачу через массивы, поэтому тут будет список целых чисел List

            while (true)  // Бесконечный цикл
            {
                if (int.TryParse(s, out a))  // Если s можно преобразовать в int, тогда преобразовываем
                {
                    array.Add(Convert.ToInt32(s));  // Добавление в список введенное число
                    Console.Write("Введите число: ");
                    s = Console.ReadLine();
                }
                else
                {
                    break;  // Если s нельзя преобразовать в int, тогда запускается блок else, в котором останавливаем цикл
                }
            }

            for (int i = 0; i < array.Count; i++)  // Сумма всех элементов (array.Count — это длинна списка array)
            {
                sum += array[i];
            }

            Console.WriteLine($"Среднее арифметическое равно: {Convert.ToDouble(sum) / array.Count}");

            /* ПОЯНСЕНИЕ:
             * Сверху используется Convert.ToDouble для того, чтобы вывелась целая и дробная часть
             * Если убрать Convert, то выведется только целая часть, а дробная откинется
             */
        }
    }
}
