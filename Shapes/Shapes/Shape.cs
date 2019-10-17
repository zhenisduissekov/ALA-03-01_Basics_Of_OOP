//-----------------------------------------------------------------------
// <copyright file="Shape.cs" company="EPAM">
//     Copyright (c) Sprocket Enterprises. All rights reserved.
// </copyright>
// <author>Zhenis Duissekov</author>
//-----------------------------------------------------------------------

namespace Shapes
{
    using System;

    /// <summary>
    /// Shape class which inherits from ShapeException
    /// </summary>
    public class Shape : ShapeException
    {
        private int area;
        private int perimeter;
        private bool dimension_altered;

        /// <summary>
        /// method to ouput perimeter if dimensions were not altered
        /// otherwise output ShapeException
        /// </summary>
        public int GetPerimeter
        {
            get
            {
                if (dimension_altered == false)
                {
                    return perimeter;
                }

                throw new ShapeException();
            }
        }

        /// <summary>
        /// method to calculate and set perimeter
        /// </summary>
        public int SetPerimeter
        {
            set
            {
                perimeter = value;
                dimension_altered = false;
            }
        }

        /// <summary>
        /// method to output area
        /// if dimensions were changed then get exception
        /// </summary>
        public int GetArea
        {
            get
            {
                if (dimension_altered == false)
                {
                    return area;
                }

                throw new ShapeException();
            }
        }

        /// <summary>
        /// method to calculate and set area
        /// </summary>
        public int SetArea
        {
            set
            {
                area = value;
                dimension_altered = false;
            }
        }

        /// <summary>
        /// method to set flag that dimensions were changed
        /// </summary>
        public bool DimensionAltered
        {
            set { dimension_altered = value; }
        }
    }
}
