/**
 * Chris Eflin
 * 
 * This program will use the forward euler method and the velocity verlet 
 * integration methods to model linear accelerated motion. The results will be
 * written out to a file for review.
 * 
 * Date created: 01/10/2018
 */



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MotionLab
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialization of the variables needed.
            // All set to 0.
            float deltaTime; // Change in time in seconds
            float time; // Initial time also in seconds
            float position; // Initial position in meters
            float velocity; // Initial velocity in m/s
            float acceleration; // Acceleration in m/s^2
            float accelerationNew;

            //Will have to change depending on who uses program
            string schoolPath = 
                @"C:\Users\svc-student\Desktop\" +
                @"MATH-PHYS_191\Lab1_TheVectorClass\";

            // First the Forward Euler Method
            // A ball being thrown from an initial height of 2.00m at an 
            // initial velocity of 49.0 m/s for times between 0.00s and 10.00s
            // using a time step of 0.10s(deltaTime). 
            // Assume acceleration due to gravity = -9.8m/s^2.

            //deltaTime = 0.10f;
            //time = 0.00f;
            //position = 2.00f;
            //velocity = 49.0f;
            //acceleration = -9.8f;

            //TextWriter sw1 = new StreamWriter(schoolPath + 
            //    "ex02_euler_0-10.csv");
            //do
            //{
            //    position += velocity * deltaTime; // Update Position
            //    velocity += acceleration * deltaTime; // Update Velocity
            //    time += deltaTime; // Update Time

            //    sw1.WriteLine($"{time},{position},{velocity}");
            //} while (time <= 10.00);
            //sw1.Close();

            //// time step of 1.0s

            //deltaTime = 1.00f;
            //time = 0.00f;
            //position = 2.00f;
            //velocity = 49.0f;
            //acceleration = -9.8f;

            //TextWriter sw2 = new StreamWriter(schoolPath +
            //    "ex02_euler_1-0.csv");
            //do
            //{
            //    position += velocity * deltaTime; // Update Position
            //    velocity += acceleration * deltaTime; // Update Velocity
            //    time += deltaTime; // Update Time

            //    sw2.WriteLine($"{time},{position},{velocity}");
            //} while (time <= 10.00);
            //sw2.Close();

            //// time step of 0.01s

            //deltaTime = 0.01f;
            //time = 0.00f;
            //position = 2.00f;
            //velocity = 49.0f;
            //acceleration = -9.8f;

            //TextWriter sw3 = new StreamWriter(schoolPath +
            //    "ex02_euler_0-01.csv");
            //do
            //{
            //    position += velocity * deltaTime; // Update Position
            //    velocity += acceleration * deltaTime; // Update Velocity
            //    time += deltaTime; // Update Time

            //    sw3.WriteLine($"{time},{position},{velocity}");
            //} while (time <= 10.00);
            //sw3.Close();

            //Console.WriteLine("Done Writing.");

            // All the same values as before but now the velocity verlet
            //method

            deltaTime = 0.10f;
            time = 0.00f;
            position = 2.00f;
            velocity = 49.0f;
            acceleration = -9.8f;
            accelerationNew = -9.8f;

            TextWriter sw4 = new StreamWriter(schoolPath +
                "ex02_verlet.csv");
            do
            {
                position += velocity * deltaTime + 0.5f * acceleration * 
                    (deltaTime * deltaTime); // Update Position

                accelerationNew += -9.8f * velocity; // update acceleration

                velocity += 0.5f * (acceleration + accelerationNew) * 
                    deltaTime; // Update Velocity

                acceleration = accelerationNew; // update acceleration

                time += deltaTime; // Update Time

                sw4.WriteLine($"{time},{position},{velocity}");
            } while (time <= 10.00);
            sw4.Close();

            Console.WriteLine("Done Writing.");

        }
    }
}
