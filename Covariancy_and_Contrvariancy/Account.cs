using System;

namespace Covariancy_and_Contrvariancy
{
    public class Account
    {
        public virtual void DoTransfer(int sum)
        {
            Console.WriteLine($"Клиент положил на счет {sum} долларов");
        }
    }
}