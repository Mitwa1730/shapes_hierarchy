
/*
 Class: Box.cs
 Author: Mitwa Patel, Student ID: 000905034
 Date: September 13, 2023
 Purpose: This class represents a Box, a three-dimensional shape with a CalculateArea method that calculates 
 the area of Box and CalculateVolume method that calculates the volume of Box.
 This class is inherited from a base class (Shape.cs)
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2A
{
    public class Box : Shape
    {
        private double length;
        private double width;
        private double height;

        /// <summary>
        /// Constructor that sets Type to "Box" and initializes a new instance of this class
        /// </summary>
        public Box() : base()
        { base.Type = "Box"; }

        /// <summary>
        /// this method calculates the area of box and returns it
        /// </summary>
        /// <returns> area of box in double </returns>
        public override double CalculateArea()
        {
            double boxArea = 2*length*width + 2*length*height + 2*height*width;
            return boxArea;
        }

        /// <summary>
        /// this method calculates the volume of Box and returns it
        /// </summary>
        /// <returns>returns volume of Box in double</returns>
        public override double CalculateVolume()
        {
            double boxVolume = length*width*height;
            return boxVolume;
        }

        /// <summary>
        /// This method allows an user to enter the length, width, and height of box while storing the value
        /// </summary>
        public override void SetData()
        {
            Console.Write("\nEnter the length: ");
            length = Double.Parse(Console.ReadLine());
            Console.Write("Enter the width: ");
            width = Double.Parse(Console.ReadLine());
            Console.Write("Enter the height: ");
            height = Double.Parse(Console.ReadLine());
        }

        /// <summary>
        /// This method represents string of a Box 
        /// </summary>
        /// <returns>a string that contains details such as, length, width, height, area, and volume of a box</returns>
        public override string ToString()
        {
            return $"\n{base.Type} - length: {length}, width: {width}, height: {height}, area: {CalculateArea()}, volume: {CalculateVolume()}";
        }
    }
}
