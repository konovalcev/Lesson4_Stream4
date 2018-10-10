using System;

// Решить задачу о нахождении длины максимальной последовательности с помощью матрицы.

// Александр Коновальцев

namespace Lesson4_Stream4
{
    static class MainClass
    {
        public static void Main(string[] args)
        {
            var a = new char[] { 'a', 'b', 'd', 'f', 'x', 'y', 'm', 'n', 'z' };
            var b = new char[] {'b', 'x', 'a', 'y', 'c', 'n', 'z' };
            Console.WriteLine(LcsLength(a, b));
        }

        private static int LcsLength(char[] a, char[] b)

        {
            int[] x = new int[a.Length];
            int[] y = new int[b.Length];
            for (int i = a.Length-2; i >= 0; i--)
                {
                for (int j = b.Length-2; j >= 0; j--)
                {

                    if (a[i] == '\0' || b[j] == '\0')
                    {
                        x[j] = 0;
                    }                        

                    if (a[i + 1] == b[j + 1])
                    {
                        x[j] = 1 + y[j + 1];
                    }

                    else 
                    {
                        x[j] = y[j] > x[j + 1] ? y[j] : x[j + 1];
                    }

                }

                    y = x;
                }

            return x[0] + 1;
        }
    }
}