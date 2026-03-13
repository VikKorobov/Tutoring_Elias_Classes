var sparkasse = new Bank("Sparkasse");

var postbank = new Bank("Postbank");

var account_1 = new Account("1001 4646 4461 1564 45"); 
var account_2 = new Account("4546 0000 0000 4567 97", 1000);

var klaus = new Client("Klaus", "Möritz");

klaus.accounts.Add(account_1);
sparkasse.accounts.Add(account_1);
sparkasse.clients.Add(klaus);

var claudia = new Client("Claudia", "Möritz", klaus.accounts);

account_1.balance += 100;
klaus.accounts[0].balance += 100;
claudia.accounts[0].balance += 100;
Console.WriteLine(klaus.accounts[0].balance);
Console.WriteLine(claudia.accounts[0].balance);
Console.WriteLine(sparkasse.accounts[0].balance);
Console.WriteLine(sparkasse.clients[0].accounts[0].balance);


