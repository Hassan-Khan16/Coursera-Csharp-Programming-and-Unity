using System;

namespace DebugExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float angle;

            Console.WriteLine("Enter angle in degrees: ");
            angle = float.Parse(Console.ReadLine());

            angle *= MathF.PI / 180;

            Console.WriteLine(MathF.Cos(angle));
            Console.WriteLine(MathF.Sin(angle));
        }
    }
}
