﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDesignPattern
{
   public interface IPaymentStream
    {
        void ProcessPayment(string paymentSystem);
    }
}
