internal class Account
{
    private double balance;
    private string num;

    public Account(string num)
    {
        this.num = num;
        this.balance = 0;
    }

    public Account(string num, double balance)
    {
        
        this.num = num;
        this.balance = balance;
    }

    public double GetBalance()
    {
        return this.balance;
    }

    public void SetBalance(double balance)
    {
        this.balance = balance;
    }

    public string GetNum()
    {
        return this.num;
    }

    public void SetNum(string num)
    {
        this.num = num;
    }
}