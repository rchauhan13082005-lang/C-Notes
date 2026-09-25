using System;
using System.Collections.Generic;
using System.Text;

namespace C_Notes.Chapter_3
{
    public interface IPayment
    {
        void pay(double amount);
    }
    public class UPIPayment : IPayment
    {
        public void pay(double amount)
        {
            Console.WriteLine($"₹{amount} is paid by UPI");
        }
    }
    public class CraditCard : IPayment
    {
        public void pay(double amount)
        {
            Console.WriteLine($"₹{amount} is paid by CraditCard");
        }
    }
    public class DebitCard : IPayment
    {
        public void pay(double amount)
        {
            Console.WriteLine($"₹{amount} is paid by DebitCard");
        }
    }

    public class Employee
    {
        public void Work()
        {
            Console.WriteLine("Employee is Working");
        }
    }
    public class Admin : Employee
    {
        public new void Work()
        {
            Console.WriteLine("Admin is managing wokrs");
        }
    }

    class Program
    {
        static void Main()
        {
            IPayment payment;

            payment = new UPIPayment();
            payment.pay(30000);

            payment = new CraditCard();
            payment.pay(10000);

            payment = new DebitCard();
            payment.pay(10000);
        }
    }
}
