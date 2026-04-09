internal class SavingAccount : Account
{
    private double _interestRate;

    public double InterestRate { get => _interestRate; set => _interestRate = sanitizeInterestRate(value); }

    private SavingAccount(string number) : base(number)
    {
        _interestRate = 0;
    }

    private SavingAccount(string number, double interestRate) : base(number)
    {
        _interestRate = interestRate;
    }

    private SavingAccount(string number, double interestRate, double balance) : base(number, balance)
    {
        _interestRate = interestRate;
    }

    protected static string sanitizeNum(string num)
    {
        num = num.Trim();

        if (num.Length != 18) throw new Exception("Account number must be 18 characters long");

        if (!num.All(c => char.IsDigit(c) || char.IsWhiteSpace(c))) throw new Exception("Account number must only contain digits and spaces");

        return num;
    }

    private static double sanitizeInterestRate(double interestRate)
    {
        if (interestRate < 0 || interestRate > 1) throw new Exception("Interest rate must be a positive value between 0 and 1");

        return interestRate;
    }

    public static SavingAccount Create(string number)
    {
        return new(sanitizeNum(number));
    }

    public static SavingAccount Create(string number, double interestRate)
    {
        return new(sanitizeNum(number), sanitizeInterestRate(interestRate));
    }

    public static SavingAccount Create(string number, double interestRate, double balance)
    {
        return new(sanitizeNum(number), sanitizeInterestRate(interestRate), balance);
    }

    public void ApplyInterest()
    {
        _balance += _balance * _interestRate;
    }

    public void ApplyInterest(int months)
    {
        for (int i = 0; i < months; i++)
        {
            ApplyInterest();
        }
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