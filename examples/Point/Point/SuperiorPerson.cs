using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    sealed partial class SuperiorPerson : PersonBase
    {
        public override void Greeting()
        {
            DoSomethingAwesome();
            Console.WriteLine("Behold the Superior Person!");
        }
    }
}
