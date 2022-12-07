using System;
using System.ComponentModel.DataAnnotations;

class hw5
{
    static void Main()
    {
        Console.WriteLine("введите номер задания (7,8,9)");
        int numb = Convert.ToInt32(Console.ReadLine());
        if (numb == 7)
        {
            #region Level2task7
            int m = 6;
            int n = 6;
            int[,] a3 = new int[m, n];
            Console.WriteLine("введите массив");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    string s = Console.ReadLine();
                    bool boo = int.TryParse(s, out int xx);
                    if (boo == true)
                    {
                        a3[i, j] = xx;
                    }
                    else
                    {

                        Console.WriteLine("введите заново");
                        break;
                    }
                }
            }
            for (int i1 = 0; i1 < m; i1++)
            {
                for (int j1 = 0; j1 < n; j1++)
                {
                    Console.Write(a3[i1, j1]);
                    Console.Write(' ');
                }
                Console.WriteLine();

            }
            int max = -100000;
            int imax = 0;
            for (int i2 = 0; i2 < m; i2++)
            {
                   if (max < a3[i2, i2])
                        {
                            max = a3[i2, i2];
                            imax = i2;
                        }
 
            }

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if ((i < j) && (i < imax))
                        a3[i, j] = 0;

                }
            }



            for (int i1 = 0; i1 < m; i1++)
            {
                for (int j1 = 0; j1 < n; j1++)
                {
                    Console.Write(a3[i1, j1]);
                    Console.Write(' ');
                }
                Console.WriteLine();

            }

            #endregion

        }
        else if (numb == 8)
        {
            #region Level2task8
            int m = 6;
            int n = 6;
            int[,] a3 = new int[m, n];
            Console.WriteLine("введите массив");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    string s = Console.ReadLine();
                    bool boo = int.TryParse(s, out int xx);
                    if (boo == true)
                    {
                        a3[i, j] = xx;
                    }
                    else
                    {

                        Console.WriteLine("введите заново");
                        break;
                    }
                }
            }
            int[] ma = new int[m];
            for (int i = 0; i < m; i++)
            {
                int jmax = 0;
                int max = -100000;
                for (int j = 0; j < n; j++)
                {
                    if (a3[i, j] > max)
                    {
                        max = a3[i, j];
                        jmax = j;
                    }
                }
                ma[i] = jmax;
            }

            int o = 0;
            while (o <= (m - 2))
            {
                int t = a3[o, ma[o]];
                a3[o, ma[o]] = a3[o + 1, ma[o + 1]];
                a3[o + 1, ma[o + 1]] = t;
                o += 2;
            }
            for (int i1 = 0; i1 < m; i1++)
            {
                for (int j1 = 0; j1 < n; j1++)
                {
                    Console.Write(a3[i1, j1]);
                    Console.Write(' ');
                }
                Console.WriteLine();

            }
            #endregion
        }
        else if (numb == 9)
        {
            #region Leel2Task9
            int m = 6;
            int n = 7;
            int[,] a3 = new int[m, n];
            Console.WriteLine("введите массив");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    string s = Console.ReadLine();
                    bool boo = int.TryParse(s, out int xx);
                    if (boo == true)
                    {
                        a3[i, j] = xx;
                    }
                    else
                    {

                        Console.WriteLine("введите заново");
                        break;
                    }
                }
            }
            for (int i1 = 0; i1 < m; i1++)
            {
                for (int j1 = 0; j1 < n; j1++)
                {
                    Console.Write(a3[i1, j1]);
                    Console.Write(' ');
                }
                Console.WriteLine();

            }

            for (int i = 0; i < m; i++)
            {
                int x = 0;
                int y = n - 1;
                while (y - x >= 1)
                {
                    int t = a3[i, x];
                    a3[i, x] = a3[i, y];
                    a3[i, y] = t;
                    y--;
                    x++;
                }
            }
            for (int i1 = 0; i1 < m; i1++)
            {
                for (int j1 = 0; j1 < n; j1++)
                {
                    Console.Write(a3[i1, j1]);
                    Console.Write(' ');
                }
                Console.WriteLine();

            }
            #endregion

        }
        else Console.WriteLine("выберите из списка");
    }
}