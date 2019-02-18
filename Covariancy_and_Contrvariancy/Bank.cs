namespace Covariancy_and_Contrvariancy
{
    class Bank<T> : IBank<T> where T : Account, new()
    {
        public T CreateAccount(int sum)
        {
            T acc = new T();  // создаем счет
            acc.DoTransfer(sum);
            return acc;
        }
    }
}