using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContBancar
{
    class Cont
    {
        private string titular;
        private decimal sold;
        private static int contor = 0;

        public Cont(string titular): this(titular, 0)
        {

        }
        public Cont(string titular, decimal sold)
        {
            this.titular = titular;
            this.sold = sold;
            contor++;
        }

        internal void Retrage(decimal suma)
        {
            Log("Incerc sa retarg", suma);
            if (this.sold - suma >= 0)
            {
                sold -= suma;
                Log("Am retras", suma);
            }
            else
            {
                Log("Nu am reusit sa retrag", suma);
                throw new NotEnoughFundsException("Fonduri insuficiente.");
            }
        }

        public static int Count
        {
            get
            {
                return contor;
            }
        }
        public void Depune(decimal suma)
        {
            Log("Incerc sa depun", suma);
            if (suma >= 0)
            {
                sold += suma;
                Log("Am depus", suma);
            }
            else
            {
                Log("Nu am reusit sa depun", suma);
                throw new InvalidAmountException("suma depusa este negativa");
            }
        }

        private void Log(string v, decimal suma)
        {
            Console.Write(v);
            Console.WriteLine(" {0}", suma);
        }
    }
}
