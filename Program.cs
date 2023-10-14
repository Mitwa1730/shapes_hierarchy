
/*
 Class: Progarm.cs
 Author: Mitwa Patel, Student ID: 000905034
 Date: September 13, 2023
 Purpose: This class represents the main program that allows an user to interact, input, and provide shape dimensions.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace Lab2A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>();
            
            bool isContinue = true;
            while(isContinue)
            {
                Console.WriteLine("Mitwa's Geometry Class: \n");
                Console.WriteLine("A - Rectangle \t E - Ellipse \t I - Triangle");
                Console.WriteLine("B - Square \t F - Circle \t J - Tetrahedron");
                Console.WriteLine("C - Box \t G - Cylinder");
                Console.WriteLine("D - Cube \t H - Sphere");
                Console.WriteLine("\n0 - List all shapes and Exit...");
                Console.Write($"\n({shapes.Count} shapes entered so far)\n");
                Console.Write("\nEnter your Choice: ");
                
                String userChoice = Console.ReadLine().ToUpper();

                switch (userChoice)
                {
                    case "A": 
                        // it creates a new rectangle, sets data of it, and add it to the list of shapes
                        Rectangle rect = new Rectangle(); 
                        rect.SetData();
                        shapes.Add(rect);
                        Console.Clear();
                        break;

                    case "B":
                        // it creates a new square, sets data of it, and add it to the list of shapes
                        Square sqr = new Square();
                        sqr.SetData();
                        shapes.Add(sqr);
                        Console.Clear();
                        break;

                    case "C":
                        // it creates a new box, sets data of it, and add it to the list of shapes
                        Box box = new Box();
                        box.SetData();
                        shapes.Add(box);
                        Console.Clear();
                        break;

                    case "D":
                        // it creates a new cube, sets data of it, and add it to the list of shapes
                        Cube cube = new Cube();
                        cube.SetData(); 
                        shapes.Add(cube);
                        Console.Clear();
                        break;

                    case "E":
                        // it creates a new ellipse, sets data of it, and add it to the list of shapes
                        Ellipse ellipse = new Ellipse();
                        ellipse.SetData();
                        shapes.Add(ellipse);
                        Console.Clear();
                        break;

                    case "F":
                        // it creates a new circle, sets data of it, and add it to the list of shapes
                        Circle circle = new Circle();
                        circle.SetData();
                        shapes.Add(circle);
                        Console.Clear();
                        break;

                    case "G":
                        // it creates a new cylinder, sets data of it, and add it to the list of shapes
                        Cylinder cylinder = new Cylinder();
                        cylinder.SetData();
                        shapes.Add(cylinder);
                        Console.Clear();
                        break;

                    case "H":
                        // it creates a new sphere, sets data of it, and add it to the list of shapes
                        Sphere sphere = new Sphere();     
                        sphere.SetData();
                        shapes.Add(sphere);
                        Console.Clear();
                        break;

                    case "I":
                        // it creates a new triangle, sets data of it, and add it to the list of shapes
                        Triangle triangle = new Triangle();
                        triangle.SetData();
                        shapes.Add(triangle);
                        Console.Clear();
                        break;

                    case "J":
                        // it creates a new tetrahedron, sets data of it, and add it to the list of shapes
                        Tetrahedron tetrahedron = new Tetrahedron();
                        tetrahedron.SetData();
                        shapes.Add(tetrahedron);
                        Console.Clear();
                        break;

                    case "0":
                        // it handles the user input to exit the program and to add shapes into the list
                        isContinue = false;
                        foreach(Shape shape in shapes)
                        {
                            Console.WriteLine(shape);
                        }
                        break;

                    default:
                        // it handles the case when user enters an invalid input and displays an error message
                        Console.WriteLine("Please enter a valid input....Press any key to continue");
                        Console.Clear();
                        break;
                }
            }
            Console.ReadLine();
        }
    }
}
