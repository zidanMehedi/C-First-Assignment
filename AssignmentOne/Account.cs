using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOne
{
    struct OurDate
    {
       internal byte day;
       internal byte month;
       internal ushort year;

       public OurDate(byte day, byte month, ushort year)
       {
           this.day = day;
           this.month = month;
           this.year = year;
       }

       internal void ShowDate()
       {
           Console.WriteLine("{0}/{1}/{2}", day, month, year);
       }
    }
    class Account
    {
        private string name;
        private int id;
        private double balance;
        private OurDate accountOpeningDate;

        internal string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        internal int Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

        internal double Balance
        {
            get { return this.balance; }
            set { this.balance = value; }
        }

        internal OurDate AccountOpeningDate
        {
            get { return this.accountOpeningDate; }
            set { this.accountOpeningDate = value; }
        }

        public Account(int id, string name, OurDate accountOpeningDate, double balance)
        {
            this.Name = name;
            this.Id = id;
            this.AccountOpeningDate = accountOpeningDate;
            this.Balance = balance;
        }

        internal virtual void Deposit(double depositeAmount)
        {
            this.Balance += depositeAmount;
            //Console.WriteLine("Deposite Successful!!");
        }

        internal virtual void Withdraw(double withdrawAmount)
        {
            this.Balance -= withdrawAmount;
            //Console.WriteLine("Withdraw Successful!!");
        }

        internal virtual void Transfer(Account targetAccount, double amount)
        {
            if (amount > this.Balance)
            {
                Console.WriteLine("Transfer Unsuccessful!!\n");
            }
            else
            {
                targetAccount.Balance += amount;
                this.Balance -= amount;
                Console.WriteLine("Transfer Successful!!\n");
            }
                
        }

        internal virtual void ShowDetails()
        {
            Console.WriteLine("Name : {0}", this.Name);
            Console.WriteLine("ID : {0}", this.Id);
            Console.Write("Account Opening Date : ");
            accountOpeningDate.ShowDate();
            Console.WriteLine("Balance : {0}", this.Balance);

        }

    }
}
