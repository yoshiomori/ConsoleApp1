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
            var line = Console.ReadLine();
            var response = new List<Vector<double>>();
            while (line.Length > 0)
            {
                var words = line.Split(' ');
                var n = int.Parse(words[0]);
                var rows = n * (n - 1) / 2;
                var A = Matrix<double>.Build.Dense(rows, n);
                for (int i = 0, j = 0, k = 1; i < rows; i++)
                {
                    A[i, j] = 1;
                    A[i, k] = 1;
                    k++;
                    if (k >= n)
                    {
                        j++;
                        k = j + 1;
                    }
                }
                var b = Vector<double>.Build.Dense(rows, i => double.Parse(words[i + 1]));
                response.Add(A.Solve(b));
                line = Console.ReadLine();
            }
            foreach (var x in response)
                Console.WriteLine(
                    x
                    .ToArray()
                    .Select(v=>v.ToString())
                    .Aggregate((s1, s2) => string.Format("{0} {1}", s1, s2))
                );
            Console.ReadLine();
        }
    }
}
