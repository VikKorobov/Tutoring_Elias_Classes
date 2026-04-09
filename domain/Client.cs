internal class Client
{
    private string firstName;
    private string lastName;
    private List<Account> accounts;

    public Client(string firstName, string lastName)
    {
        this.firstName = firstName.Trim().ToLower();
        this.lastName = lastName.Trim().ToLower();
        this.accounts = new();
    }

    public Client(string firstName, string lastName, List<Account> accounts)
    {
        this.firstName = firstName.Trim().ToLower();
        this.lastName = lastName.Trim().ToLower();
        this.accounts = accounts;
    }

    public void AddAccount(Account account)
    {
        this.accounts.Add(account);
    }

    public void RemoveAccount(Account account)
    {
        this.accounts.Remove(account);
    }

    public string GetFirstName()
    {
        var textInfo = new System.Globalization.CultureInfo("en-US", false).TextInfo;

        return textInfo.ToTitleCase(this.firstName);
    }

    public void SetFirstName(string firstName)
    {
        firstName = firstName.Trim();

        if (firstName.Length < 2) throw new Exception("First name must be at least 2 characters long");

        if (firstName.Any(char.IsDigit)) throw new Exception("First name must not contain numbers");

        this.firstName = firstName.ToLower();
    }

    public string GetLastName()
    {
        var textInfo = new System.Globalization.CultureInfo("en-US", false).TextInfo;

        return textInfo.ToTitleCase(this.lastName);
    }

    public void SetLastName(string lastName)
    {
        lastName = lastName.Trim();

        if (lastName.Length < 2) throw new Exception("Last name must be at least 2 characters long");

        if (lastName.Any(char.IsDigit)) throw new Exception("Last name must not contain numbers");

        this.lastName = lastName.ToLower();
    }

    public List<Account> GetAccounts()
    {
        return this.accounts;
    }

    // removed setter for accounts,
    // because it should not be possible to set the accounts directly
    // public void SetAccounts(List<Account> accounts)
    // {
    //     this.accounts = accounts;
    // }
}