using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDesignPattern
{
    public class NetBankingPayment : Payment
    {
        public override void MakePayment()
        {
            _paymentSystem.ProcessPayment("Net banking payment");
        }
    }
}
