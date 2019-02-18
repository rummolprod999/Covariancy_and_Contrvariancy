namespace Covariancy_and_Contrvariancy
{
    public interface IBank<out T>
    {
         T CreateAccount(int sum);
    }
}