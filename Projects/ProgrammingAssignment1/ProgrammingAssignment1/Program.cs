using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProgrammingAssignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome! This application will calculate the maximum height of the shell and the distance it will travel along the ground.");
            Console.Write("Firing angle: ");
            float theta = float.Parse(Console.ReadLine()) * (float)Math.PI / 180F; // initial angle you’ll ask the user to provide
            Console.Write("Firing speed: ");
            float speed = float.Parse(Console.ReadLine()); // initial speed you’ll ask the user to provide
            const float g = 9.8F; // acceleration due to gravity
            float vox = speed * (float)Math.Cos(theta); // x component of the velocity at start
            float voy = speed * (float)Math.Sin(theta); // y component of the velocity at start
            float t = voy / g; // time until shell reaches apex
            float h = voy * voy / (2 * g); // height of shell at apex
            float dx = vox * 2 * t; // distance shell travels horizontally (assuming launch and target elevations are equal)
            Console.WriteLine("Maximum shell height: " + h + " meters");
            Console.WriteLine("Horizontal distance: " + dx + " meters");
        }
    }
}
