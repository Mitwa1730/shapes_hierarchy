
/*
 Class: Square.cs
 Author: Mitwa Patel, Student ID: 000905034
 Date: September 13, 2023
 Purpose: This class represents a Square, a two-dimensional shape with a CalculateArea method that calculates 
 the area of Square. This class is inherited from a base class (Shape.cs)
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2A
{
    public class Square : Shape
    {
        private double length;

        /// <summary>
        /// Constructor that sets Type to "Square" and initializes a new instance of this class
        /// </summary>
        public Square()
        { base.Type = "Sqaure"; }

        /// <summary>
        /// this method calculates the area of square and returns it
        /// </summary>
        /// <returns> area of square in double </returns>
        public override double CalculateArea()
        {
            double areaSquare = length * length;
            return areaSquare;
        }

        /// <summary>
        /// this method calculates the volume of a Sqaure. Since Square is a two dimensional shape, it returns 0
        /// </summary>
        /// <returns> returns 0 as square is a two dimensional shape. </returns>
        public override double CalculateVolume()
        { return 0; }

        /// <summary>
        /// This method allows an user to enter the length and width of square while storing the value
        /// </summary>
        public override void SetData()
        {
            Console.Write("\nEnter the length: ");
            length = Double.Parse(Console.ReadLine());
        }

        /// <summary>
        /// This method represents string of a Square 
        /// </summary>
        /// <returns>a string that contains details such as, length and area of a square</returns>
        public override string ToString()
        {
            return $"\n{base.Type} - length: {length}, area: {CalculateArea()}";
        }
    }
}
