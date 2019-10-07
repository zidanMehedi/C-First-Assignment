using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account1 = new DebitAccount(1, "Shuvo", new OurDate(12, 06, 2019), 25000, "Tongi");
            Account account3 = new DebitAccount(2, "Sohan", new OurDate(13, 06, 2019), 10000, "Kuril");
            Account account2 = new CreditAccount(3, "Numan", new OurDate(18, 06, 2019), 50000, 20000);
            account1.Deposit(12000);
            account1.Withdraw(20000);
            account2.Deposit(1000);
            account2.Withdraw(60000);
            account1.Transfer(account3, 2000);
            account1.ShowDetails(); account2.ShowDetails(); account3.ShowDetails();
        }
    }
}
