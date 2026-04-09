internal class Client
{
    private string firstName;
    private string lastName;
    private List<Account> accounts;

    public Client(string firstName, string lastName)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.accounts = new();
    }

    public Client(string firstName, string lastName, List<Account> accounts)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.accounts = accounts;
    }

    public string GetFirstName()
    {
        return this.firstName;
    }

    public void SetFirstName(string firstName)
    {
        this.firstName = firstName;
    }

    public string GetLastName()
    {
        return this.lastName;
    }

    public void SetLastName(string lastName)
    {
        this.lastName = lastName;
    }

    public List<Account> GetAccounts()
    {
        return this.accounts;
    }

    public void SetAccounts(List<Account> accounts)
    {
        this.accounts = accounts;
    }
}