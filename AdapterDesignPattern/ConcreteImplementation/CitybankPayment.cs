using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDesignPattern
{
    public class CitybankPayment : IPaymentStream
    {
        public void ProcessPayment(string paymentSystem)
        {
            Console.WriteLine("using city bank gateway for " + paymentSystem);
        }
    }
}
