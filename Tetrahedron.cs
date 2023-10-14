
/*
 Class: Tetrahedron.cs
 Author: Mitwa Patel, Student ID: 000905034
 Date: September 13, 2023
 Purpose: This class represents a Tetrahedron, a three-dimensional shape with a CalculateArea method that calculates 
 the area of Tetrahedron and CalculateVolume method that calculates the volume of Tetrahedron.
 This class is inherited from a base class (Shape.cs)
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2A
{
    public class Tetrahedron : Shape
    {
        private double length;

        /// <summary>
        /// Constructor that sets Type to "Tetrahedron" and initializes a new instance of this class
        /// </summary>
        public Tetrahedron()
        {  base.Type = "Tetrahedron"; }

        /// <summary>
        /// this method calculates the area of Tetrahedron and returns it
        /// </summary>
        /// <returns> area of Tetrahedron in double </returns>
        public override double CalculateArea()
        {
            double tetrahedronArea = Math.Sqrt(3) * Math.Pow(length,2);
            return tetrahedronArea;
        }

        /// <summary>
        /// this method calculates the volume of Tetrahedron and returns it
        /// </summary>
        /// <returns>returns volume of Tetrahedron in double</returns>
        public override double CalculateVolume()
        {
            double tetrahedronVolume = (Math.Pow(length, 3)) / 6 * Math.Sqrt(2);
            return tetrahedronVolume;
        }

        /// <summary>
        /// This method allows an user to enter the length of Tetrahedron while storing the value
        /// </summary>
        public override void SetData()
        {
            Console.Write("\nEnter the length: ");
            length = Double.Parse(Console.ReadLine());
        }

        /// <summary>
        /// This method represents string of a Tetrahedron 
        /// </summary>
        /// <returns>a string that contains details such as, length, area, and volume of a Tetrahedron</returns>
        public override string ToString()
        {
            return $"\n{base.Type} - length: {length}, area: {CalculateArea()}, volume: {CalculateVolume()}";
        }

    }
}
