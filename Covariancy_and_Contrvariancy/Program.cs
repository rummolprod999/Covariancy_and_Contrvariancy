using System;

namespace Covariancy_and_Contrvariancy
{
    class Program
    {
        static void Main(string[] args)
        {
            // covariancy
            IBank<DepositAccount> depositBank = new Bank<DepositAccount>();
            Account acc1 = depositBank.CreateAccount(34);
            DepositAccount acc_1 = depositBank.CreateAccount(34);

            IBank<Account> ordinaryBank = new Bank<DepositAccount>();
            Account acc2 = ordinaryBank.CreateAccount(45);
            // DepositAccount acc_2 = ordinaryBank.CreateAccount(45);

            // contrvariancy
            ITransaction<Account> accTransaction = new Transaction<Account>();
            accTransaction.DoOperation(new Account(), 400);
            accTransaction.DoOperation(new DepositAccount(), 600);

            ITransaction<DepositAccount> depAccTransaction = accTransaction;
            depAccTransaction.DoOperation(new DepositAccount(), 450);
            // depAccTransaction.DoOperation(new  Account(), 500);
            Console.Read();
        }
    }
}