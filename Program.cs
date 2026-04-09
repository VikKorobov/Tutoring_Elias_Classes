var sparkasse = new Bank("Sparkasse");

var postbank = new Bank("Postbank");

var account_1 = new Account("1001 4646 4461 1564 45"); 
var account_2 = new Account("4546 0000 0000 4567 97", 1000);

var klaus = new Client("    kLaUs Günter  ", "Möritz");

klaus.AddAccount(account_1);
sparkasse.AddAccount(account_1);
sparkasse.AddClient(klaus);

var claudia = new Client("Claudia", "Möritz", klaus.Accounts);

account_1.Deposit(100);
klaus.Accounts[0].Deposit(100);
claudia.Accounts[0].Deposit(100);
Console.WriteLine(klaus.Accounts[0].Balance);
Console.WriteLine(claudia.Accounts[0].Balance);
Console.WriteLine(sparkasse.Accounts[0].Balance);
Console.WriteLine(sparkasse.Clients[0].Accounts[0].Balance);


Console.WriteLine(klaus.FirstName);