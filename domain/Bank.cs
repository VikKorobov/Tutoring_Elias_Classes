internal class Bank
{
    private string _name;
    private List<Account> _accounts;
    private List<Client> _clients;

    public string Name { get => styleName(_name); }
    public List<Account> Accounts { get => _accounts; }
    public List<Client> Clients { get => _clients; }
    
    public Bank(string name)
    {
        _name = name.Trim().ToLower();
        _accounts = new();
        _clients = new();
    }

    public Bank(string name, List<Account> accounts, List<Client> clients)
    {
        _name = name.Trim().ToLower();
        _accounts = accounts;
        _clients = clients;
    }

    private static string styleName(string name)
    {
        var textInfo = new System.Globalization.CultureInfo("en-US", false).TextInfo;

        return textInfo.ToTitleCase(name);
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