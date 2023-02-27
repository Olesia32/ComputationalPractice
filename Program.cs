using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            // Завдання 1. Переведення десяткового числа у двійкове
            Console.WriteLine("Введіть натуральне число: ");
            int n = int.Parse(Console.ReadLine());
            var binary = string.Empty;
            int dec = n;
            while(dec > 0)
            {
                binary = (dec % 2) + binary;
                dec /= 2;
            }
            Console.WriteLine("Результат у двійковій системі числення: {0}", binary);
            Console.WriteLine("Перевірка: {0}", Convert.ToString(n, 2));

            // Завдання 2. Арифметичні операції
            Console.WriteLine("Введіть значення x: ");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Введіть значення y: ");
            double y = double.Parse(Console.ReadLine());
            Console.WriteLine("Введіть значення z: ");
            double z = double.Parse(Console.ReadLine());
            double sqrt_of_sum_of_squares = Math.Sqrt(x * x + y * y);
            double factorial = 1;
            for(int i = 2; i <= 3; ++i)
            {
                factorial *= i;
            }
            double cube_divided_into_factorial = Math.Pow(z, 3) / factorial;
            double a = 2.0 * sqrt_of_sum_of_squares - cube_divided_into_factorial;
            double b = 1.0 - sqrt_of_sum_of_squares;
            double c = Math.Sin(cube_divided_into_factorial) + Math.Cos(Math.PI / 4);
            double max = a;
            if (b > a)
            {
                max = b;
            }
            if (c > max)
            {
                max = c;
            }
            Console.WriteLine("Максимальне число з {0:F}, {1:F} та {2:F}: {3:F}", a, b, c, max);


            //Завдання 3. Матриця

            /*int[,] A = { { 1, 6, 2, 1, 1, 0},
            {1, 3, 8, 0, 6, 2},
            {5, 1, 0, 3, 7, 4},
            {2, 3, 8, 1, 0, 4},
            {1, 9, 4, 2, 7, 1}};*/

            int[,] A = new int[5, 6];
            Console.WriteLine("\nВведіть значення елементів матриці A (5x6): ");
            for (int row = 0; row < 5; ++row)
            {
                for (int col = 0; col < 6; ++col)
                {
                    A[row, col] = int.Parse(Console.ReadLine());
                }
            }
            int[] vector_b = new int[5];
            //Пошук максимальних елементів
            for (int row = 0; row < 5; ++row)
            {
                int max_in_row = 0;
                for (int col = 0; col < 6; ++col)
                {
                    if (A[row, col] > max_in_row)
                    {
                        max_in_row = A[row, col];
                    }
                }
                vector_b[row] = max_in_row;
            }
            //Виведення матриці на консоль
            Console.WriteLine("\nМатриця A: ");
            for (int row = 0; row < 5; ++row)
            {
                for (int col = 0; col < 6; ++col)
                {
                    Console.Write("{0} ", A[row, col]);
                }
                Console.Write("\n");
            }
            //Виведення вектора на консоль
            Console.WriteLine("\nВектор b: ");
            foreach (int i in vector_b)
            {
                Console.Write("{0} ", i);
            }
            int min_index = 0;
            //Пошук номера мінімального елемента
            for (int i = 1; i < 5; ++i)
            {
                if (vector_b[i] < vector_b[min_index])
                {
                    min_index = i;
                }
            }
            Console.WriteLine("\nНомер мінімального елемента вектора b: {0}", min_index + 1);
            Console.ReadLine();
        }
    }
}
