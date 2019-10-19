// Copyright (c) EPAM
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.

namespace MyBubbleSort
{
    using System;

    /// <summary>
    /// Class ArraySort
    /// </summary>
    public class ArraySort
    {
        /// <summary>
        /// BubbleSort method including default variable ascending = true
        /// </summary>
        /// <param name="ascending"></param>
        /// <returns>int[]</returns>
        public int[] BubbleSort(bool ascending = true, params int[] array)
        {
            int a_size = array.Length;
            int i = 0;
            int swap = 0;
            int buf;
            if (a_size == 0)
            {
                return array;
            }

            int delta_left;
            int delta_right;
            if (ascending == true)
            {
                delta_left = 0;
                delta_right = 1;
            }
            else
            {
                delta_left = 1;
                delta_right = 0;
            }

            while (i < a_size)
            {
                if (i + 1 != a_size && array[i + delta_left] > array[i + delta_right])
                {
                    swap = 1;
                    buf = array[i];
                    array[i] = array[i + 1];
                    array[i + 1] = buf;
                }

                i++;
                if (i == a_size && swap == 1)
                {
                    swap = 0;
                    i = 0;
                }
            }

            return array;
        }
    }
}
