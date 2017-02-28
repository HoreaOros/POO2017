using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class World
    {
        string id;

        /// <summary>
        /// Constructor implicit
        /// </summary>
        public World()
        {
            id = "generic";
        }


        /// <summary>
        /// Constructor (C'tor)
        /// </summary>
        /// <param name="v">id-ul lumii</param>
        public World(string v)
        {
            this.id = v;
        }

        public void SayHello()
        {
            Console.WriteLine("Hello from {0}", id);
        }
    }
}
