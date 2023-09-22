namespace find2maxValues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ЗАДАЧА: Вывод двух максимальных значений из 10 вводимых

            int x = 0;
            int maxValue1 = 0;
            int maxValue2 = 0;

            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Введите число: ");
                x = Convert.ToInt32(Console.ReadLine());

                if (x > maxValue1)
                {
                    maxValue1 = x;
                }

                Console.WriteLine("Введите число: ");
                x = Convert.ToInt32(Console.ReadLine());

                if (x > maxValue2)
                {
                    maxValue2 = x;
                }
            }

            Console.WriteLine("\n" + "Максимальные числа из 10 введеных это - " + maxValue1 + " и " + maxValue2);
        }
    }
}