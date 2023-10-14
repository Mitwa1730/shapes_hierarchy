
/*
 Class: Ellipse.cs
 Author: Mitwa Patel, Student ID: 000905034
 Date: September 13, 2023
 Purpose: This class represents an Ellipse, a two-dimensional shape with a CalculateArea method that calculates 
 the area of Ellipse.
 This class is inherited from a base class (Shape.cs)
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;

namespace Lab2A
{
    public class Ellipse : Shape
    {
        private double lengthA;
        private double lengthB;

        /// <summary>
        /// Constructor that sets Type to "Ellipse" and initializes a new instance of this class
        /// </summary>
        public Ellipse() : base()
        { base.Type = "Ellipse"; }

        /// <summary>
        /// this method calculates the area of ellipse and returns it
        /// </summary>
        /// <returns> area of ellipse in double </returns>
        public override double CalculateArea()
        {
            double ellipseArea = PI * lengthA * lengthB;
            return ellipseArea;
        }

        /// <summary>
        /// this method calculates the volume of an ellipse. Since ellipse is a two dimensional shape, it returns 0
        /// </summary>
        /// <returns> returns 0 as ellipse is a two dimensional shape. </returns>
        public override double CalculateVolume()
        { return 0; }

        /// <summary>
        /// This method allows an user to enter the lengths of ellipse while storing the value
        /// </summary>
        public override void SetData()
        {
            Console.Write("\nEnter the semi-major axis lenght: ");
            lengthA = Double.Parse(Console.ReadLine());
            Console.Write("Enter the semi-minor axis lenght: ");
            lengthB = Double.Parse(Console.ReadLine());
        }

        /// <summary>
        /// This method represents string of a Ellipse 
        /// </summary>
        /// <returns>a string that contains details such as, lengths of an ellipse</returns>
        public override string ToString()
        {
            return $"\n{base.Type} - lengthA: {lengthA}, lengthB: {lengthB}, area: {CalculateArea()}";
        }
    }
}
