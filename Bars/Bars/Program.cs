using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bars
{
    class Program
    {
        static void Main(string[] args)
        {
            HorzBar h1 = new HorzBar(5);
            VertBar v1 = new VertBar(4);

            Frame f = new Frame(3, 2);

            Ladder lad = new Ladder(30, 2, 1);
        }
    }
}
