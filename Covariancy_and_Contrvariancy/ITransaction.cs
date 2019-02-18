namespace Covariancy_and_Contrvariancy
{
    interface ITransaction<in T>
    {
        void DoOperation(T account, int sum);
    }
}