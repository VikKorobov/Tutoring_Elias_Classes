internal class Client
{
    private string _firstName;
    private string _lastName;
    private List<Account> _accounts;

    public string FirstName { 

        get => styleName(_firstName); 
        set => _firstName = sanitizeName(value); 
    }

    public string LastName { 

        get => styleName(_lastName); 
        set => _lastName = sanitizeName(value); 
    }

    public List<Account> Accounts { get => _accounts; }

    private Client(string firstName, string lastName)
    {
        _firstName = firstName;
        _lastName = lastName;
        _accounts = new();
    }

    private Client(string firstName, string lastName, List<Account> accounts)
    {
        _firstName = firstName;
        _lastName = lastName;
        _accounts = accounts;
    }

    private static string styleName(string name)
    {
        var textInfo = new System.Globalization.CultureInfo("en-US", false).TextInfo;

        return textInfo.ToTitleCase(name);
    }

    private static string sanitizeName(string name)
    {
        name = name.Trim();

        if (name.Length < 2) throw new Exception("Name must be at least 2 characters long");

        if (name.Any(char.IsDigit)) throw new Exception("Name must not contain numbers");

        return name.ToLower();
    }

    public static Client Create(string firstName, string lastName)
    {
        return new(sanitizeName(firstName), sanitizeName(lastName));
    }

    public static Client Create(string firstName, string lastName, List<Account> accounts)
    {
        return new(sanitizeName(firstName), sanitizeName(lastName), accounts);
    }

    public void AddAccount(Account account)
    {
        _accounts.Add(account);
    }

    public void RemoveAccount(Account account)
    {
        _accounts.Remove(account);
    }
}