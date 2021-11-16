using System;

namespace AdapterDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {

            Payment payment = new CardPayment();
            payment._paymentSystem = new CitybankPayment();
            payment.MakePayment();
            payment._paymentSystem = new IDBIPaymentSystem();
            payment.MakePayment();

            payment = new NetBankingPayment();
            payment._paymentSystem = new CitybankPayment();
            payment.MakePayment();



            Console.ReadLine();
        }
    }
}
