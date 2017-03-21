using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TipuriValoare
{
    enum ZiSaptamana
    {
        Luni = 1,
        Marti,
        Miercuri,
        Joi,
        Vineri,
        Sambata,
        Duminica
    }
    struct Point2D
    {
        public int x, y;

        public override string ToString()
        {
            return "(" + x + ", " + y + ")";
        }
        public void Translate(int delta)
        {
            x += delta;
            y += delta;
        }
    }
    class Program
    {
        static void Process(Point2D p)
        {
            // Modific punctul
            p.x++;
            p.y++;
        }
        static void Main(string[] args)
        {
            Point2D p1 = new Point2D();
            p1.x = 1;
            p1.y = 2;
            Console.WriteLine(p1);

            p1.Translate(5);
            Console.WriteLine(p1);


            Process(p1);
            Console.WriteLine(p1);

            //FileStream fs = new FileStream("input.in", FileMode.Open, FileAccess.Read);

            //FileAccess fa = FileAccess.Read;

            //switch (fa)
            //{
            //    case FileAccess.Read:
            //        break;
            //    case FileAccess.Write:
            //        break;
            //    case FileAccess.ReadWrite:
            //        break;
            //    default:
            //        break;
            //}


            ZiSaptamana zi = ZiSaptamana.Marti;

            Console.WriteLine(zi);
            Console.WriteLine((int)zi);

            string[] names = Enum.GetNames(typeof(ZiSaptamana));
            foreach (var item in names)
            {
                Console.WriteLine(item);
            }

            long lng = Int64.MaxValue;

            int n = (int)lng;

            Console.WriteLine("n = {0}", n);
        }
    }
}
