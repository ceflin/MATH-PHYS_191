/**
 * Chris Eflin
 * 
 * This program will be built upon over the course of a semester 
 * to create a Vector 3D class. 
 * 
 * 18/09/03 - The objective of class Program is to prompt the user 
 * for input and call upon class Vector3D to do the 
 * vector calculations for sum, difference, scalar product and
 * normalization.
 * 
 * 18/09/10 - 
 * 
 **/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_TheVectorClass
{
    class Program
    {
        public static void Main()
        {
            //Console.WriteLine("Input first vector:");
            //string vectorString1 = Convert.ToString(Console.ReadLine());

            //Console.WriteLine();
            //Console.WriteLine("Input second vector:");
            //string vectorString2 = Convert.ToString(Console.ReadLine());

            //string[] vector1Split = vectorString1.Split(',');

            //string[] vector2Split = vectorString2.Split(',');

            //float vector1X = Convert.ToSingle(vector1Split[0]);
            //float vector1Y = Convert.ToSingle(vector1Split[1]);
            //float vector1Z = Convert.ToSingle(vector1Split[2]);

            //float vector2X = Convert.ToSingle(vector2Split[0]);
            //float vector2Y = Convert.ToSingle(vector2Split[1]);
            //float vector2Z = Convert.ToSingle(vector2Split[2]);

            //Vector3D vector1 = new Vector3D(vector1X, vector1Y, vector1Z);
            //float mag1 = vector1.CalcMag(vector1X, vector1Y, vector1Z);

            //Vector3D vector2 = new Vector3D(vector2X, vector2Y, vector2Z);
            //float mag2 = vector2.CalcMag(vector2X, vector2Y, vector2Z);

            //Console.WriteLine();
            //Console.WriteLine("First vector:");
            //Console.WriteLine(vector1X + "," + vector1Y + "," + vector1Z);
            //Console.WriteLine();

            //vector1.printMag(mag1);

            //Console.WriteLine();
            //Console.WriteLine("Second vector:");
            //Console.WriteLine(vector2X + "," + vector2Y + "," + vector2Z);
            //Console.WriteLine("");

            //vector2.printMag(mag2);

            //Console.WriteLine();
            //Console.WriteLine("The sum of the 2 vectors is: ");
            //Vector3D vectorSum = vector1 + vector2;
            //vectorSum.printRect();

            //Console.WriteLine();
            //Console.WriteLine("The difference of the 2 vectors is: ");
            //Vector3D vectorDiff = vector1 - vector2;
            //vectorDiff.printRect();

            //Console.WriteLine();
            //Console.Write("Enter a scalar: ");
            //float scalar = Convert.ToSingle(Console.ReadLine());

            //Console.WriteLine();
            //Console.WriteLine("The product of the 1st vector is: ");
            //Vector3D vectorProd = vector1 * scalar;
            //vectorProd.printRect();

            //Console.WriteLine();

/* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * */
            
            Console.Write("Enter the angle of the pole: ");
            float angle = Convert.ToSingle(Console.ReadLine());
            Console.Write("Enter the distance: ");
            float dist = Convert.ToSingle(Console.ReadLine());
            Console.Write("Enter the heading: ");
            float head = Convert.ToSingle(Console.ReadLine());
            Console.Write("Enter the pitch: ");
            float pitch = Convert.ToSingle(Console.ReadLine());

        }
    }
}
