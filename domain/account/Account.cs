internal abstract class Account
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

    // We can not use the static factory method in the abstract class, 
    // because we need to return an instance of a concrete class.
    // public static Account Create(string num)
    // {
    //     return new(sanitizeNum(num));
    // }

    // We can not use the static factory method in the abstract class, 
    // because we need to return an instance of a concrete class.
    // public static Account Create(string num, double balance)
    // {

    //     return new(sanitizeNum(num), balance);
    // }
   
    public virtual void Deposit(double amount)
    {
        _balance += amount;
    }

    public virtual void Withdraw(double amount)
    {
        if (_balance >= amount) _balance -= amount;
        else throw new Exception("Not enough balance");
    }

    public abstract void Transfer(Account target, double amount);
}