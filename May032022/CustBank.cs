using System;
using System.Collections.Generic;
using System.Text;

namespace Assignments.May032022
{
    public class Customer
    {
        internal ushort CId { get; set; }
        internal string CName { get; set; }
        internal string CAddress { get; set; }       
        internal List<Accounts> acntlist = new List<Accounts>();
    }
    public class Accounts
    {
        internal string AccountType { get; set; }
        internal byte AccountNos { get; set; }
        internal List<Loan> loanlist = new List<Loan>();
    }
    public class Loan
    {
        internal string LoanType { get; set; }
    }
    class CustomerMain
    {
        static void Main(string[] args)
        {
            List<Customer> custlist = new List<Customer>()
            {
               new Customer { CId = 1001, CName = "Mr. A", CAddress = "Pune",
                acntlist = { new Accounts { AccountNos = 2, AccountType = "Savings", loanlist = { new Loan { LoanType = "Home Loan" } } } } },


            };
            foreach(Customer c in custlist)
            {
                Console.WriteLine($"ID: {c.CId}, Name: {c.CName}, Location: {c.CAddress}");
                foreach(Accounts a in c.acntlist)
                {
                    Console.WriteLine($"\n\thas {a.AccountNos} acount(s), \t{a.AccountType}");
                    foreach(Loan l in a.loanlist)
                    {
                        Console.WriteLine($"\n\tLoan: {l.LoanType}");
                    }
                }
            }
        }
    }
}
