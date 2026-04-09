var sparkasse = Bank.Create("Sparkasse");

var postbank = Bank.Create("Postbank");

var account_1 = Account.Create("1001 46464461 1564"); 
var account_2 = DebitAccount.Create("4546 00000000 4567", 1000);

var klaus = Client.Create("    kLaUs Günter  ", "Möritz");

klaus.AddAccount(account_1);
klaus.AddAccount(account_2);
sparkasse.AddAccount(account_1);
sparkasse.AddClient(klaus);

var claudia = Client.Create("Claudia", "Möritz", klaus.Accounts);

account_1.Deposit(100);
klaus.Accounts[0].Deposit(100);
claudia.Accounts[0].Deposit(100);
klaus.Accounts[1].Withdraw(500);
Console.WriteLine(klaus.Accounts[0].Balance);
Console.WriteLine(claudia.Accounts[0].Balance);
Console.WriteLine(sparkasse.Accounts[0].Balance);
Console.WriteLine(sparkasse.Clients[0].Accounts[0].Balance);


Console.WriteLine(klaus.FirstName);
Console.WriteLine(klaus.Accounts[1].Balance);