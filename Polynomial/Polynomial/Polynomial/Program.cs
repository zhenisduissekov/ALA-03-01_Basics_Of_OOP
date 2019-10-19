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
            Polynom p1 = new Polynom(7);   
            Console.Write("P1 polynom created with {0} zero elements in it:  ", p1.GetPolynomSize());
            foreach (var element in p1.GetArray)
            {
                Console.Write("{0}  ", element);
            }

            Console.WriteLine();
            Polynom p2 = new Polynom(-1, 0, 2, 3, -4, 5, -6, 12, -13, 1);
            Polynom p3 = new Polynom(-1, 0, 2, 3, -4, 5, -6, 12);
            Console.Write("P2 polynom created with elements :  ", p2.GetPolynomSize());

            foreach (var element in p2.GetArray)
            {
                Console.Write("{0}  ", element);
            }

            Console.WriteLine();
            Polynom resu = new Polynom();
            resu = p3 - p2;

            Console.WriteLine("P1 is: {0}", p1.ToString());
            Console.WriteLine("P2 is: {0}", p2.ToString());
            Console.WriteLine("P3 is: {0}", p3.ToString());
            Console.WriteLine("P3-P2: {0}", resu.ToString());

            Console.WriteLine("P2(0)= {0} ", p2.CalculatePolynom(0));
            Console.WriteLine("P2(1)= {0} ", p2.CalculatePolynom(1));


        }
    }
}
