using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELTE.EVA2.Lecture01
{
    class Program
    {
	    static void LogMessage(string message)
	    {
		    Console.WriteLine("Message logged: {0}", message);
	    }

		static void LogMessage(string msg1, string msg2)
		{
			LogMessage(msg1);
			LogMessage(msg2);
		}

	    static void LogMessage(params string[] messages)
	    {
		    foreach (var message in messages)
			    Console.WriteLine(message);
	    }

        static void Main(string[] args)
        {
            var matrix = Matrix.GetIdenticalMatrix(10);
            Console.WriteLine(matrix.Add(Matrix.GetIdenticalMatrix(10)));

	        LogMessage("Hello", "World");
			LogMessage("Hello");
			LogMessage(new[] { "Hello" });
			LogMessage(new[] { "Hello", "World" });

			var words = new []{ "Hello", " ", "World", "!" };
	        IEnumerator enumerator = words.GetEnumerator();
			enumerator.Reset();
	        while (enumerator.MoveNext())
	        {
		        string current = (string)enumerator.Current;
		        Console.Write(current.ToUpper());
	        }
        }
    }
}
