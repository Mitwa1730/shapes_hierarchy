
/*
 Class: Cube.cs
 Author: Mitwa Patel, Student ID: 000905034
 Date: September 13, 2023
 Purpose: This class represents a Cube, a three-dimensional shape with a CalculateArea method that calculates 
 the area of Cube and CalculateVolume method that calculates the volume of Cube.
 This class is inherited from a base class (Shape.cs)
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2A
{
    public class Cube : Shape
    {
        private double length;

        /// <summary>
        /// Constructor that sets Type to "Cube" and initializes a new instance of this class
        /// </summary>
        public Cube() : base()
        { base.Type = "Cube"; }

        /// <summary>
        /// this method calculates the area of Cube and returns it
        /// </summary>
        /// <returns> area of cube in double </returns>
        public override double CalculateArea()
        {
            double cubeArea = 6 * Math.Pow(length, 2);
            return cubeArea;
        }

        /// <summary>
        /// this method calculates the volume of Cube and returns it
        /// </summary>
        /// <returns>returns volume of Cube in double</returns>
        public override double CalculateVolume()
        {
            double cubeVolume = length * length * length;
            return cubeVolume;
        }

        /// <summary>
        /// This method allows an user to enter the length of Cube while storing the value
        /// </summary>
        public override void SetData()
        {
            Console.Write("\nEnter the length: ");
            length = Double.Parse(Console.ReadLine());
        }

        /// <summary>
        /// This method represents string of a Cube 
        /// </summary>
        /// <returns>a string that contains details such as, length, area, and volume of a Cube</returns>
        public override string ToString()
        {
            return $"\n{base.Type} - length: {length}, area: {CalculateArea()}, volume: {CalculateVolume()}";
        }
    }
}
