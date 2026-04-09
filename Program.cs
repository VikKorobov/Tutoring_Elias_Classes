var sparkasse = new Bank("Sparkasse");

var postbank = new Bank("Postbank");

var account_1 = new Account("1001 4646 4461 1564 45"); 
var account_2 = new Account("4546 0000 0000 4567 97", 1000);

var klaus = new Client("Klaus", "Möritz");

klaus.GetAccounts().Add(account_1);
sparkasse.GetAccounts().Add(account_1);
sparkasse.GetClients().Add(klaus);

var claudia = new Client("Claudia", "Möritz", klaus.GetAccounts());

account_1.SetBalance(account_1.GetBalance() + 100);
klaus.GetAccounts()[0].SetBalance(klaus.GetAccounts()[0].GetBalance() + 100);
claudia.GetAccounts()[0].SetBalance(claudia.GetAccounts()[0].GetBalance() + 100);
Console.WriteLine(klaus.GetAccounts()[0].GetBalance());
Console.WriteLine(claudia.GetAccounts()[0].GetBalance());
Console.WriteLine(sparkasse.GetAccounts()[0].GetBalance());
Console.WriteLine(sparkasse.GetClients()[0].GetAccounts()[0].GetBalance());


