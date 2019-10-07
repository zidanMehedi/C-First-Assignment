using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOne
{
    class CreditAccount : Account
    {
        private double maxLimit;

        internal double MaxLimit
        {
            get { return this.maxLimit; }
            set { this.maxLimit = value; }
        }

        public CreditAccount(int id, string name, OurDate accountOpeningDate, double balance, double maxLimit)
            : base(id, name, accountOpeningDate, balance)
        {
            this.MaxLimit = maxLimit;
        }

        internal override void Deposit(double depositeAmount)
        {
            base.Deposit(depositeAmount);
            Console.WriteLine("Deposite Successful!!\n");
        }

        internal override void Withdraw(double withdrawAmount)
        {
            if (withdrawAmount > this.MaxLimit)
                Console.WriteLine("Maximum Credit Limit Exceeds\n");
            else
            {
                base.Withdraw(withdrawAmount);
                Console.WriteLine("Withdraw Successful!!\n");
            }
        }

        internal void Transfer(CreditAccount targetAccount, double amount)
        {
            targetAccount.Balance += amount;
            this.Balance -= amount;
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

        internal override void ShowDetails()
        {
           
            base.ShowDetails();
            Console.WriteLine();
        }
    }
}
