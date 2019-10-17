//-----------------------------------------------------------------------
// <copyright file="Circle.cs" company="EPAM">
//     Copyright (c) Sprocket Enterprises. All rights reserved.
// </copyright>
// <author>Zhenis Duissekov</author>
//-----------------------------------------------------------------------

namespace Shapes
{
    using System;

    /// <summary>
    /// circle class that inherits from shape
    /// </summary>
    public class Circle : Shape
    {
        private int radius;

        /// <summary>
        /// method to get radius
        /// </summary>
        public int Get_Radius => radius;

        /// <summary>
        /// method to set radius
        /// </summary>
        public int Set_Radius
        {
            set
            {
                radius = value;
                DimensionAltered = true;
            }
        }

        /// <summary>
        /// method to set area and perimeter
        /// </summary>
        public void Set_Area_Perimeter()
        {
            SetArea = (int)Math.PI * (int)Math.Pow(radius, 2);
            SetPerimeter = 2 * (int)Math.PI * radius;
        }
    }
}
