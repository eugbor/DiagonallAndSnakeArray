using System;

namespace DiagonallAndSnakeArray
{
    class Program
    {
        private static void Main(string[] args)
        {
            int[,] twoArray = new int[3, 3];
            SetArray(twoArray);
            Print(twoArray);
            //DiagonalSetArray(twoArray);
            Print(twoArray);

            Console.ReadKey();
        }

        //смена элементов относительно побочной диагонали
        //private static void DiagonalSetArray(int[,] a)
        //{
        //    for (int i = 0; i < 3 - 1; i++)
        //    {
        //        for (int j = 0; j < 3 - i; j++)
        //        {
        //            int b = a[i, j];
        //            a[i, j] = a[3 - (j + 1), 3 - (i + 1)];
        //            a[3 - (j + 1), 3 - (i + 1)] = b;
        //        }
        //    }
        //}

        //смена элементов относительно главной диагонали (вариант 1)
        //private static void DiagonalSetArray(int[,] a)
        //{
        //    for (int i = 0; i < 3; i++)
        //    {
        //        for (int j = 0; j < 3; j++)
        //            a[i, j] = (j * 3) + i + 1;

        //    }
        //}

        // смена элементов относительно главной диагонали (вариант 2)
        //private static void DiagonalSetArray(int[,] a)
        //{
        //    for (int i = 0; i < 3; i++)
        //    {
        //        for (int j = i + 1; j < 3; j++)
        //        {
        //                int b = a[j, i];
        //                a[j, i] = a[i, j];
        //                a[i, j] = b;
        //        }
        //    }
        //}

        private static void SetArray(int[,] a)
        {

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                    a[i, j] = (i * 3) + j + 1;

            }
        }

        //горизонтальная змейка
        //private static void SetArray(int[,] a)
        //{
        //    for (int i = 0; i < 3; i++)
        //    {
        //        for (int j = 0; j < 3; j++)
        //            if (i % 2 == 0) { a[i, j] = (i * 3) + j + 1; }
        //            else { a[i, j] = (i * 3) - j + 3; }
        //    }
        //}

        //вертикальная змейка
        //private static void SetArray(int[,] a)
        //{
        //    for (int i = 0; i < 3; i++)
        //    {
        //        for (int j = 0; j < 3; j++)
        //            if (j % 2 == 0) { a[i, j] = (j * 3) + i + 1; }
        //            else { a[i, j] = (j * 3) - i + 3; }
        //    }
        //}

        private static void Print(int[,] a)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)

                    Console.Write(a[i, j] + " ");
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
