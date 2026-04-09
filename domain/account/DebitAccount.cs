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

    private static double sanitizeOverdraftLimit(double overdraftLimit)
    {
        if (overdraftLimit < 0) throw new Exception("Overdraft limit must be non-negative");

        return overdraftLimit;
    }

    public static new DebitAccount Create(string number)
    {
        return new(number);
    }

    public static new DebitAccount Create(string number, double overdraftLimit)
    {
        return new(number, sanitizeOverdraftLimit(overdraftLimit));
    }

    public static DebitAccount Create(string number, double overdraftLimit, double balance)
    {
        return new(number, sanitizeOverdraftLimit(overdraftLimit), balance);
    }

    public override void Withdraw(double amount)
    {
        if (_balance + _overdraftLimit < amount) throw new Exception("Not enough balance and overdraft limit");
        
        _balance -= amount;
    }
}