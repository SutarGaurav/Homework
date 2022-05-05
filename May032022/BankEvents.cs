using System;
using System.Collections.Generic;
using System.Text;

namespace Assignments.May032022
{
    class Bank
    {
        internal long CurBal;
        internal delegate void BankDelegate();
        public event BankDelegate ZeroBalEvent;
        public event BankDelegate LowBalEvent;
        internal void Withdraw(long a)
        {
            
            if (CurBal == 0)
                ZeroBalEvent();
            else if (CurBal < a)
                LowBalEvent();
            else
                CurBal = CurBal - a;
            Console.WriteLine($"Current balance is {CurBal}");
        }
    }
    class BankMain
    {
        static void LBE()
        {
            Console.WriteLine("Do your math and come back again");
        }
        static void ZBE()
        {
            Console.WriteLine("Balance is zero.");
        }
        static void Main(string[] args)
        {
            Bank c1 = new Bank();
            c1.LowBalEvent += new Bank.BankDelegate(LBE);
            c1.ZeroBalEvent += new Bank.BankDelegate(ZBE);            
            c1.CurBal = 250000000L;
            Console.WriteLine("enter amount you want to withdraw");
            long amt = long.Parse(Console.ReadLine());
            c1.Withdraw(amt);
        }
    }
}
