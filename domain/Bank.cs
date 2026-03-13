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
}