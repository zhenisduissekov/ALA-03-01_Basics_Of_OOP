//-----------------------------------------------------------------------
// <copyright file="Square.cs" company="EPAM">
//     Copyright (c) Sprocket Enterprises. All rights reserved.
// </copyright>
// <author>Zhenis Duissekov</author>
//-----------------------------------------------------------------------

namespace Shapes
{
    using System;

    /// <summary>
    /// Square class which inherits from Rectangle class
    /// simply set both sides equal to each other
    /// </summary>
    public class Square : Rectangle
    {
        /// <summary>
        /// method to set the sides(equal to each other)
        /// </summary>
        public int Set_Side
        {
            set
            {
                DimensionAltered = true;
                Set_Sides = Tuple.Create(value, value);
            }
        }
    }
}