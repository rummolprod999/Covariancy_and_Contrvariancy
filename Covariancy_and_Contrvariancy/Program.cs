using System;

namespace Covariancy_and_Contrvariancy
{
    class Program
    {
        static void Main(string[] args)
        {
            IBank<DepositAccount> depositBank = new Bank<DepositAccount>();
            Account acc1 = depositBank.CreateAccount(34);

            IBank<Account> ordinaryBank = new Bank<DepositAccount>();
            Account acc2 = ordinaryBank.CreateAccount(45);
            ITransaction<Account> accTransaction = new Transaction<Account>();
            accTransaction.DoOperation(new Account(), 400);

            ITransaction<DepositAccount> depAccTransaction = new Transaction<Account>();
            depAccTransaction.DoOperation(new DepositAccount(), 450);
            Console.Read();
        }
    }
}