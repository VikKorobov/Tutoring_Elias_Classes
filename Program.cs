var someAccount = Account.Create("123456789012345678", 1000);
var someDebitAccount = DebitAccount.Create("123456789012345678", 500, 500);
var someSavingAccount = SavingAccount.Create("123456789012345678", 0.05, 900);

someSavingAccount.ApplyInterest(3);

var accounts = new List<Account> { someAccount, someDebitAccount, someSavingAccount };

foreach (var account in accounts)
{
    account.Withdraw(1000);
    Console.WriteLine($"Account number: {account.Num}, Balance: {account.Balance}");
}