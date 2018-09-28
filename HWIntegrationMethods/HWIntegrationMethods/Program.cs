/**
 * Chris Eflin
 * This program will calculate and display the 1D motion of a projectile
 * using the velocity verlet method with the conditions:
 * Position = 2.0 m
 * Velocity = 0.0 m/s
 * DeltaTime = 0.02 s
 * Acceleration = -5.0 * position
 *
 * Date Created: 09/27/2018
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWIntegrationMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            float position = 2.0f; // Position in meters
            float velocity = 0.0f; // Velocity in meters/second
            float deltaTime = 0.02f; // Change in time in seconds
            float acceleration = 0.0f; // Acceleration in meters/second^2

            int numTimes = 50; // Number of times to iterate.

            for (int i = 0; i <= numTimes; i++) // runs 50 times
            {
                // Step 1: update position
                float newPos = position + (velocity * deltaTime) +
                               (0.5f * acceleration * (deltaTime * deltaTime));
                Console.WriteLine($"Position: {newPos} m");

                // Step 2: update acceleration
                float newAcc = -5.0f * position;
                Console.WriteLine($"Acceleration: {newAcc} m/s^2");

                // Step 3: update velocity
                float newVel = velocity + ((newAcc + acceleration) / 2) * deltaTime;
                Console.WriteLine($"Velocity: {newVel} m/s");

                // Step 4: acceleration = new acceleration
                acceleration = newAcc;

                // Show time
                int time = i;
                Console.WriteLine($"Time: {time} s");
            }
        }
    }
}
