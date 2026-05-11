internal class DebitAccount : IDebit
{
    private double _overdraftLimit;
    private double _balance;
    private string _num;

    public double OverdraftLimit { get => _overdraftLimit; set => _overdraftLimit = sanitizeOverdraftLimit(value); }

    public double Balance {get => _balance;}

    public string Num {get => _num;}


    private DebitAccount(string num, double overdraftLimit = 0, double balance = 0)
    {
        _num = num;
        _overdraftLimit = overdraftLimit;
        _balance = balance;
    }

    protected static string sanitizeNum(string num)
    {
        num = num.Trim();

        if (num.Length != 18) throw new Exception("Account number must be 18 characters long");

        if (!num.All(c => char.IsDigit(c) || char.IsWhiteSpace(c))) throw new Exception("Account number must only contain digits and spaces");

        return num;
    }

    private static double sanitizeOverdraftLimit(double overdraftLimit)
    {
        if (overdraftLimit < 0) throw new Exception("Overdraft limit must be non-negative");

        return overdraftLimit;
    }

    public static DebitAccount Create(string number)
    {
        return new(sanitizeNum(number));
    }

    public static DebitAccount Create(string number, double overdraftLimit)
    {
        return new(sanitizeNum(number), sanitizeOverdraftLimit(overdraftLimit));
    }

    public static DebitAccount Create(string number, double overdraftLimit, double balance)
    {
        return new(sanitizeNum(number), sanitizeOverdraftLimit(overdraftLimit), balance);
    }

    public void Withdraw(double amount)
    {
        if (_balance + _overdraftLimit < amount) throw new Exception("Not enough balance and overdraft limit");
        
        _balance -= amount;
    }

    public void Transfer(IAccount target, double amount)
    {
        if (_balance < amount) throw new Exception("Not enough balance");
        
            _balance -= amount;

        try{

            target.Deposit(amount);
        }
        catch (Exception){

            _balance += amount;
            throw new Exception("Transfer failed");
        }     
        
    }

    public void Deposit(double amount)
    {
        _balance += amount;
    }
}