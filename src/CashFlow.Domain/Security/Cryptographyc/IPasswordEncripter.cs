namespace CashFlow.Domain.Security.Cryptographyc
{
    public interface IPasswordEncripter
    {
        string Encrypt(string password);
    }
}

