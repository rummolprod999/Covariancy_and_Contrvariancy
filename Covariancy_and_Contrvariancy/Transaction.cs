namespace Covariancy_and_Contrvariancy
{
    class Transaction<T> : ITransaction<T> where T : Account
    {
        public void DoOperation(T account, int sum)
        {
            account.DoTransfer(sum);
        }
    }
}