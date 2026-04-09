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

    private static double sanitizeInterestRate(double interestRate)
    {
        if (interestRate > 0 && interestRate < 1) throw new Exception("Interest rate must be a positive value between 0 and 1");

        return interestRate;
    }

    public static new SavingAccount Create(string number)
    {
        return new(number);
    }

    public static new SavingAccount Create(string number, double interestRate)
    {
        return new(number, sanitizeInterestRate(interestRate));
    }

    public static SavingAccount Create(string number, double interestRate, double balance)
    {
        return new(number, sanitizeInterestRate(interestRate), balance);
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
}