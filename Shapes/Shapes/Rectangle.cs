//-----------------------------------------------------------------------
// <copyright file="Rectangle.cs" company="EPAM">
//     Copyright (c) Sprocket Enterprises. All rights reserved.
// </copyright>
// <author>Zhenis Duissekov</author>
//-----------------------------------------------------------------------

namespace Shapes
{
    using System;

    /// <summary>
    /// class Rectangle that inherits from Shape class
    /// </summary>
    public class Rectangle : Shape
    {
        private int a;
        private int b;

        /// <summary>
        /// method to set sides
        /// </summary>
        public Tuple<int, int> Set_Sides
        {
            set
            {
                DimensionAltered = true;
                a = value.Item1;
                b = value.Item2;
            }
        }

        /// <summary>
        /// method to get sides
        /// </summary>
        public Tuple<int, int> Get_Sides
        {
            get
            {
                return Tuple.Create(a, b);
            }
        }

        /// <summary>
        /// method to calculate area and perimeter
        /// </summary>
        public void Set_Area_Perimeter()
        {
            SetArea = a * b;
            SetPerimeter = 2 * (a + b);
        }
    }
}
