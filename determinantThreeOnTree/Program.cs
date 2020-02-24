using System;
using System.Collections;

namespace determinantThreeOnTree
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            double[,] matrix = new double[3, 3];

            for (int i = 0; i < 3; i++)
            {
                try
                {
                    Console.Write($"1строка-{i + 1}столбец: ");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write($"A(1,{i + 1}): ");
                    Console.ResetColor();
                    matrix[0, i] = Convert.ToDouble(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Описание ошибки: {ex.Message} \nПоэтому будет присвоено значение: \"0\"");
                    Console.ResetColor();
                    matrix[0, i] = 0;
                }

            }


            for (int i = 0; i < 3; i++)
            {
                try
                {
                    Console.Write($"2строка-{i + 1}столбец: ");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write($"A(2,{i + 1}): ");
                    Console.ResetColor();
                    matrix[1, i] = Convert.ToDouble(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Описание ошибки: {ex.Message} \nПоэтому будет присвоено значение: \"0\"");
                    Console.ResetColor();
                    matrix[1, i] = 0;

                }
            }



            for (int i = 0; i < 3; i++)
            {
                try
                {
                    Console.Write($"1строка-{i + 1}столбец: ");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write($"A(3,{i + 1}): ");
                    Console.ResetColor();
                    matrix[2, i] = Convert.ToDouble(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Описание ошибки: {ex.Message} \nПоэтому будет присвоено значение: \"0\"");
                    Console.ResetColor();
                    matrix[2, i] = 0;
                }
            }


            Console.WriteLine();
            arrayOutput(matrix);
            arrayСalculation(matrix);
            Console.ReadKey();

            static void arrayOutput(double[,] mass) //Вывод итоговой матрицы на экран
            {
                double rows = mass.GetUpperBound(0) + 1;
                double columns = mass.Length / rows;
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        Console.Write($"{mass[i, j]} \t");
                    }
                    Console.WriteLine();
                }
            }

            static void arrayСalculation(double[,] mass) //Подсчет детерминанта матрицы
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nСейчас вычислим детерминант матрицы 3х3: \n");
                Console.ResetColor();
                double NumPlus = (mass[0, 0] * mass[1, 1] * mass[2, 2]) + (mass[0, 1] * mass[1, 2] * mass[2, 0]) + (mass[1, 0] * mass[2, 1] * mass[0, 2]);
                double NumMinus = (mass[0, 2] * mass[1, 1] * mass[2, 0]) - (mass[1, 0] * mass[0, 1] * mass[2, 2]) - (mass[2, 1] * mass[1, 2] * mass[0, 0]);
                double detMatrix = NumPlus - NumMinus;
                Console.Write($"Det.A = a(1,1)*а(2,2)*а(3,3) + а(1,2)*а(2,3)*а(3,1) + а(3,2)*а(2,1)*а(1,3) - а(1,3)*а(2,2)*а(3,1) - а(2,3)*а(3,2)*а(1,1) - а(2,1)*а(1,2)*а(3,3) = {detMatrix}\n\n");
            }
        }
    }
}