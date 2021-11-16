using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDesignPattern
{
   public  abstract class Payment
    {
        public IPaymentStream _paymentSystem;
        public abstract void MakePayment();
       
    }
}
