
/*
 Class: Cylinder.cs
 Author: Mitwa Patel, Student ID: 000905034
 Date: September 13, 2023
 Purpose: This class represents a Cylinder, a three-dimensional shape with a CalculateArea method that calculates 
 the area of Cylinder and CalculateVolume method that calculates the volume of Cylinder.
 This class is inherited from a base class (Shape.cs)
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2A
{
    public class Cylinder : Shape
    {
        private double radius;
        private double height;

        /// <summary>
        /// Constructor that sets Type to "Cylinder" and initializes a new instance of this class
        /// </summary>
        public Cylinder() : base()
        { base.Type = "Cylinder"; }

        /// <summary>
        /// this method calculates the area of Cylinder and returns it
        /// </summary>
        /// <returns> area of Cylinder in double </returns>
        public override double CalculateArea()
        {
            double cylinderArea = 2 * PI * radius * height + 2 * PI * Math.Pow(radius,2);   
            return cylinderArea;
        }

        /// <summary>
        /// this method calculates the volume of Cylinder and returns it
        /// </summary>
        /// <returns>returns volume of Cylinder in double</returns>
        public override double CalculateVolume()
        {
            double cylinderVolume = PI * Math.Pow(radius, 2) * height;  
            return cylinderVolume;
        }

        /// <summary>
        /// This method allows an user to enter the radius and height of Cylinder while storing the value
        /// </summary>
        public override void SetData()
        {
            Console.Write("\nEnter the radius: ");
            radius = Double.Parse(Console.ReadLine());  
            Console.Write("Enter the height: ");
            height = Double.Parse(Console.ReadLine());
        }

        /// <summary>
        /// This method represents string of a Cylinder 
        /// </summary>
        /// <returns>a string that contains details such as, radius, height, area, and volume of a cylinder</returns>
        public override string ToString()
        {
            return $"\n{base.Type} - radius: {radius}, height: {height}, area: {CalculateArea()}, volume: {CalculateVolume()}";
        }
    }
}
