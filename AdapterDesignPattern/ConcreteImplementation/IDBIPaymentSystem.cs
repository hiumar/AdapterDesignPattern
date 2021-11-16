using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDesignPattern
{
    public class IDBIPaymentSystem : IPaymentStream
    {
        public void ProcessPayment(string paymentSystem)
        {
            Console.WriteLine("using IDBI bank gateway for " + paymentSystem);
        }
    }
}
