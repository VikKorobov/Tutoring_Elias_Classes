public interface IAccount
{
    double Balance{get;}

    string Num{get;}

    void Deposit(double amount);

    void Withdraw(double amount);

    void Transfer(IAccount target, double amount);
}