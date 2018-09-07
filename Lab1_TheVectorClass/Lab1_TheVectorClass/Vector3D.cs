using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_TheVectorClass
{
    class Vector3D
    {
        // Variables
        float x = 0.0f;
        float y = 0.0f;
        float z = 0.0f;
        float w = 1.0f;

        public float getX(float x)
        {
            return x;
        }

        public float getY(float y)
        {
            return y;
        }

        public float getZ(float z)
        {
            return z;
        }

        public Vector3D()
        {
            x = 0f;
            y = 0f;
            z = 0f;
            w = 1f;
        }

        public Vector3D(float X, float Y, float Z)
        {
            x = X;
            y = Y;
            z = Z;
        }

        public float CalcMag(float vectorX, float vectorY, float vectorZ)
        {
            return Convert.ToSingle(Math.Sqrt(Math.Pow(vectorX, 2) + Math.Pow(vectorY, 2) + Math.Pow(vectorZ, 2)));
        }

        //Addition
        public static Vector3D operator+(Vector3D vector1, Vector3D vector2)
        {
            return new Vector3D(vector1.x + vector2.x, vector1.y + vector2.y, vector1.z + vector2.z);
        }

        //Subtraction
        public static Vector3D operator-(Vector3D vector1, Vector3D vector2)
        {
            return new Vector3D(vector1.x - vector2.x, vector1.y - vector2.y, vector1.z - vector2.z);
        }

        // Scalar multiplication
        public static Vector3D operator*(Vector3D vector, float scalar)
        {
            return new Vector3D(vector.x * scalar, vector.y * scalar, vector.z * scalar);
        }

        public void printRect()
        {
            Console.WriteLine("x: " + x);
            Console.WriteLine("y: " + y);
            Console.WriteLine("z: " + z);

        }

        public void printMag(float mag)
        {
            Console.WriteLine("Magnitude: {0:F}", mag);
        }
    }
}
