//-----------------------------------------------------------------------
// <copyright file="Program.cs" company="EPAM">
//     Copyright (c) Sprocket Enterprises. All rights reserved.
// </copyright>
// <author>Zhenis Duissekov</author>
//-----------------------------------------------------------------------

namespace Polynom
{
    using System;

    public class Program
    {
        /// <summary>
        /// My Main
        /// </summary>
        public static void Main()
        {
            Console.WriteLine("Hello World!");

            Polynom p1 = new Polynom(7);
            Console.WriteLine("Hello World!");
            Console.WriteLine(p1.GetPolynomSize());
            foreach (var element in p1.GetArray)
            {
                Console.Write("{0}  ", element);
            }

            Console.WriteLine();
            Polynom p2 = new Polynom(1, 0, 2, 3, -4, 5, -6, 12, -13, 1);
            Console.WriteLine(p2.GetPolynomSize());

            foreach (var element in p2.GetArray)
            {
                Console.Write("{0}  ", element);
            }

            Console.WriteLine();
            Console.WriteLine(p1.Equals(p2));

            Console.Write("My polynomial is: {0}", p2.OutputPolynom());

        }
    }
}
