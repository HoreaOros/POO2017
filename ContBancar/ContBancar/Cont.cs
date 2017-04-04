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
        public static int Count
        {
            get
            {
                return contor;
            }
        }
        public void Depune(decimal suma)
        {
            if (suma >= 0)
            {
                sold += suma;
            }
            else
            {
                throw new InvalidAmountException("suma depusa este negativa");
            }
        }
    }
}
