﻿using System;

namespace MagicNumbers
{
    class MagicNumbers
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i <= 9; i++)
            {
                for (int j = 0; j <= 9; j++)
                {
                    for (int k = 0; k <= 9; k++)
                    {
                        for (int l = 0; l <= 9; l++)
                        {
                            for (int m = 0; m <= 9; m++)
                            {
                                for (int o = 0; o <= 9; o++)
                                {
                                    if (i * j * k * l * m *o == n)
                                    {
                                        string magicNumber = string.Format("{0}{1}{2}{3}{4}{5}", i, j, k, l, m, o);
                                        Console.Write(magicNumber + " ");
                                    }
                                }
                            }
                        }
                    }
                }

            }
        }
    }
}
