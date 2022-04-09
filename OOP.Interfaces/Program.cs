using System;

namespace OOP.Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            var saver = new SaverAccount();
            saver.PayIn(500);
            saver.Withdraw(300);
            saver.Withdraw(500);
            Console.WriteLine("Current balance : "+saver.Balance);
            Console.WriteLine(saver);
        }
    }
}
