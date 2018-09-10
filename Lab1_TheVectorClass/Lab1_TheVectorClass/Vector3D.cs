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

        //float vX = 0.0f;
        //float vY = 0.0f;
        //float vZ = 0.0f;

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

        public void setRectGivenRect(Vector3D vector)
        {
            x = vector.x;
            y = vector.y;
            z = vector.z;
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

        //public Vector3D (Vector3D vector, float mag)
        //{
        //    return new Vector3D((1 / mag) * vector.x, (1 / mag) * vector.y, (1 / mag) * vector.z);
        //}

        public void printRect()
        {
            //Console.WriteLine("x: " + x);
            //Console.WriteLine("y: " + y);
            //Console.WriteLine("z: " + z);
            Console.WriteLine("{0}, {1}, {2}", x, y, z);
        }

        public void printMag(float mag)
        {
            Console.WriteLine("Magnitude: {0:F}", mag);
        }

        public float getMag(float mag)
        {
            return mag;
        }

        // Sets the rect given the magnitude and the angle of a vector (2D)
        public void setRectGivenPolar (float mag, float angle)
        {
            x = mag * (float)Math.Cos(angle);
            y = mag * (float)Math.Sin(angle);
        }

        public void setRectGivenMagHeadPitch (float mag, float head, float pitch)
        {
            x = mag * (float)Math.Cos(pitch) * (float)Math.Cos(head);
            y = mag * (float)Math.Cos(pitch) * (float)Math.Sin(head);
            z = mag * (float)Math.Sin(pitch);
        }

        public void printPolar(float mag, float angle)
        {
            Console.WriteLine("Magnitude: {0}", mag);
            Console.WriteLine("Angle: {0}", angle);
        }

        public void printMagHeadPitch(float mag, float head, float pitch)
        {
            Console.WriteLine("Magnitude: {0}", mag);
            Console.WriteLine("Heading: {0}", head);
            Console.WriteLine("Pitch: {0}", pitch);
        }

        public void printDirection(float alpha, float beta, float gama)
        {
            Console.WriteLine("Direction angles:");
            Console.WriteLine("Alpha: {0}", alpha);
            Console.WriteLine("Beta: {0}", beta);
            Console.WriteLine("Gama: {0}", gama);
        }

        public float getPitch(float pitch)
        {
            return pitch;
        }

        public float getHeading(float head)
        {
            return head;
        }

        public float getAlpha(Vector3D vector, float mag)
        {
            return (float)Math.Acos(vector.x / mag);
        }
        public float getBeta(Vector3D vector, float mag)
        {
            return (float)Math.Acos(vector.y / mag);
        }
        public float getGama(Vector3D vector, float mag)
        {
            return (float)Math.Acos(vector.z / mag);
        }
    }
}
