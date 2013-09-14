using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELTE.EVA2.Lecture01
{
    class Program
    {
        static void Main(string[] args)
        {
            var matrix = Matrix.GetIdenticalMatrix(10);
            Console.WriteLine(matrix.Add(Matrix.GetIdenticalMatrix(10)));
        }
    }
}
