internal class Account
{
    private double balance;
    private string num;

    public Account(string num)
    {
        this.num = num.Trim().ToLower();
        this.balance = 0;
    }

    public Account(string num, double balance)
    {
        
        this.num = num.Trim().ToLower();
        this.balance = balance;
    }

    public void Deposit(double amount)
    {
        this.balance += amount;
    }

    public void Withdraw(double amount)
    {
        if (this.balance >= amount) this.balance -= amount;
        else throw new Exception("Not enough balance");
    }

    public double GetBalance()
    {
        return this.balance;
    }

    // removed setter for balance,
    // because it should not be possible to set the balance directly
    // public void SetBalance(double balance)
    // {
    //     this.balance = balance;
    // }

    public string GetNum()
    {
        return this.num.ToUpper();
    }

    // removed setter for num, 
    // because it should not be possible to change the account number 
    // public void SetNum(string num)
    // {
    //     this.num = num;
    // }
}