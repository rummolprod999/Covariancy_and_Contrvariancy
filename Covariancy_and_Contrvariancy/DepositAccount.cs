using System;

namespace Covariancy_and_Contrvariancy
{
    public class DepositAccount: Account
    {
        public override void DoTransfer(int sum)
        {
            Console.WriteLine($"Клиент положил на депозитный счет {sum} долларов");
        }
    }
}