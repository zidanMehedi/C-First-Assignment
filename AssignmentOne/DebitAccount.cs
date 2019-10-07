using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOne
{
    class DebitAccount : Account
    {
        private string branchName;
        internal ushort minBalance = 1000;

        internal string BranchName
        {
            get { return this.branchName; }
            set { this.branchName = value; }
        }

        public DebitAccount(int id, string name, OurDate accountOpeningDate, double balance, string branchName)
            : base(id, name, accountOpeningDate, balance)
        {
            this.BranchName = branchName;
        }

        internal override void Deposit(double depositeAmount)
        {
            if (depositeAmount <= 20000)
            {
                base.Deposit(depositeAmount);
                Console.WriteLine("Deposite Successful!!\n");
            }
            else
                Console.WriteLine("Maximum Deposit Amount Exceeds\n");
             
        }

        internal override void Withdraw(double withdrawAmount)
        {
            if ((this.Balance - withdrawAmount) < minBalance)
            {
                Console.WriteLine("Insufficinet Balance!!\n");
            }
            else
            {
                base.Withdraw(withdrawAmount);
                Console.WriteLine("Withdraw Successful!!\n");
            }
            
        }

        internal void Transfer(DebitAccount targetAccount, double amount)
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
            Console.WriteLine("Branch : {0}", this.BranchName);
            Console.WriteLine();
            
        }
    }
}
