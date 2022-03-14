using System;

namespace Learn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] one = new int[10];  // Массив для первого кубика
            int[] two = new int[10];  // Массив для второго кубика
            int res;  // Результат броска
            Random random = new Random();  // Объект для работы с рандомными числами

            for (int i = 0; i < 10; i++)  // Заполнение массивов кубиков
            {
                one[i] = i;
                two[i] = 10 * i;
            }

            Console.Write("Нажмите Enter, чтобы бросить кубики или введите Exit для выхода: ");

            while (Console.ReadLine() != "Exit")
            {
                res = one[random.Next(0, one.Length)] + two[random.Next(0, two.Length)];  // Из массива one выбираем случайный элемент и складываем со случайным элементом из массива two
                Console.WriteLine($"Результат броска: {res}");
                Console.Write("Нажмите Enter, чтобы бросить кубики или введите Exit для выхода: ");
            }
        }
    }
}
