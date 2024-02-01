using System;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Cashier c = new Cashier(new Cash());
            Cashier c2 = new Cashier(new MasterCard());

            c.Checkout(9999999m);
            c2.Checkout(91999999m);

            Console.ReadKey();
        }
    }


    class Cashier
    {
        private IPayment _payment;

        public Cashier(IPayment payment)
        {
            _payment = payment;
        }

        public void Checkout(decimal amount)
        {
            _payment.Pay(amount);
        }
    }

    interface IPayment
    {
        void Pay(decimal amount);   
    }


    class Cash:IPayment
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Cash Payment: ${amount}");
        }
    }

    class Debit : IPayment
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Debit Payment: ${amount}");
        }
    }

    class MasterCard : IPayment
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"MasterCard Payment: ${amount}");
        }
    }

    class Visa : IPayment
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Visa Payment: ${amount}");
        }
    }
}