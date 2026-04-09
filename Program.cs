Account someDebitAccount = DebitAccount.Create("123456789012345678", 500, 700);
var someSavingAccount = SavingAccount.Create("123456789012345678", 0.05, 700);


someDebitAccount.Transfer(someSavingAccount, 200);
someSavingAccount.ApplyInterest(3);

var accounts = new List<Account> { someDebitAccount, someSavingAccount };

foreach (var account in accounts)
{
    account.Withdraw(1000);
    Console.WriteLine($"Account number: {account.Num}, Balance: {account.Balance}");
}