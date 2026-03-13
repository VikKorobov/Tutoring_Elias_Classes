public class Account
{
    public double balance;
    public string num;

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
}