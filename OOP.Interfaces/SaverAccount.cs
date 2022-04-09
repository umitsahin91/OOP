using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Interfaces
{
    public class SaverAccount : IBankAccount
    {
        private decimal _balance;
        public decimal Balance => _balance;

        public void PayIn(decimal amount)=> _balance += amount;

        public bool Withdraw(decimal amount)
        {

            if (_balance>= amount)
            {
                _balance -= amount;
                return true;
            }
            Console.WriteLine("Withdraw attemp failed");
            return false;
        }
        public override string ToString() => $"Bank Saver : Balance = {_balance}";
        
    }
}
