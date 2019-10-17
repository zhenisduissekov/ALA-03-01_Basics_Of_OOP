//-----------------------------------------------------------------------
// <copyright file="ShapeException.cs" company="EPAM">
//     Copyright (c) Sprocket Enterprises. All rights reserved.
// </copyright>
// <author>Zhenis Duissekov</author>
//-----------------------------------------------------------------------

namespace Shapes
{
    using System;

    /// <summary>
    /// an exception to indicate that dimensions were changed but
    /// area and perimeter were not recalculated and reset
    /// </summary>
    public class ShapeException : Exception
    {
        public ShapeException()
            : base(string.Format("Invalid Area or Perimeter. Needs to be recalculated. Use set_Area_Perimeter() method"))
        {
        }
    }
}
