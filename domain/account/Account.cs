internal class Account
{
    protected double _balance;
    protected string _num;

    public double Balance{get => _balance;}
    public string Num{get => _num.ToUpper();}

    protected Account(string num)
    {
        _num = num;
        _balance = 0;
    }
    
    protected Account(string num, double balance)
    {
        _num = num;
        _balance = balance;
    }

    private static string sanitizeNum(string num)
    {
        num = num.Trim();

        if (num.Length != 18) throw new Exception("Account number must be 18 characters long");

        if (!num.All(c => char.IsDigit(c) || char.IsWhiteSpace(c))) throw new Exception("Account number must only contain digits and spaces");

        return num;
    }

    public static Account Create(string num)
    {
        return new(sanitizeNum(num));
    }

    public static Account Create(string num, double balance)
    {

        return new(sanitizeNum(num), balance);
    }
   
    public virtual void Deposit(double amount)
    {
        _balance += amount;
    }

    public virtual void Withdraw(double amount)
    {
        if (_balance >= amount) _balance -= amount;
        else throw new Exception("Not enough balance");
    }

}