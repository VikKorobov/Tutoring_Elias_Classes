public class Bank
{
    public string name;
    public List<Account> accounts;
    public List<Client> clients;
    
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
}