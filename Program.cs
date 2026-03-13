var sparkasse = new Bank("Sparkasse");

var postbank = new Bank("Postbank");

var account_1 = new Account("1001 4646 4461 1564 45"); 

var klaus = new Client("Klaus", "Möritz");

klaus.accounts.Add(account_1);
sparkasse.accounts.Add(account_1);
sparkasse.clients.Add(klaus);

// account_1.balance += 100;
// Console.WriteLine(klaus.accounts[0].balance);
// Console.WriteLine(sparkasse.accounts[0].balance);
// Console.WriteLine(sparkasse.clients[0].accounts[0].balance);

Console.WriteLine(String.IsNullOrEmpty(postbank.name));
Console.WriteLine(postbank.accounts is null);
Console.WriteLine(postbank.clients is null);
