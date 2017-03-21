using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Instructiuni
{
    class Program
    {
        static void ExceptionTest()
        {
            try
            {
                checked
                {
                    int n = int.MaxValue;
                    Console.WriteLine(++n);
                }
            }
            catch (OverflowException e)
            {
                Console.WriteLine(e.Message);
                throw;
            }


        }
        static void Main(string[] args)
        {
            try
            {
                ExceptionTest();
            }
            catch (Exception e)
            {
                Console.WriteLine("Oops!. Something went wrong.");
            }

            FileStream fs = File.Create("input.txt");
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine("Hello World!");
            sw.Close();


            FileInfo f = new FileInfo("input.txt");
            Console.WriteLine(f.Length);
        }
    }
}
