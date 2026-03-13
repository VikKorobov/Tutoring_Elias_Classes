public class Client
{
    public string firstName;
    public string lastName;
    public List<Account> accounts;

    public Client(string firstName, string lastName)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.accounts = new();
    }
}