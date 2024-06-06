// See https://aka.ms/new-console-template for more information
using System;

namespace Coding.Exercise
{
    public static class MathConstants
    {
        public const double PI = 3.141592653589793;
        public static double GoldenRatio { get; } = 1.61803398875;
    }

    public class Exercise
    {
       
        public void PrintConstants()
        {
            Console.WriteLine($"PI: {MathConstants.PI}");
            Console.WriteLine($"Golden Ratio: {MathConstants.GoldenRatio}");
        }
    }
}