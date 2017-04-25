using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContBancar
{
    class Program
    {
        static void Main(string[] args)
        {
            Cont c1 = new Cont("John Doe");
            Cont c2 = new Cont("Jane Doe", 1000m);

            
            Console.WriteLine("Numarul total de conturi create este: {0}", Cont.Count);

            try
            {
                c1.Depune(100m);
                c1.Retrage(50m);
                c1.Retrage(150m);
                c1.Depune(100m);
            }
            catch (InvalidAmountException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (NotEnoughFundsException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
