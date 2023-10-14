
/*
 Class: Triangle.cs
 Author: Mitwa Patel, Student ID: 000905034
 Date: September 13, 2023
 Purpose: This class represents a Triangle, a two-dimensional shape with a CalculateArea method that calculates 
 the area of Triangle. This class is inherited from a base class (Shape.cs)
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2A
{
    public class Triangle : Shape
    {
        private double triangleBase;
        private double height;

        /// <summary>
        /// Constructor that sets Type to "Triangle" and initializes a new instance of this class
        /// </summary>
        public Triangle() : base()
        { base.Type = "Triangle"; }

        /// <summary>
        /// this method calculates the area of triangle and returns it
        /// </summary>
        /// <returns> area of triangle in double </returns>
        public override double CalculateArea()
        {
            double triangleArea = 0.5 * triangleBase * height;
            return triangleArea;
        }

        /// <summary>
        /// this method calculates the volume of a triangle. Since triangle is a two dimensional shape, it returns 0
        /// </summary>
        /// <returns> returns 0 as triangle is a two dimensional shape. </returns>
        public override double CalculateVolume()
        { return 0; }

        /// <summary>
        /// This method allows an user to enter the base and height of triangle while storing the value
        /// </summary>
        public override void SetData()
        {
            Console.Write("\nEnter the base: ");
            triangleBase = Double.Parse(Console.ReadLine());
            Console.Write("Enter the height: ");
            height = Double.Parse(Console.ReadLine());
        }

        /// <summary>
        /// This method represents string of a Triangle 
        /// </summary>
        /// <returns>a string that contains details such as, height, base, and area of a triangle</returns>
        public override string ToString()
        {
            return $"\n{base.Type} - height: {height}, triangleBase: {triangleBase}, area: {CalculateArea()}";
        }
    }
}
