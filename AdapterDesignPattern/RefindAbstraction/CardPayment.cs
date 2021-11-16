using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDesignPattern
{
    public class CardPayment : Payment
    {
        public override void MakePayment()
        {
            _paymentSystem.ProcessPayment("Card payment");   
        }
    }
}
