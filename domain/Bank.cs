internal class Bank
{
    private string name;
    private List<Account> accounts;
    private List<Client> clients;
    
    public Bank(string name)
    {
        this.name = name;
        this.accounts = new();
        this.clients = new();
    }

    public Bank(string name, List<Account> accounts, List<Client> clients)
    {
        this.name = name;
        this.accounts = accounts;
        this.clients = clients;
    }

    public string GetName()
    {
        return this.name;
    }

    public void SetName(string name)
    {
        this.name = name;
    }

    public List<Account> GetAccounts()
    {
        return this.accounts;
    }

    public void SetAccounts(List<Account> accounts)
    {
        this.accounts = accounts;
    }

    public List<Client> GetClients()
    {
        
        return this.clients;
    }

    public void SetClients(List<Client> clients)
    {
        this.clients = clients;
    }
}