//-----------------------------------------------------------------------
// <copyright file="Program.cs" company="EPAM">
//     Copyright (c) Sprocket Enterprises. All rights reserved.
// </copyright>
// <author>Zhenis Duissekov</author>
//-----------------------------------------------------------------------

namespace Shapes
{
    using System;

    public class Program
    {
        // <summary>
        // This is my Main. Here one by one, I create objects circle, triangle,
        // rectangle and square. I set their dimensions and check their perimeter
        // and area. Also I have created a an exception error when dimension is changed,
        // but area and perimeter are not recalculated
        // </summary
        private static void Main()
        {
            Circle circle_1 = new Circle();
            circle_1.Set_Radius = 3;
            circle_1.Set_Area_Perimeter();
            Console.WriteLine("Circle radius is = {0}", circle_1.Get_Radius);
            Console.WriteLine("Circle area is = {0}", circle_1.GetArea);
            Console.WriteLine("Circle perimeter is = {0}", circle_1.GetPerimeter);

            Triangle triangle_1 = new Triangle();
            triangle_1.Set_Sides = Tuple.Create(10, 20, 20);
            Console.WriteLine("Triangle sides are: {0}", triangle_1.Get_Sides);
            triangle_1.Set_Area_Perimeter();
            Console.WriteLine("Triangle area is = {0}", triangle_1.GetArea);
            Console.WriteLine("Triangle perimeter is = {0}", triangle_1.GetPerimeter);

            Rectangle rectangle_1 = new Rectangle();
            rectangle_1.Set_Sides = Tuple.Create(110, 231);
            Console.WriteLine("Rectangle sides are: {0}", rectangle_1.Get_Sides);
            rectangle_1.Set_Area_Perimeter();
            Console.WriteLine("Rectangle area is = {0}", rectangle_1.GetArea);
            Console.WriteLine("Rectangle perimeter is = {0}", rectangle_1.GetPerimeter);

            Square square_1 = new Square();
            square_1.Set_Side = 100;
            Console.WriteLine("Square sides are: {0}", square_1.Get_Sides);
            square_1.Set_Area_Perimeter();
            Console.WriteLine("Square area is = {0}", square_1.GetArea);
            Console.WriteLine("Square perimeter is = {0}", square_1.GetPerimeter);

            // For testing the ShapeException
            square_1.Set_Side = 120;
            Console.WriteLine("Square area is = {0}", square_1.GetArea);
        }
    }
}
