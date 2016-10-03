using System;
/// <summary>
/// Заполнение двумерного массива относительно диагоналей и змейкой.
/// </summary>
namespace DiagonallAndSnakeArray
{
    class Program
    {
        private static int i,j;

        private static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[][] twoArray = new int[n][];
            for (int i = 0; i < twoArray.Length; i++)
            {
                twoArray[i] = new int[n];
            }
            
            SetArray(twoArray);
            Print(twoArray);
            //DiagonalSetArray(twoArray);
            Print(twoArray);

            Console.ReadKey();
        }

        //смена элементов относительно побочной диагонали
        //private static void DiagonalSetArray(int[][] a)
        //{
        //    for (i = 0; i < a.Length; i++)
        //    {
        //        for (j = 0; j < a[i].Length; j++)
        //        {
        //            if (i + j < a.Length - 1) //для элементов над побочной диагональю должно выполняться условие (i + j < n-1)
        //            {
        //                int b = a[i][j];
        //                int k = a.Length - (j + 1);
        //                int l = a.Length - (i + 1);
        //                int c = a[k][l];
        //                a[i][j] = c;
        //                a[k][l] = b;
        //            }
        //        }
        //    }
        //}

        // смена элементов относительно главной диагонали
        //private static void DiagonalSetArray(int[][] a)
        //{
        //    for (i = 0; i < a.Length; i++)
        //    {
        //        for (j = i + 1; j < a[i].Length; j++)
        //        {
        //            int k = i;
        //            int l = j;
        //            int b = a[l][k];
        //            a[l][k] = a[k][l];
        //            a[k][l] = b;
        //        }
        //    }
        //}

        //горизонтальная змейка
        //private static void SetArray(int[][] a)
        //{
        //    for (i = 0; i < a.Length; i++)
        //    {
        //        for (j = 0; j < a[i].Length; j++)
        //            if (i % 2 == 0) {a[i][j] = (i * a.Length) + j + 1;}
        //            else {a[i][j] = (i * a.Length) - j + a.Length;}
        //    }
        //}

        //вертикальная змейка
        //private static void SetArray(int[][] a)
        //{
        //    for (i = 0; i < a.Length; i++)
        //    {
        //        for (j = 0; j < a[i].Length; j++)
        //            if (j % 2 == 0) { a[i][j] = (j * a.Length) + i + 1; }
        //            else { a[i][j] = (j * a.Length) - i + a.Length; }
        //    }
        //}

        private static void SetArray(int[][] a)
        {
            var r = new Random();
            for (int i = 0; i < a.Length; i++)
                for (int j = 0; j < a[i].Length; j++)
                    a[i][j] = r.Next(10);
        }

        private static void Print(int[][] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < a[i].Length; j++)

                    Console.Write(a[i][j] + " ");
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
