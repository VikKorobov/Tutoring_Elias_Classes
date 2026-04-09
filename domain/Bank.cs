internal class Bank
{
    private string _name;
    private List<Account> _accounts;
    private List<Client> _clients;

    public string Name { get => styleName(_name); }
    public List<Account> Accounts { get => _accounts; }
    public List<Client> Clients { get => _clients; }
    
    private Bank(string name)
    {
        _name = name;
        _accounts = new();
        _clients = new();
    }

    private Bank(string name, List<Account> accounts, List<Client> clients)
    {
        _name = name;
        _accounts = accounts;
        _clients = clients;
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

        return name.ToLower();
    }

    public static Bank Create(string name)
    {
        return new(sanitizeName(name));
    }

    public static Bank Create(string name, List<Account> accounts, List<Client> clients)
    {
        return new(sanitizeName(name), accounts, clients);
    }

    public void AddAccount(Account account)
    {
        _accounts.Add(account);
    }

    public void AddClient(Client client)
    {
        _clients.Add(client);
    }

    public void RemoveAccount(Account account)
    {
        _accounts.Remove(account);
    }

    public void RemoveClient(Client client)
    {
        _clients.Remove(client);
    }
}