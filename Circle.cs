
/*
 Class: Circle.cs
 Author: Mitwa Patel, Student ID: 000905034
 Date: September 13, 2023
 Purpose: This class represents a Circle, a two-dimensional shape with a CalculateArea method that calculates 
 the area of Circle.
 This class is inherited from a base class (Shape.cs)
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2A
{
    public class Circle : Shape
    {
        private double radius;

        /// <summary>
        /// Constructor that sets Type to "Circle" and initializes a new instance of this class
        /// </summary>
        public Circle() : base()
        { base.Type = "Circle"; }

        /// <summary>
        /// this method calculates the area of Circle and returns it
        /// </summary>
        /// <returns> area of circle in double </returns>
        public override double CalculateArea()
        {
            double circleArea = PI*Math.Pow(radius, 2);
            return circleArea;
        }

        /// <summary>
        /// this method calculates the volume of a Circle. Since circle is a two dimensional shape, it returns 0
        /// </summary>
        /// <returns> returns 0 as circle is a two dimensional shape. </returns>
        public override double CalculateVolume()
        { return 0;}

        /// <summary>
        /// This method allows an user to enter the radius of circle while storing the value
        /// </summary>
        public override void SetData()
        {
            Console.Write("\nEnter the radius: ");
            radius = Double.Parse(Console.ReadLine());  
        }

        /// <summary>
        /// This method represents string of a circle 
        /// </summary>
        /// <returns>a string that contains details such as, radius and area of a circle</returns>
        public override string ToString()
        {
            return $"\n{base.Type} - radius: {radius}, area: {CalculateArea()}";
        }
    }
}
