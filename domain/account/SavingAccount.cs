internal class SavingAccount : ISavingAccount
{
    private double _interestRate;

    private double _balance;

    private string _num;

    public double InterestRate { get => _interestRate; set => _interestRate = sanitizeInterestRate(value); }

    public double Balance {get => _balance;}

    public string Num{get => _num;}

    private SavingAccount(string num, double interestRate = 0, double balance = 0)
    {
        _num = num;
        _balance = balance;
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

    public void Withdraw(double amount)
    {
        if(amount > _balance) throw new Exception("Amount can't exceed balance!");

        _balance -= amount;
    }
}