using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELTE.EVA2.Lecture01
{
    /// <summary>
    /// Első mátrix reprezentációnk
    /// </summary>
    public class Matrix
    {
        private int[,] _Data;

        public int N { get; set; }
        public int M { get; set; }

        public Matrix() : this(2, 2) { }
        public Matrix(int n) : this(n, n) { }

        public Matrix(int n, int m)
        {
            N = n;
            M = m;
            _Data = new int[N, M];
        }

        public Matrix Negate()
        {
            var result = new Matrix(M, N);
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    result._Data[i, j] = -_Data[i, j];
                }
            }

            return result;
        }

        public Matrix Add(Matrix matrix)
        {
            if (matrix == null)
                throw new ArgumentNullException("matrix");
            
            if (N != matrix.N || M != matrix.M) 
                throw new ArgumentException("Mátrixoknak azonos méretűeknek kell lenniük!");

            var result = new Matrix(N, M);

            for (int i = 0; i < N; i++)
                for (int j = 0; j < M; j++)
                    result._Data[i, j] = _Data[i, j] + matrix._Data[i, j];

            return result;
        }

        public Matrix Subtract(Matrix matrix)
        {
            if (matrix == null)
                throw new ArgumentNullException("matrix");

            return Add(matrix.Negate());
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    builder.Append(_Data[i, j])
                           .Append(" ");
                }
                builder.AppendLine();
            }

            return builder.ToString();
        }

        public static Matrix GetIdenticalMatrix(int n)
        {
            var matrix = new Matrix(n);

            for (int i = 0; i < n; i++)
                matrix._Data[i, i] = 1;

            return matrix;
        }
    }
}
