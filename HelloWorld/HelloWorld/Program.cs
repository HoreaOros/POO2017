using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{

    class Program
    {
        static void Main(string[] args)
        {
            World w1 = new World("a");

            w1.SayHello();


            World w2 = new World("b");
            w2.SayHello();

            World w3 = new World();
        }
    }
}
