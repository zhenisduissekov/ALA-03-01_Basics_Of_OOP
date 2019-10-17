//-----------------------------------------------------------------------
// <copyright file="Triangle.cs" company="EPAM">
//     Copyright (c) Sprocket Enterprises. All rights reserved.
// </copyright>
// <author>Zhenis Duissekov</author>
//-----------------------------------------------------------------------

namespace Shapes
{
    using System;

    /// <summary>
    /// Triangle class which inherits from Shape class
    /// </summary>
    public class Triangle : Shape
    {
        private int a;
        private int b;
        private int c;

        /// <summary>
        /// method to set triangle dimensions
        /// </summary>
        public Tuple<int, int, int> Set_Sides
        {
            set
            {
                DimensionAltered = true;
                a = value.Item1;
                b = value.Item2;
                c = value.Item3;
            }
        }

        /// <summary>
        /// Method to ouput triangle dimensions
        /// </summary>
        public Tuple<int, int, int> Get_Sides
        {
            get
            {
                return Tuple.Create(a, b, c);
            }
        }

        /// <summary>
        /// method to calculate and set area and perimeter at once
        /// </summary>
        public void Set_Area_Perimeter()
        {
            int p = (a + b + c) / 2;
            SetArea = (int)Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            SetPerimeter = a + b + c;
        }
    }
}
