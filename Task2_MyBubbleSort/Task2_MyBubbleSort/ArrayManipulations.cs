// Copyright (c) EPAM
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.

namespace MyBubbleSort
{
    using System;

    /// <summary>
    /// class with methods to find max, min and sums in Array
    /// </summary>
    public class ArrayManipulations : ArraySort
    {
        public int[] FindMaxmInArray(int[][] a)
        {
            int[] result = new int[a.Length];
            int max_v;
            for (int j = 0; j < a.Length; j++)
            {
                max_v = a[j][0];
                for (int i = 1; i < a[j].Length; i++)
                {
                    if (a[j][i] > max_v)
                    {
                        max_v = a[j][i];
                    }
                }

                result[j] = max_v;
            }

            return result;
        }

        public int[] FindMinInArray(int[][] a)
        {
            int[] result = new int[a.Length];
            int min_v;
            for (int j = 0; j < a.Length; j++)
            {
                min_v = a[j][0];
                for (int i = 1; i < a[j].Length; i++)
                {
                    if (a[j][i] < min_v)
                    {
                        min_v = a[j][i];
                    }
                }

                result[j] = min_v;
            }

            return result;
        }

        /// <summary>
        /// Our method that sums elements in array and ouputs an array of sums
        /// </summary>
        public int[] SumArray(int[][] a)
        {
            int[] result = new int[a.Length];
            int sum;
            for (int j = 0; j < a.Length; j++)
            {
                sum = a[j][0];
                for (int i = 1; i < a[j].Length; i++)
                {
                    sum += a[j][i];
                }

                result[j] = sum;
            }

            return result;
        }
    }
}
