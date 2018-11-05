using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_TheVectorClass
{
    class Vector3D
    {
        #region Variables
        float x = 0.0f;
        float y = 0.0f;
        float z = 0.0f;
        float w = 1.0f;

        //float vX = 0.0f;
        //float vY = 0.0f;
        //float vZ = 0.0f;
        #endregion

        #region 3D Vector
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

        //Calculate the Magnitude
        public float CalcMag(float vectorX, float vectorY, float vectorZ)
        {
            return Convert.ToSingle(Math.Sqrt(Math.Pow(vectorX, 2) + Math.Pow(vectorY, 2) + Math.Pow(vectorZ, 2)));
        }

        //Addition
        public static Vector3D operator +(Vector3D vector1, Vector3D vector2)
        {
            return new Vector3D(vector1.x + vector2.x, vector1.y + vector2.y, vector1.z + vector2.z);
        }

        //Subtraction
        public static Vector3D operator -(Vector3D vector1, Vector3D vector2)
        {
            return new Vector3D(vector1.x - vector2.x, vector1.y - vector2.y, vector1.z - vector2.z);
        }

        // Scalar multiplication
        public static Vector3D operator *(Vector3D vector, float scalar)
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
            Console.WriteLine($"{getX(x)}, {getY(y)}, {getZ(z)}");
        }

        public void printMag(float mag)
        {
            Console.WriteLine("Magnitude: {0:F}", mag);
        }

        public float getMag(float mag)
        {
            return mag; ///edit
        }
        #endregion

        //Converts radians to degrees and vice versa.
        public float radsToDeg(float rad)
        {
            float degrees = rad * (180 / (float)Math.PI);
            return degrees;
        }
        public float degToRads(float degrees)
        {
            float rads = degrees * ((float)Math.PI / 180);
            return rads;
        }

        // Sets the rect given the magnitude and the angle of a vector (2D)
        public void setRectGivenPolar(float mag, float head)
        {
            head = degToRads(head);
            x = mag * (float)Math.Cos(head);
            y = mag * (float)Math.Sin(head);
        }

        // Sets the rect given magnitude, heading, and pitch
        public void setRectGivenMagHeadPitch(float mag, float head, float pitch)
        {
            head = degToRads(head);
            pitch = degToRads(pitch);
            x = mag * (float)Math.Cos(pitch) * (float)Math.Cos(head);
            y = mag * (float)Math.Cos(pitch) * (float)Math.Sin(head);
            z = mag * (float)Math.Sin(pitch);
        }

        // Output = the magnitude and heading of the vector.
        public void printPolar(float mag, float angle)
        {
            Console.WriteLine($"Magnitude: {getMag(mag)}");
            Console.WriteLine($"Angle: {angle}");
        }

        // Output = the magnitude, heading, and pitch of the vector.
        public void printMagHeadPitch(float M, float H, float P)
        {
            float mag = getMag(M);
            float head = getHeading(M, P, H);
            float pitch = getPitch(M, P);

            //Convert from rad to degree
            head = radsToDeg(head);
            pitch = radsToDeg(pitch);

            //Print mag, head, pitch
            Console.WriteLine($"Magnitude: {mag}");
            Console.WriteLine($"Heading: {head}");
            Console.WriteLine($"Pitch: {pitch}");
        }

        public void printDirection(float mag, Vector3D alpha, Vector3D beta, Vector3D gama)
        {
            Console.WriteLine("Direction angles:");
            Console.WriteLine($"Alpha: {getAlpha(alpha, mag)}");
            Console.WriteLine($"Beta: {getBeta(beta, mag)}");
            Console.WriteLine($"Gama: {getGama(gama, mag)}");
        }

        public float getPitch(float M, float P)
        {
            float pitch = (float)Math.Asin((M * (float)Math.Sin(P) / M));

            if (M == 0)
                return 0;

            return pitch;
        }

        public float getHeading(float M, float P, float H)
        {
            float vX = M * (float)Math.Cos(P) * (float)Math.Cos(H);
            float vY = M * (float)Math.Cos(P) * (float)Math.Sin(H);
            float head = (float)Math.Acos(vX / (float)(Math.Sqrt(Math.Pow(vX, 2) + Math.Pow(vY, 2))));

            return head;
        }

        // Returns alpha, beta, and gama if mag != 0
        public float getAlpha(Vector3D vector, float mag)
        {

            if (mag == 0)
                return vector.x = 0;

            return (float)Math.Acos(vector.x / mag);
        }
        public float getBeta(Vector3D vector, float mag)
        {
            if (mag == 0)
                return vector.y = 0;

            return (float)Math.Acos(vector.y / mag);
        }
        public float getGama(Vector3D vector, float mag)
        {
            if (mag == 0)
                return vector.z = 0;

            return (float)Math.Acos(vector.z / mag);
        }

        // Calculates the dot product of the 2 vectors U and V.
        public float dotProduct(Vector3D U, Vector3D V)
        {
            float dProd = U.x * V.x + U.y * V.y + U.z * V.z;
            return dProd;
        }

        // Calculates the angle between the 2 vectors U and V.
        public float dotProdAngle(Vector3D U, Vector3D V)
        {
            float angle = dotProduct(U, V) / (CalcMag(U.x, U.y, U.z) * CalcMag(V.x, V.y, V.z));
            return angle;
        }

        //NEEDS EDIT
        //
        public Vector3D paraProj(Vector3D U, Vector3D V)
        {
            float paraX = (dotProduct(U, V) / (CalcMag(V.x, V.y, V.z) * CalcMag(V.x, V.y, V.z)) * V.x);
            float paraY = (dotProduct(U, V) / (CalcMag(V.x, V.y, V.z) * CalcMag(V.x, V.y, V.z)) * V.y);
            float paraZ = (dotProduct(U, V) / (CalcMag(V.x, V.y, V.z) * CalcMag(V.x, V.y, V.z)) * V.z);

            return new Vector3D(paraX, paraY, paraZ);
        }

        //public Vector3D perpProj(Vector3D U, Vector3D V)
        //{

        //}

        #region 4D Vector

        public float getW(float w)
        {
            return w;
        }

        public Vector3D(float X, float Y, float Z, float W)
        {
            x = X;
            y = Y;
            z = Z;
            w = W;
        }

        //Output the 4D vector to the user
        public void printRect4D()
        {
            Console.WriteLine($"{getX(x)}, {getY(y)}, {getZ(z)}, {getW(w)}");
        }

        #endregion

        //4D dot product
        public float fourDDotProduct(Vector3D U, Vector3D V)
        {
            float fourDDotProd = U.x * V.x + U.y * V.y + U.z * V.z + U.w * V.w;
            return fourDDotProd;
        }

        #region Matrices

        // define matrix
        //public Array[,] newMatrix(int rows, int columns)
        //{
        //    Array[,] matrix = new Array[rows, columns];
        //    return matrix;
        //}

        //public Array[,] setMatrix(Array[,] matrix, float point)
        //{
        //    Array[,] newMatrix = new Array[matrix.GetLength(0), matrix.GetLength(1)];
        //    for
        //}
        public float[] setMatrixRow(float[] arr)
        {
            float[] matrixRow = new float[arr.GetLength(0)];
            for (int i = 0; i < arr.GetLength(0) - 1; ++i)
            {
                matrixRow[i] = arr[i];
            }
            return matrixRow;
        }

        #endregion
    }

}