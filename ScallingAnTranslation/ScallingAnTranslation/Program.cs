using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScallingAnTranslation
{
    class Program
    {
        static void Main(string[] args)
        {
            int numVertices = 0;
            int numVertex = 1;

            Console.Write("How many vertices do you wish to enter? ");
            numVertices = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();



            do
            {
                Console.Write($"Enter the points of vertex {numVertex} separated by spaces: ");
                string vertex = Convert.ToString(Console.ReadLine());
                string[] vertexSplit = vertex.Split(' ');
                

            }
        }
    }
}
