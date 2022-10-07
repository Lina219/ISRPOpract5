using System;

namespace pract5
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            Console.WriteLine("Введите размер массивов:");
            try
            {
                number = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                if(number < 1 || number > 10)
                {
                    Console.WriteLine("Необходимо ввести целое число от 1 до 10");
                }
                else
                {
                    Method(number);
                }
            }
            catch
            {
                Console.WriteLine("Необходимо ввести целое число от 1 до 10");
                Console.ReadKey();
            }
            Console.ReadKey();
        }

        public static void Method(int number)
        {
            if (number < 1 || number > 10)
            {
                Console.WriteLine("Необходимо ввести целое число от 1 до 10");
            }
            else
            {
                string str = "абвгдеёжзиклмнопрстуфхцчшщъыьэюяАБВГДЕЁЖЗИКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
                Random rnd = new Random();
                string[,] matr1 = new string[number, number];
                string[,] matr2 = new string[number, number];

                int counter1 = 0;
                string answer1 = "Строки в 1 массиве, заполненные только строчными буквами:";
                Console.WriteLine("1 массив:");
                for (int i = 0; i < number; i++)
                {
                    for (int j = 0; j < number; j++)
                    {
                        int x = rnd.Next(65); 
                        if (x < 32)
                        {
                            counter1++;
                        }
                        matr1[i, j] = Convert.ToString(str[x]);
                        Console.Write(matr1[i, j] + " ");
                    }
                    if (counter1 == number)
                    {
                        answer1 += i+1 + ",";
                    }
                    Console.WriteLine();
                    counter1 = 0;
                }
                Console.WriteLine();

                int counter2 = 0;
                string answer2 = "Строки во 2 массиве, заполненные только строчными буквами:";
                Console.WriteLine("2 массив:");
                for (int i = 0; i < number; i++)
                {
                    for (int j = 0; j < number; j++)
                    {
                        int x = rnd.Next(65);
                        if (x < 32)
                        {
                            counter2++;
                        }
                        matr2[i, j] = Convert.ToString(str[x]);
                        Console.Write(matr2[i, j] + " ");
                    }
                    if (counter2 == number)
                    {
                        answer2 += i+1 + ",";
                    }
                    Console.WriteLine();
                    counter2 = 0;
                }
                Console.WriteLine();
                Console.WriteLine(answer1);
                Console.WriteLine(answer2);
            }
        }
    }
}
