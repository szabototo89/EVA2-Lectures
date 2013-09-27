using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    interface IPerson
    {
        string Name { get; set; }
        void Greeting();
    }

    public abstract class PersonBase : IPerson
    {
        public string Name { get; set; }
        public abstract void Greeting();
    }

    public class UntouchablePerson : PersonBase
    {
        public sealed override void Greeting()
        {
            Console.WriteLine("Behold the Superior Person!");
        }
    }

    class Woman : PersonBase
    {
        public override void Greeting()
        {
            Console.WriteLine("Hi, Miss/Mrs. {0}", Name);
        }
    }

    class Man : PersonBase
    {
        public override void Greeting()
        {
            Console.WriteLine("Hi Mr. {0}", Name);
        }
    }

    public enum PointType
    {
        TwoDimensional,
        ThreeDimensional
    }

    interface IAdditive<T> where T : IAdditive<T>
    {
        T Add(T other);
        T Negate();
    }

    interface IMultiplicative<T> where T : IMultiplicative<T>
    {
        T Multiply(T other);
    }

    struct Point : IAdditive<Point>, IMultiplicative<Point>
    {
        public int X { get; private set; }
        public int Y { get; private set; }

        /// <summary>
        /// Default constructor
        /// </summary>
        public Point(int x, int y)
            : this()
        {
            X = x;
            Y = y;
        }

        public Point Add(Point other)
        {
            return new Point(X + other.X, Y + other.Y);
        }

        public Point Multiply(Point other)
        {
            return new Point(X * other.X, Y * other.Y);
        }

        public Point Multiply(int x, int y)
        {
            return Multiply(new Point(x, y));
        }

        public Point Add(int x, int y)
        {
            return Add(new Point(x, y));
        }

        public Point Negate()
        {
            return new Point(-X, -Y);
        }

        public override string ToString()
        {
            return string.Format("({0}, {1})", X, Y);
        }

        public static readonly Point Origo = new Point(0, 0);
    }

    class Program
    {
        static void Main(string[] args)
        {
            var p = new Point(10, 0);
            Console.WriteLine(p.Add(new Point(1, 1)).Multiply(new Point(1, 2)));
        }
    }
}
