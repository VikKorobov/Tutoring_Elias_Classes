internal class DebitAccount : Account
{
    private double _overdraftLimit;

    public double OverdraftLimit { get => _overdraftLimit; set => _overdraftLimit = sanitizeOverdraftLimit(value); }

    private DebitAccount(string number) : base(number)
    {
        _overdraftLimit = 0;
    }

    private DebitAccount(string number, double overdraftLimit) : base(number)
    {
        _overdraftLimit = overdraftLimit;
    }

    private DebitAccount(string number, double overdraftLimit, double balance) : base(number, balance)
    {
        _overdraftLimit = overdraftLimit;
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

    public override void Withdraw(double amount)
    {
        if (_balance + _overdraftLimit < amount) throw new Exception("Not enough balance and overdraft limit");
        
        _balance -= amount;
    }

    public override void Transfer(Account target, double amount)
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
}