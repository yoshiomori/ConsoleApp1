using MathNet.Numerics.LinearAlgebra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var A = Matrix<double>.Build.DenseOfArray(new double[,] {
                { 3, 2, -1 },
                { 2, -2, 4 },
                { -1, 0.5, -1 }
            });
            var b = Vector<double>.Build.Dense(new double[] { 1, -2, 0 });
            var x = A.Solve(b);
            Console.WriteLine(x);
            Console.ReadLine();
        }
    }
}
