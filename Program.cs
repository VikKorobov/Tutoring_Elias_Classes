var sparkasse = Bank.Create("Sparkasse");

var postbank = Bank.Create("Postbank");

var account_1 = Account.Create("1001 4646 4461 1564 45"); 
var account_2 = Account.Create("4546 0000 0000 4567 97", 1000);

var klaus = Client.Create("    kLaUs Günter  ", "Möritz");

klaus.AddAccount(account_1);
sparkasse.AddAccount(account_1);
sparkasse.AddClient(klaus);

var claudia = Client.Create("Claudia", "Möritz", klaus.Accounts);

account_1.Deposit(100);
klaus.Accounts[0].Deposit(100);
claudia.Accounts[0].Deposit(100);
Console.WriteLine(klaus.Accounts[0].Balance);
Console.WriteLine(claudia.Accounts[0].Balance);
Console.WriteLine(sparkasse.Accounts[0].Balance);
Console.WriteLine(sparkasse.Clients[0].Accounts[0].Balance);


Console.WriteLine(klaus.FirstName);