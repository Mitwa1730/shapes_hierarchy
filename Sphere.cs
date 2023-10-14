
/*
 Class: Sphere.cs
 Author: Mitwa Patel, Student ID: 000905034
 Date: September 13, 2023
 Purpose: This class represents a Sphere, a three-dimensional shape with a CalculateArea method that calculates 
 the area of Sphere and CalculateVolume method that calculates the volume of Sphere.
 This class is inherited from a base class (Shape.cs)
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2A
{
    public class Sphere : Shape
    {
        private double radius;

        /// <summary>
        /// Constructor that sets Type to "Sphere" and initializes a new instance of this class
        /// </summary>
        public Sphere()
        { base.Type = "Sphere"; }

        /// <summary>
        /// this method calculates the area of Sphere and returns it
        /// </summary>
        /// <returns> area of Sphere in double </returns>
        public override double CalculateArea()
        {
            double sphereArea = 4 * PI * Math.Pow(radius,2);  
            return sphereArea;
        }

        /// <summary>
        /// this method calculates the volume of Sphere and returns it
        /// </summary>
        /// <returns>returns volume of Sphere in double</returns>
        public override double CalculateVolume()
        {
            double sphereVolume = (4*PI* Math.Pow(radius,3))/3;
            return sphereVolume;
        }


        /// <summary>
        /// This method allows an user to enter the radius of Sphere while storing the value
        /// </summary>
        public override void SetData()
        {
            Console.Write("\nEnter the radius: ");
            radius = Double.Parse(Console.ReadLine());
        }

        /// <summary>
        /// This method represents string of a Sphere 
        /// </summary>
        /// <returns>a string that contains details such as, radius, area, and volume of a cylinder</returns>
        public override string ToString()
        {
            return $"\n{base.Type} - radius: {radius}, area: {CalculateArea()}, volume: {CalculateVolume()}";
        }
    }
}
