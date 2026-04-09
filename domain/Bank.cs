internal class Bank
{
    private string name;
    private List<Account> accounts;
    private List<Client> clients;
    
    public Bank(string name)
    {
        this.name = name.Trim().ToLower();
        this.accounts = new();
        this.clients = new();
    }

    public Bank(string name, List<Account> accounts, List<Client> clients)
    {
        this.name = name.Trim().ToLower();
        this.accounts = accounts;
        this.clients = clients;
    }

    public void AddAccount(Account account)
    {
        this.accounts.Add(account);
    }

    public void AddClient(Client client)
    {
        this.clients.Add(client);
    }

    public void RemoveAccount(Account account)
    {
        this.accounts.Remove(account);
    }

    public void RemoveClient(Client client)
    {
        this.clients.Remove(client);
    }

    public string GetName()
    {
        var textInfo = new System.Globalization.CultureInfo("en-US", false).TextInfo;

        return textInfo.ToTitleCase(this.name);
    }

    // removed setter for name,
    // because it should not be possible to change the name of the bank
    // public void SetName(string name)
    // {
    //     this.name = name;
    // }

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

    public List<Client> GetClients()
    {
        
        return this.clients;
    }

    // removed setter for clients,
    // because it should not be possible to set the clients directly
    // public void SetClients(List<Client> clients)
    // {
    //     this.clients = clients;
    // }
}