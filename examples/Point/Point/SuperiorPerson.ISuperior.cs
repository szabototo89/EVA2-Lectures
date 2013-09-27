using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.InteropServices.ComTypes;

namespace ConsoleApplication1
{
    interface ISuperior
    {
        void DoSomethingAwesome();
    }

    partial class SuperiorPerson : ISuperior
    {
        public void DoSomethingAwesome()
        {
            Console.WriteLine("Okay dockey karaoke ;)");
        }
    }

    public delegate void Action();

    public delegate void Action<TParameter>(TParameter parameter);

    static class Ensure
    {
        public static void NotNull(object obj, string message)
        {
            if (obj == null)
                throw new ArgumentNullException(message);
        }
    }

    public static class Math
    {
        private static event Action _DoSomethingEvent;

        public static event Action DoSomethingEvent
        {
            add
            {
                _DoSomethingEvent += value;
                Console.WriteLine("Adding ...");
            }
            remove
            {
                _DoSomethingEvent -= value;
                Console.WriteLine("Removing ...");
            }
        }

        private static void OnDoSomethingEvent()
        {
            int[] a = new int[] { 1,2,4 };
            int[] b = new int[10];
            int[][] matrix = new int[][]
            {
                new[] {1, 0, 0},
                new[] {0, 1, 0},
                new[] {0, 0, 1},
            };
            int[,] matrix2 = new int[3,3];
            Action handler = _DoSomethingEvent;
            if (_DoSomethingEvent != null) handler();
        }


        public static void ForEach<T>(IEnumerable<T> enumerable, Action<T> method)
        {
            if (method == null) throw new ArgumentNullException("method");

            foreach (var item in enumerable)
                method(item);
        }

        public static TType Max<TType>(TType a, TType b)
            where TType : IComparable
        {
            ForEach(new String[] { "Hello", "World" }, Console.WriteLine);

            return a.CompareTo(b) > 0 ? a : b;
        }
    }
}
