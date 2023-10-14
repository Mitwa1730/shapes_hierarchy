
/*
 Class: Rectangle.cs
 Author: Mitwa Patel, Student ID: 000905034
 Date: September 13, 2023
 Purpose: This class represents a Rectangle, a two-dimensional shape with a CalculateArea method that calculates 
 the area of rectangle. This class is inherited from a base class (Shape.cs)
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2A

{
    public class Rectangle : Shape

    {
        private double length;
        private double width;

        /// <summary>
        /// Constructor that sets Type to "Rectangle" and initializes a new instance of this class
        /// </summary>
        public Rectangle() : base()
        { base.Type = "Rectangle"; }
      
        /// <summary>
        /// this method calculates the area of rectangle and returns it
        /// </summary>
        /// <returns> area of rectangle in double </returns>
        public override double CalculateArea()
        {
            double rectArea = length * width;
            return rectArea;
        }

        /// <summary>
        /// this method calculates the volume of rectangle. Since Rectangle is a two dimensional shape, it returns 0
        /// </summary>
        /// <returns> returns 0 as rectangle is a two dimensional shape. </returns>
        public override double CalculateVolume()
        { return 0; }

        /// <summary>
        /// This method allows an user to enter the length and width of rectangle while storing the value
        /// </summary>
        public override void SetData()
        {
            Console.Write("\nEnter the length: ");
            length = Double.Parse(Console.ReadLine());
            Console.Write("Enter the width: " );
            width = Double.Parse(Console.ReadLine());
        }

        /// <summary>
        /// This method represents string of a Recatngle 
        /// </summary>
        /// <returns>a string that contains details such as, length, width and area of a rectangle</returns>
        public override string ToString()
        {
            return $"\n{base.Type} - length: {length}, width: {width}, area: {CalculateArea()}";
        }
    }
}
