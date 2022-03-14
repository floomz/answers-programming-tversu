using System;

namespace Learn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int[] dividers;  //Объявление массива, в котором будут лежать числители
            int j = 0;  //Вспомогательная переменная


            if (num > 0)
            {
                dividers = new int[num];  //Если num больше 0, то создаем массив длинной num
                Console.WriteLine($"Число {num} положительное.");  //Проверка на положительность

                if (num % 2 == 0)  //Проверка на четность
                {
                    Console.WriteLine($"Число {num} четное.");
                }
                else
                {
                    Console.WriteLine($"Число {num} нечетное.");
                }

                for (int i = 1; i <= num; i++)  //Заполняем массив dividers числителями num
                {
                    if (num % i == 0)
                    {
                        dividers[j] = i;
                        j++;
                    }
                }

                if (dividers.Length > 2)  //Проверка на составность числа
                {
                    Console.WriteLine($"Число {num} составное.");
                    Console.Write($"Делители числа {num}: ");

                    for (int k = 0; k < dividers.Length; k++)  //Вывод числителей num
                    {
                        if (dividers[k] != 0)
                        {
                            Console.Write($"{dividers[k]} ");
                        }
                    }

                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine($"Число {num} простое.");
                }
            }
            else if (num < 0)
            {
                Console.WriteLine($"Число {num} отрицательное.");
            }
            else
            {
                Console.WriteLine("Введенное число равно нулю.");
            }
        }
    }
}
