// Copyright (c) EPAM
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.

namespace MyBubbleSort
{
    using System;

    /// <summary>
    /// Our working class
    /// </summary>
    public class Program : ArrayManipulations
    {
        /// <summary>
        /// Method to output to screen
        /// </summary>
        public static void OutputToScreen(string str, int[] array)
        {
            Console.Write(str);
            foreach (var element in array)
            {
                Console.Write(" {0}", element);
            }

            Console.WriteLine();
        }

        /// <summary>
        /// Method to output to screen array[][]
        /// </summary>
        public static void OutputToScreen(string str, int[][] array)
        {
            Console.WriteLine(str);
            for (int j = 0; j < array.Length; j++)
            {
                Console.Write("\tRow {0} \t", j);
                foreach (var element in array[j])
                {
                    Console.Write(" {0}", element);
                }

                Console.WriteLine();
            }

            Console.WriteLine();
        }

        /// <summary>
        /// Our Main where we give some values and call Bubble_Sort method
        /// </summary>
        private static void Main(string[] args)
        {
            int[][] jagged_arr = new int[4][];
            jagged_arr[0] = new int[] { 1, 2, 3, 5 };
            jagged_arr[1] = new int[] { 0 };
            jagged_arr[2] = new int[] { 101, -1, 0, 53, 3, -23, 111, 5934, 33 };
            jagged_arr[3] = new int[] { -1 };

            OutputToScreen("Output original array", jagged_arr);
            ArrayManipulations d = new ArrayManipulations();
            OutputToScreen("Output maximums sorted, ascending: ", d.BubbleSort(true, d.FindMaxmInArray(jagged_arr)));
            OutputToScreen("Output maximums sorted, descending: ", d.BubbleSort(false, d.FindMaxmInArray(jagged_arr)));
            OutputToScreen("Output maximums sorted, descending: ", d.BubbleSort(true, d.FindMinInArray(jagged_arr)));
            OutputToScreen("Output minimums sorted, ascending: ", d.BubbleSort(false, d.FindMinInArray(jagged_arr)));
            OutputToScreen("Output sums sorted, ascending: ", d.BubbleSort(true, d.SumArray(jagged_arr)));
            OutputToScreen("Output sums sorted, descending: ", d.BubbleSort(false, d.SumArray(jagged_arr)));
        }
    }
}
