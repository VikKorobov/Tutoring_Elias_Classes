internal class Account
{
    private double _balance;
    private string _num;

    public double Balance{get => _balance;}
    public string Num{get => _num.ToUpper();}

    public Account(string num)
    {
        _num = num.Trim().ToLower();
        _balance = 0;
    }

    public Account(string num, double balance)
    {
        
        _num = num.Trim().ToLower();
        _balance = balance;
    }
   

    public void Deposit(double amount)
    {
        _balance += amount;
    }

    public void Withdraw(double amount)
    {
        if (_balance >= amount) _balance -= amount;
        else throw new Exception("Not enough balance");
    }

}